---
title: "IDiaSymbol::get_oemSymbolId"
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
ms.assetid: 187801f0-bd82-4c5b-9fae-8eeb1a4ac0ce
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
# IDiaSymbol::get_oemSymbolId
Retrieves the original equipment manufacturer (OEM) symbol's ID value.  
  
## Syntax  
  
```cpp#  
HRESULT get_oemSymbolId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an OEM's internally assigned symbol ID.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.  
  
 This property applies only to symbols with a [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) type of `SymTagCustomType`.  
  
## See Also  
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)