---
title: "IJsDebugDataTarget::ReadNullTerminatedString Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.ReadNullTerminatedString"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 64683b39-6fc2-40c4-82ae-2a6f58d392d5
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::ReadNullTerminatedString Method
Reads the specified number of characters from the target.  
  
## Syntax  
  
```cpp
HRESULT ReadNullTerminatedString(  
   UINT64 address,  
   UINT16 characterSize,  
   UINT32 maxCharacters,  
   BSTR *pString  
);  
```  
  
#### Parameters  
 `address`  
 [in] The address to read from.  
  
 `characterSize`  
 [in] size of each character in the string  
  
 `maxCharacters`  
 [in] The maximum number of characters to read. maxCharacters should be reasonable. Any request for more than 128MB of memory will fail.  If the string is larger than maxCharacters, the result string will be truncated after maxCharacters.  
  
 `pString`  
 [out] The BSTR read from the target.  
  
## Return Value  
  
## Remarks  
 Returns S_FALSE if truncated.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)