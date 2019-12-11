---
title: "IJsDebugDataTarget::WriteMemory Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.WriteMemory"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 0d3c04c3-9ef8-4842-a145-3d29bca75062
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::WriteMemory Method
Reads the memory of the target process.  
  
## Syntax  
  
```cpp
HRESULT WriteMemory(  
   UINT64 address,  
   const BYTE *pMemory,  
   DWORD size  
);  
```  
  
#### Parameters  
 `address`  
 [in] The base address from which to write the target process's memory.  
  
 `pMemory`  
 [in] The data to be written in the address space of the specified process.  
  
 `size`  
 [in] The number of bytes to write to the process.  
  
## Return Value  
  
## Remarks  
 Before data transfer occurs, the system verifies that all data in the base address and the memory of the specified size is accessible for write access, and if it is not accessible, the function raises an E_JsDEBUG_INVALID_MEMORY_ADDRESS error.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)