---
title: "IPropertyProxyEESide::CreateReplacementObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IPropertyProxyEESide::CreateReplacementObject"
helpviewer_keywords: 
  - "IPropertyProxyEESide::CreateReplacementObject"
ms.assetid: 0cfe79b8-c3f1-48b0-a225-e39dee2c92fe
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IPropertyProxyEESide::CreateReplacementObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates a copy of a data object specific to the expression evaluator (EE).  
  
## Syntax  
  
```cpp  
HRESULT CreateReplacementObject(  
   IEEDataStorage*  dataIn,  
   IEEDataStorage** dataOut  
);  
```  
  
```csharp  
int CreateReplacementObject(  
   IEEDataStorage     dataIn,  
   out IEEDataStorage dataOut  
);  
```  
  
#### Parameters  
 `dataIn`  
 [in] An [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object holding the data to be copied.  
  
 `dataOut`  
 [out] Returns a new `IEEDataStorage` object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is given an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object representing an array of bytes. This incoming data object is typically not implemented by the EE. However, the object returned by this method is always implemented by the EE, which lets the EE implement the `IEEDataStorage` interface on whatever class is desired.  
  
 Note that the data supplied by the incoming `IEEDataStorage` object must be the same data in the outgoing `IEEDataStorage` object.  
  
## See also  
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
