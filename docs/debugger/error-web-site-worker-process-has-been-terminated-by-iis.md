---
title: "Error: Web site worker process has been terminated by IIS | Microsoft Docs"
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
  - "vs.debug.error.web_server_process_terminated"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 5707b972-71a6-4cc6-ab99-c7c00ca8628c
caps.latest.revision: 20
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
# Error: Web site worker process has been terminated by IIS
The debugger stopped execution of code on the Web site. This caused Internet Information Services (IIS) to assume that the worker process had stopped responding. Therefore, IIS terminated the worker process.  
  
 To continue to debug, you must configure IIS to allow the worker process to continue. This error message does not appear with versions of IIS that are older than IIS 7.  
  
### To configure IIS 7 to allow the worker process to continue  
  
1.  Open the **Administrative Tools** window.  
  
    1.  Click **Start**, and then choose **Control Panel**.  
  
    2.  In **Control Panel**, choose **Switch to Classic View**, if necessary, and then double-click **Administrative Tools**.  
  
2.  In the **Administrative Tools** window, double-click **Internet Information Services (IIS) Manager**.  
  
     IIS Manager opens.  
  
3.  In the **Connections** pane, expand the \<computer name> node if necessary.  
  
4.  Under the \<computer name> node, click **Application Pools**.  
  
5.  In the **Application Pools** list, right-click the name of the pool your application runs in, and then click **Advanced Settings**.  
  
6.  In the **Advanced Settings** dialog box, locate the **Process Model** section, and perform one of the following actions:  
  
    -   Set **Ping Enabled** to **False**.  
  
    -   Set **Ping Maximum Response Time** to a value that is larger than 90 seconds.  
  
     Setting **Ping Enabled** to **False** stops IIS from checking whether the worker process is still running and keeps the worker process alive until you stop your debugged process. Setting **Ping Maximum Response Time** to a large value allows IIS to continue monitoring the worker process.  
  
7.  Click **OK** to close the **Advanced Settings** dialog box.  
  
8.  Close IIS Manager and the **Administrative Tools** window.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)