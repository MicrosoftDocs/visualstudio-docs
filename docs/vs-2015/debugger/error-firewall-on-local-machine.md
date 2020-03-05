---
title: "Error: Firewall on Local Machine | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.firewall.localmachine"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: ab60dda9-7934-4891-aa2f-001380d2ed83
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Firewall on Local Machine
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Internet Connection Firewall on the local machine, the machine you are running Visual Studio from, is not set up to allow remote debugging. For managed or native remote debugging with the default transport, the TCP 135 port must be opened for DCOM traffic. File and printer sharing must be opened, and devenv.exe must be added to the exceptions list. Opening some IPSEC ports may be necessary as well.  
  
 For more information, see [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c).
