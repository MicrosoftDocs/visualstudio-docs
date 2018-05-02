---
title: "IDebugClassField::GetEnclosingClass | Microsoft Docs"
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
  - "IDebugClassField::GetEnclosingClass"
helpviewer_keywords: 
  - "IDebugClassField::GetEnclosingClass method"
ms.assetid: a0c12e3c-9ea0-4dfb-9e45-8cea18725022
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugClassField::GetEnclosingClass
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugClassField::GetEnclosingClass](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugclassfield-getenclosingclass).  
  
Gets the class that encloses this class.  
  
## Syntax  
  
```cpp#  
HRESULT GetEnclosingClass(   
   IDebugClassField** ppClassField  
);  
```  
  
```csharp  
int GetEnclosingClass(  
   out IDebugClassField ppClassField  
);  
```  
  
#### Parameters  
 `ppClassField`  
 [out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object representing the enclosing class. Returns a null value if there is no enclosing class.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 If the class represented by this [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object is a nested class, then the `ppClassField` parameter returns an `IDebugClassField` object representing the enclosing class. For example, given this class definition:  
  
```  
class RootClass {  
   class NestedClass { }  
};  
```  
  
 Calling the `GetEnclosingClass` method on the `IDebugClassField` object representing the `NestedClass` class returns an `IDebugClassField` object representing the class `RootClass`.  
  
## See Also  
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)

