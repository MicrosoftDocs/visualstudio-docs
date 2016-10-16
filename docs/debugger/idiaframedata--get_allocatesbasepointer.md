---
title: "IDiaFrameData::get_allocatesBasePointer"
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
  - "IDiaFrameData::get_allocatesBasePointer method"
ms.assetid: 8a33db5d-008c-4fe5-b64f-210c9b77f686
caps.latest.revision: 9
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
# IDiaFrameData::get_allocatesBasePointer
Retrieves a flag that indicates whether the base pointer is allocated for code in this address range. This method is deprecated.  
  
## Syntax  
  
```cpp#  
HRESULT get_allocatesBasePointer (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if a base pointer is allocated; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 This property should be used only by code that formerly accessed FPO_DATA, or when the program string returned by the [IDiaFrameData::get_program](../debugger/idiaframedata--get_program.md) method is `NULL`. Otherwise, the program string contains all the information needed to compute previous register values.  
  
## See Also  
 [IDiaFrameData](../debugger/idiaframedata.md)   
 [IDiaFrameData::get_program](../debugger/idiaframedata--get_program.md)