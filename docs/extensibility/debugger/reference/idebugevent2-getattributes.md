---
title: "IDebugEvent2::GetAttributes | Microsoft Docs"
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
  - "IDebugEvent2::GetAttributes"
helpviewer_keywords: 
  - "IDebugEvent2::GetAttributes"
ms.assetid: 2ac5b5fb-da17-43f7-811a-313f677e60d7
caps.latest.revision: 10
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
# IDebugEvent2::GetAttributes
Gets the attributes for this debug event.  
  
## Syntax  
  
```cpp#  
HRESULT GetAttribute(   
   DWORD* pdwAttrib  
);  
```  
  
```c#  
int GetAttribute(   
   out uint pdwAttrib  
);  
```  
  
#### Parameters  
 `pdwAttrib`  
 [out] A combination of flags from the [EVENTATTRIBUTES](../../../extensibility/debugger/reference/eventattributes.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface is common to all events. This method describes the type of event; for example, is the event synchronous or asynchronous and is it a stopping event.  
  
## See Also  
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [EVENTATTRIBUTES](../../../extensibility/debugger/reference/eventattributes.md)