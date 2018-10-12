---
title: "How to: Get Specific Versions of a DataRow | Microsoft Docs"
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
  - "row states"
  - "updating datasets, row states"
  - "DataRow object"
ms.assetid: d7cde25e-cef5-4559-b994-be00e258ac1f
caps.latest.revision: 16
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Get Specific Versions of a DataRow
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When changes are made to data rows, the dataset retains both the original (<xref:System.Data.DataRowVersion>) and new (<xref:System.Data.DataRowVersion>) versions of the row. For example, before calling the `AcceptChanges` method, your application can access the different versions of a record (as defined in the <xref:System.Data.DataRowVersion> enumeration) and process the changes accordingly.  
  
> [!NOTE]
>  Different versions of a row exist only after it has been edited and before it has had the `AcceptChanges` method called. After the `AcceptChanges` method has been called, the current and original versions are the same.  
  
 Passing the <xref:System.Data.DataRowVersion> value along with the column index (or column name as a string) returns the value from that column's particular row version. The changed column is identified during the <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.ColumnChanged> events, so that is a good time to inspect the differing row versions for validation purposes. However, if you have temporarily suspended constraints, those events will not be raised and you will need to programmatically identify which columns have changed. You can do this by iterating through the <xref:System.Data.DataTable.Columns%2A> collection and comparing the different <xref:System.Data.DataRowVersion> values.  
  
## Accessing the Original Version of a DataRow  
  
#### To get the original version of a record  
  
-   Access the value of a column passing in the <xref:System.Data.DataRowVersion> of the row you want to return.  
  
     The following example shows how you can use a <xref:System.Data.DataRowVersion> value to get the original value of a `CompanyName` field in a <xref:System.Data.DataRow>:  
  
     [!code-csharp[VbRaddataEditing#21](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#21)]
     [!code-vb[VbRaddataEditing#21](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#21)]  
  
## Accessing the Current Version of a DataRow  
  
#### To get the current version of a record  
  
-   Access the value of a column and add a parameter to the index indicating which version of a row you want to return.  
  
     The following example shows how you can use a <xref:System.Data.DataRowVersion> value to get the current value of a `CompanyName` field in a <xref:System.Data.DataRow>:  
  
     [!code-csharp[VbRaddataEditing#22](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#22)]
     [!code-vb[VbRaddataEditing#22](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#22)]  
  
## See Also  
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)   
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Overview of Data Applications in Visual Studio](../data-tools/overview-of-data-applications-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)