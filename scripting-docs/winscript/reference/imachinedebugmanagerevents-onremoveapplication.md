---
title: "IMachineDebugManagerEvents::onRemoveApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IMachineDebugManagerEvents.onRemoveApplication"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IMachineDebugManagerEvents::onRemoveApplication"
ms.assetid: 3ba71bd8-fd69-4a41-99c6-c736c416f227
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManagerEvents::onRemoveApplication
Handles the event when an application is removed from the running application list.  
  
## Syntax  
  
```cpp
HRESULT onRemoveApplication(  
   IRemoteDebugApplication*  pda,  
   DWORD                     dwAppCookie  
);  
```  
  
#### Parameters  
 `pda`  
 [in] Application that was removed from the running application list.  
  
 `dwAppCookie`  
 [in] The cookie provided when the application was added from the application list.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates that an application was removed from the running application list.  
  
## See also  
 [IMachineDebugManagerEvents Interface](../../winscript/reference/imachinedebugmanagerevents-interface.md)   
 [IMachineDebugManagerEvents::onAddApplication](../../winscript/reference/imachinedebugmanagerevents-onaddapplication.md)