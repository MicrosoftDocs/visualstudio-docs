---
title: "IDebugCustomAttribute::GetAttributeTypeField | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCustomAttribute::GetAttributeTypeField"
helpviewer_keywords: 
  - "IDebugCustomAttribute::GetAttributeTypeField"
ms.assetid: d6ce26d5-42ba-44c1-8659-0516db5bc82d
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugCustomAttribute::GetAttributeTypeField
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the custom attribute class type.  
  
## Syntax  
  
```cpp#  
HRESULT GetAttributeTypeField(   
   IDebugClassField** ppCAType  
);  
```  
  
```csharp  
int GetAttributeTypeField(  
   out IDebugClassField ppCAType  
);  
```  
  
#### Parameters  
 `ppCAType`  
 [out] Returns the [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object that represents the class of which the custom attribute is an instance.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A custom attribute is always a class. This method provides access to an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object that describes that class.  
  
## See Also  
 [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)   
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
