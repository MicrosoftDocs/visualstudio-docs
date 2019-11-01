---
title: "IActiveScriptProfilerControl::StartProfiling | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerControl.StartProfiling"
apilocation: 
  - "scrobj.dll"
ms.assetid: 56a7b3b7-8c21-43d0-9d8b-53bbc19fabb9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl::StartProfiling
Starts profiling on the scripting engine. The scripting engine creates an instance of the profiler object by making a call to [CoCreateInstance](/windows/desktop/api/combaseapi/nf-combaseapi-cocreateinstance).  
  
## Syntax  
  
```cpp
HRESULT StartProfiling(  
    [in] REFCLSID clsidProfilerObject,  
    [in] DWORD dwEventMask,  
    [in] DWORD dwContext);  
```  
  
#### Parameters  
 `clsidProfilerObject`  
 [in] Class identifier (CLSID) of the profiler object to be created.  
  
 `dwEventMask`  
 [in] A 4-byte bitmask that specifies the types of events. The bits are defined in [PROFILER_EVENT_MASK Enumeration](../../winscript/reference/profiler-event-mask-enumeration.md).  
  
 `dwContext`  
 [in] A 4-byte value that is passed to the profiler object.  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
|`ACTIVPROF_E_PROFILER_PRESENT`|Profiling is already enabled.|  
  
## See also  
 [IActiveScriptProfilerControl Interface](../../winscript/reference/iactivescriptprofilercontrol-interface.md)