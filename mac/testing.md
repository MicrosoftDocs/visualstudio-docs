---
title: Visual Studio for Mac testing tools
description: Creating and running tests using Visual Studio for Mac.
ms.date: 03/03/2022
ms.custom: devdivchpfy22
ms.topic: conceptual
helpviewer_keywords:
- testing tools [Visual Studio for Mac]
- unit tests [Visual Studio for Mac]
author: jmatthiesen
ms.author: jomatthi
manager: dominicn
---
# Testing tools in Visual Studio for Mac

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Visual Studio for Mac testing tools can help you and your team develop and sustain high standards of code excellence. Unit tests can be written and run using the Microsoft unit test framework (MSTest), xUnit, or NUnit.

## Creating tests
To get started with testing, you can create a new test project in your solution by right-clicking your solution and choosing the **Add > New Project...** menu. Then choose one of the Test categories on the left-side of the dialog (For example, the **Web and Console > Tests** category). Select the type of test project you want to create, and then select **Next**. Follow the instructions in the dialogs that appear and then a new test project will be added to your solution.

![New project dialog with Web and Console > Tests section selected, showing xUnit, MSTest, and NUnit projects](media/create-new-test-project.PNG)

> [!NOTE]
> For more information about unit testing your .NET Core applications and selecting unit test frameworks, see the [Unit testing in .NET Core and .NET Standard](/dotnet/core/testing/?pivots=xunit) documentation.

## Running tests
The **Unit Tests** window is used to run unit tests and is opened using the **View > Tests** menu. Unit tests in your solution are automatically discovered and shown in this window. Here you can run all of the tests or a set of tests that you've selected.

![Test Window showing a list of unit tests and a tool bar for running or stopping tests.](media/test-window.PNG)

When editing a C# class that contains unit tests, you can run tests by right clicking in the test class or a test method and choosing the **Run Test(s)** or **Debug Test(s)** menu. Choosing the **Run Test(s)** menu item will run the tests in the test window, choosing the **Debug Test(s)** menu will do the same and attach the debugger so you can troubleshoot your code.

![Editor right-click menu with Run and Debug Tests options](media/run-tests-context-menu.PNG)

As tests are running, a **Test Results** window appears so you can review successful or failed tests, and the output from running those tests.

![Test results window showing one failed test and a count of 21 passed tests and 1 failed test.](media/test-results-window.PNG)

## See also

- [Unit testing in .NET Core and .NET Standard](/dotnet/core/testing)
- [Get Started with unit testing (Visual Studio on Windows)](/visualstudio/test/getting-started-with-unit-testing)
- [Unit test basics (Visual Studio on Windows)](/visualstudio/test/unit-test-basics)