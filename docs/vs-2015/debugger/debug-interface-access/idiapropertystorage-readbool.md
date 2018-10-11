---
title: "IDiaPropertyStorage::ReadBOOL | Microsoft Docs"
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
  - "IDiaPropertyStorage::ReadBOOL"
ms.assetid: ad1822db-4572-48f7-9919-f8137f6701f2
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaPropertyStorage::ReadBOOL
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Reads `BOOL` values in a property set.  
  
## Syntax  
  
```cpp#  
HRESULT ReadBOOL (   
   PROPID id,  
   BOOL*  pValue  
);  
```  
  
#### Parameters  
 `id`  
 [in] Identifier of the property to be read (`PROPID` is defined in WTypes.h as a `ULONG`).  
  
 `pValue`  
 [out] Returns the property value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code. Returns `E_INVALIDARG` if the property is not of type `BOOL`.  
  
## Remarks  
 For consistent results, interpret the `BOOL` value so that nonzero values are `TRUE` and zero is `FALSE`.  
  
## See Also  
 [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)



