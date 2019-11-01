---
title: "Unit Testing"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, unit tests"
  - "unit tests, verifying code with"
  - "testing code, automated tests"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Unit test your code

Unit tests give developers and testers a quick way to look for logic errors in the methods of classes in C#, Visual Basic, and C++ projects.

The unit test tools include:

* **Test Explorer**&mdash;Run unit tests and see their results in **Test Explorer**. You can use any unit test framework, including a third-party framework, that has an adapter for **Test Explorer**.

* **Microsoft unit test framework for managed code**&mdash;The Microsoft unit test framework for managed code is installed with Visual Studio and provides a framework for testing .NET code.

* **Microsoft unit test framework for C++**&mdash;The Microsoft unit test framework for C++ is installed as part of the **Desktop development with C++** workload. It provides a framework for testing native code. Google Test, Boost.Test, and CTest frameworks are also included, and third-party adapters are available for additional test frameworks. For more information, see [Write unit tests for C/C++](../test/writing-unit-tests-for-c-cpp.md).

* **Code coverage tools**&mdash;You can determine the amount of product code that your unit tests exercise from one command in Test Explorer.

* **Microsoft Fakes isolation framework**&mdash;The Microsoft Fakes isolation framework can create substitute classes and methods for production and system code that create dependencies in the code under test. By implementing the fake delegates for a function, you control the behavior and output of the dependency object.

You can also use [IntelliTest](../test/generate-unit-tests-for-your-code-with-intellitest.md) to explore your .NET code to generate test data and a suite of unit tests. For every statement in the code, a test input is generated that will execute that statement. A case analysis is performed for every conditional branch in the code.

## Key tasks

Use the following articles to help with understanding and creating unit tests:

|Tasks|Associated Topics|
|-|-----------------------|
|**Quickstarts and walkthroughs:** Learn about unit testing in Visual Studio from code examples.|- [Walkthrough: Create and run unit tests for managed code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)<br />- [Quickstart: Test-driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)<br />- [How to: Add unit tests to C++ apps](../test/how-to-use-microsoft-test-framework-for-cpp.md)|
|**Unit testing with Test Explorer:** Learn how Test Explorer can help create more productive and efficient unit tests.|- [Unit test basics](../test/unit-test-basics.md)<br />- [Create a unit test project](../test/create-a-unit-test-project.md)<br />- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)<br />- [Install third-party unit test frameworks](../test/install-third-party-unit-test-frameworks.md)|
|**Unit test C++ code**|- [Write unit tests for C/C++](../test/writing-unit-tests-for-c-cpp.md)|
|**Isolating unit tests**|- [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)|
|**Use code coverage to identify what proportion of your project's code is tested:** Learn about the code coverage feature of Visual Studio testing tools.|- [Use code coverage to determine how much code is being tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)|
|**Perform stress and performance analysis by using load tests:** Learn how to create load tests to help isolate performance and stress issues in your application.|- [Quickstart: Create a load test project](../test/quickstart-create-a-load-test-project.md)<br />- [Load testing (Azure Test Plans and TFS)](/azure/devops/test/load-test/index?view=vsts)|
|**Set quality gates:** Learn how to create quality gates to enforce that tests are run before code is checked in or merged.|- [Check-in policies (Azure Repos TFVC)](/azure/devops/repos/tfvc/add-check-policies?view=vsts)|
|**Set testing options:** Learn how to configure test options, for example, where test results are stored.|[Configure unit tests by using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)|

## API reference documentation

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting> describes the UnitTesting namespace, which provides attributes, exceptions, asserts, and other classes that support unit testing.
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Web> describes the UnitTesting.Web namespace, which extends the UnitTesting namespace by providing support for ASP.NET and web service unit tests.

## See also

- [Improve code quality](../test/improve-code-quality.md)
