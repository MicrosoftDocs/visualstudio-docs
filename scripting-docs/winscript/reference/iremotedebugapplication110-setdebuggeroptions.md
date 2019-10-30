---
title: "IRemoteDebugApplication110::SetDebuggerOptions | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IRemoteDebugApplication110::SetDebuggerOptions"
ms.assetid: 58e9fd18-3e0d-47fa-8893-f316146bde84
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication110::SetDebuggerOptions
Called to update debugger options. This method should be called after [IRemoteDebugApplication::ConnectDebugger](../../winscript/reference/iremotedebugapplication-connectdebugger.md). The [IRemoteDebugApplication::DisconnectDebugger](../../winscript/reference/iremotedebugapplication-disconnectdebugger.md) method automatically resets to the default options. The options default to 0 (SDO_NONE).  
  
> [!IMPORTANT]
> [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT SetDebuggerOptions(        [in] enum SCRIPT_DEBUGGER_OPTIONS mask,        [in] enum SCRIPT_DEBUGGER_OPTIONS value    );  
```  
  
#### Parameters  
 `mask`  
 The [SCRIPT_DEBUGGER_OPTIONS Enumeration](../../winscript/reference/script-debugger-options-enumeration.md) mask.  
  
 `value`  
 The [SCRIPT_DEBUGGER_OPTIONS Enumeration](../../winscript/reference/script-debugger-options-enumeration.md) value.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)   
 [IRemoteDebugApplication110 Interface](../../winscript/reference/iremotedebugapplication110-interface.md)