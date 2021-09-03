---
title: 'How to: View, save, and configure build log files | Microsoft Docs'
description: Learn how you can view, save, and configure build log files. These files provide useful information for tasks like troubleshooting a build failure.
ms.custom: SEO-VS-2020
ms.date: 08/28/2019
ms.technology: vs-ide-compile
ms.topic: how-to
ms.assetid: 75d38b76-26d6-4f43-bbe7-cbacd7cc81e7
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- multiple
---
# How to: View, save, and configure build log files

After you build a project in the Visual Studio IDE, you can view information about that build in the **Output** window. By using this information, you can, for example, troubleshoot a build failure.

- For C++ projects, you can also view the same information in a log file that's created and saved when you build a project. 

- For managed code projects, you can click in the build output window and press **Ctrl**+**S**. Visual Studio prompts you for a location to save the information from the **Output** window into a log file.

You can also use the IDE to specify what kinds of information you want to view about each build.

If you build any kind of project by using MSBuild, you can create a log file to save information about the build. For more information, see [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md).

## To view the build log file for a C++ project

1. In **Windows Explorer** or **File Explorer**, open the following file (relative to the project root folder): *Release*\\{ProjectName}.Log* or *Debug\\{ProjectName}.log*

## To create a build log file for a managed-code project

1. On the menu bar, choose **Build** > **Build Solution**.

2. In the **Output** window, click somewhere in the text.

3. Press **Ctrl**+**S**.

   Visual Studio prompts you for a location to save the build output.

You can also generate logs by running MSBuild directly from the command line, using the `-fileLogger` (`-fl`) command-line option. See [Obtain build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md).

## To change the amount of information included in the build log

1. On the menu bar, choose **Tools** > **Options**.

2. On the **Projects and Solutions** page, choose the **Build and Run** page.

3. In the **MSBuild project build output verbosity** list, choose one of the following values, and then choose the **OK** button.

    |Verbosity level|Description|
    | - |-----------------|
    |**Quiet**|Displays a summary of the build only.|
    |**Minimal**|Displays a summary of the build and errors, warnings, and messages that are categorized as highly important.|
    |**Normal**|Displays a summary of the build; errors, warnings, and messages that are categorized as highly important; and the main steps of the build. You'll use this level of detail most frequently.|
    |**Detailed**|Displays a summary of the build; errors, warnings, and messages that are categorized as highly important; all of the steps of the build; and messages that are categorized as of normal importance.|
    |**Diagnostic**|Displays all data that's available for the build. You can use this level of detail to help debug issues with custom build scripts and other build issues.|

     For more information, see [Options dialog box,  Projects and Solutions, Build and Run](../ide/reference/options-dialog-box-projects-and-solutions-build-and-run.md) and <xref:Microsoft.Build.Framework.LoggerVerbosity>.

    > [!IMPORTANT]
    > You must rebuild the project for your changes to take effect in the **Output** window (all projects) and the *\<ProjectName>.txt* file (C++ projects only).

## Use binary logs to make it easier to browse large log files

Binary logs are an optional feature for .NET projects that lets you have a richer log browsing experience that might make it easier to find information in large logs. To use binary logs, install the [Project System Tools](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ProjectSystemTools). For more information, see [https://msbuildlog.com](https://msbuildlog.com) and [Binary Log](https://github.com/microsoft/msbuild/blob/master/documentation/wiki/Binary-Log.md)

## See also

- [Build and clean projects and solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
