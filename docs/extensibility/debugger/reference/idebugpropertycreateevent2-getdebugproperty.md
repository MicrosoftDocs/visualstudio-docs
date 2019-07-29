---
title: "IDebugPropertyCreateEvent2::GetDebugProperty | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPropertyCreateEvent2::GetDebugProperty"
helpviewer_keywords:
  - "IDebugPropertyCreateEvent2::GetDebugProperty"
ms.assetid: d7e43183-444c-4417-af19-82e28229f83a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPropertyCreateEvent2::GetDebugProperty
Gets the new property.

## Syntax

```cpp
HRESULT GetDebugProperty ( 
   IDebugProperty2** ppProperty
);
```

```csharp
int GetDebugProperty ( 
   out IDebugProperty2 ppProperty
);
```

## Parameters
`ppProperty`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the new property.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPropertyCreateEvent2](../../../extensibility/debugger/reference/idebugpropertycreateevent2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)