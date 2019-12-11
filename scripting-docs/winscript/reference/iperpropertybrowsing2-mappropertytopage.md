---
title: "IPerPropertyBrowsing2::MapPropertyToPage | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IPerPropertyBrowsing2.MapPropertyToPage"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IPerPropertyBrowsing2::MapPropertyToPage"
ms.assetid: e6418a8e-500b-42e1-9b5a-52e6f7567f99
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IPerPropertyBrowsing2::MapPropertyToPage
Returns the CLSID of the property page that can be used to edit this property.  
  
## Syntax  
  
```cpp
HRESULT MapPropertyToPage(  
   DISPID  dispid,  
   CLSID*  pClsidPropPage  
);  
```  
  
#### Parameters  
 `dispid`  
 [in] Dispatch identifier of the property of interest.  
  
 `pClsidPropPage`  
 [out] Pointer to the CLSID identifying the property page associated with the property. If this method fails, *`pClsidPropPage` is set to CLSID_NULL.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IPerPropertyBrowsing2 Interface 1](../../winscript/reference/iperpropertybrowsing2-interface-1.md)