---
title: "IDebugClassField::EnumNestedEnums"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugClassField::EnumNestedEnums"
helpviewer_keywords: 
  - "IDebugClassField::EnumNestedEnums method"
ms.assetid: 90fd0cef-9145-4de6-91d4-6c881df39d6e
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
# IDebugClassField::EnumNestedEnums
Creates an enumerator for the nested enumerators of this class.  
  
## Syntax  
  
```cpp#  
HRESULT EnumNestedEnums(   
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumNestedEnums(  
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../extensibility/ienumdebugfields.md) object representing the list of nested enumerations. Returns a null value if there are no nested enumerations.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no nested enumerators. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugEnumField](../extensibility/idebugenumfield.md) object describing a nested enumeration.  
  
 An enumeration declared inside a class is considered a nested enumeration. For example, given:  
  
```  
class RootClass {  
   enum NestedEnum { EnumValue = 0 }  
};  
```  
  
 The `EnumNestedEnums` method would return an [IEnumDebugFields](../extensibility/ienumdebugfields.md) object that contains one [IDebugEnumField](../extensibility/idebugenumfield.md) object that represents the `NestedEnum` enumeration.  
  
## See Also  
 [IDebugClassField](../extensibility/idebugclassfield.md)   
 [IEnumDebugFields](../extensibility/ienumdebugfields.md)   
 [IDebugEnumField](../extensibility/idebugenumfield.md)