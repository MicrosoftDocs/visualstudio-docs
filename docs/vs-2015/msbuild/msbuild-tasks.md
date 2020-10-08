---
title: "MSBuild Tasks | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "tasks"
  - "MSBuild, tasks"
ms.assetid: 5d3cc4a7-e5db-4f73-b707-8b6882fddcf8
caps.latest.revision: 21
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Tasks
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A build platform needs the ability to execute any number of actions during the build process. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] uses *tasks* to perform these actions. A task is a unit of executable code used by [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] to perform atomic build operations.  
  
## Task Logic  
 The [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] XML project file format cannot fully execute build operations on its own, so task logic must be implemented outside of the project file.  
  
 The execution logic of a task is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ITask> interface, which is defined in the <xref:Microsoft.Build.Framework> namespace.  
  
 The task class also defines the input and output parameters available to the task in the project file. All public settable non-static non-abstract properties exposed by the task class can be accessed in the project file by placing a corresponding attribute with the same name on the [Task](../msbuild/task-element-msbuild.md) element.  
  
 You can write your own task by authoring a managed class that implements the <xref:Microsoft.Build.Framework.ITask> interface. For more information, see [Task Writing](../msbuild/task-writing.md).  
  
## Executing a Task from a Project File  
 Before executing a task in your project file, you must first map the type in the assembly that implements the task to the task name with the [UsingTask](../msbuild/usingtask-element-msbuild.md) element. This lets [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] know where to look for the execution logic of your task when it finds it in your project file.  
  
 To execute a task in an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file, create an element with the name of the task as a child of a `Target` element. If a task accepts parameters, these are passed as attributes of the element.  
  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] item lists and properties can be used as parameters. For example, the following code calls the `MakeDir` task and sets the value of the `Directories` property of the `MakeDir` object equal to the value of the `BuildDir` property declared in the previous example.  
  
```  
<Target Name="MakeBuildDirectory">  
    <MakeDir  
        Directories="$(BuildDir)" />  
</Target>  
```  
  
 Tasks can also return information to the project file, which can be stored in items or properties for later use. For example, the following code calls the `Copy` task and stores the information from the `CopiedFiles` output property in the `SuccessfullyCopiedFiles` item list.  
  
```  
<Target Name="CopyFiles">  
    <Copy  
        SourceFiles="@(MySourceFiles)"  
        DestinationFolder="@(MyDestFolder)">  
        <Output  
            TaskParameter="CopiedFiles"  
            ItemName="SuccessfullyCopiedFiles"/>  
     </Copy>  
</Target>  
```  
  
## Included Tasks  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] ships with many tasks such as [Copy](../msbuild/copy-task.md), which copies files, [MakeDir](../msbuild/makedir-task.md), which creates directories, and [Csc](../msbuild/csc-task.md), which compiles [!INCLUDE[csprcs](../includes/csprcs-md.md)] source code files. For a complete list of available tasks and usage information, see [Task Reference](../msbuild/msbuild-task-reference.md).  
  
## Overridden Tasks  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] looks for tasks in several locations. The first location is in files with the extension .OverrideTasks stored in the .NET Framework directories. Tasks in these files override any other tasks with the same names, including tasks in the project file. The second location is in files with the extension .Tasks in the .NET Framework directories. If the task is not found in either of these locations, the task in the project file is used.  
  
## See Also  
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)   
 [MSBuild](msbuild.md)   
 [Task Writing](../msbuild/task-writing.md)   
 [Inline Tasks](../msbuild/msbuild-inline-tasks.md)
