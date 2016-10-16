---
title: "IDebugMemoryContext2"
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
  - "IDebugMemoryContext2"
helpviewer_keywords: 
  - "IDebugMemoryContext2 interface"
ms.assetid: 3a544c8b-11dc-46bb-8549-261e4ac5bbc4
caps.latest.revision: 11
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
# IDebugMemoryContext2
This interface represents a position in the address space of the machine running the program being debugged.  
  
## Syntax  
  
```  
IDebugMemoryContext2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent an address in memory.  
  
## Notes for Callers  
 A call to [GetMemoryContext](../extensibility/idebugproperty2--getmemorycontext.md) or [GetMemoryContext](../extensibility/idebugreference2--getmemorycontext.md) returns this interface. Also, calls to [Add](../extensibility/idebugmemorycontext2--add.md) and [Subtract](../extensibility/idebugmemorycontext2--subtract.md) return new copies of this interface after the appropriate arithmetic operation has been applied.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugMemoryContext2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetName](../extensibility/idebugmemorycontext2--getname.md)|Gets the user-displayable name for this context.|  
|[GetInfo](../extensibility/idebugmemorycontext2--getinfo.md)|Gets information that describes this context.|  
|[Add](../extensibility/idebugmemorycontext2--add.md)|Adds a specified value to the current context's address to create a new context.|  
|[Subtract](../extensibility/idebugmemorycontext2--subtract.md)|Subtracts a specified value from the current context's address to create a new context.|  
|[Compare](../extensibility/idebugmemorycontext2--compare.md)|Compares two contexts in the manner indicated by compare flags.|  
  
## Remarks  
 Visual Studio's **Memory** window calls [GetMemoryContext](../extensibility/idebugproperty2--getmemorycontext.md) to obtain the `IDebugMemoryContext2` interface that contains the evaluated expression used for the memory address. This context is then passed to [ReadAt](../extensibility/idebugmemorybytes2--readat.md) and [WriteAt](../extensibility/idebugmemorybytes2--writeat.md) to specify the address to read or write.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetMemoryContext](../extensibility/idebugproperty2--getmemorycontext.md)   
 [GetMemoryContext](../extensibility/idebugreference2--getmemorycontext.md)   
 [ReadAt](../extensibility/idebugmemorybytes2--readat.md)   
 [WriteAt](../extensibility/idebugmemorybytes2--writeat.md)