---
title: "IDebugClassField::EnumBaseClasses"
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
  - "IDebugClassField::EnumBaseClasses"
helpviewer_keywords: 
  - "IDebugClassField::EnumBaseClasses method"
ms.assetid: 78749674-ef75-46d3-a1f4-ff33afd90e32
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
# IDebugClassField::EnumBaseClasses
Creates an enumerator for the base classes of this class.  
  
## Syntax  
  
```cpp#  
HRESULT EnumBaseClasses(   
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumBaseClasses(  
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../extensibility/ienumdebugfields.md) object representing the list of base classes. Returns a null value if there are no base classes.  
  
## Return Value  
 If successful, returns S_OK, returns S_SH_NO_BASE_CLASSES if there are no base classes (and the `ppEnum` parameter is set to a null value); otherwise, returns an error code.  
  
## Remarks  
 The base classes in the enumerator object are specified in order of the most immediate (or most derived) base class to the most remote base class. For example, given the C++ classes:  
  
```  
class Root { }  
class Level1 : Root { }  
class Level2 : Level1 { }  
class MyClass : Level2 { }  
```  
  
 The enumeration would return the base classes in the order `Level2`, `Level1`, `Root`.  
  
## See Also  
 [IDebugClassField](../extensibility/idebugclassfield.md)   
 [IEnumDebugFields](../extensibility/ienumdebugfields.md)