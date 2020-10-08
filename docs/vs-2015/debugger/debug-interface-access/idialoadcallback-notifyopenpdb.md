---
title: "IDiaLoadCallback::NotifyOpenPDB | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLoadCallback::NotifyOpenPDB method"
ms.assetid: c0547f99-8468-4e57-82ca-9ef7d6707c8a
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaLoadCallback::NotifyOpenPDB
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Called when a candidate .pdb file is opened.  
  
## Syntax  
  
```cpp#  
HRESULT NotifyOpenPDB (   
   LPCOLESTR pdbPath,  
   HRESULT   resultCode  
);  
```  
  
#### Parameters  
 `pdbPath`  
 [in] The full path of the .pdb file.  
  
 `resultCode`  
 [in] Code that indicates the success (`S_OK`) or failure of the load as applied to this file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The return code is typically ignored.  
  
## See Also  
 [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
