---
title: "IDebugAlias::GetObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugAlias::GetObject"
helpviewer_keywords: 
  - "IDebugAlias::GetObject method"
ms.assetid: 97bc3af6-6e55-4940-8a6d-692c61257806
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugAlias::GetObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the object that this alias is for.  
  
## Syntax  
  
```cpp  
HRESULT GetObject(  
   IDebugObject2** ppObject  
);  
```  
  
```csharp  
int GetObject(  
   Out IDebugObject2 ppObject  
)  
```  
  
#### Parameters  
 `ppObject`  
 [out] The [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md) this alias represents.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## See Also  
 [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)   
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
