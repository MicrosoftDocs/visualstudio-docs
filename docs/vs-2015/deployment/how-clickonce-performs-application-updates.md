---
title: "How ClickOnce Performs Application Updates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "updates, ClickOnce"
  - "ClickOnce deployment, updates"
  - "deploying applications [ClickOnce], application updates"
ms.assetid: d54313c2-cf0c-420d-b151-99953a95f0bb
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How ClickOnce Performs Application Updates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

ClickOnce uses the file version information specified in an application's deployment manifest to decide whether to update the application's files. After an update begins, ClickOnce uses a technique called *file patching* to avoid redundant downloading of application files.  
  
## File Patching  
 When updating an application, ClickOnce does not download all of the files for the new version of the application unless the files have changed. Instead, it compares the hash signatures of the files specified in the application manifest for the current application against the signatures in the manifest for the new version. If a file's signatures are different, ClickOnce downloads the new version. If the signatures match, the file has not changed from one version to the next. In this case, ClickOnce copies the existing file and uses it in the new version of the application. This approach prevents ClickOnce from having to download the entire application again, even if only one or two files have changed.  
  
 File patching also works for assemblies that are downloaded on demand using the <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroup%2A> and <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroupAsync%2A> methods.  
  
 If you use Visual Studio to compile your application, it will generate new hash signatures for all files whenever you rebuild the entire project. In this case, all assemblies will be downloaded to the client, although only a few assemblies may have changed.  
  
 File patching does not work for files that are marked as data and stored in the data directory. These are always downloaded regardless of the file's hash signature. For more information on the data directory, see [Accessing Local and Remote Data in ClickOnce Applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md).  
  
## See also  
 [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md)   
 [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
