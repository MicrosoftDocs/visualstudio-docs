---
title: Unit test Python code with Test Explorer
description: Write unit tests for Python code in Visual Studio and access Test Explorer features to discover, run, and debug tests.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python
ms.workload:
  - python
  - data-science

# CustomerIntent: As a developer, I want to write unit tests for Python code in Visual Studio so I can access Test Explorer features to run, debug, and analyze the tests.
---

# Write unit tests for Python with Test Explorer in Visual Studio

Unit tests are pieces of code that test other code units in an application, typically isolated functions, classes, and so on. When an application passes all its unit tests, you can be confident that at least the low-level program functionality is correct.

Python uses unit tests extensively to validate scenarios while designing a program. Python support in Visual Studio includes discovering, executing, and debugging unit tests within the context of your development process, without needing to run tests separately.

This article provides a brief outline of unit testing capabilities in Visual Studio with Python. For more on unit testing in general, see [Unit test your code](../test/unit-test-your-code.md).

## Prerequisites 

- Visual Studio on Windows installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- A [Python project](quickstart-02-python-in-visual-studio-project-from-template.md) with code or a [folder with Python code](quickstart-05-python-visual-studio-open-folder.md).

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Select test framework for a Python project

Visual Studio supports two testing frameworks for Python, [unittest](https://docs.python.org/3/library/unittest.html) and [pytest](https://pytest.org/en/latest/) (available in Visual Studio 2019 version 16.3 and later). By default, no framework is selected when you create a Python project.

Follow these steps to select the test framework for your Python project: 

1. In **Solution Explorer**, right-click the project name and select **Properties**.

1. In the project **Properties** pane, select the **Test** tab and choose your **Test framework** type:

   - For the **unittest** framework, Visual Studio assigns the project's **Root directory** for test discovery. The default value is `.`, but you can specify a different location when you configure the project settings. You can also specify one or more strings for the test filename **Pattern**, such as `test*.py, test_*.py`.

   - For the **pytest** framework, testing options like test location and filename patterns are specified by using the standard pytest _.ini_ configuration file. By default, the workspace/project folder is used for the location. The default filename pattern includes `test_*py` and `*_test.py`. For more information, see the [pytest reference documentation](https://docs.pytest.org/en/latest/reference.html#ini-options-ref).

   > [!NOTE]
   > When you define the filename pattern, keep in mind that special characters like the underscore (`_`) aren't matched by the wildcard (`*`). If you want to use special characters in the filename, specify these characters in the pattern definition, such as `test_*.py`.

1. To save your framework selection and settings, you can use the **Ctrl**+**S** keyboard shortcut.

After you configure the framework, Visual Studio initiates test discovery and opens [Test Explorer](#view-tests-with-test-explorer).

## Configure testing for Python without a project

Visual Studio allows you to run and test existing Python code without a project, by [opening a folder](quickstart-05-python-visual-studio-open-folder.md) with Python code. In this scenario, you need to use a _PythonSettings.json_ file to configure testing.

1. Open your existing Python code by using the **Open a Local Folder** option:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/open-local-folder.png" alt-text="Screenshot that shows how to select the Open a local folder option when Visual Studio 2022 starts." border="false" lightbox="media/quickstart-open-folder/vs-2022/open-local-folder.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/open-local-folder.png" alt-text="Screenshot that shows how to select the Open a local folder option when Visual Studio starts." border="false" lightbox="media/quickstart-open-folder/open-local-folder.png":::

   ::: moniker-end

1. When you open a Python folder, Visual Studio creates several hidden folders to manage settings related to the program. To see these folders (and any other hidden files and folders, such as the _.git_ folder) in **Solution Explorer**, select the **Show All Files** option:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/view-hidden-folders-solution-explorer.png" alt-text="Screenshot that shows how to view hidden folders and files in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/vs-2022/view-hidden-folders-solution-explorer.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/view-hidden-folders-solution-explorer.png" alt-text="Screenshot that shows how to view hidden folders and files in Solution Explorer in Visual Studio." border="false" lightbox="media/view-hidden-folders-solution-explorer.png" :::

   ::: moniker-end

1. In **Solution Explorer**, expand the _Local Settings_ folder, and double-click the _PythonSettings.json_ file to open the file in the editor. 

   > [!NOTE]
   > Most configurations show two settings files: _PythonSettings.json_ and _ProjectSettings.json_. For this exercise, you need to modify the _PythonSettings.json_ file.

   If you don't see the _PythonSettings.json_ file in the _Local Settings_ folder, you can create it manually:

   1. Right-click the _Local Settings_ folder and select **Add** > **New File**.

   1. Name the file _PythonSettings.json_, and select **Enter** to save your changes.

   Visual Studio automatically opens the new file in the editor.

1. In the _PythonSettings.json_ file, add the following code to define the `TestFramework`. Set the framework value to _pytest_ or _unittest_ depending on your desired testing framework:

   ```json
   {
     "TestFramework": "unittest",
     "UnitTestRootDirectory": "testing",
     "UnitTestPattern": "test_*.py"
   }
   ```

   - For the **unittest** framework, if you don't define specific values for the `UnitTestRootDirectory` and `UnitTestPattern` settings in the _PythonSettings.json_ file, Visual Studio automatically adds these fields with the default values of `.` and `test*.py`, respectively.

   - For the **pytest** framework, configuration options are always specified in the pytest _.ini_ configuration file rather than through Visual Studio settings. 

1. If your Python program contains a _src_ folder separate from the folder that contains your tests, specify the path to the _src_ folder with the `SearchPaths` setting in the _PythonSettings.json_ file:

   ```json
     "SearchPaths": [".\\src"]
   ```

1. Save your changes to the _PythonSettings.json_ file.

After you configure the framework, Visual Studio initiates test discovery for the specified framework. You can access the test in [Test Explorer](#view-tests-with-test-explorer).

## Add and discover tests

By default, Visual Studio identifies **unittest** and **pytest** tests as methods whose names start with `test`.

To see how Visual Studio initiates test discovery, follow these steps:

1. Open a [Python project](managing-python-projects-in-visual-studio.md) in Visual Studio.

1. Set the test framework **Properties** for the project, as described in [Select test framework for Python project](#select-test-framework-for-a-python-project).

1. In **Solution Explorer**, right-click the project and select **Add** > **New Item**.

   1. In the **Add New Item** dialog, select the **Python Unit Test** file type.
   
   1. Enter a filename that satisfies the **Pattern** definition you specified for the project **Properties**.
   
   1. Select **Add**.

1. Visual Studio creates the test file with default code:

   ```python
   import unittest

   class Test_test1(unittest.TestCase):
       def test_A(self):
           self.fail("Not implemented")

   if __name__ == '__main__':
       unittest.main()
   ```

   This code imports the standard `unittest` module and derives a test class from the `unittest.TestCase` method. When you run the script directly, this code also invokes the `unittest.main()` function.

When you add new test files, Visual Studio makes them available in [Test Explorer](#view-tests-with-test-explorer).

## View tests with Test Explorer

After you configure your test framework and test files, Visual Studio searches for tests and displays them in **Test Explorer**.

Here are some of the ways you can work with **Test Explorer**:

- Open the **Test Explorer** window by selecting **Test** > **Test Explorer**.

- When the **Test Explorer** window is open, use the keyboard shortcut **CTRL**+**R**, **A** to trigger test discovery.

- Double-click a test in **Test Explorer** to open the corresponding source file in the editor:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-open-test-file.png" alt-text="Screenshot that shows the default view for a test in Test Explorer in Visual Studio 2022." border="false" lightbox="media/vs-2022/test-explorer-open-test-file.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-a-2.png" alt-text="Screenshot that shows the default view for a test in Test Explorer." lightbox="media/unit-test-a-2.png":::

   ::: moniker-end

- Organize the view of your tests by using the **Group By** option on the toolbar:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-group-by.png" alt-text="Screenshot that shows how to organize the view of tests in Test Explorer with the Group By option in Visual Studio 2022." border="false" lightbox="media/vs-2022/test-explorer-group-by.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-group-menu-2.png" alt-text="Screenshot that shows how to organize the view of tests in Test Explorer with the Group By option." lightbox="media/unit-test-group-menu-2.png":::

   ::: moniker-end

- Filter tests by name by entering text in the **Search** field:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-filter-view.png" alt-text="Screenshot that shows how to filter the view of tests in Test Explorer by  using the Search field." border="false" lightbox="media/vs-2022/test-explorer-filter-view.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-filter.png" alt-text="Screenshot that shows how to filter the view of tests in Test Explorer by using the Search field." lightbox="media/unit-test-filter.png":::

   ::: moniker-end

- [Run tests](#run-tests-with-test-explorer) and view the status for the test run, as described in the next section.

For more information on the `unittest` module and writing tests, see the [Python documentation](https://docs.python.org/3.11/library/unittest.html).

## Run tests with Test Explorer

In **Test Explorer**, you can run tests in several ways:

- Select **Run All (tests in view)** to execute all tests shown in the current view based on your filter settings.
- Use commands on the **Run** menu to run failed, passed, or not run tests as a group.
- Select one or more tests, and then right-click and select the **Run Selected Tests** option.

Visual Studio runs your tests in the background. **Test Explorer** updates the status for each test as it completes:

- **Passing** tests show a green tick and the time to complete the test run:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-passed.png" alt-text="Screenshot that shows the status for a passed test in Test Explorer in Visual Studio 2022." border="false" lightbox="media/vs-2022/test-explorer-passed.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-A-pass.png" alt-text="Screenshot that shows the status for a passed test in Test Explorer." border="false" lightbox="media/unit-test-A-pass.png":::

   ::: moniker-end

- **Failed** tests show a red X with an **Output** link that shows console output and `unittest` output from the test run:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-failed.png" alt-text="Screenshot that shows the status and reason details for a failed test in Test Explorer in Visual Studio 2022." border="false" lightbox="media/vs-2022/test-explorer-failed.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-A-fail.png" alt-text="Screenshot that shows the status for a failed test in Test Explorer." border="false" lightbox="media/unit-test-A-fail.png":::

   :::image type="content" source="media/unit-test-A-fail-reason.png" alt-text="Screenshot that shows the reason for a failed test in Test Explorer." border="false" lightbox="media/unit-test-A-fail-reason.png":::
   
   ::: moniker-end

## Check tests with the Debugger

Unit tests are pieces of code that are subject to bugs like any other code and occasionally need to be run in a debugger. In the Visual Studio **Debugger**, you can set breakpoints, examine variables, and step through code. Visual Studio also provides diagnostic tools for unit tests.

Review these points about checking your tests with the Visual Studio **Debugger**:

- By default, test debugging uses the **debugpy** debugger for Visual Studio 2019 version 16.5 and later. Some earlier versions of Visual Studio use the **ptvsd 4** debugger. If you're using an earlier version of Visual Studio and prefer the **ptvsd 3** debugger, select the **Use Legacy Debugger** option under **Tools** > **Options** > **Python** > **Debugging**.

- To start debugging, set an initial breakpoint in your code, then right-click the test (or a selection) in **Test Explorer** and select **Debug Selected Tests**. Visual Studio starts the Python debugger as it would for application code.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/test-explorer-debug-test.png" alt-text="Screenshot that shows how to debug a unit test with the Visual Studio 2022 Debugger." border="false" lightbox="media/vs-2022/test-explorer-debug-test.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/unit-test-debugging.png" alt-text="Screenshot that shows how to debug a unit test with the Visual Studio Debugger." border="false" lightbox="media/unit-test-debugging.png":::

   ::: moniker-end

- If you prefer, you can use the **Analyze Code Coverage for Selected Tests**. For more information, see [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

## Related content

- [Unit test tools and tasks](../test/unit-test-your-code.md)
- [Get started with unit testing](../test/getting-started-with-unit-testing.md)
