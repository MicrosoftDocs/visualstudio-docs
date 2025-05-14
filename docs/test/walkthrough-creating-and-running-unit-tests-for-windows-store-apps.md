---
title: Create and run unit tests for Universal Windows Platform (UWP) apps
description: Learn about unit testing UWP apps in Visual Studio, and use test-driven development to create and unit test a C# UWP app.
ms.date: 01/17/2023
ms.topic: conceptual
helpviewer_keywords:
- unit tests, creating
- unit tests
- unit tests, UWP apps
- unit tests, running
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Walkthrough: Create and run unit tests for UWP apps

This article describes how to unit test Universal Windows Platform (UWP) apps in Visual Studio. Visual Studio offers UWP unit test project templates for C#, Visual Basic, and C++. For more information about developing UWP apps, see [Get started with UWP apps](/windows/uwp/get-started/).

The article walks through an example of creating and unit testing a C# class in a UWP app. The example uses [test-driven development](quick-start-test-driven-development-with-test-explorer.md) to write tests that verify specific behaviors, and then write code that passes the tests.

## Create and run a unit test project

The following procedures describe how to create and run unit test projects for UWP apps.

### Create a UWP unit test project

::: moniker range=">=vs-2022"

1. On the Visual Studio **Start** window, choose **Create a new project**.

1. On the **Create a new project** page, enter *unit test* in the Search box. The template list filters to unit testing projects.

1. Select the correct UWP unit testing template for either C# or Visual Basic, and then select **Next**.

   Starting in Visual Studio 2022 version 17.14, the recommended unit testing template for C# and .NET 9 is **UWP Unit Test App** and targets Native AOT. The older UWP templates are named **UWP Unit Test App (.NET Native)** and **Unit Test App (Universal Windows)**.

   :::image type="content" source="media/vs-2022/new-uwp-unit-test-app.png" alt-text="Screenshot that shows creating a new UWP unit test app in Visual Studio.":::

1. Optionally change the project or solution name and location, and then select **Create**.

1. Optionally change the target and minimum platform versions, and then select **OK**.

Visual Studio creates the test project and opens it in Visual Studio **Solution Explorer**.

:::image type="content" source="media/vs-2022/uwp-unit-test-project-solution-explorer.png"  alt-text="Screenshot that shows the UWP unit test project in Solution Explorer.":::

::: moniker-end

::: moniker range="vs-2019"

1. On the Visual Studio **Start** window, choose **Create a new project**.

1. On the **Create a new project** page, enter *unit test* in the Search box. The template list filters to unit testing projects.

1. Select the **Unit Test App (Universal Windows)** template for either C# or Visual Basic, and then select **Next**.

   :::image type="content" source="media/vs-2019/new-uwp-unit-test-app.png" alt-text="Screenshot that shows creating a new UWP unit test app in Visual Studio.":::

1. Optionally change the project or solution name and location, and then select **Create**.

1. Optionally change the target and minimum platform versions, and then select **OK**.

Visual Studio creates the test project and opens it in Visual Studio **Solution Explorer**.

:::image type="content" source="media/vs-2019/uwp-unit-test-project-solution-explorer.png"  alt-text="Screenshot that shows the UWP unit test project in Solution Explorer.":::

::: moniker-end

### Edit the project's application manifest

1. In **Solution Explorer**, right-click the *Package.appxmanifest* file and select **Open**.

1. In the manifest designer, select the **Capabilities** tab.

1. In the **Capabilities** list, select the capabilities you need for the code and unit test. For example, if your code and its unit test need to access the internet, select the **Internet** checkbox.

Select only the capabilities you need for the unit test to function correctly.

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/unit-test.png" alt-text="Screenshot that shows a unit test manifest.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/unit-test.png" alt-text="Screenshot that shows a unit test manifest.":::

::: moniker-end

### Add code to unit test the UWP app

