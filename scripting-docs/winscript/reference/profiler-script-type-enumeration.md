---
title: "PROFILER_SCRIPT_TYPE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "PROFILER_SCRIPT_TYPE"
apilocation: 
  - "scrobj.dll"
ms.assetid: 3ab6633a-6241-44f0-b837-14336f70c71e
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_SCRIPT_TYPE Enumeration
Specifies the type of script.  
  
## Syntax  
  
```cpp
typedef enum {  
    PROFILER_SCRIPT_TYPE_USER,  
    PROFILER_SCRIPT_TYPE_DYNAMIC,  
    PROFILER_SCRIPT_TYPE_NATIVE,  
    PROFILER_SCRIPT_TYPE_DOM  
} PROFILER_SCRIPT_TYPE;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|PROFILER_SCRIPT_TYPE_USER|Specifies user-written script code.|  
|PROFILER_SCRIPT_TYPE_DYNAMIC|Specifies script code that is generated dynamically during execution.|  
|PROFILER_SCRIPT_TYPE_NATIVE|Specifies the script type for native functions and objects that are defined by the scripting engine.|  
|PROFILER_SCRIPT_TYPE_DOM|Specifies a call into the Document Object Model (DOM) of Internet Explorer, for example, a call to the `document.getElementById` method.|  
  
## See also  
 [Active Script Profiler Constants, Enumerations and Structures](../../winscript/reference/active-script-profiler-constants-enumerations-and-structures.md)   
 [IActiveScriptProfilerCallback::ScriptCompiled](../../winscript/reference/iactivescriptprofilercallback-scriptcompiled.md)   
 [IActiveScriptProfilerCallback2::OnFunctionEnterByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionenterbyname.md)   
 [IActiveScriptProfilerCallback2::OnFunctionExitByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionexitbyname.md)