---
title: "IDebugObject2::GetICorDebugValue | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugObject2::GetICorDebugValue"
helpviewer_keywords: 
  - "IDebugObject2::GetICorDebugValue method"
ms.assetid: bcd4355d-3fbe-483f-bb23-a44348323c6a
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugObject2::GetICorDebugValue
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugObject2::GetICorDebugValue](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugobject2-geticordebugvalue).  
  
Gets a managed code object representing the value associated with this object.  
  
## Syntax  
  
```cpp  
HRESULT GetICorDebugValue(  
   IUnknown** ppUnk  
);  
```  
  
```csharp  
int GetICorDebugValue(  
   out object ppUnk  
);  
```  
  
#### Parameters  
 `ppUnk`  
 [out] `IUnknown` interface that represents this alias. This interface can be queried for the `ICorDebugValue` interface.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The `ICorDebugValue` object is a Common Language Runtime interface that represents a value.  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)

