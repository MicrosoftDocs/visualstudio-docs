---
title: "Visual Studio Open Folder extensibility overview | Microsoft Docs"
ms.date: "02/21/2018"
ms.topic: "conceptual"
ms.assetid: 94c3f8bf-1de3-40ea-aded-7f40c4b314c7
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
ms.workload:
  - "vssdk"
---
# Open Folder extensibility

The [Open Folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) feature allows users to open any codebase in Visual Studio without the need for project or solution files. Open Folder provides the features users expect from Visual Studio such as:

* Solution Explorer integration and search
* Editor colorization
* Go To navigation
* Find in Files search

When used with Workloads such as for .NET and C++ development, users also get:

* Rich Intellisense
* Language-specific functionality

With Open Folder, extension authors can create rich features for any language. There are APIs to support building, debugging, and symbol search for any file in a user's codebase. Current extenders can update their existing Visual Studio features to understand code without the backing of projects or a solution.

## An API without project systems

Historically, Visual Studio only understood files in a solution and its projects using project systems. A project system is responsible for the functionality and user interactions of a loaded project. It understands what files its project contains, the visual representation of the project contents, dependencies on other projects, and modification of the underlying project file. It's through these hierarchies and capabilities that other components do work on behalf of the user. Not all codebases are well represented in a project and solution structure. Scripting languages and open-source code written in C++ for Linux are good examples. With Open Folder, Visual Studio gives users a new way of interacting with their source code.

The Open Folder APIs are under the `Microsoft.VisualStudio.Workspace.*` namespace and are available for extenders to produce and consume data or actions around files within Open Folder. Extensions can use these APIs to provide functionality for many areas, including:

- [Workspaces](workspaces.md) - The starting point of Open Folder extensibility is the workspace and its APIs.
- [File contexts and actions](workspace-file-contexts.md) - File specific code intelligence provided through file contexts.
- [Indexing](workspace-indexing.md) - Collect and persist data about Open Folder workspaces.
- [Language services](workspace-language-services.md) - Integrate language services into Open Folder workspaces.
- [Build](workspace-build.md) - Build support for Open Folder workspaces.

Features that use the following types will need to adopt new APIs to support Open Folder:

- `IVsHierarchy`
- `IVsProject`
- `DTE`

## Feedback, comments, issues

Open Folder and the `Microsoft.VisualStudio.Workspace.*` APIs are under active development. If you see unexpected behavior, then see the known issues for the release of interest. [Developer Community](https://developercommunity.visualstudio.com) is the recommended place to vote and create any issues. For each feedback, we highly recommend a detailed description of your issue. Include the Visual Studio version you're developing for, the APIs you're using (both what you've implemented and what you're interacting with), the expected outcome, and the actual outcome. If possible, include a dump of the devenv.exe process. Use GitHub's issue tracking for giving feedback on this and related documentation.

## Next steps

* [Workspaces](workspaces.md) - Learn about the Open Folder workspace API.