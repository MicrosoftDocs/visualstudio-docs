---
title: "SCRIPTSTATE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "SCRIPTSTATE"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "SCRIPTSTATE enum"
ms.assetid: 5f5deb05-c4bb-4964-8077-e624c6b2a14e
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTSTATE Enumeration
Specifies the state of a scripting engine. This enumeration is used by the [IActiveScript::GetScriptState](../../winscript/reference/iactivescript-getscriptstate.md) , [IActiveScript::SetScriptState](../../winscript/reference/iactivescript-setscriptstate.md) , and [IActiveScriptSite::OnStateChange](../../winscript/reference/iactivescriptsite-onstatechange.md) methods.  
  
## Syntax  
  
```cpp
typedef enum tagSCRIPTSTATE {  
    SCRIPTSTATE_UNINITIALIZED = 0,  
    SCRIPTSTATE_INITIALIZED   = 5,  
    SCRIPTSTATE_STARTED       = 1,  
    SCRIPTSTATE_CONNECTED     = 2,  
    SCRIPTSTATE_DISCONNECTED  = 3,  
    SCRIPTSTATE_CLOSED        = 4  
} SCRIPTSTATE;  
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTSTATE_UNINITIALIZED|Script has just been created, but has not yet been initialized using an `IPersist*` interface and [IActiveScript::SetScriptSite](../../winscript/reference/iactivescript-setscriptsite.md) .|  
|SCRIPTSTATE_INITIALIZED|Script has been initialized, but is not running (connecting to other objects or sinking events) or executing any code. Code can be queried for execution by calling the [IActiveScriptParse::ParseScriptText](../../winscript/reference/iactivescriptparse-parsescripttext.md) method.|  
|SCRIPTSTATE_STARTED|Script can execute code, but is not yet sinking the events of objects added by the [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) method.|  
|SCRIPTSTATE_CONNECTED|Script is loaded and connected for sinking events.|  
|SCRIPTSTATE_DISCONNECTED|Script is loaded and has a run-time execution state, but is temporarily disconnected from sinking events.|  
|SCRIPTSTATE_CLOSED|Script has been closed. The scripting engine no longer works and returns errors for most methods.|  
  
## See also  
 [Active Script Constants, Enumerations, and Error Codes](../../winscript/reference/active-script-constants-enumerations-and-error-codes.md)