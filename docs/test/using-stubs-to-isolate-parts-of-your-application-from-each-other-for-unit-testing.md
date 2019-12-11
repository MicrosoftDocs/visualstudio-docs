---
title: "Using stubs to isolate parts of your app for testing"
ms.date: 11/04/2016
ms.topic: conceptual
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
dev_langs:
 - CSharp
 - VB
---
# Use stubs to isolate parts of your application from each other for unit testing

*Stub types* are one of two technologies that the Microsoft Fakes framework provides to let you easily isolate a component you are testing from other components that it calls. A stub is a small piece of code that takes the place of another component during testing. The benefit of using a stub is that it returns consistent results, making the test easier to write. And you can run tests even if the other components are not working yet.

For an overview and quick start guide to Fakes, see [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md).

To use stubs, you have to write your component so that it uses only interfaces, not classes, to refer to other parts of the application. This is a good design practice because it makes changes in one part less likely to require changes in another. For testing, it allows you to substitute a stub for a real component.

In the diagram, the component StockAnalyzer is the one we want to test. It normally uses another component, RealStockFeed. But RealStockFeed returns different results every time its methods are called, making it difficult to test StockAnalyzer.  During testing, we replace it with a different class, StubStockFeed.

![Real and Stub classes conform to one interface.](../test/media/fakesinterfaces.png)

Because stubs rely on your being able to structure your code in this way, you typically use stubs to isolate one part of your application from another. To isolate it from other assemblies that are not under your control, such as *System.dll*, you would normally use shims. See [Use shims to isolate your application from other assemblies for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md).

## How to use stubs

### Design for dependency injection

