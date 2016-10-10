---
title: "How to: Turn pluralization on and off (O-R Designer)"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Turn pluralization on and off (O/R Designer)
ms.assetid: 9b693bc3-303a-40a9-97ee-9cef5ca3ae81
caps.latest.revision: 2
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
# How to: Turn pluralization on and off (O-R Designer)
By default, when you drag database objects that have names ending in s or ies from **Server Explorer**/**Database Explorer** onto the [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md), the names of the generated entity classes are changed from plural to singular. This is done to more accurately represent the fact that the instantiated entity class maps to a single record of data. For example, adding a Customers table to the O/R Designer results in an entity class named Customer because the class will hold data for only a single customer.  
  
> [!NOTE]
>  Pluralization is on by default only in the English-language version of Visual Studio.  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
### To turn pluralization on and off  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  In the **Options** dialog box, expand **Database Tools**.  
  
> [!NOTE]
>  Select **Show all settings** if the **Database Tools** node is not visible.  
  
1.  Click **O/R Designer**.  
  
2.  Set **Pluralization of names** to **Enabled** = **False** to set the O/R Designer so that it does not change class names.  
  
3.  Set **Pluralization of names** to **Enabled** = **True** to apply pluralization rules to the class names of objects added to the O/R Designer.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Accessing data in Visual Studio](../VS_raddata/Accessing-data-in-Visual-Studio.md)