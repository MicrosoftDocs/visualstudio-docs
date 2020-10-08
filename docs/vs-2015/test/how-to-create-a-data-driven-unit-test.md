---
title: "How To: Create a Data-Driven Unit Test | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
f1_keywords:
  - "vs.test.testresults.unittest.datadriven"
  - "vs.test.testresults.unittest.datadriven.failure"
helpviewer_keywords:
  - "unit tests, running"
  - "unit tests, data-driven"
  - "data-driven unit tests"
ms.assetid: a0322bc5-02c8-4f9f-af43-100a60b1bd28
caps.latest.revision: 35
ms.author: jillfra
manager: jillfra
---
# How To: Create a Data-Driven Unit Test
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Using the Microsoft unit test framework for managed code, you can set up a unit test method to retrieve values used in the test method from a data source. The method is run successively for each row in the data source, which makes it easy to test a variety of input by using a single method.

 This topic contains the following sections:

- [The method under test](../test/how-to-create-a-data-driven-unit-test.md#BKMK_The_method_under_test)

- [Creating a data source](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Creating_a_data_source)

- [Adding a TestContext to the test class](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Adding_a_TestContext_to_the_test_class)

- [Writing the test method](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Writing_the_test_method)

  - [Specifying the DataSourceAttribute](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Specifying_the_DataSourceAttribute)

  - [Using TestContext.DataRow to access the data](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Using_TestContext_DataRow_to_access_the_data)

- [Running the test and viewing results](../test/how-to-create-a-data-driven-unit-test.md#BKMK_Running_the_test_and_viewing_results)

  Creating a data-driven unit test involves the following steps:

1. Create a data source that contains the values that you use in the test method. The data source can be any type that is registered on the machine that runs the test.

2. Add a private <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext> field and a public `TestContext` property to the test class.

3. Create a unit test method and add a <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute> attribute to it.

4. Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow%2A> indexer property to retrieve the values that you use in a test.

## <a name="BKMK_The_method_under_test"></a> The method under test
 As an example, let's assume that we have created:

1. A solution called `MyBank` that accepts and processes transactions for different types of accounts.

2. A project in `MyBank` called `BankDb` that manages the transactions for accounts.

3. A class called `Maths` in the `DbBank` project that performs the mathematical functions to ensure that any transaction is advantageous to the bank.

4. A unit test project called `BankDbTests` to test the behavior of the `BankDb` component.

5. A unit test class called `MathsTests` to verify the behavior of the `Maths` class.

   We will test a method in `Maths` that adds two integers using a loop:

```
public int AddIntegers(int first, int second)
{
    int sum = first;
    for( int i = 0; i < second; i++)
    {
        sum += 1;
    }
    return sum;
}
```

## <a name="BKMK_Creating_a_data_source"></a> Creating a data source
 To test the `AddIntegers` method, we create a data source that specifies a range of values for the parameters and the sum that you expect to be returned. In our example, we create a Sql Compact database named `MathsData` and a table named `AddIntegersData` that contains the following column names and values

|FirstNumber|SecondNumber|Sum|
|-----------------|------------------|---------|
|0|1|1|
|1|1|2|
|2|-3|-1|

## <a name="BKMK_Adding_a_TestContext_to_the_test_class"></a> Adding a TestContext to the test class
 The unit test framework creates a `TestContext` object to store the data source information for a data-driven test. The framework then sets this object as the value of the `TestContext` property that we create.

```

private TestContext testContextInstance;
public TestContext TestContext
{
    get { return testContextInstance; }
    set { testContextInstance = value; }
}

```

 In your test method, you access the data through the `DataRow` indexer property of the `TestContext`.

## <a name="BKMK_Writing_the_test_method"></a> Writing the test method
 The test method for `AddIntegers` is fairly simple. For each row in the data source, we call `AddIntegers` with the **FirstNumber** and **SecondNumber** column values as parameters, and we verify the return value against **Sum** column value:

```

[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
[TestMethod()]
public void AddIntegers_FromDataSourceTest()
{
    var target = new Maths();

    // Access the data
    int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
    int y = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
    int expected = Convert.ToInt32(TestContext.DataRow["Sum"]);
    int actual = target.IntegerMethod(x, y);
    Assert.AreEqual(expected, actual,
        "x:<{0}> y:<{1}>",
        new object[] {x, y});

}

```

 Note that the `Assert` method includes a message that displays the `x` and `y` values of a failed iteration. By default, the asserted values, `expected` and `actual`, are already included in the details of a failed test.

### <a name="BKMK_Specifying_the_DataSourceAttribute"></a> Specifying the DataSourceAttribute
 The `DataSource` attribute specifies the connection string for the data source and the name of the table that you use in the test method. The exact information in the connection string differs, depending on what kind of data source you are using. In this example, we used a SqlServerCe database.

```
[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0;Data Source=C:\Data\MathsData.sdf", "AddIntegersData")]
```

 The DataSource attribute has three constructors.

```
[DataSource(dataSourceSettingName)]
```

 A constructor with one parameter uses connection information that is stored in the app.config file for the solution. The *dataSourceSettingsName* is the name of the Xml element in the config file that specifies the connection information.

 Using an app.config file allows you to change the location of the data source without making changes to the unit test itself. For information about how to create and use an app.config file, see [Walkthrough: Using a Configuration File to Define a Data Source](../test/walkthrough-using-a-configuration-file-to-define-a-data-source.md)

```
[DataSource(connectionString, tableName)]
```

 The `DataSource` constructor with two parameters specifies the connection string for the data source and the name of the table that contains the data for the test method.

 The connection strings depend on the type of the type of data source, but it should contain a Provider element that specifies the invariant name of the data provider.

```
[DataSource(
    dataProvider,
    connectionString,
    tableName,
    dataAccessMethod
    )]
```

### <a name="BKMK_Using_TestContext_DataRow_to_access_the_data"></a> Using TestContext.DataRow to access the data
 To access the data in the `AddIntegersData` table, use the `TestContext.DataRow` indexer. `DataRow` is a <xref:System.Data.DataRow> object, so we retrieve column values by index or column names. Because the values are returned as objects, we need to convert them to the appropriate type:

```
int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);

```

## <a name="BKMK_Running_the_test_and_viewing_results"></a> Running the test and viewing results
 When you have finished writing a test method, build the test project. The test method appears in the Test Explorer window in the **Not Run Tests** group. As you run, write, and rerun your tests, Test Explorer displays the results in groups of **Failed Tests**, **Passed Tests**, and **Not Run Tests**. You can choose **Run All** to run all your tests, or choose **Run...** to choose a subset of tests to run.

 The test results bar at the top of the Explorer is animated as your test runs. At the end of the test run, the bar will be green if all of the tests have passed or red if any of the tests have failed. A summary of the test run appears in the details pane at the bottom of the Test Explorer window. Select a test to view the details of that test in the bottom pane.

 If you ran the `AddIntegers_FromDataSourceTest` method in our example, the results bar turns red and the test method is moved to the **Failed Tests** A data-driven test fails if any of the iterated methods from the data source fails. When you choose a failed data-driven test in the Test Explorer window, the details pane displays the results of each iteration that is identified by the data row index. In our example, it appears that the `AddIntegers` algorithm does not handle negative values correctly.

 When the method under test is corrected and the test rerun, the results bar turns green and the test method is moved to the **Passed Test** group.

## See Also
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute?displayProperty=fullName>
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext?displayProperty=fullName>
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow%2A?displayProperty=fullName>
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert?displayProperty=fullName>
 [How to: Create and Run a Unit Test](https://msdn.microsoft.com/5e0f43cf-5e51-48e2-9c98-0eb9324bdc48)
 [Unit Test Your Code](../test/unit-test-your-code.md)
 [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
 [Writing Unit Tests for the .NET Framework with the Microsoft Unit Test Framework for Managed Code](../test/writing-unit-tests-for-the-dotnet-framework-with-the-microsoft-unit-test-framework-for-managed-code.md)
