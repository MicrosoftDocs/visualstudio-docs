---
title: "You have selected a database object from an unsupported database provider | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: c0f1298e-31aa-471e-ae19-1bafffd2ae40
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# You have selected a database object from an unsupported database provider
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[vs_ordesigner_long](../includes/vs-ordesigner-long-md.md)] ([!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]) supports only the .NET Framework Data Provider for SQL Server (<xref:System.Data.SqlClient>). Although you can click **OK** and continue to work with objects from unsupported database providers, you may experience unexpected behavior at run time.

> [!NOTE]
> Only data connections that use the .NET Framework Data Provider for SQL Server are supported.

### To correct this error

- Click **OK** to continue designing the entity classes that map to the connection that uses the unsupported database provider. You might experience unexpected behavior when you use unsupported database providers.

     -or-

- Click **Cancel**.

     The action is stopped. Create or use a data connection that uses the .NET Framework Provider for SQL Server.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
 [.NET Framework Data Providers](https://msdn.microsoft.com/library/03a9fc62-2d24-491a-9fe6-d6bdb6dcb131)