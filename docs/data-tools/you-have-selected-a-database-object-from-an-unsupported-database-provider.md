---
title: "You have selected a database object from an unsupported database provider | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c0f1298e-31aa-471e-ae19-1bafffd2ae40
caps.latest.revision: 3
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
ms.technology: "vs-data-tools"
---
# You have selected a database object from an unsupported database provider
The [!INCLUDE[vs_ordesigner_long](../data-tools/includes/vs_ordesigner_long_md.md)] ([!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]) supports only the .NET Framework Data Provider for SQL Server (<xref:System.Data.SqlClient>). Although you can click **OK** and continue to work with objects from unsupported database providers, you may experience unexpected behavior at run time.  
  
> [!NOTE]
>  Only data connections that use the .NET Framework Data Provider for SQL Server are supported.  
  
### To correct this error  
  
-   Click **OK** to continue designing the entity classes that map to the connection that uses the unsupported database provider. You might experience unexpected behavior when you use unsupported database providers.  
  
     -or-  
  
-   Click **Cancel**.  
  
     The action is stopped. Create or use a data connection that uses the .NET Framework Provider for SQL Server.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)   
 [.NET Framework Data Providers](/dotnet/framework/data/adonet/data-providers)   
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)