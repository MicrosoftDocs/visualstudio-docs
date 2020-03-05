---
title: "IDebugProcessQueryProperties::QueryProperties | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugProcessQueryProperties::QueryProperties"
ms.assetid: 976a9962-b689-45bb-afb6-16b2c5dbc3b8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcessQueryProperties::QueryProperties
This method queries for a specified property values of the debugging process.

## Syntax

```cpp
HRESULT QueryProperties(
   ULONG                  celt,
   PROCESS_PROPERTY_TYPE *rgdwPropTypes,
   VARIANT               *rgtPropValues);
```

```csharp
int QueryProperties(
   uint                       celt,
   enum_PROCESS_PROPERTY_TYPE rgdwPropTypes,
   out object[ ]              rgtPropValues);
```

## Parameters
`celt`\
[in] Size of the arrays containing the property definitions and property values.

`dwPropType`\
[in] An array that contains definitions of the queried properties. The possible values are:

- PROCESS_PROPERTY_COMMAND_LINE = 1

- PROCESS_PROPERTY_CURRENT_DIRECTORY = 2

- PROCESS_PROPERTY_ENVIRONMENT_VARIABLES = 3

`pvarPropValue`\
[out] An array containing the property values.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is seldom used.

## See also
- [IDebugProcessQueryProperties](../../../extensibility/debugger/reference/idebugprocessqueryproperties.md)