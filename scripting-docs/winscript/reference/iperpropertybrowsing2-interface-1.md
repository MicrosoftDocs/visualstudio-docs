---
title: "IPerPropertyBrowsing2 Interface 1 | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IPerPropertyBrowsing2"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IPerPropertyBrowsing2 interface"
ms.assetid: 1e50b3f7-cc1c-495a-93c7-3ee03aea0b8a
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IPerPropertyBrowsing2 Interface 1
Accesses the information in the property pages offered by an object.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|`GetDisplayString`|Returns a text string describing the specified property.|  
|`MapPropertyToPage`|Returns the CLSID of the property page that allows manipulation of the specified property.|  
|`GetPredefinedStrings`|Returns a counted array of strings (`LPOLESTR` pointers) listing the descriptions of the allowable values that the specified property can accept.|  
|`SetPredefinedValue`|Sets the value of the property to the predefined value identified by the token `dwCookie.`|  
  
## Requirements  
 Header: dbgprop.h