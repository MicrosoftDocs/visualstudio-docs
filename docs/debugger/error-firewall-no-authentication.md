---
title: "Error: Firewall No Authentication | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.firewall.noauth"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Firewall No Authentication
The Internet Connection Firewall on the remote machine is not set up to allow remote debugging. For remote debugging with `No Authentication`, msvsmon.exe must be added to the exceptions list. Opening some IPSEC ports may be necessary as well.

> [!NOTE]
> The remote debugger is able to automatically configure the Windows Firewall. When using a firewall other than the Windows Firewall such as third party software firewall or a hardware firewall, the firewall must be manually configured to allow remote debugging. To do so, allow traffic on TCP/IP ports that msvsmon.exe is listening on. By default, these are port 4018 and 4019, where 4018 is used on all Operating Systems, and 4019 is used only on Windows x64 to allow debugging x86 processes.

 For more information, see [Remote Debugging](../debugger/remote-debugging.md).