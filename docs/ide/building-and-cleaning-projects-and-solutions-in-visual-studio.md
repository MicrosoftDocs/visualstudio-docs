---
title: Building and Cleaning Projects and Solutions
ms.date: 11/04/2016
ms.technology: vs-ide-compile
ms.topic: conceptual
f1_keywords:
  - "VS.BuildProjectPicker"
  - "vs.batchbuild"
helpviewer_keywords:
  - "Clean Solution command"
  - "builds [Visual Studio], managing"
  - "solution build configurations, starting"
  - "Build Solution command"
  - "project build configurations, starting"
  - "build configurations, starting"
  - "project build configurations, dependencies"
  - "Rebuild Solution command"
  - "solution build configurations, build order"
  - "builds [Visual Studio], preparing"
ms.assetid: 710891fd-379e-42c2-a84b-44a7af694ca0
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# Build and clean projects and solutions in Visual Studio

By using the procedures in this topic, you can build, rebuild, or clean all or some of the projects or project items in a solution. For a step-by-step tutorial, see [Walkthrough: Building an application](../ide/walkthrough-building-an-application.md).

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Build and clean projects and solutions in Visual Studio for Mac](/visualstudio/mac/building-and-cleaning-projects-and-solutions).

> [!NOTE]
> The UI in your edition of Visual Studio might differ from what this topic describes, depending on your active settings. To change your settings, for example to **General** or **Visual C++** settings, choose **Tools** > **Import and Export Settings**, and then choose **Reset all settings**.

## To build, rebuild, or clean an entire solution

1. In **Solution Explorer**, choose or open the solution.

2. On the menu bar, choose **Build**, and then choose one of the following commands:

    - Choose **Build** or **Build Solution** to compile only those project files and components that have changed since the most recent build.

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

     When this check box is selected, only the current startup project and its dependencies are built when you perform either of the following steps:

    - On the menu bar, choose **Debug** > **Start** (**F5**).

    - On the menu bar, choose **Build** > **Build Solution** (**Ctrl**+**Shift**+**B**).

    When this check box is cleared, all projects, their dependencies, and the solution files are built when you run either of the preceding commands. By default, this check box is cleared.

## To build only the selected Visual C++ project

Choose a [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] project, and then, on the menu bar, choose **Build** > **Project Only**, and one of the following commands:

- **Build Only** *ProjectName*

- **Rebuild Only** *ProjectName*

- **Clean Only** *ProjectName*

- **Link Only** *ProjectName*

These commands apply only to the [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] project that you chose, without building, rebuilding, cleaning, or linking any project dependencies or solution files. Depending on your version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], the **Project Only** submenu might contain more commands.

## To compile multiple C++ project items

In **Solution Explorer**, choose multiple files that have can be compiled actions, open the shortcut menu for one of those files, and then choose **Compile**.

If the files have dependencies, the files will be compiled in dependency order. The compile operation will fail if the files require a precompiled header that isn't available when you compile. The compile operation uses the current active solution configuration.

## To stop a build

Perform either of the following steps:

- On the menu bar, select **Build** > **Cancel**.

- Press **Ctrl**+**Break**.

## See also

- [How to: View, save, and configure build log files](../ide/how-to-view-save-and-configure-build-log-files.md)
- [Obtaining build logs](../msbuild/obtaining-build-logs-with-msbuild.md)
- [Compiling and building](../ide/compiling-and-building-in-visual-studio.md)
- [Understanding build configurations](../ide/understanding-build-configurations.md)
- [How to: Set debug and release configurations](../debugger/how-to-set-debug-and-release-configurations.md)
- [C/C++ building reference](/cpp/build/reference/c-cpp-building-reference)
- [Devenv command line switches](../ide/reference/devenv-command-line-switches.md)
- [Solutions and projects](../ide/solutions-and-projects-in-visual-studio.md)
- [Build and clean projects and solutions (Visual Studio for Mac)](/visualstudio/mac/building-and-cleaning-projects-and-solutions)