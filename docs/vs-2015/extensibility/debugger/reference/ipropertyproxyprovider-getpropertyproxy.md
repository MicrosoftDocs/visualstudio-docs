---
title: "IPropertyProxyProvider::GetPropertyProxy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IPropertyProxyProvider::GetPropertyProxy"
helpviewer_keywords: 
  - "IPropertyProxyProvider::GetPropertyProxy"
ms.assetid: 3ebb7515-5bfe-48f4-9b8d-721b8f664eb6
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# IPropertyProxyProvider::GetPropertyProxy
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the property proxy interface for the specified proxy ID.  
  
## Syntax  
  
```cpp#  
HRESULT GetPropertyProxy(  
   DWORD                  dwID,  
   IPropertyProxyEESide** proxy  
);  
```  
  
```csharp  
int GetPropertyProxy(  
   uint                     dwID,  
   out IPropertyProxyEESide proxy  
);  
```  
  
#### Parameters  
 `dwID`  
 [in] ID of the desired property proxy.  
  
 `proxy`  
 [out] Returns an [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To support external type visualizers, this method typically forwards the call to the [GetPropertyProxy](../../../extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy.md) method. See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for details on how the IEEVisualizerService is obtained.  
  
## See Also  
 [IPropertyProxyProvider](../../../extensibility/debugger/reference/ipropertyproxyprovider.md)   
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [GetPropertyProxy](../../../extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy.md)   
 [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md)
