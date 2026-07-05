# AGENTS.md

## Project Overview

ASP.NET Core MVC (.NET 9) management system with a Clean Architecture-inspired layout.
Solution: `ManagementSystemMVC.sln`, single project: `WebApp/WebApp.csproj`.
PostgreSQL via EF Core (`Npgsql.EntityFrameworkCore.PostgreSQL`), `ErrorOr` for result types, `BCrypt.Net-Next` for password hashing.

## Build, Run, and Test Commands

```bash
# Build
dotnet build
dotnet build WebApp/WebApp.csproj

# Run (development server)
dotnet run --project WebApp
# Launch profiles: http (port 5213) and https (port 7263)

# Tests (no test project exists yet)
dotnet test

# EF Core
dotnet ef migrations add <MigrationName> --project WebApp
dotnet ef database update --project WebApp
dotnet ef migrations remove --project WebApp

# Package management
dotnet add WebApp/WebApp.csproj package <PackageName>
dotnet list package --project WebApp
```

There is no linter, formatter, or analyzer configuration (no `.editorconfig`, StyleCop, or Roslyn Analyzer rulesets). If adding one, use the standard .NET defaults.

## Project Architecture

```
WebApp/
├── Controllers/        # MVC controllers (thin, delegate to use cases)
├── UseCases/           # Business logic layer, organized by domain
│   ├── Interfaces/     #   Repository interfaces (IUserRepository, etc.)
│   └── *Cases/         #   Use case impls + their own Interfaces/ subfolder
├── Repositories/       # EF Core repository implementations
├── Entities/           # Domain entities (inherit BaseCommon)
├── Models/             # ViewModels (used in Razor views, not EF models)
├── EfConfiguration/    # DbContext + IEntityTypeConfiguration classes
│   └── ModelsConfiguration/
├── Exceptions/         # ErrorOr error definitions (partial static Errors class)
├── Common/             # Shared base classes (BaseCommon)
└── Views/              # Razor .cshtml views, _ViewImports, _ViewStart
```

**Dependency direction:** Controllers → UseCases → Repositories (via interfaces in `UseCases/Interfaces`).

## Code Style

### Naming

| Element | Convention | Example |
|---------|-----------|---------|
| Classes | PascalCase | `UserRepository` |
| Interfaces | `I` + PascalCase | `IUserRepository` |
| Use case classes | `View` + PascalCase verb | `ViewCreateUser` |
| Use case interfaces | `I` + class name | `IViewCreateUser` |
| ViewModels | PascalCase + `VM` suffix | `CreateUserVM` |
| Private fields | `_camelCase` | `_userRepository` |
| Method parameters | camelCase | `Guid userId` |
| Local variables | camelCase | `var newUser` |
| Async methods | `Task` return, named with `Async` or action | `AddAsync`, `ExecuteAsync` |
| Entity IDs | PascalCase `Id` with `Guid` type | `public Guid Id` |

### Formatting

- **2-space indentation** throughout (no tabs).
- **Braces on same line** (K&R style).
- **File-scoped namespaces** with braces (block style, not semicolon).
- `using` directives go **inside** the namespace block.
- One blank line between `using` block and class declaration.
- Constructors: each parameter on its own line, closing paren on its own line.
- Single empty line at end of file.

### Nullability and Types

- Nullable reference types are **enabled** (`<Nullable>enable</Nullable>` in .csproj).
- Use `string?` only when a value genuinely may be absent.
- Navigation property collections: `ICollection<T>?` (nullable by design).
- Single navigation props: `RelatedEntity?` (nullable).
- Foreign key IDs: non-nullable `Guid` (e.g., `public Guid UserId`).

### Imports

- Always use the `WebApp.*` namespace path rooted at the project.
- Keep imports sorted into groups: framework (`Microsoft.*`, `System.*`) first, then project (`WebApp.*`), then third-party (`ErrorOr`).
- Remove unused imports.

### Entity Classes

- Every entity inherits `BaseCommon` (provides `CreatedAt`, `CreatedBy`, `UpdatedAt`, `UpdatedBy`, `IsDeleted`).
- Entities use a **primary constructor** receiving all fields.
- Properties are `public { get; set; }` auto-properties.
- Navigation properties are declared near the bottom, grouped under `//relations`.

### Error Handling

- Errors are defined in `Exceptions/Errors.*.cs` as `public static partial class Errors` with nested `Error` properties using `ErrorOr.Error.*()` factory methods.
- UseCases return `ErrorOr<T>` to signal success or failure.
- Validate inputs at the UseCase layer and return `Errors.*` on failure.
- Do not throw exceptions for domain/logic errors; only for truly exceptional conditions.

### Repositories

- Declare interface in `UseCases/Interfaces/`, implement in `Repositories/`.
- Generic method templates: `Task AddAsync(T)`, `void Update(T)`, `void Disabled(T)` (soft-deletes via `IsDeleted = true`), `Task<T?> GetByIdAsync(Guid)`, `Task<List<T>> GetAllAsync()`.
- Register in `Program.cs` with `builder.Services.AddTransient<I*, *>();`.
- `AddAsync` and `GetAllAsync`/`GetByIdAsync` are async; `Update` and `Disabled` are synchronous.
- Use `AsNoTracking()` on read-only queries.

### Entity Framework Configuration

- `ApplicationDbContext` in `EfConfiguration/` exposes `DbSet<T>` for each tracked entity.
- `OnModelCreating` calls `modelBuilder.ApplyConfigurationsFromAssembly(...)` for discovery, then defines remaining relationships inline.
- Per-entity configuration classes in `EfConfiguration/ModelsConfiguration/` implement `IEntityTypeConfiguration<T>`:
  - Call `builder.ToTable("PluralTableName")`
  - Define `HasKey`, `HasIndex(IsUnique)`, `Property(HasMaxLength)`, `Property(IsRequired)`

### Dependency Injection

- Constructor injection only (no property injection or service locator).
- Add services in `Program.cs` between `AddControllersWithViews()` and `Build()`.
- Repository lifetime: `AddTransient`.
- DbContext lifetime: default scoped from `AddDbContext`.

### Views (Razor)

- All views use `@model` with a strongly-typed ViewModel from `WebApp.Models`.
- Shared layout, `_ViewImports.cshtml`, `_ViewStart.cshtml` in `Views/Shared/`.
- One subfolder per controller under `Views/`.
- ViewModels are simple data-transfer objects, not tied to Entity Framework.

## General Principles

- Keep controllers thin: they parse input, call a use case, and return a view or redirect.
- Use `AsNoTracking()` on EF queries that are only displayed (not mutated).
- Do not expose EF entities directly from controllers; always use ViewModels.
- Keep `using` statements inside the namespace block.
- Prefer `var` for local variables where the type is obvious from context.
