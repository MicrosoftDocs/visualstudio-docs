---
title: Project query reference
description: An overview of the project query API
author: hgwelliver
ms.author: hwelliver
ms.technology: vs-ide-sdk
ms.topic: overview
ms.date: 02/13/2023
ms.custom: template-overview
---

# Project query overview

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
- [Query additional information from a previously-returned item](#query-additional-information-from-a-previously-returned-item)
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

## Access the project query space

[Question: terminology can be confusing. "project query space" vs "workspace" vs "ProjectQueryableSpace" -- the same or not? ]

[Consider having two versions of the page - in proc and out of proc]

Before you can query the project system, you need to obtain an instance of the *project query space* object, which has several asynchronous methods that query or update the project system. The term *project query space* and the term *workspace* both mean the same thing, the object that provides access to all the data for a project.

### Project query space access in an out-of-process extension

If you're creating an out-of-process extension, use the following code:

```csharp
WorkspacesExtensibility workSpace = this.Extensibility.Workspaces();
```

### Project query space access in an in-process extension

If you're creating an [in-process extension](../../getting-started/in-proc-extensions.md), you instead access the project query space as shown in the following code example. Unless you have specifically created an in-process extension, use the snippet in the previous section to get an instance of the project query space object.

```csharp
IProjectSystemQueryService queryService = await package.GetServiceAsync<IProjectSystemQueryService, IProjectSystemQueryService>();
ProjectQueryableSpace workSpace = queryService.QueryableSpace;
```

## Query the project system for a project

The `WorkspacesExtensibility` object lets you query for an individual project, if you have the project GUID. There are usually two GUIDs associated with a project, one that represents the project type, and other that uniquely represents the project. You can find the project's unique GUID in the solution file, or from an extension, you can query for the `Guid` property as demonstrated in the next section.

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

When using `WithRequired`, only projects with the required properties will be returned.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projectWithFiles = workSpace
    .Projects
    .With(p => new { p.Path, p.Guid })
    .WithRequired(p => p.Files.Where(f => f.FileName == "information.txt"))
    .QueryAsync(cancellationToken);
```

### Example when no properties are specified

When no properties are specified, the default set of properties will be returned.

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

### Example using built-in filtering

You can also use query methods like `ProjectsByCapabilities` that have filtering built into the query.

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

## Query additional information from a previously-returned item

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

### Example of adding a file to a previously-returned project

```csharp
IQueryResult<IProjectSnapshot> updatedProjects = myproject
    .AsUpdatable()
    .CreateFile("AdditionalInformation2.txt", textContent)
    .ExecuteAsync(cancellationToken);
```

## Query for project properties

You can use a `Get` clause to query for project properties. The following query returns a collection of `IPropertySnapshot` that contains entries for the two properties requested. `IPropertySnapshot` contains the property name, display name, and value at a point in time.

```csharp
// We assume that we can find the "RootNamespace" property in the result.
// However it is not true from query API point of view.
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
    .With(folder => folder.VisualPath) // it is a relative (virtual) path to represent how the folder is nested.
    .QueryAsync(cancellationToken);
```

Here we are getting all nested solution folders, projects, files inside a solution folder (not recursively nested):

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

Here we are getting all recursively nested solution folders. Note that `VisualPath` the path as it shows up in Solution Explorer.

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

Here is an example enumerating all .xaml files in a project and its code generator:

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

## Next steps

Review the code for an extension that uses the Project Query API at [VSProjectQueryAPISample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/README.md).
