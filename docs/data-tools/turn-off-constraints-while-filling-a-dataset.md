---
title: "Turn off constraints while filling a dataset | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DataRow.BeginEdit"
  - "DataRow.EndEdit"
  - "DataRow.CancelEdit"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "updating datasets, constraints"
  - "constraints [Visual Basic], datasets"
  - "datasets [Visual Basic], constraints"
  - "constraints [Visual Basic], suspending during dataset update"
ms.assetid: 553f7d0c-2faa-4c17-b226-dd02855bf1dc
caps.latest.revision: 18
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
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
# Turn off constraints while filling a dataset
If a dataset contains constraints (such as foreign-key constraints),theycan raise errors  related to the order of operations that are performed against the dataset. For example, loading child records before loadingrelated parent records can violate a constraint and cause an error. As soon as you load a child record, the constraint checks for the related parent record and raises an error.  
  
 If there were no mechanism to allow temporary constraint suspension, an error would be raised every time you tried to load a record into the child table. Another way to suspend all constraints in a dataset is with the <xref:System.Data.DataRow.BeginEdit%2A>, and <xref:System.Data.DataRow.EndEdit%2A> properties.  
  
> [!NOTE]
>  Validation events (for example, <xref:System.Data.DataTable.ColumnChanging> and<xref:System.Data.DataTable.RowChanging>) will not be raised when constraints are turned off.  
  
### To suspend update constraints programmatically  
  
-   The following example shows how to temporarily turn off constraint checking in a dataset:  
  
     [!code-cs[VbRaddataEditing#10](../data-tools/codesnippet/CSharp/turn-off-constraints-while-filling-a-dataset_1.cs)]
     [!code-vb[VbRaddataEditing#10](../data-tools/codesnippet/VisualBasic/turn-off-constraints-while-filling-a-dataset_1.vb)]  
  
### To suspend update constraints using the Dataset Designer  
  
1.  Open your dataset in the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md). For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  In the **Properties** window, set the <xref:System.Data.DataSet.EnforceConstraints%2A> property to `false`.  
  
## See Also  
 [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)   
 [Relationships in datasets](../data-tools/relationships-in-datasets.md)