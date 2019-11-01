---
title: "IPerPropertyBrowsing2::SetPredefinedValue | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IPerPropertyBrowsing2.SetPredefinedValue"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IPerPropertyBrowsing2::SetPredefinedValue"
ms.assetid: 3aff5300-c5a4-4d9b-9d47-a75b64014ac4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IPerPropertyBrowsing2::SetPredefinedValue
Sets the value of the property specified by `dispID`. The predefined value is identified by the token `dwCookie.`  
  
## Syntax  
  
```cpp
HRESULT SetPredefinedValue(  
   DISPID  dispid,  
   DWORD  dwCookie  
);  
```  
  
#### Parameters  
 `dispid`  
 [in] Dispatch identifier of the property for which a predefined value is being set.  
  
 `dwCookie`  
 [in] Token identifying the value to set.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IPerPropertyBrowsing2 Interface 1](../../winscript/reference/iperpropertybrowsing2-interface-1.md)