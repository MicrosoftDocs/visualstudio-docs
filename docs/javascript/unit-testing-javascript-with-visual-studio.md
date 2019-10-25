---
title: "Unit testing JavaScript and TypeScript"
description: Visual Studio provides support unit testing JavaScript and TypeScript code using the Node.js Tools for Visual Studio
ms.date: "06/06/2018"
ms.topic: "conceptual"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---

# Unit testing JavaScript and TypeScript in Visual Studio

The Node.js Tools For Visual Studio allow you to write and run unit tests using some of the more popular
JavaScript frameworks without the need to switch to a command prompt.

The supported frameworks are:
* Mocha ([mochajs.org](https://mochajs.org/))
* Jasmine ([Jasmine.github.io](https://jasmine.github.io/))
* Tape ([github.com/substack/tape](https://github.com/substack/tape))
* Jest ([jestjs.io](https://jestjs.io/))
* Export Runner (this framework is specific to Node.js Tools for Visual Studio)

> [!WARNING]
> An issue in Tape currently prevents Tape tests from running. If [PR #361](https://github.com/substack/tape/pull/361) is merged, the issue should be resolved.

If your favorite framework is not supported, see [Add support for a unit test framework](#addingFramework) for information on adding support.

## Write unit tests

Before adding unit tests to your project, make sure the framework you plan to use is installed locally in your project. This is easy to do using the [npm package installation window](npm-package-management.md#npmInstallWindow).

The preferred way to add unit tests to your project is by creating a *tests* folder in
your project, and setting that as the test root in project properties. You also need
to select the test framework you want to use.

![Set test root and test framework](../javascript/media/unit-test-project-properties.png)

You can add simple blank tests to your project, using the **Add New Item** dialog box. Both JavaScript and TypeScript are supported in the same project.

![Add new unit test](../javascript/media/unit-test-add-new-item.png)

For a Mocha unit test, use the following code:

```javascript
var assert = require('assert');

describe('Test Suite 1', function() {
    it('Test 1', function() {
        assert.ok(true, "This shouldn't fail");
    })

    it('Test 2', function() {
        assert.ok(1 === 1, "This shouldn't fail");
        assert.ok(false, "This should fail");
    })
})
```

If you haven't set the unit test options in the project properties, you must ensure the **Test Framework**
property in the **Properties** window is set to the correct test framework for your unit test files. This is
done automatically by the unit test file templates.

![Test Framework](../javascript/media/UnitTestsFrameworkMocha.png)

> [!Note]
> The unit test options will take preference over the settings for individual files.

After opening Test Explorer (choose **Test** > **Windows** > **Test Explorer**), Visual Studio discovers and displays tests. If tests are not showing initially, then rebuild the project to refresh the list.

![Test Explorer](../javascript/media/UnitTestsDiscoveryMocha.png)

> [!NOTE]
> Do not use the `outdir` or `outfile` option in *tsconfig.json*, because Test Explorer won't be able to find your unit tests in TypeScript files.

## Run tests

You can run tests in Visual Studio 2017 or from the command line.

### Run tests in Visual Studio 2017

You can run the tests by clicking the **Run All** link in Test Explorer. Or, you can run tests by selecting one or more tests or groups, right-clicking, and selecting **Run Selected Tests** from the shortcut menu. Tests run in the background, and Test Explorer automatically updates and shows the results. Furthermore, you can also debug selected tests by selecting **Debug Selected Tests**.

> [!Warning]
> Debugging unit tests using Node 8+ currently only works for JavaScript test files,
> TypeScript test files will fail to hit breakpoints. As a workaround use the `debugger` keyword.

> [!NOTE]
> We don't currently support profiling tests, or code coverage.

### Run tests from the command line

You can run the tests from the [Developer Command Prompt](/dotnet/framework/tools/developer-command-prompt-for-vs) for Visual Studio 2017 using the following command:

```
vstest.console.exe <path to project file>\NodejsConsoleApp23.njsproj /TestAdapterPath:<VisualStudioFolder>\Common7\IDE\Extensions\Microsoft\NodeJsTools\TestAdapter
```

This command shows output similar to the following:

```
Microsoft (R) Test Execution Command Line Tool Version 15.5.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Processing: NodejsConsoleApp23\NodejsConsoleApp23\UnitTest1.js
  Creating TestCase:NodejsConsoleApp23\NodejsConsoleApp23\UnitTest1.js::Test Suite 1 Test 1::mocha
  Creating TestCase:NodejsConsoleApp23\NodejsConsoleApp23\UnitTest1.js::Test Suite 1 Test 2::mocha
Processing finished for framework of Mocha
Passed   Test Suite 1 Test 1
Standard Output Messages:
 Using default Mocha settings
 1..2
 ok 1 Test Suite 1 Test 1

Failed   Test Suite 1 Test 2
Standard Output Messages:
 not ok 1 Test Suite 1 Test 2
   AssertionError [ERR_ASSERTION]: This should fail
       at Context.<anonymous> (NodejsConsoleApp23\NodejsConsoleApp23\UnitTest1.js:10:16)

Total tests: 2. Passed: 1. Failed: 1. Skipped: 0.
Test Run Failed.
Test execution time: 1.5731 Seconds
```

> [!NOTE]
> If you get an error indicating that *vstest.console.exe* cannot be found, make sure you've opened the Developer Command Prompt and not a regular command prompt.

## <a name="addingFramework"></a>Add support for a unit test framework

You can add support for additional test frameworks by implementing the discovery and execution logic using JavaScript. You do this by adding a folder with the name of the test framework under:

`<VisualStudioFolder>\Common7\IDE\Extensions\Microsoft\NodeJsTools\TestAdapter\TestFrameworks`

This folder has to contain a JavaScript file with the same name which exports the following two functions:

* `find_tests`
* `run_tests`

For good a example of the `find_tests` and the `run_tests` implementations, see the implementation for the Mocha
unit testing framework in:

`<VisualStudioFolder>\Common7\IDE\Extensions\Microsoft\NodeJsTools\TestAdapter\TestFrameworks\mocha\mocha.js`

Discovery of available test frameworks occurs at Visual Studio start. If a framework is added while
Visual Studio is running, restart Visual Studio to detect the framework. However you don't need to restart
when making changes to the implementation.

## Unit tests in other project types
You are not limited to writing unit tests in just your Node.js projects. When you add the TestFramework and
TestRoot properties to any C# or Visual Basic project, those tests will be enumerated and you can run them using
the Test Explorer window.

To enable this, right-click the project node in the Solution Explorer, choose **Unload Project**, and then choose **Edit Project**. Then in the project file, add the following two elements to a property group.

> [!NOTE]
> Make sure that the property group you're adding the elements to doesn't have a condition specified.
> This can cause unexpected behavior.

```xml
<PropertyGroup>
    <JavaScriptTestRoot>tests\</JavaScriptTestRoot>
    <JavaScriptTestFramework>Tape</JavaScriptTestFramework>
</PropertyGroup>
```

Next, add your tests to the test root folder you specified, and they will be available to run in the
Test Explorer window. If they don't initially appear, you may need to rebuild the project.

### Unit test .NET Core and .NET Standard
In addition to the properties above, you will also need to install the NuGet package [Microsoft.JavaScript.UnitTest](https://www.nuget.org/packages/Microsoft.JavaScript.UnitTest/) and set the property:

```xml
<PropertyGroup>
    <GenerateProgramFile>false</GenerateProgramFile>
</PropertyGroup>
```
