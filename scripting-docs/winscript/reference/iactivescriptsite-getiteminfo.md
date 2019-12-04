---
title: "IActiveScriptSite::GetItemInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.GetItemInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_GetItemInfo"
ms.assetid: f859ed3b-02c1-4924-99f8-5f5bf1bf8405
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::GetItemInfo
Allows the scripting engine to obtain information about an item added with the [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) method.  
  
## Syntax  
  
```cpp
HRESULT GetItemInfo(  
    LPCOLESTR pstrName,     // address of item name  
    DWORD dwReturnMask,     // bit mask for information retrieval  
    IUnknown **ppunkItem,   // address of pointer to item's IUnknown  
    ITypeInfo **ppTypeInfo  // address of pointer to item's ITypeInfo  
);  
```  
  
#### Parameters  
 `pstrName`  
 [in] The name associated with the item, as specified in the [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) method.  
  
 `dwReturnMask`  
 [in] A bit mask specifying what information about the item should be returned. The scripting engine should request the minimum amount of information possible because some of the return parameters (for example, `ITypeInfo`) can take considerable time to load or generate. Can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTINFO_IUNKNOWN|Returns the `IUnknown` interface for this item.|  
|SCRIPTINFO_ITYPEINFO|Returns the `ITypeInfo` interface for this item.|  
  
 `ppunkItem`  
 [out] Address of a variable that receives a pointer to the `IUnknown` interface associated with the given item. The scripting engine can use the `IUnknown::QueryInterface` method to obtain the `IDispatch` interface for the item. This parameter receives NULL if `dwReturnMask` does not include the SCRIPTINFO_IUNKNOWN value. Also, it receives NULL if there is no object associated with the item name; this mechanism is used to create a simple class when the named item was added with the SCRIPTITEM_CODEONLY flag set in the [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) method.  
  
 `ppTypeInfo`  
 [out] Address of a variable that receives a pointer to the `ITypeInfo` interface associated with the item. This parameter receives NULL if `dwReturnMask` does not include the SCRIPTINFO_ITYPEINFO value, or if type information is not available for this item. If type information is not available, the object cannot source events, and name binding must be realized with the `IDispatch::GetIDsOfNames` method. Note that the `ITypeInfo` interface retrieved describes the item's coclass (TKIND_COCLASS) because the object may support multiple interfaces and event interfaces. If the item supports the `IProvideMultipleTypeInfo` interface, the `ITypeInfo` interface retrieved is the same as the index zero `ITypeInfo` that would be obtained using the `IProvideMultipleTypeInfo::GetInfoOfIndex` method.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`TYPE_E_ELEMENTNOTFOUND`|An item of the specified name was not found.|  
  
## Remarks  
 This method retrieves only the information indicated by the `dwReturnMask` parameter; this improves performance. For example, if an `ITypeInfo` interface is not needed for an item, it is simply not specified in `dwReturnMask`.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)