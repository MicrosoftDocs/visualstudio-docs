---
title: "IJsDebugDataTarget Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: a9b784d6-958f-4d55-b3f6-c2d6b260a16b
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget Interface
Implemented by the debugger to provide functionality to access and change the state of the target debugger process.  
  
## Syntax  
  
```cpp
IJsDebugDataTarget : public IUnknown;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IJsDebugDataTarget::AllocateVirtualMemory Method](../../winscript/reference/ijsdebugdatatarget-allocatevirtualmemory-method.md)|Reserves and/or commits a region of memory within the virtual address space of the target process.|  
|[IJsDebugDataTarget::CreateStackFrameEnumerator Method](../../winscript/reference/ijsdebugdatatarget-createstackframeenumerator-method.md)|Creates an enumerator for stack frames.|  
|[IJsDebugDataTarget::FreeVirtualMemory Method](../../winscript/reference/ijsdebugdatatarget-freevirtualmemory-method.md)|Releases and/or decommits a region of memory within the virtual address space of the target process.|  
|[IJsDebugDataTarget::GetThreadContext Method](../../winscript/reference/ijsdebugdatatarget-getthreadcontext-method.md)|Retrieves context for given thread.|  
|[IJsDebugDataTarget::GetTlsValue Method](../../winscript/reference/ijsdebugdatatarget-gettlsvalue-method.md)|For the thread being debugged, retrieves the value in the thread local storage (TLS) slot for the specified TLS index.|  
|[IJsDebugDataTarget::ReadBSTR Method](../../winscript/reference/ijsdebugdatatarget-readbstr-method.md)|Reads a BSTR from the debug target.|  
|[IJsDebugDataTarget::ReadMemory Method](../../winscript/reference/ijsdebugdatatarget-readmemory-method.md)|Reads the memory of the target process.|  
|[IJsDebugDataTarget::ReadNullTerminatedString Method](../../winscript/reference/ijsdebugdatatarget-readnullterminatedstring-method.md)|Reads the specified number of characters from the target.|  
|[IJsDebugDataTarget::WriteMemory Method](../../winscript/reference/ijsdebugdatatarget-writememory-method.md)|Reads the memory of the target process.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)