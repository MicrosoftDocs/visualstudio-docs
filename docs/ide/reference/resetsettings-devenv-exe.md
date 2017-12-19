---
title: "-ResetSettings (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Devenv, /ResetSettings switch"
  - "ResetSettings switch"
  - "/ResetSettings Devenv switch"
ms.assetid: 1d41021c-6f58-4bd5-b122-d1c995812192
caps.latest.revision: 10
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# /ResetSettings (devenv.exe)
Restores [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] default settings and automatically launches the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE. Optionally resets the settings to a specified .vssettings file.  
  
 The default settings are determined by the profile that was selected when [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] was first launched.  
  
## Syntax  
  
```  
Devenv /ResetSettings SettingsFile  
```  
  
## Arguments  
 `SettingsFile`  
 The full path and name of the .vssettings file to apply to [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
 To restore the General Development Settings profile, use `General`.  
  
## Remarks  
 If no `SettingsFile` is specified, you will be prompted to select a default collection of settings the next time you start [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## Example  
 The following command line applies the settings stored in the file `MySettings.vssettings`.  
  
```  
Devenv.exe /ResetSettings "C:\My Files\MySettings.vssettings"  
```  
  
## See Also  
 [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)   
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)