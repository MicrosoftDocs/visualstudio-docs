---
title: "IJsDebugDataTarget::ReadMemory Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.ReadMemory"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 664e0f7d-2007-45f4-b993-36fe8b1944e5
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::ReadMemory Method
Reads the memory of the target process.  
  
## Syntax  
  
```cpp
HRESULT ReadMemory(  
   UINT64 address,  
   JsDebugReadMemoryFlags flags,  
   BYTE *pBuffer,  
   DWORD size,  
   DWORD *pBytesRead  
);  
```  
  
#### Parameters  
 `address`  
 [in] The base address from which to read the target process's memory.  
  
 `flags`  
 [in] Flags controlling the behavior of ReadMemory.  
  
 `pBuffer`  
 [out] A buffer that receives the contents from the address space of the target process. On failure, the content of this buffer is unspecified.  
  
 `size`  
 [in] The number of bytes to be read from the process.  
  
 `pBytesRead`  
 [out] Indicates the number of bytes read from the target process. If JsDebugAllowPartialRead is clear, on success this value will always be exactly equal to the input size. If JsDebugAllowPartialRead is specified, on success, this value will be greater than zero.  
  
## Return Value  
  
## Remarks  
 Returns S_OK on success, and failure codes are used for any error. Returns E_JsDEBUG_INVALID_MEMORY_ADDRESS if the address is not valid. Fore more information, see JsDebugAllowPartialRead.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)