---
description: "Gets the object pointed to."
title: IDebugPointerObject::Dereference | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPointerObject::Dereference
helpviewer_keywords:
- IDebugPointerObject::Dereference method
ms.assetid: 196ec2cc-8569-4780-b217-23b24e7f50ca
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
# IDebugPointerObject::Dereference
Gets the object pointed to.

## Syntax

```cpp
HRESULT DeReference( 
   DWORD          dwIndex,
   IDebugObject** ppObject
);
```

```csharp
int Dereference(
   uint             dwIndex,
   out IDebugObject ppObject
);
```

## Parameters
`dwIndex`\
[in] A simple byte offset from the beginning of the object pointed to.

`ppObject`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the object pointed to, plus offset, if any.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this object does not point to another object.

## Remarks
 The object pointed to can be a primitive or a more complex type such as a class or structure.

## See also
- [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md)
