---
description: "Gets the title, friendly name, or file name of the hosting process of this program."
title: IDebugProgramHost2::GetHostName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramHost2::GetHostName
helpviewer_keywords:
- IDebugProgramHost2::GetHostName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramHost2::GetHostName

Gets the title, friendly name, or file name of the hosting process of this program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostName( 
   uint dwType,
   out string pbstrHostName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostName( 
   DWORD dwType,
   BSTR* pbstrHostName
);
```
---

## Parameters
`dwType`\
[in] A value from the [GETHOSTNAME_TYPE](../../../extensibility/debugger/reference/gethostname-type.md) enumeration.

`pbstrHostName`\
[out] Returns the requested name of the hosting process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 In a typical implementation of this method, the `dwType` parameter is ignored and a friendly name of the host machine is returned. Another possible implementation is to pass the `dwType` parameter to a call to the [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md) method to get the name.

## See also
- [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)
- [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md)
