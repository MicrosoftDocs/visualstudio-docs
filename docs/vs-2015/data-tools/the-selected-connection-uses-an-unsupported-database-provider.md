---
title: "The selected connection uses an unsupported database provider | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 4d25dfa1-8fa4-4529-9b90-973bc2ec2993
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# The selected connection uses an unsupported database provider
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This message appears when you drag items that do not use the .NET Framework Data Provider for SQL Server from **Server Explorer**/**Database Explorer** onto the [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md).

 The [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] supports only data connections that use the .NET Framework Provider for SQL Server. Only connections to Microsoft SQL Server or Microsoft SQL Server Database File are valid.

### To correct this error

- Add only items from data connections that use the .NET Framework Data Provider for SQL Server to the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

## See Also
 <xref:System.Data.SqlClient>
 [.NET Framework Data Providers](https://msdn.microsoft.com/library/03a9fc62-2d24-491a-9fe6-d6bdb6dcb131)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)