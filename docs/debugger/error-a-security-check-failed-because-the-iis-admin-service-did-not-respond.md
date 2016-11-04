---
title: "Error: A Security Check Failed Because the IIS Admin Service Did Not Respond | Microsoft Docs"
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
  - "vs.debug.error.iis_not_responding"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
ms.assetid: 6060e94e-71dc-49f2-bb59-2584216eadbf
caps.latest.revision: 10
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
# Error: A Security Check Failed Because the IIS Admin Service Did Not Respond
This error occurs when the IIS Admin Service does not respond. This usually indicates that there is a problem with the IIS installation. First, verify that the service is running using the **Services** tool from **Administrative Tools**.  
  
### To correct this error  
  
-   Reinstall IIS, using the **Add or Remove Programs** control panel.  
  
-   -or-  
  
-   Remove IIS from your machine, using the Add or Remove Programs control panel. If you have removed IIS and still have problems, check the registry and make sure this key no longer exists:  
  
    ```  
    HKEY_CLASSES_ROOT\CLSID\{A9E69610-B80D-11D0-B9B9-00A0C922E750}  
    ```  
  
     -or-  
  
-   Disable the IIS Admin service, using the Administrative Tools control panel. This will disable IIS on your machine.  
  
     After performing any of these three steps, restart your machine.  
  
     For additional information, see the IIS documentation.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)