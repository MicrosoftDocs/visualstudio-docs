---
description: "Creates a unique ID for this property to ensure that it is unique among all other properties."
title: IDebugProperty3::CreateObjectID | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3::CreateObjectID
helpviewer_keywords:
- IDebugProperty3::CreateObjectID
ms.assetid: f2fa81e7-822f-456e-8729-a96a18eea771
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
# IDebugProperty3::CreateObjectID
Creates a unique ID for this property to ensure that it is unique among all other properties.

## Syntax

```cpp
HRESULT CreateObjectID(
   void
);
```

```csharp
int CreateObjectID();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is called when the session debug manager wants to make sure that this property is uniquely identified among all other properties. The debug engine (DE) supports this method unless the properties it deals with are already uniquely identified. If the DE does not support this method, it returns `E_NOTIMPL`.

 Any unique ID created with `CreateObjectID` is destroyed when the [DestroyObjectID](../../../extensibility/debugger/reference/idebugproperty3-destroyobjectid.md) method is called; this also signals the end of the need for uniquely identifying this property.

> [!NOTE]
> There is no method to retrieve this unique ID, so the DE can do whatever it wants for unique IDs when the `CreateObjectID` method is called.

## See also
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [DestroyObjectID](../../../extensibility/debugger/reference/idebugproperty3-destroyobjectid.md)
