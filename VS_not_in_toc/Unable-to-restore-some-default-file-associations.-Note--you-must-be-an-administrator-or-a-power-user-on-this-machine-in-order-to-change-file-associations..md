---
title: "Unable to restore some default file associations. Note: you must be an administrator or a power user on this machine in order to change file associations."
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 449c5608-83e3-4ddd-91f1-1061916995b3
caps.latest.revision: 6
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Unable to restore some default file associations. Note: you must be an administrator or a power user on this machine in order to change file associations.
This error occurs when the devenv command-line switch /AssociateFiles is used, but the current user rights do not allow access to the HKEY_CLASSES_ROOT section of the registry. When you run Visual Studio on Windows Vista, you must run devenv as an administrator to use the /AssociateFiles (devenv.exe) switch.  
  
### To correct this error  
  
-   Change to administrative credentials and try again.  
  
## See Also  
 [User Rights and Visual Studio](assetId:///d5c55084-1e7b-4b61-b478-137db01c0fc0)   
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)