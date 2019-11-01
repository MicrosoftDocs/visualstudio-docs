---
title: "IMachineDebugManagerCookie::EnumApplications | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IMachineDebugManagerCookie.EnumApplications"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IMachineDebugManagerCookie::EnumApplications"
ms.assetid: 03f863cf-fa7f-4ec4-b1a1-1ae0ad296c39
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManagerCookie::EnumApplications
Returns an enumerator of the current list of running applications.  
  
## Syntax  
  
```cpp
HRESULT EnumApplications(  
   IEnumRemoteDebugApplications**  ppeda  
);  
```  
  
#### Parameters  
 `ppeda`  
 [out] Enumerator containing the current list of running applications.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns an enumerator of the current list of running applications. The debugger IDE uses this method to display and attach applications for debugging purposes.  
  
## See also  
 [IMachineDebugManagerCookie Interface](../../winscript/reference/imachinedebugmanagercookie-interface.md)