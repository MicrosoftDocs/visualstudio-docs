---
title: "IDiaSymbol::get_hasCastOperator | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_hasCastOperator method"
ms.assetid: a21114a6-56a3-4e8a-a65f-58ec2a0a8908
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_hasCastOperator
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the user-defined data type has any cast operators defined.  
  
## Syntax  
  
```cpp#  
HRESULT get_hasCastOperator (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a `TRUE` if the user-defined data type has any cast operators defined; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



