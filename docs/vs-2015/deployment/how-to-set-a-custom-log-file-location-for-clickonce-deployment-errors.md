---
title: "How to: Set a Custom Log File Location for ClickOnce Deployment Errors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "troubleshooting ClickOnce deployments"
  - "ClickOnce deployment, troubleshooting"
  - "ClickOnce deployment, error logging"
ms.assetid: 77424414-7f0e-4b99-94bb-ea130de92d09
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Set a Custom Log File Location for ClickOnce Deployment Errors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] maintains activation log files for all deployments. These logs document any errors pertaining to installing and initializing a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment. By default, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] creates one log file for each deployment activation. It stores these log files in the Temporary Internet Files folder. The log file for a deployment is displayed to the user when an activation failure occurs, and the user clicks **Details** in the resulting error dialog box.  
  
 You can change this behavior for a specific client by using Registry Editor (**regedit.exe**) to set a custom log file path. In this case, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] logs activation successes and failures for all deployments in a single file.  
  
> [!CAUTION]
> If you use Registry Editor incorrectly, you may cause serious problems that may require you to reinstall your operating system. Use Registry Editor at your own risk.  
  
> [!NOTE]
> You will need to truncate or delete the log file occasionally to prevent it from growing too large.  
  
 The following procedure describes how to set a custom log file location for a single client.  
  
### To set a custom log file location  
  
1. Open **Regedit.exe**.  
  
2. Navigate to the node `HKCU\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment`.  
  
3. Set the string value `LogFilePath` to the full path and filename of your preferred custom log location.  
  
     This location must be in a directory to which the user has write access. For example, on Windows Vista, create the following folder structure and set `LogFilePath` to C:\Users\\<username\>\Documents\Logs\ClickOnce\installation.log.  
  
## See Also  
 [Troubleshooting ClickOnce Deployments](../deployment/troubleshooting-clickonce-deployments.md)
