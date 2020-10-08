---
title: "IDiaTable::get_name | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaTable::get_name method"
ms.assetid: f6e9cd07-63cd-48a6-9835-e69c2d0859c5
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaTable::get_name
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the name of the table.  
  
## Syntax  
  
```cpp#  
HRESULT get_name (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the name of the table.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
