---
title: "Using emulators to isolate unit tests for Sharepoint 2010 applications"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.topic: conceptual
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
author: gewarren
---
# Using emulators to isolate unit tests for Sharepoint 2010 applications

The Microsoft.SharePoint.Emulators package provides a set of libraries that help you to create isolated unit tests for Microsoft SharePoint 2010 applications. Emulators use [shims](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md) from the [Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md) isolation framework to create lightweight in-memory objects that mimic the most common objects and methods of the SharePoint API. When a SharePoint method is not emulated, or when you want to change the default behavior of an emulator, you can create Fakes shims to provide the results that you want.

Existing test methods and classes can be easily converted to run in the Emulator context. This capability lets you create dual-use tests. A dual-use test can toggle between integration tests against the real SharePoint API and isolated unit tests that use the emulators.

##  <a name="BKMK_Requirements"></a> Requirements

-   Microsoft SharePoint 2010 (SharePoint 2010 Server or SharePoint 2010 Foundation)

-   Microsoft Visual Studio Enterprise

-   Microsoft SharePoint Emulators NuGet package

You should also be familiar with the [basics of unit testing in Visual Studio](../test/unit-test-basics.md) and some knowledge of [Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md).

##  <a name="BKMK_The_AppointmentsWebPart_example"></a> The AppointmentsWebPart example

The AppointmentsWebPart lets you view and manage a SharePoint list of your appointments.

![Appointments Web Part](../test/media/ut_emulators_appointmentswebpart.png)

We'll test two methods of the web part in this example:

-   The `ScheduleAppointment` method validates the list item values passed to the method and creates a new entry in a list on a specified SharePoint web.

-   The `GetAppointmentsForToday` method returns the details of today's appointments.

##  Convert an existing test

In a typical test of a method in a SharePoint component, the test method creates a temporary site in SharePoint Foundation and adds the SharePoint components to the site that the code under test requires. The test method then creates and exercises an instance of the component. At the end of the test, the site is torn down.

The `ScheduleAppointment` method of our code under test is probably one of the first methods written for the component:

```csharp
// method under test
public bool ScheduleAppointment(SPWeb web, string listName, string name,
    string phone, string email, string age, DateTime date, out string errorMsg)
{
    errorMsg = string.Empty;
    var badFormat = this.checkInput(name, phone, email, age);
    if (badFormat)
    {
        errorMsg = "Bad Format";
        return false;
    }
    var exists = this.CheckDuplicate(listName, web, name, phone, email, age, date);
    if (exists)
    {
        errorMsg = "Item already exists";
        return false;
    }
    SPListItemCollection items = web.Lists[listName].Items;
    // create item and populate fields
    SPListItem item = items.Add();
    item["Name"] = name;
    item["Phone"] = phone;
    item["Email"] = email;
    item["Age"] = age;
    item["Date"] = date.ToString("D");
    item.Update();
    return true;
}
```

The first test of the functionality in `ScheduleAppointment` method might look like this:

```csharp
[TestMethod]
public void ScheduleAppointmentReturnsTrueWhenNewAppointmentIsCreated()
{
    using( var site = new SPSite("http://localhost"))
    using (var webPart = new BookAnAppointmentWebPart())
    {
        // Arrange
        string errorMsg = string.Empty;
        DateTime date = DateTime.Now;
        SPList list = AddListToSiteHelper(site);

        // Act
        bool success = webPart.ScheduleAppointment(site.RootWeb, list.Title,
            "Raisa Pokrovskaya", "425-555-0163", "raisa@outlook.com", "55", date,
            out errorMsg);
        list.Delete();

        // Assert
        Assert.IsTrue(success);
    }
}
```

Although this test method does verify that the `ScheduleAppointment` method correctly adds a new entry to the list, it is more an integration test of the web part than a test of the specific behavior of your code. The external dependencies to SharePoint and the SharePoint API can cause the test to fail for reasons other than the user code in the `ScheduleAppointment` method. The overhead in creating and destroying the SharePoint site can also make the test too slow to run as a regular part of the coding process. Performing the setup and destruction of the site for every test method only compounds the problem of creating efficient developer unit tests.

Microsoft SharePoint emulators give you a set of object and method "doubles" that mimic the behavior of the most common SharePoint APIs. The emulated methods are lightweight implementations of the SharePoint API that do not require SharePoint to run. By using Microsoft Fakes to detour calls to the SharePoint API to the method doubles of SharePoint Emulators, you isolate your tests and make sure that you are testing the code you want. When you call SharePoint methods that are not emulated, you can use Fakes directly to create the desired behavior.

