---
description: "Retrieves a list of the modules that this program has loaded and is executing."
title: IDebugProgram2::EnumModules | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::EnumModules
helpviewer_keywords:
- IDebugProgram2::EnumModules
ms.assetid: 876ac9da-3b7c-4156-b79a-8f340e9fcea6
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
# IDebugProgram2::EnumModules
Retrieves a list of the modules that this program has loaded and is executing.

## Syntax

```cpp
HRESULT EnumModules( 
   IEnumDebugModules2** ppEnum
);
```

```csharp
int EnumModules( 
   out IEnumDebugModules2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md) object that contains a list of the modules.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A module is a DLL or assembly and is typically listed in the **Modules** debug window.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
