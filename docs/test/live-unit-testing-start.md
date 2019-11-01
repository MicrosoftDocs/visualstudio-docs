---
title: "Learn how to test your code with Live Unit Test"
ms.date: 08/31/2017
ms.topic: conceptual
helpviewer_keywords:
  - "Live Unit Testing"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Get started with Live Unit Testing

When you enable Live Unit Testing in a Visual Studio solution, it visually depicts your test coverage and the status of your tests. Live Unit Testing also dynamically executes tests whenever you modify your code and immediately notifies you when your changes cause tests to fail.

Live Unit Testing can be used to test solutions that target either .NET Framework or .NET Core. In this tutorial, you'll learn to use Live Unit Testing by creating a simple class library that targets .NET Standard, and you'll create an MSTest project that targets .NET Core to test it.

The complete C# solution can be downloaded from the [MicrosoftDocs/visualstudio-docs](https://github.com/MicrosoftDocs/visualstudio-docs/tree/master/docs/test/samples/csharp/UtilityLibraries/) repo on GitHub.

## Prerequisites

This tutorial requires that you've installed Visual Studio Enterprise edition with the **.NET Core cross-platform development** workload.

## Create the solution and the class library project

Begin by creating a Visual Studio solution named UtilityLibraries that consists of a single .NET Standard class library project, StringLibrary.

The solution is just a container for one or more projects. To create a blank solution, open Visual Studio and do the following:

1. Select **File** > **New** > **Project** from the top-level Visual Studio menu.

1. Type **solution** into the template search box, and then select the **Blank Solution** template.

   ::: moniker range="vs-2017"

   ![The **New Project** dialog](./media/lut-start/new-solution.png)

   ::: moniker-end

1. Finish creating the solution.

Now that you've created the solution, you'll create a class library named StringLibrary that contains a number of extension methods for working with strings.

1. In **Solution Explorer**, right-click on the UtilityLibraries solution and select **Add** > **New Project**.

::: moniker range="vs-2017"

2. In the **Add New Project** dialog, select the C# node, then select **.NET Standard**.

   > [!NOTE]
   > Because our library targets .NET Standard rather than a particular .NET implementation, it can be called from any .NET implementation that supports that version of .NET Standard. For more information, see [.NET Standard](/dotnet/standard/net-standard).

3. Select the **Class Library (.NET Standard)** template in the right pane, and enter **StringLibrary** in the **Name** text box, as the following image shows:

   ![The **Add New Project** dialog](./media/lut-start/add-project-cs.png)

4. Select **OK** to create the project.

::: moniker-end

::: moniker range=">=vs-2019"

2. Type **class library** into the template search box, and the select the **Class Library (.NET Standard)** template. Click **Next**.

   > [!NOTE]
   > Because our library targets .NET Standard rather than a particular .NET implementation, it can be called from any .NET implementation that supports that version of .NET Standard. For more information, see [.NET Standard](/dotnet/standard/net-standard).

3. Name the project **StringLibrary**.

4. Click **Create** to create the project.

::: moniker-end

5. Replace all of the existing code in the code window with the following code:

   [!code-csharp[StringLibrary source code](samples/csharp/utilitylibraries/stringlibrary/class1.cs)]

   StringLibrary has three static methods:

   - `StartsWithUpper` returns `true` if a string starts with an uppercase character; otherwise, it returns `false`.

   - `StartsWithLower`returns `true` if a string starts with a lowercase character; otherwise, it returns `false`.

   - `HasEmbeddedSpaces` returns `true` if a string contains an embedded whitespace character; otherwise, it returns `false`.

6. Select **Build** > **Build Solution** from the top-level Visual Studio menu. The build should succeed.

## Create the test project

The next step is to create the unit test project to test the StringLibrary library. Create the unit tests by performing the following steps:

1. In **Solution Explorer**, right-click on the UtilityLibraries solution and select **Add** > **New Project**.

::: moniker range="vs-2017"

2. In the **Add New Project** dialog, select the C# node, then select **.NET Core**.

   > [!NOTE]
   > You do not have to write your unit tests in the same language as your class library.

3. Select the **Unit Test Project (.NET Core)** template in the right pane, and enter **StringLibraryTests** in the **Name** text box, as the following image shows:

   ![The **Add New Project** dialog for the unit test project](./media/lut-start/add-unit-test-cs.png)

4. Select **OK** to create the project.

::: moniker-end

::: moniker range=">=vs-2019"

