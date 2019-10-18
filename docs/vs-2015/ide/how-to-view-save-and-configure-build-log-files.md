---
title: "How to: View, Save, and Configure Build Log Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 75d38b76-26d6-4f43-bbe7-cbacd7cc81e7
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: View, Save, and Configure Build Log Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

After you build a project in the Visual Studio IDE, you can view information about that build in the **Output** window. By using this information, you can, for example, troubleshoot a build failure. For C++ projects, you can also view the same information in a .txt file that's created and saved automatically. For managed-code projects, you can copy and paste the information from the **Output** window into a .txt file and save it yourself. You can also use the IDE to specify what kinds of information you want to view about each build.

 If you build any kind of project by using MSBuild, you can create a .txt file to save information about the build. For more information, see [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md).

### To view the build log file for a C++ project

1. In **Windows Explorer** or **File Explorer**, open the following file: \\...\Visual Studio *Version*\Projects\\*ProjectName*\\*ProjectName*\Debug\\*ProjectName*.txt

### To create a build log file for a managed-code project

1. On the menu bar, choose **Build**, **Build Solution**.

2. In the **Output** window, highlight the information from the build, and then copy it to the Clipboard.

3. Open a text editor, such as Notepad, paste the information into the file, and then save it.

### To change the amount of information included in the build log

1. On the menu bar, choose **Tools**, **Options**.

2. On the **Projects and Solutions** page, choose the **Build and Run** page.

3. In the **MSBuild project build output verbosity** list, choose one of the following values, and then choose the **OK** button.

    |Verbosity level|Description|
    |---------------------|-----------------|
    |Quiet|Displays a summary of the build only.|
    |Minimal|Displays a summary of the build and errors, warnings, and messages that are categorized as highly important.|
    |Normal|Displays a summary of the build; errors, warnings, and messages that are categorized as highly important; and the main steps of the build. You'll use this level of detail most frequently.|
    |Detailed|Displays a summary of the build; errors, warnings, and messages that are categorized as highly important; all of the steps of the build; and messages that are categorized as of normal importance.|
    |Diagnostic|Displays all data that's available for the build. You can use this level of detail to help debug issues with custom build scripts and other build issues.|

     For more information, see [Options Dialog Box,  Projects and Solutions, Build and Run](../ide/reference/options-dialog-box-projects-and-solutions-build-and-run.md) and <xref:Microsoft.Build.Framework.LoggerVerbosity>.

    > [!IMPORTANT]
    > You must rebuild the project for your changes to take effect in the **Output** window (all projects) and the *ProjectName*.txt file (C++ projects only).

## See Also
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)
 [Building and Cleaning Projects and Solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
