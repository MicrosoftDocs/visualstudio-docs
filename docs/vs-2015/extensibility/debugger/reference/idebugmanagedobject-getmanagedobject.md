---
title: "IDebugManagedObject::GetManagedObject | Microsoft Docs"
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
  - "IDebugManagedObject::GetManagedObject"
helpviewer_keywords: 
  - "IDebugManagedObject::GetManagedObject method"
ms.assetid: 6abe1402-6aad-41e6-8ec1-ae12d5945992
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugManagedObject::GetManagedObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns an interface that represents the managed object.  
  
## Syntax  
  
```cpp#  
HRESULT GetManagedObject(   
   IUnknown** ppManagedObject  
);  
```  
  
```cpp#  
int GetManagedObject(  
   out object ppManagedObject  
);  
```  
  
#### Parameters  
 `ppManagedObject`  
 [out] Returns an interface that represents the managed object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The interface returned from this method can be queried for any interface implemented by the managed class, allowing its methods to be called.  
  
## See Also  
 [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)

