---
title: View, save, and configure build log files
description: Explore how to configure build log files with information about the compiler and other tools for troubleshooting build failures.
ms.date: 11/13/2025
ms.subservice: compile-build
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs

#customer intent: As a developer, I want to work with build log files in Visual Studio so I can troubleshoot build failures.
---

# View, save, and configure build log files

After you build a project in the Visual Studio Interactive Development Environment (IDE), you can view logged information about the build in the Visual Studio **Output** window. The output data can be saved to log files that you can view in Visual Studio and other editors. 

The logs can help you troubleshoot issues in the build. You can locate the exact command lines used for all build tools, and get full diagnostic data about the entire build process. Visual Studio provides options to specify the kinds of information you want to see in the build output and build log files.

This article describes how to generate, configure, and view build log files in Visual Studio.

## Generate and view build log files

Use the following procedures to generate and view build log files for your scenario.

- **C++ project**:

   Visual Studio saves the log files for you when you build your project. Common locations for the log files include *Release\\\<ProjectName>.log*, *Debug\\\<ProjectName>.log*, and *\<ProjectName>.txt*. All file locations are relative to your project root folder and based on your specific configuration.

   1. Use **Windows Explorer** or **File Explorer** to browse to the log file.
   
   1. Open the log file in your preferred editor.

- **.NET project**:

   For .NET projects, you instruct Visual Studio to save the log files:

   1. In Visual Studio, select **Build** > **Build Solution**.

   1. In the **Output** window, select in the text and use the **Ctrl**+**S** keyboard shortcut.
   
   Visual Studio prompts you for a location to save the build output. You can then open the log files from that location in Visual Studio or another editor.

- **MSBuild**:

   You can generate build logs by running MSBuild directly from the command line by using the `-fileLogger` (`-fl`) command-line option. For more information, see [Obtain build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md).

   With MSBuild, you can also generate binary logs (`-binaryLogger` or `-bl` command-line option). You can view binary logs in the [Structured Log Viewer](https://msbuildlog.com/). The structured log viewer provides a richer UI that might make it easier to understand complex build processes.

You can set environment variables to configure Visual Studio to write a binary log to the filesystem. Set `MSBuildDebugEngine` to `1` and set `MSBUILDDEBUGPATH` to the desired location of the build log file. The variables have to be set in the environment in which Visual Studio is launched. These settings affect all Visual Studio builds, so might not be a good option if you only want logs for a particular invocation of the build.

For more advanced UI support for build logging in .NET projects, consider installing the [Project System Tools extension](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ProjectSystemTools2022). With the extension installed, you can turn binary logging on and off in the UI, and choose from list of logs. However, due to the way it integrates with the Visual Studio build system, the logs are slightly different from the ones you would get from the **Output** window, or with the environment variables.

## Specify data verbosity for build logs

You can specify how much information to include in the build log files. The amount of data in the log file columns is measured as *logger verbosity*. The number of log file rows represent *messages collected*. The log verbosity (column values) affects the types of logged messages (row values). **Quiet** verbosity produces minimal logging in the build output. **Diagnostic** is the most verbose setting and generates log files with all possible data.

The following table shows what types of messages are collected based on the logger verbosity:

| Message type / Verbosity           | Quiet | Minimal | Normal | Detailed | Diagnostic |
|------------------------------------|:-----:|:-------:|:------:|:--------:|:----------:|
| Errors                             |  ✅   |   ✅   |   ✅   |   ✅    |    ✅     |
| Warnings                           |  ✅   |   ✅   |   ✅   |   ✅    |    ✅     |
| High-importance messages           |       |   ✅   |   ✅   |    ✅    |    ✅     |
| Normal-importance messages         |       |         |   ✅   |   ✅    |    ✅     |
| Low-importance messages            |       |         |        |    ✅    |    ✅     |
| Other MSBuild-engine information   |       |         |        |          |    ✅     |

You can configure the logger verbosity with the following steps:

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Projects and Solutions** > **Build and Run** section.

:::moniker-end
:::moniker range="<=vs-2022"

1. Open the **Tools** > **Options** dialog, and expand the **Projects and Solutions** > **Build and Run** section.

:::moniker-end

2. Use the **MSBuild project build output verbosity** dropdown list and select your build output preference. 

3. Use the **MSBuild project build log file verbosity** dropdown list and select your logger verbosity preference. 

   > [!TIP]
   > If you want to see the command lines used for the compiler and other tools, choose at least the **Detailed** verbosity level.

:::moniker range="<=vs-2022"

4. To apply your changes, select **OK**.

:::moniker-end

> [!IMPORTANT]
> You must rebuild the project for your changes to take effect in the **Output** window. For C++ projects, the project rebuild also ensures the changes are reflected in the *\<ProjectName>.txt* file.

For more information, see [Options dialog box, Projects and Solutions, Build and Run](./reference/options-dialog-box-projects-and-solutions-build-and-run.md) and <xref:Microsoft.Build.Framework.LoggerVerbosity>.

## Use binary logs for large log files

:::moniker range="<=vs-2019"

Binary logs are an optional feature for .NET projects that lets you have a richer log browsing experience that might make it easier to find information in large logs. To use binary logs, install the [Project System Tools](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ProjectSystemTools). For more information, see [`https://msbuildlog.com`](https://msbuildlog.com) and [Binary Log](https://github.com/microsoft/msbuild/blob/main/documentation/wiki/Binary-Log.md).

:::moniker-end
:::moniker range=">=vs-2022"

Binary logs are an optional feature for .NET projects that lets you have a richer log browsing experience that might make it easier to find information in large logs. To use binary logs, install the [Project System Tools 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ProjectSystemTools2022). For more information, see [`https://msbuildlog.com`](https://msbuildlog.com) and [Binary Log](https://github.com/microsoft/msbuild/blob/main/documentation/wiki/Binary-Log.md).

:::moniker-end

## Related content

- [Build and clean projects and solutions in Visual Studio](building-and-cleaning-projects-and-solutions-in-visual-studio.md)
- [Compile and build](compiling-and-building-in-visual-studio.md)
- [Obtain build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md)
