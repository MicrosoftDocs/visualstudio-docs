---
title: "IDiaPropertyStorage::ReadLONG | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaPropertyStorage::ReadLONG"
ms.assetid: 32054cbc-db55-4513-a1b4-de80e77aac8a
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaPropertyStorage::ReadLONG
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Reads `LONG` values in a property set.  
  
## Syntax  
  
```cpp#  
HRESULT ReadDLONG (   
   PROPID id,  
   LONG*  pValue  
);  
```  
  
#### Parameters  
 `id`  
 [in] Identifier of the property to be read (`PROPID` is defined in WTypes.h as a `ULONG`).  
  
 `pValue`  
 [out] Returns the property value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code. Returns `E_INVALIDARG` if the property is not of type `LONG`.  
  
## Remarks  
 A `LONG` is defined by Windows as a 32-bit signed integer.  
  
## See Also  
 [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
