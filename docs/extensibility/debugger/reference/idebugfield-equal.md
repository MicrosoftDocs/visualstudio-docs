---
description: "This method compares this field with the specified field for equality."
title: IDebugField::Equal
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::Equal
helpviewer_keywords:
- IDebugField::Equal method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::Equal

This method compares this field with the specified field for equality.

## Syntax

### [C#](#tab/csharp)
```csharp
int Equal(
   IDebugField pField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Equal( 
   IDebugField* pField
);
```
---

## Parameters
`pField`\
[in] The field to compare to this one.

## Return Value
 If the fields are the same, returns `S_OK`. If the fields are different, returns `S_FALSE.` Otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
