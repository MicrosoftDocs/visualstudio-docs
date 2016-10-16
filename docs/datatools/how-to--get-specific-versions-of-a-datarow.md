---
title: "How to: Get Specific Versions of a DataRow"
ms.custom: na
ms.date: "09/17/2016"
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
  - "row states"
  - "updating datasets, row states"
  - "DataRow object"
ms.assetid: d7cde25e-cef5-4559-b994-be00e258ac1f
caps.latest.revision: 16
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
# How to: Get Specific Versions of a DataRow
When changes are made to data rows, the dataset retains both the original (\<xref:System.Data.DataRowVersion>) and new (\<xref:System.Data.DataRowVersion>) versions of the row. For example, before calling the `AcceptChanges` method, your application can access the different versions of a record (as defined in the \<xref:System.Data.DataRowVersion> enumeration) and process the changes accordingly.  
  
> [!NOTE]
>  Different versions of a row exist only after it has been edited and before it has had the `AcceptChanges` method called. After the `AcceptChanges` method has been called, the current and original versions are the same.  
  
 Passing the \<xref:System.Data.DataRowVersion> value along with the column index (or column name as a string) returns the value from that column's particular row version. The changed column is identified during the \<xref:System.Data.DataTable.ColumnChanging> and \<xref:System.Data.DataTable.ColumnChanged> events, so that is a good time to inspect the differing row versions for validation purposes. However, if you have temporarily suspended constraints, those events will not be raised and you will need to programmatically identify which columns have changed. You can do this by iterating through the \<xref:System.Data.DataTable.Columns*> collection and comparing the different \<xref:System.Data.DataRowVersion> values.  
  
## Accessing the Original Version of a DataRow  
  
#### To get the original version of a record  
  
-   Access the value of a column passing in the \<xref:System.Data.DataRowVersion> of the row you want to return.  
  
     The following example shows how you can use a \<xref:System.Data.DataRowVersion> value to get the original value of a `CompanyName` field in a \<xref:System.Data.DataRow>:  
  
     [!code[VbRaddataEditing#21](../datatools/codesnippet/CSharp/how-to--get-specific-versions-of-a-datarow_1.cs)]
[!code[VbRaddataEditing#21](../datatools/codesnippet/VisualBasic/how-to--get-specific-versions-of-a-datarow_1.vb)]  
  
## Accessing the Current Version of a DataRow  
  
#### To get the current version of a record  
  
-   Access the value of a column and add a parameter to the index indicating which version of a row you want to return.  
  
     The following example shows how you can use a \<xref:System.Data.DataRowVersion> value to get the current value of a `CompanyName` field in a \<xref:System.Data.DataRow>:  
  
     [!code[VbRaddataEditing#22](../datatools/codesnippet/CSharp/how-to--get-specific-versions-of-a-datarow_2.cs)]
[!code[VbRaddataEditing#22](../datatools/codesnippet/VisualBasic/how-to--get-specific-versions-of-a-datarow_2.vb)]  
  
## See Also  
 [Editing Data in Your Application](../datatools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../datatools/saving-data.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../datatools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Overview of Data Applications in Visual Studio](../datatools/overview-of-data-applications-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../datatools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../datatools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../datatools/bind-controls-to-data-in-visual-studio.md)