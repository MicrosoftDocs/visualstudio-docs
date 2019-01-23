---
title: "IDiaEnumSectionContribs::Next | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSectionContribs::Next method"
ms.assetid: a6bb2adb-ee6d-4f3c-ab5b-e89361c8880e
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSectionContribs::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a specified number of section contributions in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next(   
   ULONG                celt,   
   IDiaSectionContrib** rgelt,  
   ULONG*               pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of section contributions in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled with the [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md) objects that represent the desired section contributions.  
  
 pceltFetched  
 [out] Returns the number of section contributions in the enumerator fetched.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more section contributions. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)   
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
