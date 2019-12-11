---
title: "IRemoteDebugApplication::ResumeFromBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.ResumeFromBreakPoint"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::ResumeFromBreakPoint"
ms.assetid: a613cc2b-1d69-4713-a235-64372c253b4a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::ResumeFromBreakPoint
Continues an application that is currently in a breakpoint.  
  
## Syntax  
  
```cpp
HRESULT ResumeFromBreakPoint(  
   IRemoteDebugApplicationThread*  prptFocus,  
   BREAKRESUMEACTION               bra,  
   ERRORRESUMEACTION               era  
);  
```  
  
#### Parameters  
 `prptFocus`  
 [in] For stepping modes, the thread which is to be affected by the stepping mode.  
  
 `bra`  
 [in] The action to take upon resuming the application.  
  
 `era`  
 [in] The action to take in the case that the application stopped because of an error.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method continues an application that is currently in a breakpoint.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)   
 [BREAKRESUMEACTION Enumeration](../../winscript/reference/breakresumeaction-enumeration.md)   
 [ERRORRESUMEACTION Enumeration](../../winscript/reference/errorresumeaction-enumeration.md)