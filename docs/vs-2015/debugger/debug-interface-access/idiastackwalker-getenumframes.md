---
title: "IDiaStackWalker::getEnumFrames | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalker2::getEnumFrames method"
ms.assetid: f9f09729-4c34-441c-989c-e0b7339ee32c
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackWalker::getEnumFrames
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a stack frame enumerator for x86 platforms.  
  
## Syntax  
  
```cpp#  
HRESULT getEnumFrames(   
   IDiaStackWalkHelper*   pHelper,  
   IDiaEnumStackFrames**  ppEnum  
);  
```  
  
#### Parameters  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../../debugger/debug-interface-access/idiaenumstackframes.md) object that contains a list of [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To get a stack frame list on any other platform, call the [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) method.  
  
## See Also  
 [IDiaStackWalker](../../debugger/debug-interface-access/idiastackwalker.md)   
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)   
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)
