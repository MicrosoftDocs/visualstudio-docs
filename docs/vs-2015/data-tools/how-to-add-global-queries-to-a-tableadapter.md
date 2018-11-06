---
title: "How to: Add Global Queries to a TableAdapter | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "global functions, datasets"
  - "scalar functions, datasets"
  - "TableAdapters, global queries"
  - "data [Visual Studio], TableAdapters"
  - "datasets [Visual Basic], scalar functions"
  - "TableAdapter Query Configuration Wizard"
  - "datasets [Visual Basic], global functions"
  - "TableAdapter queries"
  - "queries [Visual Studio], TableAdapters"
ms.assetid: 4abffd6b-2e9f-4ef3-99b2-6e9ae4ad4679
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Add Global Queries to a TableAdapter
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

*Global queries* are SQL queries that return either a single (scalar) value or no value. Typically, global functions perform database operations such as inserts, updates, deletes, and the aggregating of information, such as returning a count of customers in a table or the total charges for all items in a particular order.  
  
 You add global queries by running the **TableAdapter Query Configuration Wizard** from within the **Dataset Designer**.  
  
 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
### To add a global query to a dataset  
  
1.  Open a dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](http://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).  
  
2.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto an empty area of the **Dataset Designer**.  
  
     The [Editing TableAdapters](../data-tools/editing-tableadapters.md) opens.  
  
3.  Choose a connection for the query to use. You can either choose one from the list or create a new connection. If you create a new connection, you will have the option to save it to the application configuration file. For more information, see [How to: Save and Edit Connection Strings](~/E:/Repos/visualstudio-docs-pr/docs/data-tools/how-to-save-and-edit-connection-strings.md).  
  
4.  Choose whether to use SQL statements or stored procedures.  
  
5.  Choose the stored procedure to use or, on the **Choose a Query Type** page of the wizard, choose the type of query you want and then click **Next**.  
  
6.  Provide a query that performs the desired task, for example, `SELECT COUNT(*) AS CustomerCount FROM Customers`.  
  
    > [!NOTE]
    >  Dragging a query directly onto the **Dataset Designer** creates a method that will only return a scalar (single) value. While the query or stored procedure you select may return more than a single value, the method created by the wizard will only return a single value. For example, the query might return the first column of the first row of the returned data.  
  
7.  Complete the wizard; the query is added to the **Dataset Designer**. For information on running the query, see [How to: Execute TableAdapter Queries](http://msdn.microsoft.com/library/c7518855-f896-41c1-b3de-1a8116280593).  
  
## See Also  
 [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md)   
 [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](http://msdn.microsoft.com/library/0e5d4f34-bc9b-47cf-9b8d-93acbb1f1dbb)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)