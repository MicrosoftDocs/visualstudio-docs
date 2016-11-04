---
title: "ClickOnce and Application Settings | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, application settings"
ms.assetid: 891caba6-faef-4a3c-8f71-60e6fadb60eb
caps.latest.revision: 10
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# ClickOnce and Application Settings
Application settings for Windows Forms makes it easy to create, store, and maintain custom application and user preferences on the client. The following document describes how application settings files work in a ClickOnce application, and how ClickOnce migrates settings when the user upgrades to the next version.  
  
 The information below applies only to the default application settings provider, the <xref:System.Configuration.LocalFileSettingsProvider> class. If you supply a custom provider, that provider will determine how it stores its data and how it upgrades its settings between versions. For more information on application settings providers, see [Application Settings Architecture](../Topic/Application%20Settings%20Architecture.md).  
  
## Application Settings Files  
 Application settings consumes two files: *app*.exe.config and user.config, where *app* is the name of your Windows Forms application. user.config is created on the client the first time your application stores user-scoped settings. *app*.exe.config, by contrast, will exist prior to deployment if you define default values for settings. Visual Studio will include this file automatically when you use its **Publish** command. If you create your ClickOnce application using Mage.exe or MageUI.exe, you must make sure this file is included with your application's other files when you populate your application manifest.  
  
 In a Windows Forms applications not deployed using ClickOnce, an application's *app*.exe.config file is stored in the application directory, while the user.config file is stored in the user's **Documents and Settings** folder. In a ClickOnce application, *app*.exe.config lives in the application directory inside of the ClickOnce application cache, and user.config lives in the ClickOnce data directory for that application.  
  
 Regardless of how you deploy your application, application settings ensures safe read access to *app*.exe.config, and safe read/write access to user.config.  
  
 In a ClickOnce application, the size of the configuration files used by application settings is constrained by the size of the ClickOnce cache. For more information, see [ClickOnce Cache Overview](../deployment/clickonce-cache-overview.md).  
  
## Version Upgrades  
 Just as each version of a ClickOnce application is isolated from all other versions, the application settings for a ClickOnce application are isolated from the settings for other versions as well. When your user upgrades to a later version of your application, application settings compares most recent (highest-numbered) version's settings against the settings supplied with the updated version and merges the settings into a new set of settings files.  
  
 The following table describes how application settings decides which settings to copy.  
  
|Type of Change|Upgrade Action|  
|--------------------|--------------------|  
|Setting added to *app*.exe.config|The new setting is merged into the current version's *app*.exe.config|  
|Setting removed from *app*.exe.config|The old setting is removed from the current version's *app*.exe.config|  
|Setting's default changed; local setting still set to original default in user.config|The setting is merged into the current version's user.config with the new default as the value|  
|Setting's default changed; setting set to non-default in user.config|The setting is merged into the current version's user.config with the non-default value retained|  
  
 If you have created your own application settings wrapper class and wish to customize the update logic, you can override the <xref:System.Configuration.ApplicationSettingsBase.Upgrade%2A> method.  
  
## ClickOnce and Roaming Settings  
 ClickOnce does not work with roaming settings, which allows your settings file to follow you across machines on a network. If you need roaming settings, you will need either to implement an application settings provider that stores settings over the network, or develop your own custom settings classes for storing settings on a remote computer. For more information in settings providers, see [Application Settings Architecture](../Topic/Application%20Settings%20Architecture.md).  
  
## See Also  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [Application Settings Overview](../Topic/Application%20Settings%20Overview.md)   
 [ClickOnce Cache Overview](../deployment/clickonce-cache-overview.md)   
 [Accessing Local and Remote Data in ClickOnce Applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md)