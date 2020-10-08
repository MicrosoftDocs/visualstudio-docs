---
title: "IDiaSymbol::get_classParent | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_classParent method"
ms.assetid: 99db875a-caae-4d60-ae70-64bc8a9f6fba
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_classParent
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a reference to the class parent of the symbol.  
  
## Syntax  
  
```cpp#  
HRESULT get_classParent (   
   IDiaSymbol** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the class parent of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## Remarks  
 The types of symbols that can be class parents are documented in [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md).  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)
