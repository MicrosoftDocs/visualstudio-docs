---
title: "IEEVisualizerService::GetPropertyProxy"
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
  - "IEEVisualizerService::GetPropertyProxy"
helpviewer_keywords: 
  - "IEEVisualizerService::GetPropertyProxy method"
ms.assetid: 748750f4-76e7-4580-9da2-afba07681b37
caps.latest.revision: 9
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
# IEEVisualizerService::GetPropertyProxy
This method returns a proxy for a property object.  
  
## Syntax  
  
```cpp  
HRESULT GetPropertyProxy(  
   DWORD                  dwID,  
   IPropertyProxyEESide** proxy  
);  
```  
  
```c#  
int GetPropertyProxy(  
   uint                     dwID,  
   out IPropertyProxyEESide proxy  
);  
```  
  
#### Parameters  
 `dwID`  
 [in] ID of property proxy to retrieve.  
  
 `proxy`  
 [out] Desired proxy implemented in an [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [GetPropertyProxy](../extensibility/ipropertyproxyprovider--getpropertyproxy.md) passes the request to this method as part of its support for type visualizers.  
  
## See Also  
 [IEEVisualizerService](../extensibility/ieevisualizerservice.md)   
 [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md)   
 [GetPropertyProxy](../extensibility/ipropertyproxyprovider--getpropertyproxy.md)