---
title: "What&#39;s New in the Source Control Plug-in API Version 1.3 | Microsoft Docs"
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
  - "source control plug-ins, what's new in API v1.3"
  - "what's new [Visual Studio SDK], source control plug-ins"
ms.assetid: 7dfb2227-6e1d-4028-bce9-f8967456a993
caps.latest.revision: 13
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
# What&#39;s New in the Source Control Plug-in API Version 1.3
The Source Control Plug-in API version 1.3 introduces the following new functions to provide more advanced control.  
  
## Changes  
 The following functions are new to the Source Control Plug-in API version 1.3:  
  
|Function|Overview|  
|--------------|--------------|  
|[SccGetExtendedCapabilities](../../extensibility/sccgetextendedcapabilities-function.md)|Allows additional capability bits to be reported|  
|[SccEnumChangedFiles](../../extensibility/sccenumchangedfiles-function.md)|Allows examination of files that have newer versions in the version control database than on the local disk|  
|[SccQueryChanges](../../extensibility/sccquerychanges-function.md)|Allows examination of the state of name changes (renames, additions, and deletions) for specified files|  
|[SccPopulateDirList](../../extensibility/sccpopulatedirlist-function.md)|Allows examination of directories and files in the version control database|  
|[SccAddFilesFromSCC](../../extensibility/sccaddfilesfromscc-function.md)|Adds a specified list of files from the version control database to the current project|  
|[SccBackgroundGet](../../extensibility/sccbackgroundget-function.md)|Performs a silent "Get" of the specified files (no user interface is shown)|  
|[SccGetUserOption](../../extensibility/sccgetuseroption-function.md)|Allows access to user-specific options|  
  
## See Also  
 [Getting Started](../../extensibility/internals/getting-started-with-source-control-plug-ins.md)   
 [What's New in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)