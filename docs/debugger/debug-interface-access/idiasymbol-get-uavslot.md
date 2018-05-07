---
title: "IDiaSymbol::get_uavSlot | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "C++"
ms.assetid: a70648f2-3b25-439f-8099-239ac602515a
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# IDiaSymbol::get_uavSlot
Retrieves the uav slot.  
  
## Syntax  
  
```C++  
HRESULT get_uavSlot(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the uav slot.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)