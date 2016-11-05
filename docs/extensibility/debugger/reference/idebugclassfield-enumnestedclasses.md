---
title: "IDebugClassField::EnumNestedClasses | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugClassField::EnumNestedClasses"
helpviewer_keywords: 
  - "IDebugClassField::EnumNestedClasses method"
ms.assetid: 2ba5ef0c-395e-4006-9e3c-9b06e1d711d0
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugClassField::EnumNestedClasses
Creates an enumerator for the classes nested in this class.  
  
## Syntax  
  
```cpp#  
HRESULT EnumNestedClasses(   
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumNestedClasses(  
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of nested classes. Returns a null value if there are no nested classes.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no nested classes. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object describing a nested class.  
  
 A nested class is a class defined inside another class. For example:  
  
```  
class RootClass {  
   class NestedClass { }  
};  
```  
  
 The [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) enumeration would contain one object representing the `NestedClass` class.  
  
## See Also  
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)   
 [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)