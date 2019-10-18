---
title: "CODE_PATH | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "CODE_PATH"
helpviewer_keywords: 
  - "CODE_PATH structure"
ms.assetid: 2d4b2890-4c9d-47e1-83c0-df9c6436427f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# CODE_PATH
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes a method or function call.  
  
## Syntax  
  
```cpp#  
typedef struct tagCODE_PATH {   
   BSTR                bstrName;  
   IDebugCodeContext2* pCode;  
} CODE_PATH;  
```  
  
```csharp  
public struct CODE_PATH {  
   public string            bstrName;  
   public IDebugCodeContext pCode;  
}  
```  
  
## Members  
 bstrName  
 The name of the code path.  
  
 pCode  
 The [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that identifies where in the code to step into a function.  
  
## Remarks  
 This structure is used to implement stepping into a function. [EnumCodePaths](../../../extensibility/debugger/reference/idebugprogram2-enumcodepaths.md) returns all the calls from the current location in the program being debugged. This structure represents one such call.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [EnumCodePaths](../../../extensibility/debugger/reference/idebugprogram2-enumcodepaths.md)
