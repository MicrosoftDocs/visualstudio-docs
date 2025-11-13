---
title: Options dialog, Projects and Solutions, Build and Run
description: Specify the maximum number of C++ or C# projects that can build at the same time, certain default build behaviors, and some build log settings in Visual Studio.
ms.date: 08/25/2023
ms.subservice: compile-build
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Projects.Build_and_Run"
helpviewer_keywords:
  - "builds [Visual Studio], setting up"
  - "run actions"
  - "debugger, run options"
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Options dialog box: Projects and Solutions \> Build and Run

In this dialog box, you can specify the maximum number of C++ or C# projects that can build at the same time, certain default build behaviors, and some build log settings. To access these options, select **Tools** > **Options** expand **Projects and Solutions**, and then select **Build and Run**.

**Maximum number of parallel project builds**

Specifies the maximum number of C++ and C# projects that can build at the same time. To optimize the build process, the maximum number of parallel project builds is automatically set to the number of CPUs of your computer. The maximum is 32.

**Only build startup projects and dependencies on Run**

Builds only the startup project and its dependencies when you use the **F5** key, the **Debug** > **Start Debugging** menu command, or applicable commands on the **Build** menu. If unchecked, all projects and dependencies are built.

**On Run, when projects are out of date**

*Applies to C++ projects only.*

When running a project with **F5** or the **Debug** > **Start Debugging** command, the default setting **Prompt to build** displays a message if a project configuration is out of date. Select **Always build** to build the project every time it is run. Select **Never build** to suppress all automatic builds when a project is run.

**On Run, when build or deployment errors occur**

*Applies to C++ projects only.*

When running a project with **F5** or the **Debug** > **Start Debugging** command, the default setting **Prompt to launch** displays a message if a project should be run even if the build failed. Select **Launch old version** to automatically launch the last good build, which could result in mismatches between the running code and the source code. Select **Do not launch** to suppress the message.

**For new solutions use the currently selected project as the startup project**

When this option is set, new solutions use the currently selected project as the startup project.

**MSBuild project build output verbosity**

Determines how much information from the build process is displayed in the **Output** window.

**MSBuild project build log file verbosity**

*Applies to C++ projects only.*

Determines how much information is written to the build log file, which is located at *\\\<ProjectName>\Debug\\\<ProjectName>.log*.

:::moniker range=">=vs-2022"
**Run build at low process priority**

Instructs Visual Studio to run all compile and link processes at "Below normal" priority, as managed by the operating system. Selecting this option increases the responsiveness of your computer during the execution of a build, but increases the length of time it takes to complete a build. For information about how process priority works on Windows, see [Scheduling priorities](/windows/win32/procthread/scheduling-priorities).
:::moniker-end

## See also

- [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)
- [Options Dialog Box, Projects and Solutions](projects-and-solutions-options-dialog-box.md)
- [Options Dialog Box, Projects and Solutions, Web Projects](/previous-versions/visualstudio/visual-studio-2017/ide/reference/options-dialog-box-projects-and-solutions-web-projects)
