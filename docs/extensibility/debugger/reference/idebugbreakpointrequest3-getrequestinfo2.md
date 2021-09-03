---
description: "This method gets the breakpoint request information that describes this breakpoint request."
title: IDebugBreakpointRequest3::GetRequestInfo2 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointRequest3::GetRequestInfo2
helpviewer_keywords:
- IDebugBreakpointRequest3::GetRequestInfo2
ms.assetid: 33942e4a-0a0a-49e8-a693-004954f6d38a
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointRequest3::GetRequestInfo2
This method gets the breakpoint request information that describes this breakpoint request.

## Syntax

```cpp
HRESULT GetRequestInfo2(
   BPREQI_FIELDS      dwFields,
   BP_REQUEST_INFO2*  bBPRequestInfo
);
```

```csharp
int GetRequestInfo2(
   enum_BPREQI_FIELDS  dwFields,
   BP_REQUEST_INFO2[]  bBPRequestInfo
);
```

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
