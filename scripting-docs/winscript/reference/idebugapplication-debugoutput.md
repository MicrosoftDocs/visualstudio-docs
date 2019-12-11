---
title: "IDebugApplication::DebugOutput | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.DebugOutput"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::DebugOutput"
ms.assetid: 6c02939c-3c2d-474a-ab15-49a37e22b4a7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::DebugOutput
Causes the given string to be displayed by the debugger integrated development environment (IDE).  
  
## Syntax  
  
```cpp
HRESULT DebugOutput(  
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
 This method allows a language engine to implement language-specific debugging output support. The string is typically displayed in the debugger's output window.  
  
 This method causes `IApplicationDebugger::onDebugOutput` to be called.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IApplicationDebugger::onDebugOutput](../../winscript/reference/iapplicationdebugger-ondebugoutput.md)