---
title: "IDebugGenericFieldDefinition::ConstructInstantiation"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ConstructInstantiation"
  - "IDebugGenericFieldDefinition::ConstructInstantiation"
ms.assetid: ef8ae261-a98b-4dc2-93b3-7c5191818ba2
caps.latest.revision: 8
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
# IDebugGenericFieldDefinition::ConstructInstantiation
Constructs a field instance given an array of type arguments.  
  
## Syntax  
  
```cpp#  
HRESULT ConstructInstantiation(  
   ULONG32       cArgs,  
   IDebugField** ppArgs,  
   IDebugField** ppConstructedField  
);  
```  
  
```c#  
int ConstructInstantiation(  
   uint            cArgs,  
   IDebugField[]   ppArgs,  
   out IDebugField ppConstructedField  
);  
```  
  
#### Parameters  
 `cArgs`  
 [in] Number of arguments in the `ppArgs` array.  
  
 `ppArgs`  
 [in] Array that contains the type arguments. The type arguments must be closed types (non-generic or fully instantiated generics).  
  
 `ppConstructedField`  
 [out] Returns the [IDebugField](../extensibility/idebugfield.md) interface that represents the new field.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Constraints are not checked.  
  
## See Also  
 [IDebugGenericFieldDefinition](../extensibility/idebuggenericfielddefinition.md)