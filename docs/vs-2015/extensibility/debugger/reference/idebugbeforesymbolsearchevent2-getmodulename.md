---
title: "IDebugBeforeSymbolSearchEvent2::GetModuleName | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "GetModuleName"
  - "IDebugBeforeSymbolSearchEvent2::GetModuleName"
ms.assetid: 0b4abeac-2eaf-4b2e-a2d5-c9ec303bc869
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugBeforeSymbolSearchEvent2::GetModuleName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugBeforeSymbolSearchEvent2::GetModuleName](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugbeforesymbolsearchevent2-getmodulename).  
  
Retrieves the name of the module currently being debugged.  
  
## Syntax  
  
```cpp#  
HRESULT GetModuleName(   
   BSTR *pbstrModuleName  
);  
```  
  
```csharp  
public int GetModuleName (  
   string pbstrModuleName  
);  
```  
  
#### Parameters  
 `pbstrModuleName`  
 [out] Name of the module.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugBeforeSymbolSearchEventBase** object that exposes the [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md) interface.  
  
```cpp#  
STDMETHODIMP CDebugBeforeSymbolSearchEventBase::GetModuleName(BSTR *pbstrModuleName)  
{  
    HRESULT hRes = E_FAIL;  
  
    if (m_bstrModuleName)  
    {  
  
        *pbstrModuleName = SysAllocString( m_bstrModuleName);  
  
        if (*pbstrModuleName)  
        {  
            hRes = S_OK;  
        }  
    }  
  
    return ( hRes );  
}  
```  
  
## See Also  
 [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md)

