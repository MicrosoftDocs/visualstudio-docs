---
description: "Gets information about this module."
title: IDebugModule2::GetInfo | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule2::GetInfo
helpviewer_keywords:
- GetInfo method
- IDebugModule2::GetInfo method
ms.assetid: de337e66-294f-4ac9-b21e-71fac7418e36
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
# IDebugModule2::GetInfo
Gets information about this module.

## Syntax

```cpp
HRESULT GetInfo( 
   MODULE_INFO_FIELDS dwFields,
   MODULE_INFO*       pInfo
);
```

```cpp
int GetInfo( 
   enum_MODULE_INFO_FIELDS dwFields,
   MODULE_INFO[]           pInfo
);
```

## Parameters
`dwFields`\
[in] A combination of flags from the [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md) enumeration that specify which fields of `pInfo` are to be filled out.

`pInfo`\
[in, out] A [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) structure that is filled in with a description of the module.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) structure contains the name of the module that is displayed in the **Modules** window.

## See also
- [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
- [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md)
- [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md)
