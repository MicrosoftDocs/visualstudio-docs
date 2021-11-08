---
title: Schema does not match
description: One or more selected database objects return a schema that does not match the schema of the target class
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: error-reference
ms.assetid: 3794e88b-4d3d-4e7a-ade6-8208eabe3eae
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# One or more selected database objects return a schema that does not match the schema of the target class

One or more selected database objects return a schema that does not match the schema of the target class. Nothing has been added to the designer.

When you drag database objects onto existing entity classes, the data returned by the database object must match the schema of the target entity class. Verify that the correct database object is selected and that the correct entity class is being targeted.

## To correct this error

1. Click **OK** to dismiss the dialog box.

2. Select a database object that returns data that matches the schema of the target class (the class the database object is being dropped onto in the **O/R Designer**).

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
