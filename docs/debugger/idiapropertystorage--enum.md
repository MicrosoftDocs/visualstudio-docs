---
title: "IDiaPropertyStorage::Enum"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaPropertyStorage::Enum"
ms.assetid: 00e462da-980a-40b3-a2d6-75a25ee809e5
caps.latest.revision: 10
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaPropertyStorage::Enum
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
 [IDiaPropertyStorage](../debugger/idiapropertystorage.md)