---
title: "IDebugCodeContext3::GetProcess | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugCodeContext3::GetProcess"
ms.assetid: e082e494-2255-4d9d-a5a9-6dadd904bea8
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugCodeContext3::GetProcess
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves a reference to the interface of the debug process.  
  
## Syntax  
  
```cpp#  
HRESULT GetProcess(   
   IDebugProcess2 **ppProcess  
);  
```  
  
```csharp  
public int GetProcess(   
   out IDebugProcess2 ppProcess  
);  
```  
  
#### Parameters  
 `ppProcess`  
 [out] Reference to the debug process interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugCodeContext** object that exposes the [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md) interface.  
  
```cpp#  
HRESULT CDebugCodeContext::GetProcess(IDebugProcess2** ppProcess)  
{  
    HRESULT hr = S_OK;  
    CComPtr<CDebugEngine> pEngine;  
    CComPtr<IDebugPort2> pPort2;  
  
    IfFalseGo( ppProcess, E_INVALIDARG );  
    *ppProcess = NULL;  
  
    IfFalseGo( m_pProgram, E_FAIL );  
    IfFailGo( ((CDebugProgram *)m_pProgram)->GetEngine(&pEngine) );  
    IfFailGo( pEngine->GetSDMProcess(ppProcess) );  
  
Error:  
  
    return hr;  
}  
```  
  
## See Also  
 [IDebugCodeContext3](../../../extensibility/debugger/reference/idebugcodecontext3.md)
