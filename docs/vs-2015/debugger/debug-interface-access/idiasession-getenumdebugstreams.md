---
title: "IDiaSession::getEnumDebugStreams | Microsoft Docs"
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
  - "IDiaSession::getEnumDebugStreams method"
ms.assetid: d294954b-80e9-476c-b9f0-5ca6fd575f68
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSession::getEnumDebugStreams
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSession::getEnumDebugStreams](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasession-getenumdebugstreams).  
  
Retrieves an enumerated sequence of debug data streams.  
  
## Syntax  
  
```cpp#  
HRESULT getEnumDebugStreams (   
   IDiaEnumDebugStreams** ppEnumDebugStreams  
)  
```  
  
#### Parameters  
 `ppEnumDebugStreams`  
 [out] Returns an [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md) object that contains a list of debug streams.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)



