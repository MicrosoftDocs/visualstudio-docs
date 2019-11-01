---
title: "IDebugApplication::GetBreakFlags | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.GetBreakFlags"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::GetBreakFlags"
ms.assetid: 0532ba94-f791-46ad-88ae-5f6ba220b667
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::GetBreakFlags
Returns the current break flags for the application.  
  
## Syntax  
  
```cpp
HRESULT GetBreakFlags(  
   APPBREAKFLAGS*                   pabf,  
   IRemoteDebugApplicationThread**  pprdatSteppingThread  
);  
```  
  
#### Parameters  
 `pabf`  
 [out] The current break flags for the application.  
  
 `pprdatSteppingThread`  
 [out] The currently running thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the current break flags for the application.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [APPBREAKFLAGS Enumeration](../../winscript/reference/appbreakflags-enumeration.md)