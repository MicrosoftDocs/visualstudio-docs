---
description: "IDebugProgramNode2::GetProgramName gets the name of the program."
title: IDebugProgramNode2::GetProgramName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::GetProgramName
helpviewer_keywords:
- IDebugProgramNode2::GetProgramName
ms.assetid: 510c7f5d-48ff-4d9f-ad79-fbad9f15239d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::GetProgramName
Gets the name of the program.

## Syntax

```cpp
HRESULT GetProgramName (
    BSTR* pbstrProgramName
);
```

```csharp
int GetProgramName (
    out string pbstrProgramName
);
```

## Parameters
`pbstrProgramName`\
[out] Returns the name of the program.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
The name of a program is not the same thing as the path to the program, although the name of the program may be part of such a path.

## Example
The following example shows how to implement this method for a simple `CProgram` object that implements the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface. The `MakeBstr` function allocates a copy of the specified string as a BSTR.

```cpp
HRESULT CProgram::GetProgramName(BSTR* pbstrProgramName) {
    if (!pbstrProgramName)
        return E_INVALIDARG;

    // Assign the member program name to the passed program name.
    *pbstrProgramName = MakeBstr(m_pszProgramName);
    return NOERROR;
}
```

## See also
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
