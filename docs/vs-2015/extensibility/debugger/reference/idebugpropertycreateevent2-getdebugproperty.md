---
title: "IDebugPropertyCreateEvent2::GetDebugProperty | Microsoft Docs"
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
  - "IDebugPropertyCreateEvent2::GetDebugProperty"
helpviewer_keywords: 
  - "IDebugPropertyCreateEvent2::GetDebugProperty"
ms.assetid: d7e43183-444c-4417-af19-82e28229f83a
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugPropertyCreateEvent2::GetDebugProperty
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugPropertyCreateEvent2::GetDebugProperty](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugpropertycreateevent2-getdebugproperty).  
  
Gets the new property.  
  
## Syntax  
  
```cpp#  
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
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the new property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPropertyCreateEvent2](../../../extensibility/debugger/reference/idebugpropertycreateevent2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)

