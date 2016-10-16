---
title: "IDebugPropertyField::GetPropertyGetter"
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
  - "IDebugPropertyField::GetPropertyGetter"
helpviewer_keywords: 
  - "IDebugPropertyField::GetPropertyGetter method"
ms.assetid: ab9f861a-42ad-4a82-9ae6-2606176f755a
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
# IDebugPropertyField::GetPropertyGetter
Gets the method that gets the property.  
  
## Syntax  
  
```cpp#  
HRESULT GetPropertyGetter(   
   IDebugMethodField** ppField  
);  
```  
  
```cpp#  
int GetPropertyGetter(  
   out IDebugMethodField ppField  
);  
```  
  
#### Parameters  
 `ppField`  
 [out] Returns an [IDebugMethodField](../extensibility/idebugmethodfield.md) object representing the method that gets the property.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 To get the method that sets the property, [GetPropertySetter](../extensibility/idebugpropertyfield--getpropertysetter.md) call the method.  
  
## See Also  
 [IDebugPropertyField](../extensibility/idebugpropertyfield.md)   
 [GetPropertySetter](../extensibility/idebugpropertyfield--getpropertysetter.md)   
 [IDebugMethodField](../extensibility/idebugmethodfield.md)