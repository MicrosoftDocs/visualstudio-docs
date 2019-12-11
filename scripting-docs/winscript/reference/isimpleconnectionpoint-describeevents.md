---
title: "ISimpleConnectionPoint::DescribeEvents | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISimpleConnectionPoint.DescribeEvents"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "ISimpleConnectionPoint::DescribeEvents"
ms.assetid: 659ea05f-d41e-424a-bb38-df7672b2d135
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISimpleConnectionPoint::DescribeEvents
Returns the DISPID and name for each event in a specified range of events.  
  
## Syntax  
  
```cpp
HRESULT DescribeEvents(  
   ULONG    iEvent,  
   ULONG    cEvents,  
   DISPID*  prgid,  
   BSTR*    prgbstr,  
   ULONG*   pcEventsFetched  
);  
```  
  
#### Parameters  
 `iEvent`  
 [in] Index of the first event to retrieve.  
  
 `cEvents`  
 [in] Number of events to retrieve.  
  
 `prgid`  
 [out] Array of event DISPID values.  
  
 `prgbstr`  
 [out] Array of event names.  
  
 `pcEventsFetched`  
 [out] The actual number of events fetched.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`S_FALSE`|More events were requested than were available. Unavailable events are represented with DISPID_NULL and a null BSTR.|  
|`E_INVALIDARG`|No elements could be fetched.|  
  
## Remarks  
 This method returns the DISPID and name for each event in a specified range of events.  
  
## See also  
 [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)