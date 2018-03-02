---
title: "IDebugObject2::GetField | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugObject2::GetField"
helpviewer_keywords: 
  - "IDebugObject2::GetField method"
ms.assetid: add6a6b5-e752-47dd-9613-29206ea809b0
caps.latest.revision: 7
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugObject2::GetField
Gets the type of this object.  
  
## Syntax  
  
```cpp  
HRESULT GetField(  
 IDebugField** ppField  
);  
```  
  
```csharp  
int GetField(  
   out IDebugField ppField  
);  
```  
  
#### Parameters  
 `ppField`  
 [out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object if not a null value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A field describes the type of the object.  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)