---
title: Build and clean projects and solutions
description: Build, rebuild, or clean some of your projects or project items, or all of your projects, in your Visual Studio project solution.
ms.date: 9/3/2025
ms.subservice: compile-build
ms.topic: conceptual
f1_keywords:
- VS.BuildProjectPicker
- vs.batchbuild
helpviewer_keywords:
- Clean Solution command
- builds [Visual Studio], managing
- solution build configurations, starting
- Build Solution command
- project build configurations, starting
- build configurations, starting
- project build configurations, dependencies
- Rebuild Solution command
- solution build configurations, build order
- builds [Visual Studio], preparing
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Build and clean projects and solutions in Visual Studio

By using the procedures in this topic, you can build, rebuild, or clean all or some of the projects or project items in a solution. For a step-by-step tutorial, see [Walkthrough: Building an application](../ide/walkthrough-building-an-application.md).

> [!NOTE]
> The UI in your edition of Visual Studio might differ from what this topic describes, depending on your active settings. To change your settings, for example to **General** or **Visual C++** settings, choose **Tools** > **Import and Export Settings**, and then choose **Reset all settings**.

## To build, rebuild, or clean a solution

Use this procedure to build the solution in the current configuration (for example, `Debug` or `Release`). If you want to build multiple configurations at once, see [Batch build](#batch-build).

1. In **Solution Explorer**, choose or open the solution.

2. On the menu bar, choose **Build**, and then choose one of the following commands:

    - Choose **Build** or **Build Solution**, or press **Ctrl**+**Shift**+**B**, to compile only those project files and components that have changed since the most recent build.

        > [!NOTE]
        > The **Build** command becomes **Build Solution** when a solution includes more than one project.

    - Choose **Rebuild Solution** to "clean" the solution and then build all project files and components.

    - Choose **Clean Solution** to delete any intermediate and output files. With only the project and component files left, new instances of the intermediate and output files can then be built.

## To build or rebuild a single project

1. In **Solution Explorer**, choose or open the project.

2. On the menu bar, choose **Build**, and then choose either **Build** *ProjectName* or **Rebuild** *ProjectName*.

    - Choose **Build** *ProjectName* to build only those project components that have changed since the most recent build.

    - Choose **Rebuild** *ProjectName* to "clean" the project and then build the project files and all project components.

## To build only the startup project and its dependencies

1. On the menu bar, choose **Tools** > **Options**.

2. In the **Options** dialog box, expand the **Projects and Solutions** node, and then choose the **Build and Run** page.

     The **Build and Run** > **Projects and Solutions** > **Options** dialog box opens.

3. Select the  **Only build startup projects and dependencies on Run** check box.

     When this check box is selected, only the current startup project and its dependencies are built when you choose **Debug** > **Start** (**F5**) or **Debug** > **Start Without Debugging** (**Ctrl**+**F5**).

    When you choose **Build** > **Build Solution** (**Ctrl**+**Shift**+**B**), the entire solution is built.

    When this check box is cleared, all projects, their dependencies, and the solution files are built when you run any of the preceding commands.

You can see build progress and output in the **Output** window. You also see an icon in the status bar at the bottom of the Visual Studio window that indicates a build is running.

The underlying build tool that Visual Studio uses is called [MSBuild](../msbuild/msbuild.md). MSBuild uses optimizations such as incremental build to minimize rebuilding the same files if they haven't changed, so the first time you build a solution, it might take a long time for large solutions, but subsequent builds are usually faster.

## Batch build

When you build using **Build solution** or **Build project** options, Visual Studio builds the current configuration. You can use the batch build command to build multiple configurations in one operation.

From the menu bar, choose **Build** > **Batch build**. The **Batch build** dialog box appears.

:::image type="content" source="media/building-and-cleaning-projects-and-solutions/batch-build.png" border="false" alt-text="Screenshot of the Batch build dialog box.":::

Select the desired projects and configurations and use the buttons to build, rebuild, or clean. The build operations start immediately, and all the output appears in the **Output** window.

The selections you made are remembered the next time you open the **Batch build** dialog box.

> [!NOTE]
> Batch build is not available for all project types. See [Build multiple configurations simultaneously](how-to-build-multiple-configurations-simultaneously.md).

## To build only the selected Visual C++ project

Choose a C++ project, and then, on the menu bar, choose **Build** > **Project Only**, and one of the following commands:

- **Build Only** *ProjectName*

- **Rebuild Only** *ProjectName*

- **Clean Only** *ProjectName*

- **Link Only** *ProjectName*

These commands apply only to the C++ project that you chose, without building, rebuilding, cleaning, or linking any project dependencies or solution files. Depending on your version of Visual Studio, the **Project Only** submenu might contain more commands.

## To compile multiple C++ project items

In **Solution Explorer**, choose multiple files that can be compiled, open the shortcut menu for one of those files, and then choose **Compile**, or press **Ctrl**+**F7**.

If the files have dependencies, the files will be compiled in dependency order. The compile operation will fail if the files require a precompiled header that isn't available when you compile. The compile operation uses the current active solution configuration.

## To stop a build

Perform either of the following steps:

- On the menu bar, select **Build** > **Cancel**.

- Press **Ctrl**+**Break**.

The **Cancel** menu item only appears unless a build is currently runing.

## Related content

- [How to: View, save, and configure build log files](../ide/how-to-view-save-and-configure-build-log-files.md)
- [Obtaining build logs](../msbuild/obtaining-build-logs-with-msbuild.md)
- [Compiling and building](../ide/compiling-and-building-in-visual-studio.md)
- [Understanding build configurations](../ide/understanding-build-configurations.md)
- [How to: Set debug and release configurations](../debugger/how-to-set-debug-and-release-configurations.md)
- [C/C++ building reference](/cpp/build/reference/c-cpp-building-reference)
- [Devenv command line switches](../ide/reference/devenv-command-line-switches.md)
- [Solutions and projects](../ide/solutions-and-projects-in-visual-studio.md)
