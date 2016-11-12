---
title: "Error: Remote machine does not appear in a Remote Connections dialog | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 5fd98a5b-2cf3-4438-8b0f-6f1a742a62ce
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Error: Remote machine does not appear in a Remote Connections dialog
If the remote machine does not appear in the Remote Connections dialog, check the following common causes.  
  
 If you are using managed compatibility mode, please check the Visual Studio 2010 documentation: [Troubleshooting Remote Debugging - Visual Studio 2010](https://msdn.microsoft.com/en-us/library/2ys11ead\(v=vs.100\).aspx) .  
  
### Common causes for this error  
  
-   The remote machine is running on a machine that is in a different subnet. To fix this, manually type the machine name or IP address in the Qualifier dialog  
  
-   The remote debugger is not running on the remote machine. To fix this, start the remote debugger.  
  
-   The firewall is blocking communication between Visual Studio and the remote machine. To fix this, configure your firewall to allow Visual Studio and the remote debugger (msvsmon) to communicate.  
  
-   Antivirus software is blocking communication between Visual Studio and the remote machine. To fix this, configure antivirus software to allow Visual Studio and the remote debugger (msvsmon) to communicate.  
  
## See Also  
 [Set Up the Remote Tools on the Device](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md)