2. Type **unit test** into the template search box, and the select the **Unit Test Project (.NET Core)** template. Click **Next**.

3. Name the project **StringLibraryTests**.

4. Click **Create** to create the project.

::: moniker-end

   > [!NOTE]
   > This getting started tutorial uses Live Unit Testing with the MSTest test framework. You can also use the xUnit and NUnit test frameworks.

5. The unit test project can't automatically access the class library that it is testing. You give the test library access by adding a reference to the class library project. To do this, right-click on the `StringLibraryTests` project and select **Add** > **Reference**. In the **Reference Manager** dialog, make sure the **Solution** tab is selected, and select the StringLibrary project, as shown in the following image.

   ![The **Reference Manager** dialog](./media/lut-start/add-reference.png)

6. Replace the boilerplate unit test code provided by the template with the following code:

   [!code-csharp[StringLibraryTest source code](samples/snippets/csharp/lut-start/unittest1.cs)]

7. Save your project by selecting the **Save** icon on the toolbar.

8. Because the unit test code includes some non-ASCII characters, Visual Studio displays the following dialog to warn that some characters will be lost if you save the file in its default ASCII format. Choose the **Save with Other Encoding** button.

   ![Choose a file encoding](media/lut-start/ascii-encoding.png)

9. In the **Encoding** drop-down list of the **Advance Save Options** dialog, choose **Unicode (UTF-8 without signature) - Codepage 65001**, as the following image shows:

   ![Choosing the UTF-8 encoding](media/lut-start/utf8-encoding.png)

10. Compile the unit test project by selecting **Build** > **Rebuild Solution** from the top-level Visual Studio menu.

You've created a class library as well as some unit tests for it. You've now finished the preliminaries needed to use Live Unit Testing.

## Enable Live Unit Testing

So far, although you've written the tests for the StringLibrary class library, you haven't executed them. Live Unit Testing executes them automatically once you enable it. To do that, do the following:

1. Optionally, select the code window that contains the code for StringLibrary. This is either *Class1.cs* for a C# project or *Class1.vb* for a Visual Basic project. (This step lets you visually inspect the result of your tests and the extent of your code coverage once you enable Live Unit Testing.)

1. Select **Test** > **Live Unit Testing** > **Start** from the top-level Visual Studio menu.

1. Visual Studio starts Live Unit Test, which automatically runs all of your tests.

When it finishes running your tests, **Test Explorer** displays both the overall results and the result of individual tests. In addition, the code window graphically displays both your test code coverage and the result for your tests. As the following image shows, all three tests have executed successfully. It also shows that our tests have covered all code paths in the `StartsWithUpper` method, and those tests all executed successfully (which is indicated by the green check mark, "✓"). Finally, it shows that none of the other methods in StringLibrary have code coverage (which is indicated by a blue line, "➖").

![The Test Explorer and code window after starting Live Unit testing](media/lut-start/lut-results-cs.png)

You can also get more detailed information about test coverage and test results by selecting a particular code coverage icon in the code window. To examine this detail, do the following:

1. Click on the green check mark on the line that reads `if (String.IsNullOrWhiteSpace(s))` in the `StartsWithUpper` method. As the following image shows, Live Unit Testing indicates that three tests cover that line of code, and that all have executed successfully.

   ![Code coverage for the `if` conditional statement](media/lut-start/code-coverage-cs1.png)

1. Click on the green check mark on the line that reads `return Char.IsUpper(s[0])` in the `StartsWithUpper` method. As the following image shows, Live Unit Testing indicates that only two tests cover that line of code, and that all have executed successfully.

   ![Code coverage for the return statement](media/lut-start/code-coverage-cs2.png)

The major issue that Live Unit Testing identifies is incomplete code coverage. You'll address it in the next section.

## Expand test coverage

In this section, you'll extend your unit tests to the `StartsWithLower` method. While you do that, Live Unit Testing will dynamically continue to test your code.

To extend code coverage to the `StartsWithLower` method, do the following:

