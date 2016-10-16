---
title: "IDebugMethodField::EnumParameters"
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
  - "IDebugMethodField::EnumParameters"
helpviewer_keywords: 
  - "IDebugMethodField::EnumParameters method"
ms.assetid: d77b1197-deb6-4144-8d1b-8b09949ccfac
caps.latest.revision: 10
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
# IDebugMethodField::EnumParameters
Creates an enumerator for the parameters of the method.  
  
## Syntax  
  
```cpp#  
HRESULT EnumParameters(   
   IEnumDebugFields** ppParams  
);  
```  
  
```c#  
int EnumParameters(  
   out IEnumDebugFields ppParams  
);  
```  
  
#### Parameters  
 `ppParams`  
 [out] Returns an [IEnumDebugFields](../extensibility/ienumdebugfields.md) object representing the list of parameters to the method; otherwise, returns a null value if there are no parameters.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no parameters. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../extensibility/idebugfield.md) object representing different types of parameters. Call the [GetKind](../extensibility/idebugfield--getkind.md) method on each object to determine exactly what kind of parameter the object represents.  
  
 A parameter includes both its variable name and its type. The first parameter to a class method is typically the "this" pointer.  
  
 If only the types of the parameters is needed, call the [EnumArguments](../extensibility/idebugmethodfield--enumarguments.md) method.  
  
## See Also  
 [IDebugMethodField](../extensibility/idebugmethodfield.md)   
 [IEnumDebugFields](../extensibility/ienumdebugfields.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [EnumArguments](../extensibility/idebugmethodfield--enumarguments.md)