---
title: "IDiaPropertyStorage::Enum | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaPropertyStorage::Enum"
ms.assetid: 00e462da-980a-40b3-a2d6-75a25ee809e5
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaPropertyStorage::Enum
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Gets an enumerator for properties within this set.  
  
## Syntax  
  
```cpp#  
HRESULT Enum (   
   IEnumSTATPROPSTG** ppenum  
);  
```  
  
#### Parameters  
 `ppenum`  
 [out] Returns an `IEnumSTATPROPSTG` object (in the Microsoft.VisualStudio.OLE.Interop namespace) representing an enumeration of properties.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## See Also  
 [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
