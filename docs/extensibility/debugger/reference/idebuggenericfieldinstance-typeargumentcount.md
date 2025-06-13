---
description: "Returns the number of type parameter arguments for this instance."
title: IDebugGenericFieldInstance::TypeArgumentCount
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- TypeArgumentCount
- IDebugGenericFieldInstance::TypeArgumentCount
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericFieldInstance::TypeArgumentCount

Returns the number of type parameter arguments for this instance.

## Syntax

### [C#](#tab/csharp)
```csharp
int TypeArgumentCount(
   ref uint pcArgs
);
```
### [C++](#tab/cpp)
```cpp
HRESULT TypeArgumentCount(
   ULONG32* pcArgs
);
```
---

## Parameters
`pcArgs`\
[in, out] Number of type parameter arguments for this instance.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 For example, if List\<int>, this method returns 1, and, if List\<int,float2> this method returns 2. This method returns 0 if there are no type arguments.

## See also
- [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)
