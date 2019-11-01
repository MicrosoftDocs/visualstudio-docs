---
title: "IRemoteDebugApplication110::GetCurrentDebuggerOptions | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IRemoteDebugApplication110::GetCurrentDebuggerOptions"
ms.assetid: a6e9cae1-e8f3-4d62-b133-52e9ca12ba7a
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication110::GetCurrentDebuggerOptions
Returns the set of options that are currently enabled.  
  
> [!IMPORTANT]
> [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT GetCurrentDebuggerOptions([out] enum SCRIPT_DEBUGGER_OPTIONS* pCurrentOptions);  
```  
  
#### Parameters  
 `pCurrentOptions`  
 [out] The current options.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)   
 [IRemoteDebugApplication110 Interface](../../winscript/reference/iremotedebugapplication110-interface.md)