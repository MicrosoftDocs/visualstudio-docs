---
title: 'Tutorial: Build an application'
description: Become more familiar with several options that you can configure when you build applications with Visual Studio, such as hiding compiler warnings.
ms.date: 11/18/2025
ms.subservice: compile-build
ms.topic: tutorial
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Tutorial: Build an application

In this article, you'll become more familiar with several options that you can configure when you build applications with Visual Studio. You'll create a custom build configuration, hide certain warning messages, and increase build output information for a sample application.

## Install the sample application

 The sample code used in this tutorial is found at [WPF samples](https://github.com/microsoft/wpf-samples). To clone the repo, use GitHub's green **Clone** button, and choose **Clone in Visual Studio**. You can choose the location on the local hard drive to create a copy of the contents of the repo. The repo contains many solutions. If Visual Studio opens one of the solutions, close the solution and then choose **Open project or solution**, and browse to the location where you cloned the repo, and under that, look for *GettingStarted/WalkthroughFirstWPFApp/csharp/ExpenseItIntro.sln* to work in C#, or *GettingStarted/WalkthroughFirstWPFApp/vb/ExpenseItIntro2.sln* to work in Visual Basic.

## Create a custom build configuration

When you create a solution, Debug and Release build configurations and their default platform targets are defined for the solution automatically. You can then customize these configurations or create your own. Build configurations specify the build type. Build platforms specify the operating system that an application targets for that configuration. For more information, see [Understand build configurations](../ide/understanding-build-configurations.md), [Configure projects to target platforms](../ide/how-to-configure-projects-to-target-platforms.md), and [How to: Set debug and release configurations](../debugger/how-to-set-debug-and-release-configurations.md).

You can change or create configurations and platform settings by using the **Configuration Manager** dialog box. In this procedure, you'll create a build configuration for testing.

### Create a build configuration

:::moniker range="vs-2019"

1. Open the **Configuration Manager** dialog box.

   ![Screenshot of the Build menu, Configuration Manager command.](../ide/media/buildwalk_configurationmanagerdialogbox.png)

1. In the **Active solution configuration** list, choose **\<New...\>**.

   ![Screenshot showing creating a new solution configuration.](media/vs-2022/build-tutorial-active-solution-configuration-new.png)

1. In the **New Solution Configuration** dialog box, name the new configuration `Test`, copy settings from the existing **Debug** configuration, and then choose the **OK** button.

   ![Screenshot of the New Solution Configuration Dialog Box.](../ide/media/buildwalk_newsolutionconfigdlgbox.png)

1. In the **Active solution platform** list, choose **\<New...\>**.

1. In the **New Solution Platform** dialog box, choose **x64**, and don't copy settings from the x86 platform.

   ![Screenshot of New solution platform dialog box.](../ide/media/buildwalk_newsolutionplatform.png)

1. Choose the **OK** button.

   The active solution configuration has been changed to **Test** with the active solution platform set to x64.

   ![Screenshot of Configuration Manager with Test configuration.](../ide/media/buildwalk_configmanagertestconfig.png)

1. Choose **Close**.

You can quickly verify or change the active solution configuration by using the **Solution Configurations** list on the **Standard** toolbar.

![Screenshot of Solution Configurations dropdown list on the Standard toolbar.](../ide/media/buildwalk_standardtoolbarsolutioncongfig.png)
:::moniker-end

:::moniker range=">=vs-2022"

1. Open the **Configuration Manager** dialog box.

   ![Screenshot of the Build menu Configuration Manager command.](media/vs-2022/build-tutorial-configuration-manager-menu.png)

1. In the **Active solution configuration** list, choose **\<New...\>**.

   ![Screenshot showing creating a new solution configuration.](media/vs-2022/build-tutorial-active-solution-configuration-new.png)

1. In the **New Solution Configuration** dialog box, name the new configuration `Test`, copy settings from the existing **Debug** configuration, and then choose the **OK** button.

   ![Screenshot showing creating a Test configuration in the New Solution Configuration dialog box.](media/vs-2022/build-tutorial-create-test-configuration.png)
 
1. In the **Platform** column, expand the dropdown list, and choose **\<New...\>** to create a new project platform.

   ![Screenshot showing creating a new project platform in the Configuration Manager.](media/vs-2022/build-tutorial-configuration-manager-platform-new.png)

1. In the **New Project Platform** dialog box, choose **x64**, and don't copy settings from the x86 platform.

   ![Screenshot of New solution platform dialog box.](media/vs-2022/build-tutorial-project-configuration-manager-new-project-platform.png)
 
   If the **x64** solution platform already exists, uncheck the **Create active solution platform** box.

1. Choose the **OK** button.

   The active solution configuration has been changed to **Test** with the active solution platform set to x64.

   ![Screenshot of Configuration Manager with Test configuration.](media/vs-2022/build-tutorial-configuration-manager.png)
 
1. Choose **Close**.

You can quickly verify or change the active solution configuration by using the **Solution Configurations** list on the **Standard** toolbar.

![Screenshot of Solution Configurations dropdown list on the Standard toolbar.](media/vs-2022/build-tutorial-configuration-dropdown.png)

> [!NOTE]
> If you don't see the active solution configuration or the active platform shown in the toolbar, choose the small arrow-like icon on the far right of the toolbar, and then choose **Add or remove buttons**. Be sure that **Solution Configurations** and **Solution Platforms** are enabled.

:::moniker-end

## Build the application

Next, you'll build the solution with the custom build configuration.

### Build the solution

- On the menu bar, choose **Build** > **Build Solution**, or press **Ctrl**+**Shift**+**B**.

    The **Output** window displays the results of the build. The build succeeded.

## Hide compiler warnings

Next we'll introduce some code that causes a warning to be generated by the compiler.

1. In the C# project, open the *ExpenseReportPage.xaml.cs* file. In the **ExpenseReportPage** method, add the following code: `int i;`.

    OR

    In the Visual Basic project, open the *ExpenseReportPage.xaml.vb* file. In the custom constructor **Public Sub New...**, add the following code: `Dim i`.

1. Build the solution.

The **Output** window displays the results of the build. The build succeeded, but warnings were generated:

:::moniker range="<=vs-2019"
![Screenshot of build warning in Output Window for Visual Basic.](../ide/media/buildwalk_vbbuildoutputwnd.png)

![Screenshot of build warning in Output Window for C#.](../ide/media/buildwalk_csharpbuildoutputwnd.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Screenshot of build warnings in Output window for C#.](media/vs-2022/build-tutorial-build-warning-csharp.png)

![Screenshot of build warnings in Output window for Visual Basic.](media/vs-2022/build-tutorial-build-warning-vb.png)
:::Moniker-end

You can temporarily hide certain warning messages during a build rather than have them clutter up the build output.

### Hide a specific C# warning

1. In **Solution Explorer**, choose the top-level project node.

1. On the menu bar, choose **View** > **Property Pages**.

     The **Project Designer** opens.

1. Choose the **Build** tab or section and then, in the **Suppress warnings** box, specify the warning number **0168**. If other warnings are already listed, use a semicolon as a separator.

    :::moniker range="<=vs-2019"
    ![Screenshot of Build page, Project Designer.](../ide/media/buildwalk_csharpsuppresswarnings.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of Build section in Project Properties.](media/vs-2022/build-tutorial-disable-warning-0168.png)
    :::moniker-end

    For more information, see [Build Page, Project Designer (C#)](../ide/reference/build-page-project-designer-csharp.md).

1. Build the solution using **Build > Rebuild Solution**.

    The **Output** window displays only summary information for the build (no warnings).

    :::moniker range="<=vs-2019"
    ![Screenshot of Output Window for C# with no build warnings](../ide/media/buildwalk_visualcsharpbuildwarnings.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of Output window for C# with no build warnings](media/vs-2022/build-tutorial-output-csharp-no-warning.png)
    :::moniker-end

### Suppress all Visual Basic build warnings

1. In **Solution Explorer**, choose the top-level project node.

2. On the menu bar, choose **View** > **Property Pages**.

     The **Project Designer** opens.

3. On the **Compile** page, select the **Disable all warnings** check box.

     :::moniker range="<=vs-2019"
     ![Compile page, Project Designer.](../ide/media/buildwalk_vbsuppresswarnings.png)
     :::moniker-end
     :::moniker range=">=vs-2022"
     ![Screenshot of disabling warnings in the Compile tab of the Project Designer.](media/vs-2022/build-tutorial-disable-warnings-vb.png)
     :::moniker-end

     For more information, see [Configure warnings in Visual Basic](../ide/configuring-warnings-in-visual-basic.md).

4. Build the solution. If it doesn't rebuild, build the solution using **Build > Rebuild Solution**.

   The **Output** window displays only summary information for the build (no warnings).

   :::moniker range="<=vs-2019"
   ![Screenshot of Output Window for Visual Basic with no build warnings.](../ide/media/buildwalk_visualbasicbuildwarnings.png)
   :::moniker-end
   :::moniker range=">=vs-2022"
   ![Screenshot of Output window for Visual Basic with no build warnings.](media/vs-2022/build-tutorial-build-output-vb-no-warning.png)
   :::moniker-end

   For more information, see [How to: Suppress compiler warnings](../ide/how-to-suppress-compiler-warnings.md).

## Display additional build details in the Output window

You can change how much information about the build process appears in the **Output** window. Build verbosity is usually set to **Minimal**, which means that the **Output** window displays only a summary of the build process along with any high priority warnings or errors. You can display more information about the build by using the [Tools, Options, Projects and Solutions, Build and Run](../ide/reference/options-dialog-box-projects-and-solutions-build-and-run.md).

> [!IMPORTANT]
> If you display more information, the build takes longer to complete.

### Change the amount of information in the Output window

:::moniker range="visualstudio"

1. Open the **Options** pane from the **Tools** menu:

   :::image type="content" source="media/visualstudio/build-tutorial-tools-options-menu-item.png" border="false" alt-text="Screenshot of the Tools menu showing the Options item highlighted.":::

2. Expand the **All Settings** > **Projects and Solutions** > **Build and Run** section.

3. Use the dropdown list and set the **MSBuild project build output verbosity** option to **Normal**.

:::moniker-end
:::moniker range="vs-2022"
     
1. Open the **Options** dialog from the **Tools** menu:

   ![Screenshot of Tools, Options menu item.](media/vs-2022/build-tutorial-tools-options-menu-item.png)

2. Expand the **Projects and Solutions** > **Build and Run** section.

3. Use the dropdown list and set the **MSBuild project build output verbosity** option to **Normal**, and then select **OK**.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Options** dialog from the **Tools** menu:

   ![Screenshot of Options command on the Tools menu.](../ide/media/exploreide-toolsoptionsmenu.png)

2. Expand the **Projects and Solutions** > **Build and Run** section.

3. Use the dropdown list and set the **MSBuild project build output verbosity** option to **Normal**, and then select **OK**.

:::moniker-end

4. On the main toolbar, select **Build** > **Clean Solution**.

5. Build the solution, and then review the information in the **Output** window.

   The build information includes the time that the build started (located at the beginning) and the order in which files were processed. This information also includes the actual compiler syntax that Visual Studio runs during the build.

   For example, in the C# build, the [/nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn) option lists the warning code, **0168**, that you specified earlier in this article, along with three other warnings.

   In the Visual Basic build, [/nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn) doesn't include specific warnings to exclude, so no warnings appear.

   > [!TIP]
   > You can search the contents of the **Output** window if you display the **Find** dialog box by choosing the **Ctrl**+**F** keys.

For more information, see [How to: View, save, and configure build log files](../ide/how-to-view-save-and-configure-build-log-files.md).

## Create a Release Build

You can build a version of the sample application that's optimized for shipping it. For the release build, you'll specify that the executable is copied to a network share before the build is kicked off.

For more information, see [How to: Change the build output directory](../ide/how-to-change-the-build-output-directory.md) and [Build and clean projects and solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md).

### Specify a release build for Visual Basic

1. To open the **Project Designer**, select the project node in **Solution Explorer** by right-clicking and choose **Properties** (or press **Alt**+**Enter**), or on the **View** menu, choose **Property Pages**:

    :::moniker range="<=vs-2019"
    ![Screenshot of View, Property Pages menu item.](../ide/media/buildwalk_viewpropertypages.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of View, Property Pages menu item.](media/vs-2022/build-tutorial-property-pages-menu-item.png)
    :::moniker-end

1. Choose the **Compile** page.

1. In the **Configuration** list, choose **Release**.

1. In the **Platform** list, choose **x86**.

1. In the **Build output path** box, specify a network path.

     For example, you can specify `\\myserver\builds`.

    > [!IMPORTANT]
    > A message box might appear, warning you that the network share that you've specified might not be a trusted location. If you trust the location that you've specified, choose the **OK** button in the message box.

1. Build the application.

    :::moniker range="<=vs-2019"
    ![Build Solution command on the Build menu.](../ide/media/exploreide-buildsolution.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of Build Solution command on the Build menu.](media/vs-2022/build-tutorial-build-menu.png)
    :::moniker-end

### Specify a release build for C\#

1. Open the **Project Designer**.

    :::moniker range="<=vs-2019"
    ![Screenshot of View, Property Pages menu item.](../ide/media/buildwalk_viewpropertypages.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of View, Property Pages menu item.](media/vs-2022/build-tutorial-property-pages-menu-item.png)
    :::moniker-end

1. Choose the **Build** page.

1. In the **Configuration** list, choose **Release**.

1. In the **Platform** list, choose **x86**.

1. In the **Output path** box, specify a network path.

     For example, you could specify `\\myserver\builds`.

    > [!IMPORTANT]
    > A message box might appear, warning you that the network share that you've specified might not be a trusted location. If you trust the location that you've specified, choose the **OK** button in the message box.

1. On the **Standard toolbar**, set the Solution Configurations to **Release** and the Solution Platforms to **x86**.

1. Build the application.

    :::moniker range="<=vs-2019"
    ![Build Solution command on the Build menu.](../ide/media/exploreide-buildsolution.png)
    :::moniker-end
    :::moniker range=">=vs-2022"
    ![Screenshot of Build Solution command on the Build menu.](media/vs-2022/build-tutorial-build-menu.png)
    :::moniker-end

   The executable file is copied to the network path that you specified. Its path would be `\\myserver\builds\\FileName.exe`.

Congratulations! You've successfully completed this tutorial.

## See also

- [Walkthrough: Build a project (C++)](/cpp/ide/walkthrough-building-a-project-cpp)
- [ASP.NET web application project precompilation overview](/previous-versions/aspnet/aa983464\(v\=vs.110\))
- [Walkthrough: Use MSBuild](../msbuild/walkthrough-using-msbuild.md)
