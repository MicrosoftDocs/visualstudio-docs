---
title: "IDebugPropertyField::GetPropertySetter"
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
  - "IDebugPropertyField::GetPropertySetter"
helpviewer_keywords: 
  - "IDebugPropertyField::GetPropertySetter method"
ms.assetid: 744d76fd-2bcc-4917-a040-ce4cc714ef61
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
# IDebugPropertyField::GetPropertySetter
Gets the method that sets the property.  
  
## Syntax  
  
```cpp#  
HRESULT GetPropertySetter(   
   IDebugMethodField** ppField  
);  
```  
  
```c#  
int GetPropertySetter(  
   out IDebugMethodField ppField  
);  
```  
  
#### Parameters  
 `ppField`  
 [out] Returns an [IDebugMethodField](../extensibility/idebugmethodfield.md) object representing the method that sets the property.  
  
## Return Value  
 If successful, returns S_OK; otherwise returns an error code.  
  
## Remarks  
 To get the method that gets the property, call the [GetPropertyGetter](../extensibility/idebugpropertyfield--getpropertygetter.md) method.  
  
## See Also  
 [IDebugPropertyField](../extensibility/idebugpropertyfield.md)   
 [IDebugMethodField](../extensibility/idebugmethodfield.md)   
 [GetPropertyGetter](../extensibility/idebugpropertyfield--getpropertygetter.md)