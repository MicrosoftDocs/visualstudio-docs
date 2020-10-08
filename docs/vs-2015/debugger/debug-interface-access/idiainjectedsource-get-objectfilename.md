---
title: "IDiaInjectedSource::get_objectFilename | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaInjectedSource::get_objectFilename method"
ms.assetid: 7c42847a-f0df-443a-a9fe-c495c1271ea8
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaInjectedSource::get_objectFilename
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the object file name to which the source was compiled.  
  
## Syntax  
  
```cpp#  
HRESULT get_objectFilename (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the object file name to which the source was compiled.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
