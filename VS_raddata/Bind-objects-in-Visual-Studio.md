---
title: "Bind objects in Visual Studio"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ed743ce6-73af-45e5-a8ff-045eddaccc86
caps.latest.revision: 20
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Bind objects in Visual Studio
Visual Studio provides design-time tools for working with custom objects as the data source in your application. When you want to store data from a database in an object that you bind to UI controls, the recommended approach is to use Entity Framework to generate the class or classes. Entity Frameworkautogenerates all the boilerplate change-tracking code, which means that any changes to the local objects are automatically persisted to the database when you call AcceptChanges on the DbSet object.    For more information, see [Entity Framework Documentation](https://ef.readthedocs.org/en/latest/).  
  
> [!TIP]
>  The approaches to object binding in this article should only be considered if your application is already based on datasets.These approaches can also be used if you are already familiar with datasets, and the data you will be processing is tabular and not too complex or too big. For an even simpler example, involving loading data directly into objects by using a DataReader and manually updating the UI without databinding, see [Create a simple data application by using ADO.NET](../VS_raddata/Create-a-simple-data-application-by-using-ADO.NET.md).  
  
## Object requirements  
 The only requirement for custom objects to work with the data design tools in Visual Studio is that the object needs at least one public property.  
  
 Generally, custom objects do not require any specific interfaces, constructors, or attributes to act as a data source for an application. However, if you want to drag the object from the **Data Sources** window to a design surface to create a data-bound control, and if the object implements the <xref:System.ComponentModel.ITypedList?qualifyHint=False> or <xref:System.ComponentModel.IListSource?qualifyHint=False> interface, the object must have a default constructor. Otherwise, Visual Studio cannot instantiate the data source object, and it displays an error when you drag the item to the design surface.  
  
## Examples of using custom objects as data sources  
 While there are countless ways to implement your application logic when working with objects as a data source, for SQL databases there are a few standard operations that can be simplified by using the Visual Studio–generated TableAdapter objects. This page explains how to implement these standard processes using TableAdapters.It is not intended as a guide for creating your custom objects. For example, you will typically perform the following standard operations regardless of the specific implementation of your objects, or application's logic:  
  
-   Loading data into objects (typically from a database).  
  
-   Creating a typed collection of objects.  
  
-   Adding objects to and removing objects from a collection.  
  
-   Displaying the object data to users on a form.  
  
-   Changing/editing the data in an object.  
  
-   Saving data from objects back to the database.  
  
> [!NOTE]
>  In order to better understand, and provide context for the examples on this page, we suggest that you complete the following: [Walkthrough: Connecting to Data in Objects (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20Objects%20\(Windows%20Forms\).md). That walkthrough creates the objects discussed here.  
  
### Loaddata into objects  
 For this example, you load data into your objects by using TableAdapters. By default, TableAdapters are created with two kinds of methods that fetch data from a database and populate data tables.  
  
-   The `TableAdapter.Fill` method fills an existing data table with the data returned.  
  
-   The `TableAdapter.GetData` method returns a new data table populated with data.  
  
 The easiest way to load your custom objects with data is to call the `TableAdapter.GetData` method, loop through the collection of rows in the returned data table, and populate each object with the values in each row. You can create a `GetData` method that returns a populated data table for any query added to a TableAdapter.  
  
> [!NOTE]
>  Visual Studio names the TableAdapter queries `Fill` and `GetData` by default, but those names can be changed to any valid method name.  
  
 The following example shows how to loop through the rows in a data table, and populate an object with data:  
  
 [!CODE [VbRaddataConnecting#4](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataConnecting#4)]  
  
### Create a typed collection of objects  
 You can create collection classes for your objects, or use the typed collections that are automatically provided by the [BindingSource Component](../Topic/BindingSource%20Component.md).  
  
 When you are creating a custom collection class for objects, we suggest that you inherit from <xref:System.ComponentModel.BindingList`1?qualifyHint=False>. This generic class provides functionality to administer your collection, as well as the ability to raise events that send notifications to the data-binding infrastructure in Windows Forms.  
  
 The automatically-generated collection in the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> uses a <xref:System.ComponentModel.BindingList`1?qualifyHint=False> for its typed collection. If your application does not require additional functionality, then you can maintain your collection within the <xref:System.Windows.Forms.BindingSource?qualifyHint=False>. For more information, see the <xref:System.Windows.Forms.BindingSource.List?qualifyHint=False> property of the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> class.  
  
> [!NOTE]
>  If your collection requires functionality not provided by the base implementation of the <xref:System.ComponentModel.BindingList`1?qualifyHint=False>, you should create a custom collection so you can add to the class as needed.  
  
 The following code shows how to create the class for a strongly-typed collection of `Order` objects:  
  
 [!CODE [VbRaddataConnecting#8](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataConnecting#8)]  
  
### Addobjects to a collection  
 You add objects to a collection by calling the `Add` method of your custom collection class or of the <xref:System.Windows.Forms.BindingSource?qualifyHint=False>.  
  
 For an example of adding to a collection using a <xref:System.Windows.Forms.BindingSource?qualifyHint=False>, see the `LoadCustomers` method in [Walkthrough: Connecting to Data in Objects (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20Objects%20\(Windows%20Forms\).md).  
  
 For an example of adding objects to a custom collection, see the `LoadOrders` method in [Walkthrough: Connecting to Data in Objects (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20Objects%20\(Windows%20Forms\).md).  
  
> [!NOTE]
>  The `Add` method is automatically provided for your custom collection when you inherit from <xref:System.ComponentModel.BindingList`1?qualifyHint=False>.  
  
 The following code shows how to add objects to the typed collection in a <xref:System.Windows.Forms.BindingSource?qualifyHint=False>:  
  
 [!CODE [VbRaddataConnecting#5](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataConnecting#5)]  
  
 The following code shows how to add objects to a typed collection that inherits from <xref:System.ComponentModel.BindingList`1?qualifyHint=False>:  
  
> [!NOTE]
>  In this example the `Orders` collection is a property of the `Customer` object.  
  
 [!CODE [VbRaddataConnecting#6](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataConnecting#6)]  
  
### Removeobjects from a collection  
 You remove objects from a collection by calling the `Remove` or `RemoveAt` method of your custom collection class or of <xref:System.Windows.Forms.BindingSource?qualifyHint=False>.  
  
> [!NOTE]
>  The `Remove` and `RemoveAt` methods are automatically provided for your custom collection when you inherit from <xref:System.ComponentModel.BindingList`1?qualifyHint=False>.  
  
 The following code shows how to locate and remove objects from the typed collection in a <xref:System.Windows.Forms.BindingSource?qualifyHint=False> with the <xref:System.Windows.Forms.BindingSource.RemoveAt?qualifyHint=False> method:  
  
 [!CODE [VbRaddataConnecting#7](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataConnecting#7)]  
  
### Displayobject data to users  
 To display the data in objects to users, create an object data source using the **Data Source Configuration** wizard, and then drag the entire object or individual properties onto your form from the **Data Sources** window.  
  
### Modify the data in objects  
 To edit data in custom objects that are data-bound to Windows Forms controls, simply edit the data in the bound control (or directly in the object's properties). Data-binding architecture updates the data in the object.  
  
 If your application requires the tracking of changes and the rolling back of proposed changes to their original values, then you must implement this functionality in your object model. For examples of how data tables keep track of proposed changes, see <xref:System.Data.DataRowState?qualifyHint=False>, <xref:System.Data.DataSet.HasChanges?qualifyHint=False>, and <xref:System.Data.DataTable.GetChanges?qualifyHint=False>.  
  
### Savedata in objects back to the database  
 Save data back to the database by passing the values from your object to the TableAdapter's DBDirect methods.  
  
 Visual Studio creates DBDirect methods that can be executed directly against the database. These methods do not require DataSet or DataTable objects.  
  
|TableAdapter DBDirect method|Description|  
|----------------------------------|-----------------|  
|`TableAdapter.Insert`|Adds new records to a database, allowing you to pass in individual column values as method parameters.|  
|`TableAdapter.Update`|Updates existing records in a database. The Update method takes original and new column values as method parameters. The original values are used to locate the original record, and the new values are used to update that record.<br /><br /> The `TableAdapter.Update` method is also used to reconcile changes in a dataset back to the database, by taking a <xref:System.Data.DataSet?qualifyHint=False>, <xref:System.Data.DataTable?qualifyHint=False>, <xref:System.Data.DataRow?qualifyHint=False>, or array of <xref:System.Data.DataRow?qualifyHint=False>s as method parameters.|  
|`TableAdapter.Delete`|Deletes existing records from the database based on the original column values passed in as method parameters.|  
  
 To save data from a collection of objects, loop through the collection of objects (for example, using a for-next loop).Send the values for each object to the database by using the TableAdapter's DBDirect methods.  
  
 The following example shows how to use the `TableAdapter.Insert` DBDirect method to add a new customer directly into the database:  
  
 [!CODE [VbRaddataSaving#23](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#23)]  
  
## See Also  
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)