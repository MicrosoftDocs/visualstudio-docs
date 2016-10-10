---
title: "Build Events Page, Project Designer (C#)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3fff9ae5-213c-46ea-a660-1d70acb6c922
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Build Events Page, Project Designer (C#)
Use the **Build Events** page of the **Project Designer** to specify build configuration instructions. You can also specify the conditions under which any post-build events are run. For more information, see [How to: Specify Build Events (C#)](../VS_IDE/How-to--Specify-Build-Events--C#-.md)and [How to: Specify Build Events (Visual Basic)](../VS_IDE/How-to--Specify-Build-Events--Visual-Basic-.md).  
  
## UIElement List  
 **Configuration**  
 This control is not editable in this page. For a description of this control, see [Build Page, Project Designer (C#)](../VS_IDE/Build-Page--Project-Designer--C#-.md).  
  
 **Platform**  
 This control is not editable on this page. For a description of this control, see [Build Page, Project Designer (C#)](../VS_IDE/Build-Page--Project-Designer--C#-.md).  
  
 **Pre-build event command line**  
 Specifies any commands to execute before the build starts. To type long commands, click **Edit Pre-build** to display the [Pre-build Event/Post-build Event Command Line Dialog Box](../VS_IDE/Pre-build-Event-Post-build-Event-Command-Line-Dialog-Box.md).  
  
> [!NOTE]
>  Pre-build events do not run if the project is up to date and no build is triggered.  
  
 **Post-build event command line**  
 Specifies any commands to execute after the build ends. To type long commands, click **Edit Post-build** to display the **Pre-build Event/Post-build Event Command Line Dialog Box**.  
  
> [!NOTE]
>  Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.  
  
 **Run the post-build event**  
 Specifies the following conditions for the post-build event to run, as shown in the following table.  
  
|Option|Result|  
|------------|------------|  
|**Always**|Post-build event will run regardless of whether the build succeeds.|  
|**On successful build**|Post-build event will run if the build succeeds. Thus, the event will run even for a project that is up-to-date, as long as the build succeeds.|  
|**When the build updates the project output**|Post-build event will only run when the compiler's output file (.exe or .dll) is different than the previous compiler output file. Thus, a post-build event is not run if a project is up-to-date.|  
  
## See Also  
 [How to: Specify Build Events (Visual Basic)](../VS_IDE/How-to--Specify-Build-Events--Visual-Basic-.md)   
 [How to: Specify Build Events (C#)](../VS_IDE/How-to--Specify-Build-Events--C#-.md)   
 [Project Properties Reference](../VS_IDE/Project-Properties-Reference.md)   
 [Compiling and Building](../VS_IDE/Compiling-and-Building-in-Visual-Studio.md)