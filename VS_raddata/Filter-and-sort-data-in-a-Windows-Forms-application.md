---
title: "Filter and sort data in a Windows Forms application"
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
ms.assetid: f4f100f1-776d-46dc-b2fd-5b35b98d9561
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
# Filter and sort data in a Windows Forms application
You filter data by setting the <xref:System.Windows.Forms.BindingSource.Filter?qualifyHint=False> property to a string expression that returns the desired records.  
  
 You sort data by setting the <xref:System.Windows.Forms.BindingSource.Sort?qualifyHint=False> property to the column name you want to sort on; append `DESC` to sort in descending order, or append `ASC` to sort in ascending order.  
  
> [!NOTE]
>  If your application does not use <xref:System.Windows.Forms.BindingSource?qualifyHint=False> components, you can filter and sort data by using <xref:System.Data.DataView?qualifyHint=False> objects. For more information, see [DataViews](../Topic/DataViews.md).  
  
## To filter data by using a BindingSource component  
  
-   Set the <xref:System.Windows.Forms.BindingSource.Filter?qualifyHint=False> property to the expression you want to return. For example, the following code returns customers with a `CompanyName` that starts with "B":  
  
     [!CODE [VbRaddataDisplaying#6](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataDisplaying#6)]  
  
## To sort data by using a BindingSource component  
  
-   Set the <xref:System.Windows.Forms.BindingSource.Sort?qualifyHint=False> property to the column you want to sort on. For example, the following code sorts customers on the `CompanyName` column in descending order:  
  
     [!CODE [VbRaddataDisplaying#7](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataDisplaying#7)]  
  
## See Also  
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)