---
title: "IDebugObject::SetReferenceValue | Microsoft Docs"
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
  - "IDebugObject::SetReferenceValue"
helpviewer_keywords: 
  - "IDebugObject::SetReferenceValue method"
ms.assetid: 08c78a4e-98eb-41cb-8b75-02a6a43d49f7
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
# IDebugObject::SetReferenceValue
Sets the reference value of this object.  
  
## Syntax  
  
```cpp#  
HRESULT SetReferenceValue(   
   IDebugObject* pObject  
);  
```  
  
```c#  
int SetReferenceValue(  
   [In] IDebugObject pObject  
);  
```  
  
#### Parameters  
 `pObject`  
 [in] An [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the new reference value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method makes this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object a reference to the value of the object given in the `pObject` parameter, throwing away any previous reference. Note that this `IDebugObject` object must already be a reference type.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md)