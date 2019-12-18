---
title: "IJsDebugDataTarget::FreeVirtualMemory Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.FreeVirtualMemory"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: ea54bad3-9ae3-436b-974d-70fc7fffefd6
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::FreeVirtualMemory Method
Releases and/or decommits a region of memory within the virtual address space of the target process.  
  
## Syntax  
  
```cpp
HRESULT FreeVirtualMemory(  
   UINT64 address,  
   DWORD size,  
   DWORD freeType  
);  
```  
  
#### Parameters  
 `address`  
 [in] Address within the target process where the memory should be freed.  
  
 `size`  
 [in] Number of bytes to decommit. To release a region of memory, this value must be zero.  
  
 `freeType`  
 [in] Indicates the type of free operation to perform. This is typically MEM_RELEASE (0x8000), which releases the specified region of pages. After the operation, the pages are in the free state. MEM_DECOMMIT (0x4000) can be used instead to decommit the pages without releasing them.  
  
## Return Value  
  
## Remarks  
 For additional information, see the VirtualFree Win32 API.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)