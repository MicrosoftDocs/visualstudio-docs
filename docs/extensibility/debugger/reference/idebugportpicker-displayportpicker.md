---
description: "Displays the specified dialog box that allows the user to select a port."
title: IDebugPortPicker::DisplayPortPicker
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- DisplayPortPicker
- IDebugPortPicker::DisplayPortPicker
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortPicker::DisplayPortPicker

Displays the specified dialog box that allows the user to select a port.

## Syntax

### [C#](#tab/csharp)
```csharp
public int DisplayPortPicker(
   int hwndParentDialog,
   out string pbstrPortId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DisplayPortPicker(
   HWND hwndParentDialog,
   BSTR* pbstrPortId
);
```
---

## Parameters
`hwndParentDialog`\
[in] Handle for the parent dialog box.

`pbstrPortId`\
[out] Port identifier string.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. A return value of `S_FALSE` (or a return value of `S_OK` with the `BSTR` set to `NULL`) indicates that the user  clicked **Cancel**.

## See also
- [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)
