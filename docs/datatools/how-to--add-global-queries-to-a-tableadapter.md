---
title: "How to: Add Global Queries to a TableAdapter"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
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
# How to: Add Global Queries to a TableAdapter
*Global queries* are SQL queries that return either a single (scalar) value or no value. Typically, global functions perform database operations such as inserts, updates, deletes, and the aggregating of information, such as returning a count of customers in a table or the total charges for all items in a particular order.  
  
 You add global queries by running the **TableAdapter Query Configuration Wizard** from within the **Dataset Designer**.  
  
 [!INCLUDE[note_settings_general](../datatools/includes/note_settings_general_md.md)]  
  
### To add a global query to a dataset  
  
1.  Open a dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto an empty area of the **Dataset Designer**.  
  
     The [Editing TableAdapters](../datatools/editing-tableadapters.md) opens.  
  
3.  Choose a connection for the query to use. You can either choose one from the list or create a new connection. If you create a new connection, you will have the option to save it to the application configuration file. For more information, see [How to: Save and Edit Connection Strings](../Topic/How%20to:%20Save%20and%20Edit%20Connection%20Strings.md).  
  
4.  Choose whether to use SQL statements or stored procedures.  
  
5.  Choose the stored procedure to use or, on the **Choose a Query Type** page of the wizard, choose the type of query you want and then click **Next**.  
  
6.  Provide a query that performs the desired task, for example, `SELECT COUNT(*) AS CustomerCount FROM Customers`.  
  
    > [!NOTE]
    >  Dragging a query directly onto the **Dataset Designer** creates a method that will only return a scalar (single) value. While the query or stored procedure you select may return more than a single value, the method created by the wizard will only return a single value. For example, the query might return the first column of the first row of the returned data.  
  
7.  Complete the wizard; the query is added to the **Dataset Designer**. For information on running the query, see [How to: Execute TableAdapter Queries](../Topic/How%20to:%20Execute%20TableAdapter%20Queries.md).  
  
## See Also  
 [Create and configure TableAdapters](../datatools/create-and-configure-tableadapters.md)   
 [How to: Create TableAdapter Queries](../datatools/how-to--create-tableadapter-queries.md)   
 [Bind Windows Forms controls to data in Visual Studio](../datatools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [TableAdapter Overview](../datatools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../datatools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../datatools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../datatools/how-to--connect-to-data-in-a-database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](../Topic/How%20to:%20Navigate%20Data%20with%20the%20Windows%20Forms%20BindingNavigator%20Control.md)   
 [Walkthrough: Displaying Data on a Windows Form](../datatools/walkthrough--displaying-data-on-a-windows-form.md)