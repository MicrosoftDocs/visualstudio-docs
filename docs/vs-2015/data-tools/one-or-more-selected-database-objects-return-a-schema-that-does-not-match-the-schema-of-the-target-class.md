---
title: "One or more selected database objects return a schema that does not match the schema of the target class | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 3794e88b-4d3d-4e7a-ade6-8208eabe3eae
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# One or more selected database objects return a schema that does not match the schema of the target class
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

One or more selected database objects return a schema that does not match the schema of the target class. Nothing has been added to the designer.

 When you drag database objects onto existing entity classes, the data returned by the database object must match the schema of the target entity class. Verify that the correct database object is selected and that the correct entity class is being targeted.

### To correct this error

1. Click **OK** to dismiss the dialog box.

2. Select a database object that returns data that matches the schema of the target class (the class the database object is being dropped onto in the O/R Designer).

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
 [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
