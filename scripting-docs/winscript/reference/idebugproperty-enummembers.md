---
title: "IDebugProperty::EnumMembers | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugProperty.EnumMembers"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugProperty::EnumMembers"
ms.assetid: 8ce398a5-6452-4804-ae8f-5c54cd11c661
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty::EnumMembers
Enumerates the members of a property.  
  
## Syntax  
  
```cpp
HRESULT EnumMembers (  
   DBGPROP_INFO_FLAGSdwFieldSpec,  
   UINTnRadix,  
   REFIIDrefiid,  
   IEnumDebugPropertyInfo**ppEnum  
);  
```  
  
#### Parameters  
 `dwFieldSpec`  
 [in] Specifies the `DBGPROP_INFO_FLAGS` constants that determine which fields in the enumerated debug property structures are to be filled in.  
  
 `nRadix`  
 [in] Radix to be used in interpreting any numerical information.  
  
 `refiid`  
 [in] This IID is passed for filtering the enumerator. The IID is one of the `IDebugPropertyEnumType` interfaces that inherit from `IDebugPropertyEnumType_All`.  
  
 `ppEnum`  
 [out] Returns the `IEnumDebugPropertyInfo` interface that enumerates the member properties.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)   
 [DBGPROP_INFO_FLAGS](../../winscript/reference/dbgprop-info-flags.md)   
 [IDebugPropertyEnumType_All Interface](../../winscript/reference/idebugpropertyenumtype-all-interface.md)   
 [IEnumDebugPropertyInfo Interface](../../winscript/reference/ienumdebugpropertyinfo-interface.md)