---
description: "Creates an enumerator that contains the same enumeration state as the current custom attributes enumerator."
title: IEnumDebugCustomAttributes::Clone
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumCustomAttributes::Clone
helpviewer_keywords:
- IEnumDebugCustomAttributes::Clone
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugCustomAttributes::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

### [C#](#tab/csharp)
```csharp
int Clone(
   out IEnumDebugCustomAttributes ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Clone ( 
   IEnumCustomAttributes** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns a copy of this enumeration as a separate object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.

## See also
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
