---
title: "Create solutions and projects | Microsoft Docs"
ms.custom: ""
ms.date: "03/21/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 46
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---

# Create solutions and projects

Projects are the logical containers for everything that's needed to build your application. When you create a project by choosing **File**, **New**, **Project** on the main menu, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] creates a solution to contain it. You can then add more new or existing projects to the solution if necessary. You can create projects from existing code files and you can create temporary projects (.NET only) that will be deleted when you are done with them.

> [!NOTE]
>  The descriptions in this topic are based on the Visual Studio Community edition. The dialog boxes and menu commands you see might differ from those described here, depending on your settings or Visual Studio edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Create a project from an installed project template  
 Choose **File**, **New**, **Project** on the main menu to display the New Project dialog. In the left pane under **Installed**, **Templates**, choose the programming language and platform or technology, then choose from the available templates in the middle pane.  

 In the **New Project** dialog, the **Solution** drop-down gives you the option to create the new project in a new or existing solution, or in a new instance of Visual Studio.  

|         |         |
|---------|---------|
|  ![movie camera icon for video](media/video-icon.png "Watch a video")  |    [Watch a video](https://mva.microsoft.com/en-us/training-courses/getting-started-with-visual-studio-2017-17798?l=nRw1vJD6D_6311787171) on how to create a new project in Visual Studio from a template. |

## Create a project from existing code files  
 If you have a collection of loose source files, you can easily create a project that contains them. Choose **File**, **New**, **Project From Existing Code** to start the **Create Project from Existing Code Files** wizard, and then follow the prompts.  

> [!TIP]
>  This option works best for a relatively simple collections of files.  

## Create a temporary project (C# and Visual Basic)
 By working with temporary projects, you can create and experiment with a .NET project without specifying a disk location. When you create a project, you just select a project type and template and specify a name in the **New Project** dialog box. At any time while you are working with the temporary project, you can save it, or you can discard it.  

## Create a .NET project that targets a specific version of the .NET Framework  
 You can create a project to target earlier versions of the .NET Framework by using the **.NET Framework** version drop-down menu at the top of the **New Project** dialog box. Set this value before selecting a project template, as only templates compatible with that .NET Framework version will appear in the list.  

 You must have .NET Framework 3.5 installed on your system to access framework versions earlier than 4.0.  

## Download sample solutions  
 You can use Visual Studio to download and install sample solutions from the [MSDN Code Gallery](http://go.microsoft.com/fwlink/?LinkId=254185) as well as from other sources, such as Git repositories.

 You can download the samples individually, or you can download a Sample Pack, which contains related samples that share a technology or topic. You'll receive a notification when source code changes are published for any sample that you download.  

 For more information, see [Visual Studio Samples](../ide/visual-studio-samples.md).  

## Add single files at the solution level  
 Sometimes you might have a file that multiple projects refer to, or that contains text or miscellaneous data that logically belongs at the solution level rather than under a specific project.  To add a single item to a solution:  

- Right-click on the solution node in **Solution Explorer** and choose **Add**, **New Item** or **Add**, **Existing Item**.  

## Create empty solutions  
 Although projects can reside in a solution, you can also create solutions that have no projects. You can also open code projects without needing a solution.

#### To create an empty solution  

1.  On the **File** menu, choose **New**, **Project**.  

2.  In the left pane, choose **Installed**, **Other Project Types**, **Visual Studio Solutions** in the expanded list.  

3.  In the middle pane, choose **Blank Solution**.  

4.  Set the **Name** and **Location** values for your solution, then choose **OK**.  

After you create an empty solution, you can add new or existing projects or items to it by selecting it in Solution Explorer and then choosing **Add New Item** or **Add Existing Item** on the **Project** menu.

### Delete solutions  
 You can delete a solution permanently, but not by using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Before you delete a solution, move any projects that you might want to use again into another solution. Then use File Explorer to delete the directory that contains the .sln and .suo solution files.  

> [!NOTE]
>  The .suo file is a hidden file that is not displayed under default File Explorer settings.  

##### To delete a solution  

1.  In **Solution Explorer**, on the context (right-click) menu of the solution you want to delete, choose **Open folder in File Explorer**.

2.  In File Explorer, navigate up one level.

3.  Choose the folder that contains the solution and then press the DELETE key.

## See Also  
 [Solutions and Projects](../ide/solutions-and-projects-in-visual-studio.md)   
