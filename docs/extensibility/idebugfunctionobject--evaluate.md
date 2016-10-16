---
title: "IDebugFunctionObject::Evaluate"
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
  - "IDebugFunctionObject::Evaluate"
helpviewer_keywords: 
  - "IDebugFunctionObject::Evaluate method"
ms.assetid: 29349ea3-d5c1-4135-aa76-ced073ab9683
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
# IDebugFunctionObject::Evaluate
Calls the function and returns the resulting value as an object.  
  
## Syntax  
  
```cpp#  
HRESULT Evaluate(   
   IDebugObject** ppParams,  
   DWORD          dwParams,  
   DWORD          dwTimeout,  
   IDebugObject** ppResult  
);  
```  
  
```c#  
int Evaluate(  
   IDebugObject[]   ppParams,   
   IntPtr           dwParams,   
   uint             dwTimeout,   
   out IDebugObject ppResult  
);  
```  
  
#### Parameters  
 `ppParams`  
 [in] An array of [IDebugObject](../extensibility/idebugobject.md) objects representing the input parameters. Each of these parameters was created with one of the `Create` methods in the [IDebugFunctionObject](../extensibility/idebugfunctionobject.md) interface.  
  
 `dwParams`  
 [in] The number of parameters in the `ppParams` array.  
  
 `dwTimeout`  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
 `ppResult`  
 [out] Returns an [IDebugObject](../extensibility/idebugobject.md) representing the value of the function as an object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method sets up and executes a call to the function represented by the [IDebugFunctionObject](../extensibility/idebugfunctionobject.md) object.  
  
## See Also  
 [IDebugFunctionObject](../extensibility/idebugfunctionobject.md)