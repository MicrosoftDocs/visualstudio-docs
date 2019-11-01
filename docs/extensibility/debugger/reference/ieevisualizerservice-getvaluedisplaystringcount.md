---
title: "IEEVisualizerService::GetValueDisplayStringCount | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IEEVisualizerService::GetValueDisplayStringCount"
  - "GetValueDisplayStringCount"
ms.assetid: d683a833-fbfb-4042-84df-6905124a268a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEVisualizerService::GetValueDisplayStringCount
Retrieves the number of value strings to display for the specified property or field.

## Syntax

```cpp
HRESULT GetValueDisplayStringCount (
   DWORD         displayKind,
   IDebugField * propertyOrField,
   ULONG *       pcelt
);
```

```csharp
int GetValueDisplayStringCount (
   uint        displayKind,
   IDebugField propertyOrField,
   out ulong   pcelt
);
```

## Parameters
`displayKind`\
[in] Value from the [DisplayKind](../../../extensibility/debugger/reference/displaykind.md) enumeration.

`propertyOrField`\
[in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface that represents a property or field.

`pcelt`\
[out] Returns the number of value strings to display.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)