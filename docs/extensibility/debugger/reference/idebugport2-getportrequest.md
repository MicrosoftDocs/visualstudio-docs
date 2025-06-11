---
description: "Gets the description of a port that was previously used to create the port (if available)."
title: IDebugPort2::GetPortRequest
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2::GetPortRequest
helpviewer_keywords:
- IDebugPort2::GetPortRequest
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPort2::GetPortRequest

Gets the description of a port that was previously used to create the port (if available).

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPortRequest( 
   out IDebugPortRequest2 ppRequest
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortRequest( 
   IDebugPortRequest2** ppRequest
);
```
---

## Parameters
`ppRequest`\
[out] Returns an [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) object representing the request that was used to create the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.  Returns `E_PORT_NO_REQUEST` if a port was not created using an [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) port request.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md)
- [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)
