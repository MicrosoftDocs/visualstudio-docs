---
title: "IActiveScriptErrorDebug110::GetExceptionThrownKind | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptErrorDebug110::QueryIsFirstChance"
ms.assetid: ecc16e54-93e4-4322-ae13-afa7cd860032
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptErrorDebug110::GetExceptionThrownKind
Returns a value that indicates the kind of exception thrown.  
  
> [!IMPORTANT]
> [IActiveScriptErrorDebug110 Interface](../../winscript/reference/iactivescripterrordebug110-interface.md) is implemented by PDM version 11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp
HRESULT GetExceptionThrownKind(  
   SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND*  pExceptionKind  
);  
```  
  
#### Parameters  
 `pExceptionKind`  
 [out] The kind of exception that is thrown (for example, first-chance or unhandled), represented by a [SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND Enumeration](../../winscript/reference/script-error-debug-exception-thrown-kind-enumeration.md) enumeration value.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## See also  
 [IActiveScriptErrorDebug110 Interface](../../winscript/reference/iactivescripterrordebug110-interface.md)