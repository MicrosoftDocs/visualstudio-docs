---
title: "Solutions and Projects in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "10/5/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.addnewsolutionitem"
  - "vs.environment.projects"
  - "vs.openproject"
  - "vs.addnewitem"
  - "vs.addexistingitem"
  - "VS.SolutionExplorer"
  - "vs.newproject"
  - "vs.addexistingsolutionitem"
  - "vs.environment.solutions"
  - "VS.SolutionExplorer.Solutions"
helpviewer_keywords: 
  - "solution items, folder in Solution Explorer"
  - "solution items, shared"
  - "solutions [Visual Studio]"
  - "project items [Visual Studio], about project items"
  - "solutions [Visual Studio], designing"
  - "projects [Visual Studio]"
  - "solutions [Visual Studio], projects and"
  - "projects [Visual Studio], setting up"
ms.assetid: aeaf56cb-c2dd-47f6-b012-23b84b7a7254
caps.latest.revision: 35
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# Solutions and Projects in Visual Studio
When you create an app, website, plug-in, etc. in Visual Studio, you start with a *project*. In a logical sense, a project contains of all the source code files, icons, images, data files and anything else that will be compiled into an executable program or web site, or else is needed in order to perform the compilation. A project also contains all the compiler settings and other configuration files that might be needed by various services or components that your program will communicate with.  

> [!NOTE]
>  You don't have to use solutions or projects if you don't want to. You can simply open the files into Visual Studio and start editing your code. See [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) for more information.  

A project file (.vbproj, .csproj, .vcxproj) is an XML file that defines a virtual folder hierarchy along with paths to all the items in the project. It also contains the build settings. To see the contents of a project file, you can select the project name in Solution Explorer, then choose **Unload Project** from the context (right-click) menu. Then, open the context menu again and choose **Edit \<projectname\>**.  

In Visual Studio, the project file is used by Solution Explorer to display the project contents and settings. When you compile your project, the MSBuild engine consumes the project file to create the executable. You can also customize projects to produce other kinds of output.  

A project is contained, in a logical sense and in the file system, within a *solution*, which may contain one or more related projects, along with build information, Visual Studio window settings, and any miscellaneous files that aren't associated with a particular project. A solution is described by a text file (.sln) with its own unique format; it is generally not intended to be edited by hand.  

A solution has an associated *.suo* file that stores settings, preferences and configuration information for each user that has worked on the project.  

 The following diagram shows the relationship between projects and solutions, and the items they logically contain.  

 ![Visual Studio projects and solutions](../ide/media/vside-project-diagram.png)  

## Creating new projects  
 The easiest way to create a new project is to start from a project template, which consists of a basic set of pre-generated code files, config files, assets, and settings that get you started creating a particular type of application or website in a particular programming language. These templates are what you see in the **New Project** or **New Web Site** dialog box when you choose **File**, **New**, **Project** or **File**, **New**, **Web Site**. For more information, see [Creating Solutions and Projects](../ide/creating-solutions-and-projects.md).  

You can also create custom project and item templates. For more information, see [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md).  

## Managing projects in Solution Explorer  
 After you create a new project, you use **Solution Explorer** to view and manage projects and solutions and their associated items. The following illustration shows Solution Explorer with a C# solution that contains two projects.  

 ![Solution Explorer](../ide/media/vs2015_solution_explorer.png "vs2015_solution_explorer")  

## In This Section  

-   [Creating solutions and projects](../ide/creating-solutions-and-projects.md)  

-   [Adding and removing project items](../ide/adding-and-removing-project-items.md)  

-   [Managing project and solution properties](../ide/managing-project-and-solution-properties.md)  

-   [Managing references in a project](../ide/managing-references-in-a-project.md)  

-   [Application properties](../ide/application-properties.md)  

-   [Managing assembly and manifest signing](../ide/managing-assembly-and-manifest-signing.md)  

-   [How to: specify an application Iicon (Visual Basic, C#)](../ide/how-to-specify-an-application-icon-visual-basic-csharp.md)  

-   [Targeting a specific .NET Framework version](../ide/targeting-a-specific-dotnet-framework-version.md)  

-   [Creating project and item templates](../ide/creating-project-and-item-templates.md)  

## See Also  
 [Visual Studio IDE](../ide/visual-studio-ide.md)
