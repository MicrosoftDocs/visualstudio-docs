---
title: Create Data-Driven Unit Tests
description: Learn how to use the Microsoft unit test framework for managed code to set up a unit test method to retrieve values from a data source.
ms.date: 12/18/2024
ms.topic: how-to
f1_keywords: 
  - vs.test.testresults.unittest.datadriven
  - vs.test.testresults.unittest.datadriven.failure
helpviewer_keywords: 
  - unit tests, running
  - unit tests, data-driven
  - data-driven unit tests
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Create a data-driven unit test

You can use the Microsoft unit test framework (MSTest) for managed code to set up a unit test method to retrieve values from a data source. The method is run successively for each row in the data source, which makes it easy to test a variety of input by using a single method.

A data-driven unit test can use any of the following kind:

- inline data using the `DataRow` attribute
- member data using the `DynamicData` attribute
- from some well-known source provider using the `DataSource` attribute

## The method under test

As an example, let's assume that you have:

1. A solution called `MyBank` that accepts and processes transactions for different types of accounts.

2. A project in `MyBank` called `BankDb` that manages the transactions for accounts.

3. A class called `Maths` in the `BankDb` project that performs the mathematical functions to ensure that any transaction is advantageous to the bank.

4. A unit test project called `BankDbTests` to test the behavior of the `BankDb` component.

5. A unit test class called `MathsTests` to verify the behavior of the `Maths` class.

We'll test a method in `Maths` that adds two integers using a loop:

```csharp
public int AddIntegers(int first, int second)
{
    int sum = first;
    for (int i = 0; i < second; i++)
    {
        sum += 1;
    }

    return sum;
}
```

## Test test method

### Inline data-driven test

For inline tests, MSTest uses `DataRow` to specify values used by the data-driven test. The test in this example runs successively for each data row.

```csharp
[TestMethod]
[DataRow(1, 1, 2)]
[DataRow(2, 2, 4)]
[DataRow(3, 3, 6)]
[DataRow(0, 0, 1)] // The test run with this row fails
public void AddIntegers_FromDataRowTest(int x, int y, int expected)
{
    var target = new Maths();
    int actual = target.AddIntegers(x, y);
    Assert.AreEqual(expected, actual,
        "x:<{0}> y:<{1}>",
        new object[] {x, y});
}
```

### Member data-driven test

MSTest uses `DynamicData` attribute to specify the name, kind, and defining type (by default current type is used) of the member that will provide the data used by the data-driven test.

> [!NOTE]
> Before MSTest 3.8, `DynamicDataSourceType` enumeration had two members, `Property` and `Method`. The default was `Property`. Starting with MSTest 3.8, a new member `AutoDetect` is added to the enumeration and is the default. So, you no longer need to specify `DynamicDataSourceType`.

```csharp
public static IEnumerable<object[]> AdditionData
{
    get
    {
        return new[]
        { 
            new object[] { 1, 1, 2 },
            new object[] { 2, 2, 4 },
            new object[] { 3, 3, 6 },
            new object[] { 0, 0, 1 }, // The test run with this row fails
        };
    }
}

[TestMethod]
[DynamicData(nameof(AdditionData))]
public void AddIntegers_FromDynamicDataTest(int x, int y, int expected)
{
    var target = new Maths();
    int actual = target.AddIntegers(x, y);
    Assert.AreEqual(expected, actual,
        "x:<{0}> y:<{1}>",
        new object[] {x, y});
}
```

It is also possible to override the default generated display name, using the `DynamicDataDisplayName` property of the `DynamicData` attribute. The display name method signature must be `public static string` and accept two parameters, the first of type `MethodInfo` and the second of type `object[]`.

```csharp
public static string GetCustomDynamicDataDisplayName(MethodInfo methodInfo, object[] data)
{
    return string.Format("DynamicDataTestMethod {0} with {1} parameters", methodInfo.Name, data.Length);
}

[DynamicData(nameof(AdditionData), DynamicDataDisplayName = nameof(GetCustomDynamicDataDisplayName))]
```

### Source provider data-driven test

Creating a data source driven unit test involves the following steps:

1. Create a data source that contains the values that you use in the test method. The data source can be any type that is registered on the machine that runs the test.

2. Add a public `TestContext` property of type <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext> to the test class.

3. Create a unit test method

4. Add a <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute> attribute to it.

5. Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow%2A> indexer property to retrieve the values that you use in a test.

#### Create a data source

To test the `AddIntegers` method, create a data source that specifies a range of values for the parameters and the sum that you expect to be returned. In this example, we'll create a Sql Compact database named `MathsData` and a table named `AddIntegersData` that contains the following column names and values

|FirstNumber|SecondNumber|Sum|
|-|------------------|-|
|0|1|1|
|1|1|2|
|2|-3|-1|

#### Add a TestContext to the test class

