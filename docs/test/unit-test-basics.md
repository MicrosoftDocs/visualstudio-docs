---
title: Unit test basics with Test Explorer
description: Learn how Visual Studio Test Explorer provides a flexible and efficient way to run your unit tests and view their results. 
ms.date: 09/09/2025
ms.topic: article
f1_keywords:
- vs.UnitTest.CreateUnitTest
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Unit test basics

Check that your code is working as expected by creating and running unit tests. It's called unit testing because you break down the functionality of your program into discrete testable behaviors that you can test as individual *units*. Visual Studio Test Explorer provides a flexible and efficient way to run your unit tests and view their results in Visual Studio. Visual Studio installs the Microsoft unit testing frameworks for managed and native code. Use a *unit testing framework* to create unit tests, run them, and report the results of these tests. Rerun unit tests when you make changes to test that your code is still working correctly. Visual Studio Enterprise can do this automatically with [Live Unit Testing](live-unit-testing-intro.md), which detects tests affected by your code changes and runs them in the background as you type.

Unit testing has the greatest effect on the quality of your code when it's an integral part of your software development workflow. As soon as you write a function or other block of application code, create unit tests that verify the behavior of the code in response to standard, boundary, and incorrect cases of input data, and that check any explicit or implicit assumptions made by the code. With *test driven development*, you create the unit tests before you write the code, so you use the unit tests as both design documentation and functional specifications.

Test Explorer can also run third-party and open source unit test frameworks that have implemented Test Explorer add-on interfaces. You can add many of these frameworks through the Visual Studio Extension Manager and the Visual Studio gallery. For more information, see [Install third-party unit test frameworks](../test/install-third-party-unit-test-frameworks.md).

You can quickly generate test projects and test methods from your code, or manually create the tests as you need them. When you use IntelliTest to explore .NET code, you can generate test data and a suite of unit tests. For every statement in the code, a test input is generated that will execute that statement. Find out how to [generate unit tests for .NET code](generate-unit-tests-for-your-code-with-intellitest.md).

## Get started

For an introduction to unit testing that takes you directly into coding, see one of these articles:

- [Walkthrough: Create and run unit tests for .NET code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)

- [Walkthrough: Test driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)

- [Write unit tests for C/C++ in Visual Studio](../test/writing-unit-tests-for-c-cpp.md)

## The Bank solution example

In this article, we use the development of a fictional application called `MyBank` as an example. You don't need the actual code to follow the explanations in this article. Test methods are written in C# and presented by using the Microsoft Unit Testing Framework for Managed Code. However, the concepts are easily transferred to other languages and frameworks.

::: moniker range="vs-2019"
![MyBank Solution 2019](../test/media/vs-2019/basics-mybank-solution.png)
::: moniker-end
::: moniker range=">=vs-2022"
![MyBank Solution 2022](../test/media/vs-2022/basics-mybank-solution.png)
::: moniker-end

Our first attempt at a design for the `MyBank` application includes an accounts component that represents an individual account and its transactions with the bank, and a database component that represents the functionality to aggregate and manage the individual accounts.

We create a `Bank` solution that contains two projects:

- `Accounts`

- `BankDB`

Our first attempt at designing the `Accounts` project contains a class to hold basic information about an account, an interface that specifies the common functionality of any type of account, like depositing and withdrawing assets from the account, and a class derived from the interface that represents a checking account. We begin the Accounts projects by creating the following source files:

- *AccountInfo.cs* defines the basic information for an account.

- *IAccount.cs* defines a standard `IAccount` interface for an account, including methods to deposit and withdraw assets from an account and to retrieve the account balance.

- *CheckingAccount.cs* contains the `CheckingAccount` class that implements the `IAccount` interface for a checking account.

We know from experience that one thing a withdrawal from a checking account must do is to make sure that the amount withdrawn is less than the account balance. So we override the `IAccount.Withdraw` method in `CheckingAccount` with a method that checks for this condition. The method might look like this:

```csharp
public void Withdraw(double amount)
{
    if(m_balance >= amount)
    {
        m_balance -= amount;
    }
    else
    {
        throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
    }
}
```

Now that we have some code, it's time for testing.

## Create unit tests with Copilot

