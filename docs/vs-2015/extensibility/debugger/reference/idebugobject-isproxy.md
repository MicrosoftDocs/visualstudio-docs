---
title: "IDebugObject::IsProxy | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugObject::IsProxy"
  - "IsProxy"
ms.assetid: 06c66b87-db95-4400-ab26-5d33e743a439
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugObject::IsProxy
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugObject::IsProxy](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugobject-isproxy).  
  
Determines if the object is a transparent proxy.  
  
## Syntax  
  
```cpp#  
HRESULT IsProxy (  
   BOOL* pfIsProxy  
);  
```  
  
```csharp  
int IsProxy (  
   out bool pfIsProxy  
);  
```  
  
#### Parameters  
 `pfIsProxy`  
 [out] `TRUE` if the object is a transparent proxy; otherwise, `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is implemented by the default C++ debug engine.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)

