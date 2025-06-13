---
description: "Sets the value pointed to from a series of consecutive bytes."
title: IDebugPointerObject::SetBytes
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPointerObject::SetBytes
helpviewer_keywords:
- IDebugPointerObject::SetBytes method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPointerObject::SetBytes

Sets the value pointed to from a series of consecutive bytes.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetBytes(
   uint     dwStart,
   uint     dwCount,
   byte[]   pBytes,
   out uint pdwBytes
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetBytes( 
   DWORD  dwStart,
   DWORD  dwCount,
   BYTE*  pBytes,
   DWORD* pdwBytes
);
```
---

## Parameters
`dwStart`\
[in] An offset, in bytes, from the start of the object pointed to.

`dwCount`\
[in] The number of bytes to set.

`pBytes`\
[in] An array of bytes representing the new value. This value is stored into the object, starting at the given offset.

`pdwBytes`\
[out] Returns the number of bytes actually set.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method is used if the pointer as represented by this [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md) points to a primitive type or a simple array of primitive types (that is, an array that can be represented by a simple sequence of bytes). This `IDebugPointerObject` object cannot be a null reference (it must point to an address in memory).

## See also
- [GetBytes](../../../extensibility/debugger/reference/idebugpointerobject-getbytes.md)
- [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md)
