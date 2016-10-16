---
title: "IDebugModule2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugModule2"
helpviewer_keywords: 
  - "IDebugModule2 interface"
ms.assetid: 24c2a126-f4ab-4891-8509-8ef99b994c08
caps.latest.revision: 12
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
# IDebugModule2
This interface represents a module—that is, an executable unit of a program—such as a DLL.  
  
## Syntax  
  
```  
IDebugModule2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a module and to provide access to information about that module.  
  
## Notes for Callers  
 A call to [GetModule](../extensibility/idebugmoduleloadevent2--getmodule.md) returns this interface. The DE sends the [IDebugModuleLoadEvent2](../extensibility/idebugmoduleloadevent2.md) interface to the session debug manager (SDM) using the [Event](../extensibility/idebugeventcallback2--event.md) method.  
  
 This interface can also be returned in a [FRAMEINFO](../extensibility/frameinfo.md) structure (which is returned by a call to [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md)).  
  
 [Next](../extensibility/ienumdebugmodules2--next.md) also returns this interface ([EnumModules](../extensibility/idebugprogram2--enummodules.md) returns the [IEnumDebugModules2](../extensibility/ienumdebugmodules2.md) interface).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugModule2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetInfo](../extensibility/idebugmodule2--getinfo.md)|Gets the [MODULE_INFO](../extensibility/module_info.md) that describes this module.|  
|[ReloadSymbols_Deprecated](../extensibility/idebugmodule2--reloadsymbols_deprecated.md)|OBSOLETE. DO NOT USE. Reloads the symbols for this module.|  
  
## Remarks  
 Module information can be displayed in the **Modules** window of the IDE.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [MODULE_INFO](../extensibility/module_info.md)   
 [GetModule](../extensibility/idebugmoduleloadevent2--getmodule.md)   
 [FRAMEINFO](../extensibility/frameinfo.md)   
 [IEnumDebugModules2](../extensibility/ienumdebugmodules2.md)