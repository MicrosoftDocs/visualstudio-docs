---
title: "IEEVisualizerService::GetPropertyProxy | Microsoft Docs"
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
  - "IEEVisualizerService::GetPropertyProxy"
helpviewer_keywords: 
  - "IEEVisualizerService::GetPropertyProxy method"
ms.assetid: 748750f4-76e7-4580-9da2-afba07681b37
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IEEVisualizerService::GetPropertyProxy
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEEVisualizerService::GetPropertyProxy](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy).  
  
This method returns a proxy for a property object.  
  
## Syntax  
  
```cpp  
HRESULT GetPropertyProxy(  
   DWORD                  dwID,  
   IPropertyProxyEESide** proxy  
);  
```  
  
```csharp  
int GetPropertyProxy(  
   uint                     dwID,  
   out IPropertyProxyEESide proxy  
);  
```  
  
#### Parameters  
 `dwID`  
 [in] ID of property proxy to retrieve.  
  
 `proxy`  
 [out] Desired proxy implemented in an [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) passes the request to this method as part of its support for type visualizers.  
  
## See Also  
 [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)   
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md)

