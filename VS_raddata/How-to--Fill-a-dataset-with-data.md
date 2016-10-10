---
title: "How to: Fill a dataset with data"
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
ms.assetid: 7ab436d4-54ba-4621-902f-3f193279e18c
caps.latest.revision: 16
manager: ghogen
robots: noindex,nofollow
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
# How to: Fill a dataset with data
The phrase "filling a dataset with data" refers to loading data into the individual <xref:System.Data.DataTable?qualifyHint=False> objects that make up the dataset. You fill the data tables by executing TableAdapter queries or by executing data adapter (for example, <xref:System.Data.SqlClient.SqlDataAdapter?qualifyHint=False>) commands.  
  
 Whether you should use TableAdapters or data adapters depends on how you created the dataset. If you used the design tools in Visual Studio, such as the [Data Source Configuration Wizard](../VS_raddata/media/Data-Source-Configuration-Wizard.png), your dataset contains TableAdapters. For more information on TableAdapters, see [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md). If you created your dataset programmatically, you will typically need to create data adapters to load data into the data tables.  
  
> [!NOTE]
>  When dragging items from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto a form, the code to fill the data table with data is automatically added to the `Form_Load` event handler. Open your form in the code editor to see the exact syntax to fill your specific tables. If you do not want to fill the table when the form loads, you can move this code to some other method, or remove it entirely.  
  
## Filling a Dataset Using a TableAdapter  
 You can call a query on the TableAdapter to load data into data tables in a dataset. Pass the <xref:System.Data.DataTable?qualifyHint=False> you want to fill to the TableAdapter query. If your query takes parameters, pass those to the method as well. If the dataset contains multiple tables, you should have separate TableAdapters for each table and must therefore fill each table separately.  
  
> [!NOTE]
>  By default, every time you execute a TableAdapter query, the data in the table is cleared prior to the results of the query being loaded into the table. You can keep the existing data in the table and append the results by setting the TableAdapter's `ClearBeforeFill` property to `false`.  
  
#### To fill a dataset with data using a TableAdapter  
  
1.  Open your form or component in the **Code Editor**.  
  
2.  Add code anywhere in your application where you need to load a data table with data. If your query does not take parameters, pass in the <xref:System.Data.DataTable?qualifyHint=False> you want to fill. The code should look similar to the following:  
  
     [!CODE [VbRaddataFillingAndExecuting#4](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting#4)]  
  
3.  If your query takes parameters, pass in the <xref:System.Data.DataTable?qualifyHint=False> you want to fill and the parameters expected by the query. Depending on the actual parameters in your query, the code would look similar to the following examples:  
  
     [!CODE [VbRaddataFillingAndExecuting#5](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting#5)]  
  
## Filling a Dataset Using a DataAdapter  
 You call the data adapter's `Fill` method. This causes the adapter to execute the SQL statement or stored procedure referenced in its `SelectCommand` property and put the results into a table in the dataset. If the dataset contains multiple tables, you should have separate data adapters for each table and must therefore fill each table separately.  
  
#### To fill a dataset with data using a DataAdapter  
  
-   Call the <xref:System.Data.Common.DataAdapter.Fill?qualifyHint=False> method of the <xref:System.Data.Common.DataAdapter?qualifyHint=False>, passing in the <xref:System.Data.DataSet?qualifyHint=False> or <xref:System.Data.DataTable?qualifyHint=False> to load the data into. For example:  
  
     [!CODE [VbRaddataFillingAndExecuting#6](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataFillingAndExecuting#6)]  
  
     You should typically provide the name of the <xref:System.Data.DataTable?qualifyHint=False> to load the data into. If you pass in the name of a <xref:System.Data.DataSet?qualifyHint=False> instead of a specific data table, a <xref:System.Data.DataTable?qualifyHint=False> named `Table1` is added to the dataset and loaded with the results from the database (as opposed to loading the data in an existing <xref:System.Data.DataTable?qualifyHint=False> in the dataset). For more information, see [Populating a DataSet from a DataAdapter](../Topic/Populating%20a%20DataSet%20from%20a%20DataAdapter.md).  
  
## See Also  
 [Fill datasets by using TableAdapters](../VS_raddata/Fill-datasets-by-using-TableAdapters.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)