---
title: "How to: Create DataContext methods mapped to stored procedures and functions (O-R Designer)"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)
ms.assetid: e7ca32f1-50b3-48af-ad92-ceafd749296a
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
# How to: Create DataContext methods mapped to stored procedures and functions (O-R Designer)
Stored procedures and functions can be added to the O/R Designer as <xref:System.Data.Linq.DataContext?qualifyHint=False> methods. Calling the method and passing in the required parameters runs the stored procedure or function on the database and returns the data in the return type of the <xref:System.Data.Linq.DataContext?qualifyHint=False> method. For detailed information about <xref:System.Data.Linq.DataContext?qualifyHint=False> methods, see [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md).  
  
> [!NOTE]
>  Stored procedures can also be used to override the default LINQ to SQL runtime behavior that performs Inserts, Updates, and Deletes when changes are saved from entity classes to a database. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../VS_raddata/How-to--Assign-stored-procedures-to-perform-updates--inserts--and-deletes--O-R-Designer-.md).  
  
## Creating DataContext Methods  
 You can create <xref:System.Data.Linq.DataContext?qualifyHint=False> methods by dragging stored procedures or functions from **Server Explorer/Database Explorer** onto the O/R Designer.  
  
> [!NOTE]
>  The return type of the generated <xref:System.Data.Linq.DataContext?qualifyHint=False> method differs depending on where you drop the stored procedure or function on the O/R Designer. Dropping items directly onto an existing entity class creates a <xref:System.Data.Linq.DataContext?qualifyHint=False> method with the return type of the entity class. Dropping items onto an empty area of the O/R Designer creates a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that returns an automatically generated type. You can change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method after adding it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method, select it and inspect the **Return Type** property in the **Properties** window. For more information, see [How to: Change the return type of a DataContext method (O/R Designer)](../VS_raddata/How-to--Change-the-return-type-of-a-DataContext-method--O-R-Designer-.md).  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
#### To create DataContext methods that return automatically generated types  
  
1.  In **Server Explorer**/**Database Explorer**, expand the **Stored Procedures** node of the database you are working with.  
  
2.  Locate the desired stored procedure and drag it onto an empty area of the O/R Designer.  
  
     The <xref:System.Data.Linq.DataContext?qualifyHint=False> method is created with an automatically generated return type and appears in the **Methods** pane.  
  
#### To create DataContext methods that have the return type of an entity class  
  
1.  In **Server Explorer**/**Database Explorer**, expand the **Stored Procedures** node of the database you are working with.  
  
2.  Locate the desired stored procedure and drag it onto an existing entity class in the O/R Designer.  
  
     The <xref:System.Data.Linq.DataContext?qualifyHint=False> method is created with the return type of the selected entity class and appears in the **Methods** pane.  
  
> [!NOTE]
>  For information about changing the return type of existing <xref:System.Data.Linq.DataContext?qualifyHint=False> methods, see [How to: Change the return type of a DataContext method (O/R Designer)](../VS_raddata/How-to--Change-the-return-type-of-a-DataContext-method--O-R-Designer-.md).  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Introduction to LINQ in Visual Basic](../Topic/Introduction%20to%20LINQ%20in%20Visual%20Basic.md)   
 [How to: Write LINQ Queries in C#](../Topic/How%20to:%20Write%20LINQ%20Queries%20in%20C%23.md)