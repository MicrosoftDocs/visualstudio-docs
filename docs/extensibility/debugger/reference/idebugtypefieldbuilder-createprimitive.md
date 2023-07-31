---
description: "Creates an object that represents a primitive type."
title: IDebugTypeFieldBuilder::CreatePrimitive | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CreatePrimitive
- IDebugTypeFieldBuilder::CreatePrimitive
ms.assetid: 512c6ff0-97c5-409f-939f-4cc969bc4bb9
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugTypeFieldBuilder::CreatePrimitive

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Creates an object that represents a primitive type.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreatePrimitive (
   uint            dwElementType,
   out IDebugField pTypeField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreatePrimitive (
   DWORD          dwElementType,
   IDebugField ** pTypeField
);
```
---

## Parameters
`dwElementType`\
[in] Value from the [CorElementType Enumeration](/dotnet/framework/unmanaged-api/metadata/corelementtype-enumeration) that represents the primitive type.

`pTypeField`\
[out] Returns the IDebugField interface for the new type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugTypeFieldBuilder](../../../extensibility/debugger/reference/idebugtypefieldbuilder.md)
