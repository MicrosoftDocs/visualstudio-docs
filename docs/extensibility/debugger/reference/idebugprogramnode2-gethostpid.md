---
description: "Gets the system process identifier for the process hosting the program."
title: IDebugProgramNode2::GetHostPid
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::GetHostPid
helpviewer_keywords:
- IDebugProgramNode2::GetHostPid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::GetHostPid

Gets the system process identifier for the process hosting the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostPid ( 
   out AD_PROCESS_ID pdwHostPid
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostPid ( 
   AD_PROCESS_ID * pdwHostPid
);
```
---

## Parameters
`pdwHostPid`\
[out] Returns the system process identifier for the hosting process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example
 The following example shows how to implement this method for a simple `CProgram` object that implements the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface.

```cpp
HRESULT CProgram::GetHostPid(AD_PROCESS_ID* pdwHostPid) {
   // Check for valid argument.
   if (pdwHostPid == NULL)
     return E_INVALIDARG;

   // Get the process identifier of the calling process.
   pdwHostPid->ProcessIdType = AD_PROCESS_ID_SYSTEM;
   pdwHostPid->ProcessId.dwProcessId = GetCurrentProcessId();
   return S_OK;
}
```

## See also
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
