---
title: "You have selected a database object from an unsupported database provider"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c0f1298e-31aa-471e-ae19-1bafffd2ae40
caps.latest.revision: 3
ms.author: "mblome"
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
---
# You have selected a database object from an unsupported database provider
The [!INCLUDE[vs_ordesigner_long](../datatools/includes/vs_ordesigner_long_md.md)] ([!INCLUDE[vs_ordesigner_short](../datatools/includes/vs_ordesigner_short_md.md)]) supports only the .NET Framework Data Provider for SQL Server (\<xref:System.Data.SqlClient>). Although you can click **OK** and continue to work with objects from unsupported database providers, you may experience unexpected behavior at run time.  
  
> [!NOTE]
>  Only data connections that use the .NET Framework Data Provider for SQL Server are supported.  
  
### To correct this error  
  
-   Click **OK** to continue designing the entity classes that map to the connection that uses the unsupported database provider. You might experience unexpected behavior when you use unsupported database providers.  
  
     -or-  
  
-   Click **Cancel**.  
  
     The action is stopped. Create or use a data connection that uses the .NET Framework Provider for SQL Server.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../datatools/linq-to-sql-tools-in-visual-studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [.NET Framework Data Providers](../Topic/.NET%20Framework%20Data%20Providers.md)   
 [Connecting to Data in Visual Studio](../datatools/connecting-to-data-in-visual-studio.md)