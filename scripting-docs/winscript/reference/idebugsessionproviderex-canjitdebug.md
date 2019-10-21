---
title: "IDebugSessionProviderEx:CanJITDebug | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSessionProviderEx:CanJITDebug"
apilocation: 
  - "scrobj.dll"
ms.assetid: 68f91bed-ca69-46b5-b517-ca9ca80b8803
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSessionProviderEx:CanJITDebug
Determines whether a specified process can be debugged with Just In Time debugging.  
  
## Syntax  
  
```cpp
HRESULT CanJITDebug(  
   DWORD  pid  
);  
```  
  
#### Parameters  
 `pid`  
 [in] The process identifier for the process to be debugged.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IDebugSessionProviderEx Interface](../../winscript/reference/idebugsessionproviderex-interface.md)