---
title: "Unit Testing in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f3ad6523-5a4e-4209-8977-adc2da305df2
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Setting Up Unit Testing for Python Code

Unit tests are pieces of code that test other code units in an application, typically isolated functions, classes, and so on. When an application passes all its unit tests, you can at least trust that it's low-level functionality is correct.

Python uses unit tests extensively to validate scenarios while designing a program. Python Tools for Visual Studio(PTVS)  includes support for discovering, executing, and debugging unit tests within the context of your development process, rather than needing to run them separately.

This topic provides a brief outline of unit testing capabilities in Visual Studio with Python. For more on unit testing in general, see [Unit Test Your Code](../test/unit-test-your-code.md).

## Discovering and viewing tests

By convention, PTVS will identify tests are as methods whose names start with "test". To see this, do the following:

1. Open a [Python project](python-projects.md) loaded in Visual Studio, right-click your project, select **Add > New Item...**, then select **Python Unit Test** followed by **Add**.

1. This creates a test1.py file with code that imports the standard `unittest` module, derives a test class from `unittest.TestCase`, and invokes `unittest.main()` if you run the script directly:

  ```python
  import unittest

  class Test_test1(unittest.TestCase):
      def test_A(self):
          self.fail("Not implemented")

  if __name__ == '__main__':
      unittest.main()
  ```

1. Save the file if necessary, then open Test Explorer with the **Text > Windows > Text Explorer** menu command.

1. Test Explorer will search your project for tests and display them as shown below. Double-clicking a test opens its source file.

    ![Test Explorer showing default test_A](media/unit-test-A.png)

1. As you add more tests to your project, you can organize the view in Test Explorer using the group by menu on the toolbar:

    ![Tests Explorer Group By toolbar menu](media/unit-test-group-menu.png)

1. You can also enter text in the search field to filter tests by name.

For more details on the `unittest` module and writing tests, see the [Python 2.7 documentation](https://docs.python.org/2/library/unittest.html) or the [Python 3.4 documentation](https://docs.python.org/3/library/unittest.html) (python.org).

## Running tests

In Test Explorer you can run tests in a variety of ways:

- **Run All** clearly runs all shown tests (subject to filters).
- The **Run...** menu gives you commands to run failed, passed, or not run tests as a group.
- You can select one or more tests, right-click, and select **Run Selected Tests**.

Tests run in the background and Test Explorer updates each test's status as it completes:

- Passing tests show a green rick and the time taken to run the test:

    ![test_A passed status](media/unit-test-A-pass.png)

- Failed tests show a red cross with an **Output** link that shows console output and `unittest` output from the test run:

    ![test_A failed status](media/unit-test-A-fail.png)

    ![test_A failed with reason](media/unit-test-A-fail-reason.png)

## Debugging tests

Because unit tests are pieces of code, they are subject to bugs just like any other code and occasionally need to be run in a debugger, where you can set breakpoints, examine variables, and step through code. PTVS also provides diagnostic tools

To start debugging, set an initial breakpoint in your code, then right-click the test (or a selection) in Test Explorer and select **Debug Selected Tests**. Visual Studio will start the Python debugger as it would for application code.

![Debugging a test](media/unit-test-debugging.png)

You can also use the **Analyze Code Coverage for Selected Tests** and **Profile Test** commands, depending on your version of PTVS (see the [Features matrix](python-in-visual-studio.md#features-matrix)).

### Known Issues

- When starting debugging, Visual Studio will appear to start and stop debugging, and then start again. This is expected.
- When debugging multiple tests, each one is run independently, which will interrupt the debugging session.
- Visual Studio will intermittently fail to start a test when debugging. Normally, attempting to debug the test again will succeed.
- When debugging, it is possible to step out of a test into the `unittest` implementation. Normally, the next step will run to the end of the program and stop debugging.