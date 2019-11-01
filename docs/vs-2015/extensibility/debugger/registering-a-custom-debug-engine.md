---
title: "Registering a Custom Debug Engine | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, registering"
ms.assetid: 9984cd3d-d34f-4662-9ace-31766499abf5
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# Registering a Custom Debug Engine
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The debug engine must register itself as a class factory following COM conventions as well as register with Visual Studio through the Visual Studio registry subkey.  
  
> [!NOTE]
> An example of how to register a debug engine can be found in the TextInterpreter sample, which is built as part of the [Tutorial: Building a Debug Engine Using ATL COM](https://msdn.microsoft.com/9097b71e-1fe7-48f7-bc00-009e25940c24).  
  
## DLL Server process  
 Typically, a debug engine is implemented in its own DLL as a COM server. This means that the debug engine must register the CLSID of its class factory with COM before Visual Studio can access it. Then the debug engine must register itself with Visual Studio itself in order to establish any properties (otherwise known as metrics) the debug engine supports. The choice of metrics that are written to the Visual Studio registry subkey for the debug engine depends on the features the debug engine supports.  
  
 [SDK Helpers for Debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md) describes not only the registry locations necessary to register a debug engine; it also describes the dbgmetric.lib library, which contains a number of useful functions and declarations for C++ developers that make manipulating the registry easier.  
  
### Example  
 The following is a typical example (from the TextInterpreter sample) showing how to use the `SetMetric` function (from dbgmetric.lib), to register a debug engine with Visual Studio. The metrics being passed are also defined in dbgmetric.lib.  
  
> [!NOTE]
> TextInterpreter is a basic debug engine; it does not implement—and therefore does not register—any other features. A more complete debug engine would have a whole list of `SetMetric` calls or their equivalent, one for each feature the debug engine supports.  
  
```  
// Define base registry subkey to Visual Studio.  
static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0";  
  
HRESULT CTextInterpreterModule::RegisterServer(BOOL bRegTypeLib, const CLSID * pCLSID)  
{  
    SetMetric(metrictypeEngine, __uuidof(Engine), metricName, L"Text File", false, strRegistrationRoot);  
    SetMetric(metrictypeEngine, __uuidof(Engine), metricCLSID, CLSID_Engine, false, strRegistrationRoot);  
    SetMetric(metrictypeEngine, __uuidof(Engine), metricProgramProvider, CLSID_MsProgramProvider, false, strRegistrationRoot);  
  
    return base::RegisterServer(bRegTypeLib, pCLSID);  
}  
```  
  
## See Also  
 [Creating a Custom Debug Engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)   
 [SDK Helpers for Debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)   
 [Tutorial: Building a Debug Engine Using ATL COM](https://msdn.microsoft.com/9097b71e-1fe7-48f7-bc00-009e25940c24)
