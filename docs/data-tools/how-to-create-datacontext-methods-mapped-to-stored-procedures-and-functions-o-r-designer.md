---
title: "How to: Create DataContext methods mapped to stored procedures and functions (O-R Designer) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e7ca32f1-50b3-48af-ad92-ceafd749296a
caps.latest.revision: 2
author: "mikeblome"
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
# How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)
Stored procedures and functions can be added to the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] as <xref:System.Data.Linq.DataContext> methods. Calling the method and passing in the required parameters runs the stored procedure or function on the database and returns the data in the return type of the <xref:System.Data.Linq.DataContext> method. For detailed information about <xref:System.Data.Linq.DataContext> methods, see [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md).  
  
> [!NOTE]
>  Stored procedures can also be used to override the default [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] runtime behavior that performs Inserts, Updates, and Deletes when changes are saved from entity classes to a database. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md).  
  
## Creating DataContext Methods  
 You can create <xref:System.Data.Linq.DataContext> methods by dragging stored procedures or functions from **Server Explorer/Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
> [!NOTE]
>  The return type of the generated <xref:System.Data.Linq.DataContext> method differs depending on where you drop the stored procedure or function on the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]. Dropping items directly onto an existing entity class creates a <xref:System.Data.Linq.DataContext> method with the return type of the entity class. Dropping items onto an empty area of the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] creates a <xref:System.Data.Linq.DataContext> method that returns an automatically generated type. You can change the return type of a <xref:System.Data.Linq.DataContext> method after adding it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext> method, select it and inspect the **Return Type** property in the **Properties** window. For more information, see [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md).  
  
 [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
#### To create DataContext methods that return automatically generated types  
  
1.  In **Server Explorer**/**Database Explorer**, expand the **Stored Procedures** node of the database you are working with.  
  
2.  Locate the desired stored procedure and drag it onto an empty area of the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
     The <xref:System.Data.Linq.DataContext> method is created with an automatically generated return type and appears in the **Methods** pane.  
  
#### To create DataContext methods that have the return type of an entity class  
  
1.  In **Server Explorer**/**Database Explorer**, expand the **Stored Procedures** node of the database you are working with.  
  
2.  Locate the desired stored procedure and drag it onto an existing entity class in the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
     The <xref:System.Data.Linq.DataContext> method is created with the return type of the selected entity class and appears in the **Methods** pane.  
  
> [!NOTE]
>  For information about changing the return type of existing <xref:System.Data.Linq.DataContext> methods, see [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md).  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Introduction to LINQ in Visual Basic](/dotnet/visual-basic/programming-guide/language-features/linq/introduction-to-linq)   
 [How to: Write LINQ Queries in C#](../Topic/How%20to:%20Write%20LINQ%20Queries%20in%20C%23.md)