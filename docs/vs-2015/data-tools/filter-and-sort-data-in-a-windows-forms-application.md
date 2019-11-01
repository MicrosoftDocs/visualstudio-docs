---
title: "Filter and sort data in a Windows Forms application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "row states, filtering"
  - "data views, sorting"
  - "row version, filtering"
  - "row states"
  - "data views, filtering"
  - "sorting datasets, using data views"
  - "dataset filtering, using data views"
ms.assetid: f4f100f1-776d-46dc-b2fd-5b35b98d9561
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Filter and sort data in a Windows Forms application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You filter data by setting the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to a string expression that returns the desired records.

 You sort data by setting the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column name you want to sort on; append `DESC` to sort in descending order, or append `ASC` to sort in ascending order.

> [!NOTE]
> If your application does not use <xref:System.Windows.Forms.BindingSource> components, you can filter and sort data by using <xref:System.Data.DataView> objects. For more information, see [DataViews](https://msdn.microsoft.com/library/0fe5dfa2-c1cd-435f-90b6-b4dd2e3ef34b).

## To filter data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Filter%2A> property to the expression you want to return. For example, the following code returns customers with a `CompanyName` that starts with "B":

     [!code-csharp[VbRaddataDisplaying#6](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs#6)]
     [!code-vb[VbRaddataDisplaying#6](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb#6)]

## To sort data by using a BindingSource component

- Set the <xref:System.Windows.Forms.BindingSource.Sort%2A> property to the column you want to sort on. For example, the following code sorts customers on the `CompanyName` column in descending order:

     [!code-csharp[VbRaddataDisplaying#7](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs#7)]
     [!code-vb[VbRaddataDisplaying#7](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb#7)]

## See Also
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
