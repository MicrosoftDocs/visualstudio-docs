---
description: "The Stored Procedure sp_enable_sql_debug could not execute on the server."
title: "User Could Not Execute Stored Procedure sp_enable_sql_debug | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "error-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: User Could Not Execute Stored Procedure sp_enable_sql_debug

The Stored Procedure sp_enable_sql_debug could not execute on the server. This can be caused by:

- A connection problem. You need to have a stable connection to the server.

- Lack of necessary permissions on the server. To debug on SQL Server 2005, both the account running Visual Studio and the account used to connect to SQL Server must be members of the sysadmin role. The account used to connect to SQL Server is either your Windows user account (if you are using Windows authentication) or an account with user ID and password (if you use SQL authentication).

For more information, see [How to: Set SQL Server Permissions for Debugging](/previous-versions/w1bhybwz(v=vs.100)).

## See also

- [How to: Set SQL Server Permissions for Debugging](/previous-versions/w1bhybwz(v=vs.100))
- [Setting Up SQL Debugging](/previous-versions/visualstudio/visual-studio-2010/s4sszxst\(v\=vs.100\))
