---
title: "IDebugObject::IsReadOnly | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugObject::IsReadOnly"
helpviewer_keywords: 
  - "IDebugObject::IsReadOnly method"
ms.assetid: c460f772-d08a-4b36-81f3-dff6a51a93fd
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugObject::IsReadOnly
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugObject::IsReadOnly](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugobject-isreadonly).  
  
Determines if this object is read-only.  
  
## Syntax  
  
```cpp#  
HRESULT IsReadOnly(   
   BOOL* pfIsReadOnly  
);  
```  
  
```csharp  
int IsReadOnly(  
   out int pfIsReadOnly  
);  
```  
  
#### Parameters  
 `pfIsReadOnly`  
 [out] Returns non-zero (`TRUE`) if this object is read-only; otherwise, returns zero (`FALSE`).  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A read-only object cannot have its value changed after it is created.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)

