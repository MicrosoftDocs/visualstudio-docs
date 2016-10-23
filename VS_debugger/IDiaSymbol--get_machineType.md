---
title: "IDiaSymbol::get_machineType"
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
ms.assetid: 30870b10-6f32-45c6-a0d7-020dea707710
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
# IDiaSymbol::get_machineType
Retrieves the type of the target CPU.  
  
## Syntax  
  
```cpp#  
HRESULT get_machineType (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md) enumeration that specifies the target CPU type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)