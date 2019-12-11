---
title: "IActiveScriptParse::InitNew | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptParse.InitNew"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptParse_InitNew"
ms.assetid: 3a582bd6-fc0d-43a5-812f-5ea55a8517a1
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParse::InitNew
Initializes the scripting engine.  
  
## Syntax  
  
```cpp
HRESULT InitNew(void);  
```  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if an error occurred during initialization.  
  
## Remarks  
 Before the scripting engine can be used, one of the following methods must be called: `IPersist*::Load`, `IPersist*::InitNew`, or `IActiveScriptParse::InitNew`. The semantics of this method are identical to `IPersistStreamInit::InitNew`, in that this method tells the scripting engine to initialize itself. Note that it is not valid to call both `IPersist*::InitNew` or `IActiveScriptParse::InitNew` and `IPersist*::Load`, nor is it valid to call `IPersist*::InitNew`, `IActiveScriptParse::InitNew`, or `IPersist*::Load` more than once.  
  
## See also  
 [IActiveScriptParse](../../winscript/reference/iactivescriptparse.md)