---
title: "IDebugProcessQueryProperties"
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
  - "IDebugProcessQueryProperties"
ms.assetid: ce29a248-81a0-42c0-99a7-1606e8c548ec
caps.latest.revision: 4
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
# IDebugProcessQueryProperties
This interface is an extension interface implemented by [IDebugProcess2](../extensibility/idebugprocess2.md) implementers. It allows the implementer to get information on the debugging process environment.  
  
## Syntax  
  
```  
IDebugProcessQueryProperties: IUnknown  
```  
  
## Notes for Implementers  
 Implement this interface to get information on the execution environment of a debugging process.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcessQueryProperties`.  
  
|Method|Description|  
|------------|-----------------|  
|[QueryProperty](../extensibility/idebugprocessqueryproperties--queryproperty.md)|Queries for a property value.|  
|[QueryProperties](../extensibility/idebugprocessqueryproperties--queryproperties.md)|Queries for property values.|  
  
## Remarks  
 This interface is seldom implemented.  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProcess2](../extensibility/idebugprocess2.md)