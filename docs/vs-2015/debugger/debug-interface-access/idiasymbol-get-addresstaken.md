---
title: "IDiaSymbol::get_addressTaken | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
  - "IDiaSymbol::get_addressTaken method"
ms.assetid: 0d366188-f5e1-4226-b392-58c09539d097
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_addressTaken
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_addressTaken](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-addresstaken).  
  
Retrieves a flag that indicates whether another symbol references this symbol's address.  
  
## Syntax  
  
```cpp#  
HRESULT get_addressTaken (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if another symbol references this address; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Example  
 In the following example, `B` references `A`. Therefore, symbol `A`'s `get_addressTaken` method returns `TRUE`.  
  
```cpp#  
int A  = 0;  
int* B = &A;  
```  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



