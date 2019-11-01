---
title: "IDebugReference2::GetSize | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugReference2::GetSize"
helpviewer_keywords:
  - "IDebugReference2::GetSize"
ms.assetid: a404ddd9-d940-4513-97cd-f52b8ab6a560
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugReference2::GetSize
Gets the size, in bytes, of the value of the reference. Reserved for future use.

## Syntax

```cpp
HRESULT GetSize ( 
   DWORD* pdwSize
);
```

```csharp
int GetSize ( 
   out uint pdwSize
);
```

## Parameters
`pdwSize`\
[out] Returns the size, in bytes, of the value of the reference.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)