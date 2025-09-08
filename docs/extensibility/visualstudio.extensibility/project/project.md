---
title: Project query reference (VisualStudio.Extensibility)
description: An overview of VisualStudio.Extensibility's project query API
author: Jxwoon
ms.author: jasminewoon
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: overview
ms.date: 05/01/2024
---

# Query the project API (VisualStudio.Extensibility)

> [!IMPORTANT]
> This documentation refers to Project Query API functionality for **VisualStudio.Extensibility**. For Visual Studio SDK API documentation, see [Query the project API](../../project-visual-studio-sdk.md) for Visual Studio SDK.

The VisualStudio.Extensibility project query API allows you to querying information from the project system. Project systems are a part of Visual Studio components that help users work with and maintain projects, run builds to produce results, and test output.

With the Project Query API, you can:

1. Work with Project Systems
1. Retrieve data from projects
1. Make changes to projects

Some examples of what the Project Query API can do include giving you a way to understand the files included in a project, the NuGet packages referenced by a project, add new files to a project, or adjust project properties.

Find further information on project systems [in our Visual Studio Project System Extensibility Documentation](https://github.com/microsoft/VSProjectSystem) reference.

## Work with the project query API

This overview covers top scenarios for working with the project query API:

- [Access the project query space](#access-the-project-query-space)
- [Query the project system for a project](#query-the-project-system-for-a-project)
- [Specify the project parameters to be included in the query result](#specify-the-project-parameters-to-be-included-in-the-query-result)
- [Filter the query result](#filter-the-query-result)
- [Use nested queries to specify desired properties](#use-nested-queries-to-specify-desired-properties)
- [Retrieve a child collection using the Get method](#retrieve-a-child-collection-using-the-get-method)
- [Query additional information from a previously returned item](#query-additional-information-from-a-previously-returned-item)
- [Modify a project](#modify-a-project)
- [Query for project properties](#query-for-project-properties)
- [Query for solutions](#query-for-solutions)
- [Query for solution folders](#query-for-solution-folders)
- [Enumerating source files with additional information in a project](#enumerating-source-files-with-additional-information-in-a-project)
- [Query for projects that own a specific source file](#query-for-projects-that-own-a-specific-source-file)
- [Query for project configurations and their properties](#query-for-project-configurations-and-their-properties)
- [Query for project-to-project references](#query-for-project-to-project-references)
- [Query for package references](#query-for-package-references)
- [Query for project output groups](#query-for-project-output-groups)
- [Query for Startup Projects](#query-for-startup-projects)
- [Query for Solution Configurations](#query-for-solution-configurations)
- [Action Query to Load/Unload a Project](#action-query-to-loadunload-a-project)
- [Action Query to Build Solutions/Projects](#action-query-to-build-solutionsprojects)
- [Action Query to Save a Solution/Project](#action-query-to-save-solutionsprojects)
- [Query to Subscribe to Query Changes](#query-to-subscribe-to-query-changes)
- [Query to Track Query Changes](#query-to-track-query-changes)
- [Action Query to Skip](#action-query-to-skip)

## Access the project query space

You'll need to obtain an instance of the *project query space* object to query the project system. This object has several asynchronous methods that query or update the project system. The term *project query space* and the term *workspace* both mean the same thing and refer to the object that provides access to all the data for a project. `workspace` will be consistently used in this documentation.

### Using WorkspacesExtensibility
The `WorkspacesExtensibility` object, built into `Microsoft.VisualStudio.Extensibility`, provides a simple and integrated way to use project query.

```csharp
WorkspacesExtensibility workspace = this.Extensibility.Workspaces();
```

## Query the project system for a project

The [`WorkspacesExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.workspacesextensibility) object lets you query for an individual project: if you have the project GUID. There are usually two GUIDs associated with a project, one that represents the project type, and other that uniquely represents the project. You can find the project's unique GUID in the solution file, or from an extension, you can query for the `Guid` property as demonstrated in the next section.

```csharp
IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectByGuidAsync(
    project => project.With(project => new { project.Id, project.Path }),
    knownGuid,
    cancellationToken);
```

## Specify the project parameters to be included in the query result

When querying the project system, utilize `With` clauses to determine which parameters or metadata are included in the query results. There are several valid methods to specify which parameters should be included.

### `With` clauses for each parameter

```csharp
IQueryResults<IProjectSnapshot> allProjects = await workspace.QueryProjectsAsync(
    project => project.With(p => p.Name)
        .With(p => p.Path)
        .With(p => p.Guid)
        .With(p => p.Kind) // DTE.Project.Kind
        .With(p => p.Type) // VSHPROPID_ProjectType
        .With(p => p.TypeGuid) // VSHPROPID_TypeGuid
        .With(p => p.Capabilities),
    cancellationToken);

foreach (IProjectSnapshot project in allProjects)
{
    var projectGuid = project.Guid;
    // Checking whether 'Capabilities' property has been retrieved.
    // Otherwise, it can throw for projects which do not support it. (Like SQL projects)
    bool capabilities = project.PropertiesAvailableStatus.Capabilities;
}
```

### Single `With` clause to specify multiple parameters

You can also specify multiple desired parameters in a single `With` clause.

```csharp
IQueryResults<IProjectSnapshot> results = await workspace.QueryProjectsAsync(
    project => project.With(p => new { p.Path, p.Guid, p.Kind, p.Type, p.TypeGuid, p.Capabilities }),
    cancellationToken);
```

### Example using a `WithRequired` clause

Using `WithRequired` ensures that only projects containing specified properties are retrieved. For instance, in the following example, only projects that include files named `information` are selected.

```csharp
IQueryResults<IProjectSnapshot> results = await workspace.QueryProjectsAsync(
    project => project.With(p => new { p.Path, p.Guid })
    .WithRequired(p => p.Files.Where(f => f.FileName == "information")),
    cancellationToken);
```

## Filter the query result

You can apply conditional filtering in two ways to limit query results: 

### `Where` statements

Different project types support different sets of capabilities. With a `Where` clause, you can filter for projects that support specific capabilities. Queries can fail if you don't filter to projects that support the relevant capabilities.

The following code returns the `Path` and `Guid` of all .NET Core web projects in the workspace:

```csharp
IQueryResults<IProjectSnapshot> webProjects = await workspace.QueryProjectsAsync(
    project => project.Where(p => p.Capabilities.Contains("DotNetCoreWeb"))
    .With(p => new { p.Path, p.Guid }),
    cancellationToken);
```

### Query methods with built-in filtering

#### `RuleResultsByRuleName` statement
At the level of individual projects, each project possesses a `RulesResults` attribute, which includes a `RuleName` and `Items`. The API call `RuleResultsByRuleName` can be used to filter by rule name.

In the following query, rather than retrieving every rule present in ActiveConfigurations, we specifically target the CompilerCommandLineArgs rule. The query results will include both the rule name and the items associated with it.

```csharp
IQueryResults<IProjectSnapshot> results = await workspace.QueryProjectsAsync(
    project => project.With(p => p.ActiveConfigurations
        .With(c => c.RuleResultsByRuleName("CompilerCommandLineArgs")
            .With(r => r.RuleName)
            .With(r => r.Items
                .With(i => i.Name)))),
    cancellationToken);
```

#### `ProjectsByCapabilities` statement

You can also use query methods like [`ProjectsByCapabilities`](/dotnet/api/microsoft.visualstudio.projectsystem.query.solutionpropertiesfilterextensions.projectsbycapabilities) that have filtering built into the query.

```csharp
string capabilities = "DotNetCoreWeb | DotNetCoreRazor";

// Execute the query
IQueryResults<IProjectSnapshot> webProjects = await workspace.QueryProjectsByCapabilitiesAsync(
    project => project.With(p => new { p.Path, p.Guid }),
        capabilities,
    cancellationToken);
```

## Use nested queries to specify desired properties

Some parameters are collections themselves, and you can use nested queries to do similar specification and filtering on those child collections.

### Example

In the following example, a nested query lets you filter and specify the collection of files to be included with each project returned by the outer query.

The query below yields an IProjectSnapshot for projects featuring the ApplicationIcon property. It specifically searches for .ico files within these projects, aiming to determine their paths and whether they are hidden.

```csharp

IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectsByCapabilitiesAsync(
    project => project.With(project => new { project.Path, project.IsProjectFileSearchable })
    .With(project => project.PropertiesByName("ApplicationIcon")) // Retrieve a single property, if it exists
    .With(p => p.Files // Without any condition, retrieve all files in the project, but filter them
        .Where(f => f.Extension == ".ico")
        .With(f => new { f.Path, f.IsHidden })),
    "CPS",
    cancellationToken);

foreach (IProjectSnapshot project in projects)
{
    IPropertySnapshot property = project.Properties.FirstOrDefault();
    string? applicationIcon = (string?)property?.Value;

    foreach (var iconFile in project.Files)
    {
        string filePath = iconFile.Path;
        bool isHidden = iconFile.IsHidden;
    }
}
```

## Retrieve a child collection using the Get method

The project model in Visual Studio includes collections for projects and their child collections, which can encompass files or project capabilities among others. To access a specific child collection, use the `Get` clause. This clause, similar to other types of queries, allows for the incorporation of additional clauses like the `With` clause, which helps refine or constrain the query results.

In the following query, the `Get` method retrieves the child collection, `Files`, from a project identified by its specific Guid.

```csharp
IQueryResults<IFileSnapshot> files = await workspace.QueryProjectsAsync(
    project => project.Where(p => p.Guid == knownGuid)
                        .Get(p => p.Files
                        .With(f => new { f.Path, f.IsHidden, f.IsSearchable })),
    cancellationToken);


foreach (IFileSnapshot file in files)
{
    string filePath = file.Path;
}
```

## Query additional information from a previously returned item

You can leverage the results from a previous query as the base for additional queries.

```csharp
    IQueryResults<IProjectSnapshot> allProjects = await workspace.QueryProjectsAsync(
        project => project.With(p => p.Path)
        .With(p => p.Guid),
        cancellationToken);

foreach (IProjectSnapshot project in allProjects)
{
    IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files = project.Files
        .With(f => new { f.Path, f.ItemType }).QueryAsync(cancellationToken);
}
```

## Modify a project

Query results are normally immutable. Use the query API's `UpdateProjectsAsync` clause to access mutable versions of the query results, which will allow you to make changes to the projects and project items.

### Example of adding a file to a project in a query result

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = await workspace.UpdateProjectsAsync(
project => project.Where(project => project.Guid == knownGuid),
project => project.CreateFile("CreatedFile.txt"),
cancellationToken);
```

### Example renaming a project

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = await workspace.UpdateProjectsAsync(
        project => project.Where(project => project.Guid == knownGuid),
        project => project.RenameFile(filePath, newFileName),
        cancellationToken);
```

## Query for project properties

This query asynchronously retrieves projects with the specified properties `RootNamespace` and `AssemblyVersion` from a collection of projects.

```csharp
// We assume that we can find the "RootNamespace" property in the result.
// However it isn't true from query API point of view.
// The query tries to retrieve items based on the condition, and if there is no such item, it will run successfully, only without returning items.
IQueryResults<IProjectSnapshot> properties = await workspace.QueryProjectsAsync(
    project => project.With(project => project.PropertiesByName("RootNamespace", "AssemblyVersion")),
    cancellationToken);
```

## Query for solutions

In addition to working with projects as shown previously, you can use similar techniques to work with solutions.

```csharp
IQueryResults<ISolutionSnapshot> solutions = await workspace.QuerySolutionAsync(
    solution => solution.With(s => new { s.Path, s.Guid, s.ActiveConfiguration, s.ActivePlatform }),
    cancellationToken);
```

## Query for solution folders

Likewise, you can use a `Get` clause to query for solution folders. The `IsNested` property lets you include or exclude nested folders from your results. Solution Explorer can have nested folders, such as for configuration setting or resources.

```csharp
IQueryResults<ISolutionFolderSnapshot> solutionFolders = await workspace.QuerySolutionAsync(
    solution => solution.Get(s => s.SolutionFolders
    .With(folder => folder.Name)
    .With(folder => folder.IsNested)
    .With(folder => folder.VisualPath)), // it's a relative (virtual) path to represent how the folder is nested.),
    cancellationToken);
```

This example gets all recursively nested solution folders. The `VisualPath` is the path as it shows up in Solution Explorer.

```csharp
string visualPath = mySolutionFolder.VisualPath;

IQueryResults<ISolutionFolderSnapshot> recursivelyNestedFolders = await workspace.QuerySolutionAsync(
    solution => solution.Get(s => s.SolutionFolders
    .Where(folder => folder.VisualPath.StartsWith(visualPath) && folder.VisualPath != visualPath)
    .With(folder => folder.Name)),
    cancellationToken);
```

## Enumerating source files with additional information in a project

Here's an example enumerating all .xaml files in a project and its code generator:

```csharp
IQueryResults<IFileSnapshot> projects = await workspace.QueryProjectsByGuidAsync(
    project => project.Get(p => p.Files)
        .Where(file => file.Extension == ".xaml")
        .With(file => file.Path)
        .With(file => file.PropertiesByName("Generator")),
    guids,
    cancellationToken);
```

Example of enumerating all files with a certain extension, such as XML Schema files (`.xsd` files) in all projects:

```csharp
IQueryResults<IFileSnapshot> schemaFiles = await workspace.QueryProjectsAsync(
    project => project
            .Get(proj => proj.FilesEndingWith(".xsd"))
            .With(file => file.Path),
    cancellationToken);

foreach (IFileSnapshot file in schemaFiles)
{
    // ...
}

```

## Query for projects that own a specific source file

As projects and folders have information about which files they own or contain, you can use a `WithRequired` clause to query for projects that include certain files.

### Example of finding projects that own a given file

```csharp
string myFilePath = "c://my/file//path";
IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectsAsync(
    project => project.WithRequired(project => project.FilesByPath(myFilePath))
    .With(project =>project.Guid),
    cancellationToken);
```

### Example of finding solution folders that contain a given file

```csharp
IQueryResults<ISolutionFolderSnapshot> solutionFolders = await workspace.QuerySolutionAsync(
    solution => solution.Get(s => s.SolutionFolders)
        .WithRequired(folder => folder.FilesByPath(myFilePath))
        .With(folder => folder.Name)
        .With(folder => folder.Guid),
    cancellationToken);
```

## Query for project configurations and their properties
Projects have a `ConfigurationDimension` property, which you can use to find project configuration information. Project configuration information relates to project build configurations (for example, `Debug` and `Release`).

```csharp
IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectsAsync(
    project => project.With(p => new { p.Guid, p.Name })
        .With(p => p.Configurations
            .With(c => c.Name)
            .With(c => c.PropertiesByName("OutputPath"))
            .With(c => c.ConfigurationDimensions)), // ConfigurationDimension is essentially Name, Value pairs, both are default properties.,
    cancellationToken);

foreach (IProjectSnapshot project in projects)
{
    foreach (IProjectConfigurationSnapshot configuration in project.Configurations)
    {
        // ...
    }
}
```

## Query for project-to-project references

You can also query to find projects that reference a given project.

### Example of finding all projects referenced by the current project

```csharp
IQueryResults<IProjectSnapshot> projectReferences = await workspace.QueryProjectByGuidAsync(
    project => project.With(project => project.ProjectReferences
        .With(r => r.ProjectGuid)
        .With(r => r.ReferencedProjectId)),
    knownGuid,
    cancellationToken);
```

### Example of finding all projects referencing the current project

```csharp
IQueryResults<IProjectSnapshot> projectReferences = await workspace.QueryProjectsAsync(
    project => project.With(p => p.Guid)
    .WithRequired(p => p.ProjectReferences
        .Where(r => r.ProjectGuid == knownGuid)),
    cancellationToken);
```

## Query for package references

Likewise, you can query for NuGet package references.

### Example of finding all packages referenced by the current project

```csharp
IQueryResults<IProjectSnapshot> projectReferences = await workspace.QueryProjectByGuidAsync(
    project => project.With(project => project.ActiveConfigurations
        .With(c => c.Name)
        .With(c => c.PackageReferences
            .With(p => new { p.Name, p.Version }))),
    knownGuid,
    cancellationToken);
```

### Example of finding all projects referencing a specific NuGet package

```csharp
string packageName = "Newtonsoft.Json";

IQueryResults<IProjectSnapshot> projectReferences = await workspace.QueryProjectsAsync(
    project => project.With(p => p.Guid)
    .WithRequired(p => p.ActiveConfigurations
        .WithRequired(c => c.PackageReferences
            .Where(package => package.Name == packageName))),
    cancellationToken);
```

## Query for project output groups

Project configurations have information about project output groups.

```csharp
IQueryResults<IProjectSnapshot> outputGroups = await workspace.QueryProjectsAsync(
    project => project.With(p => p.ActiveConfigurations
    .With(c => c.OutputGroupsByName()
        .With(o => o.Name)
        .With(o => o.Outputs))),
    cancellationToken);
```

## Query for startup projects

The solution has a set of startup projects that can be executed as an executable.

```csharp
// A query to get the list of startup project's name and path
IQueryResults<ISolutionSnapshot> startupProjects = await workspace.QuerySolutionAsync(
    solution => solution.With(solution => solution.StartupProjects
        .With(startupproject => startupproject.Name)
        .With(startupproject => startupproject.Path)),
    cancellationToken);
```

### Action to set the startup project

Using the Project Query API, you also can select which projects get executed. The sample below shows how two project paths can be set as the startup projects.

```csharp
// A query to set the startup project
var results = await workspace.UpdateSolutionAsync(
    solution => solution.With(solution => solution.StartupProjects),
    solution => solution.SetStartupProjects(projectPath1, projectPath2),
    cancellationToken);

```

## Query for solution configurations

A solution configuration is a collection of projects that are included in the build when the configuration is active. The example below shows how to query for the names of the solution configurations.

```csharp
var results = await workspace.QuerySolutionAsync(
    solution => solution.With(solution => solution.SolutionConfigurations
    .With(c => c.Name)),
    cancellationToken);
```

### Example of adding a solution configuration

The `AddSolutionConfiguration` method takes three parameters:
1. The first parameter is the new name for the new solution configuration. In this example, the new solution configuration will be called `Foo`.
1. The next parameter is the configuration on which the new configuration should be based. Below, the new solution configuration is based on the existing solution configuration `Debug`.
1. Lastly, the boolean represents if the solution configuration should be propagated.

```csharp
await workspace.UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "mySolution"),
    solution => solution.AddSolutionConfiguration("Foo", "Debug", false),
    cancellationToken);
```

### Example of deleting a solution configuration

`DeleteSolutionConfiguration` is an API call that removes the solution configuration. In the example below, The solution configuration called `Foo` is removed.

```csharp
await workspace.UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "mySolution"),
    solution => solution.DeleteSolutionConfiguration("Foo"),
    cancellationToken);
```

## Action query to load/unload a project

If loading/unloading a project is necessary, you need to specify the solution and the path to the desired project in question. 

```csharp
// Unload Project
await workspace.UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "MySolution"),
    solution => solution.UnloadProject("full\\path\\to\\project.csproj"),
    cancellationToken);

// Reload Project
await workspace.UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.ReloadProject(projectPath),
    cancellationToken);
```

## Action query to build solutions/projects

You can invoke build actions on the project or solution level. These build actions include:

- `BuildAsync`
- `RebuildAsync`
- `CleanAsync`
- `DebugLaunchAsync`
- `LaunchAsync`

### Building the solution level

Building on the solution level will build all projects that are loaded into the solution. Below is an example of building a solution.

```csharp
var result = await querySpace.Solutions
        .BuildAsync(cancellationToken);
```

### Building on the project level

While building on the project level, determine the selected project you want to build. In the example below, `myProject` is an `IProjectSnapshot` that will be built.

```csharp
 var result = await myProject.BuildAsync(cancellationToken);
```

## Action query to save solutions/projects

`SaveAsync` can be used on the project or solution level.

### Saving on the solution level

```csharp
var result = await querySpace.Solutions
        .SaveAsync(cancellationToken);
```

### Saving on the project level

`myProject` is an `IProjectSnapshot` of the target project to be saved.

```csharp
 var result = await myProject.SaveAsync(cancellationToken);
```

## Query to subscribe to query changes 

`SubscribeAsync` can be used to track the most recent `IQueryResults` in the project or solution. 

In the example below, `SubscribeAsync` will keep up to date with the solution's projects. The SubscribeObserver instance is passed in to receive notifications of changes.

```csharp
var solutions = await this.Extensibility.Workspaces().QuerySolutionAsync(
    solution => solution.With(solution => solution.FileName),
    cancellationToken);

var singleSolution = solutions.FirstOrDefault();

if (singleSolution is null)
{
    return;
}

var unsubscriber = await singleSolution
    .AsQueryable()
    .With(p => p.Projects)
    .SubscribeAsync(new SubscriberObserver(), CancellationToken.None);

```

The `SubscribeObserver` is a component that implements [IObserver](/dotnet/api/system.iobserver-1) interface and receives change notifications. For the example above, it would implement `IObserver<IQueryResults<ISolutionSnapshot>>`.

```csharp
private class SubscribeObserver : IObserver<IQueryResults<ISolutionSnapshot>>
{
    public void OnCompleted()
    {
        ...
    }
 
    public void OnError(Exception error)
    {
        ...
    }
 
    public void OnNext(IQueryResults<ISolutionSnapshot> value)
    {
        ...
    }
 
    public override int GetHashCode()
    {
        ...
    }
}
```

## Query to track query changes 

`TrackUpdatesAsync` can be used to track changes in the project or solution. 

In the example below, `TrackUpdatesAsync` will track changes to files in the project. The TrackerObserver instance is passed in to receive notifications of changes.

```csharp
var projects = workspace.QueryProjectsAsync(
    project => project.With(project => project.Name),
    cancellationToken);

var singleProject = projects.FirstOrDefault();

if (singleProject is null)
{
    return;
}

var unsubscriber = await singleProject
    .Files
    .With(f => f.FileName)
    .TrackUpdatesAsync(new TrackerObserver(), CancellationToken.None);

```

The `TrackerObserver` is a component that implements [IObserver](/dotnet/api/system.iobserver-1) interface and receives change notifications. For the example above, it would implement `IObserver<IQueryTrackUpdates<IFileSnapshot>>`.

```csharp
private class TrackerObserver : IObserver<IQueryTrackUpdates<IFileSnapshot>>
{
    public void OnCompleted()
    {
        ...
    }
 
    public void OnError(Exception error)
    {
        ...
    }
 
    public void OnNext(IQueryTrackUpdates<IFileSnapshot> value)
    {
        ...
    }
 
    public override int GetHashCode()
    {
        ...
    }
}
```

## Action query to skip

`Skip` can be used to skip N results from a query.

In this code sample, the first result from the query is skipped. If there were three projects in the solution, for example, the first result will be skipped, and the query will return the two remaining projects. Note that the order is not guaranteed.

```csharp
IQueryResults<IProjectSnapshot> projects = await workspace.QueryProjectsAsync(
            project => project.With(p => p.Name)
            .Skip(1),
            cancellationToken);
```

## Next steps

To review keywords and concepts regarding Project Query API, see the [Project Query Concepts](./project-concepts.md).

Review the code for an extension that uses the Project Query API at [VSProjectQueryAPISample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/README.md).
