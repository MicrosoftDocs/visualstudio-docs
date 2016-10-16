---
title: "IPropertyProxyProvider::GetPropertyProxy"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IPropertyProxyProvider::GetPropertyProxy"
helpviewer_keywords: 
  - "IPropertyProxyProvider::GetPropertyProxy"
ms.assetid: 3ebb7515-5bfe-48f4-9b8d-721b8f664eb6
caps.latest.revision: 14
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IPropertyProxyProvider::GetPropertyProxy
Retrieves the property proxy interface for the specified proxy ID.  
  
## Syntax  
  
```cpp#  
HRESULT GetPropertyProxy(  
   DWORD                  dwID,  
   IPropertyProxyEESide** proxy  
);  
```  
  
```c#  
int GetPropertyProxy(  
   uint                     dwID,  
   out IPropertyProxyEESide proxy  
);  
```  
  
#### Parameters  
 `dwID`  
 [in] ID of the desired property proxy.  
  
 `proxy`  
 [out] Returns an [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To support external type visualizers, this method typically forwards the call to the [GetPropertyProxy](../extensibility/ieevisualizerservice--getpropertyproxy.md) method. See [Visualizing and Viewing Data](../extensibility/visualizing-and-viewing-data.md) for details on how the IEEVisualizerService is obtained.  
  
## See Also  
 [IPropertyProxyProvider](../extensibility/ipropertyproxyprovider.md)   
 [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md)   
 [GetPropertyProxy](../extensibility/ieevisualizerservice--getpropertyproxy.md)   
 [Visualizing and Viewing Data](../extensibility/visualizing-and-viewing-data.md)