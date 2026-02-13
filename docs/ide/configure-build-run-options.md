---
title: Configure build and run options in Visual Studio
description: Learn how to configure parallel builds, build verbosity, startup project behavior, and other build and run settings in Visual Studio.
ms.date: 02/09/2026
ms.subservice: compile-build
ms.topic: how-to
f1_keywords:
  - "VS.ToolsOptionsPages.Projects.Build_and_Run"
helpviewer_keywords:
  - "builds [Visual Studio], setting up"
  - "run actions"
  - "debugger, run options"
  - "parallel builds"
  - "build verbosity"
author: ghogen
ms.author: ghogen
manager: mijacobs
ai-usage: ai-assisted
ms.custom: awp-ai
---
# Configure build and run options in Visual Studio

This article shows you how to configure build and run settings in Visual Studio to optimize your build workflow, control build behavior when debugging, and set appropriate verbosity levels for build output.

## Prerequisites

- Visual Studio installed. If you don't have it, see [Install Visual Studio](../install/install-visual-studio.md).
- A solution with one or more projects (required to see the effects of these settings).

## Open the Build and Run options

:::moniker range="visualstudio"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **All Settings** > **Projects and Solutions**.
1. Select **Build and Run** to open the settings pane.

:::moniker-end
:::moniker range="<=vs-2022"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **Projects and Solutions**.
1. Select **Build and Run** to open the settings page.

:::moniker-end

## Configure parallel build settings

You can control how many C++ and C# projects build simultaneously to optimize build performance.

1. Open the **Build and Run** options as described in the previous section.
1. Locate **Maximum number of parallel project builds**.
1. Set the value to the desired number of concurrent builds.

   By default, this value matches the number of CPUs on your computer. The maximum allowed value is 32. Increase this value if you have a powerful machine with many cores, or decrease it if you want to reserve CPU resources for other tasks during builds.

## Control startup project build behavior

You can configure whether Visual Studio builds all projects or only the startup project when you run or debug.

1. Open the **Build and Run** options.
1. To build only the startup project and its dependencies when you press **F5** or select **Debug** > **Start Debugging**, select the **Only build startup projects and dependencies on Run** checkbox.
1. To build all projects in the solution, clear this checkbox.

## Set the startup project for new solutions

To automatically set the currently selected project as the startup project when you create new solutions:

1. Open the **Build and Run** options.
1. Select the **For new solutions use the currently selected project as the startup project** checkbox.

## Configure build behavior for C++ projects

The following options apply to C++ projects only.

### Handle out-of-date projects

Configure how Visual Studio responds when you run a C++ project that has out-of-date files:

1. Open the **Build and Run** options.
1. Locate **On Run, when projects are out of date** and select one of the following options:
   - **Prompt to build** (default) — Displays a prompt asking whether to build the project.
   - **Always build** — Automatically builds the project every time you run it.
   - **Never build** — Runs without building, even if files are out of date.

### Handle build or deployment errors

Configure how Visual Studio responds when you try to run a C++ project after a build failure:

1. Open the **Build and Run** options.
1. Locate **On Run, when build or deployment errors occur** and select one of the following options:
   - **Prompt to launch** (default) — Displays a prompt asking whether to run despite the failure.
   - **Launch old version** — Automatically launches the last successful build. Be aware that this can cause mismatches between your running code and source code.
   - **Do not launch** — Prevents launching when build errors occur.

## Set build output verbosity

Control the amount of information displayed in the **Output** window during builds:

1. Open the **Build and Run** options.
1. Locate **MSBuild project build output verbosity**.
1. Select a verbosity level from the dropdown:
   - **Quiet** — Shows only errors and warnings.
   - **Minimal** — Shows errors, warnings, and a summary.
   - **Normal** — Shows standard build information.
   - **Detailed** — Shows more information for troubleshooting.
   - **Diagnostic** — Shows all available information.

   Use **Minimal** or **Normal** for everyday development. Switch to **Detailed** or **Diagnostic** when troubleshooting build issues.

### Set build log file verbosity (C++ only)

For C++ projects, you can also control the verbosity of the build log file written to *\\\<ProjectName>\Debug\\\<ProjectName>.log*:

1. Open the **Build and Run** options.
1. Locate **MSBuild project build log file verbosity**.
1. Select the desired verbosity level from the dropdown.

:::moniker range=">=vs-2022"

## Run builds at low process priority

If you want to keep your computer responsive during long builds, you can configure Visual Studio to run build processes at a lower priority:

1. Open the **Build and Run** options.
1. Select the **Run build at low process priority** checkbox.

When enabled, Visual Studio runs all compile and link processes at "Below normal" priority. This improves system responsiveness but increases build time. For more information about process priority, see [Scheduling priorities](/windows/win32/procthread/scheduling-priorities).

:::moniker-end

## Related content

- [Compiling and Building](compiling-and-building-in-visual-studio.md)
- [Projects and Solutions options](projects-and-solutions-options-dialog-box.md)
