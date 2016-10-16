---
title: "IDiaFrameData::get_program"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::get_program method"
ms.assetid: 9201409e-b4b1-4e2e-a9f8-d17678ac538b
caps.latest.revision: 10
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaFrameData::get_program
Retrieves the program string that is used to compute the register set before the call to the current function.  
  
## Syntax  
  
```cpp#  
HRESULT get_program (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the program string.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The program string is a sequence of macros that is interpreted in order to establish the prologue. For example, a typical stack frame might use the program string `"$T0 $ebp = $eip $T0 4 + ^ = $ebp $T0 ^ = $esp $T0 8 + ="`. The format is reverse polish notation, where the operators follow the operands. `T0` represents a temporary variable on the stack. This example performs the following steps:  
  
1.  Move contents of register `ebp` to `T0`.  
  
2.  Add `4` to the value in `T0` to produce an address, get the value from that address, and store the value in register `eip`.  
  
3.  Get the value from the address stored in `T0` and store that value in register `ebp`.  
  
4.  Add `8` to the value in `T0` and store that value in register `esp`.  
  
 Note that the program string is specific to the CPU and to the calling convention set up for the function represented by the current stack frame.  
  
## See Also  
 [IDiaFrameData](../debugger/idiaframedata.md)