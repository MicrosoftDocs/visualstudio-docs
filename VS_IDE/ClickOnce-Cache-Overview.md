---
title: "ClickOnce Cache Overview"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e379921e-9ef1-4326-bbf3-53ba67925526
caps.latest.revision: 12
manager: wpickett
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
# ClickOnce Cache Overview
All ClickOnce applications, whether they are installed locally or hosted online, are stored on the client computer in a ClickOnceapplication *cache*. A ClickOnce cache is a family of hidden directories under the Local Settings directory of the current user's Documents and Settings folder. This cache holds all the application's files, including the assemblies, configuration files, application and user settings, and data directory. The cache is also responsible for migrating the application's data directory to the latest version. For more information about data migration, see [Accessing Local and Remote Data in ClickOnce Applications](../VS_IDE/Accessing-Local-and-Remote-Data-in-ClickOnce-Applications.md).  
  
 By providing a single location for application storage, ClickOnce takes over the task of managing the physical installation of an application from the user. The cache also helps isolate applications by keeping the assemblies and data files for all applications and their distinct versions separate from one another. For example, when you upgrade a ClickOnce application, that version and its data resources are supplied with their own directories in the cache.  
  
## Cache Storage Quota  
 ClickOnce applications that are hosted online are restricted in the amount of space they can occupy by a quota that constrains the size of the ClickOnce cache. The cache size applies to all the user's online applications; a single partially-trusted, online application is limited to occupying half of the quota space. Installed applications are not limited by the cache size and do not count against the cache limit. For all ClickOnce applications, the cache retains only the current version and the previously installed version.  
  
 By default, client computers have 250 MB of storage for online ClickOnce applications. Data files do not count toward this limit. A system administrator can enlarge or reduce this quota on a particular client computer by changing the registry key, HKEY_CURRENT_USER\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment\OnlineAppQuotaInKB, which is a DWORD value that expresses the cache size in kilobytes. For example, in order to reduce the cache size to 50 MB, you would change this value to 51200.  
  
## See Also  
 [Accessing Local and Remote Data in ClickOnce Applications](../VS_IDE/Accessing-Local-and-Remote-Data-in-ClickOnce-Applications.md)