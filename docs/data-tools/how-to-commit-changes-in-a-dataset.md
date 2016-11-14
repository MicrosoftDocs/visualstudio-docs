---
title: "How to: Commit Changes in a Dataset | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DataSet.AcceptChanges"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "datasets [Visual Basic], committing changes"
ms.assetid: 51931353-4d22-4e35-a9ef-6f2b44e1f7d9
caps.latest.revision: 17
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
# How to: Commit Changes in a Dataset
As you make changes to records in a dataset by updating, inserting, and deleting records, the dataset maintains original and current versions of the records. In addition, each row's <xref:System.Data.DataRow.RowState%2A> property keeps track of whether the records are in their original state or have been updated, inserted, or deleted. This information is useful when you need to find a particular version of a row. Typically, you would get a subset of all changed records to send to another process. For more information, see [How to: Retrieve Changed Rows](../Topic/How%20to:%20Retrieve%20Changed%20Rows.md). After you have processed all the changed rows, you can commit the changes by calling the `AcceptChanges` method of the <xref:System.Data.DataSet>, <xref:System.Data.DataTable>, or <xref:System.Data.DataRow>. The `AcceptChanges` method is called automatically when calling the update methods of a [TableAdapter](../data-tools/tableadapter-overview.md) or data adapter. Call `AcceptChanges` after submitting changes to a database.  
  
 When you call <xref:System.Data.DataSet.AcceptChanges%2A> on the <xref:System.Data.DataSet>, any <xref:System.Data.DataRow> objects still in edit mode successfully end their edits. The <xref:System.Data.DataRow.RowState%2A> property of each <xref:System.Data.DataRow> also changes; <xref:System.Data.DataRowState> and <xref:System.Data.DataRowState> rows become <xref:System.Data.DataRowState>, and <xref:System.Data.DataRowState> rows are removed.  
  
 If the <xref:System.Data.DataSet> contains <xref:System.Data.ForeignKeyConstraint> objects, invoking the <xref:System.Data.DataSet.AcceptChanges%2A> method also causes the <xref:System.Data.AcceptRejectRule> to be enforced.  
  
### To commit changes in a dataset  
  
-   Call the `AcceptChanges` method on either a <xref:System.Data.DataSet>, <xref:System.Data.DataTable>, or <xref:System.Data.DataRow> to commit the changes in those objects.  
  
     The following example shows how to call the `AcceptChanges` method to commit changes in the `Customers` table after updating a data source:  
  
     [!code-cs[VbRaddataEditing#11](../data-tools/codesnippet/CSharp/how-to-commit-changes-in-a-dataset_1.cs)]
     [!code-vb[VbRaddataEditing#11](../data-tools/codesnippet/VisualBasic/how-to-commit-changes-in-a-dataset_1.vb)]  
  
## See Also  
 <xref:System.Data.DataSet.AcceptChanges%2A?displayProperty=fullName>   
 <xref:System.Data.DataTable.AcceptChanges%2A?displayProperty=fullName>   
 <xref:System.Data.DataRow.AcceptChanges%2A?displayProperty=fullName>   
 [Saving Data](../data-tools/saving-data.md)   
 [How to: Retrieve Changed Rows](../Topic/How%20to:%20Retrieve%20Changed%20Rows.md)