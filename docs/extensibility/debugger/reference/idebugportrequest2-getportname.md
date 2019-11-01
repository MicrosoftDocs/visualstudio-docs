---
title: "IDebugPortRequest2::GetPortName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPortRequest2::GetPortName"
helpviewer_keywords:
  - "IDebugPortRequest2::GetPortName"
ms.assetid: 53e2a3a4-bb34-4a02-a983-6bd84ea70587
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPortRequest2::GetPortName
Gets the name of the port.

## Syntax

```cpp
HRESULT GetPortName( 
   BSTR* pbstrPortName
);
```

```csharp
int GetPortName( 
   out string pbstrPortName
);
```

## Parameters
`pbstrPortName`\
[out] Returns the name of the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) interface is usually passed from a debug package (the client) to a port supplier (the server) to obtain a connection to a port. Both the debug package and the port supplier are aware of the possible choices for the port. If a simple string can describe the port, then the `IDebugPortRequest2::GetPortName` method has enough information to make the connection. Otherwise, additional interfaces can be provided by the client, which can be obtained by the server using `IDebugPortRequest2::QueryInterface`.

## See also
- [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md)