1. Add the following `TestStartsWithLower` and `TestDoesNotStartWithLower` methods to your project's test source code file:

    [!code-csharp[StringLibraryTest source code](samples/snippets/csharp/lut-start/unittest2.cs#1)]

1. Modify the `DirectCallWithNullOrEmpty` method by adding the following code immediately after the call to the [`Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse`](/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert.isfalse) method.

    [!code-csharp[StringLibraryTest source code](samples/snippets/csharp/lut-start/unittest2.cs#2)]

1. Live Unit Testing automatically executes new and modified tests when you modify your source code. As the following image of **Test Explorer** shows, all of the tests, including the two you've added and the one you've modified, have succeeded.

   ![The Test Explorer after expanding test coverage](media/lut-start/test-dynamic.png)

1. Switch to the window that contains the source code for the StringLibrary class. Live Unit Testing now shows that our code coverage is extended to the `StartsWithLower` method.

    ![Code coverage for the StartsWithLower method](media/lut-start/lut-extended-cs.png)

In some cases, successful tests in **Test Explorer** may be grayed-out. That indicates that a test is currently executing, or that the test has not run again because there have been no code changes that would impact the test since it was last executed.

So far, all of our tests have succeeded. In the next section, we'll examine how you can handle test failure.

## Handle a test failure

In this section, you'll explore how you can use Live Unit Testing to identify, troubleshoot, and address test failures. You'll do this by expanding test coverage to the `HasEmbeddedSpaces` method.

1. Add the following method to your test file:

    [!code-csharp[The TestHasEmbeddedSpaces test method](samples/snippets/csharp/lut-start/unittest2.cs#3)]

1. When the test executes, Live Unit Testing indicates that the `TestHasEmbeddedSpaces` method has failed, as the following image shows:

   ![The Test Explorer reporting a failed test](media/lut-start/test-failure.png)

1. Select the window that displays the library code. Live Unit Testing has expanded code coverage to the `HasEmbeddedSpaces` method. It also reports the test failure by adding a red  "🞩" to lines covered by failing tests.

1. Hover over the line with the `HasEmbeddedSpaces` method signature. Live Unit Testing displays a tooltip that reports that the method is covered by one test, as the following image shows:

   ![Live Unit Testing information on a failed test](media/lut-start/test-failure-info-cs.png)

1. Select the failed **TestHasEmbeddedSpaces** test. Live Unit Testing gives you a number of options, such as running all tests, running the selected tests, debugging all tests, and debugging selected tests, as the following image shows:

   ![Live Unit Testing options for a failed test](media/lut-start/test-failure-options.png)

1. Select **Debug Selected** to debug the failed test.

1. Visual Studio executes the test in debug mode.

   The test assigns each string in an array to a variable named `phrase` and passes it to the `HasEmbeddedSpaces` method. Program execution pauses and invokes the debugger the first time the assert expression is `false`. The exception dialog that results from the unexpected value in the [`Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue`](/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert.istrue) method call is shown in the following image.

   ![Live Unit Testing exception dialog](media/lut-start/exception-dialog-cs.png)

   In addition, all of the debugging tools that Visual Studio provides are available to help us troubleshoot our failed test, as the following image shows:

   ![Visual Studio debugging tools](media/lut-start/debugging-tools-cs.png)

   Note in the **Autos** window that the value of the `phrase` variable is "Name\tDescription", which is the second element of the array. The test method expects `HasEmbeddedSpaces` to return `true` when it is passed this string; instead, it returns `false`. Evidently, it does not recognize "\t", the tab character, as an embedded space.

1. Select **Debug** > **Continue**, press **F5**, or click the **Continue** button on the toolbar to continue executing the test program. Because an unhandled exception occurred, the test terminates.
This provides enough information for a preliminary investigation of the bug. Either `TestHasEmbeddedSpaces` (the test routine) made an incorrect assumption, or `HasEmbeddedSpaces` does not correctly recognize all embedded spaces.

1. To diagnose and correct the problem, start with the `StringLibrary.HasEmbeddedSpaces` method. Look at the comparison in the `HasEmbeddedSpaces` method. It considers an embedded space to be U+0020. However, the Unicode Standard includes a number of other space characters. This suggests that the library code has incorrectly tested for a whitespace character.

1. Replace the equality comparison with a call to the <xref:System.Char.IsWhiteSpace%2A?displayProperty=fullName> method:

    [!code-csharp[The TestHasEmbeddedSpaces test method](samples/snippets/csharp/lut-start/program2.cs#1)]

1. Live Unit Testing automatically reruns the failed test method and updates the results in the code window and in **Test Explorer**, as the following image shows:

    ![Successful HasEmbeddedSpaces test](media/lut-start/test-success-cs.png)

## See also

- [Live Unit Testing in Visual Studio](live-unit-testing.md)
- [Live Unit Testing Frequently Asked Questions](live-unit-testing-faq.md)