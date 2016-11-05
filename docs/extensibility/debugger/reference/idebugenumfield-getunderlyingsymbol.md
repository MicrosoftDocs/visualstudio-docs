---
title: "IDebugEnumField::GetUnderlyingSymbol | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEnumField::GetUnderlyingSymbol"
helpviewer_keywords: 
  - "IDebugEnumField::GetUnderlyingSymbol method"
ms.assetid: c3b8a117-6708-4cfd-8ffc-5f007d706bc5
caps.latest.revision: 7
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
# IDebugEnumField::GetUnderlyingSymbol
This method returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the name of the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetUnderlyingSymbol(  
   IDebugField** ppField  
);  
```  
  
```c#  
int GetUnderlyingSymbol(  
   out IDebugField ppField  
);  
```  
  
#### Parameters  
 `ppField`  
 [out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the name of this enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name of the enumeration also contains the type of the enumeration, which is bound to a memory location by using [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md).  
  
## See Also  
 [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)