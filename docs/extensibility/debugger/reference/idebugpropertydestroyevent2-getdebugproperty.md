---
title: "IDebugPropertyDestroyEvent2::GetDebugProperty | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugPropertyDestroyEvent2::GetDebugProperty"
helpviewer_keywords: 
  - "IDebugPropertyDestroyEvent2::GetDebugProperty"
ms.assetid: c96ae785-0ac8-4df4-8df3-15a8d7e13687
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugPropertyDestroyEvent2::GetDebugProperty
Gets the property to be destroyed.  
  
## Syntax  
  
```cpp  
HRESULT GetDebugProperty (   
   IDebugProperty2** ppProperty  
);  
```  
  
```csharp  
int GetDebugProperty (   
   out IDebugProperty2 ppProperty  
);  
```  
  
#### Parameters  
 `ppProperty`  
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the property to be destroyed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPropertyDestroyEvent2](../../../extensibility/debugger/reference/idebugpropertydestroyevent2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)