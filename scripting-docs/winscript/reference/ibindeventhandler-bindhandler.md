---
title: "IBindEventHandler::BindHandler | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IBindEventHandler.BindHandler"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IBindEventHandler::BindHandler"
ms.assetid: 87909828-2224-4bb1-a6c9-dfe715ac4c9b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IBindEventHandler::BindHandler
Binds an event to an object.  
  
## Syntax  
  
```cpp
HRESULT BindHandler(  
   LPCOLESTR   pstrEvent,  
   IDispatch*  pdisp  
);  
```  
  
#### Parameters  
 `pstrEvent`  
 [in] Specifies the event to handle.  
  
 `pdisp`  
 [in] Specifies the object to handle the event.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method binds an event to an object.  
  
## See also  
 [IBindEventHandler Interface](../../winscript/reference/ibindeventhandler-interface.md)