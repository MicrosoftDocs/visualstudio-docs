---
title: "IDebugMethodField::EnumArguments"
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
  - "IDebugMethodField::EnumArguments"
helpviewer_keywords: 
  - "IDebugMethodField::EnumArguments method"
ms.assetid: 3ab55488-2437-4ff6-a9ae-78ea6d7b23a8
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
# IDebugMethodField::EnumArguments
Creates an enumerator for the type of each argument required to call the method.  
  
## Syntax  
  
```cpp#  
HRESULT EnumArguments(   
   IEnumDebugFields** ppParams  
);  
```  
  
```c#  
int EnumArguments(  
   out IEnumDebugFields ppParams  
);  
```  
  
#### Parameters  
 `ppParams`  
 [out] Returns an [IEnumDebugFields](../extensibility/ienumdebugfields.md) object representing the list of argument types. Returns a null value if there are no arguments.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no arguments. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../extensibility/idebugfield.md) object representing the types of each parameter. Call the [GetInfo](../extensibility/idebugfield--getinfo.md) method to retrieve information about the type of each parameter.  
  
 If the name of the parameter is needed along with the type, then call the [EnumParameters](../extensibility/idebugmethodfield--enumparameters.md) method.  
  
## See Also  
 [IDebugMethodField](../extensibility/idebugmethodfield.md)   
 [IEnumDebugFields](../extensibility/ienumdebugfields.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [EnumParameters](../extensibility/idebugmethodfield--enumparameters.md)