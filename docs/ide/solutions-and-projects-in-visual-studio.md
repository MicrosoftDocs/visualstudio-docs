---
title: Solutions and projects
ms.date: 10/05/2017
ms.topic: conceptual
f1_keywords:
  - "vs.addnewitem"
  - "vs.addnewsolutionitem"
  - "vs.openproject"
  - "vs.addexistingitem"
  - "vs.addexistingsolutionitem"
  - "vs.environment.projects"
  - "vs.environment.solutions"
  - "VS.SolutionExplorer"
  - "VS.SolutionExplorer.Solutions"
helpviewer_keywords:
  - "solutions [Visual Studio]"
  - "projects [Visual Studio]"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Solutions and projects in Visual Studio

This page describes the concept of a *project* and a *solution* in Visual Studio. It also briefly covers the Solution Explorer tool window and how to create a new project.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Projects and solutions in Visual Studio for Mac](/visualstudio/mac/projects-and-solutions).

## Projects

When you create an app or website in Visual Studio, you start with a *project*. In a logical sense, a project contains all files that are compiled into an executable, library, or website. Those files can include source code, icons, images, data files, and so on. A project also contains compiler settings and other configuration files that might be needed by various services or components that your program communicates with.

### Project file

Visual Studio uses [MSBuild](../msbuild/msbuild.md) to build each project in a solution, and each project contains an MSBuild project file. The file extension reflects the type of project, for example, a C# project (.csproj), a Visual Basic project (.vbproj), or a database project (.dbproj). The project file is an XML document that contains all the information and instructions that MSBuild needs in order to build your project, including the content, platform requirements, versioning information, web server or database server settings, and the tasks to perform.

Project files are based on the [MSBuild XML schema](../msbuild/msbuild-project-file-schema-reference.md). To look at the contents of newer, [sdk-style project files](../msbuild/how-to-use-project-sdk.md) in Visual Studio, right-click on the project node in **Solution Explorer** and select **Edit \<projectname\>**. To look at the contents of .NET Framework and other projects of that style, first unload the project (right-click on the project node in **Solution Explorer** and select **Unload Project**). Then, right-click on the project and choose **Edit \<projectname\>**.

> [!NOTE]
> You don't have to use solutions or projects in Visual Studio to edit, build, and debug code. You can simply open the folder that contains your source files in Visual Studio and start editing. For more information, see [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md).

## Solutions

A project is contained within a *solution*. Despite its name, a solution is not an "answer". It's simply a container for one or more related projects, along with build information, Visual Studio window settings, and any miscellaneous files that aren't associated with a particular project. A solution is described by a text file (extension *.sln*) with its own unique format; it's not intended to be edited by hand.

Visual Studio uses two file types (*.sln* and *.suo*) to store settings for solutions:

|Extension|Name|Description|
|---------------|----------|-----------------|
|.sln|Visual Studio Solution|Organizes projects, project items, and solution items in the solution.|
|.suo|Solution User Options|Stores user-level settings and customizations, such as breakpoints.|

## Create new projects

The easiest way to create a new project is to start from a project template for a particular type of application or website. A project template consists of a basic set of pre-generated code files, config files, assets, and settings. These templates are available in the dialog box where you create a new project (**File** > **New** > **Project**). For more information, see [Create a new project in Visual Studio](create-new-project.md) and [Create solutions and projects](../ide/creating-solutions-and-projects.md).

If you often customize your projects in a certain way, you can create a custom project template that you can then use to create new projects from. For more information, see [Create project and item templates](../ide/creating-project-and-item-templates.md).

When you create a new project, it is saved by default at *%USERPROFILE%\source\repos*. You can change this location in the **Projects location** setting under **Tools** > **Options** > **Projects and Solutions** > **Locations**. For more information, see [Projects and Solutions page, Options dialog box](../ide/reference/projects-and-solutions-options-dialog-box.md).

## Solution Explorer

After you create a new project, you can use **Solution Explorer** to view and manage the project and solution and their associated items. The following illustration shows **Solution Explorer** with a C# solution that contains two projects:

![Solution Explorer](../ide/media/vs2015_solution_explorer.png)

Many menu commands are available from the right-click menu on various items in **Solution Explorer**. These commands include building a project, managing NuGet packages, adding a reference, renaming a file, and running tests, just to name a few. The toolbar across the top of **Solution Explorer** has buttons to switch from a solution view to a folder view, show hidden files, collapse all nodes, and more.

For ASP.NET Core projects, you can customize how files are nested in **Solution Explorer**. For more information, see [Customize file nesting in Solution Explorer](file-nesting-solution-explorer.md).

## See also

- [Visual Studio IDE](../get-started/visual-studio-ide.md)
- [Projects and solutions (Visual Studio for Mac)](/visualstudio/mac/projects-and-solutions)
- [Add and remove project items (Visual Studio for Mac)](/visualstudio/mac/add-and-remove-project-items)
