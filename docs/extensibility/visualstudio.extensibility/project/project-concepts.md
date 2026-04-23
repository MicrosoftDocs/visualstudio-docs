---
title: Project query conceptual overview
description: Learn how to use the project query API to get and change properties and contents of Visual Studio projects.
author: Jxwoon
ms.author: jasminewoon
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: concept-article
ms.date: 05/01/2024
---

# Project query API concepts

In Visual Studio, projects are collections of files that are compiled together into an executable or some other form of output, and solutions are collections of projects. Projects and solutions are represented in the filesystem by project files and solution files, respectively. For more information, see [What are solutions and projects in Visual Studio?](../../../ide/solutions-and-projects-in-visual-studio.md).

The project system sits between a project or solution file on disk (for example, `.csproj` and `.vbproj`) and various Visual Studio features including, but not limited to, the Solution Explorer, designers, the debugger, language services, build and deployment. Project systems are a part of Visual Studio components to help users work with and maintain projects, run builds to produce results, and to test output, and almost all interaction that occurs with files contained in a project file happens through the project system. You can find more information on project systems [here](https://github.com/microsoft/VSProjectSystem).

The goal of the project query API is to enable extensions to retrieve data about projects and solutions and make changes.

Some examples of what you might do with a project query:

- Enumerate the source files in a project
- Check which NuGet packages are referenced by a project
- Find all projects that have a given set of capabilities
- Add new files to a project
- Modify the properties of a project

A project query is a series of clauses that reference various items. Please see the [Project Query Overview](./project.md) for more information and for examples of project queries for common tasks.

## Project Query Item Types

There are many different items you can reference in your project queries. Some items have children or child collections that can also be referenced. For example, a `WorkSpace` contains a collection of `Projects`, each of which contains a collection of `Files`.

| Term                             | Description                                                                                                                |
| -------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| WorkSpace                        | The top level workspace of the API to provide the entry point.                                                             |
| PropertiesAvailableStatus        | The entry point to check whether a property value is available in the result.                                              |
| QueryableSpace.Projects          | All projects in the workspace.                                                                                             |
| QueryableSpace.Solutions         | All solutions in the workspace.                                                                                            |
| Solution                         | Represents a solution in Visual Studio.                                                                                    |
| Project                          | Represents most projects in Visual Studio, but solution folders are represented differently in VisualStudio.Extensibility. |
| SolutionFolder                   | Represents a solution folder, which is a virtual folder to group projects and files inside a Visual Studio solution.       |
| Folder                           | Represents a folder contained by a project.                                                                                |
| File                             | Represents a file contained by a project or a solution folder.                                                             |
| ExternalFile                     | Represents external files referenced by a project, which isn't yet supported by C++ projects.                              |
| Property                         | Represents dynamic set (weak name/type) of properties of a project, a configuration, or a file.                            |
| RuleName                         | Represents the set of Rules in a project configuration.                                                                    |
| ProjectReference                 | Represents project-to-project references, including shared project references.                                             |
| PackageReference                 | Represents a package reference in a project configuration, typically a NuGet package reference.                            |
| AssemblyReference                | Represents a referenced assembly in a project configuration.                                                               |
| ConfigurationDimensionDefinition | Represents values to declare project configurations.                                                                       |
| ProjectConfiguration             | Represents a project configuration.                                                                                        |
| ConfigurationDimension           | Represents values of each dimension of a single project configuration.                                                     |
| OutputGroup                      | Represents one collection of project output.                                                                               |
| Output                           | Represents one item inside a single output group.                                                                          |
| LaunchProfile                    | Represents launch profiles defined in a project.                                                                           |
| PropertyPage                     | Represents property pages shown for the project.                                                                           |
| Startup Projects                 | Represents the defined startup projects in the solution.                                                                   |

## Project Query Clause Types

Clauses in your project query determine what kind of items should be returned in the output, which collection they should come from, which properties they should have, and whether the returned items should be mutable. Clauses are also used to limit and filter the output.

| Term         | Description                                                              |
| ------------ | ------------------------------------------------------------------------ |
| With         | Requests value of a property/collection to be returned from the query.   |
| WithRequired | Requests value of a property/collection must be returned from the query. |
| Where        | Requests the query result to be filtered based on a predicate.           |
| Get          | Gets child items instead in the query result.                            |
| QueryAsync   | Executes a query and retrieves the result as IAsyncEnumerable.           |
| AsQueryable  | Starts a query from a previous retrieved object.                         |
| QueryFrom    | Starts a query from a collection of previous retrieved objects.          |
| AsUpdatable  | Starts to update object from a query result.                             |
| ExecuteAsync | Executes an update query.                                                |

## Project Query Filtering Types

Filtering types facilitate the refinement and focus of query results. Please note that certain filtering types listed below may not be available for every query item.

| Term                   | Description                                                       |
| ---------------------- | ----------------------------------------------------------------- |
| ConfigurationsByName   | Filters the query results to a specific configuration name.       |
| FilesByPath            | Filters the query results to a specific file path.                |
| OutputGroupsByName     | Filters the query results to a specific output group name.        |
| ProjectsByCapabilities | Filters the query to specific project capabilities.               |
| ProjectsByPath         | Filters the query results to a specific project path.             |
| ProjectsByProjectGuid  | Filters the query results to a specific project guid.             |
| RuleResultsByRuleName  | Filters the query to a specific rule name.                        |
| Skip                   | Executes a query result to a limited number of items by skipping. |

## Project Query Action Types

Actions in your project query determine what modifications are made to the project system. Note each query item types has their own actions available to them. Below is a simple list of action queries.

| Term                              | Description                                                                                       |
| --------------------------------- | ------------------------------------------------------------------------------------------------- |
| AddAssemblyReference              | Represents the operation to add an assembly reference to a project.                               |
| AddConfigurationDimensionValue    | Adds a new value to a configuration dimension (e.g. Configuration or Platform).                   |
| AddFiles                          | Represents the operation to add an existing file to the project.                                  |
| AddLaunchProfile                  | Represents the operation to add a new launch profile to a project.                                |
| AddPackageReference               | Represents the operation to add a package reference to a project.                                 |
| AddProjectReference               | Represents the operation to add a project to project reference to a project.                      |
| AddProject                        | Represents the operation to add a project to a solution or a solution folder.                     |
| AddProjectReferenceByPath         | Represents the operation to add a project to project reference to a project's path.               |
| AddSolutionConfiguration          | Represents the operation to add a solution configuration.                                         |
| Build                             | Represents the operation to build a solution.                                                     |
| Clean                             | Represents the operation to clean a solution.                                                     |
| ConfigurationDimensionValue       | Represents the operation to set a configuration's dimension value.                                |
| CreateFile                        | Represents the operation to create a new file in a project.                                       |
| CreateFolder                      | Represents the operation to create a folder in a project.                                         |
| CreateSolutionFolder              | Represents the operation to add a solution folder to a solution or an existing solution folder.   |
| Debug                             | Represents the operation to debug a solution.                                                     |
| DeleteConfigurationDimensionValue | Deletes a value from the configuration dimension (e.g. Configuration or Platform).                |
| Delete                            | Represents the operation to delete a Project.                                                     |
| DeleteSolutionConfiguration       | Represents the operation to remove a solution configuration.                                      |
| Deploy                            | Represents the operation to deploy a solution.                                                    |
| DuplicateLaunchProfile            | Represents the operation to duplicate an existing launch profile.                                 |
| Exclude                           | Represents the operation to exclude a project.                                                    |
| Rebuild                           | Represents the operation to rebuild a solution.                                                   |
| ReloadProject                     | Represents the operation to reload a project.                                                     |
| RemoveLaunchProfile               | Represents the operation to remove a launch profile from a project.                               |
| RenameFile                        | Represents the operation to rename a file in a project.                                           |
| RenameFolder                      | Represents the operation to rename a folder in a project.                                         |
| RenameSolutionFolder              | Represents the operation to rename a solution folder.                                             |
| RenameProject                     | Represents the operation to rename a project.                                                     |
| Run                               | Represents the operation to run a solution.                                                       |
| RunCustomTool                     | Represents the operation to run a custom tool.                                                    |
| Save                              | Represents the operation to save a project.                                                       |
| SetPropertyValue                  | Represents the operation to set a property value.                                                 |
| SetCopyToLocal                    | Represents the operation of setting the value of CopyToLocal for a project reference.             |
| SetEvaluatedUIPropertyValue       | Represents the operation to set the evaluated value of a user-visible property.                   |
| SetLaunchProfilePropertyValue     | Represents the operation of setting the value of a property exposed through the launch profile.   |
| SetPackageReferenceVersion        | Represents the operation to rename a solution folder.                                             |
| SetSolutionFolderName             | Represents the operation to set a solution folder name.                                           |
| SetStartupProjects                | Represents the operation to set a startup project.                                                |
| SetUnevaluatedUIPropertyValue     | Represents the operation to set the unevaluated value of a user-visible property.                 |
| UnloadProject                     | Represents the operation to unload a project.                                                     |
| WaitIntellisenseReady             | Represents the operation to wait project or solution intellisense operation progress to be ready. |

## Project Query Updates Types

These queries support the monitoring of updates made to query results.

| Term                | Description                                                             |
| ------------------- | ----------------------------------------------------------------------- |
| SubscribeAsync      | Represents the operation to subscribe to results from a query.          |
| TrackUpdatesAsync   | Represents the operation to track changes from a query.                 |
| QueryableSpaceEvent | An event that fires on solution open and close. Provides initial state. |

## Related content

To see some examples of project queries for common tasks, see [Project Query Overview (VisualStudio.Extensibility)](./project.md) or [Project Query Overview (Visual Studio SDK)](../../project-visual-studio-sdk.md)

For a sample extension that uses the project query API, see [Project Query Sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample/README.md)
