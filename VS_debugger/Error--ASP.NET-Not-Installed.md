---
title: "Error: ASP.NET Not Installed"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6286dd3d-3e2b-4edd-959d-81e0ed45500b
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Error: ASP.NET Not Installed
This error occurs when ASP.NET is not installed correctly on the computer that you are trying to debug. This might mean that ASP.NET was never installed or that ASP.NET was installed first and IIS was installed later.  
  
### To reinstall ASP.NET  
  
1.  From a command prompt window, run the following command:  
  
    ```  
    \WINDOWS\Microsoft.NET\Framework\version\aspnet_regiis -i  
    ```  
  
     where *version* represents the version number of the .NET Framework installed on your computer, such as v1.0.370. You can determine the framework version by looking in the `\WINDOWS\Microsoft.NET\Framework` directory.  
  
    > [!NOTE]
    >  With Windows Server 2003, you can install ASP.NET by using **Add or Remove Programs** in Control Panel.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../VS_debugger/Debugging-Web-Applications--Errors-and-Troubleshooting.md)