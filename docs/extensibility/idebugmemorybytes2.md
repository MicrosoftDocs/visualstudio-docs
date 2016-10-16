---
title: "IDebugMemoryBytes2"
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
  - "IDebugMemoryBytes2"
helpviewer_keywords: 
  - "IDebugMemoryBytes2 interface"
ms.assetid: d7647575-0e06-4190-88f5-ca40b82209a4
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
# IDebugMemoryBytes2
This interface represents bytes of memory.  
  
## Syntax  
  
```  
IDebugMemoryBytes2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent bytes in memory.  
  
## Notes for Callers  
 [GetMemoryBytes](../extensibility/idebugprogram2--getmemorybytes.md) returns this interface to provide access to system memory. [GetMemoryBytes](../extensibility/idebugproperty2--getmemorybytes.md) and [GetMemoryBytes](../extensibility/idebugreference2--getmemorybytes.md) return this interface to provide access to an object's bytes.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugMemoryBytes2`.  
  
|Method|Description|  
|------------|-----------------|  
|[ReadAt](../extensibility/idebugmemorybytes2--readat.md)|Reads a sequence of bytes, starting at a given location.|  
|[WriteAt](../extensibility/idebugmemorybytes2--writeat.md)|Writes `dwCount` bytes, starting at `pStartContext`.|  
|[GetSize](../extensibility/idebugmemorybytes2--getsize.md)|Gets the size, in bytes, of the memory represented by this interface.|  
  
## Remarks  
 For properties, an [IDebugProperty2](../extensibility/idebugproperty2.md) interface representing an array provides an `IDebugMemoryBytes2` interface to access the values in that array.  
  
 Visual Studio's **Memory View** calls [GetMemoryBytes](../extensibility/idebugprogram2--getmemorybytes.md) to retrieve an `IDebugMemoryBytes2` interface for accessing system memory. The address to be accessed is obtained by parsing the expression entered as an address into the Memory View and then evaluating the parsed expression using [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) to get an `IDebugProperty2` interface. A call to [GetMemoryContext](../extensibility/idebugproperty2--getmemorycontext.md) returns the [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md) that describes the memory address. This memory context is then passed to [ReadAt](../extensibility/idebugmemorybytes2--readat.md) and [WriteAt](../extensibility/idebugmemorybytes2--writeat.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetMemoryBytes](../extensibility/idebugprogram2--getmemorybytes.md)   
 [GetMemoryBytes](../extensibility/idebugproperty2--getmemorybytes.md)   
 [GetMemoryBytes](../extensibility/idebugreference2--getmemorybytes.md)   
 [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md)