---
title: Filter and sort data in a Windows Forms application
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "row states, filtering"
  - "data views, sorting"
  - "row version, filtering"
  - "row states"
  - "data views, filtering"
  - "sorting datasets, using data views"
  - "dataset filtering, using data views"
ms.assetid: f4f100f1-776d-46dc-b2fd-5b35b98d9561
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Filter and sort data in a Windows Forms application

You filter data by setting the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to a string expression that returns the desired records.

You sort data by setting the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column name on which you want to sort; append `DESC` to sort in descending order, or append `ASC` to sort in ascending order.

> [!NOTE]
> If your application does not use <xref:System.Windows.Forms.BindingSource> components, you can filter and sort data by using <xref:System.Data.DataView> objects. For more information, see [DataViews](/dotnet/framework/data/adonet/dataset-datatable-dataview/dataviews).

## To filter data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to the expression you want to return. For example, the following code returns customers with a `CompanyName` that starts with "B":

     [!code-csharp[VbRaddataDisplaying#6](../data-tools/codesnippet/CSharp/filter-and-sort-data-in-a-windows-forms-application_1.cs)]
     [!code-vb[VbRaddataDisplaying#6](../data-tools/codesnippet/VisualBasic/filter-and-sort-data-in-a-windows-forms-application_1.vb)]

## To sort data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column you want to sort on. For example, the following code sorts customers on the `CompanyName` column in descending order:

     [!code-csharp[VbRaddataDisplaying#7](../data-tools/codesnippet/CSharp/filter-and-sort-data-in-a-windows-forms-application_2.cs)]
     [!code-vb[VbRaddataDisplaying#7](../data-tools/codesnippet/VisualBasic/filter-and-sort-data-in-a-windows-forms-application_2.vb)]

## See also

- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)