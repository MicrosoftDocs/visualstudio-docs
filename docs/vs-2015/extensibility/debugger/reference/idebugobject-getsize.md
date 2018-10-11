---
title: "IDebugObject::GetSize | Microsoft Docs"
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
  - "IDebugObject::GetSize"
helpviewer_keywords: 
  - "IDebugObject::GetSize method"
ms.assetid: 89af423b-36eb-479d-b2de-2693455eca15
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugObject::GetSize
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the size of the object in bytes.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize(   
   UINT* pnSize  
);  
```  
  
```csharp  
int GetSize(  
   out uint pnSize  
);  
```  
  
#### Parameters  
 `pnSize`  
 [out] Returns the size in bytes.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Use the [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md) method to retrieve the value as a sequence of bytes.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md)

