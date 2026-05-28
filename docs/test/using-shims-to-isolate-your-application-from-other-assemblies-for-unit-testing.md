---
title: Isolate Your App with Shims (Unit Testing)
description: Learn how to use shim types to divert calls to specific methods in code that you write as part of your test. A shim can return consistent results at every call.
ms.date: 05/29/2026
ms.topic: how-to
ms.author: mikejo
ms.manager:  aajohn
ms.subservice: test-tools
author: mikejo5000
dev_langs: 
  - CSharp
  - VB

monikerRange: '>=vs-2022'
# customer intent: As a developer, I want to use shim types for unit testing, so I can divert calls to specific methods in my unit test code. 
---
# Use shims to isolate your app for unit testing

**Shim types**, one of the two key technologies utilized by the Microsoft Fakes Framework, are instrumental in isolating the components of your app during testing. They work by intercepting and diverting calls to specific methods, which you can then direct to custom code within your test. This feature enables you to manage the outcome of these methods so you can ensure the results are consistent and predictable during each call, regardless of external conditions. This level of control streamlines the testing process and aids in achieving more reliable and accurate results.

Employ **shims** when you need to create a boundary between your code and assemblies that don't form part of your solution. When the aim is to isolate components of your solution from each other, the use of **stubs** is recommended. For a detailed description about stubs, see [Use stubs to isolate parts of your application from each other for unit testing](../test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing.md).

This article provides a step-by-step guide for using shim types to divert calls to specific methods in your unit test code.

## Understand type limitations with shims

There are some limitations when working with shims. They can't be used on all types from certain libraries in the .NET base class, specifically:

- **mscorlib** and **System** in the .NET Framework
- **System.Runtime** in .NET Core or .NET 5+

When you design your testing strategy, plan for this constraint to ensure successful and effective unit testing.

## Create a shim

Suppose your component contains calls to the `System.IO.File.ReadAllLines` method:

```csharp
// Code under test:
this.Records = System.IO.File.ReadAllLines(path);
```

To prepare the component for unit testing, complete the steps in the following procedures.

### Create a class library

Create a new solution and initial project for the class library.

1. In the Visual Studio **Start Window** (**File** > **Start Window**), create a `Class Library` project by selecting the template for C# or Visual Basic.

   ::: moniker range="visualstudio"

   :::image type="content" source="../test/media/visualstudio/microsoft-fakes-shims-create-class-library-project.png" border="false" alt-text="Screenshot of the Class Library project template for .NET Framework and C# in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../test/media/microsoft-fakes-shims-create-class-library-project.png" border="false" alt-text="Screenshot of the Class Library project template for .NET Framework and C# in Visual Studio 2022.":::

   ::: moniker-end

1. Configure the new project:

   - Set the class library **Project name** to `HexFileReader`.
   - Set the **Solution name** to `ShimsTutorial`.
   - Set the **Target framework** to **.NET Framework 4.8**.
   
   Select **Create**.

1. After the project opens, locate the default file `Class1.cs` in **Solution Explorer**, and delete the file.

1. Add a file named `HexFile.cs` and enter the following class definition:

   #### [C#](#tab/csharp)

   ```csharp
   // HexFile.cs
   public class HexFile
   {
       public string[] Records { get; private set; }

       public HexFile(string path)
       {
           this.Records = System.IO.File.ReadAllLines(path);
       }
   }
   ```
   
   #### [VB](#tab/vb)

   ```vb
   ' HexFile.vb
   Public Class HexFile
       Public Property Records As String()

       Public Sub New(ByVal path As String)
           Me.Records = System.IO.File.ReadAllLines(path)
       End Sub
   End Class
   ```

   ---

### Add a unit test project

Add another project to your solution for the unit tests.

1. In **Solution Explorer**, right-click the `ShimsTutorial` solution, and select **Add** > **New Project**.

1. In the **Start Window**, create a `Unit Test Project` project by selecting the template. 

   ::: moniker range="visualstudio"

   :::image type="content" source="../test/media/visualstudio/microsoft-fakes-shims-create-test-project.png" border="false" alt-text="Screenshot of the Microsoft Unit Test project template for .NET Framework and C# in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../test/media/microsoft-fakes-shims-create-test-project.png" border="false" alt-text="Screenshot of the Microsoft Unit Test project template for .NET Framework and C# in Visual Studio 2022.":::

   ::: moniker-end

