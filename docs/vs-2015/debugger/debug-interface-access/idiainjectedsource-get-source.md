---
title: "IDiaInjectedSource::get_source | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaInjectedSource::get_source method"
ms.assetid: 3c0b5386-321f-4f8f-85cc-e2ee7b4cc3d2
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaInjectedSource::get_source
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the source code bytes.  
  
## Syntax  
  
```cpp#  
HRESULT get_source (   
   DWORD  cbData,  
   DWORD* pcbData,  
   BYTE   data[]  
);  
```  
  
#### Parameters  
 `cbData`  
 [in] The number of bytes that represents the size of the data buffer.  
  
 `pcbData`  
 [out] Returns the number of bytes that represents the bytes returned. If `data` is `NULL`, then `pcbData` is the total number of bytes of data available.  
  
 `data[]`  
 [out] A buffer that is to be filled in with the source bytes.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
