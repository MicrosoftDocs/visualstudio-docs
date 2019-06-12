---
title: "Error: ASP.NET Not Installed | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
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
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: ASP.NET Not Installed
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This error occurs when [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] is not installed correctly on the computer that you are trying to debug. This might mean that [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] was never installed or that [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] was installed first and IIS was installed later.  
  
### To reinstall ASP.NET  
  
1. From a command prompt window, run the following command:  
  
    ```  
    \WINDOWS\Microsoft.NET\Framework\version\aspnet_regiis -i  
    ```  
  
     where *version* represents the version number of the .NET Framework installed on your computer, such as v1.0.370. You can determine the framework version by looking in the `\WINDOWS\Microsoft.NET\Framework` directory.  
  
    > [!NOTE]
    > With Windows Server 2003, you can install [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] by using **Add or Remove Programs** in Control Panel.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