1. Configure the new project:

   - Set the unit test **Project name** to `TestProject`.
   - Set the **Target framework** to **.NET Framework 4.8**.
   
   Select **Create**.

### Add Fakes Assembly

Add a reference to the `HexFileReader` project.

1. In **Solution Explorer**, expand the `TestProject` node, right-click the **References** node, and select **Add Reference**.

   ::: moniker range="visualstudio"

   :::image type="content" source="../test/media/visualstudio/microsoft-fakes-shims-add-project-reference.png" border="false" alt-text="Screenshot of the Microsoft Unit Test project template for .NET Framework and C# in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../test/media/microsoft-fakes-shims-add-project-reference.png" border="false" alt-text="Screenshot that shows how to add a reference from the unit test project to the class in Visual Studio 2022.":::

   ::: moniker-end

   1. In the left pane of the **Reference Manager** window, select the **Projects** section.

   1. In the middle pane, select the checkbox for the `HexFileReader` project, and select **OK**.

1. Add the Fakes Assembly.

   1. In **Solution Explorer**, locate the containing node for the assembly:

       - For an older .NET Framework Project (non-SDK style), expand the unit test project node, and then expand the **References** node.

       - For an SDK-style project targeting .NET Framework, .NET Core, or .NET 5+, expand the **Dependencies** node to locate the assembly to fake under **Assemblies**, **Projects**, or **Packages**.

       - For Visual Basic, select **Show All Files** in the **Solution Explorer** toolbar to see the **References** node.
       
   1. Select the `System` assembly that contains the definition of `System.IO.File.ReadAllLines`.

   1. Right-click the `System` node and select **Add Fakes Assembly**.

      ::: moniker range="visualstudio"

      :::image type="content" source="../test/media/visualstudio/microsoft-fakes-shims-add-fakes-assembly.png" border="false" alt-text="Screenshot that shows how to add the Fakes assembly for the project in Visual Studio.":::

      ::: moniker-end
      ::: moniker range="<=vs-2022"

      :::image type="content" source="../test/media/microsoft-fakes-shims-add-fakes-assembly.png" border="false" alt-text="Screenshot that shows how to add the Fakes assembly for the project in Visual Studio 2022.":::

      ::: moniker-end

   The build process produces warnings and errors for types not supported for use with shims.

   When the build completes, **Solution Explorer** refreshes to show a **Fakes** node for the unit test project.
   
1. Select the `Fakes\mscorlib.fakes` file and replace the XML to exclude the unsupported types:

   ```xml
   <Fakes xmlns="http://schemas.microsoft.com/fakes/2011/" Diagnostic="true">
   <Assembly Name="mscorlib" Version="4.0.0.0"/>
   <StubGeneration>
        <Clear/>
   </StubGeneration>
   <ShimGeneration>
        <Clear/>
        <Add FullName="System.IO.File"/>
        <Remove FullName="System.IO.FileStreamAsyncResult"/>
        <Remove FullName="System.IO.FileSystemEnumerableFactory"/>
        <Remove FullName="System.IO.FileInfoResultHandler"/>
        <Remove FullName="System.IO.FileSystemInfoResultHandler"/>
        <Remove FullName="System.IO.FileStream+FileStreamReadWriteTask"/>
        <Remove FullName="System.IO.FileSystemEnumerableIterator"/>
   </ShimGeneration>
   </Fakes>
   ```

### Create a unit test

Add a unit test for your project.

1. Update the default `TestProject\UnitTest1.cs` file provided by the project template.

   #### [C#](#tab/csharp)

   Locate the following section of code in the file and replace it with the provided snippet:

   ```csharp
   [TestMethod]
   public void TestMethod1()
   {
   }
   ```

   Replacement snippet:

   ```csharp
   [TestMethod]
   public void TestFileReadAllLine()
   {
      using (ShimsContext.Create())
      {
         // Arrange
         System.IO.Fakes.ShimFile.ReadAllLinesString = (s) => new string[] { "Hello", "World", "Shims" };

         // Act
         var target = new HexFile("this_file_doesnt_exist.txt");

         Assert.AreEqual(3, target.Records.Length);
      }
   }
   ```

   #### [VB](#tab/vb)

   Locate the following section of code in the file and replace it with the provided snippet:

   ```vb
   <TestMethod>
   Public Sub TestFileReadAllLine()
   End Sub
   ```

   Replacement snippet:

   ```vb
   <TestMethod>
   Public Sub TestFileReadAllLine()
      Using ShimsContext.Create()
         ' Arrange
         System.IO.Fakes.ShimFile.ReadAllLinesString = Function(s) New String() {"Hello", "World", "Shims"}

         ' Act
         Dim target = New HexFile("this_file_doesnt_exist.txt")

         Assert.AreEqual(3, target.Records.Length)
      End Using
   End Sub
   ```

   ---

