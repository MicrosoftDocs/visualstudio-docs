---
title: "IDebugEvent2::GetAttributes | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEvent2::GetAttributes"
helpviewer_keywords:
  - "IDebugEvent2::GetAttributes"
ms.assetid: 2ac5b5fb-da17-43f7-811a-313f677e60d7
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEvent2::GetAttributes
Gets the attributes for this debug event.

## Syntax

```cpp
HRESULT GetAttribute( 
   DWORD* pdwAttrib
);
```

```csharp
int GetAttribute( 
   out uint pdwAttrib
);
```

## Parameters
`pdwAttrib`\
[out] A combination of flags from the [EVENTATTRIBUTES](../../../extensibility/debugger/reference/eventattributes.md) enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface is common to all events. This method describes the type of event; for example, is the event synchronous or asynchronous and is it a stopping event.

## See also
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [EVENTATTRIBUTES](../../../extensibility/debugger/reference/eventattributes.md)