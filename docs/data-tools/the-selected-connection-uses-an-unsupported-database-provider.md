---
title: The selected connection uses an unsupported database provider
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 4d25dfa1-8fa4-4529-9b90-973bc2ec2993
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# The selected connection uses an unsupported database provider

This message appears when you drag items that do not use the .NET Framework Data Provider for SQL Server from **Server Explorer** or **Database Explorer** onto the [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md).

The **O/R Designer** supports only data connections that use the .NET Framework Provider for SQL Server. Only connections to Microsoft SQL Server or Microsoft SQL Server Database File are valid.

To correct this error, add only items from data connections that use the .NET Framework Data Provider for SQL Server to the **O/R Designer**.

## See also

- <xref:System.Data.SqlClient>
- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
