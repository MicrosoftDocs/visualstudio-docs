---
title: "IDiaPropertyStorage::ReadBSTR | Microsoft Docs"
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
  - "IDiaPropertyStorage::ReadBSTR"
ms.assetid: 7214643b-3286-48ed-90aa-0fe95b4cae5b
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaPropertyStorage::ReadBSTR
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Reads `BSTR` values in a property set.  
  
## Syntax  
  
```cpp#  
HRESULT ReadBSTR (   
   PROPID id,  
   BSTR*  pValue  
);  
```  
  
#### Parameters  
 `id`  
 [in] Identifier of the property to be read (`PROPID` is defined in WTypes.h as a `ULONG`).  
  
 `pValue`  
 [out] Returns the property value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code. Returns `E_INVALIDARG` if the property is not of type `BSTR`.  
  
## Remarks  
 A `BSTR` is defined by Windows as a zero-terminated wide character string.  
  
## See Also  
 [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)



