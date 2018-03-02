---
title: "IEnumDebugModules2::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugModules2::Clone"
helpviewer_keywords: 
  - "IEnumDebugModules2::Clone"
ms.assetid: fd6d3abc-20d9-4f6f-9c8e-5bd29f68d47d
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IEnumDebugModules2::Clone
Returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp  
HRESULT Clone(  
   IEnumDebugModules2** ppEnum  
);  
```  
  
```csharp  
int Clone(  
   out IEnumDebugModules2 ppEnum  
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
 [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)