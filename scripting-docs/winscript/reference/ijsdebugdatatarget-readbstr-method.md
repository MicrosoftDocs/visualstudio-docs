---
title: "IJsDebugDataTarget::ReadBSTR Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.ReadBSTR"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 4b571db7-04b9-42a0-9a3e-310ac9d0e659
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::ReadBSTR Method
Reads a BSTR from the debug target.  
  
## Syntax  
  
```cpp
HRESULT ReadBSTR(  
   UINT64 address,  
   BSTR *pString  
);  
```  
  
#### Parameters  
 `address`  
 [in] The address to read from.  
  
 `pString`  
 [out] The BSTR read from the debug target.  
  
## Return Value  
  
## Remarks  
 Returns E_JsDEBUG_INVALID_MEMORY_ADDRESS if the address is not valid.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)