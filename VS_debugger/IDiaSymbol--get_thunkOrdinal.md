---
title: "IDiaSymbol::get_thunkOrdinal"
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
ms.assetid: 4b28d78a-1974-4d8a-8bb7-781bf630f2f4
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
# IDiaSymbol::get_thunkOrdinal
Retrieves the thunk type of a function.  
  
## Syntax  
  
```cpp#  
HRESULT get_thunkOrdinal (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [THUNK_ORDINAL Enumeration](../VS_debugger/THUNK_ORDINAL.md) enumeration that specifies the thunk type of a function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 This property is valid only if the symbol as a [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) value of `SymTagThunk`.  
  
 A "thunk" is a piece of code that converts between a 32-bit memory address space (also known as flat address space) and a 16-bit address space (known as a segmented address space).  
  
## See Also  
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)   
 [THUNK_ORDINAL Enumeration](../VS_debugger/THUNK_ORDINAL.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)