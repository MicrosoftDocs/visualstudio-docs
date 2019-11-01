---
title: "IPerPropertyBrowsing2::GetPredefinedStrings | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IPerPropertyBrowsing2.GetPredefinedStrings"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IPerPropertyBrowsing2::GetPredefinedStrings"
ms.assetid: d2fa30f7-a566-4dbd-8b47-ffdc00419771
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IPerPropertyBrowsing2::GetPredefinedStrings
Allows the caller to fill a list box with a counted array of string pointers which represent potential values for this property.  
  
## Syntax  
  
```cpp
HRESULT GetPredefinedStrings(  
   DISPID  dispid,  
   CALPOLESTR*  pCaStrings,  
   CADWORD*  pCaCookies  
);  
```  
  
#### Parameters  
 `dispid`  
 [in] Dispatch identifier of the property for which the caller is requesting the string list.  
  
 `pCaStrings`  
 [out] Pointer to a caller-allocated, counted array structure that contains the element count and address of a method-allocated array of string pointers. If the method fails, no memory is allocated, and the contents of the structure are undefined.  
  
 `pCaCookies`  
 [out] Pointer to the caller-allocated, counted array structure that contains the element count and address of a method-allocated array of DWORDs. If the method fails, no memory is allocated, and the contents of the structure are undefined.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IPerPropertyBrowsing2 Interface 1](../../winscript/reference/iperpropertybrowsing2-interface-1.md)