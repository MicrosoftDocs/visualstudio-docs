---
title: "BP_LOCATION_CODE_STRING | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_LOCATION_CODE_STRING"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_STRING structure"
ms.assetid: a4cd71c6-5052-45fe-907b-ebc6ca1df2e4
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# BP_LOCATION_CODE_STRING
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Used for setting code breakpoints based on a string that the user can enter from the integrated development environment (IDE).  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_STRING {   
   BSTR bstrContext;  
   BSTR bstrCodeExpr;  
} BP_LOCATION_CODE_STRING;  
```  
  
## Members  
 `bstrContext`  
 The context of the breakpoint within the code, typically a method or function name as seen on a call stack.  
  
 `bstrCodeExpr`  
 The string that the user types in to describe the code breakpoint.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)
