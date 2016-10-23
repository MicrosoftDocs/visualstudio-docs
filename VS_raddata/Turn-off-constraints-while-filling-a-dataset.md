---
title: "Turn off constraints while filling a dataset"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: 553f7d0c-2faa-4c17-b226-dd02855bf1dc
caps.latest.revision: 18
manager: ghogen
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
# Turn off constraints while filling a dataset
If a dataset contains constraints (such as foreign-key constraints),theycan raise errors  related to the order of operations that are performed against the dataset. For example, loading child records before loadingrelated parent records can violate a constraint and cause an error. As soon as you load a child record, the constraint checks for the related parent record and raises an error.  
  
 If there were no mechanism to allow temporary constraint suspension, an error would be raised every time you tried to load a record into the child table. Another way to suspend all constraints in a dataset is with the <xref:System.Data.DataRow.BeginEdit?qualifyHint=False>, and <xref:System.Data.DataRow.EndEdit?qualifyHint=False> properties.  
  
> [!NOTE]
>  Validation events (for example, <xref:System.Data.DataTable.ColumnChanging?qualifyHint=False> and<xref:System.Data.DataTable.RowChanging?qualifyHint=False>) will not be raised when constraints are turned off.  
  
### To suspend update constraints programmatically  
  
-   The following example shows how to temporarily turn off constraint checking in a dataset:  
  
     [!CODE [VbRaddataEditing#10](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataEditing#10)]  
  
### To suspend update constraints using the Dataset Designer  
  
1.  Open your dataset in the [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md). For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  In the **Properties** window, set the <xref:System.Data.DataSet.EnforceConstraints?qualifyHint=False> property to `false`.  
  
## See Also  
 [Fill datasets by using TableAdapters](../VS_raddata/Fill-datasets-by-using-TableAdapters.md)   
 [Relationships in datasets](../VS_raddata/Relationships-in-datasets.md)