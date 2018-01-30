---
title: "IEnumDebugObjects::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugObjects::Clone"
helpviewer_keywords: 
  - "IEnumDebugObjects::Clone method"
ms.assetid: cb7df109-d29a-4218-b900-6809091459dd
caps.latest.revision: 5
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IEnumDebugObjects::Clone
This method returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp  
HRESULT Clone(  
   IEnumDebugObjects** ppEnum  
);  
```  
  
```csharp  
int Clone(  
   out IEnumDebugObjects ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)