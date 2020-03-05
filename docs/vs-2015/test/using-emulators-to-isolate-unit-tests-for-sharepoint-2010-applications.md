---
title: "Using emulators to isolate unit tests for Sharepoint 2010 applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: b681164c-c87a-4bd7-be48-ed77e1578471
caps.latest.revision: 17
ms.author: jillfra
manager: jillfra
---
# Using emulators to isolate unit tests for Sharepoint 2010 applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Microsoft.SharePoint.Emulators package provides a set of libraries that help you to create isolated unit tests for Microsoft SharePoint 2010 applications. Emulators use [shims](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md) from the [Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md) isolation framework to create lightweight in-memory objects that mimic the most common objects and methods of the SharePoint API. When a SharePoint method is not emulated, or when you want to change the default behavior of an emulator, you can create Fakes shims to provide the results that you want.

 Existing test methods and classes can be easily converted to run in the Emulator context. This capability lets you create dual-use tests. A dual-use test can toggle between integration tests against the real SharePoint API and isolated unit tests that use the emulators.

## <a name="BKMK_In_this_topic"></a> In this topic
 [Requirements](#BKMK_Requirements)

 [The AppointmentsWebPart example](#BKMK_The_AppointmentsWebPart_example)

 [Converting an existing test](#BKMK_Converting_an_existing_test)

- [Adding the Emulators package to a test project](#BKMK_Adding_the_Emulators_package_to_a_test_project)

- [Running a test method with emulation](#BKMK__Running_a_test_method_in_the_emulation_context)

  [Creating dual-use classes and methods](#BKMK_Creating_dual_use_classes_and_methods)

  [Using TestInitialize and TestCleanup attributes to create a dual-use test class](#BKMK_Using_TestInitialize_and_TestCleanup_attributes_to_create_a_dual_use_test_class)

  [Handling non-emulated SharePoint methods](#BKMK_Handling_non_emulated_SharePoint_methods)

  [Writing emulation tests from scratch, and a summary](#BKMK_Writing_emulation_tests_from_scratch__and_a_summary)

  [Example](#BKMK_Example)

  [Emulated SharePoint types](#BKMK_Emulated_SharePoint_types)

## <a name="BKMK_Requirements"></a> Requirements

- Microsoft SharePoint 2010 (SharePoint 2010 Server or SharePoint 2010 Foundation)

- Microsoft Visual Studio Enterprise

- Microsoft SharePoint Emulators NuGet package

  You should also be familiar with the [basics of unit testing in Visual Studio](../test/unit-test-basics.md) and some knowledge of [Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md).

## <a name="BKMK_The_AppointmentsWebPart_example"></a> The AppointmentsWebPart example
 The AppointmentsWebPart lets you view and manage a SharePoint list of your appointments.

 ![Appointments Web Part](../test/media/ut-emulators-appointmentswebpart.png "UT_EMULATORS_AppointmentsWebPart")

 We'll test two methods of the web part in this example:

- The `ScheduleAppointment` method validates the list item values passed to the method and creates a new entry in a list on a specified SharePoint web.

- The `GetAppointmentsForToday` method returns the details of today's appointments.

  [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Converting_an_existing_test"></a> Converting an existing test
 In a typical test of a method in a SharePoint component, the test method creates a temporary site in SharePoint Foundation and adds the SharePoint components to the site that the code under test requires. The test method then creates and exercises an instance of the component. At the end of the test, the site is torn down.

 The `ScheduleAppointment` method of our code under test is probably one of the first methods written for the component:

```
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

 [In this topic](#BKMK_In_this_topic)

### <a name="BKMK_Adding_the_Emulators_package_to_a_test_project"></a> Adding the Emulators package to a test project
 To add the SharePoint emulators to a test project:

1. Select the test project in Solution Explorer.

2. Choose **Manage NuGet Packages ...** on the shortcut menu.

3. Search the **Online** category for `Microsoft.SharePoint.Emulators`, and then choose **Install**.

   ![Sharepoint Emulators NuGet package](../test/media/ut-emulators-nuget.png "UT_EMULATORS_Nuget")

   [In this topic](#BKMK_In_this_topic)

### <a name="BKMK__Running_a_test_method_in_the_emulation_context"></a> Running a test method with emulation
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

 When the test method is executed, the Emulator runtime calls Microsoft Fakes to dynamically inject code into SharePoint methods to divert the calls to these methods to delegates that are declared in Microsoft.SharePoint.Fakes.dll. Microsoft.SharePoint.Emulators.dll implements the delegates for emulated methods, closely mimicking the actual SharePoint behavior. When the test method or the component under test calls a SharePoint method, the behavior that results is that of the emulation.

 ![Emulator execution flow](../test/media/ut-emulators-flowchart.png "UT_EMULATORS_FlowChart")

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Creating_dual_use_classes_and_methods"></a> Creating dual-use classes and methods
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

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Using_TestInitialize_and_TestCleanup_attributes_to_create_a_dual_use_test_class"></a> Using TestInitialize and TestCleanup attributes to create a dual-use test class
 If you run all or most of the tests in a class using `SharePointEmulationScope`, you can take advantage of class-level techniques to set the emulation mode.

- Test class methods that attributed with <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute> and <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute> can create and destroy the scope.

- Setting the `EmulationMode` at the class level can let you automate the mode change between `EmulationMode.Enabled` and `EmulationMode.Passthrough`.

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

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Handling_non_emulated_SharePoint_methods"></a> Handling non-emulated SharePoint methods
 Not all SharePoint types are emulated, and not all methods in some emulated types are emulated. If the code under test calls a SharePoint method that is not emulated, the method throws a `NotSupportedException` exception. When an exception occurs, you add a Fakes shim for the SharePoint method.

 **Setting up Sharepoint Fakes**

 To explicitly call Microsoft Fakes shims:

1. If you want to shim a SharePoint class that is not emulated, edit the Microsoft.SharePoint.fakes file and add the class to the list of shimmed classes. See the [Configuring code generation of stubs and shims](https://msdn.microsoft.com/library/hh708916.aspx#bkmk_configuring_code_generation_of_stubs) section of [Code generation, compilation, and naming conventions in Microsoft Fakes](../test/code-generation-compilation-and-naming-conventions-in-microsoft-fakes.md).

    ![Fakes folder in Solution Explorer](../test/media/ut-emulators-fakesfilefolder.png "UT_EMULATORS_FakesFileFolder")

2. Rebuild the test project at least once after you have installed the Microsoft SharePoint Emulators package and if you have edited the Microsoft.SharePoint.Fakes file. Building the project creates and populates a **FakesAssembly** folder in your on-disk project root folder.

    ![FakesAssembly folder](../test/media/ut-emulators-fakesassemblyfolder.png "UT_EMULATORS_FakesAssemblyFolder")

3. Add a reference to the **Microsoft.SharePoint.14.0.0.0.Fakes.dll** assembly that is located in the **FakesAssembly** folder.

4. (Optional) Add a namespace directive for to the test class for `Microsoft.QualityTools.Testing.Fakes`, `Microsoft.SharePoint.Fakes` and any nested namespace of `Microsoft.SharePoint.Fakes`that you want to use.

   **Implementing the shim delegate for a SharePoint method**

   In our example project, the `GetAppointmentsForToday` method calls the [SPList.GetItems(SPQuery)](https://msdn.microsoft.com/library/ms457534.aspx) SharePoint API method.

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

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Writing_emulation_tests_from_scratch__and_a_summary"></a> Writing emulation tests from scratch, and a summary
 Although the techniques to create emulation and dual-use tests that are described in the previous sections assume that you are converting existing tests, you can also use the techniques to write tests from scratch. The following list summarizes these techniques:

- To use emulators in a test project, add the Microsoft.SharePoint.Emulators NuGet package to the project.

- To use emulators in a test method, create a `SharePointEmulationScope` object at the beginning of the method. All supported SharePoint APIs will be emulated until the scope is disposed.

- Write your test code as if you were writing it against the real SharePoint API. The emulation context automatically detours the calls to SharePoint methods to their emulators.

- Not all SharePoint objects are emulated, and not all methods of some emulated objects are emulated. A `NotSupportedException` exception is thrown when you use a non-emulated object or method. When this occurs, explicitly create a Fakes shim delegate for the method to return the required behavior.

- To create dual-use tests, use the `SharePointEmulationScope(EmulationMode)` constructor to create the emulation scope object. The `EmulationMode` value specifies whether the SharePoint calls are emulated or executed against a real SharePoint site.

- If all or most of your test methods in a test class execute in the emulation context, you can use a class-level `TestInitialize` attributed method to create the `SharePointEmulationScope` object and a class-level field to set the emulation mode. This will help you to automate the changing of the emulation mode. Then use a `TestCleanup` attributed method to dispose of the scope object.

  [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Example"></a> Example
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

## <a name="BKMK_Emulated_SharePoint_types"></a> Emulated SharePoint types
 [Microsoft.SharePoint.SPField](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPField)

 [Microsoft.SharePoint.SPFieldIndex](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFieldIndex)

 [Microsoft.SharePoint.SPFieldIndexCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFieldIndexCollection)

 [Microsoft.SharePoint.SPFieldLink](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFieldLink)

 [Microsoft.SharePoint.SPFieldLinkCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFieldLinkCollection)

 [Microsoft.SharePoint.SPFieldUrlValue](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFieldUrlValue)

 [Microsoft.SharePoint.SPFile](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFile)

 [Microsoft.SharePoint.SPFileCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFileCollection)

 [Microsoft.SharePoint.SPFolder](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFolder)

 [Microsoft.SharePoint.SPFolderCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPFolderCollection)

 [Microsoft.SharePoint.SPItem](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPItem)

 [Microsoft.SharePoint.SPItemEventDataCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPItemEventDataCollection)

 [Microsoft.SharePoint.SPItemEventProperties](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPItemEventProperties)

 [Microsoft.SharePoint.SPList](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPList)

 [Microsoft.SharePoint.SPListCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPListCollection)

 [Microsoft.SharePoint.SPListEventProperties](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPListEventProperties)

 [Microsoft.SharePoint.SPListItem](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPListItem)

 [Microsoft.SharePoint.SPListItemCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPListItemCollection)

 [Microsoft.SharePoint.SPQuery](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPQuery)

 [Microsoft.SharePoint.SPRoleAssignment](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPRoleAssignment)

 [Microsoft.SharePoint.SPRoleAssignmentCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPRoleAssignmentCollection)

 [Microsoft.SharePoint.SPSecurableObject](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPSecurableObject)

 [Microsoft.SharePoint.SPSecurity](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPSecurity)

 [Microsoft.SharePoint.SPSite](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPSite)

 [Microsoft.SharePoint.SPUser](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPUser)

 [Microsoft.SharePoint.SPUserCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPUserCollection)

 [Microsoft.SharePoint.SPView](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPView)

 [Microsoft.SharePoint.SPViewCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPViewCollection)

 [Microsoft.SharePoint.SPViewContext](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPViewContext)

 [Microsoft.SharePoint.SPWeb](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPWeb)

 [Microsoft.SharePoint.SPWebCollection](https://msdn.microsoft.com/library/Microsoft.SharePoint.SPWebCollection)

 [In this topic](#BKMK_In_this_topic)

## See Also
 [Unit Test Your Code](../test/unit-test-your-code.md)
 [Testing SharePoint 2010 Applications with Coded UI Tests](../test/testing-sharepoint-2010-applications-with-coded-ui-tests.md)
 [Web performance and load testing SharePoint 2010 and 2013 applications](https://msdn.microsoft.com/library/20c2e469-0e4e-4296-a739-c0e8fff36e54)
 [Developing SharePoint Solutions](https://msdn.microsoft.com/library/059bce0f-c301-4234-a0b4-9c14b7cdfa3e)
