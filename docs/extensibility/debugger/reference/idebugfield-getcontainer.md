---
title: "IDebugField::GetContainer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugField::GetContainer"
helpviewer_keywords:
  - "IDebugField::GetContainer method"
ms.assetid: 6d6c8213-6181-4adf-9584-3e4cac163dd8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugField::GetContainer
This method gets the container of a field.

## Syntax

```cpp
HRESULT GetContainer( 
   IDebugContainerField** ppContainerField
);
```

```csharp
int GetContainer(
   out IDebugContainerField ppContainerField
);
```

## Parameters
`ppContainerField`\
[out] Returns the container as represented by the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If this field does not have a container, the returned `ppContainerField` will be a null value.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)