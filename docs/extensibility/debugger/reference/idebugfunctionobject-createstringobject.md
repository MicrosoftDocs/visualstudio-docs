---
description: "Creates a string object."
title: IDebugFunctionObject::CreateStringObject | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionObject::CreateStringObject
helpviewer_keywords:
- IDebugFunctionObject::CreateStringObject method
ms.assetid: fd6070ab-07d4-4ea1-8d71-b16592d6f1a7
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
# IDebugFunctionObject::CreateStringObject
Creates a string object.

## Syntax

```cpp
HRESULT CreateStringObject( 
   LPCOLESTR      pcstrString,
   IDebugObject** ppObject
);
```

```csharp
int CreateStringObject(
   string      pcstrString,
   out IDebugObject ppOjbect
);
```

## Parameters
`pcstrString`\
[in] The string value for the string object.

`ppObject`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object that represents the newly created string object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Call this method to create an object that represents a string that is a parameter to the function which is represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.

## See also
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
