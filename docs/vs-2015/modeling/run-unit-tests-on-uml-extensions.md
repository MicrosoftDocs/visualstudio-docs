---
title: "Run unit tests on UML extensions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 745d74ae-e48c-4fd9-a755-4354b81b9f8a
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# Run unit tests on UML extensions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To help keep your code stable through successive changes, we recommend that you write unit tests and perform them as part of a regular build process. For more information, see [Unit Test Your Code](../test/unit-test-your-code.md). To set up tests for Visual Studio modeling extensions, you need some key pieces of information. In summary:

- [Setting up a Unit Test for VSIX Extensions](#Host)

   Run tests with the VS IDE host adapter. Prefix each test method with `[HostType("VS IDE")]`. This host adapter starts [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] when your tests run.

- [Accessing DTE and ModelStore](#DTE)

   Typically, you will have to open a model and its diagrams and access the `IModelStore` in the test initialization.

- [Opening a Model Diagram](#Opening)

   You can cast `EnvDTE.ProjectItem` to and from `IDiagramContext`.

- [Performing Changes in the UI Thread](#UiThread)

   Tests that make changes to the model store must be performed in the UI thread. You can use `Microsoft.VSSDK.Tools.VsIdeTesting.UIThreadInvoker` for this.

- [Testing commands, gestures and other MEF components](#MEF)

   To test MEF components, you must explicitly connect their imported properties to values.

  These points are elaborated in the following sections.

## Requirements
 See [Requirements](../modeling/extend-uml-models-and-diagrams.md#Requirements).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## <a name="Host"></a> Setting up a Unit Test for VSIX Extensions
 The methods in your modeling extensions usually work with a diagram that is already open. The methods use MEF imports such as **IDiagramContext** and **ILinkedUndoContext**. Your test environment must set up this context before you run the tests.

#### To set up a unit test that executes in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]

1. Create the UML extension project and the unit test project.

    1. **A UML extension project.** Typically you create this by using the command, gesture, or validation project templates. For example, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

    2. **A unit test project.** For more information, see [Unit Test Your Code](../test/unit-test-your-code.md).

2. Create a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution that contains a UML modeling project. You will use this solution as the initial state of your tests. It should be separate from the solution in which you write the UML extension and its unit tests. For more information, see [Create UML modeling projects and diagrams](../modeling/create-uml-modeling-projects-and-diagrams.md).

3. **In the UML extension project**, edit the .csproj file as text and make sure that the following lines show `true`:

    ```
    <CopyBuildOutputToOutputDirectory>true</CopyBuildOutputToOutputDirectory>
        <CopyOutputSymbolsToOutputDirectory>true</CopyOutputSymbolsToOutputDirectory>
    ```

     To edit the .csproj file as text, choose **Unload Project** on the shortcut menu of the project in Solution Explorer. Then choose **Edit ….csproj**. After you have edited the text, choose **Reload Project**.

4. In your UML extension project, add the following line to **Properties\AssemblyInfo.cs**. This allows the unit tests to access the methods that you want to test:

    ```csharp
    [assembly:InternalsVisibleTo("MyUnitTests")] // Name of unit tests assembly.
    ```

5. **In the unit test project**, add the following assembly References:

    - *Your UML extension project*

    - **EnvDTE.dll**

    - **Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll**

    - **Microsoft.VisualStudio.ComponentModelHost.dll**

    - **Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll**

    - **Microsoft.VisualStudio.Uml.Interfaces.dll**

    - **Microsoft.VSSDK.TestHostFramework.dll**

6. Prefix the attribute `[HostType("VS IDE")]` to each test method, including initialization methods.

     This will ensure that the test will run in an experimental instance of Visual Studio.

## <a name="DTE"></a> Accessing DTE and ModelStore
 Write a method to open a modeling project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Typically, you want to open a solution only once in each test run. To run the method only once, prefix the method with the `[AssemblyInitialize]` attribute. Don’t forget that you also need the [HostType("VS IDE")] attribute on each test method.  For example:

```csharp
using EnvDTE;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VSSDK.Tools.VsIdeTesting;

namespace UnitTests
{
  [TestClass]
  public static class TestSetup
  {

    // Location of a VS Solution that defines an initial state for your tests:
    private const string testSolutionFilePath = @"C:\MyTestFolder\TestModelSln\TestModel.sln";
    // Name of a modeling project within the test solution:
    private const string testModelingProjectName = "MyTestModel";

    // Make Solution and IModelStore available to test methods:
    public static Solution ModelSolution = null;
    public static IModelingProject ModelingProject = null;
    public static IModelStore ModelStore = null;

    // This method will be performed once to initialize tests for this assembly:
    [AssemblyInitialize]
    [HostType("VS IDE")]
    public static void OpenTestModelingProject(TestContext testContext)
    {
      // To make sure that we always start the tests in the same state,
      // copy the test solution from a read-only directory:
      // TODO: copy test solution folder.

      // Open a solution that is the initial state for your tests:
      ModelSolution = VsIdeTestHostContext.Dte.Solution;
      ModelSolution.Open(testSolutionFilePath);

      // Find the ModelingProject and IModelStore:
      foreach (Project project in ModelSolution.Projects)
      {
        // https://msdn.microsoft.com/library/ee791691.aspx
        ModelingProject = project as IModelingProject;
        if (ModelingProject != null)
        {
          // This is a modeling project.
          ModelStore = ModelingProject.Store;
          break;
        }
        // else this is another kind of project.
      }

      Assert.IsNotNull(ModelSolution, "VS solution not found");
      Assert.IsNotNull(ModelStore, "Modeling store not found");
    }
    [AssemblyCleanup]
    public static void RemoveTestSolution ()
    {
      // TODO: Remove copied test solution directory.
    }
  }
}

```

 If an instance of <xref:EnvDTE.Project?displayProperty=fullName> represents a modeling project, then you can cast it to and from [IModelingProject](/previous-versions/ee789474(v=vs.140)).

## <a name="Opening"></a> Opening a Model Diagram
 For each test or class of tests, you typically want to work with an open diagram. The following example uses the `[ClassInitialize]` attribute, which executes this method before other methods in this test class. Again, don’t forget that you also need the attribute [HostType("VS IDE")] on each test method:

```csharp
//
private IDiagram diagram;
// This class contains unit tests:
[TestClass]
public class MyTestClass
{
  // Map filenames to open diagram files:
  private static Dictionary<string, IDiagram> diagrams = new Dictionary<string, IDiagram>();

  // This method will be called once for this test class:
  [ClassInitialize]
  [HostType("VS IDE")]
  public static void TestClassInitialize(TestContext testContext)
  {
    // Open all the diagrams in the model:
    foreach (ProjectItem item in (TestSetup.ModelingProject as Project).ProjectItems)
    {
      // Get the filename of the principal file (not the .layout subsidiary):
      string fileName = item.FileNames[0];
      // If this is a model diagram file, it can be cast to IDiagramContext:
      IDiagramContext modelingItem = item as IDiagramContext;
      if (modelingItem != null)
      {
        IDiagram diagram = modelingItem.CurrentDiagram;
        if (diagram == null)
        {
          // Diagram is closed. Open it:
          item.Open().Activate();
          diagram = modelingItem.CurrentDiagram;
        }
        diagrams[fileName] = diagram;
      }
      // else item is not a model diagram.
    }
    Assert.IsTrue(diagrams.Count>0, "UML diagram not found");
  }
// Insert test methods here ...
}

```

## <a name="UiThread"></a> Perform Model Changes in the UI Thread
 If your tests, or the methods under test, make changes to the model store, then you must execute them in the user interface thread. If you do not do this, you might see an `AccessViolationException`. Enclose the code of the test method in a call to Invoke:

```
using System.Windows.Forms;
using Microsoft.VSSDK.Tools.VsIdeTesting;
 ...
    [TestMethod]
    [HostType("VS IDE")]
    public void MyTest1()
    {
      // Store operations must run in the UI thread:
      UIThreadInvoker.Invoke((System.Action)delegate()
      {
        SetupTestState(TestSetup.ModelStore, diagram);
        ExecuteMethodUnderTest(TestSetup.ModelStore, diagram);
      });
    }
```

## <a name="MEF"></a> Testing command, gesture and other MEF components
 MEF components use property declarations that have the `[Import]` attribute, and whose values are set by their hosts. Typically, such properties include IDiagramContext, SVsServiceProvider, and ILinkedUndoContext. When you test a method that uses any of these properties, you have to set their values before executing the method under test. For example, if you have written a command extension resembling this code:

```

  [Export(typeof(ICommandExtension))]
  [ClassDesignerExtension]
  class MyCommand : ICommandExtension
  {
    [Import] IDiagramContext context { get; set; }
    [Import]
Microsoft.VisualStudio.Shell.SVsServiceProvider
serviceProvider {get;set;}
    [Import] ILinkedUndoContext linkedUndoContext { get; set; }
    public void Execute(IMenuCommand command)
    {
      DoCommand();
    }
    private void DoCommand()
    {
      IDiagram diagram = context.CurrentDiagram;
      using (ILinkedUndoTransaction t = linkedUndoContext.BeginTransaction("go"))
      { ... }}}

```

 Then you can set the imported properties as follows:

```

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VSSDK.Tools.VsIdeTesting;
...
    [TestMethod]
    [HostType("VS IDE")]
    public void Test1()
    {
      // Create an instance of the class under test:
      MyCommand myCommand = new MyCommand();
      // Get the components service:
      IComponentModel components = VsIdeTestHostContext.ServiceProvider
        .GetService(typeof(SComponentModel)) as IComponentModel;
      // Set the imported properties of the instance under test:
      // Extension requires "using System.ComponentModel.Composition;" :
      components.DefaultCompositionService.SatisfyImportsOnce(myCommand);
      // Call method(s) under test:
      UIThreadInvoker.Invoke((System.Action)delegate()
      {
        myCommand.DoCommand();
      });
...}
```

 If you want to test a method that takes an imported property as a parameter, then you can import the property into your test class, and apply `SatisfyImportsOnce` to the test instance. For example:

```

using System.ComponentModel.Composition;
...
  [TestClass]
  public class MyTestClass
  {
    [Import] ILinkedUndoContext linkedUndoContext { get; set; }

    // Called before each test method:
    [TestInitialize, HostType("VS IDE")]
    public void TestInitializer()
    {
      IComponentModel components = VsIdeTestHostContext.ServiceProvider
            .GetService(typeof(SComponentModel)) as IComponentModel;
      // Extension requires "using System.ComponentModel.Composition;" :
      components.DefaultCompositionService.SatisfyImportsOnce(this);
    }
    [TestMethod, HostType("VS IDE")]
    public void Test2()
    {
     UIThreadInvoker.Invoke((System.Action)delegate()
      {
      // Pass context items to class under test:
      Class1 item1 = new Class1(this.linkedUndoContext);
      item1.Method1(); // Can use linkedUndoContext
     });
   }
}

```

 In this example, the two attributes on each test method are combined for convenience into one line.

## Access from tests to private methods and variables
 Sometimes you want to test a method that is private, or you want to verify the state of a field that is private, before and after you execute a method under test. This presents a difficulty because the tests are in a separate assembly to the classes under test. There are several tactics that you can consider, including the following:

 Test only by using public and internal items
 Write your tests so that they use only public (or internal) classes and members. This is the best approach. Your tests will continue to work even if you refactor the internal implementation of the assembly under test. By applying the same tests before and after the changes, you can be sure that your changes have not altered the behavior of the assembly.

 To make this possible, you might have to restructure your code. For example, you might need to separate some methods into another class.

 By giving serious consideration to this approach, you will often find that your code is made easier to read and change, and less prone to errors when changes are necessary.

 You can allow the test assembly to access internal items by adding an attribute in **Properties\AssemblyInfo.cs** in the project to be tested:

```csharp
[assembly:InternalsVisibleTo("MyUnitTests")] // Name of unit tests assembly.
```

 Define a test interface
 Define an interface that includes both the public members of a class to be tested, and additional properties and methods for the private members that you want the tests to be able to use. Add this interface to the project to be tested. For example:

```csharp
internal interface MyClassTestInterface {
  void PublicMethod1();
  string PublicProperty1 { get; }
  string privateField1_Accessor { get; }
  int privateMethod1_Accessor (string p1);
 }
```

 Add methods to the class to be tested, to implement the accessor methods explicitly. Keep these additional methods separate from the main class by writing them in a partial class definition in a separate file. For example:

```csharp
partial public class MyClass
{
  string MyClassTestInterface.privateField1_Accessor
  { get { return privateField1; } }
  int MyClassTestInterface.privateMethod1_Accessor (string p1)
  { return privateMethod1(p1); }
}

```

 Allow the test assembly to use the test interfaces by adding this attribute to the assembly that you are testing:

```csharp
[assembly:InternalsVisibleTo("MyUnitTests")] // Name of unit tests assembly.
```

 In the unit test methods, use the test interface. For example:

```csharp
MyClassTestInterface testInstance = new MyClass();
testInstance.PublicMethod1();
Assert.AreEqual("hello", testInstance.privateField1_Accessor);
```

 Define accessors by using reflection
 This is the way that we recommend least. Older versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] provided a utility that automatically created an accessor method for each private method. Although this is convenient, our experience suggests that it tends to result in unit tests that are very strongly coupled to the internal structure of the application that they are testing. This results in extra work when the requirements or architecture change, because the tests have to be changed along with the implementation. Also, any erroneous assumptions in the design of the implementation are also built into the tests, so that the tests do not find errors.

## See Also
 [Anatomy of a Unit Test](https://msdn.microsoft.com/a03d1ee7-9999-4e7c-85df-7d9073976144)
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
