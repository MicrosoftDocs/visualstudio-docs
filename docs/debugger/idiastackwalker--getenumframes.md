---
title: "IDiaStackWalker::getEnumFrames"
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
  - "IDiaStackWalker2::getEnumFrames method"
ms.assetid: f9f09729-4c34-441c-989c-e0b7339ee32c
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
# IDiaStackWalker::getEnumFrames
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
 [in] The helper [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../debugger/idiaenumstackframes.md) object that contains a list of [IDiaStackFrame](../debugger/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To get a stack frame list on any other platform, call the [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md) method.  
  
## See Also  
 [IDiaStackWalker](../debugger/idiastackwalker.md)   
 [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md)   
 [IDiaStackFrame](../debugger/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md)