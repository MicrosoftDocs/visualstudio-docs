---
description: "Gets a description of the stack frame."
title: IDebugStackFrame2::GetInfo | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetInfo
helpviewer_keywords:
- IDebugStackFrame2::GetInfo
ms.assetid: 19c6870b-b94e-453c-bf19-82ce95b79d26
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
# IDebugStackFrame2::GetInfo

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets a description of the stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInfo ( 
   enum_FRAMEINFO_FLAGS dwFieldSpec,
   uint                 nRadix,
   FRAMEINFO[]          pFrameInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInfo ( 
   FRAMEINFO_FLAGS dwFieldSpec,
   UINT            nRadix,
   FRAMEINFO*      pFrameInfo
);
```
---

## Parameters
`dwFieldSpec`\
[in] A combination of flags from the [FRAMEINFO_FLAGS](../../../extensibility/debugger/reference/frameinfo-flags.md) enumeration that specifies which fields of the `pFrameInfo` parameter are to be filled in.

`nRadix`\
[in] The radix to be used in formatting any numerical information.

`pFrameInfo`\
[out] A [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structure that is filled in with the description of the stack frame.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [FRAMEINFO_FLAGS](../../../extensibility/debugger/reference/frameinfo-flags.md)
- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)
