---
title: "IDiaInjectedSource::get_length | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaInjectedSource::get_length method"
ms.assetid: 38b88b8b-c2e0-4b2d-8b8b-9ff373733e78
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaInjectedSource::get_length
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of bytes of code.  
  
## Syntax  
  
```cpp#  
HRESULT get_length (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of code.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is the length of the source code and is the same value as returned by the [IDiaInjectedSource::get_source](../../debugger/debug-interface-access/idiainjectedsource-get-source.md) method.  
  
## See Also  
 [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)   
 [IDiaInjectedSource::get_source](../../debugger/debug-interface-access/idiainjectedsource-get-source.md)
