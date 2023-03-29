---
title: Project query conceptual reference
description: 2023-2-13
author: hgwelliver
ms.author: hgwelliver
ms.technology: vs-ide-sdk
ms.topic: conceptual
ms.date: 02/13/2023
ms.custom: template-concept
---

# Project query API

In Visual Studio, projects are collections of files that are compiled together into an executable or some other form of output, and solutions are collections of projects. Projects and solutions are represented in the filesystem by project files and solution files, respectively. For more information, see [What are solutions and projects in Visual Studio?](https://learn.microsoft.com/visualstudio/ide/solutions-and-projects-in-visual-studio).

The project system sits between a project or solution file on disk (for example, .csproj and .vbproj) and various Visual Studio features including, but not limited to, the Solution Explorer, designers, the debugger, language services, build and deployment. Project systems are a part of Visual Studio components to help users work with and maintain projects, run builds to produce results, and to test output, and almost all interaction that occurs with files contained in a project file happens through the project system. You can find more information on project systems [here](https://github.com/microsoft/VSProjectSystem).

The goal of the project query API is to enable extensions to retrieve data about projects and solutions and make changes.

Some examples of what you might do with a project query:

- Enumerate the source files in a project
- Check which NuGet packages are referenced by a project
- Find all projects that have a given set of capabilities
- Add new files to a project
- Modify the properties of a project

A project query is a series of clauses that reference various items. Please see the [Project Query Overview](./project.md) for more information and for examples of project queries for common tasks.

## Project query item types

There are many different items you can reference in your project queries. Some items have children or child collections that can also be referenced. For example, a `WorkSpace` contains a collection of `Projects`, each of which contains a collection of `Files`.

|Term|Description
|---|---
|WorkSpace| The top level workspace of the API to provide the entry point.
|PropertiesAvailableStatus| The entry point to check whether a property value is available in the result.
|QueryableSpace.Projects| All projects in the workspace.
|QueryableSpace.Solutions| All solutions in the workspace.
|Solution| Represents a solution in Visual Studio.
|Project| Represents most projects in Visual Studio, but solution folders are represented differently in VisualStudio.Extensibility.
|SolutionFolder| Represents a solution folder, which is a virtual folder to group projects and files inside a Visual Studio solution.
|File| Represents a file contained by a project or a solution folder.
|ExternalFile| Represents external files referenced by a project, which is not yet supported by C++ projects.
|Property| Represents dynamic set (weak name/type) of properties of a project, a configuration, or a file.
|ProjectReference| Represents project-to-project references, including shared project references.
|PackageReference| Represents a package reference in a project configuration, typically a NuGet package reference.
|AssemblyReference| Represents a referenced assembly in a project configuration.
|ConfigurationDimensionDefinition| Represents values to declare project configurations.
|ProjectConfiguration| Represents a project configuration.
|ConfigurationDimension| Represents values of each dimension of a single project configuration.
|OutputGroup| Represents one collection of project output.
|Output| Represents one item inside a single output group.
|LaunchProfile| Represents launch profiles defined in a project.
|PropertyPage| Represents property pages shown for the project.

## Project query clause types

Clauses in your project query determine what kind of items should be returned in the output, which collection they should come from, which properties they should have, and whether the returned items should be mutable. Clauses are also used to limit and filter the output.

|Term|Description
|---|---
|With| Requests value of a property/collection to be returned from the query.
|WithRequired| Requests value of a property/collection must be returned from the query.
|Where| Requests the query result to be filtered based on a predicate.
|Get| Gets child items instead in the query result.
|QueryAsync| Executes a query and retrieves the result as IAsyncEnumerable.
|AsQueryable| Starts a query from a previous retrieved object.
|QueryFrom| Starts a query from a collection of previous retrieved objects.
|AsUpdatable| Starts to update object from a query result.
|ExecuteAsync| Executes an update query.

## Next Steps

To see some examples of project queries for common tasks, see the [Project Query Overview](./project.md)

For a sample extension that uses the project query API, see [Project Query Sample](../../../../New_Extensibility_Model/Samples/VSProjectQueryAPISample/README.md)