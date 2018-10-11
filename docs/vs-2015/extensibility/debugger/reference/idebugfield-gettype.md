---
title: "IDebugField::GetType | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugField::GetType"
helpviewer_keywords: 
  - "IDebugField::GetType method"
ms.assetid: b3cdec9f-ef7b-44d0-a775-d17ef7eae968
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugField::GetType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugField::GetType](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugfield-gettype).  
  
This method gets the type of field.  
  
## Syntax  
  
```cpp#  
HRESULT GetType(   
   IDebugField** ppType  
);  
```  
  
```csharp  
int GetType(  
   out IDebugField ppType  
);  
```  
  
#### Parameters  
 `ppType`  
 [out] Returns the field type as another [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)

