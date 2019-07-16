---
title: "IDiaSymbol::get_unmodifiedType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_unmodifiedType method"
ms.assetid: bf914dc0-ff84-4f5d-9f75-1733b17f3be0
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_unmodifiedType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the original type for this symbol. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to a type.  
  
## Syntax  
  
```cpp#  
HRESULT get_unmodifiedType(   
   IDiaSymbol** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the original type of this symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The current type is a modification of the returned original type. The original type for a symbol can be determined by first getting the type of the symbol and then interrogating that returned type for the original type. Note that some symbols may not have a modified type of the original type.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
