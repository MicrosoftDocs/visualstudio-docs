---
title: "Error: Transact-SQL execution ended without debugging | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.sqlde_sql_executed_but_not_debugged"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "SQL"
ms.assetid: 7a4d4999-3973-4339-ba6a-f0d19bcb1d4a
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Error: Transact-SQL execution ended without debugging
This error occurs when you are trying to debug a Transact-SQL or SQLCLR procedure and the debugger does not receive debugging messages from the SQL Server.  
  
 This could be due to network problems or to problems on the SQL Server, but the most likely cause is a permissions problem.  
  
 There are two accounts involved:  
  
-   The application account is the user account that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is running as.  
  
-   The connection account is the identity used to make the connection to SQL Server. This is not necessarily the same as the identity that Visual Studio is running as if the connection is using SQL authentication.  
  
 SQL debugging requires that the application account must match the connection account or be sysadmin.  
  
 If you are using a SQL login like sa, the application account must be setup on the SQL Server as a sysadmin. By default, administrators on the machine SQL server is running on are SQL Server sysadmins.  
  
 To correct this error, you might need to:  
  
-   Verify your permissions settings. For more information, see [How to: Set SQL Server Permissions for Debugging](http://msdn.microsoft.com/en-us/84e088d0-0409-41d4-841b-f5d4b0fda414).  
  
-   Make sure SQL debugging if set up correctly.  
  
-   Consult with your network or database administrator.  
  
## See Also  
 [Setting Up SQL Debugging](http://msdn.microsoft.com/en-us/3db09e68-edcc-42de-9c22-4e97cfd55ab3)   
 [How to: Set SQL Server Permissions for Debugging](http://msdn.microsoft.com/en-us/84e088d0-0409-41d4-841b-f5d4b0fda414)   
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Remote Debugging](../debugger/remote-debugging.md)