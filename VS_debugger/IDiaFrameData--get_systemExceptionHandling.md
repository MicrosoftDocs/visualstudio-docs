---
title: "IDiaFrameData::get_systemExceptionHandling"
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
ms.assetid: e8df1972-913c-446c-9779-775575b0caa9
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
# IDiaFrameData::get_systemExceptionHandling
Retrieves a flag that indicates whether system exception handling is in effect.  
  
## Syntax  
  
```cpp#  
HRESULT get_systemExceptionHandling (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns `TRUE` if system exception handling is in effect; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 System exception handling is more commonly known as structured exception handling.  
  
 To determine if C++ exception handling is in effect, call the [IDiaFrameData::get_cplusplusExceptionHandling](../VS_debugger/IDiaFrameData--get_cplusplusExceptionHandling.md) method.  
  
## See Also  
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)   
 [IDiaFrameData::get_cplusplusExceptionHandling](../VS_debugger/IDiaFrameData--get_cplusplusExceptionHandling.md)