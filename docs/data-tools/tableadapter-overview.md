---
title: "TableAdapter Overview | Microsoft Docs"
ms.custom: ""
ms.date: "10/25/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vbData.Microsoft.VSDesigner.DataSource.DataAccessor"
  - "vbdata.Microsoft.VSDesigner.DataSource.DataAccessor"
  - "TableAdapter"
  - "vs.data.TableAdapter"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "data [Visual Studio], table adapters"
  - "TableAdapters, queries"
  - "data [Visual Studio], TableAdapters"
  - "query data in Visual Studio"
  - "TableAdapter.GetData"
  - "TableAdapter.Fill"
  - "data [Visual Studio], datasets"
  - "TableAdapters"
  - "table adapters"
ms.assetid: a87c46a0-52ab-432a-a864-9ba55069f9eb
caps.latest.revision: 40
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# TableAdapter Overview
TableAdapters are designer-generated components that connect to a database, execute queries or stored procedures, and fill their DataTable with the returned data. TableAdapters are also used to send updated data from your application back to the database. You can have as many queries as you want on a TableAdapter as long as they return data that conforms to the schema of the table with which the TableAdapter is associated. The following diagram shows how TableAdapters interact with databases and other objects in memory:  
  
 ![Data flow in a client application](../data-tools/media/clientdatadiagram.gif "ClientDataDiagram")  
  
 While TableAdapters are designed with the **Dataset Designer**, the TableAdapter classes generated are not generated as nested classes of the <xref:System.Data.DataSet>. They are located in a separate namespace specific to each dataset. For example, if you have a dataset named `NorthwindDataSet`, the TableAdapters associated with the <xref:System.Data.DataTable>s in the `NorthwindDataSet` would be in the `NorthwindDataSetTableAdapters` namespace. To access a particular TableAdapter programmatically, you must declare a new instance of the TableAdapter. For example:  
  
 [!code-cs[VbRaddataTableAdapters#7](../data-tools/codesnippet/CSharp/tableadapter-overview_1.cs)]
 [!code-vb[VbRaddataTableAdapters#7](../data-tools/codesnippet/VisualBasic/tableadapter-overview_1.vb)]  
  
## Associated DataTable Schema  
 When creating a TableAdapter, the initial query or stored procedure is used to define the schema of the TableAdapter's associated <xref:System.Data.DataTable>. You execute this initial query or stored procedure by calling the TableAdapter's `Fill` method (which fills the TableAdapter's associated <xref:System.Data.DataTable>). Any changes made to the TableAdapter's main query are reflected in the schema of the associated data table. For example, removing a column from the main query removes the column from the associated data table. If any additional queries on the TableAdapter use SQL statements returning columns that are not in the main query, then the designer will attempt to synchronize the column changes between the main query and any additional queries. For more information, see [How to: Edit TableAdapters](../Topic/How%20to:%20Edit%20TableAdapters.md).  
  
## TableAdapter Update Commands  
 The update functionality of a TableAdapter is dependent on how much information is available based on the main query provided in the TableAdapter Wizard. For example, TableAdapters that are configured to fetch values from multiple tables (JOINs), scalar values, views, or the results of aggregate functions are not initially created with the ability to send updates back to the underlying database. However, you can configure the INSERT, UPDATE and DELETE commands manually in the **Properties** window.  
  
## TableAdapter Queries  
 ![TableAdapter with multiple queries](../data-tools/media/tableadapter.gif "TableAdapter")  
  
 TableAdapters can contain multiple queries to fill their associated data tables. You can define as many queries for a TableAdapter as your application requires, as long as each query returns data that conforms to the same schema as its associated data table. This enables loading of data that satisfies differing criteria. For example, if your application contains a table of customers, you can create a query that fills the table with every customer whose name begins with a certain letter, and another query that fills the table with all customers located in the same state. To fill a `Customers` table with customers in a given state you can create a `FillByState` query that takes a parameter for the state value: `SELECT * FROM Customers WHERE State = @State`. You execute the query by calling the `FillByState` method and passing in the parameter value like this: `CustomerTableAdapter.FillByState("WA")`. For more information, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md).  
  
 In addition to queries that return data of the same schema as the TableAdapter's data table, you can add queries that return scalar (single) values. For example, creating a query that returns a count of customers (`SELECT Count(*) From Customers`) is valid for a `CustomersTableAdapter` even though the data returned does not conform to the table's schema.  
  
## ClearBeforeFill Property  
 By default, every time you execute a query to fill a TableAdapter's data table, the data is cleared and only the results of the query are loaded into the table. Set the TableAdapter's `ClearBeforeFill` property to `false` if you want to add or merge the data returned from a query to the existing data in a data table. Regardless of whether you clear the data, you need to explicitly send updates back to the database, if desired. So remember to save any changes made to the data in the table before executing another query that fills the table. For more information, see [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md).  
  
## TableAdapter Inheritance  
 TableAdapters extend the functionality of standard data adapters by encapsulating a configured <xref:System.Data.Common.DataAdapter>. By default, the TableAdapter inherits from <xref:System.ComponentModel.Component> and cannot be cast to the <xref:System.Data.Common.DataAdapter> class. Casting a TableAdapter to a <xref:System.Data.Common.DataAdapter> results in an <xref:System.InvalidCastException>. To change the base class of a TableAdapter, you can type a class that derives from <xref:System.ComponentModel.Component> in the **Base Class** property of the TableAdapter in the **Dataset Designer**.  
  
## TableAdapter Methods and Properties  
 The TableAdapter class is not part of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)], and as such you cannot look it up in the documentation or the **Object Browser**. It is created at design time when you use one of the wizards mentioned above. The name assigned to a TableAdapter when you create it is based on the name of the table you are working with. For example, when creating a TableAdapter based on a table in a database named `Orders`, the TableAdapter would be named `OrdersTableAdapter`. The class name of the TableAdapter can be changed using the **Name** property in the **Dataset Designer**.  
  
 The following are the commonly used methods and properties of TableAdapters:  
  
|Member|Description|  
|------------|-----------------|  
|`TableAdapter.Fill`|Populates the TableAdapter's associated data table with the results of the TableAdapter's SELECT command. For more information, see [How to: Fill a dataset with data](../data-tools/how-to-fill-a-dataset-with-data.md).|  
|`TableAdapter.Update`|Sends changes back to the database and returns an integer representing the number of rows affected by the update. For more information, see [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md).|  
|`TableAdapter.GetData`|Returns a new <xref:System.Data.DataTable> filled with data.|  
|`TableAdapter.Insert`|Creates a new row in the data table. For more information, see [How to: Add Rows to a DataTable](../Topic/How%20to:%20Add%20Rows%20to%20a%20DataTable.md).|  
|`TableAdapter.ClearBeforeFill`|Determines whether a data table is emptied before you call one of the `Fill` methods.|  
  
## TableAdapter Update Method  
 TableAdapters use data commands to read to and write from the database. The TableAdapter's initial `Fill` (main) query is used as the basis for creating the schema of the associated data table, as well as the `InsertCommand`, `UpdateCommand`, and `DeleteCommand` commands associated with the `TableAdapter.Update` method. This means that calling a TableAdapter's `Update` method executes the statements created when the TableAdapter was originally configured, and not one of the additional queries added with the **TableAdapter Query Configuration Wizard**.  
  
 When you use a TableAdapter, it effectively performs the same operations with the commands that you typically would perform. For example, when you call the adapter's `Fill` method, the adapter executes the data command in its `SelectCommand` property and uses a data reader (for example, <xref:System.Data.SqlClient.SqlDataReader>) to load the result set into the data table. Similarly, when you call the adapter's `Update` method, it executes the appropriate command (in the `UpdateCommand`, `InsertCommand`, and `DeleteCommand` properties) for each changed record in the data table.  
  
> [!NOTE]
>  If there is enough information in the main query, the `InsertCommand`, `UpdateCommand`, and `DeleteCommand` commands are created by default when the TableAdapter is generated. If the TableAdapter's main query is more than a single table SELECT statement, it is possible the designer will not be able to generate the `InsertCommand`, `UpdateCommand`, and `DeleteCommand`. If these commands are not generated, you may receive an error when executing the `TableAdapter.Update` method.  
  
## TableAdapter GenerateDbDirectMethods  
 In addition to the `InsertCommand`, `UpdateCommand`, and `DeleteCommand`, TableAdapters are created with methods that can be executed directly against the database. These methods (`TableAdapter.Insert`, `TableAdapter.Update`, and `TableAdapter.Delete`) can be called directly to manipulate data in the database. This means you can call these individual methods from your code instead of calling TableAdapter.Update to handle the inserts, updates, and deletes that are pending for the associated data table.  
  
 If you do not want to create these direct methods, set the TableAdapter's **GenerateDbDirectMethods** property to `false` (in the **Properties** window). Additional queries added to the TableAdapter are standalone queries — they do not generate these methods.  
  
## TableAdapter Support for Nullable Types  
 The TableAdapters support nullable types `Nullable(Of T)` and `T?`. For more information on nullable types in Visual Basic, see [Nullable Value Types](/dotnet/visual-basic/programming-guide/language-features/data-types/nullable-value-types). For more information on nullable types in C#, see [Using Nullable Types](/dotnet/csharp/programming-guide/nullable-types/using-nullable-types).  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Walkthrough: Connecting to Data in a Database (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20a%20Database%20\(Windows%20Forms\).md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../data-tools/saving-data.md)