---
title: "How to: Get Specific Versions of a DataRow"
ms.custom: na
ms.date: 09/17/2016
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
ms.assetid: d7cde25e-cef5-4559-b994-be00e258ac1f
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
# How to: Get Specific Versions of a DataRow
When changes are made to data rows, the dataset retains both the original (<xref:System.Data.DataRowVersion?qualifyHint=False>) and new (<xref:System.Data.DataRowVersion?qualifyHint=False>) versions of the row. For example, before calling the `AcceptChanges` method, your application can access the different versions of a record (as defined in the <xref:System.Data.DataRowVersion?qualifyHint=False> enumeration) and process the changes accordingly.  
  
> [!NOTE]
>  Different versions of a row exist only after it has been edited and before it has had the `AcceptChanges` method called. After the `AcceptChanges` method has been called, the current and original versions are the same.  
  
 Passing the <xref:System.Data.DataRowVersion?qualifyHint=False> value along with the column index (or column name as a string) returns the value from that column's particular row version. The changed column is identified during the <xref:System.Data.DataTable.ColumnChanging?qualifyHint=False> and <xref:System.Data.DataTable.ColumnChanged?qualifyHint=False> events, so that is a good time to inspect the differing row versions for validation purposes. However, if you have temporarily suspended constraints, those events will not be raised and you will need to programmatically identify which columns have changed. You can do this by iterating through the <xref:System.Data.DataTable.Columns?qualifyHint=False> collection and comparing the different <xref:System.Data.DataRowVersion?qualifyHint=False> values.  
  
## Accessing the Original Version of a DataRow  
  
#### To get the original version of a record  
  
-   Access the value of a column passing in the <xref:System.Data.DataRowVersion?qualifyHint=False> of the row you want to return.  
  
     The following example shows how you can use a <xref:System.Data.DataRowVersion?qualifyHint=False> value to get the original value of a `CompanyName` field in a <xref:System.Data.DataRow?qualifyHint=False>:  
  
     [!CODE [VbRaddataEditing#21](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataEditing#21)]  
  
## Accessing the Current Version of a DataRow  
  
#### To get the current version of a record  
  
-   Access the value of a column and add a parameter to the index indicating which version of a row you want to return.  
  
     The following example shows how you can use a <xref:System.Data.DataRowVersion?qualifyHint=False> value to get the current value of a `CompanyName` field in a <xref:System.Data.DataRow?qualifyHint=False>:  
  
     [!CODE [VbRaddataEditing#22](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataEditing#22)]  
  
## See Also  
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [Overview of Data Applications in Visual Studio](../VS_raddata/Overview-of-Data-Applications-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)