---
title: "Error: Remote machine does not appear in a Remote Connections dialog | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 5fd98a5b-2cf3-4438-8b0f-6f1a742a62ce
caps.latest.revision: 5
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Remote machine does not appear in a Remote Connections dialog
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If the remote machine does not appear in the Remote Connections dialog, check the following common causes.  
  
 If you are using managed compatibility mode, please check the Visual Studio 2010 documentation: [Troubleshooting Remote Debugging - Visual Studio 2010](https://msdn.microsoft.com/library/2ys11ead\(v=vs.100\).aspx) .  
  
### Common causes for this error  
  
- The remote machine is running on a machine that is in a different subnet. To fix this, manually type the machine name or IP address in the Qualifier dialog  
  
- The remote debugger is not running on the remote machine. To fix this, start the remote debugger.  
  
- The firewall is blocking communication between Visual Studio and the remote machine. To fix this, configure your firewall to allow Visual Studio and the remote debugger (msvsmon) to communicate.  
  
- Antivirus software is blocking communication between Visual Studio and the remote machine. To fix this, configure antivirus software to allow Visual Studio and the remote debugger (msvsmon) to communicate.  
  
## See Also  
 [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c)
