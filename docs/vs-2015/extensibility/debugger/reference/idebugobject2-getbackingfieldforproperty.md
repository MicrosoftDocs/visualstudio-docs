---
title: "IDebugObject2::GetBackingFieldForProperty | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject2::GetBackingFieldForProperty"
helpviewer_keywords: 
  - "IDebugObject2::GetBackingFieldForProperty method"
ms.assetid: e72c6338-5573-4fad-8075-f3ade3435424
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugObject2::GetBackingFieldForProperty
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the field or variable (if any) that may be backing the property represented by this object.  
  
## Syntax  
  
```cpp  
HRESULT GetBackingFieldForProperty(  
   IDebugObject2** ppObject  
);  
```  
  
```csharp  
int GetBackingFieldForProperty(  
   out IDebugObject2 ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] An [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md) object describing the backing field.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md) object represents a managed code class property, that is, a method with a get and/or set accessor. Such properties generally require a variable to contain the value manipulated by the property. This variable is known as the backing field. If there is no backing field for the object, then make sure to return a null value: some callers may not pay attention to the return value but will instead look to see if a null value was returned in `ppObject`.  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
