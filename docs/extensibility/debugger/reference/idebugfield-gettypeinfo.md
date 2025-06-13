---
description: "This method gets type-independent information about the symbol or type."
title: IDebugField::GetTypeInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetTypeInfo
helpviewer_keywords:
- IDebugField::GetTypeInfo method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetTypeInfo

This method gets type-independent information about the symbol or type.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetTypeInfo(
   TYPE_INFO[] pTypeInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetTypeInfo( 
   TYPE_INFO* pTypeInfo
);
```
---

## Parameters
`pTypeInfo`\
[out] Returns type information in the supplied [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) structure.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Type-independent information would include, for example, the AppDomain, the module, and the class that contains the symbol.

## See also
- [GetType](../../../extensibility/debugger/reference/idebugfield-gettype.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)
