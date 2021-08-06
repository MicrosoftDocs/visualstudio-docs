---
title: Connection property missing
description: 'The connection property in the Application Settings file is missing or incorrect. View information about this Visual Studio O/R Designer message.'
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: error-reference
ms.assetid: 77724510-ff59-4d43-b933-a0434e1ac597
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# The connection property in the Application Settings file is missing or incorrect

The connection property in the Application Settings file is missing or incorrect. The connection string from the *.dbml* file has been used in its place.

The *.dbml* file contains a reference to a connection string in the application settings file that cannot be found. This message is informational; the connection string setting will be created when **OK** is clicked.

To respond to this message, select **OK**. The connection information that is contained in the *.dbml* file is added to application settings.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
