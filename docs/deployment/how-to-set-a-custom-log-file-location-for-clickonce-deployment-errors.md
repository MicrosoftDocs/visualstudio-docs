---
title: "How to: Set a Custom Log File Location for ClickOnce Deployment Errors | Microsoft Docs"
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
  - "troubleshooting ClickOnce deployments"
  - "ClickOnce deployment, troubleshooting"
  - "ClickOnce deployment, error logging"
ms.assetid: 77424414-7f0e-4b99-94bb-ea130de92d09
caps.latest.revision: 9
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
# How to: Set a Custom Log File Location for ClickOnce Deployment Errors
[!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] maintains activation log files for all deployments. These logs document any errors pertaining to installing and initializing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment. By default, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] creates one log file for each deployment activation. It stores these log files in the Temporary Internet Files folder. The log file for a deployment is displayed to the user when an activation failure occurs, and the user clicks **Details** in the resulting error dialog box.  
  
 You can change this behavior for a specific client by using Registry Editor (**regedit.exe**) to set a custom log file path. In this case, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] logs activation successes and failures for all deployments in a single file.  
  
> [!CAUTION]
>  If you use Registry Editor incorrectly, you may cause serious problems that may require you to reinstall your operating system. Use Registry Editor at your own risk.  
  
> [!NOTE]
>  You will need to truncate or delete the log file occasionally to prevent it from growing too large.  
  
 The following procedure describes how to set a custom log file location for a single client.  
  
### To set a custom log file location  
  
1.  Open **Regedit.exe**.  
  
2.  Navigate to the node `HKCU\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment`.  
  
3.  Set the string value `LogFilePath` to the full path and filename of your preferred custom log location.  
  
     This location must be in a directory to which the user has write access. For example, on Windows Vista, create the following folder structure and set `LogFilePath` to C:\Users\\<username\>\Documents\Logs\ClickOnce\installation.log.  
  
## See Also  
 [Troubleshooting ClickOnce Deployments](../deployment/troubleshooting-clickonce-deployments.md)