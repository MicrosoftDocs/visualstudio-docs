---
title: "How to: Fill a dataset with data | Microsoft Docs"
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
  - "TableAdapter.GetData"
  - "TableAdapter.Fill"
  - "datasets [Visual Basic], filling"
  - "DataTable objects, loading"
  - "data [Visual Basic], loading into datasets"
ms.assetid: 7ab436d4-54ba-4621-902f-3f193279e18c
caps.latest.revision: 16
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Fill a dataset with data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The phrase "filling a dataset with data" refers to loading data into the individual <xref:System.Data.DataTable> objects that make up the dataset. You fill the data tables by executing TableAdapter queries or by executing data adapter (for example, <xref:System.Data.SqlClient.SqlDataAdapter>) commands.  
  
 Whether you should use TableAdapters or data adapters depends on how you created the dataset. If you used the design tools in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], such as the [Data Source Configuration Wizard](http://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f), your dataset contains TableAdapters. For more information on TableAdapters, see [TableAdapter Overview](../data-tools/tableadapter-overview.md). If you created your dataset programmatically, you will typically need to create data adapters to load data into the data tables.  
  
> [!NOTE]
>  When dragging items from the [Data Sources Window](http://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992) onto a form, the code to fill the data table with data is automatically added to the `Form_Load` event handler. Open your form in the code editor to see the exact syntax to fill your specific tables. If you do not want to fill the table when the form loads, you can move this code to some other method, or remove it entirely.  
  
## Filling a Dataset Using a TableAdapter  
 You can call a query on the TableAdapter to load data into data tables in a dataset. Pass the <xref:System.Data.DataTable> you want to fill to the TableAdapter query. If your query takes parameters, pass those to the method as well. If the dataset contains multiple tables, you should have separate TableAdapters for each table and must therefore fill each table separately.  
  
> [!NOTE]
>  By default, every time you execute a TableAdapter query, the data in the table is cleared prior to the results of the query being loaded into the table. You can keep the existing data in the table and append the results by setting the TableAdapter's `ClearBeforeFill` property to `false`.  
  
#### To fill a dataset with data using a TableAdapter  
  
1.  Open your form or component in the **Code Editor**.  
  
2.  Add code anywhere in your application where you need to load a data table with data. If your query does not take parameters, pass in the <xref:System.Data.DataTable> you want to fill. The code should look similar to the following:  
  
     [!code-csharp[VbRaddataFillingAndExecuting#4](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/CS/Form2.cs#4)]
     [!code-vb[VbRaddataFillingAndExecuting#4](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/VB/Form2.vb#4)]  
  
3.  If your query takes parameters, pass in the <xref:System.Data.DataTable> you want to fill and the parameters expected by the query. Depending on the actual parameters in your query, the code would look similar to the following examples:  
  
     [!code-csharp[VbRaddataFillingAndExecuting#5](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/CS/Form2.cs#5)]
     [!code-vb[VbRaddataFillingAndExecuting#5](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/VB/Form2.vb#5)]  
  
## Filling a Dataset Using a DataAdapter  
 You call the data adapter's `Fill` method. This causes the adapter to execute the SQL statement or stored procedure referenced in its `SelectCommand` property and put the results into a table in the dataset. If the dataset contains multiple tables, you should have separate data adapters for each table and must therefore fill each table separately.  
  
#### To fill a dataset with data using a DataAdapter  
  
-   Call the <xref:System.Data.Common.DataAdapter.Fill%2A> method of the <xref:System.Data.Common.DataAdapter>, passing in the <xref:System.Data.DataSet> or <xref:System.Data.DataTable> to load the data into. For example:  
  
     [!code-csharp[VbRaddataFillingAndExecuting#6](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/CS/Form2.cs#6)]
     [!code-vb[VbRaddataFillingAndExecuting#6](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting/VB/Form2.vb#6)]  
  
     You should typically provide the name of the <xref:System.Data.DataTable> to load the data into. If you pass in the name of a <xref:System.Data.DataSet> instead of a specific data table, a <xref:System.Data.DataTable> named `Table1` is added to the dataset and loaded with the results from the database (as opposed to loading the data in an existing <xref:System.Data.DataTable> in the dataset). For more information, see [Populating a DataSet from a DataAdapter](http://msdn.microsoft.com/library/3fa0ac7d-e266-4954-bfac-3fbe2f913153).  
  
## See Also  
 [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)