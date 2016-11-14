---
title: "IDebugObject2::CreateAlias | Microsoft Docs"
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
  - "IDebugObject2::CreateAlias"
helpviewer_keywords: 
  - "IDebugObject2::CreateAlias method"
ms.assetid: 54a05920-5d13-4f67-962b-d1a7f013dff9
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
# IDebugObject2::CreateAlias
Creates a unique ID or alias for this object or returns an existing alias.  
  
## Syntax  
  
```cpp  
HRESULT CreateAlias(  
   IDebugAlias** ppAlias  
);  
```  
  
```c#  
int CreateAlias(  
   out IDebugAlias ppAlias  
);  
```  
  
#### Parameters  
 `ppAlias`  
 [out] The new (or existing) alias.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 An alias is a label that represents a particular object while the object is in memory.  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)   
 [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)