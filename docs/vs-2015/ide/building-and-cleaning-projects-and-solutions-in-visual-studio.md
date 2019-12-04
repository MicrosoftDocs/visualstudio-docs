---
title: Build clean projects solutions
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
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
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Building and Cleaning Projects and Solutions in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using the procedures in this topic, you can build, rebuild, or clean all or some of the projects or project items in a solution. For a step-by-step tutorial, see [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md).

> [!NOTE]
> The UI in your edition of Visual Studio might differ from what this topic describes, depending on your active settings. To change your settings, open the **Tools** menu, and then choose **Import and Export Settings**. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

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

2. On the menu bar, choose **Build**, and then choose either **Build** _ProjectName_ or **Rebuild** _ProjectName_.

    - Choose **Build** _ProjectName_ to build only those project components that have changed since the most recent build.

    - Choose **Rebuild** _ProjectName_ to "clean" the project and then build the project files and all project components.

## To build only the startup project and its dependencies

1. On the menu bar, choose **Tools**, **Options**.

2. In the **Options** dialog box, expand the **Projects and Solutions** node, and then choose the **Build and Run** page.

    The **Build and Run, Projects and Solutions, Options** dialog box opens.

3. Select the  **Only build startup projects and dependencies on Run** check box.

    When this check box is selected, only the current startup project and its dependencies are built when you perform either of the following steps:

   - On the menu bar, choose **Debug** > **Start Debugging** (F5).

   - On the menu bar, choose **Build** > **Build Solution** (CTRL+SHIFT+B).

     When this check box is cleared, all projects, their dependencies, and the solution files are built when you run either of the preceding commands. By default, this check box is cleared.

## To build only the selected Visual C++ project

1. Choose a [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] project, and then, on the menu bar, choose **Build**, **Project Only**, and one of the following commands:

   - **Build Only** *ProjectName*

   - **Rebuild Only** *ProjectName*

   - **Clean Only** *ProjectName*

   - **Link Only** *ProjectName*

     These commands apply only to the [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] project that you chose, without building, rebuilding, cleaning, or linking any project dependencies or solution files. Depending on your version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], the **Project Only** submenu might contain more commands.

## To compile multiple C++ project items

1. In **Solution Explorer**, choose multiple files that have can be compiled actions, open the shortcut menu for one of those files, and then choose **Compile**.

     If the files have dependencies, the files will be compiled in dependency order. The compile operation will fail if the files require a precompiled header that isn’t available when you compile. The compile operation uses the current active solution configuration.

## To stop a build

1. Perform either of the following steps:

    - On the menu bar, choose **Build**, **Cancel**.

    - Choose the Ctrl + Break keys.

## See also
 [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md)
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)
 [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e)
 [C/C++ Building Reference](https://msdn.microsoft.com/library/100b4ccf-572c-4d1f-970c-fa0bc0cc0d2d)
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)
 [Solutions and Projects](../ide/solutions-and-projects-in-visual-studio.md)
