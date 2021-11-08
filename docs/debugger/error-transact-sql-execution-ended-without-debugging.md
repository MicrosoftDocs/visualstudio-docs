---
description: "This error occurs when you're trying to debug a Transact-SQL or SQLCLR procedure and the debugger doesn't receive debugging messages from the SQL Server."
title: "Transact-SQL execution ended without debugging | Microsoft Docs"
ms.date: "11/08/2018"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.sqlde_sql_executed_but_not_debugged"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "SQL"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: Transact-SQL execution ended without debugging

This error occurs when you're trying to debug a Transact-SQL or SQLCLR procedure and the debugger doesn't receive debugging messages from the SQL Server.

This issue could be because of network problems or to problems on the SQL Server, but the most likely cause is a permissions problem.

There are two accounts involved:

- The application account is the user account that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is running as.

- The connection account is the identity used to make the connection to SQL Server. This account isn't necessarily the same as the identity that Visual Studio is running as if the connection is using SQL authentication.

  SQL debugging requires that the application account must match the connection account or be a sysadmin.

  If you're using a SQL account name like sa, the application account must be set up on the SQL Server as a sysadmin. By default, administrators on the machine that SQL server is running on are SQL Server sysadmins.

  To correct this error, you might need to:

  - Verify your permissions settings. For more information, see [How to: Set SQL Server Permissions for Debugging](/previous-versions/w1bhybwz(v=vs.100)).

  - Make sure SQL debugging if set up correctly.

  - Consult with your network or database administrator.

## See also

- [Setting Up SQL Debugging](/previous-versions/visualstudio/visual-studio-2010/s4sszxst(v=vs.100))
- [How to: Set SQL Server Permissions for Debugging](/previous-versions/w1bhybwz(v=vs.100))
- [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)
- [Remote Debugging](../debugger/remote-debugging.md)
