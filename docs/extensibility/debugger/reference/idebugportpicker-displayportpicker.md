---
description: "Displays the specified dialog box that allows the user to select a port."
title: IDebugPortPicker::DisplayPortPicker | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- DisplayPortPicker
- IDebugPortPicker::DisplayPortPicker
ms.assetid: 08511ef5-be64-4069-b169-a569cc94bc64
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
# IDebugPortPicker::DisplayPortPicker

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
