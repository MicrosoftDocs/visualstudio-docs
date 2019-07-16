---
title: "IDiaSymbol::get_isCVTCIL | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_isCVTCIL method"
ms.assetid: 711b81fd-9549-44dc-9761-5eb862ed64c0
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_isCVTCIL
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag indicating whether the module was converted from a Common Intermediate Language (CIL) module to a native module.  
  
## Syntax  
  
```cpp#  
HRESULT get_isCVTCIL(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if the module was converted from CIL to native code; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 This property is available from the `SymTagCompilandDetails` symbol type (see [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md).  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)
