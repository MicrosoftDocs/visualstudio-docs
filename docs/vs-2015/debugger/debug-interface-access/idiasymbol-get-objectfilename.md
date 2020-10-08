---
title: "IDiaSymbol::get_objectFileName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 21793872-4879-4e4d-b527-dcf70aa7fb31
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_objectFileName
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the object file name.  
  
## Syntax  
  
```cpp  
HRESULT get_objectFilename(   
   BSTR *pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BSTR` that holds the object file name.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
