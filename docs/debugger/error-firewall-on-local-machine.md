---
title: "Error: Firewall on Local Machine | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "vs.debug.error.firewall.localmachine"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Error: Firewall on Local Machine
The Internet Connection Firewall on the local machine, the machine you are running Visual Studio from, is not set up to allow remote debugging. For managed or native remote debugging with the default transport, the TCP 135 port must be opened for DCOM traffic. File and printer sharing must be opened, and devenv.exe must be added to the exceptions list. Opening some IPSEC ports may be necessary as well.  
  
 For more information, see [Remote Debugging](../debugger/remote-debugging.md).