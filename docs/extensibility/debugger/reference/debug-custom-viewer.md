---
description: "A structure that identifies a custom viewer or type visualizer."
title: DEBUG_CUSTOM_VIEWER
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUG_CUSTOM_VIEWER
helpviewer_keywords:
- DEBUG_CUSTOM_VIEWER structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DEBUG_CUSTOM_VIEWER

A structure that identifies a custom viewer or type visualizer.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct DEBUG_CUSTOM_VIEWER {
    public uint   dwID;
    public string bstrMenuName;
    public string bstrDescription;
    public Guid   guidLang;
    public Guid   guidVendor;
    public string bstrMetric;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct tagDEBUG_CUSTOM_VIEWER {
    DWORD dwID;
    BSTR  bstrMenuName;
    BSTR  bstrDescription;
    GUID  guidLang;
    GUID  guidVendor;
    BSTR  bstrMetric;
} DEBUG_CUSTOM_VIEWER;
```
---

## Members
`dwID`\
An ID to differentiate multiple viewers or visualizers implemented by one `GUID`.

`bstrMenuName`\
The text that will appear in the drop-down menu.

`bstrDescription`\
A description of the custom viewer or type visualizer (must be a null value if not used).

`guidLang`\
Language of the providing expression evaluator.

`guidVendor`\
Vendor of the providing expression evaluator.

`bstrMetric`\
Metric under which the custom viewer or type visualizer `CLSID` is stored.

## Remarks
A list of this structure is returned by a call to the [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) method (and, by extension, the [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md) method).

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md)
- [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md)
