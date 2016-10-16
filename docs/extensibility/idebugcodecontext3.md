---
title: "IDebugCodeContext3"
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
  - "IDebugCodeContext3 interface"
ms.assetid: 524eb882-0ad5-4bfb-95eb-eb3abb3d0237
caps.latest.revision: 8
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
# IDebugCodeContext3
Extends the [IDebugCodeContext2](../extensibility/idebugcodecontext2.md) interface to enable the retrieval of module and process interfaces.  
  
## Syntax  
  
```  
IDebugCodeContext3 : IDebugCodeContext2  
```  
  
## Notes for Implementers  
 Implemented by debug engines and consumed by the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Debug package.  
  
## Methods  
 In addition to the methods on the `IDebugCodeContext2` interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetModule](../extensibility/idebugcodecontext3--getmodule.md)|Retrieves a reference to the interface of the debug module.|  
|[GetProcess](../extensibility/idebugcodecontext3--getprocess.md)|Retrieves a reference to the interface of the debug process.|  
  
## Remarks  
 This is an optional interface which generally does not have to be implemented.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll