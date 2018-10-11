---
title: "IEnumDebugObjects::Reset | Microsoft Docs"
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
  - "IEnumDebugObjects::Reset"
helpviewer_keywords: 
  - "IEnumDebugObjects::Reset method"
ms.assetid: 4a245e47-cc39-4177-b83d-083ea0e3190f
caps.latest.revision: 7
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugObjects::Reset
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugObjects::Reset](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugobjects-reset).  
  
This method resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(void);  
```  
  
```csharp  
int Reset();  
```  
  
#### Parameters  
 None  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md) returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)   
 [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md)

