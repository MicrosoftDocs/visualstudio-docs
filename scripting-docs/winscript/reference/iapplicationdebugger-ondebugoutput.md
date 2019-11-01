---
title: "IApplicationDebugger::onDebugOutput | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IApplicationDebugger.onDebugOutput"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IApplicationDebugger::onDebugOutput"
ms.assetid: 978d8bcf-16dc-4f24-a6bc-206adee2b2e9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebugger::onDebugOutput
Handles a debug output event.  
  
## Syntax  
  
```cpp
HRESULT onDebugOutput(  
   LPCOLESTR  pstr  
);  
```  
  
#### Parameters  
 `pstr`  
 [in] String to display in the debugger.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The debugger typically displays `pstr` in an output window.  
  
 This method is called when `IDebugApplication::DebugOutput` is called.  
  
## See also  
 [IApplicationDebugger Interface](../../winscript/reference/iapplicationdebugger-interface.md)   
 [IDebugApplication::DebugOutput](../../winscript/reference/idebugapplication-debugoutput.md)