---
title: "Turn off constraints while filling a dataset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
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
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Turn off constraints while filling a dataset
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If a dataset contains constraints (such as foreign-key constraints),theycan raise errors  related to the order of operations that are performed against the dataset. For example, loading child records before loadingrelated parent records can violate a constraint and cause an error. As soon as you load a child record, the constraint checks for the related parent record and raises an error.

 If there were no mechanism to allow temporary constraint suspension, an error would be raised every time you tried to load a record into the child table. Another way to suspend all constraints in a dataset is with the <xref:System.Data.DataRow.BeginEdit%2A>, and <xref:System.Data.DataRow.EndEdit%2A> properties.

> [!NOTE]
> Validation events (for example, <xref:System.Data.DataTable.ColumnChanging> and<xref:System.Data.DataTable.RowChanging>) will not be raised when constraints are turned off.

### To suspend update constraints programmatically

- The following example shows how to temporarily turn off constraint checking in a dataset:

     [!code-csharp[VbRaddataEditing#10](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#10)]
     [!code-vb[VbRaddataEditing#10](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#10)]

### To suspend update constraints using the Dataset Designer

1. Open your dataset in the Dataset Designer. For more information, see [How to: Open a Dataset in the Dataset Designer](https://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).

2. In the **Properties** window, set the <xref:System.Data.DataSet.EnforceConstraints%2A> property to `false`.

## See Also
 [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
 [Relationships in datasets](../data-tools/relationships-in-datasets.md)
