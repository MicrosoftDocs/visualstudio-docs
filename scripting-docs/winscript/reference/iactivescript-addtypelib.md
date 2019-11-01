---
title: "IActiveScript::AddTypeLib | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.AddTypeLib"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_AddTypeLib"
ms.assetid: 8e507ea8-c80a-471c-b482-ae753c6e8595
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::AddTypeLib
Adds a type library to the name space for the script. This is similar to the `#include` directive in C/C++. It allows a set of predefined items such as class definitions, `typedefs`, and named constants to be added to the run-time environment available to the script.  
  
## Syntax  
  
```cpp
HRESULT AddTypeLib(  
    REFGUID guidTypeLib,  // CLSID of type library  
    DWORD dwMaj,          // major version number  
    DWORD dwMin,          // minor version number  
    DWORD dwFlags         // option flags  
);  
```  
  
#### Parameters  
 `guidTypeLib`  
 [in] CLSID of the type library to add.  
  
 `dwMaj`  
 [in] Major version number.  
  
 `dwMin`  
 [in] Minor version number.  
  
 `dwFlags`  
 [in] Option flags. Can be the following:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTTYPELIB_ISCONTROL|The type library describes an ActiveX control used by the host.|  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
|`TYPE_E_CANTLOADLIBRARY`|The specified type library could not be loaded.|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)