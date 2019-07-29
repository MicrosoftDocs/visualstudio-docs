---
title: "IDebugProperty3::DestroyObjectID | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProperty3::DestroyObjectID"
helpviewer_keywords:
  - "IDebugProperty3::DestroyObjectID"
ms.assetid: bd08f356-cc67-4717-98c9-c3d00cad2040
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProperty3::DestroyObjectID
Destroys the unique ID associated with this property, indicating that the caller no longer cares to identify this property uniquely from all other properties.

## Syntax

```cpp
HRESULT DestroyObjectID(
   void
);
```

```csharp
int DestroyObjectID();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If the debug engine doesn't need to support unique IDs for a property (because it already tracks them uniquely internally), then it can simply return `E_NOTIMPL` for this method.

 Unique IDs are created with a call to the [CreateObjectID](../../../extensibility/debugger/reference/idebugproperty3-createobjectid.md) method when the caller wants to make sure that this property is uniquely identified among all other properties.

## See also
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [CreateObjectID](../../../extensibility/debugger/reference/idebugproperty3-createobjectid.md)