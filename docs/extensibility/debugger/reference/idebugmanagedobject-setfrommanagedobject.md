---
title: "IDebugManagedObject::SetFromManagedObject | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugManagedObject::SetFromManagedObject"
helpviewer_keywords: 
  - "IDebugManagedObject::SetFromManagedObject method"
ms.assetid: 8700ee8d-2704-4580-bccc-046837a24edd
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugManagedObject::SetFromManagedObject
Sets the value of the instance of the value class object from the instance of the value class provided as a parameter.  
  
## Syntax  
  
```cpp  
HRESULT SetFromManagedObject(   
   IUnknown* pManagedObject  
);  
```  
  
```csharp  
int SetFromManagedObject(  
   object pManagedObject  
);  
```  
  
#### Parameters  
 `pManagedObject`  
 [in] An interface that represents the managed object containing the new value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method is used to change the managed object as represented by the [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md) object.  
  
## See Also  
 [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)