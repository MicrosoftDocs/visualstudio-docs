---
title: "IDiaSymbol::get_upperBoundId | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_upperBoundId method"
ms.assetid: ddfa1617-bd0f-4187-ba77-a225bab93a95
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_upperBoundId
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension.  
  
## Syntax  
  
```cpp#  
HRESULT get_upperBoundId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out,] Returns the ID of the symbol that represents the upper bound of a FORTRAN array dimension.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
