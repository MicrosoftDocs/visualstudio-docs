---
description: "Gets information about this module."
title: IDebugModule2::GetInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule2::GetInfo
helpviewer_keywords:
- GetInfo method
- IDebugModule2::GetInfo method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
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
