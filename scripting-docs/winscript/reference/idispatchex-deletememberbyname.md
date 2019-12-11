---
title: "IDispatchEx::DeleteMemberByName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.DeleteMemberByName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "DeleteMemberByName method"
ms.assetid: a01b4e6a-d989-4b29-bb3f-04554f8c39f7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::DeleteMemberByName
Deletes a member by name.  
  
## Syntax  
  
```cpp
HRESULT DeleteMemberByName(  
   BSTR bstrName,  
   DWORD grfdex  
  
```  
  
#### Parameters  
 `bstrName`  
 Name of member to be deleted.  
  
 `grfdex`  
 Determines if the member name is case sensitive. This can be one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|fdexNameCaseSensitive|Requests that the name lookup be done in a case-sensitive manner. Can be ignored by object that does not support case-sensitive lookup.|  
|fdexNameCaseInsensitive|Requests that the name lookup be done in a case-insensitive manner. Can be ignored by object that does not support case-insensitive lookup.|  
  
## Return Value  
 Returns one of the following values:  
  
|||  
|-|-|  
|`S_OK`|Success.|  
|`S_FALSE`|Member exists but cannot be deleted.|  
  
## Remarks  
 If the member is deleted, the DISPID needs to remain valid for `GetNextDispID`.  
  
 If a member with a given name is deleted and later a member with the same name is recreated, the DISPID should be the same. (Whether members that differ only by case are the "same" is object-dependent.)  
  
## Example  
  
```cpp
BSTR bstrName;  
IDispatchEx *pdex;  
  
// Assign to pdex and bstrName  
pdex->DeleteMemberByName(bstrName, fdexNameCaseSensitive);  
```  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)