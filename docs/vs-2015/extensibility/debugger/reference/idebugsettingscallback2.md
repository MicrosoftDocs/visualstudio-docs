---
title: "IDebugSettingsCallback2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugSettingsCallback2 interface"
ms.assetid: 7e525d0b-7d7a-4d1c-8b78-e1398fa922f2
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugSettingsCallback2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Enables debug engines to read metric settings remotely.  
  
## Syntax  
  
```  
IDebugSettingsCallback2D : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the event callback of the session debug manager and consumed by debug engines. It could also be used locally instead of Dbgmetric[d].lib.  
  
## Methods  
 The following table shows the methods of `IDebugSettingsCallback2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumEEs](../../../extensibility/debugger/reference/idebugsettingscallback2-enumees.md)|Enumerates the available expression evaluators given the language and vendor identifiers.|  
|[GetEELocalObject](../../../extensibility/debugger/reference/idebugsettingscallback2-geteelocalobject.md)|Retrieves a expression evaluator local object given the metric.|  
|[GetEEMetricDword](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricdword.md)|Retrieves a value that corresponds to the specified metric of the expression evaluator.|  
|[GetEEMetricFile](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricfile.md)|Retrieves the expression evaluator metric file given the name or the metric.|  
|[GetEEMetricGuid](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricguid.md)|Retrieves the unique identifier for a expression evaluator metric given its name.|  
|[GetEEMetricString](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricstring.md)|Retrieves the value string of an expression evaluator metric given its name.|  
|[GetMetricDword](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricdword.md)|Retrieves the value of a metric given its name.|  
|[GetMetricGuid](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricguid.md)|Retrieves the unique identifier of a metric given its name.|  
|[GetMetricString](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricstring.md)|Retrieves the value string of the metric given its name.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
 The following example shows a function that takes an **IDebugSettingsCallback2** object as a parameter.  
  
```cpp#  
HRESULT GetDebugSettingsCallback (IDebugSettingsCallback2 **ppCallback)  
{  
    HRESULT hRes = E_FAIL;  
  
    if ( ppCallback )  
   {  
        if ( EVAL(m_pdec) )  
            hRes = m_pdec->QueryInterface(IID_IDebugSettingsCallback2, (void **)ppCallback);  
        else  
            hRes = E_FAIL;  
    }  
    else  
        hRes = E_INVALIDARG;  
  
    return ( hRes );  
}  
```
