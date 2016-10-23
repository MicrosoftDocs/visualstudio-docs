---
title: "DataContext Methods (O-R Designer)"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: DataContext Methods (O/R Designer)
ms.assetid: c149f4e5-3b61-4c33-892e-3e26d47f3eeb
caps.latest.revision: 5
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
# DataContext Methods (O-R Designer)
<xref:System.Data.Linq.DataContext?qualifyHint=False> methods (in the context of the [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)) are methods of the <xref:System.Data.Linq.DataContext?qualifyHint=False> class that run stored procedures and functions in a database.  
  
 The <xref:System.Data.Linq.DataContext?qualifyHint=False> class is a LINQ to SQL class that acts as a conduit between a SQL Server database and the LINQ to SQL entity classes mapped to that database. The <xref:System.Data.Linq.DataContext?qualifyHint=False> class contains the connection string information and the methods for connecting to a database and manipulating the data in the database. By default, the <xref:System.Data.Linq.DataContext?qualifyHint=False> class contains several methods that you can call, such as the <xref:System.Data.Linq.DataContext.SubmitChanges?qualifyHint=False> method that sends updated data from LINQ to SQL classes to the database. You can also create additional <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that map to stored procedures and functions. In other words, calling these custom methods will run the stored procedure or function in the database that the <xref:System.Data.Linq.DataContext?qualifyHint=False> method is mapped to. You can add new methods to the <xref:System.Data.Linq.DataContext?qualifyHint=False> class just as you would add methods to extend any class. However, in discussions about <xref:System.Data.Linq.DataContext?qualifyHint=False> methods in the context of the O/R Designer, it is the <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that map to stored procedures and functions that are being discussed.  
  
## Methods Pane  
 <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that map to stored procedures and functions are displayed in the methods pane of the O/R Designer. The methods pane is the pane along the side of the **Entities** pane (the main design surface). The methods pane lists all <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that you have created by using the O/R Designer. By default, the methods pane is empty; drag stored procedures or functions from **Server Explorer**/**Database Explorer** onto the O/R Designer to create <xref:System.Data.Linq.DataContext?qualifyHint=False> methods and populate the methods pane. For more information, see [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md).  
  
> [!NOTE]
>  Open and close the methods pane by right-clicking the O/R Designer and then clicking **Hide Methods Pane** or **Show Methods Pane**, or use the keyboard shortcut CTRL+1.  
  
## Two Types of DataContext Methods  
 DataContext methods are those methods that map to stored procedures and functions in the database. You can create and add DataContext methods on the methods pane of the O/R Designer. There are two distinct types of <xref:System.Data.Linq.DataContext?qualifyHint=False> methods; those that return one or more result sets, and those that do not:  
  
-   <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that return one or more result sets:  
  
     Create this kind of <xref:System.Data.Linq.DataContext?qualifyHint=False> method when your application just needs to run stored procedures and functions in the database and return the results. For more information, see [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md), System.Data.Linq.ISingleResult<T\>, and <xref:System.Data.Linq.IMultipleResults?qualifyHint=False>.  
  
-   <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that do not return result sets: such as Inserts, Updates, and Deletes for a specific entity class.  
  
     Create this kind of <xref:System.Data.Linq.DataContext?qualifyHint=False> method when your application has to run stored procedures instead of using the default LINQ to SQL behavior for saving modified data between an entity class and the database. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../VS_raddata/How-to--Assign-stored-procedures-to-perform-updates--inserts--and-deletes--O-R-Designer-.md).  
  
## Return Types of DataContext Methods  
 When you drag stored procedures and functions from **Server Explorer**/**Database Explorer** onto the O/R Designer, the return type of the generated <xref:System.Data.Linq.DataContext?qualifyHint=False> method differs depending on where you drop the item. Dropping the items directly onto an existing entity class creates a <xref:System.Data.Linq.DataContext?qualifyHint=False> method with the return type of the entity class; dropping items onto an empty area of the O/R Designer (in either pane) creates a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that returns an automatically generated type. The automatically generated type that is created has a name that matches the stored procedure or function name and properties that map to the fields returned by the stored procedure or function.  
  
> [!NOTE]
>  You can change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method, select it and inspect the **Return Type** property in the **Properties** window. For more information, see [How to: Change the return type of a DataContext method (O/R Designer)](../VS_raddata/How-to--Change-the-return-type-of-a-DataContext-method--O-R-Designer-.md).  
  
 Objects you drag from the database onto the O/R Designer surface will be named automatically, based on the name of the objects in the database. If you drag the same object more than once, a number is appended to the end of the new name that differentiates the names. When database object names contain spaces, or characters not-supported in Visual Basic or C#, the space or invalid character is replaced with an underscore.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Stored Procedures](../Topic/Stored%20Procedures.md)   
 [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md)   
 [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../VS_raddata/How-to--Assign-stored-procedures-to-perform-updates--inserts--and-deletes--O-R-Designer-.md)   
 [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../VS_raddata/Walkthrough--Customizing-the-insert--update--and-delete-behavior-of-entity-classes.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)