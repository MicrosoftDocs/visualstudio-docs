---
title: "IJsDebugDataTarget::GetTlsValue Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.GetTlsValue"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: db575be9-7b24-45c5-9008-e4f2f76d6757
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::GetTlsValue Method
For the thread being debugged, retrieves the value in the thread local storage (TLS) slot for the specified TLS index.  
  
## Syntax  
  
```cpp
HRESULT GetTlsValue(  
   DWORD threadId,  
   UINT32 tlsIndex,  
   UINT64 *pValue  
);  
```  
  
#### Parameters  
 `threadId`  
 [in] Thread running in the target process to read from.  
  
 `tlsIndex`  
 [in] The TLS index that was allocated when the target process called the TlsAlloc function.  
  
 `pValue`  
 [out] The pointer-sized value which was stored in the thread's TLS slot. If the target thread is 32-bit, the upper 32-bits of this value will be zero.  
  
## Return Value  
  
## Remarks  
 Each thread of a process has its own slot for each TLS index.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)