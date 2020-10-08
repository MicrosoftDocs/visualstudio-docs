---
title: "IDebugProgram2::EnumCodePaths | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::EnumCodePaths"
helpviewer_keywords: 
  - "IDebugProgram2::EnumCodePaths"
ms.assetid: fb100c3c-9c29-4d63-bd1f-a3e531cb395f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::EnumCodePaths
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves a list of the code paths for a given position in a source file.  
  
## Syntax  
  
```cpp#  
HRESULT EnumCodePaths(   
   LPCOLESTR            pszHint,  
   IDebugCodeContext2*  pStart,  
   IDebugStackFrame2*   pFrame,  
   BOOL                 fSource,  
   IEnumCodePaths2**    ppEnum,  
   IDebugCodeContext2** ppSafety  
);  
```  
  
```csharp  
int EnumCodePaths(   
   string                 pszHint,  
   IDebugCodeContext2     pStart,  
   IDebugStackFrame2      pFrame,  
   Int                    fSource,  
   out IEnumCodePaths2    ppEnum,  
   out IDebugCodeContext2 ppSafety  
);  
```  
  
#### Parameters  
 `pszHint`  
 [in] The word under the cursor in the **Source** or **Disassembly** view in the IDE.  
  
 `pStart`  
 [in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object representing the current code context.  
  
 `pFrame`  
 [in] An [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) object representing the stack frame associated with the current breakpoint.  
  
 `fSource`  
 [in] Nonzero (`TRUE`) if in the **Source** view, or zero (`FALSE`) if in the **Disassembly** view.  
  
 `ppEnum`  
 [out] Returns an [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md) object containing a list of the code paths.  
  
 `ppSafety`  
 [out] Returns an [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object representing an additional code context to be set as a breakpoint in case the chosen code path is skipped. This can happen in the case of a short-circuited Boolean expression, for example.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A code path describes the name of a method or function that was called to get to the current point in the execution of the program. A list of code paths represents the call stack.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
