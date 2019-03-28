---
title: "IDebugObject2::CreateAlias | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject2::CreateAlias"
helpviewer_keywords: 
  - "IDebugObject2::CreateAlias method"
ms.assetid: 54a05920-5d13-4f67-962b-d1a7f013dff9
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugObject2::CreateAlias
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates a unique ID or alias for this object or returns an existing alias.  
  
## Syntax  
  
```cpp  
HRESULT CreateAlias(  
   IDebugAlias** ppAlias  
);  
```  
  
```csharp  
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
