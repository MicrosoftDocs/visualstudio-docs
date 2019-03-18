---
title: Create unit test method stubs
ms.date: 05/02/2017
ms.topic: conceptual
helpviewer_keywords:
  - "unit testing, create unit tests"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Create unit test method stubs with the Create Unit Tests command

The Visual Studio **Create Unit Tests** command provides the ability to create unit test method stubs. This feature allows easy configuration of a test project, the test class, and the test method stub within it.

## Availability and extensions

The **Create Unit Tests** menu command:

* Is available in the Community, Professional, and Enterprise Editions of Visual Studio 2015 and later.

* Supports only C# code that targets the .NET Framework.

* Is extensible, and supports emitting tests in MSTest, MSTest V2, NUnit, xUnit format.

* Is not yet available in .NET Core projects.

## Get started

To get started, select a method, a type, or a namespace in the code editor in the project you want to test, open the shortcut menu, and choose **Create Unit Tests**. The **Create Unit Tests** dialog opens, where the create options for the new unit tests can be selected.

![Using the Create unit tests command](media/createunittestcommand.png)

## Set unit test traits

If you plan to run these tests as part of the test automation process, you might consider having the test created in another test project (the second option in the dialog above) and setting unit test traits for the unit test. This enables you to more easily include or exclude these specific tests as part of a continuous integration or continuous deployment pipeline. The traits are set by adding metadata to the unit test directly, as shown below.

![Setting unit test traits](media/createunittest.png)

## Use third-party unit test frameworks

With Visual Studio, you can easily have unit tests created for you using any test framework. To install other test frameworks:

::: moniker range="vs-2017"

1. Choose **Tools** > **Extensions and Updates**.

::: moniker-end

::: moniker range=">=vs-2019"

1. Choose **Extensions** > **Manage Extensions**.

::: moniker-end

2. Expand **Online** > **Visual Studio Marketplace** > **Tools**, and then choose **Testing**.

![Using third party test frameworks](media/createunittestfx.png)

Test framework extensions are available in Visual Studio Marketplace:

* [NUnit extension for the test generators](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.TestGeneratorNUnitextension)
* [xUnit.net extension for the test generators](https://marketplace.visualstudio.com/items?itemName=BradWilson.xUnitnetTestExtensions)

## When should I use this feature?

Use this feature whenever you need to create unit tests, but specifically when you are testing existing code that has little or no test coverage, and no documentation. In other words, where there is limited or non-existent code specification. It effectively implements an approach similar to [Smart unit tests](https://devblogs.microsoft.com/devops/introducing-smart-unit-tests/) that characterize the observed behavior of the code.

However, this feature is equally applicable to the situation where the developer starts by writing some code, and uses that to bootstrap the unit testing discipline. Within the flow of coding, the developer might want to quickly create a unit test method stub (with a suitable test class, and a suitable test project) for a particular piece of code.

## See also

- [Creating unit test method stubs with "Create Unit Tests"](https://devblogs.microsoft.com/devops/creating-unit-test-method-stubs-with-create-unit-tests/)
- [Unit testing blog posts](https://devblogs.microsoft.com/devops/?s=unit+testing)
