---
title: "IDiaLoadCallback::RestrictSymbolServerAccess | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLoadCallback::RestrictSymbolServerAccess method"
ms.assetid: db37ad9f-f75e-4f0c-83bf-21a6e66ba859
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaLoadCallback::RestrictSymbolServerAccess
Determines if access is allowed to a symbol server to resolve symbols.  
  
## Syntax  
  
```C++  
HRESULT RestrictSymbolServerAccess();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Any return code other than `S_OK` prevents use of a symbol server to resolve symbols.  
  
## See Also  
 [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)