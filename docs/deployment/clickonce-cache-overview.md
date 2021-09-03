---
title: "ClickOnce Cache Overview | Microsoft Docs"
description: Learn about the ClickOnce application cache, which includes hidden directories on a client computer where ClickOnce applications are stored. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Windows applications, ClickOnce deployemtn"
  - "ClickOnce applications, cache"
  - "ClickOnce deployment, cache"
ms.assetid: e379921e-9ef1-4326-bbf3-53ba67925526
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# ClickOnce cache overview
All [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications, whether they are installed locally or hosted online, are stored on the client computer in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application *cache*. A [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] cache is a family of hidden directories under the Local Settings directory of the current user's Documents and Settings folder. This cache holds all the application's files, including the assemblies, configuration files, application and user settings, and data directory. The cache is also responsible for migrating the application's data directory to the latest version. For more information about data migration, see [Accessing Local and Remote Data in ClickOnce Applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md).

 By providing a single location for application storage, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] takes over the task of managing the physical installation of an application from the user. The cache also helps isolate applications by keeping the assemblies and data files for all applications and their distinct versions separate from one another. For example, when you upgrade a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, that version and its data resources are supplied with their own directories in the cache.

## Cache storage quota
 [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications that are hosted online are restricted in the amount of space they can occupy by a quota that constrains the size of the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] cache. The cache size applies to all the user's online applications; a single partially-trusted, online application is limited to occupying half of the quota space. Installed applications are not limited by the cache size and do not count against the cache limit. For all [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications, the cache retains only the current version and the previously installed version.

 By default, client computers have 250 MB of storage for online [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications. Data files do not count toward this limit. A system administrator can enlarge or reduce this quota on a particular client computer by changing the registry key, **HKEY_CURRENT_USER\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment\OnlineAppQuotaInKB**, which is a DWORD value that expresses the cache size in kilobytes. For example, in order to reduce the cache size to 50 MB, you would change this value to 51200.

## See also
- [Access local and remote data in ClickOnce applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md)