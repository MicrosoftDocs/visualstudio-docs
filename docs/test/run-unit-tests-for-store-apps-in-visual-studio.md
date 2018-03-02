---
title: "Run, organize, and debug unit tests in Visual Studio | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-devops-test
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.author: gewarren
manager: ghogen
ms.workload:
  - multiple
author: gewarren
---
# Run, organize, and debug unit tests

This topic describes how to run unit tests by using the Test Explorer in Microsoft Visual Studio.

## Unit test frameworks and test projects

Visual Studio includes the Microsoft unit testing frameworks for managed code and native C++ code. Test Explorer can run tests from multiple test projects in a solution, and from test classes that are part of the production code projects. Test projects can be any combination of the Visual C++ or the Visual C# and Visual Basic unit test frameworks. When the code under test is written for the .NET Framework, the test project can be written in any .NET Framework language, regardless of the language of the target code. Native C/C++ code projects must be tested by using a C++ unit test framework.

## Run tests in Test Explorer

When you build the test project, the tests appear in Test Explorer. If Test Explorer is not visible, choose **Test** on the Visual Studio menu, choose **Windows**, and then choose **Test Explorer**.

![Unit Test Explorer](../test/media/ute_failedpassednotrunsummary.png)

As you run, write, and rerun your tests, Test Explorer displays the results in default groups of **Failed Tests**, **Passed Tests**, **Skipped Tests** and **Not Run Tests**. You can change the way Test Explorer groups your tests.

You can perform much of the work of finding, organizing, and running tests from the Test Explorer toolbar.

![Run tests from the Test Explorer toolbar](../test/media/ute_toolbar.png)

### Run tests

You can run all the tests in the solution, all the tests in a group, or a set of tests that you select. Do one of the following:

- To run all the tests in a solution, choose **Run All**.

- To run all the tests in a default group, choose **Run...** and then choose the group on the menu.

- Select the individual tests that you want to run, open the shortcut menu for a selected test and then choose **Run Selected Tests**.

The pass/fail bar at the top of the Test Explorer window is animated as the tests run. At the conclusion of the test run, the pass/fail bar turns green if all tests passed or turns red if any test failed.

## View test results

As you run, write, and rerun your tests, Test Explorer displays the results in groups of **Failed Tests**, **Passed Tests**, **Skipped Tests** and **Not Run Tests**. The details pane at the bottom of Test Explorer displays a summary of the test run.

### View test details

To view the details of an individual test, select the test.

The test details pane displays the following information:

- The source file name and the line number of the test method.

- The status of the test.

- The elapsed time that the test method took to run.

If the test fails, the details pane also displays:

- The message returned by the unit test framework for the test.

- The stack trace at the time the test failed.

### View the source code of a test method

To display the source code for a test method in the Visual Studio editor, select the test and then choose **Open Test** on the shortcut menu or press **F12**.

## Organize the test list

### Group tests

By default, Test Explorer displays your tests as child nodes of **Failed Tests**, **Passed Tests**, **Skipped Tests** and **Not Run Tests**.

|||
|-|-|
|![Test Explorer group button](../test/media/ute_groupby_btn.png "UTE_GroupBy_btn")|To group your tests by the time it takes to execute them, open the **Group By** list and choose **Duration**. Choose **Test Outcome** to switch to the original grouping.|

### Search and filter the test list

When you have a large number of tests, you can type in the Test Explorer search box to filter the list by the specified string. You can restrict your filter to specific types of strings by choosing from the filter list before you enter the search string.

![Search filter categories](../test/media/ute_searchfilter.png)

## Debug unit tests

You can use Test Explorer to start a debugging session for your tests. Stepping through your code with the Visual Studio debugger seamlessly takes you back and forth between the unit tests and the project under test. To start debugging:

1. In the Visual Studio editor, set a breakpoint in one or more test methods that you want to debug.

    > [!NOTE]
    > Because test methods can run in any order, set breakpoints in all the test methods that you want to debug.

1. In Test Explorer, select the test methods and then choose **Debug Selected Tests** on the shortcut menu.

For more information about the debugger, see [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md).
