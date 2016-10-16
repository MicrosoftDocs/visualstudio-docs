---
title: "IPropertyProxyEESide::InitSourceDataProvider"
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
  - "IPropertyProxyEESide::InitSourceDataProvider"
helpviewer_keywords: 
  - "IPropertyProxyEESide::InitSourceDataProvider"
ms.assetid: 5156f593-5052-4e3a-9d02-081916fb342d
caps.latest.revision: 11
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
# IPropertyProxyEESide::InitSourceDataProvider
Initializes the source data for this object and returns an object containing the initial data.  
  
## Syntax  
  
```cpp#  
HRESULT InitSourceDataProvider(  
   IEEDataStorage** dataOut  
);  
```  
  
```c#  
int InitSourceDataProvider(  
   out IEEDataStorage dataOut  
);  
```  
  
#### Parameters  
 `dataOut`  
 [out] Returns an [IEEDataStorage](../extensibility/ieedatastorage.md) object  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method does whatever is necessary to initialize an object so it can return an [IEEDataStorage](../extensibility/ieedatastorage.md) interface on the object's data. This allows the object's data to be viewed and, if allowed, changed by a type visualizer.  
  
## See Also  
 [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md)   
 [IEEDataStorage](../extensibility/ieedatastorage.md)