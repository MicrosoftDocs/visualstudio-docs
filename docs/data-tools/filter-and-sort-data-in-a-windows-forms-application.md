---
title: Filter and sort data in a Windows Forms application (.NET Framework)
description: In .NET Framework application development with Visual Studio, filter and sort data in a Windows Forms application. Set the Filter property to a string expression that returns the desired records.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- row states, filtering
- data views, sorting
- row version, filtering
- row states
- data views, filtering
- sorting datasets, using data views
- dataset filtering, using data views
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Filter and sort data in a .NET Framework Windows Forms application

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

You filter data by setting the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to a string expression that returns the desired records.

You sort data by setting the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column name on which you want to sort; append `DESC` to sort in descending order, or append `ASC` to sort in ascending order.

> [!NOTE]
> If your application does not use <xref:System.Windows.Forms.BindingSource> components, you can filter and sort data by using <xref:System.Data.DataView> objects. For more information, see [DataViews](/dotnet/framework/data/adonet/dataset-datatable-dataview/dataviews).

## To filter data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to the expression you want to return. For example, the following code returns customers with a `CompanyName` that starts with "B":

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb" id="Snippet6":::
     ---

## To sort data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column you want to sort on. For example, the following code sorts customers on the `CompanyName` column in descending order:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb" id="Snippet7":::
     ---

## Related content

- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
