---
title: "How to: Specify Verbose Log Files for ClickOnce Deployments | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "logs, ClickOnce deployment"
  - "ClickOnce deployment, logging"
ms.assetid: 0807a28d-2e40-4a51-ab10-308d808ded6b
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify Verbose Log Files for ClickOnce Deployments
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] maintains activity log files for all deployments. These logs document details pertaining to installing, initializing, updating, and uninstalling a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment. To increase the detail that [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] writes to these log files, use Registry Editor (**regedit.exe**) to specify the verbosity level.  
  
> [!CAUTION]
> If you use Registry Editor incorrectly, you may cause serious problems that may require you to reinstall the operating system. Use Registry Editor at your own risk.  
  
 The following procedure describes how to specify the verbosity level for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] log files for the current user. To reduce the level of verbosity, remove this registry value.  
  
### To specify verbose log files  
  
1. Open **Regedit.exe**.  
  
2. Navigate to the node `HKEY_CURRENT_USER\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment`.  
  
3. If necessary, create a new string value named `LogVerbosityLevel`.  
  
4. Set the `LogVerbosityLevel` value to `1`.  
  
## See Also  
 [Troubleshooting ClickOnce Deployments](../deployment/troubleshooting-clickonce-deployments.md)
