---
title: "How to: Create TableAdapter Queries"
ms.custom: na
ms.date: 10/01/2016
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
ms.assetid: df0cf4a5-e9cc-4de6-8b94-ce74fb7b2452
caps.latest.revision: 20
manager: ghogen
robots: noindex,nofollow
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create TableAdapter Queries
TableAdapter queries are SQL statements or stored procedures that your application can execute against a database.  
  
 Add as many queries to a TableAdapter as your application requires. TableAdapter queries appear as methods on a TableAdapter. When you create a query called `FillByCity` that takes a parameter representing the city value, the query is added to the TableAdapter. It is added as a typed method that takes the correct type of parameter as an argument — in this case a string representing the city value. You call the TableAdapter query just like any method on any object. For example, the following code executes the `FillByCity` query and fills the `Customers` table with all customers with a city value of `Seattle`:  
  
 [!CODE [VbRaddataTableAdapters#1](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataTableAdapters#1)]  
  
 TableAdapter queries can fill a data table (`Fill` and `FillBy` queries) or return new data tables populated with the data returned by the query (`GetData` and `GetDataBy` queries).  
  
 You can add queries to existing TableAdapters by running the [Editing TableAdapters](../VS_raddata/Editing-TableAdapters.md). (Right-click any TableAdapter and choose **Add Query**.)  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
## Create a query in the Dataset Designer  
  
#### To add a query to a TableAdapter in the Dataset Designer  
  
1.  Open a dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Right-click the desired TableAdapter, and select **Add Query**.  
  
     -or-  
  
3.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto a table on the designer.  
  
     The **TableAdapter Query Configuration Wizard** opens.  
  
4.  Complete the wizard; the query is added to the TableAdapter.  
  
## Create a Query Directly on a Form in Your Windows Application  
 If you have an instance of a TableAdapter on your form you can add a query using the [Search Criteria Builder Dialog Box](../Topic/Search%20Criteria%20Builder%20Dialog%20Box.md), which adds a <xref:System.Windows.Forms.ToolStrip?qualifyHint=False> control to the form that accepts any input parameters required by the query, as well as a button to run the query.  
  
#### To add a query to a TableAdapter using the Search Criteria dialog box  
  
1.  Select a TableAdapter in the component tray.  
  
2.  Click the TableAdapter's smart tag, and choose **Add Query**.  
  
3.  Complete the dialog box and the query is added to the TableAdapter. For more information, see [Search Criteria Builder Dialog Box](../Topic/Search%20Criteria%20Builder%20Dialog%20Box.md).  
  
## See Also  
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)   
 [How to: Edit TableAdapter Queries](../VS_raddata/How-to--Edit-TableAdapter-Queries.md)   
 [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md)   
 [Add new data sources](../VS_raddata/Add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../VS_raddata/How-to--Connect-to-Data-in-a-Database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](../Topic/How%20to:%20Navigate%20Data%20with%20the%20Windows%20Forms%20BindingNavigator%20Control.md)   
 [Walkthrough: Displaying Data on a Windows Form](../VS_raddata/Walkthrough--Displaying-Data-on-a-Windows-Form.md)   
 [Walkthrough: Creating a TableAdapter with Multiple Queries](../VS_raddata/Walkthrough--Creating-a-TableAdapter-with-Multiple-Queries.md)