###  <a name="BKMK_Adding_the_Emulators_package_to_a_test_project"></a> Add the emulators package to a test project

To add the SharePoint emulators to a test project:

1.  Select the test project in **Solution Explorer**.

2.  Choose **Manage NuGet Packages** on the shortcut menu.

3.  Search the **Online** category for `Microsoft.SharePoint.Emulators`, and then choose **Install**.

![Sharepoint Emulators NuGet package](../test/media/ut_emulators_nuget.png)

###  <a name="BKMK__Running_a_test_method_in_the_emulation_context"></a> Run a test method with emulation

Installing the package adds references to the required libraries to your projects. To make it easy to use emulators in an existing test class, add the namespaces `Microsoft.SharePoint.Emulators` and `Microsoft.QualityTools.Testing.Emulators`.

To enable emulation in your test methods, wrap the method body in a `using` statement that creates a `SharePointEmulationScope` object. For example:

```csharp
[TestMethod]
public void ScheduleAppointmentReturnsTrueWhenNewAppointmentIsCreated()
{
    // create the emulation scope with a using statement
    using (new SharePointEmulationScope())
    using( var site = new SPSite("http://localhost"))
    using (var webPart = new BookAnAppointmentWebPart())
    {
        // Arrange
        string errorMsg = string.Empty;
        DateTime date = DateTime.Now;
        SPList list = AddListToSiteHelper(site);

        // Act
        bool success = webPart.ScheduleAppointment(site.RootWeb, list.Title,
            "Raisa Pokrovskaya", "425-555-0163", "raisa@outlook.com", "55", date,
            out errorMsg);
        list.Delete();

        // Assert
        Assert.IsTrue(success);
    }
}
```

When the test method is executed, the Emulator runtime calls Microsoft Fakes to dynamically inject code into SharePoint methods to divert the calls to these methods to delegates that are declared in *Microsoft.SharePoint.Fakes.dll*. *Microsoft.SharePoint.Emulators.dll* implements the delegates for emulated methods, closely mimicking the actual SharePoint behavior. When the test method or the component under test calls a SharePoint method, the behavior that results is that of the emulation.

![Emulator execution flow](../test/media/ut_emulators_flowchart.png)

##  Create dual-use classes and methods

To create methods that can be used for both integration tests against the real SharePoint API and isolated unit tests that use emulators, use the overloaded constructor `SharePointEmulationScope(EmulationMode)` to wrap your test method code. The two values of the `EmulationMode` enum specify whether the scope uses emulators (`EmulationMode.Enabled`) or whether the scope uses the SharePoint API (`EmulationMode.Passthrough`).

For example, here's how you can modify the previous test to be dual-use:

```csharp
// class level field specifies emulation mode
private const EmulationMode emulatorMode = EmulationMode.Enabled;

[TestMethod]
public void ScheduleAppointmentReturnsTrueWhenNewAppointmentIsCreated()
{
    // emulation scope determined by emulatorMode
    using( SharePointEmulationScope(emulatorMode))
    using( var site = new SPSite("http://localhost"))
    using (var webPart = new BookAnAppointmentWebPart())
    {
        // Arrange
        string errorMsg = string.Empty;
        DateTime date = DateTime.Now;
        SPList list = AddListToSiteHelper(site);

        // Act
        bool success = webPart.ScheduleAppointment(site.RootWeb, list.Title,
            "Raisa Pokrovskaya", "425-555-0163", "raisa@outlook.com", "55", date,
            out errorMsg);
        list.Delete();

        // Assert
        Assert.IsTrue(success);
    }
}
```

## Use TestInitialize and TestCleanup attributes to create a dual-use test class

If you run all or most of the tests in a class using `SharePointEmulationScope`, you can take advantage of class-level techniques to set the emulation mode.

-   Test class methods that attributed with <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute> and <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute> can create and destroy the scope.

-   Setting the `EmulationMode` at the class level can let you automate the mode change between `EmulationMode.Enabled` and `EmulationMode.Passthrough`.

A class method that is attributed with `[TestInitialize]` is run at the start of each test method and a method that is attributed with `[TestCleanup]` runs at the end of each test method. You can declare a private field for the `SharePointEmulationScope` object at the class level, initialize it in the `TestInitialize` attributed method, and then dispose of the object in the `TestCleanup` attributed method.

