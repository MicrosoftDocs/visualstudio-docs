---
title: "Error: Unable to Automatically Step Into the Server | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.causality_no_server_response"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "remote debugging, notification error"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Unable to Automatically Step Into the Server
The error reads:

 Unable to Automatically Step Into the Server. The debugger was not notified before the remote procedure was executed

 This error can occur when you are trying to step into a web service (see [Stepping Into an XML Web Service](https://msdn.microsoft.com/library/8e67de38-bf5f-41cc-a457-1b88ce63d764)). It can occur whenever [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] is not set up properly.

 Possible causes are:

- The web.config file for your [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application does not set debug to "true" in (see [Debug Mode in ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)).

- A version of [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] was installed after Visual Studio was installed. [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] should be installed before Visual Studio. To fix this problem, use the Windows **Control Panel > Programs and Features** to repair your Visual Studio installation.

## See also
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
- [Remote Debugging](../debugger/remote-debugging.md)