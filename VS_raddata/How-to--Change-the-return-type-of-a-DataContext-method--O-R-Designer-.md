---
title: "How to: Change the return type of a DataContext method (O-R Designer)"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Change the return type of a DataContext method (O/R Designer)
ms.assetid: c5b66bff-6dbb-43c0-bffa-317133ca5b9e
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
# How to: Change the return type of a DataContext method (O-R Designer)
The return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method (created based on a stored procedure or function) differs depending on where you drop the stored procedure or function in the O/R Designer. If you drop an item directly onto an existing entity class, a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that has the return type of the entity class is created (if the schema of the data returned by the stored procedure or function matches the shape of the entity class). If you drop an item onto an empty area of the O/R Designer, a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that returns an automatically generated type is created. You can change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method, select it and click the **Return Type** property in the **Properties** window.  
  
> [!NOTE]
>  You cannot revert <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that have a return type set to an entity class to return the auto-generated type by using the **Properties** window. To revert a <xref:System.Data.Linq.DataContext?qualifyHint=False> method to return an auto-generated type, you must drag the original database object onto the O/R Designer again.  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
### To change the return type of a DataContext method from the auto-generated type to an entity class  
  
1.  Select the <xref:System.Data.Linq.DataContext?qualifyHint=False> method in the methods pane.  
  
2.  Select **Return Type** in the **Properties** window and then select an available entity class in the **Return Type** list. If the desired entity class is not in the list, add it to or create it in the O/R Designer to add it to the list.  
  
3.  Save the .dbml file.  
  
### To change the return type of a DataContext method from an entity class back to the auto-generated type  
  
1.  Select the <xref:System.Data.Linq.DataContext?qualifyHint=False> method in the methods pane and delete it.  
  
2.  Drag the database object from **Server Explorer**/**Database Explorer** onto an empty area of the O/R Designer.  
  
3.  Save the .dbml file.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md)   
 [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md)