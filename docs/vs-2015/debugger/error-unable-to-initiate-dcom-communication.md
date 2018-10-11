---
title: "Error: Unable to initiate DCOM communication | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.unmarshal_server_failed"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 2a7b27e6-2526-4f32-bc4d-eaee447f24ec
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Error: Unable to initiate DCOM communication
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [Error: Unable to initiate DCOM communication](https://docs.microsoft.com/visualstudio/debugger/error-unable-to-initiate-dcom-communication).  
  
A DCOM error occurred when the local machine tried to communicate with the remote machine. This is caused by a firewall on the remote server or broken Windows authentication on the remote machine.  
  
### To correct this error  
  
-   If the remote machine has Windows Firewall enabled, see [Set Up the Remote Tools on the Device](http://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c) for instructions about how to configure the firewall for local debugging.  
  
-   To restore Windows authentication, try rebooting both machines. Examine event logs on local and remote machines for Kerberos errors and contact domain administrators for known problems.  
  
## See Also  
 [Remote Debugging](../debugger/remote-debugging.md)



