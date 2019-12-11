---
title: "IDebugField::GetContainer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugField::GetContainer"
helpviewer_keywords: 
  - "IDebugField::GetContainer method"
ms.assetid: 6d6c8213-6181-4adf-9584-3e4cac163dd8
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugField::GetContainer
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the container of a field.  
  
## Syntax  
  
```cpp#  
HRESULT GetContainer(   
   IDebugContainerField** ppContainerField  
);  
```  
  
```csharp  
int GetContainer(  
   out IDebugContainerField ppContainerField  
);  
```  
  
#### Parameters  
 `ppContainerField`  
 [out] Returns the container as represented by the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If this field does not have a container, the returned `ppContainerField` will be a null value.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
