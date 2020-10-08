---
title: "Application of Settings Across Multiple Project Connections | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "source control plug-ins, application of settings"
ms.assetid: 2116d3d0-c46c-4d0a-b482-08a178584f46
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Application of Settings Across Multiple Project Connections
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A source control plug-in built using the Source Control Plug-in API 1.2, can use a batch operation to execute the same source control operation across multiple projects or multiple connection contexts. Batches can be used to eliminate redundant, per-project dialog boxes from the user experience.  
  
 If a user selects multiple items that belong to more than one connection in a source control plug-in built using the Source Control Plug-in API 1.1,  (for example, two Web projects on different file-share machines) and checks them out, the user sees the same dialog box repeatedly. This happens even if the user clicks the **Apply to All** check box in the dialog box, because the IDE resets its state for each connection context.  
  
## New Capability Flag  
 `SccBeginBatch` Function sets the `SCC_CAP_BATCH` flag to indicate that a batch operation is in progress  
  
## New Functions  
 The following new functions support the batch operation:  
  
- [SccBeginBatch](../../extensibility/sccbeginbatch-function.md)  
  
- [SccEndBatch](../../extensibility/sccendbatch-function.md)  
  
  The `SCCBeginBatch` function starts a group of source control operations. `SccEndBatch` closes the group. The groups may not be nested.  
  
## See Also  
 [What's New in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)
