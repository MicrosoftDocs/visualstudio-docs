---
title: "IDiaEnumSourceFiles::Clone | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSourceFiles::Clone method"
ms.assetid: 87a9a9b6-3927-4131-927c-ad95f8f098b9
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSourceFiles::Clone
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IDiaEnumSourceFiles** ppenum  
);  
```  
  
#### Parameters  
 ppenum  
 [out] Returns an [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md) object that contains a duplicate of the enumerator. The source files are not duplicated, only the enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
