---
title: "How to: Commit Changes in a Dataset"
ms.custom: na
ms.date: 09/16/2016
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
ms.assetid: 51931353-4d22-4e35-a9ef-6f2b44e1f7d9
caps.latest.revision: 17
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
# How to: Commit Changes in a Dataset
As you make changes to records in a dataset by updating, inserting, and deleting records, the dataset maintains original and current versions of the records. In addition, each row's <xref:System.Data.DataRow.RowState?qualifyHint=False> property keeps track of whether the records are in their original state or have been updated, inserted, or deleted. This information is useful when you need to find a particular version of a row. Typically, you would get a subset of all changed records to send to another process. For more information, see [How to: Retrieve Changed Rows](../Topic/How%20to:%20Retrieve%20Changed%20Rows.md). After you have processed all the changed rows, you can commit the changes by calling the `AcceptChanges` method of the <xref:System.Data.DataSet?qualifyHint=False>, <xref:System.Data.DataTable?qualifyHint=False>, or <xref:System.Data.DataRow?qualifyHint=False>. The `AcceptChanges` method is called automatically when calling the update methods of a [TableAdapter](../VS_raddata/TableAdapter-Overview.md) or data adapter. Call `AcceptChanges` after submitting changes to a database.  
  
 When you call <xref:System.Data.DataSet.AcceptChanges?qualifyHint=False> on the <xref:System.Data.DataSet?qualifyHint=False>, any <xref:System.Data.DataRow?qualifyHint=False> objects still in edit mode successfully end their edits. The <xref:System.Data.DataRow.RowState?qualifyHint=False> property of each <xref:System.Data.DataRow?qualifyHint=False> also changes; <xref:System.Data.DataRowState?qualifyHint=False> and <xref:System.Data.DataRowState?qualifyHint=False> rows become <xref:System.Data.DataRowState?qualifyHint=False>, and <xref:System.Data.DataRowState?qualifyHint=False> rows are removed.  
  
 If the <xref:System.Data.DataSet?qualifyHint=False> contains <xref:System.Data.ForeignKeyConstraint?qualifyHint=False> objects, invoking the <xref:System.Data.DataSet.AcceptChanges?qualifyHint=False> method also causes the <xref:System.Data.AcceptRejectRule?qualifyHint=False> to be enforced.  
  
### To commit changes in a dataset  
  
-   Call the `AcceptChanges` method on either a <xref:System.Data.DataSet?qualifyHint=False>, <xref:System.Data.DataTable?qualifyHint=False>, or <xref:System.Data.DataRow?qualifyHint=False> to commit the changes in those objects.  
  
     The following example shows how to call the `AcceptChanges` method to commit changes in the `Customers` table after updating a data source:  
  
     [!CODE [VbRaddataEditing#11](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataEditing#11)]  
  
## See Also  
 <xref:System.Data.DataSet.AcceptChanges?qualifyHint=True>   
 <xref:System.Data.DataTable.AcceptChanges?qualifyHint=True>   
 <xref:System.Data.DataRow.AcceptChanges?qualifyHint=True>   
 [Saving Data](../VS_raddata/Saving-Data.md)   
 [How to: Retrieve Changed Rows](../Topic/How%20to:%20Retrieve%20Changed%20Rows.md)