1. To see all the Fakes assemblies for the unit test, select **Show All Files** in the **Solution Explorer** menubar:
   
   ::: moniker range="visualstudio"

   :::image type="content" source="../test/media/visualstudio/microsoft-fakes-shims-all-files-small.png" border="false" alt-text="Screenshot of Solution Explorer in Visual Studio showing all files, which includes the Fakes assemblies." lightbox="../test/media/visualstudio/microsoft-fakes-shims-all-files.png" :::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../test/media/microsoft-fakes-shims-all-files.png" border="false" alt-text="Screenshot of Solution Explorer in Visual Studio 2022 showing all files, which includes the Fakes assemblies.":::

   ::: moniker-end

1. Open **Test Explorer** and run the test.

It's critical to properly dispose each shim context. As a rule of thumb, call the `ShimsContext.Create` method inside of a `using` statement to ensure proper clearing of the registered shims. For example, you might register a shim for a test method that replaces the `DateTime.Now` method with a delegate that always returns January 1, 2000. If you forget to clear the registered shim in the test method, the remainder of the test run always returns January 1, 2000 as the `DateTime.Now` value. This result might be surprising and confusing.

## Review naming conventions for shim classes

Shim class names use the `Fakes.Shim` prefix followed by the original type name. Parameter names are appended to the method name. (You don't have to add any assembly reference to `System.Fakes`.)

```csharp
System.IO.File.ReadAllLines(path);

System.IO.Fakes.ShimFile.ReadAllLinesString = (path) => new string[] { "Hello", "World", "Shims" };
```

## Understand how shims work

Shims operate by introducing *detours* into the codebase of the application being tested. Whenever there's a call to the original method, the Fakes system intervenes to redirect the call, causing your custom shim code to execute instead of the original method.

It's important to note that these detours are created and removed dynamically at runtime. Detours should always be created within the lifespan of a `ShimsContext`. When the ShimsContext is disposed, any active shims created within it are also removed. To manage this design efficiently, the recommendation is to encapsulate the creation of detours within a `using` statement.

## Explore shims for different kinds of methods

Shims support various types of methods.

### Static methods

When you shim static methods, properties that hold shims are housed within a shim type. These properties only possess a setter, which is used to attach a delegate to the targeted method.

For instance, for a class called `MyClass` with a static method `MyMethod`:

```csharp
//Code under test
public static class MyClass {
    public static int MyMethod() {
        ...
    }
}
```

You can attach a shim to `MyMethod` such that it constantly returns 5:

```csharp
// Unit test code
ShimMyClass.MyMethod = () => 5;
```

### Instance methods (for all instances)

Just like static methods, instance methods can also be shimmed for all instances. The properties that hold these shims are placed in a nested type named `AllInstances` to prevent confusion.

For the class `MyClass` with an instance method `MyMethod`:

```csharp
// Code under test
public class MyClass {
    public int MyMethod() {
        ...
    }
}
```

You can attach a shim to `MyMethod` so it consistently returns 5, regardless of the instance:

```csharp
// Unit test code
ShimMyClass.AllInstances.MyMethod = () => 5;
```

The following snippet shows the generated type structure of `ShimMyClass`:

```csharp
// Fakes generated code
public class ShimMyClass : ShimBase<MyClass> {
   public static class AllInstances {
      public static Func<MyClass, int>MyMethod {
         set {
            ...
         }
      }
   }
}
```

In this scenario, Fakes passes the runtime instance as the first argument of the delegate.

### Instance methods (single runtime instance)

Instance methods can also be shimmed by using different delegates, depending on the call's receiver. This approach allows the same instance method to exhibit different behaviors for each instance of the type. The properties that hold these shims are instance methods of the shim type itself. Each instantiated shim type is linked to a raw instance of a shimmed type.

For example, given a class `MyClass` with an instance method `MyMethod`:

```csharp
// Code under test
public class MyClass {
   public int MyMethod() {
      ...
   }
}
```

You can create two shim types for `MyMethod` such that the first consistently returns 5 and the second consistently returns 10:

```csharp
// Unit test code
var myClass1 = new ShimMyClass()
{
   MyMethod = () => 5
};
var myClass2 = new ShimMyClass { MyMethod = () => 10 };
```

The following snippet shows the generated type structure of `ShimMyClass`:

```csharp
// Fakes generated code
public class ShimMyClass : ShimBase<MyClass> {
   public Func<int> MyMethod {
      set {
         ...
      }
   }
   public MyClass Instance {
      get {
         ...
      }
   }
}
```

The actual shimmed type instance can be accessed through the `Instance` property:

```csharp
// Unit test code
var shim = new ShimMyClass();
var instance = shim.Instance;
```

The shim type also includes an implicit conversion to the shimmed type, which allows you to use the shim type directly:

```csharp
// Unit test code
var shim = new ShimMyClass();
MyClass instance = shim; // Implicit cast retrieves the runtime instance
```

## Explore shim constructors

Constructors are no exception to shimming. They can be shimmed to attach shim types to objects that are created in the future. For instance, every constructor is represented as a static method named `Constructor` within the shim type. 

Consider a class `MyClass` with a constructor that accepts an integer:

```csharp
public class MyClass {
   public MyClass(int value) {
      this.Value = value;
   }
   ...
}
```

A shim type for this constructor can be set up such that, irrespective of the value passed to the constructor, every future instance returns -5 when the `Value` getter is invoked:

```csharp
// Unit test code
ShimMyClass.ConstructorInt32 = (@this, value) => {
   var shim = new ShimMyClass(@this) {
      ValueGet = () => -5
   };
};
```

Each shim type exposes two types of constructors:

- When you need a new instance, use the default constructor.
- When you have a constructor shim, use the constructor that takes a shimmed instance as an argument.

```csharp
// Unit test code
public ShimMyClass() { }
public ShimMyClass(MyClass instance) : base(instance) { }
```

The following code illustrates the generated type for the `ShimMyClass`:

```csharp
// Fakes generated code
public class ShimMyClass : ShimBase<MyClass>
{
   public static Action<MyClass, int> ConstructorInt32 {
      set {
         ...
      }
   }

   public ShimMyClass() { }
   public ShimMyClass(MyClass instance) : base(instance) { }
   ...
}
```

### Access base members

You can reach the shim properties of base members by creating a shim for the base type. Then, input the child instance into the constructor of the base shim class.

For example, consider a class `MyBase` with an instance method `MyMethod` and a subtype `MyChild`:

```csharp
public abstract class MyBase {
   public int MyMethod() {
       ...
   }
}

public class MyChild : MyBase {
}
```

A shim of `MyBase` can be set up by initiating a new `ShimMyBase` shim:

```csharp
// unit test code
var child = new ShimMyChild();
new ShimMyBase(child) { MyMethod = () => 5 };
```

It's important to note that when you pass the child shim as a parameter to the base shim constructor, the child shim type is implicitly converted to the child instance.

The structure of the generated type for `ShimMyChild` and `ShimMyBase` is similar to the following code:

```csharp
// Fakes generated code
public class ShimMyChild : ShimBase<MyChild> {
   public ShimMyChild() { }
   public ShimMyChild(Child child)
       : base(child) { }
}
public class ShimMyBase : ShimBase<MyBase> {
   public ShimMyBase(Base target) { }
   public Func<int> MyMethod
   { set { ... } }
}
```

### Static constructors

Shim types expose a static method `StaticConstructor` to shim the static constructor of a type. Because static constructors are executed one time only, you need to make sure the shim is configured before any member of the type is accessed.

### Finalizers

Finalizers aren't supported in Fakes.

### Private methods

The Fakes code generator creates shim properties for private methods that only have visible types in the signature, that is, parameter types and return type visible.

### Binding interfaces

When a shimmed type implements an interface, the code generator emits a method that allows it to bind all the members from that interface at once.

For example, given a class `MyClass` that implements `IEnumerable<int>`:

```csharp
public class MyClass : IEnumerable<int> {
   public IEnumerator<int> GetEnumerator() {
       ...
   }
   ...
}
```

You can shim the implementations of `IEnumerable<int>` in `MyClass` by calling the `Bind` method:

```csharp
// Unit test code
var shimMyClass = new ShimMyClass();
shimMyClass.Bind(new List<int> { 1, 2, 3 });
```

The generated type structure of `ShimMyClass` resembles the following code:

```csharp
// Fakes generated code
public class ShimMyClass : ShimBase<MyClass> {
   public ShimMyClass Bind(IEnumerable<int> target) {
       ...
   }
}
```

## Change default behavior

Each generated shim type includes an instance of the `IShimBehavior` interface, accessible via the `ShimBase<T>.InstanceBehavior` property. This behavior is invoked whenever a client calls an instance member that isn't explicitly shimmed.

By default, if no specific behavior is set, the design uses the instance returned by the static `ShimBehaviors.Current` property, which typically throws a `NotImplementedException` exception.

You can modify this behavior at any time by adjusting the `InstanceBehavior` property for any shim instance.

For example, you can alter the behavior to either do nothing or return the default value of the return type, `default(T)`:

```csharp
// Unit test code
var shim = new ShimMyClass();

//Return default(T) or do nothing
shim.InstanceBehavior = ShimBehaviors.DefaultValue;
```
You can also globally change the behavior for all shimmed instances, where the `InstanceBehavior` property isn't explicitly defined, by setting the static `ShimBehaviors.Current` property:

```csharp
// Unit test code
// Change default shim for all shim instances where the behavior isn't set
ShimBehaviors.Current = ShimBehaviors.DefaultValue;
```

## Identify interactions with external dependencies

To help identify when your code is interacting with external systems or dependencies (referred to as the `environment`), you can utilize shims to assign a specific behavior to all members of a type (including static methods). By setting the `ShimBehaviors.NotImplemented` behavior on the static `Behavior` property of the shim type, any access to a member of that type that isn't explicitly shimmed throws a `NotImplementedException`. This result can serve as a useful signal during testing, indicating that your code is attempting to access an external system or dependency.

Here's an example of how to set up this form of shim in your unit test code:

```csharp
// Unit test code
// Assign the NotImplementedException behavior to ShimMyClass
ShimMyClass.Behavior = ShimBehaviors.NotImplemented;
```

For convenience, a shorthand method is also provided to achieve the same effect:

```csharp
// Shorthand to assign the NotImplementedException behavior to ShimMyClass
ShimMyClass.BehaveAsNotImplemented();
```

## Invoke original methods from within shim methods

In some scenarios, you might need to execute the original method during execution of the shim method. For instance, you might want to write text to the file system after validating the file name passed to the method.

One approach to handle this situation is to encapsulate a call to the original method by using a delegate and the `ShimsContext.ExecuteWithoutShims()` method:

```csharp
// Unit test code
ShimFile.WriteAllTextStringString = (fileName, content) => {
  ShimsContext.ExecuteWithoutShims(() => {

     Console.WriteLine("enter");
     File.WriteAllText(fileName, content);
     Console.WriteLine("leave");
  });
};
```

Alternatively, you can nullify the shim, call the original method, and then restore the shim:

```csharp
// Unit test code
ShimsDelegates.Action<string, string> shim = null;

shim = (fileName, content) => {
   try {
      Console.WriteLine("enter");
      // Remove shim in order to call original method
      ShimFile.WriteAllTextStringString = null;
      File.WriteAllText(fileName, content);
   }
   finally
   {
      // Restore shim
      ShimFile.WriteAllTextStringString = shim;
      Console.WriteLine("leave");
   }
};

// Initialize the shim
ShimFile.WriteAllTextStringString = shim;
```

## Handle concurrency with shim types

Shim types operate across all threads within the AppDomain and don't possess thread affinity. This characteristic is crucial to keep in mind if you plan to utilize a test runner that supports concurrency. It's worth noting that tests that involve shim types can't run concurrently, although the Fakes runtime doesn't enforce this restriction.

## Use shims with System.Environment

To shim the <xref:System.Environment?displayProperty=fullName> class, you need to modify the `mscorlib.fakes` file.

Locate the `\<Assembly>` element, and add the following content after the element definition:

```xml
<ShimGeneration>
   <Add FullName="System.Environment"/>
</ShimGeneration>
```

After you make changes and rebuild the solution, the methods and properties in the `System.Environment` class are now available for shimming.

Here's an example of how you can assign a behavior to the `GetCommandLineArgsGet` method:

```csharp
System.Fakes.ShimEnvironment.GetCommandLineArgsGet = ...
```

When you make these modifications, you gain the ability to control and test how your code interacts with system environment variables, which is an essential tool for comprehensive unit testing.

## Related content

- [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)
