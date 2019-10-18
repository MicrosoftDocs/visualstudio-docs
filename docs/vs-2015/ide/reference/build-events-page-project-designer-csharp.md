---
title: "Build Events Page, Project Designer (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "cs.ProjectPropertiesBuildEvents"
helpviewer_keywords:
  - "build events"
  - "Project Designer, Build Events page"
  - "pre-build events"
  - "post-build events"
ms.assetid: 3fff9ae5-213c-46ea-a660-1d70acb6c922
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Build Events Page, Project Designer (C#)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **Build Events** page of the **Project Designer** to specify build configuration instructions. You can also specify the conditions under which any post-build events are run. For more information, see [How to: Specify Build Events (C#)](../../ide/how-to-specify-build-events-csharp.md)and [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md).

## UIElement List
 **Configuration**
 This control is not editable in this page. For a description of this control, see [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

 **Platform**
 This control is not editable on this page. For a description of this control, see [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

 **Pre-build event command line**
 Specifies any commands to execute before the build starts. To type long commands, click **Edit Pre-build** to display the [Pre-build Event/Post-build Event Command Line Dialog Box](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md).

> [!NOTE]
> Pre-build events do not run if the project is up to date and no build is triggered.

 **Post-build event command line**
 Specifies any commands to execute after the build ends. To type long commands, click **Edit Post-build** to display the **Pre-build Event/Post-build Event Command Line Dialog Box**.

> [!NOTE]
> Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

 **Run the post-build event**
 Specifies the following conditions for the post-build event to run, as shown in the following table.

|Option|Result|
|------------|------------|
|**Always**|Post-build event will run regardless of whether the build succeeds.|
|**On successful build**|Post-build event will run if the build succeeds. Thus, the event will run even for a project that is up-to-date, as long as the build succeeds.|
|**When the build updates the project output**|Post-build event will only run when the compiler's output file (.exe or .dll) is different than the previous compiler output file. Thus, a post-build event is not run if a project is up-to-date.|

## See Also
 [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)
 [How to: Specify Build Events (C#)](../../ide/how-to-specify-build-events-csharp.md)
 [Project Properties Reference](../../ide/reference/project-properties-reference.md)
 [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)
