---
title: "Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network. | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.remote.dcom_disabled"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "DCOM, unable to connect error"
ms.assetid: b584b5db-ef52-45ed-8561-1314da3cc5b8
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network.
This behavior occurs if one of the following conditions is true:  
  
-   Your connection to the remote computer was broken.  
  
-   Your user account on the remote computer is disabled.  
  
-   Your password on the remote computer has expired.  
  
### To resolve this behavior  
  
-   Make sure that the local computer and the remote computer are in the same network. To do this, use Microsoft Windows Explorer (or File Explorer) to try to access the remote computer.  
  
     — and —  
  
-   Make sure that the user account that you are using to connect to the remote computer is enabled.  
  
     — and —  
  
-   Make sure that the password that you are using to connect to the remote computer is valid and has not expired.  
  
## See Also  
 [Set Up the Remote Tools on the Device](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md)   
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)