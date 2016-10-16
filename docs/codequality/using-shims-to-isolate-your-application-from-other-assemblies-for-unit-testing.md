---
title: "Using shims to isolate your application from other assemblies for unit testing"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d2a34de2-6527-4c21-8b93-2f268ee894b7
caps.latest.revision: 12
ms.author: "mlearned"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using shims to isolate your application from other assemblies for unit testing
**Shim types** are one of two technologies that the Microsoft Fakes Framework uses to let you easily isolate components under test from the environment. Shims divert calls to specific methods to code that you write as part of your test. Many methods return different results dependent on external conditions, but a shim is under the control of your test and can return consistent results at every call. This makes your tests much easier to write.  
  
 Use shims to isolate your code from assemblies that are not part of your solution. To isolate components of your solution from each other, we recommend that you use stubs.  
  
 For an overview and quick start guidance, see [Isolating Code Under Test with Microsoft Fakes](../codequality/isolating-code-under-test-with-microsoft-fakes.md)  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 See [Video (1h16): Testing Un-testable Code with Fakes in Visual Studio 2012](http://go.microsoft.com/fwlink/?LinkId=261837)  
  
## In this topic  
 Here’s what you’ll learn in this topic:  
  
 [Example: The Y2K bug](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Example__The_Y2K_bug)  
  
 [How to use Shims](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Fakes_requirements)  
  
-   [Add Fakes Assemblies](#AddFakes)  
  
-   [Use ShimsContext](#ShimsContext)  
  
-   [Write Tests with Shims](#WriteTests)  
  
 [Shims for different kinds of methods](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Shim_basics)  
  
-   [Static methods](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Static_methods)  
  
-   [Instance methods (for all instances)](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Instance_methods__for_all_instances_)  
  
-   [Instance methods (for one runtime instance)](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Instance_methods__for_one_instance_)  
  
-   [Constructors](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Constructors)  
  
-   [Base members](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Base_members)  
  
-   [Static constructors](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Static_constructors)  
  
-   [Finalizers](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Finalizers)  
  
-   [Private methods](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Private_methods)  
  
-   [Binding interfaces](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Binding_interfaces)  
  
 [Changing the default behavior](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Changing_the_default_behavior)  
  
 [Detecting environment accesses](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Detecting_environment_accesses)  
  
 [Concurrency](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Concurrency)  
  
 [Calling the original method from the shim method](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Calling_the_original_method_from_the_shim_method)  
  
 [Limitations](../codequality/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md#BKMK_Limitations)  
  
##  <a name="BKMK_Example__The_Y2K_bug"></a> Example: The Y2K bug  
 Let’s consider a method that throws an exception on January 1st of 2000:  
  
```c#  
// code under test  
public static class Y2KChecker {  
    public static void Check() {  
        if (DateTime.Now == new DateTime(2000, 1, 1))  
            throw new ApplicationException("y2kbug!");  
    }  
}  
  
```  
  
 Testing this method is particularly problematic because the program depends on `DateTime.Now`, a method that depends on the computer's clock, an environment-dependent, non-deterministic method. Furthermore, the `DateTime.Now` is a static property so a stub type can’t be used here. This problem is symptomatic of the isolation issue in unit testing: programs that directly call into database APIs, communicate with web services, and so on are hard to unit test because their logic depends on the environment.  
  
 This is where shim types should be used. Shim types provide a mechanism to detour any .NET method to a user defined delegate. Shim types are code-generated by the Fakes generator, and they use delegates, which we call shim types, to specify the new method implementations.  
  
 The following test shows how to use the shim type, `ShimDateTime`, to provide a custom implementation of DateTime.Now:  
  
```c#  
//unit test code  
// create a ShimsContext cleans up shims   
using (ShimsContext.Create()  
    // hook delegate to the shim method to redirect DateTime.Now  
    // to return January 1st of 2000  
    ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);  
    Y2KChecker.Check();  
}  
  
```  
  
##  <a name="BKMK_Fakes_requirements"></a> How to use Shims  
  
###  <a name="AddFakes"></a> Add Fakes Assemblies  
  
1.  In Solution Explorer, expand your unit test project’s **References**.  
  
    -   If you are working in Visual Basic, you must select **Show All Files** in the Solution Explorer toolbar, in order to see the References list.  
  
2.  Select the assembly that contains the classes definitions for which you want to create shims. For example, if you want to shim DateTime, select System.dll  
  
3.  On the shortcut menu, choose **Add Fakes Assembly**.  
  
###  <a name="ShimsContext"></a> Use ShimsContext  
 When using shim types in a unit test framework, you must wrap the test code in a `ShimsContext` to control the lifetime of your shims. If we didn’t require this, your shims would last until the AppDomain shut down. The easiest way to create a `ShimsContext` is by using the static `Create()` method as shown in the following code:  
  
```c#  
//unit test code  
[Test]  
public void Y2kCheckerTest() {  
  using(ShimsContext.Create()) {  
    ...  
  } // clear all shims  
}  
  
```  
  
 It is critical to properly dispose each shim context. As a rule of thumb, always call the `ShimsContext.Create` inside of a `using` statement to ensure proper clearing of the registered shims. For example, you might register a shim for a test method that replaces the `DateTime.Now` method with a delegate that always returns the first of January 2000. If you forget to clear the registered shim in the test method, the rest of the test run would always return the first of January 2000 as the DateTime.Now value. This might be suprising and confusing.  
  
###  <a name="WriteShims"></a> Write a test with shims  
 In your test code, insert a *detour* for the method you want to fake. For example:  
  
```c#  
[TestClass]  
public class TestClass1  
{   
        [TestMethod]  
        public void TestCurrentYear()  
        {  
            int fixedYear = 2000;  
  
            using (ShimsContext.Create())  
            {  
              // Arrange:  
                // Detour DateTime.Now to return a fixed date:  
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
  
```vb#  
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
  
 Shim class names are made up by prefixing `Fakes.Shim` to the original type name.  
  
 Shims work by inserting *detours* into the code of the application under test. Wherever a call to the original method occurs, the Fakes system performs a detour, so that instead of calling the real method, your shim code is called.  
  
 Notice that detours are created and deleted at run time. You must always create a detour within the life of a `ShimsContext`. When it is disposed, any shims you created while it was active are removed. The best way to do this is inside a `using` statement.  
  
 You might see a build error stating that the Fakes namespace does not exist. This error sometimes appears when there are other compilation errors. Fix the other errors and it will vanish.  
  
##  <a name="BKMK_Shim_basics"></a> Shims for different kinds of methods  
 Shim types allow you to replace any .NET method, including static methods or non-virtual methods, with your own delegates.  
  
###  <a name="BKMK_Static_methods"></a> Static methods  
 The properties to attach shims to static methods are placed in a shim type. Each property has only a setter that can be used to attach a delegate to the target method. For example, given a class `MyClass` with a static method `MyMethod`:  
  
```c#  
//code under test  
public static class MyClass {  
    public static int MyMethod() {  
        ...  
    }  
}  
```  
  
 We can attach a shim to `MyMethod` that always returns 5:  
  
```c#  
// unit test code  
ShimMyClass.MyMethod = () =>5;  
```  
  
###  <a name="BKMK_Instance_methods__for_all_instances_"></a> Instance methods (for all instances)  
 Similarly to static methods, instance methods can be shimmed for all instances. The properties to attach those shims are placed in a nested type named AllInstances to avoid confusion. For example, given a class `MyClass` with an instance method `MyMethod`:  
  
```c#  
// code under test  
public class MyClass {  
    public int MyMethod() {  
        ...  
    }  
}  
```  
  
 You can attach a shim to `MyMethod` that always returns 5, regardless of the instance:  
  
```c#  
// unit test code  
ShimMyClass.AllInstances.MyMethod = () => 5;  
```  
  
 The generated type structure of ShimMyClass looks like the following code:  
  
```c#  
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
  
 Notice that Fakes passes the runtime instance as the first argument of the delegate in this case.  
  
###  <a name="BKMK_Instance_methods__for_one_instance_"></a> Instance methods (for one runtime instance)  
 Instance methods can also be shimmed by different delegates, based on the receiver of the call. This enables the same instance method to have different behaviors per instance of the type. The properties to set up those shims are instance methods of the shim type itself. Each instantiated shim type is also associated with a raw instance of a shimmed type.  
  
 For example, given a class `MyClass` with an instance method `MyMethod`:  
  
```c#  
// code under test  
public class MyClass {  
    public int MyMethod() {  
        ...  
    }  
}  
```  
  
 We can set up two shim types of MyMethod such that the first one always returns 5 and the second always returns 10:  
  
```c#  
// unit test code  
var myClass1 = new ShimMyClass()  
{  
    MyMethod = () => 5  
};  
var myClass2 = new ShimMyClass { MyMethod = () => 10 };  
```  
  
 The generated type structure of ShimMyClass looks like the following code:  
  
```c#  
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
  
 The actual shimmed type instance can be accessed through the Instance property:  
  
```c#  
// unit test code  
var shim = new ShimMyClass();  
var instance = shim.Instance;  
```  
  
 The shim type also has an implicit conversion to the shimmed type, so you can usually simply use the shim type as is:  
  
```c#  
// unit test code  
var shim = new ShimMyClass();  
MyClass instance = shim; // implicit cast retrieves the runtime  
                         // instance  
```  
  
###  <a name="BKMK_Constructors"></a> Constructors  
 Constructors can also be shimmed in order to attach shim types to future objects. Each constructor is exposed as a static method Constructor in the shim type. For example, given a class `MyClass` with a constructor taking an integer:  
  
```c#  
// code under test  
public class MyClass {  
    public MyClass(int value) {  
        this.Value = value;  
    }  
    ...  
}  
```  
  
 We set up the shim type of the constructor so that every future instance returns -5 when the Value getter is invoked, regardless of the value in the constructor:  
  
```c#  
// unit test code  
ShimMyClass.ConstructorInt32 = (@this, value) => {  
    var shim = new ShimMyClass(@this) {  
        ValueGet = () => -5  
    };  
};  
```  
  
 Note that each shim type exposes two constructors. The default constructor should be used when a fresh instance is needed, while the constructor taking a shimmed instance as argument should be used in constructor shims only:  
  
```c#  
// unit test code  
public ShimMyClass() { }  
public ShimMyClass(MyClass instance) : base(instance) { }  
```  
  
 The generated type structure of ShimMyClass resembles the followoing code:  
  
```c#  
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
  
###  <a name="BKMK_Base_members"></a> Base members  
 The shim properties of base members can be accessed by creating a shim for the base type and passing the child instance as a parameter to the constructor of the base shim class.  
  
 For example, given a class `MyBase` with an instance method `MyMethod` and a subtype `MyChild`:  
  
```c#  
public abstract class MyBase {  
    public int MyMethod() {  
        ...  
    }  
}  
  
public class MyChild : MyBase {  
}  
  
```  
  
 We can set up a shim of `MyBase` by creating a new `ShimMyBase` shim:  
  
```c#  
// unit test code  
var child = new ShimMyChild();  
new ShimMyBase(child) { MyMethod = () => 5 };  
```  
  
 Note that the child shim type is implicitly converted to the child instance when passed as a parameter to the base shim constructor.  
  
 The generated type structure of ShimMyChild and ShimMyBase resembles the following code:  
  
```c#  
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
  
###  <a name="BKMK_Static_constructors"></a> Static constructors  
 Shim types expose a static method `StaticConstructor` to shim the static constructor of a type. Since static constructors are executed once only, you need to ensure that the shim is configured before any member of the type is accessed.  
  
###  <a name="BKMK_Finalizers"></a> Finalizers  
 Finalizers are not supported in Fakes.  
  
###  <a name="BKMK_Private_methods"></a> Private methods  
 The Fakes code generator will create shim properties for private methods that only have visible types in the signature, i.e. parameter types and return type visible.  
  
###  <a name="BKMK_Binding_interfaces"></a> Binding interfaces  
 When a shimmed type implements an interface, the code generator emits a method that allows it to bind all the members from that interface at once.  
  
 For example, given a class `MyClass` that implements `IEnumerable<int>`:  
  
```c#  
public class MyClass : IEnumerable<int> {  
    public IEnumerator<int> GetEnumerator() {  
        ...  
    }  
    ...  
}  
  
```  
  
 We can shim the implementations of `IEnumerable<int>` in MyClass by calling the Bind method:  
  
```c#  
// unit test code  
var shimMyClass = new ShimMyClass();  
shimMyClass.Bind(new List<int> { 1, 2, 3 });  
  
```  
  
 The generated type structure of ShimMyClass resembles the following code:  
  
```c#  
// Fakes generated code  
public class ShimMyClass : ShimBase<MyClass> {  
    public ShimMyClass Bind(IEnumerable<int> target) {  
        ...  
    }  
}  
  
```  
  
##  <a name="BKMK_Changing_the_default_behavior"></a> Changing the default behavior  
 Each generated shim type holds an instance of the `IShimBehavior` interface, through the `ShimBase<T>.InstanceBehavior` property. The behavior is used whenever a client calls an instance member that was not explicitly shimmed.  
  
 If the behavior has not been explicitly set, it will use the instance returned by the static `ShimsBehaviors.Current` property. By default, this property returns a behavior that throws a `NotImplementedException` exception.  
  
 This behavior can be changed at any time by setting the `InstanceBehavior` property on any shim instance. For example, the following snippet changes the shim to a behavior that does nothing or returns the default value of the return type—that is, default(T):  
  
```c#  
// unit test code  
var shim = new ShimMyClass();  
//return default(T) or do nothing  
shim.InstanceBehavior = ShimsBehaviors.DefaultValue;  
  
```  
  
 The behavior can also be changed globally for all shimmed instances for which the `InstanceBehavior` property was not explicitly set by setting the static `ShimsBehaviors.Current` property:  
  
```c#  
// unit test code  
// change default shim for all shim instances  
// where the behavior has not been set  
ShimsBehaviors.Current =   
    ShimsBehaviors.DefaultValue;  
  
```  
  
##  <a name="BKMK_Detecting_environment_accesses"></a> Detecting environment accesses  
 It is possible to attach a behavior to all the members, including static methods, of a particular type by assigning the `ShimsBehaviors.NotImplemented` behavior to the static property `Behavior` of the corresponding shim type:  
  
```c#  
// unit test code  
// assigning the not implemented behavior  
ShimMyClass.Behavior = ShimsBehaviors.NotImplemented;  
// shorthand  
ShimMyClass.BehaveAsNotImplemented();  
  
```  
  
##  <a name="BKMK_Concurrency"></a> Concurrency  
 Shim types apply to all threads in the AppDomain and don’t have thread affinity. This is an important fact if you plan to use a test runner that support concurrency: tests involving shim types cannot run concurrently. This property is not enfored by the Fakes runtime.  
  
##  <a name="BKMK_Calling_the_original_method_from_the_shim_method"></a> Calling the original method from the shim method  
 Imagine that we wanted to actually write the text to the file system after validating the file name passed to the method. In that case, we would want to call the original method in the middle of the shim method.  
  
 The first approach to solve this problem is to wrap a call to the original method using a delegate and `ShimsContext.ExecuteWithoutShims()` as in the following code:  
  
```c#  
// unit test code  
ShimFile.WriteAllTextStringString = (fileName, content) => {  
  ShimsContext.ExecuteWithoutShims(() => {  
  
      Console.WriteLine("enter");  
      File.WriteAllText(fileName, content);  
      Console.WriteLine("leave");  
  });  
};  
  
```  
  
 Another approach is to set the shim to null, call the original method and restore the shim.  
  
```c#  
// unit test code  
ShimsDelegates.Action<string, string> shim = null;  
shim = (fileName, content) => {  
  try {  
    Console.WriteLine("enter”);  
    // remove shim in order to call original method  
    ShimFile.WriteAllTextStringString = null;  
    File.WriteAllText(fileName, content);  
  }  
  finally  
  {  
    // restore shim  
    ShimFile.WriteAllTextStringString = shim;  
    Console.WriteLine("leave");  
  }  
};  
// initialize the shim  
ShimFile.WriteAllTextStringString = shim;  
  
```  
  
##  <a name="BKMK_Limitations"></a> Limitations  
 Shims cannot be used on all types from the .NET base class library **mscorlib** and **System**.  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](http://go.microsoft.com/fwlink/?LinkID=255188)  
  
## See Also  
 [Isolating Code Under Test with Microsoft Fakes](../codequality/isolating-code-under-test-with-microsoft-fakes.md)   
 [Peter Provost’s blog: Visual Studio 2012 Shims](http://www.peterprovost.org/blog/2012/04/25/visual-studio-11-fakes-part-2)   
 [Video (1h16): Testing Un-testable Code with Fakes in Visual Studio 2012](http://go.microsoft.com/fwlink/?LinkId=261837)