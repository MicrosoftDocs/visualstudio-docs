---
title: "SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: b3aa4966-e110-4b30-b368-1281a9740dbd
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND Enumeration
Indicates the kind of exception thrown. This enumeration is used by the [IActiveScriptErrorDebug110::GetExceptionThrownKind](../../winscript/reference/iactivescripterrordebug110-getexceptionthrownkind.md) method.  
  
> [!IMPORTANT]
> These constants are implemented by PDM version 11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp
typedef SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|ETK_FIRST_CHANCE|0x00000000|The exception is a first-chance exception.|  
|ETK_USER_UNHANDLED|0x00000001|The exception isn't handled in user code.|  
|ETK_UNHANDLED|0x00000002|The exception isn't handled in code.|  
  
## See also  
 [IActiveScriptErrorDebug110 Interface](../../winscript/reference/iactivescripterrordebug110-interface.md)