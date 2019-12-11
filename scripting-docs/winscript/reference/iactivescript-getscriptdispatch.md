---
title: "IActiveScript::GetScriptDispatch | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetScriptDispatch"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetScriptDispatch"
ms.assetid: 2092ccd4-1f4c-493a-b5b7-077a70ce95ca
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetScriptDispatch
Retrieves the `IDispatch` interface for the methods and properties associated with the currently running script.  
  
## Syntax  
  
```cpp
HRESULT GetScriptDispatch(  
    LPCOLESTR pstrItemName  // address of item name  
    IDispatch **ppdisp      // receives IDispatch pointer  
);  
```  
  
#### Parameters  
 `pstrItemName`  
 [in] Address of a buffer that contains the name of the item for which the caller needs the associated dispatch object. If this parameter is `NULL`, the dispatch object contains as its members all of the global methods and properties defined by the script. Through the `IDispatch` interface and the associated `ITypeInfo` interface, the host can invoke script methods or view and modify script variables.  
  
 `ppdisp`  
 [out] Address of a variable that receives a pointer to the object associated with the script's global methods and properties. If the scripting engine does not support such an object, `NULL` is returned.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
|`S_FALSE`|The scripting engine does not support a dispatch object; the `ppdisp` parameter is set to NULL.|  
  
## Remarks  
 Because methods and properties can be added by calling the [IActiveScriptParse](../../winscript/reference/iactivescriptparse.md) interface, the `IDispatch` interface returned by this method can dynamically support new methods and properties. Similarly, the `IDispatch::GetTypeInfo` method should return a new, unique `ITypeInfo` interface when methods and properties are added. Note, however, that language engines must not change the `IDispatch` interface in a way that is incompatible with any previous `ITypeInfo` interface returned. That implies, for example, that DISPIDs will never be reused.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)