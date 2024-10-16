---
title: Object from unsupported provider
description: You have selected a database object from an unsupported database provider. View information about this Visual Studio (O/R Designer) message.
ms.date: 11/04/2016
ms.topic: error-reference
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# You have selected a database object from an unsupported database provider

The **O/R Designer** supports only the .NET Framework Data Provider for SQL Server (<xref:System.Data.SqlClient>). Although you can click **OK** and continue to work with objects from unsupported database providers, you might experience unexpected behavior at run time.

> [!NOTE]
> Only data connections that use the .NET Framework Data Provider for SQL Server are supported.

## Options

- Click **OK** to continue designing the entity classes that map to the connection that uses the unsupported database provider. You might experience unexpected behavior when you use unsupported database providers.

- Click **Cancel** to stop the action. Create or use a different data connection that uses the .NET Framework Provider for SQL Server.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