You can also use Copilot `/tests` slash command to generate unit tests from code. For example, you can type `/tests using NUnit Framework` to generate NUnit tests. For more information, see [Use slash commands in Copilot Chat](../ide/copilot-chat-context.md#slash-commands).

## Create unit test projects and test methods (C#)

For C#, it is often quicker to generate the unit test project and unit test stubs from your code. Or you can choose to create the unit test project and tests manually depending on your requirements. If you want to create unit tests from code with a 3rd party framework you will need one of these extensions installed: [NUnit](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.TestGeneratorNUnitextension-18371) or [xUnit](https://marketplace.visualstudio.com/items?itemName=YowkoTsai.xUnitnetTestGenerator). If you are not using C#, skip this section and go to [Create the unit test project and unit tests manually](#create-the-unit-test-project-and-unit-tests-manually).

### Generate unit test project and unit test stubs

1. From the code editor window, right-click and choose [**Create Unit Tests**](create-unit-tests-menu.md) from the right-click menu.

   ::: moniker range="vs-2019"
   ![From the editor window, view the context menu](../test/media/vs-2019/basics-create-unit-tests.png)

   > [!NOTE]
   > The **Create Unit Tests** menu command is only available for C# code. To use this method with .NET Core or .NET Standard, Visual Studio 2019 or later is required.
   ::: moniker-end

   ::: moniker range=">=vs-2022"
   ![From the editor window, view the context menu](../test/media/vs-2022/basics-create-unit-tests.png)

   > [!NOTE]
   > The **Create Unit Tests** menu command is only available for C# code. To use this method with .NET Core or .NET Standard, Visual Studio 2019 or later is required.
   ::: moniker-end

2. Select **OK** to accept the defaults to create your unit tests, or change the values used to create and name the unit test project and the unit tests. You can select the code that is added by default to the unit test methods.

   ::: moniker range="<=vs-2019"
   ![Create Unit Tests dialog box in Visual Studio](../test/media/create-unit-tests.png)
   ::: moniker-end
   ::: moniker range=">=vs-2022"
   ![Create Unit Tests dialog box in Visual Studio](../test/media/vs-2022/create-unit-tests.png)
   ::: moniker-end

3. The unit test stubs are created in a new unit test project for all the methods in the class.

   ::: moniker range="vs-2019"
   ![The unit tests are created](../test/media/vs-2019/basics-test-stub.png)
   ::: moniker-end
   ::: moniker range=">=vs-2022"
   ![The unit tests are created](../test/media/vs-2022/basics-test-stub.png)
   ::: moniker-end

4. Now jump ahead to learn how to [Write your tests](#write-your-tests) to make your unit test meaningful, and any extra unit tests that you might want to add to thoroughly test your code.

### Create the unit test project and unit tests manually

A unit test project usually mirrors the structure of a single code project. In the MyBank example, you add two unit test projects named `AccountsTests` and `BankDbTests` to the `Bank` solution. The test project names are arbitrary, but adopting a standard naming convention is a good idea.

**To add a unit test project to a solution:**

1. In **Solution Explorer**, right-click on the solution and choose **Add** > **New** **Project**.

2. Type **test** in the project template search box to find a unit test project template for the test framework that you want to use. (In the examples in this article, we use MSTest.)

3. On the next page, name the project. To test the `Accounts` project of our example, you could name the project `AccountsTests`.

4. In your unit test project, add a reference to the code project under test, in our example to the Accounts project.

   To create the reference to the code project:
   
   1. In the unit test project in Solution Explorer, right-click the **References** or **Dependencies** node, and then choose **Add Project Reference** or **Add Reference**, whichever is available.

   2. On the **Reference Manager** dialog box, open the **Solution** node and choose **Projects**. Select the code project name and close the dialog box.

Each unit test project contains classes that mirror the names of the classes in the code project. In our example, the `AccountsTests` project would contain the following classes:

- `AccountInfoTests` class contains the unit test methods for the `AccountInfo` class in the `Accounts` project

- `CheckingAccountTests` class contains the unit test methods for `CheckingAccount` class.

## Write your tests

The unit test framework that you use and Visual Studio IntelliSense will guide you through writing the code for your unit tests for a code project. To run in **Test Explorer**, most frameworks require that you add specific attributes to identify unit test methods. The frameworks also provide a way—usually through assert statements or method attributes—to indicate whether the test method has passed or failed. Other attributes identify optional setup methods that are at class initialization and before each test method and teardown methods that are run after each test method and before the class is destroyed.

The AAA (Arrange, Act, Assert) pattern is a common way of writing unit tests for a method under test.

- The **Arrange** section of a unit test method initializes objects and sets the value of the data that is passed to the method under test.

- The **Act** section invokes the method under test with the arranged parameters.

- The **Assert** section verifies that the action of the method under test behaves as expected. For .NET, methods in the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert> class are often used for verification.

To test the `CheckingAccount.Withdraw` method of our example, we can write two tests: one that verifies the standard behavior of the method, and one that verifies that a withdrawal of more than the balance will fail (The following code shows an MSTest unit test, which is supported in .NET.). In the `CheckingAccountTests` class, we add the following methods:

```csharp
[TestMethod]
public void Withdraw_ValidAmount_ChangesBalance()
{
    // arrange
    double currentBalance = 10.0;
    double withdrawal = 1.0;
    double expected = 9.0;
    var account = new CheckingAccount("JohnDoe", currentBalance);

    // act
    account.Withdraw(withdrawal);

    // assert
    Assert.AreEqual(expected, account.Balance);
}

[TestMethod]
public void Withdraw_AmountMoreThanBalance_Throws()
{
    // arrange
    var account = new CheckingAccount("John Doe", 10.0);

    // act and assert
    Assert.ThrowsException<System.ArgumentException>(() => account.Withdraw(20.0));
}
```

For more information about the Microsoft unit testing frameworks, see one of the following articles:

- [Unit test your code](unit-test-your-code.md)

- [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md)

## Set timeouts for unit tests

If you're using the MSTest framework, you can use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TimeoutAttribute> to set a timeout on an individual test method:

```csharp
[TestMethod]
[Timeout(2000)]  // Milliseconds
public void My_Test()
{ ...
}
```

To set the timeout to the maximum allowed:

```csharp
[TestMethod]
[Timeout(TestTimeout.Infinite)]  // Milliseconds
public void My_Test ()
{ ...
}
```

## Run tests in Test Explorer

When you build the test project, the tests appear in **Test Explorer**. If **Test Explorer** is not visible, choose **Test** on the Visual Studio menu, choose **Windows**, and then choose **Test Explorer** (or press **Ctrl** + **E**, **T**).

::: moniker range="vs-2019"
![Unit Test Explorer](../test/media/vs-2019/basics-test-explorer.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Unit Test Explorer](../test/media/vs-2022/basics-test-explorer.png)
::: moniker-end

As you run, write, and rerun your tests, the **Test Explorer** can display the results in groups of **Failed Tests**, **Passed Tests**, **Skipped Tests** and **Not Run Tests**. You can choose different group by options in the toolbar.

You can also filter the tests in any view by matching text in the search box at the global level or by selecting one of the pre-defined filters. You can run any selection of the tests at any time. The results of a test run are immediately apparent in the pass/fail bar at the top of the explorer window. Details of a test method result are displayed when you select the test.

### Run and view tests

The **Test Explorer** toolbar helps you discover, organize, and run the tests that you are interested in.

::: moniker range="vs-2019"
![Run tests from the Test Explorer toolbar](../test/media/vs-2019/test-explorer-toolbar-diagram-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Run tests from the Test Explorer toolbar](../test/media/vs-2022/test-explorer-toolbar-diagram-17-0.png)
::: moniker-end

You can choose **Run All** to run all your tests (or press **Ctrl** + **R**, **V**), or choose **Run** to choose a subset of tests to run (**Ctrl** + **R**, **T**). Select a test to view the details of that test in the test details pane. Choose **Open Test** from the right-click menu (Keyboard: **F12**) to display the source code for the selected test.

If individual tests have no dependencies that prevent them from being run in any order, turn on parallel test execution in the settings menu of the toolbar. This can noticeably reduce the time taken to run all the tests.

### Run tests after every build

To run your unit tests after each local build, open the settings icon in the Test Explorer toolbar and select **Run Tests After Build**.

### Filter and group the test list

When you have a large number of tests, you can type in the **Test Explorer** search box to filter the list by the specified string. You can restrict your filter event more by choosing from the filter list.

::: moniker range="vs-2019"
![Search filter categories](../test/media/vs-2019/test-explorer-search-filter-16-2.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Search filter categories](../test/media/vs-2022/test-explorer-search-filter-17-0.png)
::: moniker-end

|Button|Description|
|-|-|
|![Test Explorer group button](../test/media/ute_groupby_btn.png)|To group your tests by category, choose the **Group By** button.|

For more information, see [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md).

## Q&A

**Q: How do I debug unit tests?**

**A:** Use **Test Explorer** to start a debugging session for your tests. Stepping through your code with the Visual Studio debugger seamlessly takes you back and forth between the unit tests and the project under test. To start debugging:

1. In the Visual Studio editor, set a breakpoint in one or more test methods that you want to debug.

    > [!NOTE]
    > Because test methods can run in any order, set breakpoints in all the test methods that you want to debug.

2. In **Test Explorer**, select the test methods and then choose **Debug Selected Tests** from the shortcut menu.

Learn more details about [debugging unit tests](../debugger/debugger-feature-tour.md).

**Q: If I'm using TDD, how do I generate code from my tests?**

**A:** Use Quick Actions to generate classes and methods in your project code. Write a statement in a test method that calls the class or method that you want to generate, then open the light bulb that appears under the error. If the call is to a constructor of the new class, choose **Generate type** from the menu and follow the wizard to insert the class in your code project. If the call is to a method, choose **Generate method** from the IntelliSense menu.

::: moniker range="vs-2019"
![Generate Method Stub Quick Action Menu](../test/media/vs-2019/basics-generate-method-tdd.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Generate Method Stub Quick Action Menu](../test/media/vs-2022/basics-generate-method-tdd.png)
::: moniker-end

**Q: Can I create unit tests that take multiple sets of data as input to run the test?**

**A:** Yes. *Data-driven test methods* let you test a range of values with a single unit test method. Use a `DataRow`, `DynamicData` or `DataSource` attribute for the test method that specifies the data source that contains the variable values that you want to test.

The attributed method runs once for each row in the data source. **Test Explorer** reports a test failure for the method if any of the iterations fail. The test results detail pane for the method shows you the pass/fail status method for each row of data.

Learn more about [data-driven unit tests](../test/how-to-create-a-data-driven-unit-test.md).

**Q: Can I view how much of my code is tested by my unit tests?**

::: moniker range=">=visualstudio"
**A:** Yes. You can determine the amount of your code that is actually being tested by your unit tests by using the Visual Studio Code coverage tool in Visual Studio. Native and managed languages and all unit test frameworks that can be run by the Unit Test Framework are supported.
::: moniker-end

::: moniker range="<=vs-2022"
**A:** Yes. You can determine the amount of your code that is actually being tested by your unit tests by using the Visual Studio Code coverage tool in Visual Studio Enterprise. Native and managed languages and all unit test frameworks that can be run by the Unit Test Framework are supported.
::: moniker-end

You can run code coverage on selected tests or on all tests in a solution. The **Code Coverage Results** window displays the percentage of the blocks of product code that were exercised by line, function, class, namespace and module.

To run code coverage for test methods in a solution, choose **Test** > **Analyze Code Coverage for All Tests**.

Coverage results appear in the **Code Coverage Results** window.

::: moniker range="<=vs-2019"
![Code coverage results](../test/media/ute_codecoverageresults.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Code coverage results](../test/media/vs-2022/ute-code-coverage-results.png)
::: moniker-end

Learn more about [code coverage](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

**Q: Can I test methods in my code that have external dependencies?**

**A:** Yes. If you have Visual Studio Enterprise, Microsoft Fakes can be used with test methods that you write by using unit test frameworks for managed code.

Microsoft Fakes uses two approaches to create substitute classes for external dependencies:

1. *Stubs* generate substitute classes derived from the parent interface of the target dependency class. Stub methods can be substituted for public virtual methods of the target class.

2. *Shims* use runtime instrumentation to divert calls to a target method to a substitute shim method for non-virtual methods.

In both approaches, you use the generated delegates of calls to the dependency method to specify the behavior that you want in the test method.

Learn more about [isolating unit test methods with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md).

**Q: Can I use other unit test frameworks to create unit tests?**

**A:** Yes, follow these steps to [find and install other frameworks](../test/install-third-party-unit-test-frameworks.md). After you restart Visual Studio, reopen your solution to create your unit tests, and then select your installed frameworks here:

![Select other installed unit test framework](../test/media/createunittestsdialogextensions.png)

Your unit test stubs will be created using the selected framework.

**Q: How do I export my unit test results?**

**A:** You can use a *.runsettings* file with either the command-line or the Visual Studio IDE to configure unit tests and set the test results file. For more information, see [LoggerRunSettings element](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#loggerrunsettings-element).
