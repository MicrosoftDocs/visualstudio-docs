---
title: "IDiaSymbol::get_framePointerPresent | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_framePointerPresent method"
ms.assetid: d036090a-1651-454d-9130-b798f58ba053
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_framePointerPresent
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the frame pointer is present. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.  
  
## Syntax  
  
```cpp#  
HRESULT get_framePointerPresent(   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] ] Returns `TRUE` if the frame pointer is present; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
