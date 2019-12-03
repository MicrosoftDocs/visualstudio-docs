---
title: "Unit Test Your Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, unit tests"
  - "unit tests, verifying code with"
  - "testing code, automated tests"
ms.assetid: c191de3e-3f3b-471e-b828-29ec24e80e2c
caps.latest.revision: 64
ms.author: jillfra
manager: jillfra
---
# Unit Test Your Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Unit tests give developers and testers a quick way to look for logic errors in the methods of classes in [!INCLUDE[csharp_current_short](../includes/csharp-current-short-md.md)], [!INCLUDE[vb_current_short](../includes/vb-current-short-md.md)], and [!INCLUDE[cpp_current_short](../includes/cpp-current-short-md.md)] projects.

 The unit test tools include:

1. **Test Explorer.** Test Explorer lets you run unit tests and view their results. Test Explorer can use any unit test framework, including a third-party framework, that has an adapter for the Explorer.

2. **Microsoft unit test framework for managed code.** The Microsoft unit test framework for managed code is installed with Visual Studio and provides a framework for testing .NET code.

3. **Microsoft unit test framework for C++.** The Microsoft unit test framework for C++ is installed with Visual Studio and provides a framework for testing native code.

4. **Code coverage tools.** You can determine the amount of product code that your unit tests exercise from one command in Test Explorer.

5. **Microsoft Fakes isolation framework.** The Microsoft Fakes isolation framework can create substitute classes and methods for production and system code that create dependencies in the code under test. By implementing the fake delegates for a function, you control the behavior and output of the dependency object.

   You can also use [IntelliTest](../test/generate-unit-tests-for-your-code-with-intellitest.md) to explore your .NET code to generate test data and a suite of unit tests. For every statement in the code, a test input is generated that will execute that statement. A case analysis is performed for every conditional branch in the code.

## Key tasks
 Use the following topics to help with understanding and creating unit tests:

|Tasks|Associated Topics|
|-----------|-----------------------|
|**Quick starts and walkthroughs:** Use the following topics to learn unit testing in Visual Studio from code examples.|-   [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)<br />-   [Quick Start: Test Driven Development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)<br />-   [Adding unit tests to existing C++ applications](../test/unit-testing-existing-cpp-applications-with-test-explorer.md)<br />-   [Unit testing native code with Test Explorer](https://msdn.microsoft.com/8a09d6d8-3613-49d8-9ffe-11375ac4736c)|
|**Unit testing with Test Explorer:** Learn how Test Explorer can help create more productive and efficient unit tests.|-   [Unit Test Basics](../test/unit-test-basics.md)<br />-   [Create a unit test project](../test/create-a-unit-test-project.md)<br />-   [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)<br />-   [Install third-party unit test frameworks](../test/install-third-party-unit-test-frameworks.md)<br />-   [Upgrading Unit Tests from Visual Studio 2010](https://msdn.microsoft.com/9bb75856-f68a-4de2-a084-b08a947a1172)|
|**Unit testing managed code:**|-   [Writing Unit Tests for the .NET Framework with the Microsoft Unit Test Framework for Managed Code](../test/writing-unit-tests-for-the-dotnet-framework-with-the-microsoft-unit-test-framework-for-managed-code.md)|
|**Unit testing C++ code**|-   [Writing Unit tests for C/C++ with the Microsoft Unit Testing Framework for C++](../test/writing-unit-tests-for-c-cpp-with-the-microsoft-unit-testing-framework-for-cpp.md)|
|**Isolating unit tests**|-   [Isolating Code Under Test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)|
|**Use code coverage to identify what proportion of your project's code is being tested using unit tests:** Learn about the code coverage feature of [!INCLUDE[vsprvsts](../includes/vsprvsts-md.md)] testing tools.|-   [Using Code Coverage to Determine How Much Code is being Tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)|
|**Perform stress and performance analysis by using load tests for your unit tests:** You can create a load test and add your unit tests to it to help isolate performance and stress issues in your application. **Note:**  Creating and using load tests requires Visual Studio Enterprise.|-   [Creating and Editing Load Tests](https://msdn.microsoft.com/e2985d15-60a7-4177-93b4-f986c2936337)<br />-   [How to: Add Web Performance Tests and Unit Tests to a Load Test Scenario](https://msdn.microsoft.com/03cc073e-9bdf-4530-ae46-504a51884594)<br />-   [How to: Remove Web Tests and Unit Tests  from a Load Test Scenario](https://msdn.microsoft.com/3d6128d2-82b0-42fc-bda2-23a8aa03be07)|
|**Set and enforce quality gates:** You can create quality gates to enforce that tests are run before code is checked in to help ensure the quality of the code.|-   [Set and Enforce Quality Gates](https://msdn.microsoft.com/library/bdc5666e-6cf0-45b2-a0a1-133c3f61e852)|
|**Extend the unit test type:** You can add functionality to your tests that might not be in the Unit Test Framework. For example, you can add a test property that specifies if a test should run as a normal user or not. Or you can extend the framework to add row attributes to a method and use the data in that row inside the test.|For sample code of how to extend the unit test framework, see the following [Microsoft Web site](https://go.microsoft.com/fwlink/?LinkId=185591).|
|**Set testing options:** For example, you can specify where test results are stored.|[Configure unit tests by using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)|

## Related tasks
 [Reviewing Test Results in Microsoft Test Manager](https://msdn.microsoft.com/9fb3e429-78df-4fe2-89ed-0ad1db0738f4)

 Describes test results and ways to work with them, including how to view, save, and delete them.

 [Running System Tests Using Microsoft Visual Studio](https://msdn.microsoft.com/library/19fae5c4-5798-4c4c-b531-3e8f901b1130)

 Provides links to information about using Visual Studio as opposed to using [!INCLUDE[TCMext](../includes/tcmext-md.md)] to run automated tests.

## Reference
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting>
 Describes the UnitTesting namespace, which provides attributes, exceptions, asserts, and other classes that support unit testing.

 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Web>
 Describes the UnitTesting.Web namespace, which extends the UnitTesting namespace by providing support for [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] and Web service unit tests.

## External resources

### Videos
 [Channel 9: Unit testing your Windows Store apps built using XAML](https://go.microsoft.com/fwlink/?LinkId=226285)

### Forums
 [Visual Studio Unit Testing](https://go.microsoft.com/fwlink/?LinkId=224477)

### Guidance
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](https://go.microsoft.com/fwlink/?LinkID=255188)

### Reference
 [Content Index for Unit Tests](https://go.microsoft.com/fwlink/?LinkID=254719)

## See Also
 [Improve Code Quality](https://msdn.microsoft.com/library/73baa961-c21f-43fe-bb92-3f59ae9b5945)
 [Testing the application](https://msdn.microsoft.com/library/796b7d6d-ad45-4772-9719-55eaf5490dac)
