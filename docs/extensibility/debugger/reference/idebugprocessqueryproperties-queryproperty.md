---
description: "This method queries for a specified property value of the debugging process."
title: IDebugProcessQueryProperties::QueryProperty
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessQueryProperties::QueryProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcessQueryProperties::QueryProperty

This method queries for a specified property value of the debugging process.

## Syntax

### [C#](#tab/csharp)
```csharp
int QueryProperty(
   enum_PROCESS_PROPERTY_TYPE dwPropType,
   out object                 pvarPropValue);
```
### [C++](#tab/cpp)
```cpp
HRESULT QueryProperty(
   PROCESS_PROPERTY_TYPE  dwPropType,
   VARIANT               *pvarPropValue);
```
---

## Parameters
`dwPropType`\
[in] Definition of the property queried. The values are:

- PROCESS_PROPERTY_COMMAND_LINE = 1

- PROCESS_PROPERTY_CURRENT_DIRECTORY = 2

- PROCESS_PROPERTY_ENVIRONMENT_VARIABLES = 3

`pvarPropValue`\
[out] The value of the property.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is seldom used.

## See also
- [IDebugProcessQueryProperties](../../../extensibility/debugger/reference/idebugprocessqueryproperties.md)
