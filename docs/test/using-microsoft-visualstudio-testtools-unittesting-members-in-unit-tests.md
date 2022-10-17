---
title: Use MSTest in unit tests
description: Learn about the MSTest framework, which supports unit testing in Visual Studio. Use these classes and members to code unit tests.
ms.custom: SEO-VS-2020
ms.date: 10/17/2022
ms.topic: reference
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
- multiple
author: mikejo5000
---
# Use the MSTest framework in unit tests

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The [MSTest](https://github.com/microsoft/testfx) framework supports unit testing in Visual Studio. Use the classes and members in the <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace when you are coding unit tests. You can also use them when you are refining a unit test that was generated from code.

## Framework members

To help provide a clearer overview of the unit testing framework, this section organizes the members of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace into groups of related functionality.

> [!NOTE]
> Attribute elements, whose names end with "Attribute", can be used either with or without "Attribute" on the end and for parameterless constructors with or without parenthesis. For example, the following code examples function identically:
>
> `[TestClass()]`
>
> `[TestClassAttribute()]`
>
> `[TestClass]`
>
> `[TestClassAttribute]`

### Attributes used to identify test classes and methods

Every test class must have the `TestClass` attribute, and every test method must have the `TestMethod` attribute. For more information, see [Anatomy of a unit test](/previous-versions/ms182517(v=vs.110)).

#### TestClassAttribute

The [TestClass](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute>) attribute marks a class that contains tests and, optionally, initialize or cleanup methods.

This attribute can be extended to update or extend the behavior.

Example:

```csharp
[TestClass]
public class MyTestClass
{    
}
```

#### TestMethodAttribute

The [TestMethod](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute>) attribute is used inside a `TestClass` to define the actual test method to run.

The method should be an instance method defined as `public void` or `public Task` (optionally `async`) and be parameterless.

**Example**

```csharp
[TestClass]
public class MyTestClass
{
    [TestMethod]
    public void TestMethod()
    {
    }
}
```

```csharp
[TestClass]
public class MyTestClass
{
    [TestMethod]
    public async Task TestMethod()
    {
    }
}
```

### Attributes used for data-driven testing

Use the following elements to set up data-driven unit tests. For more information, see [Create a data-driven unit test](../test/how-to-create-a-data-driven-unit-test.md) and [Use a configuration file to define a data source](../test/walkthrough-using-a-configuration-file-to-define-a-data-source.md).

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataTestMethodAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataRowAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DynamicDataAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute>

### Attributes used to provide initialization and cleanups

A method decorated with one of the following attributes is called at the moment you specify. For more information, see [Anatomy of a unit test](/previous-versions/ms182517(v=vs.110)).

#### Assembly

[AssemblyInitialize](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyInitializeAttribute>) is called right after your assembly is loaded and [AssemblyCleanup](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyCleanupAttribute>) is called right before your assembly is unloaded.

The methods marked with these attributes should be defined as `static void` or `static Task`, in a `TestClass`, and appear only once. The initialize part requires one argument of type [TestContext](xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext) and the cleanup no argument.

```csharp
[TestClass]
public class MyTestClass
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext testContext)
    {
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
    }
}
```

```csharp
[TestClass]
public class MyOtherTestClass
{
    [AssemblyInitialize]
    public static async Task AssemblyInitialize(TestContext testContext)
    {
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
    }
}
```

#### Class

[ClassInitialize](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute>) is called right before your class is loaded (but after static constructor) and [ClassCleanup](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute>) is called right after your class is unloaded.

It is possible to control the inheritance behavior: only for current class using `InheritanceBehavior.None` or for all derived classes using `InheritanceBehavior.BeforeEachDerivedClass`.

It is also possible to configure whether the class cleanup should be run at the end of the class or at the end of the assembly (current default).

The methods marked with these attributes should be defined as `static void` or `static Task`, in a `TestClass`, and appear only once. The initialize part requires one argument of type [TestContext](xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext) and the cleanup no argument.

```csharp
[TestClass]
public class MyTestClass
{
    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
    }
}
```

```csharp
[TestClass]
public class MyOtherTestClass
{
    [ClassInitialize]
    public static async Task ClassInitialize(TestContext testContext)
    {
    }

    [ClassCleanup]
    public static async Task ClassCleanup()
    {
    }
}
```

#### Test

[TestInitialize](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute>) is called right before your test is started and [TestCleanup](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute>) is called right after your test is finished.

The `TestInitialize` is similar to the class constructor but is usually better fitted for long or async initializations. Note that the `TestInitialize` is always called after the constructor and called for each test (including each data row of data-driven tests).

The `TestCleanup` is similar to the class `Dispose` (or `DisposeAsync`) but is usually better fitted for long or async cleanups. Note that the `TestCleanup` is always called just before the `DisposeAsync`/`Dispose` and called for each test (including each data row of data-driven tests).

The methods marked with these attributes should be defined as `void` or `Task`, in a `TestClass`, be parameterless, and appear one or multiple times.

```csharp
[TestClass]
public class MyTestClass
{
    [TestInitialize]
    public void TestInitialize()
    {
    }

    [TestCleanup]
    public void TestCleanup()
    {
    }
}
```

```csharp
[TestClass]
public class MyOtherTestClass
{
    [TestInitialize]
    public async Task TestInitialize()
    {
    }

    [TestCleanup]
    public async Task TestCleanup()
    {
    }
}
```

## Assertions and related exceptions

Unit tests can verify specific application behavior by their use of various kinds of assertions, exceptions, and attributes. For more information, see [Using the assert classes](../test/using-the-assert-classes.md).

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException%2A?displayProperty=nameWithType>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException>

## The TestContext class

The following attributes and the values assigned to them appear in the Visual Studio Properties window for a particular test method. These attributes are not meant to be accessed through the code of the unit test. Instead, they affect the ways the unit test is used or run, either by you through the IDE of Visual Studio, or by the Visual Studio test engine. For example, some of these attributes appear as columns in the **Test Manager** window and **Test Results** window, which means that you can use them to group and sort tests and test results. One such attribute is <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute>, which you use to add arbitrary metadata to unit tests. For example, you could use it to store the name of a test pass that this test covers, by marking the unit test with `[TestProperty("TestPass", "Accessibility")]`. Or, you could use it to store an indicator of the kind of test it is with `[TestProperty("TestKind", "Localization")]`. The property you create by using this attribute, and the property value you assign, are both displayed in the Visual Studio **Properties** window under the heading **Test specific**.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.OwnerAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PriorityAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.WorkItemAttribute>

## Test configuration classes

- [ObjectTypes](/previous-versions/visualstudio/visual-studio-2013/dd987428(v=vs.120))

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestConfigurationSection>

## Attributes used to generate reports

The attributes in this section relate the test method that they decorate to entities in the project hierarchy of a Team Foundation Server team project.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CssIterationAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CssProjectStructureAttribute>

## Classes used with private accessors

You can generate a unit test for a private method. This generation creates a private accessor class, which instantiates an object of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject> class. The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject> class is a wrapper class that uses reflection as part of the private accessor process. The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType> class is similar, but is used for calling private static methods instead of calling private instance methods.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType>

## See also

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting> reference documentation