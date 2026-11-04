---
title: "Query the project system"
description: "Query and modify projects, files, and properties using the Project Query API in VisualStudio.Extensibility."
ms.date: 09/29/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Query the project system

Use the Project Query API to read and modify projects, files, and properties in a Visual Studio solution.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/VSProjectQueryAPISample/QueryFileCommand.cs":::

> [!TIP]
> See the full working sample: [VSProjectQueryAPISample ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/)

**Related concepts:** [Project concepts](project-concepts.md) — project system architecture and query patterns

## Understand the example

### Get the workspace

```csharp
WorkspacesExtensibility workspace = this.Extensibility.Workspaces();
```

`workspace.Queryable` gives access to the root project queryable space for advanced queries and subscriptions. For common queries, use the `QueryProjectsAsync` and `QuerySolutionAsync` helpers shown below.

### Observe solution open and close

`QueryableSpaceChanged` runs asynchronously when a solution opens or closes. `SolutionPath` is `null` on close. Keep the listener alive for as long as you need notifications, and unsubscribe when it is disposed:

```csharp
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.ProjectSystem.Query;

internal sealed class SolutionChangeListener : IDisposable
{
    private readonly WorkspacesExtensibility workspace;

    public SolutionChangeListener(VisualStudioExtensibility extensibility)
    {
        this.workspace = extensibility.Workspaces();
        this.workspace.QueryableSpaceChanged += this.OnChangedAsync;
    }

    private Task OnChangedAsync(ProjectQueryableSpaceChangedEventArgs args)
    {
        Trace.WriteLine(args.SolutionPath is null
            ? "Solution closed"
            : $"Solution opened: {args.SolutionPath}");
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        this.workspace.QueryableSpaceChanged -= this.OnChangedAsync;
    }
}
```

### Get the active document and project

In a command, the client context captures the current IDE state. The active document URI and project snapshot can both be absent:

```csharp
Uri? documentUri = await context.GetActiveDocumentUriAsync(cancellationToken);
IProjectSnapshot? activeProject = await context.GetActiveProjectAsync(cancellationToken);
```

See the [active project command ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/ShowActiveProjectCommand.cs) for an example that handles a missing project. The document URI reflects the active selection when the context was created, not a live view of later changes.

### Query projects with properties

```csharp
// Get all projects with name, path, and GUID
IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectsAsync(
    project => project.With(p => p.Name)
                      .With(p => p.Path)
                      .With(p => p.Guid),
    cancellationToken);
```

### Filter projects by capability

```csharp
// Get only .NET Core web projects
IQueryResults<IProjectSnapshot> webProjects = await workspace.QueryProjectsAsync(
    project => project.Where(p => p.Capabilities.Contains("DotNetCoreWeb"))
        .With(p => p.Path)
        .With(p => p.Guid),
    cancellationToken);
```

### Query project files

```csharp
// Get all files in a specific project
IQueryResults<IFileSnapshot> files = await workspace.QueryProjectsAsync(
    project => project.Where(p => p.Guid == knownGuid)
        .Get(p => p.Files.With(f => f.FileName)),
    cancellationToken);
```

### Add a file to a project

```csharp
IQueryResults<IProjectSnapshot> updated = await workspace.UpdateProjectsAsync(
    project => project.Where(p => p.Guid == knownGuid),
    project => project.CreateFile("NewFile.cs"),
    cancellationToken);
```

### Rename a file

```csharp
await workspace.UpdateProjectsAsync(
    project => project.Where(p => p.Guid == knownGuid),
    project => project.RenameFile(oldPath, newName),
    cancellationToken);
```

### Build a project

```csharp
// Build entire solution
IQueryResults<ISolutionSnapshot> solutions = await this.Extensibility.Workspaces().QuerySolutionAsync(
    s => s, cancellationToken);
foreach (var solution in solutions)
{
    await solution.AsQueryable().BuildAsync(cancellationToken);
}

// Build a single project by name
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
    project => project.Where(p => p.Name == "MyApp"),
    cancellationToken);
await result.First().BuildAsync(cancellationToken);
```

### Query NuGet packages

```csharp
// Get all package references for a project
IQueryResults<IProjectSnapshot> result = await workspace.QueryProjectByGuidAsync(
    project => project.With(p => p.ActiveConfigurations
        .With(c => c.PackageReferences
            .With(pkg => pkg.Name)
            .With(pkg => pkg.Version))),
    knownGuid,
    cancellationToken);
```

### Query project properties

```csharp
IQueryResults<IProjectSnapshot> props = await workspace.QueryProjectsAsync(
    project => project.With(p => p.PropertiesByName("RootNamespace", "AssemblyVersion")),
    cancellationToken);
```

### Query the solution

```csharp
IQueryResults<ISolutionSnapshot> solution = await workspace.QuerySolutionAsync(
    s => s.With(sol => sol.Path)
          .With(sol => sol.Guid)
          .With(sol => sol.ActiveConfiguration),
    cancellationToken);
```

## Tips

### ✅ DO

- Always use `.With()` to specify which properties you need
- Filter by capability before accessing capability-specific properties
- Use `UpdateProjectsAsync` for mutations
- Pass `CancellationToken` to all async calls

### ❌ DON'T

- Don't query without filtering — large solutions will be slow
- Don't assume all project types support all properties (for example, SQL projects)
- Don't try to modify `IProjectSnapshot` directly — it's immutable
- Don't use `CancellationToken.None` in production extensions

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Property throws an exception | Check `PropertiesAvailableStatus` first |
| Query returns empty results | The filter matched nothing — verify project capabilities or names |
| `CreateFile` fails | Verify the project is loaded and writable |
| Capability-specific properties missing | Use `WithRequired` to filter to projects that actually have the property |

## Next steps

- [Project Query concepts](./project-concepts.md)
