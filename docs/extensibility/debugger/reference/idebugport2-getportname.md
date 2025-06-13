---
description: "Gets the port name."
title: IDebugPort2::GetPortName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2::GetPortName
helpviewer_keywords:
- IDebugPort2::GetPortName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPort2::GetPortName

Gets the port name.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPortName( 
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortName( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
