---
title: "IDispatchEx::GetNextDispID | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname:
  - "IDispatchEx.GetNextDispID"
apilocation:
  - "scrobj.dll"
helpviewer_keywords:
  - "GetNextDispID method"
ms.assetid: 8263d441-85ee-47f4-bdba-fbf2ad07e85f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::GetNextDispID

Enumerates the members of the object.

## Syntax

```cpp
HRESULT GetNextDispID(
   DWORD grfdex,
   DISPID id,
   DISPID *pid
);
```

## Parameters

`grfdex`\
Determines which set of items are to be enumerated. This can be a combination of the following values:

|Value|Meaning|
|-----------|-------------|
|fdexEnumDefault|Requests that the object enumerates the default elements. The object is allowed to enumerate any set of elements.|
|fdexEnumAll|Requests that the object enumerates all of the elements. The object is allowed to enumerate any set of elements.|

`id`\
Identifies the current member. GetNextDispID retrieves the item in the enumeration after this one. Uses GetDispID or a previous call to GetNextDispID to obtain this identifier. Uses the DISPID_STARTENUM value to obtain the first identifier of the first item.

`pid`\
Address of a DISPID variable that receives the identifier of the next item in the enumeration.

If a member is deleted by `DeleteMemberByName` or `DeleteMemberByDispID`, the `DISPID` needs to remain valid for `GetNextDispID`.

## Return Value

Returns one of the following values:

|||
|-|-|
|`S_OK`|Success.|
|`S_FALSE`|Enumeration is done.|

## Example

```cpp
   HRESULT hr;
   BSTR bstrName;
   DISPID dispid;
   IDispatchEx *pdex;

   // Assign to pdex
   hr = pdex->GetNextDispID(fdexEnumAll, DISPID_STARTENUM, &dispid);
   while (hr == NOERROR)
   {
      hr = pdex->GetMemberName(dispid, &bstrName);
      if (!wcscmp(bstrName, OLESTR("Bar")))
      {
         SysFreeString(bstrName);
         return TRUE;
      }
      SysFreeString(bstrName);
      hr = pdex->GetNextDispID(fdexEnumAll, dispid, &dispid);
   }
```

## See also

- [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)
- [IDispatchEx::GetDispID](../../winscript/reference/idispatchex-getdispid.md)
- [IDispatchEx::DeleteMemberByName](../../winscript/reference/idispatchex-deletememberbyname.md)
- [IDispatchEx::DeleteMemberByDispID](../../winscript/reference/idispatchex-deletememberbydispid.md)