You can use any method that you choose to automate the selection of the `EmulationMode`. One way is to check for the existence of a symbol by using preprocessor directives. For example, to run the test methods in a class using emulators, you can define a symbol such as `USE_EMULATION` in the test project file or on the build command line. If the symbol is defined, a class level `EmulationMode` constant is declared and set to `Enabled`. Otherwise, the constant is set to `Passthrough`.

Here's an example of the test class that demonstrates how to use preprocessor directives and the `TestInitialize` and `TestCleanup` attributed methods to set the emulation mode.

```csharp
//namespace declarations
...

namspace MySPAppTests
{
    [TestClass]
    public class BookAnAppointmentWebPartTests
    {

        // emulationScope is a class level field
        private SharePointEmulationScope emulationScope;

        // preprocessor directives determine the value of emulatorMode
        #if USE_EMULATIONprivate const EmulationMode emulatorMode = EmulationMode.Enabled;#elseprivate const EmulationMode emulatorMode = EmulationMode.Passthrough;#endif

        // InitializeTest sets the emulation scope at the beginning of each test method
        [TestInitialize]public void InitializeTest(){this.emulationScope = new SharePointEmulationScope(emulatorMode);}

        // CleanupTest disposes the emulation scope at the end of each test method
        [TestCleanup]public void CleanupTest(){this.emulationScope.Dispose();}

        [TestMethod]
        public void ScheduleAppointmentReturnsTrueWhenNewAppointmentIsCreated()
        {
            // remove the SharePointEmulationScope using statement from the method
            using( var site = new SPSite("http://localhost"))
            using (var webPart = new BookAnAppointmentWebPart())
            {
                // Arrange
                string errorMsg = string.Empty;
                DateTime date = DateTime.Now;
                SPList list = AddListToSiteHelper(site);

                // Act
                bool success = webPart.ScheduleAppointment(site.RootWeb, list.Title,
                    "Raisa Pokrovskaya", "425-555-0163", "raisa@outlook.com", "55", date,
                    out errorMsg);
                list.Delete()

                // Assert
                Assert.IsTrue(success);
            }
        }

        ...// More tests

    }
}
```

##  Handle non-emulated SharePoint methods

Not all SharePoint types are emulated, and not all methods in some emulated types are emulated. If the code under test calls a SharePoint method that is not emulated, the method throws a `NotSupportedException` exception. When an exception occurs, you add a Fakes shim for the SharePoint method.

**Setting up Sharepoint Fakes**

To explicitly call Microsoft Fakes shims:

