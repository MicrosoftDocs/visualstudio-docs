---
title: "IRemoteDebugApplication110::GetMainThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IRemoteDebugApplication110::GetMainThread"
ms.assetid: 9982acc9-3d35-4dcf-8ca9-662469de4072
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication110::GetMainThread
Returns the main thread for hosts that call [SetSite](/windows/win32/api/ocidl/nf-ocidl-iobjectwithsite-setsite), otherwise returns E_FAIL.  
  
> [!IMPORTANT]
> [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT GetMainThread([out] IRemoteDebugApplicationThread **ppThread);  
```  
  
#### Parameters  
 `ppThread`  
 [out] The main [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md).  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)   
 [IRemoteDebugApplication110 Interface](../../winscript/reference/iremotedebugapplication110-interface.md)