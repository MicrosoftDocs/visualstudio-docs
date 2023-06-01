---
description: "Gets the port identifier."
title: IDebugPort2::GetPortId | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2::GetPortId
helpviewer_keywords:
- IDebugPort2::GetPortId
ms.assetid: 837cb924-c113-4224-aa86-3e02b33dfa70
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugPort2::GetPortId

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the port identifier.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPortId( 
   out Guid pguidPort
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortId( 
   GUID* pguidPort
);
```
---

## Parameters
`pguidPort`\
[out] Returns the GUID that identifies the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
