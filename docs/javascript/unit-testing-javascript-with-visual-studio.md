---
title: "Unit testing JavaScript and TypeScript"
description: Explore unit testing support in Visual Studio for JavaScript and TypeScript code by using the Node.js Tools for Visual Studio.
ms.date: "8/6/2025"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
---
# Unit testing JavaScript and TypeScript in Visual Studio

You can write and run unit tests in Visual Studio using some of the more popular JavaScript frameworks without the need to switch to a command prompt. Both Node.js and ASP.NET Core projects are supported.

::: moniker range=">=vs-2022"
The supported frameworks are:
- Mocha ([mochajs.org](https://mochajs.org/))
- Jasmine ([Jasmine.github.io](https://jasmine.github.io/))
- Tape ([github.com/substack/tape](https://github.com/substack/tape))
- Jest ([jestjs.io](https://jestjs.io/))
- Vitest ([vitest.dev](https://vitest.dev/))
::: moniker-end


::: moniker range=">=vs-2022"
## Write unit tests for a CLI-based project (.esproj)

The [CLI-based projects](../javascript/javascript-in-vs-2022.md#project-templates) supported in Visual Studio 2022 work with Test Explorer. Vitest is the built-in test framework for React and Vue projects (previously Jest), and Karma and Jasmine is used for Angular projects. By default, you'll be able to run the default tests provided by each framework, as well as any additional tests you write.  Just hit the **Run** button in Test Explorer. If you don’t already have Test Explorer open, you can find it by selecting **Test** > **Test Explorer** in the menu bar.

To run unit tests from the command-line, right-click the project in Solution Explorer, choose **Open in Terminal**, and run the command specific to the test type.

For information on setting up unit tests, see the following:

- [Testing with Vitest](https://vitest.dev/guide/)
- [Testing React with Jest](https://jestjs.io/docs/tutorial-react)
- [Angular testing](https://angular.io/guide/testing)
- [Testing Vue.js](https://vuejs.org/guide/scaling-up/testing.html#unit-testing)

A simple example is also provided here. However, use the preceding links for complete information.

### Add a unit test (.esproj)

The following example is based on the TypeScript React project template provided in Visual Studio 2022 version 17.12 or later, which is the **Standalone TypeScript React Project** template. For Vue and Angular, the steps are similar.

1. In Solution Explorer, right-click the React project and choose **Edit Project File**.

1. Make sure that the following properties are present in the *.esproj* file with the values shown.

   ```xml
   <PropertyGroup>
     <JavaScriptTestRoot>src\</JavaScriptTestRoot>
     <JavaScriptTestFramework>Vitest</JavaScriptTestFramework>
   </PropertyGroup> 
   ```

   This example specifies Vitest as the test framework. You could specify Mocha, Tape, Jasmine, or Jest instead.

   The `JavaScriptTestRoot` element specifies that your unit tests will be in the *src* folder of the project root. It's also common to specify the *test* folder.

1. In Solution Explorer, right-click the **npm** node and choose **Install new npm packages**.

   Use the npm package installation dialog to install the following npm packages:

   - vitest

   This package is added to the *package.json* file under dependencies.

   > [!NOTE]
   > If you're using jest, the jest-editor-support npm package is required as well as the jest package.

1. In *package.json*, add the `test` section at the end of the `scripts` section:

   ```json
   "scripts": {
      ...
      "test": "vitest"
   },
   ```

1. In Solution Explorer, right-click the src folder and choose **Add** > **New Item**, and then add a new file named *App.test.tsx*.

   This adds the new file under the src folder.

1. Add the following code to *App.test.tsx*.

   ```javascript
   import { describe, it, expect } from 'vitest';

   describe('testAsuite', () => {
      it('testA1', async () => {
         expect(2).toBe(2);
      });
   });
   ```

1. Open Test Explorer (choose **Test** > **Test Explorer**) and Visual Studio discovers and displays tests. If tests aren't showing initially, then rebuild the project to refresh the list.

   ![Screenshot of Test Explorer test discovery (.esproj).](../javascript/media/vs-2022/unit-tests-esproj-discovery.png)

   > [!NOTE]
   > For TypeScript, don't use the `outfile` option in *tsconfig.json*, because Test Explorer won't be able to find your unit tests. You can use the `outdir` option, but make sure that configuration files such as `package.json` and `tsconfig.json` are in the project root.

   > [!IMPORTANT]
   > If the output from **Tests** in the Output window shows a `ReadOnlySpan` error during test discovery, use the following workaround for a known [MSBuild issue](https://github.com/dotnet/msbuild/issues/7873). For Visual Studio 2022, open the folder, *Program Files\Microsoft Visual Studio\2022\\<version\>\Common7\IDE\Extensions\TestPlatform*, and rename *System.Memory.dll* to a different name. This fix enables test discovery.

### Run tests (.esproj)

You can run the tests by clicking the **Run All** link in Test Explorer. Or, you can run tests by selecting one or more tests or groups, right-clicking, and selecting **Run** from the shortcut menu. Tests run in the background, and Test Explorer automatically updates and shows the results. Furthermore, you can also debug selected tests by right-clicking and selecting **Debug**.

The following illustration shows the example with a second unit test added.

![Screenshot of Test Explorer results (.esproj).](../javascript/media/vs-2022/unit-tests-esproj-run.png)

For some unit test frameworks, unit tests are typically run against the generated JavaScript code.

> [!NOTE]
> In most TypeScript scenarios, you can debug a unit test by setting a breakpoint in TypeScript code, right-clicking a test in Test Explorer, and choosing **Debug**. In more complex scenarios, such as some scenarios that use source maps, you may have difficulty hitting breakpoints in TypeScript code. As a workaround, try using the `debugger` keyword.

> [!NOTE]
> Profiling tests and code coverage aren't currently supported.

## Run unit tests from the command line for a CLI-based project (.esproj)

You can run unit tests directly from the command line for your unit test framework the same way you would if you weren't using Visual Studio.

You may also choose to run the tests from the command line using *vstest.console*. For example, you may want to use vstest.console to maintain consistency with C# unit tests, or to run in Azure DevOps. Use the following command, but replace `MyProj` with your project name.

::: moniker-end
::: moniker range=">=visualstudio"
```
vstest.console .\MyProj.esproj /TestAdapterPath:"C:\Program Files\Microsoft Visual Studio\18\Enterprise\Common7\IDE\Extensions\Microsoft\JavaScript"
```
::: moniker-end

::: moniker range="vs-2022"
```
vstest.console .\MyProj.esproj /TestAdapterPath:"C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\Extensions\Microsoft\JavaScript"
```
::: moniker-end

## Write unit tests for ASP.NET Core

To add support for unit testing of JavaScript and TypeScript in an ASP.NET Core project, you need to add TypeScript, npm, and unit testing support to the project by including required NuGet packages.

### Add a unit test (ASP.NET Core)

The following example is based on the ASP.NET Core Model-View-Controller project template, and includes adding a Jest or Mocha unit test.

1. Create an ASP.NET Core Model-View-Controller project.

   For an example project, see [Add TypeScript to an existing ASP.NET Core app](../javascript/tutorial-aspnet-with-typescript.md). For unit testing support, we recommend you start with a standard ASP.NET Core project template.

1. In Solution Explorer (right pane), right-click the ASP.NET Core project node and select **Manage NuGet Packages for Solutions**.

1. In the **Browse** tab, search for the following packages and install each one:

   ::: moniker range=">=vs-2022"
   - [Microsoft.TypeScript.MSBuild](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild)
   - [Npm](https://www.nuget.org/packages/Npm)
   ::: moniker-end


   Use the NuGet package to add TypeScript support instead of the npm TypeScript package.

1. In Solution Explorer, right-click the project node and choose **Edit Project File**.

   The *.csproj* file opens in Visual Studio.

1. Add the following elements to the *.csproj* file in the `PropertyGroup` element.

   This example specifies Jest or Mocha as the test framework. You could specify Tape or Jasmine instead.

   # [Jest](#tab/jest)

   The `JavaScriptTestRoot` element specifies that your unit tests will be in the *tests* folder of the project root.

   ```xml
   <PropertyGroup>
      ...
      <JavaScriptTestRoot>tests\</JavaScriptTestRoot>
      <JavaScriptTestFramework>Jest</JavaScriptTestFramework>
      <GenerateProgramFile>false</GenerateProgramFile>
   </PropertyGroup>
   ```

   # [Mocha](#tab/mocha)

   The `JavaScriptTestRoot` element specifies the location for your unit tests. To simplify the configuration for Mocha, in this example we point the test root to the output folder, *wwwroot\js\tests\\*.

   ```xml
   <PropertyGroup>
      ...
      <JavaScriptTestRoot>wwwroot\js\tests\</JavaScriptTestRoot>
      <JavaScriptTestFramework>Mocha</JavaScriptTestFramework>
      <GenerateProgramFile>false</GenerateProgramFile>
   </PropertyGroup>
   ```

1. In Solution Explorer, right-click the ASP.NET Core project node and select **Add > New Item**. Choose the **TypeScript JSON Configuration File**, and then select **Add**.

   If you don't see all the item templates, select **Show All Templates**, and then choose the item template.

   Visual Studio adds the *tsconfig.json* file to the project root. You can use this file to [configure options](https://www.typescriptlang.org/docs/handbook/tsconfig-json.html) for the TypeScript compiler.

1. Open *tsconfig.json* and replace the default code with the following code:

   # [Jest](#tab/jest)

   ```json
   {
     "compileOnSave": true,
     "compilerOptions": {
        "noImplicitAny": false,
        "noEmitOnError": true,
        "removeComments": false,
        "sourceMap": true,
        "target": "es5",
        "outDir": "wwwroot/js"
     },
     "include": [
       "scripts/**/*"
     ],
     "exclude": [
      "node_modules",
      "tests"
     ]
   }
   ```

   For Jest, if you want to compile TypeScript tests to JavaScript, remove the *tests* folder from the *exclude* section.

   The *scripts* folder is where you can put the TypeScript code for your app. For an example project that adds code, see [Add TypeScript to an existing ASP.NET Core app](../javascript/tutorial-aspnet-with-typescript.md).

   # [Mocha](#tab/mocha)

   ```json
   {
     "compileOnSave": true,
     "compilerOptions": {
        "noImplicitAny": false,
        "noEmitOnError": true,
        "removeComments": false,
        "sourceMap": true,
        "target": "es5",
        "outDir": "wwwroot/js"
     },
     "include": [
        "scripts/**/*",
        "tests/**/*"
     ],
     "exclude": [
        "node_modules"
     ]
   }
   ```

   The *scripts* folder is where you can put the TypeScript code for your app. For an example project that adds code, see [Add TypeScript to an existing ASP.NET Core app](../javascript/tutorial-aspnet-with-typescript.md).

1. Right-click the project in Solution Explorer and choose **Add** > **New Item** (or press **Ctrl** + **SHIFT** + **A**). Use the search box to find the npm file, choose the **npm Configuration File**, use the default name, and click **Add**.

   A *package.json* file is added to the project root.

1. In Solution Explorer, right-click the **npm** node under Dependencies and choose **Install new npm packages**.

   >[!NOTE]
   > In some scenarios, Solution Explorer might not show the npm node due to a known issue described [here](https://github.com/aspnet/Tooling/issues/479). If you need to see the npm node, you can unload the project (right-click the project and choose **Unload Project**) and then reload the project to make the npm node re-appear. Alternatively, you can add the package entries to *package.json* and install by building the project.

   Use the npm package installation dialog to install the following npm packages:

   # [Jest](#tab/jest)

   - jest
   - jest-editor-support
   - @types/jest

   These packages are added to the *package.json* file under devDependencies.

   ```typescript
    "@types/jest": "^29.5.8",
    "jest": "^29.7.0",
    "jest-editor-support": "^31.1.2"
   ```

   # [Mocha](#tab/mocha)

   - mocha
   - assert
   - @types/mocha
   - @types/node

   These packages are added to the *package.json* file under devDependencies.

   ```typescript
    "@types/mocha": "^10.0.5",
    "@types/node": "^20.9.2",
    "assert": "^2.1.0",
    "mocha": "^10.2.0"
   ```

1. In *package.json*, add the `test` section at the end of the `scripts` section:

   # [Jest](#tab/jest)

   ```json
   "scripts": {
      ...
      "test": "jest"
   },
   ```

   # [Mocha](#tab/mocha)

   ```json
   "scripts": {
      ...
      "test": "mocha"
   },
   ```

1. In Solution Explorer, right-click the *test* folder and choose **Add** > **New Item**, and then add a new file named *App.test.tsx*.

   This adds the new file under the *test* folder.

1. Add the following code to *App.test.tsx*.

   # [Jest](#tab/jest)

   ```javascript
   describe('testAsuite', () => {
      it('testA1', async () => {
         expect(2).toBe(2);
      });
   });
   ```

   # [Mocha](#tab/mocha)

   ```javascript
   var assert = require('assert');

   describe('testAsuite', function () {
      it('testA1', function () {
         assert.equal(1, 1);
      })
   })
   ```

1. Open Test Explorer (choose **Test** > **Windows** > **Test Explorer**) and Visual Studio discovers and displays tests. If tests aren't showing initially, then rebuild the project to refresh the list. The following illustration shows the Jest example, with two different unit test files.

   ![Screenshot of Test Explorer test discovery (ASP.NET Core).](../javascript/media/vs-2022/unit-tests-asp-dotnet-discovery.png)

   > [!NOTE]
   > For TypeScript, don't use the `outfile` option in *tsconfig.json*, because Test Explorer won't be able to find your unit tests. You can use the `outdir` option, but make sure that configuration files such as `package.json` and `tsconfig.json` are in the project root.

   ::: moniker range="vs-2022"
   > [!IMPORTANT]
   > If the output from **Tests** in the Output window shows a `ReadOnlySpan` error during test discovery, use the following workaround for a known [MSBuild issue](https://github.com/dotnet/msbuild/issues/7873). In Visual Studio 2022, open the folder, *Program Files\Microsoft Visual Studio\2022\\<version\>\Common7\IDE\Extensions\TestPlatform*, and rename *System.Memory.dll* to a different name. This fix enables test discovery.
   ::: moniker-end

### Run tests (ASP.NET Core)

You can run the tests by clicking the **Run All** link in Test Explorer. Or, you can run tests by selecting one or more tests or groups, right-clicking, and selecting **Run** from the shortcut menu. Tests run in the background, and Test Explorer automatically updates and shows the results. Furthermore, you can also debug selected tests by right-clicking and selecting **Debug**.

The following illustration shows the Jest example, with a second unit test added.

![Screenshot of Test Explorer results (ASP.NET Core).](../javascript/media/vs-2022/unit-tests-asp-dotnet-run.png)

For some unit test frameworks, unit tests are typically run against the generated JavaScript code.

> [!NOTE]
> In most TypeScript scenarios, you can debug a unit test by setting a breakpoint in TypeScript code, right-clicking a test in Test Explorer, and choosing **Debug**. In more complex scenarios, such as some scenarios that use source maps, you may have difficulty hitting breakpoints in TypeScript code. As a workaround, try using the `debugger` keyword.

> [!NOTE]
> Profiling tests and code coverage aren't currently supported.