In the Visual Studio code editor, edit the unit test code file to add the asserts and logic your tests require. For examples, see [Unit test a C# class](#unit-test-a-c-class) later in this article.

### Run the unit test with Test Explorer

::: moniker range=">=vs-2022"

Build the solution and run the unit test by using **Test Explorer**.

1. On the Visual Studio **Test** menu, select **Test Explorer**. The **Test Explorer** window opens.

1. In **Test Explorer**, select the **Run all** icon. You must use **Run all** to discover tests in UWP projects.

   :::image type="content" source="media/vs-2022/test-explorer.png" alt-text="Screenshot that shows Test Explorer Run all icon.":::

The solution builds and the unit test runs. After the test runs, the test appears in the **Test Explorer** test list, with information about outcome and duration.

:::image type="content" source="media/vs-2022/test-explorer-run.png" alt-text="Screenshot that shows the Test Explorer with completed test information.":::

Also in **Test Explorer**, you can select individual tests and right-click to **Run** or **Debug** the tests, or **Go To Test** to open the test code. From the top menu, you can group tests, add tests to playlists, or open test options.

:::image type="content" source="media/vs-2022/test-explorer-done.png" alt-text="Screenshot that shows a Test Explorer context menu.":::

::: moniker-end

::: moniker range="vs-2019"

Build the solution and run the unit test by using **Test Explorer**. 

1. On the Visual Studio **Test** menu, select **Test Explorer**. The **Test Explorer** window opens.

1. In **Test Explorer**, select the **Run all** icon. You must use **Run all** to discover tests in UWP projects.

   :::image type="content" source="media/vs-2019/test-explorer.png" alt-text="Screenshot that shows Test Explorer Run all icon.":::

The solution builds and the unit test runs. After the test runs, the test appears in the **Test Explorer** test list, with information about outcome and duration.

:::image type="content" source="media/vs-2019/test-explorer-run.png" alt-text="Screenshot that shows the Test Explorer with completed test information.":::

Also in **Test Explorer**, you can select individual tests and right-click to **Run** or **Debug** the tests, or **Go To Test** to open the test code. From the top menu, you can group tests, add tests to playlists, or open test **Options**.

:::image type="content" source="media/vs-2019/test-explorer-done.png" alt-text="Screenshot that shows a Test Explorer context menu.":::

::: moniker-end

## Unit test a C# class

A stable set of good unit tests increases confidence that you haven't introduced bugs when you change code. The following example walks through one way to create unit tests for a C# class in a UWP app. The example uses *test-driven development* to write tests that verify specific behavior, and then write code that passes the tests.

In the example **Maths** code project, the **Rooter** class implements a function that calculates the estimated square root of a number. The **RooterTests** project unit tests the **Rooter** class.

### Create the solution and projects

Create the UWP app project:

1. On the Visual Studio **File** menu, select **New Project**.
1. On the **Create a new project** page, enter *blank app* in the Search box, and then select the C# **Blank App (Universal Windows)** project template.
1. On the **Configure your new project** page, name the project *Maths*, and select **Create**.
1. Optionally change the target and minimum platform versions, and then select **OK**. Visual Studio creates the project and opens it in **Solution Explorer**.

Create the unit test project:

1. In **Solution Explorer**, right-click the **Maths** solution and choose **Add** > **New Project**.
1. On the **Add a new project** page, enter *unit test* in the Search box, and then select the C# **Unit Test App (Universal Windows)** project template.
1. Name the test project *RooterTests*, and select **Create**.
1. Optionally change the target and minimum platform versions, and then select **OK**. The **RooterTests** project appears under the **Maths** solution in **Solution Explorer**.

### Verify that tests run in Test Explorer

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert> class provides several static methods that you can use to verify results in test methods.

1. In **Solution Explorer**, select the *UnitTest.cs* file in the **RooterTests** project.

1. Insert the following code into `TestMethod1`:

   ```csharp
   [TestMethod]
   public void TestMethod1()
   {
       Assert.AreEqual(0, 0);
   }
   ```

1. In **Test Explorer**, select **Run All Tests**.

1. The test project builds and runs, and the test appears under **Passed Tests**. The **Group Summary** pane on the right provides details about the test.

### Add a class to the app project

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click the **Maths** project and select **Add** > **Class**.

1. Name the class file *Rooter.cs*, and then select **Add**.

1. In the code editor, add the following code to the `Rooter` class in the *Rooter.cs* file:

   ```csharp
   public Rooter()
   {
   }
   
   // estimate the square root of a number
   public double SquareRoot(double x)
   {
       return 0.0;
   }
   ```

   The `Rooter` class declares a constructor and the `SquareRoot` estimator method. The `SquareRoot` method is a minimal implementation to test the basic testing setup.

1. Change the `internal` keyword to `public` in the `Rooter` class declaration, so the test code can access it.

   ```csharp
   public class Rooter
   ```
::: moniker-end

::: moniker range="<=vs-2019"

1. In **Solution Explorer**, right-click the **Maths** project and select **Add** > **Class**.

1. Name the class file *Rooter.cs*, and then select **Add**.

1. In the code editor, add the following code to the `Rooter` class in the *Rooter.cs* file:

   ```csharp
   public Rooter()
   {
   }
   
   // estimate the square root of a number
   public double SquareRoot(double x)
   {
       return 0.0;
   }
   ```

   The `Rooter` class declares a constructor and the `SquareRoot` estimator method. The `SquareRoot` method is a minimal implementation to test the basic testing setup.

1. Add the `public` keyword to the `Rooter` class declaration, so the test code can access it.

   ```csharp
   public class Rooter
   ```
::: moniker-end

### Add a reference from the test project to the app project

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click the **RooterTests** project, and select **Add** > **Reference**.

1. In the **Reference Manager - RooterTests** dialog box, expand **Projects**, and select the **Maths** project.

   :::image type="content" source="media/vs-2022/add-reference.png" alt-text="Screenshot that shows adding a reference to the Maths project.":::

1. Select **OK**.

1. Add the following `using` statement to the *UnitTest.cs*, after the `using Microsoft.VisualStudio.TestTools.UnitTesting;` line:

   ```csharp
   using Maths;
   ```

::: moniker-end

::: moniker range="vs-2019"

1. In **Solution Explorer**, right-click the **RooterTests** project, and select **Add** > **Reference**.

1. In the **Reference Manager - RooterTests** dialog box, expand **Projects**, and select the **Maths** project.

   :::image type="content" source="media/ute_cs_windows_addreference.png" alt-text="Screenshot that shows adding a reference to the Maths project.":::

1. Select **OK**.

1. Add the following `using` statement to *UnitTest.cs*, after the `using Microsoft.VisualStudio.TestTools.UnitTesting;` line:

   ```csharp
   using Maths;
   ```

::: moniker-end

### Add a test that uses the app function

1. Add the following test method to *UnitTest.cs*:

   ```csharp
   [TestMethod]
   public void BasicTest()
   {
       Maths.Rooter rooter = new Rooter();
       double expected = 0.0;
       double actual = rooter.SquareRoot(expected * expected);
       double tolerance = .001;
       Assert.AreEqual(expected, actual, tolerance);
   }
   ```

   The new test appears in **Solution Explorer** and in the **Not Run Tests** node of **Test Explorer**.

1. To avoid a "Payload contains two or more files with the same destination path" error, in **Solution Explorer**, expand the **Properties** node under the **Maths** project, and delete the *Default.rd.xml* file.

1. Save all files.

### Run the tests

::: moniker range=">=vs-2022"

In **Test Explorer**, select the **Run All Tests** icon. The solution builds, and the tests run and pass.

:::image type="content" source="media/vs-2022/test-explorer-uwp-app.png" alt-text="Screenshot that shows Basic Test passed in Test Explorer":::

::: moniker-end

::: moniker range="vs-2019"

In **Test Explorer**, select the **Run All Tests** icon. The solution builds, and the tests run and pass.

:::image type="content" source="media/vs-2019/test-explorer-uwp-app.png" alt-text="Screenshot that shows Basic Test passed in Test Explorer":::

::: moniker-end

If you get a Duplicate Entity error when you run the test, delete the runtime directives file, `Properties\Default.rd.xml` from the test project and re-try.

You've set up the test and app projects and verified that you can run tests that call functions in the app project. Now you can write real tests and code.

### Add tests and make them pass

It's best not to change tests that have passed. Add new tests instead. Develop code by adding tests one at a time, and make sure that all tests pass after each iteration.

::: moniker range=">=vs-2022"

1. Add a new test called `RangeTest` to *UnitTest.cs*:

   ```csharp
   [TestMethod]
   public void RangeTest()
   {
       Rooter rooter = new Rooter();
       for (double v = 1e-6; v < 1e6; v = v * 3.2)
       {
           double expected = v;
           double actual = rooter.SquareRoot(v*v);
           double tolerance = expected/1000;
           Assert.AreEqual(expected, actual, tolerance);
       }
   }
   ```

1. Run the **RangeTest** test and verify that it fails.

   :::image type="content" source="media/vs-2022/test-explorer-rangetest-fail.png" alt-text="Screenshot that shows the RangeTest fails in Test Explorer.":::

   > [!TIP]
   > In test driven development, you run a test immediately after you write it. This practice helps you avoid the easy mistake of writing a test that never fails.

1. Fix your app code so that the new test passes. In *Rooter.cs*, change the `SquareRoot` function as follows:

   ```csharp
   public double SquareRoot(double x)
   {
       double estimate = x;
       double diff = x;
       while (diff > estimate / 1000)
       {
           double previousEstimate = estimate;
           estimate = estimate - (estimate * estimate - x) / (2 * estimate);
           diff = Math.Abs(previousEstimate - estimate);
       }
       return estimate;
   }
   ```

1. In **Test Explorer**, select the **Run all tests** icon. All three tests now pass.

::: moniker-end

::: moniker range="vs-2019"

1. Add a new test called `RangeTest` to *UnitTest.cs*:

   ```csharp
   [TestMethod]
   public void RangeTest()
   {
       Rooter rooter = new Rooter();
       for (double v = 1e-6; v < 1e6; v = v * 3.2)
       {
           double expected = v;
           double actual = rooter.SquareRoot(v*v);
           double tolerance = expected/1000;
           Assert.AreEqual(expected, actual, tolerance);
       }
   }
   ```

1. Run the **RangeTest** test and verify that it fails.

   :::image type="content" source="media/vs-2019/test-explorer-rangetest-fail.png" alt-text="Screenshot that shows the RangeTest fails in Test Explorer.":::

   > [!TIP]
   > In test driven development, you run a test immediately after you write it. This practice helps you avoid the easy mistake of writing a test that never fails.

1. Fix your app code so that the new test passes. In *Rooter.cs*, change the `SquareRoot` function as follows:

   ```csharp
   public double SquareRoot(double x)
   {
       double estimate = x;
       double diff = x;
       while (diff > estimate / 1000)
       {
           double previousEstimate = estimate;
           estimate = estimate - (estimate * estimate - x) / (2 * estimate);
           diff = Math.Abs(previousEstimate - estimate);
       }
       return estimate;
   }
   ```

1. In **Test Explorer**, select the **Run all tests** icon. All three tests now pass.

::: moniker-end

### Refactor the code

In this section, you refactor both the app and the test code, then rerun the tests to make sure they still pass.

#### Simplify the square root estimation

1. In *Rooter.cs*, simplify the central calculation in the `SquareRoot` function by changing the following line:

   `estimate = estimate - (estimate * estimate - x) / (2 * estimate);`

   To

   `estimate = (estimate + x/estimate) / 2.0;`

1. Run all tests to make sure you haven't introduced a regression. The tests should all pass.

#### Remove duplicate test code

The `RangeTest` method hard codes the denominator of the `tolerance` variable that's passed to the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert> method. If you plan to add more tests that use the same tolerance calculation, using a hard-coded value in several locations makes the code harder to maintain. Instead, you can add a private helper method to the `UnitTest1` class to calculate the tolerance value, and then call that method from `RangeTest`.

To add the helper method, in *UnitTest.cs*:

1. Add the following method to the `UnitTest1` class:

   ```csharp
   private double ToleranceHelper(double expected)
   {
       return expected / 1000;
   }
   ```

1. In `RangeTest`, change the following line:

   `double tolerance = expected/1000;`

   To

   `double tolerance = ToleranceHelper(expected);`

1. Run the **RangeTest** test to make sure it still passes.

> [!TIP]
> If you add a helper method to a test class, and you don't want the helper method to appear in the list in **Test Explorer**, don't add the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute> attribute to the method.

## Next steps

- [Unit test tools and tasks](../test/unit-test-your-code.md)
- [Walkthrough: Create and run unit tests for managed code](walkthrough-creating-and-running-unit-tests-for-managed-code.md)
- [Walkthrough: Test-driven development using Test Explorer](quick-start-test-driven-development-with-test-explorer.md)
