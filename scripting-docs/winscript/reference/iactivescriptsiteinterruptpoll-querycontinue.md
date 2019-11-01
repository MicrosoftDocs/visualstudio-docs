---
title: "IActiveScriptSiteInterruptPoll::QueryContinue | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteInterruptPoll.QueryContinue"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteInterruptPoll::QueryContinue"
ms.assetid: 41ac3807-f8b4-4a0e-bcc6-556bc89f3904
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteInterruptPoll::QueryContinue
Allows a host to specify that a script should terminate.  
  
## Syntax  
  
```cpp
HRESULT QueryContinue();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The call succeeded and the host permits the script to continue running.|  
|`S_FALSE`|The call succeeded and the host requests that the script terminate.|  
  
## Remarks  
 The hosted script should terminate unless the return value of the `QueryContinue` method is `S_OK`. A return value of `S_FALSE` indicates that the host explicitly requests that the script terminate.  
  
 A multithreaded host may use the `IActiveScript::InterruptScriptThread` method to terminate a script.  
  
## See also  
 [IActiveScriptSiteInterruptPoll Interface](../../winscript/reference/iactivescriptsiteinterruptpoll-interface.md)   
 [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md)