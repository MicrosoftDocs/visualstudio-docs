---
title: "IDiaFrameData::get_cplusplusExceptionHandling"
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
ms.assetid: 54ee9cde-ce8e-45f1-809c-6fbad800d850
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
# IDiaFrameData::get_cplusplusExceptionHandling
Retrieves a flag that indicates whether C++ exception handling is in effect.  
  
## Syntax  
  
```cpp#  
HRESULT get_cplusplusExceptionHandling (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if C++ exception handling is in effect; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 To determine if structured exception handling is in effect (which is very different from C++ exception handling), call the [IDiaFrameData::get_systemExceptionHandling](../VS_debugger/IDiaFrameData--get_systemExceptionHandling.md) method.  
  
## See Also  
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)   
 [IDiaFrameData::get_systemExceptionHandling](../VS_debugger/IDiaFrameData--get_systemExceptionHandling.md)