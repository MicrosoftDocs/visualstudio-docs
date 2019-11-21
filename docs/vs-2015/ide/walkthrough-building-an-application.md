---
title: "Walkthrough: Building an Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 4842955d-8959-4e4e-98b8-2358360179b3
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Building an Application

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By completing this walkthrough, you’ll  become more familiar with several options that you can configure when you build applications with Visual Studio. You’ll create a custom build configuration, hide certain warning messages, and increase build output information, among other tasks, for a sample application.

This topic contains the following sections:

[Install the Sample Application](../ide/walkthrough-building-an-application.md)

[Create a Custom Build Configuration](../ide/walkthrough-building-an-application.md#BKMK_CreateBuildConfig)

[Build the Application](../ide/walkthrough-building-an-application.md#BKMK_building)

[Hide Compiler Warnings](../ide/walkthrough-building-an-application.md#BKMK_hidewarning)

[Display Additional Build Details in the Output Window](../ide/walkthrough-building-an-application.md#BKMK_outputdetails)

[Create a Release Build](../ide/walkthrough-building-an-application.md)

#### To install the sample application

1. On the menu bar, choose **Tools**, **Extensions and Updates**.

2. Choose the **Online** category, and then choose the **Samples Gallery** category.

3. Specify `Introduction` in the search box to find the sample.

    ![Extensions and Updates dialog box](../ide/media/buildwalk-extensionsdialogsampledownload.png "BuildWalk_ExtensionsDialogSampleDownload")

4. In the results list, choose either **Introduction to Building WPF Applications (Visual C#)** or **Introduction to Building WPF Applications (Visual Basic)**.

5. Choose the **Download** button, and then choose the **Close** button.

   The Introduction to Building WPF Applications sample appears in the **New Project** dialog box.

#### To create a solution for the sample application

1. Open the **New Project** dialog box.

     ![On the menu bar, choose File, New, Project](../ide/media/exploreide-filenewproject.png "ExploreIDE-FileNewProject")

2. In the **Installed** category, choose the **Samples** category to display the Introduction to Building WPF Applications sample.

3. Name the solution `IntroWPFcsharp` for Visual C#.

     ![New Project dialog box, Installed Samples](../ide/media/buildwalk-newprojectdlgintrotowpfsample.png "BuildWalk_NewProjectdlgIntrotoWPFsample")

     OR

     Name the solution `IntroWPFvb` for Visual Basic.

     ![New Project dialog box, Visual Basic Sample](../ide/media/buildwalk-newprojectdlgintrotowpfsamplevb.png "BuildWalk_NewProjectdlgIntrotoWPFsampleVB")

4. Choose the **OK** button.

## <a name="BKMK_CreateBuildConfig"></a> Create a Custom Build Configuration

When you create a solution, debug and release build configurations and their default platform targets are defined for the solution automatically. You can then customize these configurations or create your own. Build configurations specify the build type. Build platforms specify the operating system that an application targets for that configuration. For more information, see [Understanding Build Configurations](../ide/understanding-build-configurations.md), [Understanding Build Platforms](../ide/understanding-build-platforms.md), and [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e).

You can change or create configurations and platform settings by using the **Configuration Manager** dialog box. In this procedure, you’ll create a build configuration for testing.

#### To create a build configuration

1. Open the **Configuration Manager** dialog box.

    ![Build menu, Configuration Manager command](../ide/media/buildwalk-configurationmanagerdialogbox.png "BuildWalk_ConfigurationManagerDialogBox")

2. In the **Active solution configuration** list, choose **New**.

3. In the **New Solution Configuration** dialog box, name the new configuration `Test`, copy settings from the existing Debug configuration, and then choose the **OK** button.

    ![New Solution Configuration Dialog Box](../ide/media/buildwalk-newsolutionconfigdlgbox.png "BuildWalk_NewSolutionConfigDlgBox")

4. In the **Active solution platform** list, choose **New**.

5. In the **New Solution Platform** dialog box, choose **x64**, and don’t copy settings from the x86 platform.

    ![New Solution Platform Dialog Box](../ide/media/buildwalk-newsolutionplatform.png "BuildWalk_NewSolutionPlatform")

6. Choose the **OK** button.

   The active solution configuration has been changed to Test with the active solution platform set to x64.

   ![Configuration Manager with Test configuration](../ide/media/buildwalk-configmanagertestconfig.png "BuildWalk_ConfigManagerTestconfig")

   You can quickly verify or change the active solution configuration by using the **Solution Configurations** list on the **Standard** toolbar.

   ![Solution Configuration option Standard Toolbar](../ide/media/buildwalk-standardtoolbarsolutioncongfig.png "BuildWalk_StandardToolbarSolutionCongfig")

## <a name="BKMK_building"></a> Build the Application

Next, you’ll build the solution with the custom build configuration.

#### To build the solution

- On the menu bar, choose **Build**, **Build Solution**.

  The **Output** window displays the results of the build. The build succeeded, but several warning messages were generated.

  Figure 1: Visual Basic warnings

  ![Output Window Visual Basic](../ide/media/buildwalk-vbbuildoutputwnd.png "BuildWalk_VBBuildOutputWnd")

  Figure 2: Visual C# warnings

  ![Output Window Visual C&#35;](../ide/media/buildwalk-csharpbuildoutputwnd.png "BuildWalk_CsharpBuildOutputWnd")

## <a name="BKMK_hidewarning"></a> Hide Compiler Warnings

You can temporarily hide certain warning messages during a build rather than have them clutter up the build output.

#### To hide a specific Visual C# warning

1. In **Solution Explorer**, choose the top-level project node.

2. On the menu bar, choose **View**, **Property Pages**.

     The **Project Designer** opens.

3. Choose the **Build** page and then, in the **Suppress warnings** box, specify the warning number `1762`.

     ![Build page, Project Designer](../ide/media/buildwalk-csharpsuppresswarnings.png "BuildWalk_CsharpSuppressWarnings")

     For more information, see [Build Page, Project Designer (C#)](../ide/reference/build-page-project-designer-csharp.md).

4. Build the solution.

     The **Output** window displays only summary information for the build.

     ![Output Window, Visual C&#35; Build Warnings](../ide/media/buildwalk-visualcsharpbuildwarnings.png "BuildWalk_VisualCsharpBuildWarnings")

#### To suppress all Visual Basic build warnings

1. In **Solution Explorer**, choose the top-level project node.

2. On the menu bar, choose **View**, **Property Pages**.

    The **Project Designer** opens.

3. On the **Compile** page, select the **Disable all warnings** check box.

    ![Compile page, Project Designer](../ide/media/buildwalk-vbsuppresswarnings.png "BuildWalk_VBSuppressWarnings")

    For more information, see [Configuring Warnings in Visual Basic](../ide/configuring-warnings-in-visual-basic.md).

4. Build the solution.

   The **Output** window displays only summary information for the build.

   ![Output Window, Visual Basic Build Warnings](../ide/media/buildwalk-visualbasicbuildwarnings.png "BuildWalk_VisualBasicBuildWarnings")

   For more information, see [How to: Suppress Compiler Warnings](../ide/how-to-suppress-compiler-warnings.md).

## <a name="BKMK_outputdetails"></a> Display Additional Build Details in the Output Window

You can change how much information about the build process appears in the **Output** window. Build verbosity is usually set to Minimal, which means that the **Output** window displays only a summary of the build process along with any high priority warnings or errors. You can display more information about the build by using the [Options Dialog Box,  Projects and Solutions, Build and Run](../ide/reference/options-dialog-box-projects-and-solutions-build-and-run.md).

> [!IMPORTANT]
> If you display more information, the build will take longer to complete.

#### To change the amount of information in the Output window

1. Open the **Options** dialog box.

    ![Options command on the Tools menu](../ide/media/exploreide-toolsoptionsmenu.png "ExploreIDE-ToolsOptionsmenu")

2. Choose the **Projects and Solutions** category, and then choose the **Build and Run** page.

3. In the **MSBuild project build output verbosity** list, choose **Normal**, and then choose the **OK** button.

4. On the menu bar, choose **Build**, **Clean Solution**.

5. Build the solution, and then review the information in the **Output** window.

    The build information includes the time that the build started (located at the beginning), the order in which files were processed, and the amount of time that the process took to complete (located at the end). This information also includes the actual compiler syntax that Visual Studio runs during the build.

    For example, in the Visual C# build, the [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83) option lists the warning code, 1762, that you specified earlier in this topic, along with three other warnings.

    In the Visual Basic build, [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83) doesn’t include specific warnings to exclude, so no warnings appear.

   > [!TIP]
   > You can search the contents of the **Output** window if you display the **Find** dialog box by choosing the Ctrl+F keys.

   For more information, see [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md).

## Create a Release Build

You can build a version of the sample application that’s optimized for shipping it. For the release build, you’ll specify that the executable is copied to a network share before the build is kicked off.

For more information, see [How to: Change the Build Output Directory](../ide/how-to-change-the-build-output-directory.md) and [Building and Cleaning Projects and Solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md).

#### To specify a release build for Visual Basic

1. Open the **Project Designer**.

     ![View menu, Property Pages command](../ide/media/buildwalk-viewpropertypages.png "BuildWalk_ViewPropertyPages")

2. Choose the **Compile** page.

3. In the **Configuration** list, choose **Release**.

4. In the **Platform** list, choose **x86**.

5. In the **Build output path** box, specify a network path.

     For example, you can specify \\\myserver\builds.

    > [!IMPORTANT]
    > A message box might appear, warning you that the network share that you’ve specified might not be a trusted location. If you trust the location that you’ve specified, choose the **OK** button in the message box.

6. Build the application.

     ![Build Solution command on the Build menu](../ide/media/exploreide-buildsolution.png "ExploreIDE-BuildSolution")

#### To specify a release build for Visual C\#

1. Open the **Project Designer**.

    ![View menu, Property Pages command](../ide/media/buildwalk-viewpropertypages.png "BuildWalk_ViewPropertyPages")

2. Choose the **Build** page.

3. In the **Configuration** list, choose **Release**.

4. In the **Platform** list, choose **x86**.

5. In the **Output path** box, specify a network path.

    For example, you could specify \\\myserver\builds.

   > [!IMPORTANT]
   > A message box might appear, warning you that the network share that you’ve specified might not be a trusted location. If you trust the location that you’ve specified, choose the **OK** button in the message box.

6. Build the application.

    ![Build Solution command on the Build menu](../ide/media/exploreide-buildsolution.png "ExploreIDE-BuildSolution")

   The executable file is copied to the network path that you specified. Its path would be \\\myserver\builds\\*FileName*.exe.

   Congratulations: you’ve successfully completed this walkthrough.

## See Also

- [Walkthrough: Building a Project (C++)](https://msdn.microsoft.com/library/d459bc03-88ef-48d0-9f9a-82d17f0b6a4d)
- [ASP.NET Web Application Project Precompilation Overview](https://msdn.microsoft.com/b940abbd-178d-4570-b441-52914fa7b887)
- [Walkthrough: Using MSBuild](../msbuild/walkthrough-using-msbuild.md)
