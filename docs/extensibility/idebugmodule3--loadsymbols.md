---
title: "IDebugModule3::LoadSymbols"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugModule3::LoadSymbols"
helpviewer_keywords: 
  - "IDebugModule3::LoadSymbols"
ms.assetid: 7548c8c1-cbc6-48aa-a845-19058d4a85bb
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugModule3::LoadSymbols
Loads the symbols for the current module.  
  
## Syntax  
  
```cpp#  
HRESULT LoadSymbols(  
   void  
);  
```  
  
```c#  
int LoadSymbols();  
```  
  
## Return Value  
 If the method succeeds, it returns `S_OK`. If it fails, it returns an error code.  
  
## Remarks  
 This method loads the symbols from the current search path (which can be altered by calling the [SetSymbolPath](../extensibility/idebugengine3--setsymbolpath.md) method).  
  
 This method is preferred over the [ReloadSymbols_Deprecated](../extensibility/idebugmodule2--reloadsymbols_deprecated.md) method.  
  
## See Also  
 [IDebugModule3](../extensibility/idebugmodule3.md)   
 [SetSymbolPath](../extensibility/idebugengine3--setsymbolpath.md)