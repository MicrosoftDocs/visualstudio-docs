---
title: "IActiveScriptWinRTErrorDebug::GetRestrictedErrorReference | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptWinRTErrorDebug::GetRestrictedErrorReference"
ms.assetid: fcf60971-9518-4b24-a3a6-1e2e30a02cea
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptWinRTErrorDebug::GetRestrictedErrorReference
Returns the Windows Runtime restricted reference error, if available.  
  
> [!IMPORTANT]
> [IActiveScriptWinRTErrorDebug Interface](../../winscript/reference/iactivescriptwinrterrordebug-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT GetRestrictedErrorReference([out] BSTR * referenceString);  
```  
  
#### Parameters  
 `referenceString`  
 [out] The reference error string.  
  
## See also  
 [IActiveScriptWinRTErrorDebug Interface](../../winscript/reference/iactivescriptwinrterrordebug-interface.md)