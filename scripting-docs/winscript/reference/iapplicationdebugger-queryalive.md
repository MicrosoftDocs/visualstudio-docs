---
title: "IApplicationDebugger::QueryAlive | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IApplicationDebugger.QueryAlive"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IApplicationDebugger::QueryAlive"
ms.assetid: 41181ebb-a3bf-4e41-82af-d6c7348dc706
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebugger::QueryAlive
Indicates if the debugger is responsive.  
  
## Syntax  
  
```cpp
HRESULT QueryAlive();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates if the debugger is responsive. Implementations of this method should always return `S_OK`.  
  
 If the debugger process terminates unexpectedly, COM returns an error from the marshalling proxy for calls to this method.  
  
## See also  
 [IApplicationDebugger Interface](../../winscript/reference/iapplicationdebugger-interface.md)