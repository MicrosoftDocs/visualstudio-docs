---
description: "Gets the memory bytes that compose the value of a property."
title: IDebugProperty2::GetMemoryBytes | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetMemoryBytes
helpviewer_keywords:
- IDebugProperty2::GetMemoryBytes
ms.assetid: b32042ed-7a06-4b4a-99ef-fe03b0aa61cc
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
# IDebugProperty2::GetMemoryBytes

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the memory bytes that compose the value of a property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryBytes ( 
   out IDebugMemoryBytes2 ppMemoryBytes
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryBytes ( 
   IDebugMemoryBytes2** ppMemoryBytes
);
```
---

## Parameters
`ppMemoryBytes`\
[out] Returns an [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object that can be used to retrieve the memory that contains the value of the property.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETMEMORYBYTES_NO_MEMORY_BYTES` if there are no memory bytes to retrieve.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md)
