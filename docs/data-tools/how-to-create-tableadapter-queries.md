---
title: "How to: Create TableAdapter Queries | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
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
  - "TableAdapters, creating queries"
  - "queries [Visual Studio], creating"
  - "data [Visual Studio], TableAdapter queries"
  - "queries [Visual Studio], TableAdapters"
ms.assetid: df0cf4a5-e9cc-4de6-8b94-ce74fb7b2452
caps.latest.revision: 20
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
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
# How to: Create TableAdapter Queries
TableAdapter queries are SQL statements or stored procedures that your application can execute against a database.  
  
 Add as many queries to a TableAdapter as your application requires. TableAdapter queries appear as methods on a TableAdapter. When you create a query called `FillByCity` that takes a parameter representing the city value, the query is added to the TableAdapter. It is added as a typed method that takes the correct type of parameter as an argument — in this case a string representing the city value. You call the TableAdapter query just like any method on any object. For example, the following code executes the `FillByCity` query and fills the `Customers` table with all customers with a city value of `Seattle`:  
  
 [!code-vb[VbRaddataTableAdapters#1](../data-tools/codesnippet/VisualBasic/how-to-create-tableadapter-queries_1.vb)]
 [!code-cs[VbRaddataTableAdapters#1](../data-tools/codesnippet/CSharp/how-to-create-tableadapter-queries_1.cs)]  
  
 TableAdapter queries can fill a data table (`Fill` and `FillBy` queries) or return new data tables populated with the data returned by the query (`GetData` and `GetDataBy` queries).  
  
 You can add queries to existing TableAdapters by running the [Editing TableAdapters](../data-tools/editing-tableadapters.md). (Right-click any TableAdapter and choose **Add Query**.)  
  
 [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
## Create a query in the Dataset Designer  
  
#### To add a query to a TableAdapter in the Dataset Designer  
  
1.  Open a dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Right-click the desired TableAdapter, and select **Add Query**.  
  
     -or-  
  
3.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto a table on the designer.  
  
     The **TableAdapter Query Configuration Wizard** opens.  
  
4.  Complete the wizard; the query is added to the TableAdapter.  
  
## Create a Query Directly on a Form in Your Windows Application  
 If you have an instance of a TableAdapter on your form you can add a query using the [Search Criteria Builder Dialog Box](../Topic/Search%20Criteria%20Builder%20Dialog%20Box.md), which adds a <xref:System.Windows.Forms.ToolStrip> control to the form that accepts any input parameters required by the query, as well as a button to run the query.  
  
#### To add a query to a TableAdapter using the Search Criteria dialog box  
  
1.  Select a TableAdapter in the component tray.  
  
2.  Click the TableAdapter's smart tag, and choose **Add Query**.  
  
3.  Complete the dialog box and the query is added to the TableAdapter. For more information, see [Search Criteria Builder Dialog Box](../Topic/Search%20Criteria%20Builder%20Dialog%20Box.md).  
  
## See Also  
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [How to: Edit TableAdapter Queries](../data-tools/how-to-edit-tableadapter-queries.md)   
 [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](../Topic/How%20to:%20Navigate%20Data%20with%20the%20Windows%20Forms%20BindingNavigator%20Control.md)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)   
 [Walkthrough: Creating a TableAdapter with Multiple Queries](../data-tools/walkthrough-creating-a-tableadapter-with-multiple-queries.md)