---
title: "IDiaSymbol::get_classParentId | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_classParentId method"
ms.assetid: f11e3ccb-215d-418c-b8c3-e63159234915
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_classParentId
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the class parent identifier of the symbol.  
  
## Syntax  
  
```cpp#  
HRESULT get_classParentId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the class parent ID of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
