---
title: "IDispatchEx::GetMemberProperties | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.GetMemberProperties"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "GetMemberProperties method"
ms.assetid: 20d43209-12e2-472a-9bf3-81eced137b71
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::GetMemberProperties
Retrieves a member's properties.  
  
## Syntax  
  
```cpp
HRESULT GetMemberProperties(  
   DISPID id,  
   DWORD grfdexFetch,  
   DWORD *pgrfdex  
);  
```  
  
#### Parameters  
 `id`  
 Identifies the member. Uses `GetDispID` or `GetNextDispID` to obtain the dispatch identifier.  
  
 `grfdexFetch`  
 Determines which properties to retrieve. This can be a combination of the values listed under `pgrfdex` and/or a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|grfdexPropCanAll|Combines fdexPropCanGet, fdexPropCanPut, fdexPropCanPutRef, fdexPropCanCall, fdexPropCanConstruct and fdexPropCanSourceEvents.|  
|grfdexPropCannotAll|Combines fdexPropCannotGet, fdexPropCannotPut, fdexPropCannotPutRef, fdexPropCannotCall, fdexPropCannotConstruct and fdexPropCannotSourceEvents.|  
|grfdexPropExtraAll|Combines fdexPropNoSideEffects and fdexPropDynamicType.|  
|grfdexPropAll|Combines grfdexPropCanAll, grfdexPropCannotAll and grfdexPropExtraAll.|  
  
 `pgrfdex`  
 Address of a `DWORD` that receives the requested properties. This can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|fdexPropCanGet|The member can be obtained using DISPATCH_PROPERTYGET.|  
|fdexPropCannotGet|The member cannot be obtained using DISPATCH_PROPERTYGET.|  
|fdexPropCanPut|The member can be set using DISPATCH_PROPERTYPUT.|  
|fdexPropCannotPut|The member cannot be set using DISPATCH_PROPERTYPUT.|  
|fdexPropCanPutRef|The member can be set using DISPATCH_PROPERTYPUTREF.|  
|fdexPropCannotPutRef|The member cannot be set using DISPATCH_PROPERTYPUTREF.|  
|fdexPropNoSideEffects|The member does not have any side effects. For example, a debugger could safely get/set/call this member without changing the state of the script being debugged.|  
|fdexPropDynamicType|The member is dynamic and can change during the lifetime of the object.|  
|fdexPropCanCall|The member can be called as a method using DISPATCH_METHOD.|  
|fdexPropCannotCall|The member cannot be called as a method using DISPATCH_METHOD.|  
|fdexPropCanConstruct|The member can be called as a constructor using DISPATCH_CONSTRUCT.|  
|fdexPropCannotConstruct|The member cannot be called as a constructor using DISPATCH_CONSTRUCT.|  
|fdexPropCanSourceEvents|The member can fire events.|  
|fdexPropCannotSourceEvents|The member cannot fire events.|  
  
## Return Value  
 Returns one of the following values:  
  
|||  
|-|-|  
|`S_OK`|Success.|  
|`DISP_E_UNKNOWNNAME`|The name was not known.|  
  
## Example  
  
```cpp
BSTR bstrName;  
   DISPID dispid;  
   IDispatchEx *pdex;   
   DWORD dwProps;  
  
   // Assign to pdex and bstrName  
   if (SUCCEEDED(pdex->GetDispID(bstrName, fdexNameCaseSensitive, &dispid)) &&  
      SUCCEEDED(pdex->GetMemberProperties(dispid, grfdexPropAll, &dwProps)) &&  
         (dwProps & fdexPropCanPut))  
   {  
      // Assign to member  
   }  
```  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)   
 [IDispatchEx::GetDispID](../../winscript/reference/idispatchex-getdispid.md)   
 [IDispatchEx::GetNextDispID](../../winscript/reference/idispatchex-getnextdispid.md)