---
title: "Error: Firewall No Authentication | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.firewall.noauth"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: dda1acb8-bed7-4bc8-9991-9cdc49c2ac1e
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Firewall No Authentication
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Internet Connection Firewall on the remote machine is not set up to allow remote debugging. For remote debugging with `No Authentication`, msvsmon.exe must be added to the exceptions list. Opening some IPSEC ports may be necessary as well.  
  
> [!NOTE]
> The remote debugger is able to automatically configure the Windows Firewall. When using a firewall other than the Windows Firewall such as third party software firewall or a hardware firewall, the firewall must be manually configured to allow remote debugging. To do so, allow traffic on TCP/IP ports that msvsmon.exe is listening on. By default, these are port 4018 and 4019, where 4018 is used on all Operating Systems, and 4019 is used only on Windows x64 to allow debugging x86 processes.  
  
 For more information, see [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c).
