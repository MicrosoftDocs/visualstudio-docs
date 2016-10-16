---
title: "IDebugProgramDestroyEventFlags2"
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
  - "IDebugProgramDestroyEventFlags2 interface"
ms.assetid: d384ff71-dc71-40b9-a871-801f8b6a3418
caps.latest.revision: 7
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
# IDebugProgramDestroyEventFlags2
Enables a debug engine to override the default behavior of the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] UI when you end a debug session.  
  
## Syntax  
  
```  
IDebugProgramDestroyEventFlags2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by debug engines. It is useful for hosts that might create and destroy multiple programs over the lifetime of a process.  
  
## Methods  
 The following table shows the methods of `IDebugProgramDestroyEventFlags2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFlags](../extensibility/idebugprogramdestroyeventflags2--getflags.md)|Retrieves the program destroy flags.|  
  
## Remarks  
 The default behavior of the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] UI is to go back to design mode after all programs have sent a program destroy event. This interface enables a debug engine to change that behavior.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll