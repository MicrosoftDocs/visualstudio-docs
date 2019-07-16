---
title: "IDebugModule3::LoadSymbols | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugModule3::LoadSymbols"
helpviewer_keywords: 
  - "IDebugModule3::LoadSymbols"
ms.assetid: 7548c8c1-cbc6-48aa-a845-19058d4a85bb
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugModule3::LoadSymbols
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Loads the symbols for the current module.  
  
## Syntax  
  
```cpp#  
HRESULT LoadSymbols(  
   void  
);  
```  
  
```csharp  
int LoadSymbols();  
```  
  
## Return Value  
 If the method succeeds, it returns `S_OK`. If it fails, it returns an error code.  
  
## Remarks  
 This method loads the symbols from the current search path (which can be altered by calling the [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md) method).  
  
 This method is preferred over the [ReloadSymbols_Deprecated](../../../extensibility/debugger/reference/idebugmodule2-reloadsymbols-deprecated.md) method.  
  
## See Also  
 [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)   
 [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md)
