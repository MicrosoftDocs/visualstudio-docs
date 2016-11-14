---
title: "Uninstalling a VSPackage With Windows Installer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "packages, uninstalling"
  - "VSPackages, uninstalling"
  - "uninstalling VSPackages"
ms.assetid: c4575ac7-82da-4af8-a375-ea756a101fbf
caps.latest.revision: 14
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Uninstalling a VSPackage With Windows Installer
For the most part, Windows Installer can uninstall your VSPackage just by "undoing" what it did to install your VSPackage. The custom actions discussed in [Commands That Must Be Run After Installation](../../extensibility/internals/commands-that-must-be-run-after-installation.md) must be run after an uninstall as well. Because the calls to devenv.exe occur just before the InstallFinalize standard action for both installation and uninstallation, the CustomAction and InstallExecuteSequence table entries serve both cases.  
  
> [!NOTE]
>  Run `devenv /setup` after you uninstall an MSI package.  
  
 As a general rule, if you add custom actions to a Windows Installer package, you must handle those actions during uninstallation and rollback. If you add custom actions to self-register your VSPackage, for example, you must add custom actions to unregister it, too.  
  
> [!NOTE]
>  It is possible for a user to install your VSPackage and then uninstall the versions of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] with which it is integrated. You can help ensure that your VSPackage's uninstallation works in that scenario by eliminating custom actions that run code with dependencies on [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## Handling Launch Conditions at Uninstall Time  
 The LaunchConditions standard action reads the rows of the LaunchCondition table to show error messages if the conditions are not met. As launch conditions are generally used to ensure that system requirements are met, you can generally skip launch conditions during uninstallation by adding the condition, `NOT Installed`, to the LaunchConditions row of the LaunchCondition table.  
  
 An alternative is to add `OR Installed` to launch conditions that are not important during uninstallation. That ensures that the condition will always be true during uninstallation and therefore will not display the launch condition error message.  
  
> [!NOTE]
>  `Installed` is the property Windows Installer sets when it detects that your VSPackage has already been installed on the system.  
  
## See Also  
 [Windows Installer](http://msdn.microsoft.com/en-us/187d8965-c79d-4ecb-8689-10930fa8b3b5)   
 [Detecting System Requirements](../../extensibility/internals/detecting-system-requirements.md)