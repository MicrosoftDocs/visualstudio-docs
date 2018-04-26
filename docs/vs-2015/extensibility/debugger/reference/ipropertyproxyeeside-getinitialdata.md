---
title: "IPropertyProxyEESide::GetInitialData | Microsoft Docs"
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
  - "IPropertyProxyEESide::GetInitialData"
helpviewer_keywords: 
  - "IPropertyProxyEESide::GetInitialData"
ms.assetid: 36cceb19-2604-4ef9-b42b-5dd30cbe24b1
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IPropertyProxyEESide::GetInitialData
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IPropertyProxyEESide::GetInitialData](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ipropertyproxyeeside-getinitialdata).  
  
Returns the initial data for this object.  
  
## Syntax  
  
```cpp#  
HRESULT GetInitialData(  
   IEEDataStorage** dataOut  
);  
```  
  
```csharp  
int GetInitialData(  
   out IEEDataStorage dataOut  
);  
```  
  
#### Parameters  
 `dataOut`  
 [out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object containing the initial data of this object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)

