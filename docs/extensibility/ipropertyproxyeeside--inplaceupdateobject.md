---
title: "IPropertyProxyEESide::InPlaceUpdateObject"
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
  - "IPropertyProxyEESide::InPlaceUpdateObject"
helpviewer_keywords: 
  - "IPropertyProxyEESide::InPlaceUpdateObject"
ms.assetid: abf89411-1853-4f23-b244-d5e0afa197b1
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
# IPropertyProxyEESide::InPlaceUpdateObject
Updates the object's data with the given data object and returns a new data object representing the object's new data.  
  
## Syntax  
  
```cpp#  
HRESULT InPlaceUpdateObject(  
   [in] IEEDataStorage*   dataIn,  
   [out] IEEDataStorage** dataOut  
);  
```  
  
```c#  
int InPlaceUpdateObject(  
   IEEDataStorage     dataIn,  
   out IEEDataStorage dataOut  
);  
```  
  
#### Parameters  
 `dataIn`  
 [in] An [IEEDataStorage](../extensibility/ieedatastorage.md) object containing the new data.  
  
 `dataOut`  
 [out] Returns a new `IEEDataStorage` object containing the replaced data.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method actually updates the object's data. The data in the returned [IEEDataStorage](../extensibility/ieedatastorage.md) object does not need to be the same as the data in the incoming `IEEDataStorage` object, but the returned object must reflect the property's current value.  
  
 The incoming data object is typically not implemented by the EE. However, the object returned by this method is always implemented by the EE, which lets the EE implement the `IEEDataStorage` interface on whatever class is desired.  
  
 The [CreateReplacementObject](../extensibility/ipropertyproxyeeside--createreplacementobject.md) method creates a data object based on the incoming data object but does not affect the property's original data.  
  
## See Also  
 [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md)   
 [IEEDataStorage](../extensibility/ieedatastorage.md)   
 [CreateReplacementObject](../extensibility/ipropertyproxyeeside--createreplacementobject.md)