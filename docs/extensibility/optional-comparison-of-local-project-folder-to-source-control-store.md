---
title: "Optional Comparison of Local Project Folder to Source Control Store"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "source control plug-ins, comparing versions"
  - "source control plug-ins, local project folders"
ms.assetid: 65217e8b-15a6-4446-92b0-4cff1c6220f5
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
# Optional Comparison of Local Project Folder to Source Control Store
In Source control Plug-in API 1.2 the comparison between the local project folder and source control is accomplished by using the functions [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md) and [SccDirDiff](../extensibility/sccdirdiff-function.md).  
  
 Within **Solution Explorer**, if a folder is selected instead of an individual file, the **Compare versions** shortcut menu invokes the new [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md) and [SccDirDiff](../extensibility/sccdirdiff-function.md) in the source control plug-in.  
  
## New Capability Flags  
 `SCC_CAP_DIRECTORYDIFF`  
  
 `SCC_CAP_DIRECTORYCHECKOUT`  
  
## New Functions  
 [SccDirDiff](../extensibility/sccdirdiff-function.md)  
  
 [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md)  
  
 The `SccDirQueryInfo` function is called before `SccDirDiff` to determine if the working directory is source-controlled. The `SccDirDiff` function displays the differences between the current local directory and the corresponding source control folder. This command asks the source control plug-in to display the list of changes to the directory. A source control plug-in provides its own UI to display the differences.  
  
> [!NOTE]
>  This function uses the same command flags as [SccDiff](../extensibility/sccdiff-function.md). As a source control plug-in provider, you may choose to not support the "quick diff" operation for directories.  
  
## See Also  
 [What's New in the Source Control Plug-in API Version 1.2](../extensibility/what-s-new-in-the-source-control-plug-in-api-version-1.2.md)