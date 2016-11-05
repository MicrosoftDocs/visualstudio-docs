---
title: "IDebugObject::SetValue | Microsoft Docs"
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
  - "IDebugObject::SetValue"
helpviewer_keywords: 
  - "IDebugObject::SetValue method"
ms.assetid: d652e09c-cdc1-4519-8116-d7c743f5679b
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
# IDebugObject::SetValue
Sets the value of the object from a consecutive series of bytes.  
  
## Syntax  
  
```cpp#  
HRESULT SetValue(   
   BYTE* pValue,  
   UINT  nSize  
);  
```  
  
```c#  
int SetValue(  
   byte[] pValue,   
   uint   nSize  
);  
```  
  
#### Parameters  
 `pValue`  
 [in] An array of bytes representing the new value.  
  
 `nSize`  
 [in] The size of the value in bytes.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The values in the array are copied into this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object, replacing any existing value. The size of the new value can be larger or smaller than the existing value. This `IDebugObject` cannot be a null reference.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md)