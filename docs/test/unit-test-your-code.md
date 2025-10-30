---
title: Explore unit test tools and tasks
description: Learn about the unit test tools you can use to give developers and testers a quick way to look for logic errors in your code. 
ms.date: 12/05/2023
ms.topic: article
helpviewer_keywords:
- Visual Studio, unit tests
- unit tests, verifying code with
- testing code, automated tests
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Unit test tools and tasks

Unit tests give developers and testers a quick way to look for logic errors in the methods of classes in C#, Visual Basic, and C++ projects.

The unit test tools include:

* **Test Explorer**&mdash;Run unit tests and see their results in **Test Explorer**. You can use any unit test framework, including a third-party framework, that has an adapter for **Test Explorer**.

* **Microsoft unit test framework for managed code**&mdash;The Microsoft unit test framework for managed code is installed with Visual Studio and provides a framework for testing .NET code.

* **Microsoft Native Unit Test Framework**&mdash;The Microsoft Native Unit Test Framework for C++ is installed as part of the **Desktop development with C++** workload. It provides a framework for testing native code. Google Test, Boost.Test, and CTest frameworks are also included, and third-party adapters are available for additional test frameworks. For more information, see [Write unit tests for C/C++](../test/writing-unit-tests-for-c-cpp.md).

* **Code coverage tools**&mdash;You can determine the amount of product code that your unit tests exercise from one command in Test Explorer.

* **Microsoft Fakes isolation framework**&mdash;The Microsoft Fakes isolation framework can create substitute classes and methods for production and system .NET code that create dependencies in the code under test. By implementing the fake delegates for a function, you control the behavior and output of the dependency object.

For .NET, you can also use [IntelliTest](../test/generate-unit-tests-for-your-code-with-intellitest.md) to explore your code and generate test data and a suite of unit tests. For every statement in the code, a test input is generated that will execute that statement. A case analysis is performed for every conditional branch in the code.

## Key tasks

Use the following articles to help with understanding and creating unit tests:

|Tasks|Associated Topics|
|-|-----------------------|
|**Tutorials:** Learn about unit testing in Visual Studio from code examples.|- [Get started with unit testing](getting-started-with-unit-testing.md)<br />- [Test-driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)|
|**Unit testing with Test Explorer:** Learn how Test Explorer can help create more productive and efficient unit tests.|- [Unit test basics](../test/unit-test-basics.md)<br />- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)<br />- [Install third-party unit test frameworks](../test/install-third-party-unit-test-frameworks.md)|
|**Unit test .NET code**|- [Create and run unit tests for .NET code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)|
|**Unit test C++ code**|- [Write unit tests for C/C++](../test/writing-unit-tests-for-c-cpp.md)<br />- [How to: Add unit tests to C++ apps](../test/how-to-use-microsoft-test-framework-for-cpp.md)|
|**Use code coverage to identify what proportion of your project's code is tested:** Learn about the code coverage feature of Visual Studio testing tools.|- [Use code coverage to determine how much code is being tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)|
|**Isolating unit tests**|- [Isolate .NET code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)|
|**Set quality gates:** Learn how to create quality gates to enforce that tests are run before code is checked in or merged.|- [Check-in policies (Azure Repos TFVC)](/azure/devops/repos/tfvc/add-check-policies?view=vsts&preserve-view=true)|
|**Set testing options:** Learn how to configure test options, for example, where test results are stored.|[Configure unit tests by using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)|

## API reference documentation

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting> describes the UnitTesting namespace, which provides attributes, exceptions, asserts, and other classes that support unit testing.
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Web> describes the UnitTesting.Web namespace, which extends the UnitTesting namespace by providing support for ASP.NET and web service unit tests.

## Related content

- [Improve code quality](../test/improve-code-quality.md)
