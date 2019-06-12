---
title: "Error: User Could Not Execute Stored Procedure sp_enable_sql_debug | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.sqlde_accessdenied"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 11957495-c238-4cc5-8937-e4026f5e10e1
caps.latest.revision: 9
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: User Could Not Execute Stored Procedure sp_enable_sql_debug
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Stored Procedure sp_enable_sql_debug could not execute on the server. This can be caused by:  
  
- A connection problem. You need to have a stable connection to the server.  
  
- Lack of necessary permissions on the server. To debug on SQL Server 2005, both the account running Visual Studio and the account used to connect to SQL Server must be members of the sysadmin role. The account used to connect to SQL Server is either your Windows user account (if you are using Windows authentication) or an account with user ID and password (if you use SQL authentication).  
  
  For more information, see [How to: Set SQL Server Permissions for Debugging](https://msdn.microsoft.com/84e088d0-0409-41d4-841b-f5d4b0fda414).  
  
## See Also  
 [How to: Set SQL Server Permissions for Debugging](https://msdn.microsoft.com/84e088d0-0409-41d4-841b-f5d4b0fda414)   
 [Setting Up SQL Debugging](https://msdn.microsoft.com/3db09e68-edcc-42de-9c22-4e97cfd55ab3)
