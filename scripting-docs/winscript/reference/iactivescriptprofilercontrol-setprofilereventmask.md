---
title: "IActiveScriptProfilerControl::SetProfilerEventMask | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerControl.SetProfilerEventMask"
apilocation: 
  - "scrobj.dll"
ms.assetid: 207e192f-e12e-4fcb-b4d8-eaee50ecb86e
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl::SetProfilerEventMask
Sets a 4-byte bitmask that specifies the types of events that the scripting engine should raise.  
  
## Syntax  
  
```cpp
HRESULT SetProfilerEventMask(  
    [in] DWORD dwEventMask);  
```  
  
#### Parameters  
 `dwEventMask`  
 [in] A 4-byte bitmask that specifies the types of events. The bits are defined in [PROFILER_EVENT_MASK Enumeration](../../winscript/reference/profiler-event-mask-enumeration.md).  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
|`ACTIVPROF_E_PROFILER_ABSENT`|Profiling is not enabled.|  
  
## See also  
 [IActiveScriptProfilerControl Interface](../../winscript/reference/iactivescriptprofilercontrol-interface.md)