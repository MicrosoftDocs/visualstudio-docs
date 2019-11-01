---
title: "IMachineDebugManagerEvents::onAddApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IMachineDebugManagerEvents.onAddApplication"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IMachineDebugManagerEvents::onAddApplication"
ms.assetid: 00a54b91-36d5-430d-b654-5e2abe5300cd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManagerEvents::onAddApplication
Handles the event when an application is added to the running application list.  
  
## Syntax  
  
```cpp
HRESULT onAddApplication(  
   IRemoteDebugApplication*  pda,  
   DWORD                     dwAppCookie  
);  
```  
  
#### Parameters  
 `pda`  
 [in] Application that was added to the running application list.  
  
 `dwAppCookie`  
 [in] The cookie provided when the application was added to the application list.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates that an application was added to the running application list.  
  
## See also  
 [IMachineDebugManagerEvents Interface](../../winscript/reference/imachinedebugmanagerevents-interface.md)   
 [IMachineDebugManagerEvents::onRemoveApplication](../../winscript/reference/imachinedebugmanagerevents-onremoveapplication.md)