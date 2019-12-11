---
title: "IDebugProgram2::GetName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgram2::GetName"
helpviewer_keywords:
  - "IDebugProgram2::GetName"
ms.assetid: a54cbf13-b3e3-4c9f-8b8d-13573232dfb0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgram2::GetName
Gets the name of the program.

## Syntax

```cpp
HRESULT GetName( 
   BSTR* pbstrName
);
```

```csharp
int GetName( 
   out string pbstrName
);
```

## Parameters
`pbstrName`\
[out] Returns the name of the program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name returned by this method is always a friendly, user-displayable name that describes the program.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)