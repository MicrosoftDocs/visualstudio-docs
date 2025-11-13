---
description: "This method queries for a specified property values of the debugging process."
title: IDebugProcessQueryProperties::QueryProperties
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessQueryProperties::QueryProperties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcessQueryProperties::QueryProperties

This method queries for a specified property values of the debugging process.

## Syntax

### [C#](#tab/csharp)
```csharp
int QueryProperties(
   uint                       celt,
   enum_PROCESS_PROPERTY_TYPE rgdwPropTypes,
   out object[ ]              rgtPropValues);
```
### [C++](#tab/cpp)
```cpp
HRESULT QueryProperties(
   ULONG                  celt,
   PROCESS_PROPERTY_TYPE *rgdwPropTypes,
   VARIANT               *rgtPropValues);
```
---

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
