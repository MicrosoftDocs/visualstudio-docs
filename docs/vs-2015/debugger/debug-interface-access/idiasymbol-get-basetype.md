---
title: "IDiaSymbol::get_baseType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_baseType method"
ms.assetid: 5c69a241-a8d3-48ed-8b36-27463a196572
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_baseType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the base type for this symbol.  
  
## Syntax  
  
```cpp#  
HRESULT get_baseType (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [BasicType Enumeration](../../debugger/debug-interface-access/basictype.md) enumeration specifying the base type of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Remarks  
 The basic type for a symbol can be determined by first getting the type of the symbol and then interrogating that returned type for the base type. Note that some symbols may not have a base type—for example, a structure name.  
  
## Example  
  
```cpp#  
IDiaSymbol* pType;  
CComPtr<IDiaSymbol> pBaseType;  
if (pType->get_type( &pBaseType ) == S_OK)  
{  
    BasicType btBaseType;  
    if (pBaseType->get_baseType((DWORD *)&btBaseType) == S_OK)  
    {  
        // Do something with basic type.  
    }  
}  
```  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [BasicType Enumeration](../../debugger/debug-interface-access/basictype.md)   
 [IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)
