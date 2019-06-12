---
title: "IDebugPort2::GetPortId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPort2::GetPortId"
helpviewer_keywords:
  - "IDebugPort2::GetPortId"
ms.assetid: 837cb924-c113-4224-aa86-3e02b33dfa70
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPort2::GetPortId
Gets the port identifier.

## Syntax

```cpp
HRESULT GetPortId( 
   GUID* pguidPort
);
```

```csharp
int GetPortId( 
   out Guid pguidPort
);
```

## Parameters
`pguidPort`\
[out] Returns the GUID that identifies the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)