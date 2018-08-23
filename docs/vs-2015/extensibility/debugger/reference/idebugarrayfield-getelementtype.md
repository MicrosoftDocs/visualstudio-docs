---
title: "IDebugArrayField::GetElementType | Microsoft Docs"
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
  - "IDebugArrayField::GetElementType"
helpviewer_keywords: 
  - "IDebugArrayField::GetElementType method"
ms.assetid: c46bf625-0a48-4cbb-8f1f-286356f2c065
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugArrayField::GetElementType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugArrayField::GetElementType](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugarrayfield-getelementtype).  
  
Gets the type of element in the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetElementType(   
   IDebugField** ppType  
);  
```  
  
```csharp  
int GetElementType(  
   out IDebugField ppType  
);  
```  
  
#### Parameters  
 `ppType`  
 [out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that describes the type of element.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md) object assumes that all elements of the array are the same type.  
  
## See Also  
 [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)

