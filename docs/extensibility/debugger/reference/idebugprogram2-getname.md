---
description: "IDebugProgram2::GetName gets the name of the program."
title: IDebugProgram2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetName
helpviewer_keywords:
- IDebugProgram2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetName

Gets the name of the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName( 
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name returned by this method is always a friendly, user-displayable name that describes the program.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