The unit test framework creates a `TestContext` object to store the data source information for a data-driven test. The framework then sets this object as the value of the `TestContext` property that you create.

```csharp
public TestContext TestContext { get; set; }
```

In your test method, you access the data through the `DataRow` indexer property of the `TestContext`.

> [!NOTE]
> .NET Core does not support the [DataSource](xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute) attribute. If you try to access test data in this way in a .NET Core, UWP or WinUI unit test project, you will see an error similar to **"'TestContext' does not contain a definition for 'DataRow' and no accessible extension method 'DataRow' accepting a first argument of type 'TestContext' could be found (are you missing a using directive or an assembly reference?)"**.

#### Write the test method

The test method for `AddIntegers` is fairly simple. For each row in the data source, call `AddIntegers` with the **FirstNumber** and **SecondNumber** column values as parameters, and verify the return value against **Sum** column value:

```csharp
[TestMethod]
[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
public void AddIntegers_FromDataSourceTest()
{
    var target = new Maths();

    // Access the data
    int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
    int y = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
    int expected = Convert.ToInt32(TestContext.DataRow["Sum"]);
    int actual = target.AddIntegers(x, y);
    Assert.AreEqual(expected, actual,
        "x:<{0}> y:<{1}>",
        new object[] {x, y});
}
```

#### Specify the DataSourceAttribute

The `DataSource` attribute specifies the connection string for the data source and the name of the table that you use in the test method. The exact information in the connection string differs, depending on what kind of data source you are using. In this example, we used a SqlServerCe database.

```csharp
[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0;Data Source=C:\Data\MathsData.sdf", "AddIntegersData")]
```

> [!CAUTION]
> The connection string can contain sensitive data (for example, a password). The connection string is stored in plain text in source code and in the compiled assembly. Restrict access to the source code and assembly to protect this sensitive information.

The DataSource attribute has three constructors.

```csharp
[DataSource(dataSourceSettingName)]
```

A constructor with one parameter uses connection information that is stored in the *app.config* file for the solution. The *dataSourceSettingsName* is the name of the Xml element in the config file that specifies the connection information.

Using an *app.config* file allows you to change the location of the data source without making changes to the unit test itself. For information about how to create and use an *app.config* file, see [Walkthrough: Using a Configuration File to Define a Data Source](../test/walkthrough-using-a-configuration-file-to-define-a-data-source.md)

```csharp
[DataSource(connectionString, tableName)]
```

The `DataSource` constructor with two parameters specifies the connection string for the data source and the name of the table that contains the data for the test method.

The connection strings depend on the type of the type of data source, but it should contain a Provider element that specifies the invariant name of the data provider.

```csharp
[DataSource(
    dataProvider,
    connectionString,
    tableName,
    dataAccessMethod
    )]
```

#### Use TestContext.DataRow to access the data

To access the data in the `AddIntegersData` table, use the `TestContext.DataRow` indexer. `DataRow` is a <xref:System.Data.DataRow> object, so retrieve column values by index or column names. Because the values are returned as objects, convert them to the appropriate type:

```csharp
int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
```

## Run the test and view results

When you've finished writing a test method, build the test project. The test method appears in **Test Explorer** in the **Not Run Tests** group. As you run, write, and rerun your tests, **Test Explorer** displays the results in groups of **Failed Tests**, **Passed Tests**, and **Not Run Tests**. You can choose **Run All** to run all your tests, or choose **Run** to choose a subset of tests to run.

The test results bar at the top of **Test Explorer** is animated as your test runs. At the end of the test run, the bar will be green if all of the tests have passed or red if any of the tests have failed. A summary of the test run appears in the details pane at the bottom of the **Test Explorer** window. Select a test to view the details of that test in the bottom pane.

> [!NOTE]
> There's a result for each row of data and also one summary result. If the test passed on each row of data, the summary run shows as **Passed**. If the test failed on any data row, the summary run shows as **Failed**.

If you ran any of the `AddIntegers_FromDataRowTest`, `AddIntegers_FromDynamicDataTest` or `AddIntegers_FromDataSourceTest` method in our example, the results bar turns red and the test method is moved to the **Failed Tests**. A data-driven test fails if any of the iterated methods from the data source fails. When you choose a failed data-driven test in the **Test Explorer** window, the details pane displays the results of each iteration that is identified by the data row index. In our example, it appears that the `AddIntegers` algorithm does not handle negative values correctly.

When the method under test is corrected and the test rerun, the results bar turns green and the test method is moved to the **Passed Test** group.

## Related content

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute?displayProperty=fullName>
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext?displayProperty=fullName>
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow%2A?displayProperty=fullName>
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert?displayProperty=fullName>
- [Unit test your code](../test/unit-test-your-code.md)
- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
- [Write unit tests for .NET with the Microsoft unit test framework](../test/unit-test-your-code.md)
