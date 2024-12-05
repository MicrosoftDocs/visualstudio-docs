---
title: Run unit tests with Test Explorer
description: Run tests with Test Explorer in Visual Studio, enable automatic tests after build, view results, group and filter the test list, create playlists, and use shortcuts.
ms.date: 12/3/2024
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Run unit tests with Test Explorer

Use Test Explorer to run unit tests from Visual Studio or third-party unit test projects. You can also use Test Explorer to group tests into categories, filter the test list, and create, save, and run playlists of tests. You can also use Test Explorer to [debug unit tests](../test/debug-unit-tests-with-test-explorer.md) and, in Visual Studio Enterprise, to [analyze code coverage](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

**Test Explorer** can run tests from multiple test projects in a solution and from test classes that are part of the production code projects. Test projects can use different unit test frameworks. When the code under test is written for .NET, the test project can be written in any language that also targets .NET, regardless of the language of the target code. Native C/C++ code projects must be tested by using a C++ unit test framework.

## Build your test project

If you do not already have a test project set up in your Visual Studio solution, you must first create and build a test project.

- [Get started with unit testing (.NET)](../test/getting-started-with-unit-testing.md)
- [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md)

Visual Studio includes the Microsoft unit testing frameworks for both managed and native code. However, Test Explorer can also run any unit test framework that has implemented a Test Explorer adapter. For more information about installing third-party unit test frameworks, see [Install third-party unit test frameworks](../test/install-third-party-unit-test-frameworks.md)

## Run tests in Test Explorer

When you build the test project, the tests appear in Test Explorer. If Test Explorer is not visible, choose **Test** on the Visual Studio menu, and then choose **Test Explorer** (or press **Ctrl** + **E**, **T**).

::: moniker range="vs-2019"
![Test Explorer](../test/media/vs-2019/test-explorer-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Test Explorer](../test/media/vs-2022/test-explorer-17-0.png)
::: moniker-end

As you run, write, and rerun your tests, the Test Explorer displays the results in a default grouping of **Project**, **Namespace**, and **Class**. You can change the way the Test Explorer groups your tests.

You can perform much of the work of finding, organizing and running tests from the **Test Explorer** toolbar.

::: moniker range="vs-2019"
![Run tests from the Test Explorer toolbar](../test/media/vs-2019/test-explorer-toolbar-diagram-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
:::image type="content" source="../test/media/vs-2022/test-explorer-toolbar-diagram-17-0.png" alt-text="Run tests from the Test Explorer toolbar":::
::: moniker-end

### Run tests

You can run all the tests in the solution, all the tests in a group, or a set of tests that you select. Do one of the following:

- To run all the tests in a solution, choose the **Run All** icon (or press **Ctrl** + **R**, **V**).

- To run all the tests in a default group, choose the **Run** icon and then choose the group on the menu.

- Select the individual tests that you want to run, open the right-click menu for a selected test and then choose **Run Selected Tests** (or press **Ctrl** + **R**, **T**).

- If individual tests have no dependencies that prevent them from being run in any order, turn on parallel test execution in the settings menu of the toolbar. This can noticeably reduce the time taken to run all the tests.

>![NOTE]
> To configure the target platform (process architecture) for running unit tests, see [Configure process architecture for a unit test](../test/run-a-unit-test-as-a-64-bit-process.md).

### Run tests after every build

To run your unit tests after each local build, open the settings icon in the Test Explorer toolbar and select **Run Tests After Build**.

## View test results

As you run, write, and rerun your tests, Test Explorer displays the results in groups of **Failed Tests**, **Passed Tests**, **Skipped Tests** and **Not Run Tests**. The details pane at the bottom or side of the Test Explorer displays a summary of the test run.

### View test details

To view the details of an individual test, select the test.

::: moniker range="vs-2019"
![Test execution details](../test/media/vs-2019/test-explorer-detail.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Test execution details](../test/media/vs-2022/test-explorer-details.png)
::: moniker-end

The test details pane displays the following information:

- The source file name and the line number of the test method.

- The status of the test.

- The elapsed time that the test method took to run.

If the test fails, the details pane also displays:

- The message returned by the unit test framework for the test.

- The stack trace at the time the test failed.

### View the source code of a test method

To display the source code for a test method in the Visual Studio editor, select the test and then choose **Open Test** on the right-click menu (or press **F12**).

## Group and filter the test list

Test Explorer lets you group your tests into predefined categories. Most unit test frameworks that run in Test Explorer let you define your own categories and category/value pairs to group your tests. You can also filter the list of tests by matching strings against test properties.

### Group tests in the test list

::: moniker range="vs-2019"
Test Explorer lets you group your tests into a hierarchy. The default hierarchy grouping is **Project**, **Namespace**, and then **Class**. To change the way that tests are organized, choose the **Group By** button ![Test Explorer group button](../test/media/ute_groupby_btn.png) and select a new grouping criteria.

![Group tests by category in Test Explorer](../test/media/vs-2019/test-explorer-groupby-162.png)

You can define your own levels of the hierarchy and group by **State** and then **Class** for example by selecting Group By options in your preferred order.

![Screenshot of the Visual Studio Test Explorer showing  a test hierarchy in one pane and the Group By menu in the other with the Class and State options checked.](../test/media/vs-2019/test-explorer-groupby-state-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
Test Explorer lets you group your tests into a hierarchy. The default hierarchy grouping is **Project**, **Namespace**, and then **Class**. To change the way that tests are organized, choose the **Group By** button ![Test Explorer group button](../test/media/ute_groupby_btn.png) and select a new grouping criteria.

![Group tests by category in Test Explorer](../test/media/vs-2022/test-explorer-groupby-17-0.png)

You can define your own levels of the hierarchy and group by **State** and then **Class** for example by selecting Group By options in your preferred order.

![Screenshot of the Visual Studio Test Explorer showing  a test hierarchy in one pane and the Group By menu in the other with the Class and State options checked.](../test/media/vs-2022/test-explorer-groupby-state-17-0.png)
::: moniker-end

### Test Explorer groups

|Group|Description|
|-|-----------------|
|**Duration**|Groups tests by execution time: **Fast**, **Medium**, and **Slow**.|
|**State**|Groups tests by execution results: **Failed Tests**, **Skipped Tests**, **Passed Tests**, **Not Run**|
|**Target Framework** | Groups tests by the framework their projects target |
|**Namespace**|Groups tests by the containing namespace.|
|**Project**|Groups tests by the containing project.|
|**Class**|Groups tests by the containing class.|

### Traits

A trait is usually a category name/value pair, but it can also be a single category. Traits can be assigned to methods that are identified as a test method by the unit test framework. A unit test framework can define trait categories. You can add values to the trait categories to define your own category name/value pairs. The syntax to specify trait categories and values is defined by the unit test framework.

**Traits in the Microsoft Unit Testing Framework for Managed Code**

In the Microsoft unit test framework for managed apps, you define a trait name/ value pair in a  <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute> attribute. The test framework also contains these predefined traits:

|Trait|Description|
|-|-----------------|
|<xref:Microsoft.VisualStudio.TestTools.UnitTesting.OwnerAttribute>|The Owner category is defined by the unit test framework and requires you to provide a string value of the owner.|
|<xref:Microsoft.VisualStudio.TestTools.UnitTesting.PriorityAttribute>|The Priority category is defined by the unit test framework and requires you to provide an integer value of the priority.|
|<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute>|The TestCategory attribute enables you to specify the category of a unit test.|
|<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute>|The TestProperty attribute enables you to define trait category/value pair.|

**Traits in the Microsoft Unit Testing Framework for C++**

See [How to use the Microsoft Unit Testing Framework for C++](how-to-use-microsoft-test-framework-for-cpp.md).

## Create custom playlists

::: moniker range="vs-2019"
You can create and save a list of tests that you want to run or view as a group. When you select a playlist, the tests in the list are displayed in a new Test Explorer tab. You can add a test to more than one playlist.

**To create a playlist**, choose one or more tests in Test Explorer. On the right-click menu, choose **Add to Playlist** > **New Playlist**.

![Create a playlist](../test/media/vs-2019/test-explorer-playlist-16-2.png)

The playlist opens in a new Test Explorer tab. You can use this playlist once and then discard it, or you can click the **Save** button in the playlist window's toolbar, and then select a name and location to save the playlist.

![Playlist opens in separate test explorer tab](../test/media/vs-2019/test-explorer-playlist-tab-16-7.png)

**To create a playlist**, choose one or more tests in Test Explorer. Right-click and choose **Add to Playlist** > **New playlist**.

**To open a playlist**, choose the playlist icon in the Visual Studio toolbar and select a previously saved playlist file from the menu.

**To edit a playlist**, you can right-click on any test and use the menu options to add or remove it from a playlist.

Starting in Visual Studio 2019 version 16.7, you can choose the **Edit** button in the toolbar. Check boxes will appear next to your tests showing what tests are included and excluded in the playlist. Edit groups as desired.

![Edit Playlist button](../test/media/vs-2019/test-explorer-playlist-edit-16-7.png)

You can also check or uncheck the boxes of the parent groups in the hierarchy. This action creates a dynamic playlist that always updates the playlist based on the tests that are in that group. For example, if you place a check mark next to a class, any test added from that class becomes part of this playlist. If you delete a test from that class, it is removed from the playlist. You can learn more about the rules by saving the playlist with the Save button in the toolbar and opening the *.playlist* file that is created on your disk. This file lists all the rules and individual tests that make up a playlist.

![Playlist xml file](../test/media/vs-2019/test-explorer-playlist-xml-file.png)

If you would like to make a playlist for traits, use the following format for MSTest.
```xml
<Playlist Version="2.0">
  <Rule Name="Includes" Match="Any">
    <Property Name="Trait" Value="SchemaUpdateBasic" />
  </Rule>
</Playlist>
```

Use the following format for xUnit. Make sure there is a space between your `TestCategory` name and the `[Value]`.

```xml
<Playlist Version="2.0">
  <Rule Name="Includes" Match="Any">
    <Rule Match="All">
      <Property Name="Solution" />
        <Rule Match="Any">
            <Property Name="Trait" Value="TestCategory [Value]" />
        </Rule>
    </Rule>
  </Rule>
</Playlist>
```

::: moniker-end

::: moniker range=">=vs-2022"
You can create and save a list of tests that you want to run or view as a group. When you select a playlist, the tests in the list are displayed in a new Test Explorer tab. You can add a test to more than one playlist.

**To create a playlist**, choose one or more tests in Test Explorer. On the right-click menu, choose **Add to Playlist** > **New Playlist**.

![Create a playlist](../test/media/vs-2022/test-explorer-playlist-17-0.png)

The playlist opens in a new Test Explorer tab. You can use this playlist once and then discard it, or you can click the **Save** button in the playlist window's toolbar, and then select a name and location to save the playlist.

![Playlist opens in separate test explorer tab](../test/media/vs-2022/test-explorer-playlist-tab-17-0.png)

**To create a playlist**, choose one or more tests in Test Explorer. Right-click and choose **Add to Playlist** > **New playlist**.

**To open a playlist**, choose the playlist icon in the Visual Studio toolbar and select a previously saved playlist file from the menu.

**To edit a playlist**, you can right-click on any test and use the menu options to add or remove it from a playlist.

Starting in Visual Studio 2019 version 16.7, you can choose the **Edit** button in the toolbar. Check boxes will appear next to your tests showing what tests are included and excluded in the playlist. Edit groups as desired.

![Edit Playlist button](../test/media/vs-2022/test-explorer-playlist-edit-17-0.png)

You can also check or uncheck the boxes of the parent groups in the hierarchy. This action creates a dynamic playlist that always updates the playlist based on the tests that are in that group. For example, if you place a check mark next to a class, any test added from that class becomes part of this playlist. If you delete a test from that class, it is removed from the playlist. You can learn more about the rules by saving the playlist with the Save button in the toolbar and opening the *.playlist* file that is created on your disk. This file lists all the rules and individual tests that make up a playlist.

![Playlist xml file](../test/media/vs-2022/test-explorer-playlist-xml-file.png)

If you would like to make a playlist for traits, use the following format for MSTest.

```xml
<Playlist Version="2.0">
  <Rule Name="Includes" Match="Any">
    <Property Name="Trait" Value="SchemaUpdateBasic" />
  </Rule>
</Playlist>
```

Use the following format for xUnit. Make sure there is a space between your `TestCategory` name and the `[Value]`.

```xml
<Playlist Version="2.0">
  <Rule Name="Includes" Match="Any">
    <Rule Match="All">
      <Property Name="Solution" />
        <Rule Match="Any">
            <Property Name="Trait" Value="TestCategory [Value]" />
        </Rule>
    </Rule>
  </Rule>
</Playlist>
```

::: moniker-end

::: moniker range="vs-2019"
### Test Explorer columns

The [groups](#test-explorer-groups) are also available as columns in Test Explorer, along with Trait, Stack Trace, Error Message, and Fully Qualified Name. Most columns are not visible by default, and you can customize which columns you see and the order in which they appear.

![Screenshot of the Visual Studio Test Explorer showing a menu with Columns selected and a sub-menu with Duration, Traits, and Error Message selected.](../test/media/vs-2019/test-explorer-columns-16-2.png)

### Filter, sort, and rearrange test columns

Columns can be filtered, sorted, and rearranged.
* To filter to specific traits, click the filter icon at the top of the Traits column.

  ![Column filter](../test/media/vs-2019/test-explorer-filter-column-16-2.png)

* To change the order of the columns, click on a column header and drag it left or right.

* To sort a column, click on the column header. Not all columns can be sorted. You can also sort by a secondary column by holding the **Shift** key and clicking on an additional column header.

  ![Column sort](../test/media/vs-2019/test-explorer-sort-column-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
### Test Explorer columns

The [groups](#test-explorer-groups) are also available as columns in Test Explorer, along with Trait, Stack Trace, Error Message, and Fully Qualified Name. Most columns are not visible by default, and you can customize which columns you see and the order in which they appear.

![Screenshot of the Visual Studio Test Explorer showing a menu with Columns selected and a sub-menu with Duration, Traits, and Error Message selected.](../test/media/vs-2022/test-explorer-columns-17-0.png)

### Filter, sort, and rearrange test columns

Columns can be filtered, sorted, and rearranged.
* To filter to specific traits, click the filter icon at the top of the Traits column.

  ![Column filter](../test/media/vs-2022/test-explorer-filter-column-17-0.png)

* To change the order of the columns, click on a column header and drag it left or right.

* To sort a column, click on the column header. Not all columns can be sorted. You can also sort by a secondary column by holding the **Shift** key and clicking on an additional column header.

  ![Column sort](../test/media/vs-2022/test-explorer-sort-column-17-0.png)
::: moniker-end

## Search and filter the test list

You can also use Test Explorer search filters to limit the test methods in your projects that you view and run.

When you type a string in the **Test Explorer** search box and choose **Enter**, the test list is filtered to display only those tests whose fully qualified names contain the string.

To filter by a different criteria:

1. Open the drop-down list to the right of the search box.

2. Choose a new criteria.

3. Enter the filter value between the quotation marks. If you want to search for an exact match on the string instead of a containing match use an equals sign (=) instead of the colon (:).

::: moniker range="vs-2019"
![Filter tests in Test Explorer](../test/media/vs-2019/test-explorer-search-filter-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Filter tests in Test Explorer](../test/media/vs-2022/test-explorer-search-filter-17-0.png)
::: moniker-end

> [!NOTE]
> Searches are case insensitive and match the specified string to any part of the criteria value.

|Qualifier|Description|
|-|-----------------|
|**State**|Searches the Test Explorer category names for matches: **Failed Tests**, **Skipped Tests**, **Passed Tests**.|
|**Traits**|Searches both trait category and value for matches. The syntax to specify trait categories and values are defined by the unit test framework.|
|**Fully Qualified Name**|Searches the fully qualified name of test namespaces, classes, and methods for matches.|
|**Project**|Searches the test project names for matches.|
|**Target Framework**|Searches the test frameworks for matches.|
|**Namespace**|Searches the test namespaces for matches.|
|**Class**|Searches the test classes names for matches.|

To exclude a subset of the results of a filter, use the following syntax:

```
FilterName:"Criteria" -FilterName:"SubsetCriteria"
```

For example, `FullName:"MyClass" - FullName:"PerfTest"` returns all tests that include "MyClass" in their name, except tests that also include "PerfTest" in their name.

### Analyze unit test code coverage

You can determine the amount of product code that is actually being tested by your unit tests by using the Visual Studio Code coverage tool that's available in Visual Studio Enterprise edition. You can run code coverage on selected tests or on all tests in a solution.

To run code coverage for test methods in a solution:

* Right-click in Test Explorer and select **Analyze Code Coverage for Selected tests**

The **Code Coverage Results** window displays the percentage of the blocks of product code that were exercised by line, function, class, namespace and module.

For more information, see [Use code coverage to determine how much code is being tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

## Test shortcuts

Tests can be run from Test Explorer by right-clicking in the code editor on a test and selecting **Run test** or by using the default [Test Explorer shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_testexplorerGLOBAL) in Visual Studio. Some of the shortcuts are context-based. This means that they run, [debug](../test/debug-unit-tests-with-test-explorer.md), or [profile](../test/debug-unit-tests-with-test-explorer.md#diagnose-test-method-performance-issues) tests based on where your cursor is in the code editor. If your cursor is inside a test method, then that test method runs. If your cursor is at the class level, then all the tests in that class run. This is the same for the namespace level as well.

|Frequent Commands| Keyboard Shortcuts|
|-|------------------------|
|TestExplorer.DebugAllTestsInContext|**Ctrl**+**R**, **Ctrl**+**T**|
|TestExplorer.RunAllTestsInContext|**Ctrl**+**R**, **T**|
|TestExplorer.RunAllTests|**Ctrl**+**R**, **A**|
|TestExplorer.RepeatLastRun|**Ctrl**+**R**, **L**|

> [!NOTE]
> You can't run a test in an abstract class, because tests are only defined in abstract classes and not instantiated. To run tests in abstract classes, create a class that derives from the abstract class.

## Test audio cue

Test Explorer can play a sound when a test run completes. There are two sounds: one sound to indicate the test run succeeded with all passing tests, and a second sound to indicate the test run completed with at least one failing test. You can set up these sounds in the default Windows 11 sound dialog. This feature is available starting in Visual Studio 2019 Update 16.9 Preview 3.

1. Open the default Windows 11 sound dialog.
2. Navigate to the **Sounds** tab.
3. Find the **Microsoft Visual Studio** category. Choose the **Test Run Succeeded** or **Test Run Failed** sounds to select the preset sounds or browse to your own audio file.  
![Windows 11 sound dialog](../test/media/default-windows-11-sound-dialog.png)

## Related content

- [Unit test your code](../test/unit-test-your-code.md)
- [Debug unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md)
- [Run a unit test as a 64-bit process](../test/run-a-unit-test-as-a-64-bit-process.md)
- [Test Explorer FAQ](test-explorer-faq.md)
