---
title: You have selected a database object from an unsupported database provider
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: c0f1298e-31aa-471e-ae19-1bafffd2ae40
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# You have selected a database object from an unsupported database provider

The **O/R Designer** supports only the .NET Framework Data Provider for SQL Server (<xref:System.Data.SqlClient>). Although you can click **OK** and continue to work with objects from unsupported database providers, you may experience unexpected behavior at run time.

> [!NOTE]
> Only data connections that use the .NET Framework Data Provider for SQL Server are supported.

## Options

- Click **OK** to continue designing the entity classes that map to the connection that uses the unsupported database provider. You might experience unexpected behavior when you use unsupported database providers.

- Click **Cancel** to stop the action. Create or use a different data connection that uses the .NET Framework Provider for SQL Server.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)