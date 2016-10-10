---
title: "The selected class cannot be deleted because it is used as a return type for one or more DataContext methods"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d68254a0-f3a1-47e2-aed3-a83471e1d711
caps.latest.revision: 3
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
# The selected class cannot be deleted because it is used as a return type for one or more DataContext methods
The return type of one or more <xref:System.Data.Linq.DataContext?qualifyHint=False> methods is the selected entity class. Deleting an entity class that is used as the return type for a <xref:System.Data.Linq.DataContext?qualifyHint=False> method will cause the compilation of the project to fail. To delete the selected entity class, identify the <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that use it and set their return types to a different entity class.  
  
 To revert the return types of <xref:System.Data.Linq.DataContext?qualifyHint=False> methods to their original auto-generated types, first delete the <xref:System.Data.Linq.DataContext?qualifyHint=False> method from the methods pane and then drag the object from **Server Explorer**/**Database Explorer** onto the O/R Designer again.  
  
### To correct this error  
  
1.  Identify <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that use the entity class as a return type by selecting a <xref:System.Data.Linq.DataContext?qualifyHint=False> method in the methods pane and inspecting the **Return Type** property in the **Properties** window.  
  
2.  Set the **Return Type** to a different entity class or delete the <xref:System.Data.Linq.DataContext?qualifyHint=False> method from the methods pane.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md)   
 [How to: Change the return type of a DataContext method (O/R Designer)](../VS_raddata/How-to--Change-the-return-type-of-a-DataContext-method--O-R-Designer-.md)