---
title: Project query reference
description: An overview of the project query API
author: Jxwoon
ms.author: jasminewoon
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.topic: overview
ms.date: 05/01/2024
---

# Query the project API

The VisualStudio.Extensibility project query API allows for querying information from the project system. Project systems are a part of Visual Studio components to help users work with and maintain projects, run builds to produce results, and to test output.

The goal of the Project Query API is to:

1. Work with Project Systems
1. Retrieve data from projects
1. Make changes to projects

Some examples include understanding files included in a project, NuGet packages referenced by a project, adding new files to a project, or changing project properties.

Find further information on project systems [here](https://github.com/microsoft/VSProjectSystem).
Find conceptual documentation about what the project system is, usages, and its various terms [here](https://github.com/microsoft/VSProjectSystem).

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
- [Action Query to Track Query Changes](#action-query-to-track-query-changes)
- [Action Query to Skip](#action-query-to-skip)

## Access the project query space

Before you can query the project system, you need to obtain an instance of the *project query space* object, which has several asynchronous methods that query or update the project system. The term *project query space* and the term *workspace* both mean the same thing, the object that provides access to all the data for a project.

### Project query space access in an out-of-process extension

If you're creating an out-of-process extension, use the following code:

```csharp
WorkspacesExtensibility workSpace = this.Extensibility.Workspaces();
```

### Project query space access in an in-process extension

If you're creating an [in-process extension](../get-started/in-proc-extensions.md), you instead access the project query space as shown in the following code example. Unless you have specifically created an in-process extension, use the snippet in the previous section to get an instance of the project query space object.

In the following code excerpt, `package` represents an instance of [AsyncPackage](/dotnet/api/microsoft.visualstudio.shell.asyncpackage), a class utilized in the development of Visual Studio extensions. The method `GetServiceAsync` is employed to asynchronously procure the query service from the Visual Studio's service container.

```csharp
IProjectSystemQueryService queryService = await package.GetServiceAsync<IProjectSystemQueryService, IProjectSystemQueryService>();
ProjectQueryableSpace workSpace = queryService.QueryableSpace;
```

## Query the project system for a project

The [`WorkspacesExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.workspacesextensibility) object lets you query for an individual project, if you have the project GUID. There are usually two GUIDs associated with a project, one that represents the project type, and other that uniquely represents the project. You can find the project's unique GUID in the solution file, or from an extension, you can query for the `Guid` property as demonstrated in the next section.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projectList = workspace
    .ProjectsByProjectGuid(knownGuid) 
    .QueryAsync(cancellationToken);
```

## Specify the project parameters to be included in the query result

When querying the project system, you can use `With` clauses to control which parameters or metadata are included in the query results. There are several valid ways to specify which parameters should be included.

### Example using a separate `With` clause for each parameter

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
    .Projects
    .With(p => p.Path)
    .With(p => p.Guid)
    .With(p => p.Kind)      // DTE.Project.Kind
    .With(p => p.Type)      // VSHPROPID_ProjectType
    .With(p => p.TypeGuid)  // VSHPROPID_TypeGuid
    .With(p => p.Capabilities)
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in allProjects)
    {
        var projectGuid = project.Value.Guid;
        // Checking whether 'Capabilities' property has been retrieved.
        // Otherwise, it can throw for projects which do not support it. (Like SQL projects)
        bool capabilities = project.Value.PropertiesAvailableStatus.Capabilities;
    }
```

### Example using a single `With` clause to specify multiple parameters

You can also specify multiple desired parameters in a single `With` clause.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
    .Projects
    .With(p => new { p.Path, p.Guid, p.Capabilities })
    .QueryAsync(cancellationToken);
```

### Example using a `WithRequired` clause

When using `WithRequired`, only projects with the required properties are returned.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projectWithFiles = workSpace
    .Projects
    .With(p => new { p.Path, p.Guid })
    .WithRequired(p => p.Files.Where(f => f.FileName == "information.txt"))
    .QueryAsync(cancellationToken);
```

### Example when no properties are specified

When no properties are specified, the default set of properties i returned.

```csharp
IAsyncEnumerable<IQueryResultItem<IPropertySnapshot>> properties = myproject
    .PropertiesByName("RootNamespace", "AssemblyVersion")
    .QueryAsync(cancellationToken);
```

## Filter the query result

To limit query results, there are two ways to apply conditional filtering: `Where` statements and query methods with built-in filtering.

### Example using a `Where` clause

Different project types support different sets of capabilities. With a `Where` clause, you can filter for projects that support specific capabilities. Queries can fail if you don't filter to projects that support the relevant capabilities.

The following code returns the `Path` and `Guid` of all .NET Core web projects in the workspace:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> webProjects = workspace
    .Projects
    .Where(p => p.Capabilities.Contains("DotNetCoreWeb"))
    .With(p => new { p.Path, p.Guid })
    .QueryAsync(cancellationToken);
```

### Example using `RuleResultsByRuleName` filtering

At the level of individual projects, each project possesses a `RulesResults` attribute, which includes a `RuleName` and `Items`. The API call `RuleResultsByRuleName` can be used to filter by rule type within a project.

```csharp
    var results = await querySpace
        .Projects
        .With(p => p.Path)
        .With(p => p.ActiveConfigurations
            .With(c => c.RuleResultsByRuleName("CompilerCommandLineArgs")
                .With(r => r.RuleName)
                .With(r => r.Items
                    .With(i => i.Name))))
        .ExecuteQueryAsync();
```

### Example using `ProjectsByCapabilities` filtering

You can also use query methods like [`ProjectsByCapabilities`](/dotnet/api/microsoft.visualstudio.projectsystem.query.solutionpropertiesfilterextensions.projectsbycapabilities) that have filtering built into the query.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> webProjects = workspace
        .ProjectsByCapabilities("DotNetCoreWeb | DotNetCoreRazor")
        .With(p => new { p.Path, p.Guid })
        .QueryAsync(cancellationToken);
```

## Use nested queries to specify desired properties

Some parameters are themselves collections, and you can use nested queries to do similar specification and filtering on those child collections.

### Example

In the following example, a nested query lets you filter and specify the collection of files to be included with each project returned by the outer query.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects = workspace
    .ProjectsByCapabilities("CPS")
    .With(p => new { p.Path, p.IsProjectFileSearchable })
    .With(p => p.PropertiesByName("ApplicationIcon")) // Retrieve a single property, if it exists
    .With(p => p.Files // Without any condition, retrieve all files in the project, but filter them
        .Where(f => f.Extension == ".ico")
        .With(f => new { f.Path, f.IsHidden }))
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in projects)
    {
        IPropertySnapshot property = project.Value.Properties.FirstOrDefault();
        string? applicationIcon = (string?)property?.Value;

        foreach (var iconFile in project.Value.Files)
        {
            string filePath = iconFile.Path;
            bool isHidden = iconFile.IsHidden;
        }
    }
```

## Retrieve a child collection using the Get method

The Visual Studio project model has collections for projects and well as child collections, such as for files or project capabilities within projects. To retrieve a child collection itself, you can use a `Get` clause. Like other query types, the `Get` clause lets you use other clauses such as the `With` clause to shape or limit the results.

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files = workspace
    .Projects
    .Where(p => p.Guid == knownGuid)
    .Get(p => p.Files
        .With(f => new { f.Path, f.IsHidden, f.IsSearchable }))
    .QueryAsync(cancellationToken);

    await foreach (var file in files)
    {
        string filePath = file.Value.Path;
    }
```

## Query additional information from a previously returned item

You can use the results from a previous query as the base for additional queries.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
    .Projects
    .With(p => p.Path)
    .With(p => p.Guid)
    .QueryAsync(cancellationToken);

await foreach (IQueryResultItem<IProjectSnapshot> project in allProjects)
{
    // Gets child collections
    IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files = project.Value
        .Files
        .With(f => new { f.Path, f.ItemType })
        .QueryAsync(cancellationToken);
}
```

## Modify a project

The query results are normally immutable. You can also use the query API to make changes using the `AsUpdatable` clause to access mutable versions of the query results, so that you can make changes to the projects and project items.

### Example of adding a file to a project in a query result

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = workSpace
    .ProjectsByProjectGuid(knownGuid)
    .AsUpdatable()
    .CreateFile("AdditionalInformation.txt", textContent)
    .ExecuteAsync(cancellationToken);
```

### Example of adding a file to a previously returned project

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = myproject
    .AsUpdatable()
    .CreateFile("AdditionalInformation2.txt", textContent)
    .ExecuteAsync(cancellationToken);
```

### Example renaming a project

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = myproject
    .AsUpdatable()
    .Rename("NewProjectName", textContent)
    .ExecuteAsync(cancellationToken);
```

## Query for project properties

You can use a `Get` clause to query for project properties. The following query returns a collection of [`IPropertySnapshot`](/dotnet/api/microsoft.visualstudio.projectsystem.query.ipropertysnapshot) that contains entries for the two properties requested. `IPropertySnapshot` contains the property name, display name, and value at a point in time.

```csharp
// We assume that we can find the "RootNamespace" property in the result.
// However it isn't true from query API point of view.
// The query tries to retrieve items based on the condition, and if there is no such item, it will run successfully, only without returning items.
IAsyncEnumerable<IQueryResultItem<IPropertySnapshot>> properties = myProject
    .AsQueryable()  
    .Get(p => p.PropertiesByName("RootNamespace", "AssemblyVersion"))
    .QueryAsync(cancellationToken);
```

## Query for solutions

In addition to working with projects as shown previously, you can use similar techniques to work with solutions.

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionSnapshot>> solutions = workSpace
    .Solutions
    .With(s => new { s.Path, s.Guid, s.ActiveConfiguration, s.ActivePlatform })
    .QueryAsync(cancellationToken);
```

## Query for solution folders

Likewise, you can use a `Get` clause to query for solution folders. The `IsNested` property lets you include or exclude nested folders from your results. Solution Explorer can have nested folders, such as for configuration setting or resources.

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> solutionFolders = workSpace
    .Solutions
    .Get(s => s.SolutionFolders)
    .With(folder => folder.Name)
    .With(folder => folder.IsNested)
    .With(folder => folder.VisualPath) // it's a relative (virtual) path to represent how the folder is nested.
    .QueryAsync(cancellationToken);
```

This example gets all nested solution folders, projects, files inside a solution folder (not recursively nested):

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionSnapshot>> solutionFoldersWithExtraInformation = mySolutionFolder
    .AsQueryable()
    .With(folder => folder.Files
        .With(f => f.Path))
    .With(folder => folder.Projects
        .With(p => new { p.Name, p.Guid }))
    .With(folder => folder.SolutionFolders
        .With(nested => nested.Name))
    .QueryAsync(cancellationToken);
```

This example gets all recursively nested solution folders. The `VisualPath` is the path as it shows up in Solution Explorer.

```csharp
string visualPath = mySolutionFolder.VisualPath;
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> recursivelyNestedFolders = await workSpace
    .Solutions
    .Get(s => s.SolutionFolders)
    .Where(f => f.VisualPath.StartsWith(visualPath) && f.VisualPath != visualPath)
    .With(f => f.Name)
    .QueryAsync(cancellationToken);
```

## Enumerating source files with additional information in a project

Here's an example enumerating all .xaml files in a project and its code generator:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
workSpace.ProjectsByProjectGuid(knownGuid)
    .Get(p => p.Files)
    .Where(file => file.Extension == ".xaml")
    .With(file => file.Path)
    .With(file => file.PropertiesByName("Generator"))
    .QueryAsync(cancellationToken);
```

Another example is to start with a project returned from the previous query:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files = myProject
    .FilesEndingWith(".xaml")     // use built-in filter instead of 'Where' condition
    .With(file => file.Path)
    .With(file => file.PropertiesByName("Generator"))
    .QueryAsync(cancellationToken);
```

Or to get all content files, which are non-compiled files that are required at runtime, such as HTML and CSS files.

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
    myProject.FilesWithItemTypes("Content")
        .With(file => file.Path)
        .QueryAsync(cancellationToken);
```

Or to enumerate all files with a certain extension, such as XML Schema files (`.xsd` files) in all projects:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> schemaFiles =
workSpace.Projects
    .Get(proj => proj.FilesEndingWith(".xsd"))
    .With(file => file.Path)
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IFileSnapshot> fileResult in schemaFiles)
    {
        DoSomething(fileResult.Value.Path);
    }
```

## Query for projects that own a specific source file

Projects and folders have information about which files they own or contain, so you can use a `WithRequired` clause to query for projects that include certain files.

### Example of finding projects that own a given file

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects = workspace
    .Projects
    .WithRequired(proj => proj.FilesByPath(myFilePath))
    .With(proj => proj.Guid)
    .QueryAsync(cancellationToken);
```

### Example of finding solution folders that contain a given file

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> solutionFolders = workspace
    .Solutions
    .Get(s => s.SolutionFolders)
    .WithRequired(folder => folder.FilesByPath(myFilePath))
    .With(folder => folder.Name)
    .With(folder => folder.Guid)
    .QueryAsync(cancellationToken);
```

## Query for project configurations and their properties
Projects have a `ConfigurationDimension` property, which you can use to find project configuration information. Project configuration information relates to project build configurations (for example, `Debug` and `Release`).

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects = workspace
    .Projects
    .With(p => new { p.Guid, p.Name })
    .With(p => p.Configurations
        .With(c => c.Name)
        .With(c => c.PropertiesByName("OutputPath"))
        .With(c => c.ConfigurationDimensions)) // ConfigurationDimension is essentially Name, Value pairs, both are default properties.
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in projects)
    {
        foreach (var configuration in project.Value.Configuration)
        {
            // ...
        }
    }
```

## Query for project-to-project references

You can also query to find projects that reference a given project.

### Example of finding all projects referenced by the current project

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectReferenceSnapshot>> projectReferences = myProject
    .ProjectReferences
    .With(r => r.ProjectGuid)
    .With(r => r.ReferencedProjectId)
    .QueryAsync(cancellationToken);
```

### Example of finding all projects referencing the current project

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects = workSpace
    .Projects
    .With(p => p.Guid)
    .WithRequired(p => p.ProjectReferences
        .Where(r => r.ProjectGuid == knownGuid))
    .QueryAsync(cancellationToken);
```

## Query for package references

Likewise, you can query for NuGet package references.

### Example of finding all packages referenced by the current project

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectConfigurationSnapshot>> configurationsWithPackageReferences = myProject
    .ActiveConfigurations
    .With(c => c.Name)
    .With(c => c.PackageReferences
        .With(p => new { p.Name, p.Version }))
    .QueryAsync(cancellationToken);
```

### Example of finding all projects referencing a specific NuGet package

```csharp
string packageName = "Newtonsoft.Json";

IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects = workSpace
    .Projects
    .With(p => p.Guid)
    .WithRequired(p => p.ActiveConfigurations
        .WithRequired(c => c.PackageReferences
            .Where(package => package.Name == packageName)))
    .QueryAsync(cancellationToken);
```

## Query for project output groups

Project configurations have information about project output groups.

```csharp
// From our list of active configurations, we need to get the first one in the list
IAsyncEnumerable<IQueryResultItem<IProjectConfigurationSnapshot>> configurations = myProject
    .ActiveConfigurations
    .QueryAsync(cancellationToken);

    IProjectConfigurationSnapshot myConfiguration = null;

    await foreach (IQueryResultItem<IProjectConfigurationSnapshot> config in configurations)
    {
        myConfiguration = config.Value;
        break;
    }

    // A multi-target project may have multiple active configurations
    IAsyncEnumerable<IQueryResultItem<IOutputGroupSnapshot>> outputGroups = myConfiguration
        .OutputGroupsByName("Built", "Symbols")
        .With(g => g.Name)
        .With(g => g.Outputs)
        .QueryAsync(cancellationToken);
```

## Query for startup projects

The solution has a set of startup projects that can be executed as an executable.

```csharp
// A query to get the list of startup project's name and path
var result = await this.QueryableSpace.Solutions
    .With(solution => solution.StartupProjects
        .With(startupproject => startupproject.Name)
        .With(startupproject => startupproject.Path))
    .QueryAsync(CancellationToken.None);
```

### Action to set the startup project

Using the Project Query API, you also can select which projects get executed. The sample below shows how two project paths can be set as the startup projects.

```csharp
// A query to set the startup project
var result = await this.QueryableSpace.Solutions
        .With(solution => solution.StartupProjects)
        .AsUpdatable()
        .SetStartupProjects("full\\path\\to\\project1.csproj", 
                            "full\\path\\to\\project2.csproj")
    .ExecuteAsync(CancellationToken.None);
```

## Query for solution configurations

A solution configuration is a collection of projects that are included in the build when the configuration is active. The example below shows how to query for the names of the solution configurations.

```csharp
var results = await this.Extensibility.Workspaces().QuerySolutionAsync(
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
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "mySolution"),
    solution => solution.AddSolutionConfiguration("Foo", "Debug", false),
    cancellationToken);
```

### Example of deleting a solution configuration

`DeleteSolutionConfiguration` is an API call that removes the solution configuration. In the example below, The solution configuration called `Foo` is removed.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "mySolution"),
    solution => solution.DeleteSolutionConfiguration("Foo"),
    cancellationToken);
```

## Action query to load/unload a project

If a project needs to be unloaded, you need to specify the solution and the path to the desired project to unload. The example below uses the `Extensibility.Workspaces().UpdateSolutionAsync` method to update the solution and `UnloadProject` to unload the project.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == "MySolution"),
    solution => solution.UnloadProject("full\\path\\to\\project.csproj"),
    cancellationToken);
```

`AsUpdatable` can also be used to load or unload a project.

```csharp
var result = await querySpace.Solutions
    .AsUpdatable()
    .LoadProject("full\\path\\to\\project.csproj")
    .ExecuteAsync();
```

## Action query to build solutions/projects

In project query, you also have the ability to invoke build actions on the project or solution level. These build actions include:

-  `BuildAsync`
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

## Action query to track query changes

`TrackUpdatesAsync` can be used at the project or solution level. It is used to track changes in the project or solution. 

In the example, `TrackUpdatesAsync` is called on the Files property of a project, with a file name filter applied. This means it will track changes to the file names in the project. The TrackerObserver instance is passed to receive notifications of changes.

```csharp
var projects = await querySpace.Projects.ExecuteQueryAsync(cancellationToken: CancellationToken.None);

var singleProject = projects.FirstOrDefault();
 
var unsubscriber = await singleProject
    .Files
    .With(f => f.FileName)
    .TrackUpdatesAsync(new TrackerObserver(), CancellationToken.None);
```

The `TrackerObserver` is a private class that implements the IObserver interface, specifically for `IQueryTrackUpdates<IFileSnapshot>`. This is designed to receive notifications about tracking updates to file snapshots.

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

In this code sample, the first result from the query is skipped. For example, if there were three projects in the solution, the first result will be skipped and the query will return the two remaining projects. Note: the order is not guaranteed.

```csharp
var projects = await queryableSpace.Projects
        .With(proj => proj.Name)
        .Skip(1)
       .ExecuteQueryAsync(new CancellationToken());
```

## Next steps

To review keywords and concepts regarding Project Query API, see the [Project Query Concepts](./project-concepts.md).

Review the code for an extension that uses the Project Query API at [VSProjectQueryAPISample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/README.md).
