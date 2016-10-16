---
title: "Error: You do not have permission to inspect the process&#39;s identity"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 6233d060-85b8-42be-ae5f-bde7e1d0f241
caps.latest.revision: 5
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
# Error: You do not have permission to inspect the process&#39;s identity
You do not have permission to inspect the process's identity. This may be due to your system's configuration.  
  
 The debugger was not able to inspect the process identity, which is necessary information for debugging. The most likely cause is Terminal Services being disabled. Terminal Services service is enabled by default. Follow these steps to re-enable it.  
  
### To enable Terminal Services  
  
1.  Click **Start** and then choose **Control Panel**.  
  
2.  In Control Panel, choose **Switch to Classic View**, if necessary, and then double-click **Administrative Tools**.  
  
3.  In the **Administrative Tools** window, double-click **Computer Management**.  
  
4.  In the Computer Management window, expand the **Services and Applications** node.  
  
5.  Under the **Services and Applications**, click **Services**.  
  
     A list of services appears in the right pane.  
  
6.  In the **Services** list, right-click **Terminal Services** and then choose **Properties**.  
  
7.  In the **Terminal Services Properties** window, go to the **General** tab and set **Startup type** to **Manual**.  
  
8.  Click **OK**.  
  
9. Restart the computer.  
  
     This procedure does not automatically enable Remote Desktop. If you want to enable Remote Desktop on your computer, perform the following additional procedure.  
  
### To enable Remote Desktop  
  
1.  Click **Start** and then right-click **My Computer**.  
  
2.  Choose **Properties**.  
  
     The **System Properties** window is displayed.  
  
3.  Click **Remote**.  
  
4.  Under **Remote Desktop**, select **Allow users to connect remotely to this computer**.  
  
5.  Click **OK**.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)