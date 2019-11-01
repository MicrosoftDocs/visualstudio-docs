---
title: "IDispatchEx::DeleteMemberByDispID | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.DeleteMemberByDispID"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "DeleteMemberByDispID method"
ms.assetid: f61231e5-ba93-4ac3-bde8-d363548356b3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::DeleteMemberByDispID
Deletes a member by DISPID.  
  
## Syntax  
  
```cpp
HRESULT DeleteMemberByDispID(  
    DISPID id  
);  
```  
  
#### Parameters  
 `id`  
 Member identifier. Uses `GetDispID` or `GetNextDispID` to obtain the dispatch identifier.  
  
## Return Value  
 Returns one of the following values:  
  
|||  
|-|-|  
|`S_OK`|Success.|  
|`S_FALSE`|Member exists but cannot be deleted.|  
  
## Remarks  
 If the member is deleted, the DISPID needs to remain valid for `GetNextDispID`.  
  
 If a member with a given name is deleted and later a member with the same name is recreated, the DISPID should be the same. (Whether member names that differ only by case are the "same" is object-dependent.)  
  
## Example  
  
```cpp
BSTR bstrName;  
DISPID dispid;  
IDispatchEx *pdex;   
  
// Assign to pdex and bstrName  
if (SUCCEEDED(pdex->GetDispID(bstrName, fdexNameCaseSensitive, &dispid)))  
    pdex->DeleteMemberByDispID(dispid);  
```  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)   
 [IDispatchEx::GetDispID](../../winscript/reference/idispatchex-getdispid.md)   
 [IDispatchEx::GetNextDispID](../../winscript/reference/idispatchex-getnextdispid.md)