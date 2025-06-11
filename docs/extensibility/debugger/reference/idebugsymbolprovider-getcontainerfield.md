---
description: "This method gets the field that contains the debug address."
title: IDebugSymbolProvider::GetContainerField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetContainerField
helpviewer_keywords:
- IDebugSymbolProvider::GetContainerField method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetContainerField

This method gets the field that contains the debug address.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetContainerField(
   IDebugAddress            pAddress,
   out IDebugContainerField ppContainerField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetContainerField( 
   IDebugAddress*         pAddress,
   IDebugContainerField** ppContainerField
);
```
---

## Parameters
`pAddress`\
[in] The address as represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`ppContainerField`\
[out] Returns a container field represented by an [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