1.  If you want to shim a SharePoint class that is not emulated, edit the *Microsoft.SharePoint.fakes* file and add the class to the list of shimmed classes. See the [Configure code generation of stubs](code-generation-compilation-and-naming-conventions-in-microsoft-fakes.md#configure-code-generation-of-stubs) section of [Code generation, compilation, and naming conventions in Microsoft Fakes](../test/code-generation-compilation-and-naming-conventions-in-microsoft-fakes.md).

     ![Fakes folder in Solution Explorer](../test/media/ut_emulators_fakesfilefolder.png)

2.  Rebuild the test project at least once after you have installed the Microsoft SharePoint Emulators package and if you have edited the *Microsoft.SharePoint.Fakes* file. Building the project creates and populates a **FakesAssembly** folder in your on-disk project root folder.

     ![FakesAssembly folder](../test/media/ut_emulators_fakesassemblyfolder.png)

3.  Add a reference to the **Microsoft.SharePoint.14.0.0.0.Fakes.dll** assembly that is located in the **FakesAssembly** folder.

4.  (Optional) Add a namespace directive for to the test class for `Microsoft.QualityTools.Testing.Fakes`, `Microsoft.SharePoint.Fakes` and any nested namespace of `Microsoft.SharePoint.Fakes`that you want to use.

**Implementing the shim delegate for a SharePoint method**

In our example project, the `GetAppointmentsForToday` method calls the [SPList.GetItems(SPQuery)](xref:Microsoft.SharePoint.SPList.GetItems%2A) SharePoint API method.

```csharp
// method under test
public string GetAppointmentsForToday(string listName, SPWeb web)
{
    SPList list = web.Lists[listName];
    DateTime today = DateTime.Now;
    var listQuery = new SPQuery{Query = String.Format("<Where><Eq><FieldRef Name='Date'/>" +"<Value Type='Text'>{0}</Value>" +"</Eq></Where>", today.ToString("D"))};
    var result = new System.Text.StringBuilder();
    foreach (SPListItem item in list.GetItems(listQuery))
    {
        result.AppendFormat("Name: {0}, Phone: {1}, Email: {2}, Age: {3}, Date: {4}\n",
            item["Name"], item["Phone"], item["Email"], item["Age"], item["Date"]);
    }
    return result.ToString();
}
```

The `SPList.GetItems(SPQuery)` version of the overloaded `GetItems` method is not emulated. Therefore, just wrapping an existing test for `GetAppointmentsForToday` in `SharePoint.Emulation.Scope` would fail. To create a working test, you have to write an implementation of the Fakes delegate `ShimSPList.GetItemsSPQuery` that returns the results that you want to test against.

Here's a modification of an existing test method, `GetAppointmentsForTodayReturnsOnlyTodaysAppointments`, that implements a Fakes delegate. The required changes are called out in comments:

> [!IMPORTANT]
> Test methods that explicitly create Fakes shims throw a `ShimNotSupported` exception when the test is run in the `EmulationMode.Passthrough` context. To avoid this issue, use a variable to set the `EmulationMode` value and wrap any Fakes code in an `if` statement that tests the value.

```csharp
// class level field to set emulation mode
private const EmulationMode emulatorMode = EmulationMode.Enabled

[TestMethod]
public void GetAppointmentsForTodayReturnsOnlyTodaysAppointments()
{

    // create the emulation scope with a using statement
    using (var emulationScope = new SharePointEmulationScope(emulatorMode))
    using( var site = new SPSite("http://localhost"))
    using (var webPart = new BookAnAppointmentWebPart())
    {
        // Arrange
        DateTime date = DateTime.Now;
        SPList list = AddListToSiteHelper(site);
        // insert 2 items into list
        AddItemsToListHelper(list, new string[] {"Raisa Pokrovskaya", "425-555-0163",
            "raisa@outlook.com", "55", date.ToString("D") });
        AddItemsToListHelper(list, new string[] {"Francis Totten", "313-555-0100",
            "francis@contoso.com", "42", date.AddDays(1).ToString("D") });

        // use Fakes shims only if emulation is enabled
        if (emulatorMode == EmulationMode.Enabled){var sList = new ShimSPList(list);sList.GetItemsSPQuery = (query) =>{var shim = new ShimSPListItemCollection();shim.Bind(new[] { list.Items[0] });return shim.Instance;}}

        // Act
        string result = webPart.GetAppointmentsForToday(list.Title, site.RootWeb);
        list.Delete();

        // Assert
        Assert.IsTrue(result.Contains(String.Format(
            "Name: Raisa Pokrovskaya, Phone: 425-555-0163, Email: raisa@outlook.com," +
            "Age: 55, Date: {0}", date.ToString("D"))));
        Assert.IsFalse(result.Contains("Name: Francis Totten"));
    }
}
```

In this method, we first test that emulation is enabled. If it is, we create a Fakes shim object for our `SPList` list and then create and assign a method to its `GetItemsSPQuery` delegate. The delegate uses the Fakes `Bind` method to add the correct list item to the `ShimSPListItemCollection` that is returned to the caller.

##  Write emulation tests from scratch, and a summary

Although the techniques to create emulation and dual-use tests that are described in the previous sections assume that you are converting existing tests, you can also use the techniques to write tests from scratch. The following list summarizes these techniques:

-   To use emulators in a test project, add the Microsoft.SharePoint.Emulators NuGet package to the project.

-   To use emulators in a test method, create a `SharePointEmulationScope` object at the beginning of the method. All supported SharePoint APIs will be emulated until the scope is disposed.

-   Write your test code as if you were writing it against the real SharePoint API. The emulation context automatically detours the calls to SharePoint methods to their emulators.

-   Not all SharePoint objects are emulated, and not all methods of some emulated objects are emulated. A `NotSupportedException` exception is thrown when you use a non-emulated object or method. When this occurs, explicitly create a Fakes shim delegate for the method to return the required behavior.

-   To create dual-use tests, use the `SharePointEmulationScope(EmulationMode)` constructor to create the emulation scope object. The `EmulationMode` value specifies whether the SharePoint calls are emulated or executed against a real SharePoint site.

-   If all or most of your test methods in a test class execute in the emulation context, you can use a class-level `TestInitialize` attributed method to create the `SharePointEmulationScope` object and a class-level field to set the emulation mode. This will help you to automate the changing of the emulation mode. Then use a `TestCleanup` attributed method to dispose of the scope object.

##  <a name="BKMK_Example"></a> Example

Here's a final example that incorporates the SharePoint emulator techniques that are described above:

```csharp
using System;
//other namespace declarations
...
// code under test
using MySPApps;
using Microsoft.SharePoint;
// unit testing and emulators
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Emulators;
using Microsoft.SharePoint.Emulators;
// explicit Fakes shims
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.SharePoint.Fakes

namspace MySPAppTests
{
    [TestClass]
    public class BookAnAppointmentWebPartTests
    {

        // emulationScope is a class level field
        private SharePointEmulationScope emulationScope;

        // preprocessor directives determine the value of emulatorMode
        #if USE_EMULATION
            private const EmulationMode emulatorMode = EmulationMode.Enabled;
        #else
            private const EmulationMode emulatorMode = EmulationMode.Passthrough;
        #endif

        // InitializeTest sets the emulation scope at the beginning of each test method
        [TestInitialize]
        public void InitializeTest()
        {
            this.emulationScope = new SharePointEmulationScope(emulatorMode);
        }

        // CleanupTest disposes the emulation scope at the end of each test method
        [TestCleanup]
        public void Cleanup()
        {
            this.emulationScope.Dispose();
        }

        [TestMethod]
        public void ScheduleAppointmentReturnsTrueWhenNewAppointmentIsCreated()
        {
            // remove the SharePointEmulationScope using statement from the method
            using( var site = new SPSite("http://localhost"))
            using (var webPart = new BookAnAppointmentWebPart())
            {
                // Arrange
                string errorMsg = string.Empty;
                DateTime date = DateTime.Now;
                SPList list = AddListToSiteHelper(site);

                // Act
                bool success = webPart.ScheduleAppointment(site.RootWeb, list.Title,
                    "Raisa Pokrovskaya", "425-555-0163", "raisa@outlook.com", "55", date,
                    out errorMsg);
                list.Delete()

                // Assert
                Assert.IsTrue(success);
            }
        }

        [TestMethod]
        public void GetAppointmentsForTodayReturnsOnlyTodaysAppointments()
        {

            // remove the SharePointEmulationScope using statement from the method
            using( var site = new SPSite("http://localhost"))
            using (var webPart = new BookAnAppointmentWebPart())
            {
                // Arrange
                DateTime date = DateTime.Now;
                SPList list = AddListToSiteHelper(site);
                // insert 2 items into list
                AddItemsToListHelper(list, new string[] {"Raisa Pokrovskaya", "425-555-0163",
                    "raisa@outlook.com", "55", date.ToString("D") });
                AddItemsToListHelper(list, new string[] {"Francis Totten", "313-555-0100",
                    "francis@contoso.com", "42", date.AddDays(1).ToString("D") });

                // use Fakes shims only if emulation is enabled
                if (emulatorMode == EmulationMode.Enabled)
                {
                    var sList = new ShimSPList(list);

                    sList.GetItemsSPQuery = (query) =>
                    {
                        var shim = new ShimSPListItemCollection();
                        shim.Bind(new[] { list.Items[0] });
                        return shim.Instance;
                    }
                }

                // Act
                string result = webPart.GetAppointmentsForToday(list.Title, site.RootWeb);
                list.Delete();

                // Assert
                Assert.IsTrue(result.Contains(String.Format(
                    "Name: Raisa Pokrovskaya, Phone: 425-555-0163, Email: raisa@outlook.com," +
                    "Age: 55, Date: {0}", date.ToString("D"))));
                Assert.IsFalse(result.Contains("Name: Francis Totten"));
            }
        }

        ...// More tests

    }
}
```

##  <a name="BKMK_Emulated_SharePoint_types"></a> Emulated SharePoint types

 <xref:Microsoft.SharePoint.SPField?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFieldIndex?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFieldIndexCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFieldLink?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFieldLinkCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFieldUrlValue?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFile?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFileCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFolder?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPFolderCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPItem?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPItemEventDataCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPItemEventProperties?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPList?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPListCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPListEventProperties?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPListItem?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPListItemCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPQuery?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPRoleAssignment?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPRoleAssignmentCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPSecurableObject?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPSecurity?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPSite?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPUser?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPUserCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPView?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPViewCollection?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPViewContext?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPWeb?displayProperty=nameWithType>

 <xref:Microsoft.SharePoint.SPWebCollection?displayProperty=nameWithType>

## See also

- [Unit test your code](../test/unit-test-your-code.md)
- [Test SharePoint 2010 applications with coded UI tests](../test/testing-sharepoint-2010-applications-with-coded-ui-tests.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
