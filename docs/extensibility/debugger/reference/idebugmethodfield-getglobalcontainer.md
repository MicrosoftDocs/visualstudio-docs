---
title: "IDebugMethodField::GetGlobalContainer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugMethodField::GetGlobalContainer"
helpviewer_keywords:
  - "IDebugMethodField::GetGlobalContainer method"
ms.assetid: 041ac5aa-0b80-4310-b9ae-b88f8e7e0e5f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugMethodField::GetGlobalContainer
Gets the global container of the method.

## Syntax

```cpp
HRESULT GetGlobalContainer(
   IDebugClassField** ppClass
);
```

```csharp
int GetGlobalContainer(
   out IDebugClassField ppClass
);
```

## Parameters
`ppClass`\
[out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) representing the module in which this method is defined.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The returned [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object represents the entire module and is an artificial object, that is, the module itself does not have an actual class but it can be represented by an `IDebugClassField` object, allowing the various elements of the module to be enumerated and discovered.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)