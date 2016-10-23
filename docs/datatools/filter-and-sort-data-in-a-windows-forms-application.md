---
title: "Filter and sort data in a Windows Forms application"
ms.custom: na
ms.date: "10/14/2016"
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
  - "row states, filtering"
  - "data views, sorting"
  - "row version, filtering"
  - "row states"
  - "data views, filtering"
  - "sorting datasets, using data views"
  - "dataset filtering, using data views"
ms.assetid: f4f100f1-776d-46dc-b2fd-5b35b98d9561
caps.latest.revision: 18
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
# Filter and sort data in a Windows Forms application
You filter data by setting the \<xref:System.Windows.Forms.BindingSource.Filter*> property to a string expression that returns the desired records.  
  
 You sort data by setting the \<xref:System.Windows.Forms.BindingSource.Sort*> property to the column name you want to sort on; append `DESC` to sort in descending order, or append `ASC` to sort in ascending order.  
  
> [!NOTE]
>  If your application does not use \<xref:System.Windows.Forms.BindingSource> components, you can filter and sort data by using \<xref:System.Data.DataView> objects. For more information, see [DataViews](../Topic/DataViews.md).  
  
## To filter data by using a BindingSource component  
  
-   Set the \<xref:System.Windows.Forms.BindingSource.Filter*> property to the expression you want to return. For example, the following code returns customers with a `CompanyName` that starts with "B":  
  
     [!code[VbRaddataDisplaying#6](../datatools/codesnippet/CSharp/filter-and-sort-data-in-a-windows-forms-application_1.cs)]
[!code[VbRaddataDisplaying#6](../datatools/codesnippet/VisualBasic/filter-and-sort-data-in-a-windows-forms-application_1.vb)]  
  
## To sort data by using a BindingSource component  
  
-   Set the \<xref:System.Windows.Forms.BindingSource.Sort*> property to the column you want to sort on. For example, the following code sorts customers on the `CompanyName` column in descending order:  
  
     [!code[VbRaddataDisplaying#7](../datatools/codesnippet/CSharp/filter-and-sort-data-in-a-windows-forms-application_2.cs)]
[!code[VbRaddataDisplaying#7](../datatools/codesnippet/VisualBasic/filter-and-sort-data-in-a-windows-forms-application_2.vb)]  
  
## See Also  
 [Bind controls to data in Visual Studio](../datatools/bind-controls-to-data-in-visual-studio.md)