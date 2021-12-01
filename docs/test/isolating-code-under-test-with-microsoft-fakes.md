---
title: Isolating Code Under Test with Microsoft Fakes
description: Learn how Microsoft Fakes helps you isolate the code you are testing by replacing other parts of the application with stubs or shims.
ms.custom: SEO-VS-2020
ms.date: 06/03/2020
ms.topic: how-to
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload: 
  - multiple
author: mikejo5000
dev_langs: 
  - VB
  - CSharp
---
# Isolate code under test with Microsoft Fakes

Microsoft Fakes helps you isolate the code you are testing by replacing other parts of the application with *stubs* or *shims*. These are small pieces of code that are under the control of your tests. By isolating your code for testing, you know that if the test fails, the cause is there and not somewhere else. Stubs and shims also let you test your code even if other parts of your application are not working yet.

Fakes come in two flavors:

- A [stub](#get-started-with-stubs) replaces a class with a small substitute that implements the same interface.  To use stubs, you have to design your application so that each component depends only on interfaces, and not on other components. (By "component" we mean a class or group of classes that are designed and updated together and typically contained in an assembly.)

- A [shim](#get-started-with-shims) modifies the compiled code of your application at run time so that instead of making a specified method call, it runs the shim code that your test provides. Shims can be used to replace calls to assemblies that you cannot modify, such as .NET assemblies.

![Fakes replace other components](../test/media/fakes-2.png)

**Requirements**

- Visual Studio Enterprise
- A .NET Framework project
::: moniker range=">=vs-2019"
- .NET Core, .NET 5.0 or later, and SDK-style project support previewed in Visual Studio 2019 Update 6, and is enabled by default in Update 8. For more information, see [Microsoft Fakes for .NET Core and SDK-style projects](/visualstudio/releases/2019/release-notes#microsoft-fakes-for-net-core-and-sdk-style-projects).
::: moniker-end

> [!NOTE]
> - Profiling with Visual Studio is not available for tests that use Microsoft Fakes.

## Choose between stub and shim types
Typically, you would consider a Visual Studio project to be a component, because you develop and update those classes at the same time. You would consider using stubs and shims for calls that the project makes to other projects in your solution, or to other assemblies that the project references.

As a general guide, use stubs for calls within your Visual Studio solution, and shims for calls to other referenced assemblies. This is because within your own solution it is good practice to decouple the components by defining interfaces in the way that stubbing requires. But external assemblies such as *System.dll* typically are not provided with separate interface definitions, so you must use shims instead.

Other considerations are:

**Performance.** Shims run slower because they rewrite your code at run time. Stubs do not have this performance overhead and are as fast as virtual methods can go.

**Static methods, sealed types.** You can only use stubs to implement interfaces. Therefore, stub types cannot be used for static methods, non-virtual methods, sealed virtual methods, methods in sealed types, and so on.

**Internal types.** Both stubs and shims can be used with internal types that are made accessible by using the assembly attribute <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute>.

**Private methods.** Shims can replace calls to private methods if all the types on the method signature are visible. Stubs can only replace visible methods.

**Interfaces and abstract methods.** Stubs provide implementations of interfaces and abstract methods that can be used in testing. Shims can't instrument interfaces and abstract methods, because they don't have method bodies.

In general, we recommend that you use stub types to isolate from dependencies within your codebase. You can do this by hiding the components behind interfaces. Shim types can be used to isolate from third-party components that do not provide a testable API.

## Get started with stubs
For a more detailed description, see [Use stubs to isolate parts of your application from each other for unit testing](../test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing.md).

1. **Inject interfaces**

     To use stubs, you have to write the code you want to test in such a way that it does not explicitly mention classes in another component of your application. By "component" we mean a class or classes that are developed and updated together, and typically contained in one Visual Studio project. Variables and parameters should be declared by using interfaces and instances of other components should be passed in or created by using a factory. For example, if StockFeed is a class in another component of the application, then this would be considered bad:

     `return (new StockFeed()).GetSharePrice("COOO"); // Bad`

     Instead, define an interface that can be implemented by the other component, and which can also be implemented by a stub for test purposes:

    ```csharp
    public int GetContosoPrice(IStockFeed feed) => feed.GetSharePrice("COOO");
    ```

    ```vb
    Public Function GetContosoPrice(feed As IStockFeed) As Integer
     Return feed.GetSharePrice("COOO")
    End Function

    ```

2. **Add Fakes Assembly**

   1. In **Solution Explorer**, 
       - For an older .NET Framework Project (non-SDK style), expand your unit test project's **References** node.
       ::: moniker range=">=vs-2019"
       - For an SDK-style project targeting .NET Framework, .NET Core, or .NET 5.0 or later, expand the **Dependencies** node to find the assembly you would like to fake under **Assemblies**, **Projects**, or **Packages**.
       ::: moniker-end
       - If you're working in Visual Basic, select **Show All Files** in the **Solution Explorer** toolbar to see the **References** node.
   2. Select the assembly that contains the class definitions for which you want to create shims. For example, if you want to shim **DateTime**, select **System.dll**.

   3. On the shortcut menu, choose **Add Fakes Assembly**.

3. In your tests, construct instances of the stub and provide code for its methods:

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

    The special piece of magic here is the class `StubIStockFeed`. For every interface in the referenced assembly, the Microsoft Fakes mechanism generates a stub class. The name of the stub class is derived from the name of the interface, with "`Fakes.Stub`" as a prefix, and the parameter type names appended.

    Stubs are also generated for the getters and setters of properties, for events, and for generic methods. For more information, see [Use stubs to isolate parts of your application from each other for unit testing](../test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing.md).

## Get started with shims
(For a more detailed description, see [Use shims to isolate your application from other assemblies for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md).)

Suppose your component contains calls to `DateTime.Now`:

```csharp
// Code under test:
    public int GetTheCurrentYear()
    {
       return DateTime.Now.Year;
    }
```

During testing, you would like to shim the `Now` property, because the real version inconveniently returns a different value at every call.

To use shims, you don't have to modify the application code or write it a particular way.

1. **Add Fakes Assembly**

     In **Solution Explorer**, open your unit test project's references and select the reference to the assembly that contains the method you want to fake. In this example, the `DateTime` class is in *System.dll*.  To see the references in a Visual Basic project, choose **Show All Files**.

     Choose **Add Fakes Assembly**.

2. **Insert a shim in a ShimsContext**

    ```csharp
    [TestClass]
    public class TestClass1
    {
            [TestMethod]
            public void TestCurrentYear()
            {
                int fixedYear = 2000;

                // Shims can be used only in a ShimsContext:
                using (ShimsContext.Create())
                {
                  // Arrange:
                    // Shim DateTime.Now to return a fixed date:
                    System.Fakes.ShimDateTime.NowGet =
                    () =>
                    { return new DateTime(fixedYear, 1, 1); };

                    // Instantiate the component under test:
                    var componentUnderTest = new MyComponent();

                  // Act:
                    int year = componentUnderTest.GetTheCurrentYear();

                  // Assert:
                    // This will always be true if the component is working:
                    Assert.AreEqual(fixedYear, year);
                }
            }
    }
    ```

    ```vb
    <TestClass()> _
    Public Class TestClass1
        <TestMethod()> _
        Public Sub TestCurrentYear()
            Using s = Microsoft.QualityTools.Testing.Fakes.ShimsContext.Create()
                Dim fixedYear As Integer = 2000
                ' Arrange:
                ' Detour DateTime.Now to return a fixed date:
                System.Fakes.ShimDateTime.NowGet = _
                    Function() As DateTime
                        Return New DateTime(fixedYear, 1, 1)
                    End Function

                ' Instantiate the component under test:
                Dim componentUnderTest = New MyComponent()
                ' Act:
                Dim year As Integer = componentUnderTest.GetTheCurrentYear
                ' Assert:
                ' This will always be true if the component is working:
                Assert.AreEqual(fixedYear, year)
            End Using
        End Sub
    End Class
    ```

    Shim class names are made up by prefixing `Fakes.Shim` to the original type name. Parameter names are appended to the method name. (You don't have to add any assembly reference to System.Fakes.)

The previous example uses a shim for a static method. To use a shim for an instance method, write `AllInstances` between the type name and the method name:

```vb
System.IO.Fakes.ShimFile.AllInstances.ReadToEnd = ...
```

(There is no 'System.IO.Fakes' assembly to reference. The namespace is generated by the shim creation process. But you can use 'using' or 'Import' in the usual way.)

You can also create shims for specific instances, for constructors, and for properties. For more information, see [Use shims to isolate your application from other assemblies for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md).

## Using Microsoft Fakes in the CI

### Microsoft Fakes Assembly Generation
Since Microsoft Fakes requires Visual Studio Enterprise, the generation of Fakes Assemblies requires that you build your project using [Visual Studio Build Task](/azure/devops/pipelines/tasks/build/visual-studio-build?view=azure-devops&preserve-view=true).

::: moniker range=">=vs-2019"
> [!NOTE]
> An alternative to this is to check your Fakes Assemblies into the CI and use the [MSBuild Task](../msbuild/msbuild-task.md?view=vs-2019&preserve-view=true). When you do this, you need to ensure that you have an assembly reference to the generated Fakes assembly in your test project, similar to the following code snippet :

```xml
<Project Sdk="Microsoft.NET.Sdk">
    <ItemGroup>
        <Reference Include="FakesAssemblies\System.Fakes.dll"/>
    </ItemGroup>
</Project>
```

This reference is required to be added in manually specifically SDK-style projects (.NET Core, .NET 5.0 or later, and .NET Framework) because we have moved to implicitly adding assembly references to your test project. If you follow this method, you need to ensure that the fakes assembly is updated when the parent assembly changes.
::: moniker-end

### Running Microsoft Fakes tests
As long as Microsoft Fakes assemblies are present in the configured `FakesAssemblies` directory (The default being `$(ProjectDir)FakesAssemblies`), you can run tests using the [vstest task](/azure/devops/pipelines/tasks/test/vstest?view=azure-devops&preserve-view=true).

::: moniker range=">=vs-2019"
Distributed testing with the [vstest task](/azure/devops/pipelines/tasks/test/vstest?view=azure-devops&preserve-view=true) .NET Core and .NET 5.0 or later projects using Microsoft Fakes requires Visual Studio 2019 Update 9 Preview `20201020-06` and higher.
::: moniker-end

::: moniker range=">=vs-2019"
## Transitioning your .NET Framework test projects that use Microsoft Fakes to SDK-style .NET Framework, .NET Core, or .NET 5.0 or later projects
You will need minimal changes in your .NET Framework set up for Microsoft Fakes to transition to .NET Core or .NET 5.0 or later. The cases that you would have to consider are:
- If you are using a custom project template, you need to ensure that it is SDK-style and builds for a compatible target framework.
- Certain types exist in different assemblies in .NET Framework and .NET Core/.NET 5.0 or later (for example, `System.DateTime` exists in `System`/`mscorlib` in .NET Framework, and in `System.Runtime` in .NET Core and .NET 5.0 or later), and in these scenarios you need to change the assembly being faked.
- If you have an assembly reference to a fakes assembly and the test project, you might see a build warning about a missing reference similar to:
  ```
  (ResolveAssemblyReferences target) ->
  warning MSB3245: Could not resolve this reference. Could not locate the assembly "AssemblyName.Fakes". Check to make sure the assembly exists on disk.
  If this reference is required by your code, you may get compilation errors.
  ```
  This warning is due to necessary changes made in Fakes generation can be ignored. It can be avoided by removing the assembly reference from the project file, because we now implicitly add them during the build.
::: moniker-end

## Microsoft Fakes support 
### Microsoft Fakes in older projects targeting .NET Framework (non-SDK style).
- Microsoft Fakes assembly generation is supported in Visual Studio Enterprise 2015 and higher.
- Microsoft Fakes tests can run with all available Microsoft.TestPlatform NuGet packages.
- Code coverage is supported for test projects using Microsoft Fakes in Visual Studio Enterprise 2015 and higher.

### Microsoft Fakes in SDK-style .NET Framework, .NET Core, and .NET 5.0 or later projects
- Microsoft Fakes assembly generation previewed in Visual Studio Enterprise 2019 Update 6 and is enabled by default in Update 8.
- Microsoft Fakes tests for projects that target .NET Framework can run with all available Microsoft.TestPlatform NuGet packages.
- Microsoft Fakes tests for projects that target .NET Core and .NET 5.0 or later can run with Microsoft.TestPlatform NuGet packages with versions [16.9.0-preview-20210106-01](https://www.nuget.org/packages/Microsoft.TestPlatform/16.9.0-preview-20210106-01) and higher.
- Code coverage is supported for test projects targeting .NET Framework using Microsoft Fakes in Visual Studio Enterprise version 2015 and higher.
- Code coverage support for test projects targeting .NET Core and .NET 5.0 or later using Microsoft Fakes is available in Visual Studio 2019 update 9 and higher.


## In this section
[Use stubs to isolate parts of your application from each other for unit testing](../test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing.md)

[Use shims to isolate your application from other assemblies for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md)

[Code generation, compilation, and naming conventions in Microsoft Fakes](../test/code-generation-compilation-and-naming-conventions-in-microsoft-fakes.md)
