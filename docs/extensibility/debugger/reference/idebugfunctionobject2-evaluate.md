---
title: "IDebugFunctionObject2::Evaluate | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugFunctionObject2::Evaluate"
ms.assetid: bc54c652-904b-4297-a6db-faa329684881
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
# IDebugFunctionObject2::Evaluate
Calls the function and returns the resulting value as an object.  
  
## Syntax  
  
```cpp#  
HRESULT Evaluate (  
   IDebugObject** ppParams,  
   DWORD          dwParams,  
   DWORD          dwEvalFlags,  
   DWORD          dwTimeout,  
   IDebugObject** ppResult  
);  
```  
  
```c#  
int Evaluate (  
   IDebugObject     ppParams,  
   uint             dwParams,  
   uint             dwEvalFlags,  
   uint             dwTimeout,  
   out IDebugObject ppResult  
);  
```  
  
#### Parameters  
 `ppParams`  
 [in] An array of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects that represents the input parameters. Each of these parameters was created by using one of the Create methods in this interface.  
  
 `dwParams`  
 [in] The number of parameters in the `ppParams` array.  
  
 `dwEvalFlags`  
 [in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that specify how the evaluation is to be performed.  
  
 `dwTimeout`  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.  
  
 `ppResult`  
 [out] Returns an **IDebugObject** that represents the value of the function as an object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)