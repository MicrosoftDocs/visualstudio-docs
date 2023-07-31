---
description: "Gets the program node associated with a program."
title: IDebugProgramEx2::GetProgramNode | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramEx2::Attach
helpviewer_keywords:
- IDebugProgramEx2::Attach
ms.assetid: 1545ffbf-1422-4b5d-9bb9-314ba8665041
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgramEx2::GetProgramNode

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the program node associated with a program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProgramNode( 
   out IDebugProgramNode2 ppProgramNode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProgramNode( 
   IDebugProgramNode2** ppProgramNode
);
```
---

## Parameters
`ppProgramNode`\
[out] Returns an [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object that represents the program node associated with this program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramEx2](../../../extensibility/debugger/reference/idebugprogramex2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
