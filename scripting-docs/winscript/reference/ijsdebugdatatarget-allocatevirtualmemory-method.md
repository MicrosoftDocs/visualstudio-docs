---
title: "IJsDebugDataTarget::AllocateVirtualMemory Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.AllocateVirtualMemory"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 1d3a77b0-c1de-4a0c-a759-3e0c68fd96dd
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::AllocateVirtualMemory Method
Reserves and/or commits a region of memory within the virtual address space of the target process.  
  
## Syntax  
  
```cpp
HRESULT AllocateVirtualMemory(  
   UINT64 address,  
   DWORD size,  
   DWORD allocationType,  
   DWORD pageProtection,  
   UINT64 *pAllocatedAddress  
);  
```  
  
#### Parameters  
 `address`  
 [in] The address within the target process where the memory should be committed or reserved. This value is typically zero, in which case the system chooses an address.  
  
 `size`  
 [in] The size of the region of memory to allocate, in bytes. The system will automatically round up to the next page boundary.  
  
 `allocationType`  
 [in] Indicates the type of allocation to perform. This is typically MEM_COMMIT &#124; MEM_RESERVE (0x3000) which reserves and commits an allocation in one step.  
  
 `pageProtection`  
 [in] The memory protection for the region of pages to be allocated. If the pages are being committed, you can specify any one of the memory protection constants (for example, PAGE_READWRITE, PAGE_EXECUTE).  
  
 `pAllocatedAddress`  
 [out] Base address of the allocated region of pages.  
  
## Return Value  
  
## Remarks  
 The function initializes the memory it allocates to zero, unless MEM_RESET is used. For additional information, see the VirtualAlloc Win32 API.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)