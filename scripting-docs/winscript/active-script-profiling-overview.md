---
title: "Active Script Profiling Overview | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Active Script Profiling"
ms.assetid: eec2f413-6605-4df4-a86f-4919755e9358
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Active Script Profiling Overview
The [Active Script Profiler Interfaces](../winscript/reference/active-script-profiler-interfaces.md) enable profiling of a scripting engine. Active Script Profiling consists of the following parts:  
  
- Language Engine  
  
- Host  
  
- Profiler  
  
## Language Engine  
 The language engine executes the script. It provides methods that enable profiling of the script code as it is executed. When profiling is enabled, the language engine takes the class identifier (CLSID) of the profiler COM object as an argument. It creates an instance of the profiler COM object and then calls into the profiler when various events occur.  
  
 The language engine implements [IActiveScriptProfilerControl Interface](../winscript/reference/iactivescriptprofilercontrol-interface.md).  
  
> [!NOTE]
> The [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] language runtime checks the JS_PROFILER environment variable on creation to determine whether profiling should be enabled. If this variable is set to the CLSID of the profiler, the language runtime creates an instance of the profiler COM object, using the value of the variable to determine which profiler to create.  
  
## Host  
 The host creates the language engine and provides the language engine with scripts to be executed. A smart host also provides the document context that can be used by a debugger or profiler to provide better information when you are debugging or profiling.  
  
## Profiler  
 The profiler receives the calls from the language engine when various events occur. The profiler must be registered as a COM object and must implement the [IActiveScriptProfilerCallback Interface](../winscript/reference/iactivescriptprofilercallback-interface.md).  
  
## See also  
 [Active Script Profiler Interfaces](../winscript/reference/active-script-profiler-interfaces.md)