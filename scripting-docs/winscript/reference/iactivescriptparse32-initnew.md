---
title: "IActiveScriptParse32::InitNew | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7c77aa16-f391-4c93-9f1a-4e529a9930b2
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptParse32::InitNew
Initializes the scripting engine.  
  
## Syntax  
  
```cpp
HRESULT InitNew(void);  
```  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if an error occurred during initialization.  
  
## Remarks  
 Before the scripting engine can be used, one of the following methods must be called: `IPersist*::Load`, `IPersist*::InitNew`, or `IActiveScriptParse32::InitNew`. The semantics of this method are identical to `IPersistStreamInit::InitNew`, in that this method tells the scripting engine to initialize itself. Note that it is not valid to call both `IPersist*::InitNew` or `IActiveScriptParse32::InitNew` and `IPersist*::Load`, nor is it valid to call `IPersist*::InitNew`, `IActiveScriptParse32::InitNew`, or `IPersist*::Load` more than once.  
  
## See also  
 [IActiveScriptParse32](../../winscript/reference/iactivescriptparse32.md)