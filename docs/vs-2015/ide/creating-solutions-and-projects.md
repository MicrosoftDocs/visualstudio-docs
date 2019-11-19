---
title: "Creating Solutions and Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.openprojectfromweb"
  - "vs.newproject"
  - "VS.ToolsOptionsPages.Projects.General"
  - "SolutionItemsProject"
helpviewer_keywords:
  - "solutions [Visual Studio], deleting"
  - "solutions [Visual Studio], creating"
  - "projects [Visual Studio], creating"
ms.assetid: 836f8ca0-3fc9-4f4b-9090-45f2e4d2e9c8
caps.latest.revision: 49
author: jillre
ms.author: jillfra
manager: jillfra
---
# Creating Solutions and Projects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Projects are the logical containers for everything that's needed to build your application. When you create a project by choosing **File &#124; New &#124; Project** from the main menu, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] creates a solution to contain it. You can then add more new or existing projects to the solution if necessary. You can create projects from existing code files and you can create temporary projects (.NET only) that will be deleted when you are done with them.

> [!NOTE]
> The descriptions in this topic are based on the Visual Studio Community edition. The dialog boxes and menu commands you see might differ from those described here, depending on your settings or Visual Studio edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Create a project from an installed project template
 **File &#124; New &#124; Project** from the main menu to bring up the New Project dialog. In the left pane under **Intalled &#124; Templates** chose the programming language and platform or technology, then choose from the available templates in the middle pane.

 In the **New Project** dialog, the **Solution** drop-down gives you the option to create the new project in a new or existing solution, or in a new instance of Visual Studio.

## Create a project from existing code files
 If you have a collection of loose source files, you can easily create a project that contains them. Choose **File &#124; New &#124;Project From Existing Code** to start the **Create Project from Existing Code Files Wizard** and follow the prompts.

> [!TIP]
> This option works best for relatively simple collections of files.

## Create a temporary project (C# and Visual Basic)
 By working with temporary projects, you can create and experiment with a .NET project without specifying a disk location. When you create a project, you just select a project type and template and specify a name in the **New Project** dialog box. At any time while you are working with the temporary project, you can save it, or you can discard it.

## Create a .NET project that targets a specific version of the .NET Framework
 You can create a project to target earlier versions of the .NET Framework by using the **.NET Framework** version drop-down menu at the top of the **New Project** dialog box. Set this value before selecting a project template, as only templates compatible with that .NET Framework version will appear in the list.

 You must have .NET Framework 3.5 installed on your system to access framework versions earlier than 4.0.

## Downloading Sample Solutions
 You can use Visual Studio to download and install sample solutions from the [MSDN Code Gallery](https://go.microsoft.com/fwlink/?LinkId=254185).

 You can download the samples individually, or you can download a Sample Pack, which contains related samples that share a technology or topic. You'll receive a notification when source code changes are published for any sample that you download.

 For more information, see [Visual Studio Samples](../ide/visual-studio-samples.md).

## Adding single files at the solution level
 Sometimes you might have a file that multiple projects refer to, or that contains text or miscellaneous data that logically belongs at the solution level rather than under a specific project.  To add a single item to a solution:

1. Right-click on the solution node in **Solution Explorer** and choose **Add &#124; New Item** or **Add &#124; Existing Item**.

## Creating Empty Solutions
 Although a project must reside in a solution, you can create a solution that has no projects.

#### To create an empty solution

1. On the **File** menu, click **New** and then click **New Project**.

2. In the left pane, select **Installed**, select **Other Project Types**, and then select **Visual Studio Solutions** from the expanded list.

3. In the middle pane, select **Blank Solution**.

4. Set the **Name** and **Location** values for your solution, then click **OK**.

   After you create an empty solution, you can add new or existing projects or items to it by clicking **Add New Item** or **Add Existing Item** on the **Project** menu.

### Deleting Solutions
 You can delete a solution permanently, but not by using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Before you delete a solution, move any projects that you might want to use again in another solution. Then use File Explorer to delete the directory that contains the .sln and .suo solution files.

> [!NOTE]
> The .suo file is a hidden file that is not displayed under default File Explorer settings.

##### To delete a solution

1. In **Solution Explorer**, right-click the solution to delete, and select **Open folder in File Explorer**.

2. In File Explorer, navigate up one level.

3. Select the directory containing the solution and press Delete.

## See Also
 [Solutions and Projects](../ide/solutions-and-projects-in-visual-studio.md)
 [NIB How to: Create Multi-Project Solutions](https://msdn.microsoft.com/02ecd6dd-0114-46fe-b335-ba9c5e3020d6)
