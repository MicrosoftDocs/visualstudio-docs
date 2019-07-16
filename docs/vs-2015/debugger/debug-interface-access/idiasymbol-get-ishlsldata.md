---
title: "IDiaSymbol::get_isHLSLData | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 4662058b-c505-4ccf-ae03-739a62c814ca
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_isHLSLData
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies whether this symbol represents High Level Shader Language (HLSL) data.  
  
## Syntax  
  
```cpp  
HRESULT get_isHLSLData(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether this symbol represents HLSL data.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
