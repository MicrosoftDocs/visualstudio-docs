---
title: "IDispatchEx::GetDispID | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.GetDispID"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "GetDispID method"
ms.assetid: a288d63d-b08a-4540-9d9d-0bcd182eff9a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::GetDispID
Maps a single member name to its corresponding DISPID, which can then be used on subsequent calls to `IDispatchEx::InvokeEx`.  
  
## Syntax  
  
```cpp
HRESULT GetDispID(  
   BSTR bstrName,  
   DWORD grfdex,  
   DISPID *pid  
);  
```  
  
#### Parameters  
 `bstrName`  
 Passed in name to be mapped.  
  
 `grfdex`  
 Determines the options for obtaining the member identifier. This can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|fdexNameCaseSensitive|Requests that the name lookup be done in a case-sensitive manner. May be ignored by object that does not support case-sensitive lookup.|  
|fdexNameEnsure|Requests that the member be created if it does not already exist. The new member should be created with the value `VT_EMPTY`.|  
|fdexNameImplicit|Indicates that the caller is searching object(s) for a member of a particular name when the base object is not explicitly specified.|  
|fdexNameCaseInsensitive|Requests that the name lookup be done in a case-insensitive manner. May be ignored by object that does not support case-insensitive lookup.|  
  
 `pid`  
 Pointer to caller-allocated location to receive DISPID result. If an error occurs, `pid` contains DISPID_UNKNOWN.  
  
## Return Value  
 Returns one of the following values:  
  
|||  
|-|-|  
|`S_OK`|Success.|  
|`E_OUTOFMEMORY`|Out of Memory.|  
|`DISP_E_UNKNOWNNAME`|The name was not known.|  
  
## Remarks  
 `GetDispID` can be used instead of `GetIDsOfNames` to obtain the DISPID for a given member.  
  
 Because `IDispatchEx` allows the addition and deletion of members, the set of DISPIDs does not remain constant for the lifetime of an object.  
  
 The unused `riid` parameter in `IDispatch::GetIDsOfNames` has been removed.  
  
## Example  
  
```cpp
BSTR bstrName;  
   DISPID dispid;  
   IDispatchEx *pdex;   
  
   // Assign to pdex and bstrName  
   pdex->GetDispID(bstrName, fdexNameCaseSensitive, &dispid);  
   // Use dispid  
```  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)