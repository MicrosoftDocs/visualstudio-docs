---
title: "IDiaStackFrame::get_cplusplusExceptionHandling"
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
ms.assetid: f2631820-c986-40ca-b61e-230d7a9c426c
caps.latest.revision: 9
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
# IDiaStackFrame::get_cplusplusExceptionHandling
Retrieves a flag that indicates if C++ exception handling is in effect.  
  
## Syntax  
  
```cpp#  
HRESULT get_cplusplusExceptionHandling (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if C++ exception handling is in effect for this frame; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 C++ exception handling is not the same as structured or system exception handling.  
  
 To determine if structured exception handling is in effect, call the [IDiaStackFrame::get_systemExceptionHandling](../VS_debugger/IDiaStackFrame--get_systemExceptionHandling.md) method.  
  
## See Also  
 [IDiaStackFrame](../VS_debugger/IDiaStackFrame.md)   
 [IDiaStackFrame::get_systemExceptionHandling](../VS_debugger/IDiaStackFrame--get_systemExceptionHandling.md)