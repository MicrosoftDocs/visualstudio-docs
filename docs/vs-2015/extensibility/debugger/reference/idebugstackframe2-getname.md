---
title: "IDebugStackFrame2::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugStackFrame2::GetName"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetName"
ms.assetid: 069d4f96-363f-404e-9c89-5318c4c9821b
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugStackFrame2::GetName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugStackFrame2::GetName](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugstackframe2-getname).  
  
Gets the name of the stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetName (   
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetName (   
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name of a stack frame is typically the name of the method being executed.  
  
## See Also  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)

