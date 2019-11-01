---
title: "IDebugOutputStringEvent2::GetString | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugOutputStringEvent2::GetString"
helpviewer_keywords:
  - "IDebugOutputStringEvent2::GetString"
ms.assetid: f059f8e0-ad44-49ac-ba90-73576ada5e06
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugOutputStringEvent2::GetString
Gets the displayable message.

## Syntax

```cpp
HRESULT GetString( 
   BSTR* pbstrString
);
```

```csharp
int GetString( 
   out string pbstrString
);
```

## Parameters
`pbstrString`\
[out] Returns the displayable message.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugOutputStringEvent2](../../../extensibility/debugger/reference/idebugoutputstringevent2.md)