---
title: "IPerPropertyBrowsing2::GetDisplayString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IPerPropertyBrowsing2.GetDisplayString"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IPerPropertyBrowsing2::GetDisplayString"
ms.assetid: 8f75c6a9-86a9-4e2d-8cb4-74e7b1c0a524
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IPerPropertyBrowsing2::GetDisplayString
Gets a string to display types which are not inherently viewable The returned text is a name describing the property and can be displayed in the caller's user interface.  
  
## Syntax  
  
```cpp
HRESULT GetDisplayString(  
   DISPID  dispid,  
   BSTR*  pBstr  
);  
```  
  
#### Parameters  
 `dispid`  
 [in] Dispatch identifier of the property whose display name is requested.  
  
 `pBstr`  
 [out] Pointer to the `BSTR` containing the display name for the property identified by `dispID`.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## Remarks  
 The returned string is not a legal value of the property. It is just a string display of the property.  
  
## See also  
 [IPerPropertyBrowsing2 Interface 1](../../winscript/reference/iperpropertybrowsing2-interface-1.md)