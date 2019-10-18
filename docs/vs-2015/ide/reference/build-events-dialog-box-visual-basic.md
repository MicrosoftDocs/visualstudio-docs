---
title: "Build Events Dialog Box (Visual Basic) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "vb.ProjectPropertiesBuildEvents"
helpviewer_keywords: 
  - "build events"
  - "build events, specifying"
  - "pre-build events"
  - "Build Events dialog box"
  - "post-build events"
ms.assetid: 3a81a7c7-39f9-47a8-ba5a-b351227f380e
caps.latest.revision: 8
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Build Events Dialog Box (Visual Basic)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **Build Events** dialog box to specify build configuration instructions. You can also specify the conditions under which any pre-build or post-build events are run. For more information, see [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md).  
  
 **Pre-build event command line**  
 Specifies any commands to execute before the build starts. To type long commands, click **Edit Pre-build** to display the [Pre-build Event/Post-build Event Command Line Dialog Box](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md).  
  
> [!NOTE]
> Pre-build events do not run if the project is up-to-date and no build is triggered.  
  
 **Post-build event command line**  
 Specifies any commands to execute after the build ends. To type long commands, click **Edit Post-build** to display the **Pre-build Event/Post-build Event Command Line d**ialog box.  
  
> [!NOTE]
> Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.  
  
 **Run the post-build event**  
 Specifies the conditions for the post-build event to run, as shown in the following table.  
  
|Option|Result|  
|------------|------------|  
|**Always**|Post-build event will run, regardless of whether the build succeeds.|  
|**On successful build**|Post-build event will run if the build succeeds. The event will run even for a project that is up-to-date, as long as the build succeeds. This is the default setting.|  
|**When the build updates the project output**|Post-build event will run only when the compiler's output file (.exe or .dll) differs from the previous compiler output file. A post-build event is not run if a project is up-to-date.|  
  
## See also  
 [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)   
 [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)   
 [Pre-build Event/Post-build Event Command Line Dialog Box](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
