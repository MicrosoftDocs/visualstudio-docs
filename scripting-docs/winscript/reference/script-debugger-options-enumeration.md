---
title: "SCRIPT_DEBUGGER_OPTIONS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "SCRIPT_DEBUGGER_OPTIONS Enumeration"
ms.assetid: aef41ec0-6f65-48e8-a69e-44b4e4fb929f
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPT_DEBUGGER_OPTIONS Enumeration
Indicates a set of options and/or capabilities that apply to the attached debugger. Used in [IDebugApplicationNode100::GetExcludedDocuments](../../winscript/reference/idebugapplicationnode100-getexcludeddocuments.md) and [IDebugApplicationNode100::SetFilterForEventSink](../../winscript/reference/idebugapplicationnode100-setfilterforeventsink.md)  
  
> [!IMPORTANT]
> These constants are implemented by PDM v10.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp
typedef SCRIPT_DEBUGGER_OPTIONS  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|SDO_NONE|0x00000000|No options are set.|  
|SDO_ENABLE_FIRST_CHANCE_EXCEPTIONS|0x00000001|Indicates that the script runtime should raise BREAKREASON_ERROR events when an exception is thrown. This option may be set by the debugger, or set by user-code via `Debug.enableFirstChanceExceptions(<true&#124;false>)`.|  
|SDO_ENABLE_WEB_WORKER_SUPPORT|0x00000002|Indicates that the attached debugger supports web workers.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)