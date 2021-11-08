---
description: "This method compares this field with the specified field for equality."
title: IDebugField::Equal | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::Equal
helpviewer_keywords:
- IDebugField::Equal method
ms.assetid: 75369fe6-ddd3-497d-80d1-2488e6100e9f
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
# IDebugField::Equal
This method compares this field with the specified field for equality.

## Syntax

```cpp
HRESULT Equal( 
   IDebugField* pField
);
```

```csharp
int Equal(
   IDebugField pField
);
```

## Parameters
`pField`\
[in] The field to compare to this one.

## Return Value
 If the fields are the same, returns `S_OK`. If the fields are different, returns `S_FALSE.` Otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
