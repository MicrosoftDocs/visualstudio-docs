---
title: "BP_LOCATION_CODE_ADDRESS | Microsoft Docs"
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
  - "BP_LOCATION_CODE_ADDRESS"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_ADDRESS structure"
ms.assetid: 83c9da8b-19d9-4be5-b225-854543654901
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
# BP_LOCATION_CODE_ADDRESS
Describes the location of a breakpoint at an address in code.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_ADDRESS {   
   BSTR bstrContext;  
   BSTR bstrModuleUrl;  
   BSTR bstrFunction;  
   BSTR bstrAddress;  
} BP_LOCATION_CODE_ADDRESS;  
```  
  
## Members  
 `bstrContext`  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 `bstrModuleUrl`  
 The URL of the module that contains the breakpoint.  
  
 `bstrFunction`  
 The name of the function that contains the breakpoint.  
  
 `bstrAddress`  
 The address of the breakpoint, which is parsed by an expression evaluator to bind it to an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)