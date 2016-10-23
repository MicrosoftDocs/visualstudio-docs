---
title: "How to: Create LINQ to SQL classes mapped to tables and views (O-R Designer)"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Create LINQ to SQL classes mapped to tables and views (O/R Designer)
ms.assetid: 0fb78bbc-7a78-4ab4-b32f-85ece912e660
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
# How to: Create LINQ to SQL classes mapped to tables and views (O-R Designer)
LINQ to SQL classes that are mapped to database tables and views are called *entity classes*. The entity class maps to a record, whereas the individual properties of an entity class map to the individual columns that make up a record. Create entity classes that are based on database tables or views by dragging tables or views from **Server Explorer**/**Database Explorer** onto the [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md). The O/R Designer generates the classes and applies the specific LINQ to SQL attributes to enable LINQ to SQL functionality (the data communication and editing capabilities of the <xref:System.Data.Linq.DataContext?qualifyHint=False>). For detailed information about LINQ to SQL classes, see [The LINQ to SQL Object Model](../Topic/The%20LINQ%20to%20SQL%20Object%20Model.md).  
  
> [!NOTE]
>  The O/R Designer is a simple object relational mapper because it supports only 1:1 mapping relationships. In other words, an entity class can have only a 1:1 mapping relationship with a database table or view. Complex mapping, such as mapping an entity class to multiple tables, is not supported. However, you can map an entity class to a view that joins multiple related tables.  
  
## Create LINQ to SQL Classes That Are Mapped to Database Tables or Views  
 Dragging tables or views from **Server Explorer**/**Database Explorer** onto the O/R Designer creates entity classes in addition to the <xref:System.Data.Linq.DataContext?qualifyHint=False> methods that are used for performing updates.  
  
 By default, the LINQ to SQL runtime creates logic to save changes from an updatable entity class back to the database. This logic is based on the schema of the table (the column definitions and primary key information). If you do not want this behavior, you can configure an entity class to use stored procedures to perform Inserts, Updates, and Deletes instead of using the default LINQ to SQL runtime behavior. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../VS_raddata/How-to--Assign-stored-procedures-to-perform-updates--inserts--and-deletes--O-R-Designer-.md).  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
#### To create LINQ to SQL classes that are mapped to database tables or views  
  
1.  In **Server**/**Database Explorer**, expand **Tables** or **Views** and locate the database table or view that you want to use in your application.  
  
2.  Drag the table or view onto the O/R Designer.  
  
     An entity class is created and appears on the design surface. The entity class has properties that map to the columns in the selected table or view.  
  
## Create an Object Data Source and Display the Data on a Form  
 After you create entity classes by using the O/R Designer, you can create an object data source and populate the [Data Sources Window](../Topic/Data%20Sources%20Window.md) with the entity classes.  
  
#### To create an object data source based on LINQ to SQL entity classes  
  
1.  On the **Build** menu, click **Build Solution** to build your project.  
  
2.  On the **Data** menu, click **Show Data Sources**.  
  
3.  In the **Data Sources** window, click **Add New Data Source**.  
  
4.  Click **Object** on the **Choose a Data Source Type** page and then click **Next**.  
  
5.  Expand the nodes and locate and select your class.  
  
    > [!NOTE]
    >  If the **Customer** class is not available, cancel out of the wizard, build the project, and run the wizard again.  
  
6.  Click **Finish** to create the data source and add the **Customer** entity class to the **Data Sources** window.  
  
7.  Drag items from the **Data Sources** window onto a form.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md)   
 [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md)   
 [The LINQ to SQL Object Model](../Topic/The%20LINQ%20to%20SQL%20Object%20Model.md)   
 [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../VS_raddata/Walkthrough--Customizing-the-insert--update--and-delete-behavior-of-entity-classes.md)   
 [Walkthrough: Adding Validation to Entity Classes](../Topic/Walkthrough:%20Adding%20Validation%20to%20Entity%20Classes.md)   
 [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../VS_raddata/How-to--Create-an-association--relationship--between-LINQ-to-SQL-classes--O-R-Designer-.md)