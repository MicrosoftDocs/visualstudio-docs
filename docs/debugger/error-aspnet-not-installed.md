---
title: "Error: ASP.NET Not Installed | Microsoft Docs"
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
  - "vs.debug.error.http_not_supported"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Web applications, errors"
  - "debugger, Web application errors"
  - "error messages, ASP.NET"
  - "ASP.NET, installation error messages"
ms.assetid: 6286dd3d-3e2b-4edd-959d-81e0ed45500b
caps.latest.revision: 14
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
# Error: ASP.NET Not Installed
This error occurs when [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] is not installed correctly on the computer that you are trying to debug. This might mean that [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] was never installed or that [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] was installed first and IIS was installed later.  
  
### To reinstall ASP.NET  
  
1.  From a command prompt window, run the following command:  
  
    ```  
    \WINDOWS\Microsoft.NET\Framework\version\aspnet_regiis -i  
    ```  
  
     where *version* represents the version number of the .NET Framework installed on your computer, such as v1.0.370. You can determine the framework version by looking in the `\WINDOWS\Microsoft.NET\Framework` directory.  
  
    > [!NOTE]
    >  With Windows Server 2003, you can install [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] by using **Add or Remove Programs** in Control Panel.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)