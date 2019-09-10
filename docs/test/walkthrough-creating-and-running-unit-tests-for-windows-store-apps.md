---
title: "Creating and Running Unit Tests for UWP apps"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "unit tests, creating"
  - "unit tests"
  - "unit tests, UWP apps"
  - "unit tests, running"
ms.author: gewarren
manager: jillfra
ms.workload:
  - "uwp"
author: gewarren
---
# Walkthrough: Create and run unit tests for UWP apps

Visual Studio includes support for unit testing Universal Windows Platform (UWP) apps. It includes unit test project templates for Visual C#, Visual Basic and Visual C++.

> [!TIP]
> For more information about developing UWP apps, see [Getting started with UWP apps](/windows/uwp/get-started/).

The following procedures describe the steps to create, run and debug unit tests for a UWP app.

## Create a unit test project for a UWP app

1. From the **File** menu, choose **New Project**.

     The **New Project** dialog displays.

2. Under Templates, choose the programming language you want to create unit tests in, and then choose the associated Windows Universal unit test library. For example, choose **Visual C#** , then choose **Windows Universal**, and then choose **Unit Test App (Universal Windows)**.

3. (Optional) In the **Project name** textbox, enter the name you want to use for the project.

4. (Optional) Modify the path where you want to create the project by entering it in the **Location** textbox, or by choosing the **Browse** button.

5. (Optional) In the **Solution** name textbox, enter that name you want to use for your solution.

6. Leave the **Create directory for solution** option selected and choose the **OK** button.

     ![Tailored Unit Test Library](../test/media/unit_test_win8_1.png)

     **Solution Explorer** is populated with the UWP unit test project, and the code editor displays the default unit test titled UnitTest1.

     ![New tailored unit test project](../test/media/unit_test_win8_unittestexplorer_newprojectcreated.png)

## Edit the unit test project's UWP application manifest file

1. In **Solution Explorer**, right-click the *Package.appxmanifest* file and choose **Open**.

     The **Manifest Designer** displays for editing.

2. In the **Manifest Designer**, choose the **Capabilities** tab.

3. In the list under **Capabilities**, select the capabilities that you need your unit test and the code that it testing to have. For example, select the **Internet** checkbox if the unit test needs and the code it is testing need to have the capability to access the internet.

    > [!NOTE]
    > The capabilities you select should only include capabilities that are necessary for the unit test to function correctly.

     ![Unit Test Manifest](../test/media/unit_test_win8_.png)

## Code the unit test for a UWP app

In the **Code Editor**, edit the unit test and add the asserts and logic required for your test.

## Run unit tests

### To build the solution and run the unit test using Test Explorer

1. On the **Test** menu, choose **Windows**, and then choose **Test Explorer**.

     **Test Explorer** displays without your test being listed.

2. From the **Build** menu, choose **Build Solution**.

     Your unit test is now listed.

    > [!NOTE]
    > You must build the solution to update the list of unit tests in Test Explorer.

3. In **Test Explorer**, choose the unit test you created.

    > [!TIP]
    > Test Explorer provides a link to the source code next to **Source:**.

4. Choose **Run All**.

     ![Unit Test Explorer &#45; run unit test](../test/media/unit_test_win8_unittestexplorer_contextmenurun.png)

    > [!TIP]
    > You can select one or more unit tests listed in Explorer and then right-click and choose **Run Selected Tests**.
    >
    > Additionally, you can choose to **Debug Selected Tests**, **Open Test**, and use the **Properties** option.
    >
    > ![Unit Test Explorer &#45; uni test context menu](../test/media/unit_test_win8_unittestexplorer_contextmenu.png)

    The unit test runs. Upon completion, **Test Explorer** displays the test status, elapsed time and provides a link to the source.

    ![Unit Test Explorer &#45; test completed](../test/media/unit_test_win8_unittestexplorer_done.png)

## See also

- [Test UWP apps with Visual Studio](../test/unit-test-your-code.md)
- [Build and test a UWP app](/azure/devops/pipelines/apps/windows/universal?tabs=vsts)
