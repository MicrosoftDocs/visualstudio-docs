---
title: "IDiaStackWalkHelper::symbolForVA"
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
ms.assetid: 8dd9455d-d44c-4dd6-a0aa-31131cbea2aa
caps.latest.revision: 10
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
# IDiaStackWalkHelper::symbolForVA
Retrieves the symbol that contains the specified virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT symbolForVA(   
   ULONGLONG     va,  
   IDiaSymbol**  ppSymbol  
);  
```  
  
#### Parameters  
 `va`  
 [in] The virtual address that is contained in the requested symbol. The symbol must be a `SymTagFunctionType` (a value from the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) enumeration).  
  
 `ppSymbol`  
 [out] An [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object that represents the symbol at the specified address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../VS_debugger/IDiaStackWalkHelper.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)