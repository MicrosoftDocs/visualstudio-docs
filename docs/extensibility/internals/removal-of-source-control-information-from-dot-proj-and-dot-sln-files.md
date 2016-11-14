---
title: "Removal of Source Control Information from .Proj and .Sln Files | Microsoft Docs"
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
  - "source control plug-ins, .sln and .proj files"
ms.assetid: 7b06883f-35de-41e2-9a9e-d3edba236f17
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
# Removal of Source Control Information from .Proj and .Sln Files
In version 1.2 of the Source Control Plug-in API the SCC information is stored in a MSSCCPRJ.SCC file. The advantage of the MSSCCPRJ.SCC file is that the SCC information is not source -controlled, like it is in .proj and .sln files.  
  
## Version 1.2 Changes  
 In source control plug-ins that are based on the Source Control Plug-in API version 1.1, information about source control is stored in the project (.proj) and solution (.sln) files. The database location of the source control information is specified by the AuxPath, and the specific location within the database is specified by ProjName. This behavior can cause problems after branch, fork, or copy operations because the ProjName would typically be invalid after any of these operations.  
  
 In the Source Control Plug-in API version 1.1, the IDE used ~SAK files to detect if a plug-in supported the MSSCCPRJ.SCC method of storing source control information. The Source Control Plug-in API version 1.2 provides a new capability for detecting the support for MSSCCPRJ.SCC file without using a ~SAK file. For more information, see [Elimination of ~SAK Files](../../extensibility/internals/elimination-of-tilde-sak-files.md).  
  
## See Also  
 [What's New in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)