To use stubs, your application has to be designed so that the different components are not dependent on each other, but only dependent on interface definitions. Instead of being coupled at compile time, components are connected at run time. This pattern helps to make software that is robust and easy to update, because changes tend not to propagate across component boundaries. We recommend following it even if you don't use stubs. If you are writing new code, it's easy to follow the [dependency injection](https://en.wikipedia.org/wiki/Dependency_injection) pattern. If you are writing tests for existing software, you might have to refactor it. If that would be impractical, you could consider using shims instead.

Let's start this discussion with a motivating example, the one in the diagram. The class StockAnalyzer reads share prices and generates some interesting results. It has some public methods, which we want to test. To keep things simple, let's just look at one of those methods, a very simple one that reports the current price of a particular share. We want to write a unit test of that method. Here's the first draft of a test:

```csharp
[TestMethod]
public void TestMethod1()
{
    // Arrange:
    var analyzer = new StockAnalyzer();
    // Act:
    var result = analyzer.GetContosoPrice();
    // Assert:
    Assert.AreEqual(123, result); // Why 123?
}
```

```vb
<TestMethod()> Public Sub TestMethod1()
    ' Arrange:
    Dim analyzer = New StockAnalyzer()
    ' Act:
    Dim result = analyzer.GetContosoPrice()
    ' Assert:
    Assert.AreEqual(123, result) ' Why 123?
End Sub
```

One problem with this test is immediately obvious: share prices vary, and so the assertion will usually fail.

Another problem might be that the StockFeed component, which is used by the StockAnalyzer, is still under development. Here's the first draft of the code of the method under test:

```csharp
public int GetContosoPrice()
{
    var stockFeed = new StockFeed(); // NOT RECOMMENDED
    return stockFeed.GetSharePrice("COOO");
}
```

```vb
Public Function GetContosoPrice()
    Dim stockFeed = New StockFeed() ' NOT RECOMMENDED
    Return stockFeed.GetSharePrice("COOO")
End Function
```

As it stands, this method might not compile or might throw an exception because work on the StockFeed class is not yet complete. Interface injection addresses both of these problems. Interface injection applies the following rule:

The code of any component of your application should never explicitly refer to a class in another component, either in a declaration or in a `new` statement. Instead, variables and parameters should be declared with interfaces. Component instances should be created only by the component's container.

- By "component", we mean a class, or a group of classes that you develop and update together. Typically, a component is the code in one Visual Studio project. It's less important to decouple classes within one component, because they are updated at the same time.

- It is also not so important to decouple your components from the classes of a relatively stable platform such as *System.dll*. Writing interfaces for all these classes would clutter your code.

You can decouple the StockAnalyzer code from the StockFeed by using an interface like this:

```csharp
public interface IStockFeed
{
    int GetSharePrice(string company);
}

public class StockAnalyzer
{
    private IStockFeed stockFeed;
    public StockAnalyzer(IStockFeed feed)
    {
        stockFeed = feed;
    }
    public int GetContosoPrice()
    {
        return stockFeed.GetSharePrice("COOO");
    }
}
```

```vb
Public Interface IStockFeed
    Function GetSharePrice(company As String) As Integer
End Interface

Public Class StockAnalyzer
    ' StockAnalyzer can be connected to any IStockFeed:
    Private stockFeed As IStockFeed
    Public Sub New(feed As IStockFeed)
        stockFeed = feed
    End Sub
    Public Function GetContosoPrice()
        Return stockFeed.GetSharePrice("COOO")
    End Function
End Class
```

In this example, StockAnalyzer is passed an implementation of an IStockFeed when it is constructed. In the completed application, the initialization code would perform the connection:

```csharp
analyzer = new StockAnalyzer(new StockFeed());
```

There are more flexible ways of performing this connection. For example, StockAnalyzer could accept a factory object that can instantiate different implementations of IStockFeed in different conditions.

### Generate stubs

You've decoupled the class you want to test from the other components that it uses. As well as making the application more robust and flexible, the decoupling allows you to connect the component under test to stub implementations of the interfaces for test purposes.

You could simply write the stubs as classes in the usual way. But Microsoft Fakes provides you with a more dynamic way to create the most appropriate stub for every test.

To use stubs, you must first generate stub types from the interface definitions.

#### Add a Fakes Assembly

1. In **Solution Explorer**, expand your unit test project's **References**.

   If you're working in Visual Basic, select **Show All Files** in the **Solution Explorer** toolbar in order to see the **References** node.

2. Select the assembly that contains the interface definitions for which you want to create stubs.

3. On the shortcut menu, choose **Add Fakes Assembly**.

### Write your test with stubs

```csharp
[TestClass]
class TestStockAnalyzer
{
    [TestMethod]
    public void TestContosoStockPrice()
    {
      // Arrange:

        // Create the fake stockFeed:
        IStockFeed stockFeed =
             new StockAnalysis.Fakes.StubIStockFeed() // Generated by Fakes.
                 {
                     // Define each method:
                     // Name is original name + parameter types:
                     GetSharePriceString = (company) => { return 1234; }
                 };

        // In the completed application, stockFeed would be a real one:
        var componentUnderTest = new StockAnalyzer(stockFeed);

        // Act:
        int actualValue = componentUnderTest.GetContosoPrice();

        // Assert:
        Assert.AreEqual(1234, actualValue);
    }
    ...
}
```

```vb
<TestClass()> _
Class TestStockAnalyzer

    <TestMethod()> _
    Public Sub TestContosoStockPrice()
        ' Arrange:
        ' Create the fake stockFeed:
        Dim stockFeed As New StockAnalysis.Fakes.StubIStockFeed
        With stockFeed
            .GetSharePriceString = Function(company)
                                       Return 1234
                                   End Function
        End With
        ' In the completed application, stockFeed would be a real one:
        Dim componentUnderTest As New StockAnalyzer(stockFeed)
        ' Act:
        Dim actualValue As Integer = componentUnderTest.GetContosoPrice
        ' Assert:
        Assert.AreEqual(1234, actualValue)
    End Sub
End Class
```

The special piece of magic here is the class `StubIStockFeed`. For every public type in the referenced assembly, the Microsoft Fakes mechanism generates a stub class. The name of the stub class is the derived from the name of the interface, with "`Fakes.Stub`" as a prefix, and the parameter type names appended.

Stubs are also generated for the getters and setters of properties, for events, and for generic methods.

### Verify parameter values

You can verify that when your component makes a call to another component, it passes the correct values. You can either place an assertion in the stub, or you can store the value and verify it in the main body of the test. For example:

```csharp
[TestClass]
class TestMyComponent
{
    [TestMethod]
    public void TestVariableContosoPrice()
    {
        // Arrange:
        int priceToReturn = 345;
        string companyCodeUsed = "";
        var componentUnderTest = new StockAnalyzer(new StockAnalysis.Fakes.StubIStockFeed()
            {
               GetSharePriceString = (company) =>
                  {
                     // Store the parameter value:
                     companyCodeUsed = company;
                     // Return the value prescribed by this test:
                     return priceToReturn;
                  };
            };

        // Act:
        int actualResult = componentUnderTest.GetContosoPrice();

        // Assert:
        // Verify the correct result in the usual way:
        Assert.AreEqual(priceToReturn, actualResult);

        // Verify that the component made the correct call:
        Assert.AreEqual("COOO", companyCodeUsed);
    }
...
}
```

```vb
<TestClass()> _
Class TestMyComponent
    <TestMethod()> _
    Public Sub TestVariableContosoPrice()
        ' Arrange:
        Dim priceToReturn As Integer = 345
        Dim companyCodeUsed As String = ""
        Dim stockFeed As New StockAnalysis.Fakes.StubIStockFeed()
        With stockFeed
            ' Implement the interface's method:
            .GetSharePriceString = _
                Function(company)
                    ' Store the parameter value:
                    companyCodeUsed = company
                    ' Return a fixed result:
                    Return priceToReturn
                End Function
        End With
        ' Create an object to test:
        Dim componentUnderTest As New StockAnalyzer(stockFeed)

        ' Act:
        Dim actualResult As Integer = componentUnderTest.GetContosoPrice()

        ' Assert:
        ' Verify the correct result in the usual way:
        Assert.AreEqual(priceToReturn, actualResult)
        ' Verify that the component made the correct call:
        Assert.AreEqual("COOO", companyCodeUsed)
    End Sub
...
End Class
```

## Stubs for different kinds of type members

### Methods

As described in the example, methods can be stubbed by attaching a delegate to an instance of the stub class. The name of the stub type is derived from the names of the method and parameters. For example, given the following `IMyInterface` interface and method `MyMethod`:

```csharp
// application under test
interface IMyInterface
{
    int MyMethod(string value);
}
```

We attach a stub to `MyMethod` that always returns 1:

```csharp
// unit test code
var stub = new StubIMyInterface ();
stub.MyMethodString = (value) => 1;
```

If you do not provide a stub for a function, Fakes generates a function that returns the default value of the return type. For numbers, the default value is 0 and for class types it is `null` (C#) or `Nothing` (Visual Basic).

### Properties

Property getters and setters are exposed as separate delegates and can be stubbed separately. For example, consider the `Value` property of `IMyInterface`:

```csharp
// code under test
interface IMyInterface
{
    int Value { get; set; }
}
```

We attach delegates to the getter and setter of `Value` to simulate an auto-property:

```csharp
// unit test code
int i = 5;
var stub = new StubIMyInterface();
stub.ValueGet = () => i;
stub.ValueSet = (value) => i = value;
```

If you do not provide stub methods for either the setter or the getter of a property, Fakes generates a stub that stores values so that the stub property works like a simple variable.

### Events

Events are exposed as delegate fields. As a result, any stubbed event can be raised simply by invoking the event backing field. Let's consider the following interface to stub:

```csharp
// code under test
interface IWithEvents
{
    event EventHandler Changed;
}
```

To raise the `Changed` event, we simply invoke the backing delegate:

```csharp
// unit test code
  var withEvents = new StubIWithEvents();
  // raising Changed
  withEvents.ChangedEvent(withEvents, EventArgs.Empty);
```

### Generic methods

It's possible to stub generic methods by providing a delegate for each desired instantiation of the method. For example, given the following interface containing a generic method:

```csharp
// code under test
interface IGenericMethod
{
    T GetValue<T>();
}
```

You could write a test that stubs the `GetValue<int>` instantiation:

```csharp
// unit test code
[TestMethod]
public void TestGetValue()
{
    var stub = new StubIGenericMethod();
    stub.GetValueOf1<int>(() => 5);

    IGenericMethod target = stub;
    Assert.AreEqual(5, target.GetValue<int>());
}
```

If the code were to call `GetValue<T>` with any other instantiation, the stub would simply call the behavior.

### Stubs of virtual classes

In the previous examples, the stubs have been generated from interfaces. You can also generate stubs from a class that has virtual or abstract members. For example:

```csharp
// Base class in application under test
    public abstract class MyClass
    {
        public abstract void DoAbstract(string x);
        public virtual int DoVirtual(int n)
        { return n + 42; }
        public int DoConcrete()
        { return 1; }
    }
```

In the stub generated from this class, you can set delegate methods for `DoAbstract()` and `DoVirtual()`, but not `DoConcrete()`.

```csharp
// unit test
  var stub = new Fakes.MyClass();
  stub.DoAbstractString = (x) => { Assert.IsTrue(x>0); };
  stub.DoVirtualInt32 = (n) => 10 ;
```

If you do not provide a delegate for a virtual method, Fakes can either provide the default behavior, or it can call the method in the base class. To have the base method called, set the `CallBase` property:

```csharp
// unit test code
var stub = new Fakes.MyClass();
stub.CallBase = false;
// No delegate set - default delegate:
Assert.AreEqual(0, stub.DoVirtual(1));

stub.CallBase = true;
// No delegate set - calls the base:
Assert.AreEqual(43,stub.DoVirtual(1));
```

## Debug stubs

The stub types are designed to provide a smooth debugging experience. By default, the debugger is instructed to step over any generated code, so it should step directly into the custom member implementations that were attached to the stub.

## Stub limitations

- Method signatures with pointers aren't supported.

- Sealed classes or static methods can't be stubbed because stub types rely on virtual method dispatch. For such cases, use shim types as described in [Use shims to isolate your application from other assemblies for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md)

## Change the default behavior of stubs

Each generated stub type holds an instance of the `IStubBehavior` interface (through the `IStub.InstanceBehavior` property). The behavior is called whenever a client calls a member with no attached custom delegate. If the behavior has not been set, it uses the instance returned by the `StubsBehaviors.Current` property. By default, this property returns a behavior that throws a `NotImplementedException` exception.

The behavior can be changed at any time by setting the `InstanceBehavior` property on any stub instance. For example, the following snippet changes a behavior that does nothing or returns the default value of the return type: `default(T)`:

```csharp
// unit test code
var stub = new StubIFileSystem();
// return default(T) or do nothing
stub.InstanceBehavior = StubsBehaviors.DefaultValue;
```

The behavior can also be changed globally for all stub objects for which the behavior has not been set by setting the `StubsBehaviors.Current` property:

```csharp
// Change default behavior for all stub instances
// where the behavior has not been set.
StubBehaviors.Current = BehavedBehaviors.DefaultValue;
```

## See also

- [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)