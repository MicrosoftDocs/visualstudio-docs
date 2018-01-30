---
title: "IDebugObject::IsNullReference | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugObject::IsNullReference"
helpviewer_keywords: 
  - "IDebugObject::IsNullReference method"
ms.assetid: 6dbfcdb0-954f-4486-8fac-7ea8d003e3a9
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugObject::IsNullReference
Tests whether this object is a null reference.  
  
## Syntax  
  
```cpp  
HRESULT IsNullReference(   
   BOOL* pfIsNull  
);  
```  
  
```csharp  
int IsNullReference(  
   out int pfIsNull  
);  
```  
  
#### Parameters  
 `pfIsNull`  
 [out] Returns non-zero (`TRUE`) if this object is a null reference; otherwise, returns zero (`FALSE`).  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A null reference means an empty object or an object that has not been assigned to.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)