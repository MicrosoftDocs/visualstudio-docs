---
description: "This method gets the breakpoint request information that describes this breakpoint request."
title: IDebugBreakpointRequest3::GetRequestInfo2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointRequest3::GetRequestInfo2
helpviewer_keywords:
- IDebugBreakpointRequest3::GetRequestInfo2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointRequest3::GetRequestInfo2

This method gets the breakpoint request information that describes this breakpoint request.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetRequestInfo2(
   enum_BPREQI_FIELDS  dwFields,
   BP_REQUEST_INFO2[]  bBPRequestInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetRequestInfo2(
   BPREQI_FIELDS      dwFields,
   BP_REQUEST_INFO2*  bBPRequestInfo
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md) enumeration that determine which fields of `pBPRequestInfo` are to be filled in.

`bBPRequestInfo`\
[out] The [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structure to be filled in.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## Remarks
 There is more information in this request than is returned from the [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md) method.

## See also
- [IDebugBreakpointRequest3](../../../extensibility/debugger/reference/idebugbreakpointrequest3.md)
- [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md)
- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
- [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md)
