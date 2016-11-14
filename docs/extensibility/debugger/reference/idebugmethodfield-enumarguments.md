---
title: "IDebugMethodField::EnumArguments | Microsoft Docs"
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
 [out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of argument types. Returns a null value if there are no arguments.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no arguments. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing the types of each parameter. Call the [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md) method to retrieve information about the type of each parameter.  
  
 If the name of the parameter is needed along with the type, then call the [EnumParameters](../../../extensibility/debugger/reference/idebugmethodfield-enumparameters.md) method.  
  
## See Also  
 [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)   
 [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [EnumParameters](../../../extensibility/debugger/reference/idebugmethodfield-enumparameters.md)