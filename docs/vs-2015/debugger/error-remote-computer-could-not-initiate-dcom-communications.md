---
title: "Error: Remote computer could not initiate DCOM communications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.unmarshal_callback_failed"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: bbba0766-2502-4ef1-a75d-bf1f0db39e37
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Remote computer could not initiate DCOM communications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A DCOM error occurred when the remote machine tried to communicate with the local machine. The local machine is the machine that is  
  
 running Visual Studio. This error can occur for several reasons:  
  
- The local machine has a firewall enabled.  
  
- Windows authentication from the remote machine to the local machine is not working.  
  
### To correct this error  
  
1. If the local machine has Windows Firewall enabled, see [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c) for instructions about how to configure the firewall for local debugging.  
  
2. Test Windows authentication by trying to open a file share on the local machine from the remote server.  
  
3. To restore Windows authentication, try rebooting both machines. Examine event logs on local and remote machines for Kerberos errors and contact domain administrators for known problems.  
  
## See Also  
 [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c)
