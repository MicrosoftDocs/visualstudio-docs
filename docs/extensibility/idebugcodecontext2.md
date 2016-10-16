---
title: "IDebugCodeContext2"
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
  - "IDebugCodeContext2"
helpviewer_keywords: 
  - "IDebugCodeContext2 interface"
ms.assetid: 3670439e-2171-405d-9d77-dedb0f1cba93
caps.latest.revision: 10
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
# IDebugCodeContext2
This interface represents the starting position of a code instruction. For most run-time architectures today, a code context can be thought of as an address in a program's execution stream.  
  
## Syntax  
  
```  
IDebugCodeContext2 : IDebugMemoryContext2  
```  
  
## Notes for Implementers  
 The debug engine implements this interface to relate the position of a code instruction to a document position.  
  
## Notes for Callers  
 Methods on many interfaces return this interface, most typically, [GetCodeContext](../extensibility/idebugstackframe2--getcodecontext.md). It is also used extensively with the [IDebugDisassemblyStream2](../extensibility/idebugdisassemblystream2.md) interface as well as in breakpoint resolution information.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetDocumentContext](../extensibility/idebugcodecontext2--getdocumentcontext.md)|Gets the document context that corresponds to the active code context.|  
|[GetLanguageInfo](../extensibility/idebugcodecontext2--getlanguageinfo.md)|Gets the language information for this code context.|  
  
## Remarks  
 The key difference between an `IDebugCodeContext2` interface and an [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md) interface is that an `IDebugCodeContext2` is always instruction-aligned. This means that an `IDebugCodeContext2` is always pointing to the beginning of an instruction, whereas an `IDebugMemoryContext2` may point to any byte of memory in the run-time architecture. `IDebugCodeContext2` is incremented by instructions rather than by the basic storage size (typically byte).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [GetDisassemblyStream](../extensibility/idebugprogram2--getdisassemblystream.md)   
 [CanSetNextStatement](../extensibility/idebugthread2--cansetnextstatement.md)   
 [SetNextStatement](../extensibility/idebugthread2--setnextstatement.md)   
 [GetCodeContext](../extensibility/idebugcanstopevent2--getcodecontext.md)   
 [GetCodeContext](../extensibility/idebugstackframe2--getcodecontext.md)   
 [Next](../extensibility/ienumdebugcodecontexts2--next.md)   
 [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md)