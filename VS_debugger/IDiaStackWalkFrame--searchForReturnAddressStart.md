---
title: "IDiaStackWalkFrame::searchForReturnAddressStart"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 47660b9b-6e4f-4dfa-88ab-63dce28f7412
caps.latest.revision: 8
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaStackWalkFrame::searchForReturnAddressStart
Searches the specified stack frame for a return address at or near the specified address.  
  
## Syntax  
  
```cpp#  
HRESULT searchForReturnAddressStart (   
   IDiaFrameData* frame,  
   ULONGLONG      startAddress,  
   ULONGLONG*     returnAddress  
);  
```  
  
#### Parameters  
 `frame`  
 [in] An [IDiaFrameData](../VS_debugger/IDiaFrameData.md) object that represents the current stack frame.  
  
 `startAddress`  
 [in] A virtual memory address from which to begin searching.  
  
 `returnAddress`  
 [out] Returns the nearest function return address to `startAddress`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md)   
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)