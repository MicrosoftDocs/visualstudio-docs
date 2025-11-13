---
description: "This method is called to display the specified value."
title: IDebugCustomViewer::DisplayValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomViewer::DisplayValue
helpviewer_keywords:
- IDebugCustomViewer::DisplayValue
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomViewer::DisplayValue

This method is called to display the specified value.

## Syntax

### [C#](#tab/csharp)
```csharp
int DisplayValue(
   IntPtr          hwnd,
   uint            dwID,
   object          pHostServices,
   IDebugProperty3 pDebugProperty
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DisplayValue(
   HWND             hwnd,
   DWORD            dwID,
   IUnknown *       pHostServices,
   IDebugProperty3* pDebugProperty);
);
```
---

## Parameters
`hwnd`\
[in] Parent window

`dwID`\
[in] ID for custom viewers that support more than one type.

`pHostServices`\
[in] Reserved. Always set to null.

`pDebugProperty`\
[in] Interface that can be used to retrieve the value to be displayed.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code.

## Remarks
 The display is "modal" in that this method will create the necessary window, display the value, wait for input, and close the window, all before returning to the caller. This means the method must handle all aspects of displaying the property's value, from creating a window for output, to waiting for user input, to destroying the window.

 To support changing the value on the given [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) object, you can use the [SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md) method —if the value can be expressed as a string. Otherwise, it is necessary to create a custom interface—exclusive to the expression evaluator implementing this `DisplayValue` method—on the same object that implements the `IDebugProperty3` interface. This custom interface would supply methods for changing the data of an arbitrary size or complexity.

## See also
- [IDebugCustomViewer](../../../extensibility/debugger/reference/idebugcustomviewer.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md)
