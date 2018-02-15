---
title: "Walkthrough: Creating and Running Unit Tests for UWP apps | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-devops-test
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "unit tests, creating"
  - "unit tests"
  - "unit tests, UWP apps"
  - "unit tests, running"
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "uwp"
author: gewarren
---
# Walkthrough: Creating and Running Unit Tests for UWP apps
Visual Studio includes support for unit testing managed [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] apps and includes unit test library templates for Visual C#, Visual Basic and Visual C++.  
  
> [!TIP]
>  For more information about developing [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] apps, see [Getting started with UWP apps](http://go.microsoft.com/fwlink/?LinkID=241410).  
  
 Visual Studio provides the following unit testing functionality:  
  
-   [Create unit test projects](#CreateAndRunUnitTestWin8Tailored_Create)  
  
-   [Edit the Manifest for the Unit Test Project](#CreateAndRunUnitTestWin8Tailored_Manifest)  
  
-   [Code the Unit Test](#CreateAndRunUnitTestWin8Tailored_Code)  
  
-   [Run Unit Tests](#CreateAndRunUnitTestWin8Tailored_Run)  
  
 The following procedures describe the steps to create, run and debug unit tests for managed Windows 8 [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] app.  
  
## Prerequisites  
 Visual Studio  
  
##  <a name="CreateAndRunUnitTestWin8Tailored_Create"></a> Create unit test projects  
  
#### To create a unit test project for a UWP app  
  
1.  From the **File** menu, choose **New Project**.  
  
     The New Project dialog displays.  
  
2.  Under Templates, choose the programming language you want to create unit test in and then choose the associated [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] unit test library. For example, choose **Visual C#** , then choose **Windows Universal**, and then choose **Unit Test Library (Universal Windows)**.  
  
    > [!NOTE]
    >  Visual Studio includes unit test library templates for Visual C#, Visual Basic and Visual C++.  
  
3.  (Optional) In the **Name** textbox, enter the name you want to use for the [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)]unit test project.  
  
4.  (Optional) Modify the path where you want to create the project by entering it in the **Location** textbox, or choosing the **Browse** button.  
  
5.  (Optional) In the **Solution** name textbox, enter that name you want to use for your solution.  
  
6.  Leave the **Create directory for solution** option selected and choose the **OK** button.  
  
     ![Tailored Unit Test Library](../test/media/unit_test_win8_1.png "Unit_Test_Win8_1")  
  
     Solution Explorer is populated with your new [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)]unit test project and the code editor displays the default unit test titled UnitTest1.  
  
     ![New tailored unit test project](../test/media/unit_test_win8_unittestexplorer_newprojectcreated.png "Unit_Test_Win8_UnitTestExplorer_NewProjectCreated")  
  
##  <a name="CreateAndRunUnitTestWin8Tailored_Manifest"></a> Edit the Manifest for the Unit Test Project  
 It may be necessary to edit the manifest for the unit test project to provide required capabilities to run the app.  
  
#### To edit the unit test project's UWP application manifest file  
  
1.  In Solution Explorer, in the new [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] unit test project, right-click the Package.appxmanifest file and choose **Open**.  
  
     The Manifest Designer displays for editing.  
  
2.  In the Manifest Designer, choose the **Capabilities** tab.  
  
3.  In the list under **Capabilities**, select the capabilities that you need your unit test and the code that it testing to have. For example, select the **Internet** checkbox if the unit test needs and the code it is testing need to have the capability to access the internet.  
  
    > [!NOTE]
    >  The capabilities you select should only include capabilities that are necessary for the [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] unit test to function correctly. The capabilities should never have to include capabilities that are not part of the [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] app being tested and generally should be a subset of the capabilities specified for the [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)]app under test.  
  
     For more information about the Manifest Designer, see [Configure a Windows 8.1 app package by using the manifest designer](http://msdn.microsoft.com/Library/24c58b7f-9c6d-41c3-b385-c1e8497d5b2d).  
  
     ![Unit Test Manifest](../test/media/unit_test_win8_.png "Unit_Test_Win8_")  
  
##  <a name="CreateAndRunUnitTestWin8Tailored_Code"></a> Code the Unit Test  
  
#### To code the unit test for a UWP app  
  
1.  In the Code Editor, edit the unit test and add the asserts and logic required for your test.  
  
     For more information, see in [Using the Assert Classes](http://go.microsoft.com/fwlink/?LinkID=224991) in the MSDN library.  
  
##  <a name="CreateAndRunUnitTestWin8Tailored_Run"></a> Run Unit Tests  
  
#### To build the solution and run the unit test using Test Explorer  
  
1.  On the **Test** menu, choose **Windows**, and then choose **Test Explorer**.  
  
     Test Explorer displays without your test being listed.  
  
2.  From the **Build** menu, choose **Build Solution**.  
  
     Your unit test is now listed.  
  
    > [!NOTE]
    >  You must build the solution to update the list of unit tests in Test Explorer.  
  
    > [!WARNING]
    >  Visual Studio known issue: You must open Test Explorer prior to building the test project.  
  
3.  In Test Explorer, choose the unit test you created.  
  
    > [!TIP]
    >  Test Explorer provides a link to the source code next to **Source:**.  
  
4.  Choose **Run All**.  
  
     ![Unit Test Explorer &#45; run unit test](../test/media/unit_test_win8_unittestexplorer_contextmenurun.png "Unit_Test_Win8_UnitTestExplorer_ContextMenuRun")  
  
    > [!TIP]
    >  You can select one or more unit tests listed in Explorer and then right-click and choose **Run Selected Tests**.  
    >   
    >  Additionally, you can choose to **Debug Selected Tests**, **Open Test**, and use the **Properties** option.  
    >   
    >  ![Unit Test Explorer &#45; uni test context menu](../test/media/unit_test_win8_unittestexplorer_contextmenu.png "Unit_Test_Win8_UnitTestExplorer_ContextMenu")  
  
     The unit test runs. Upon completion, Test Explorer displays the test status, elapsed time and provides a link to the source.  
  
     ![Unit Test Explorer &#45; test completed](../test/media/unit_test_win8_unittestexplorer_done.png "Unit_Test_Win8_UnitTestExplorer_Done")  
  
## External Resources  
  
### Videos  
 [Channel 9: Unit testing your UWP apps built using XAML](http://go.microsoft.com/fwlink/?LinkId=226285)  
  
### Forums  
 [Visual Studio Unit Testing](http://go.microsoft.com/fwlink/?LinkId=224477)  
  
### MSDN Library  
 [MSDN Library - Creating and Running Unit Tests for Existing Code (Visual Studio 2010)](http://go.microsoft.com/fwlink/?LinkID=223683)  
  
## See Also  
 [Testing UWP apps with Visual Studio](../test/testing-store-apps-with-visual-studio.md)   
 [Build and test a UWP app using Team Foundation Build](http://msdn.microsoft.com/Library/d0ca17bb-deae-4f3d-a18d-1a99bebceaa9)
