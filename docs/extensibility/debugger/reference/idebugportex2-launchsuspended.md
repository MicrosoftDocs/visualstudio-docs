---
description: "Launches an executable file."
title: IDebugPortEx2::LaunchSuspended
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::LaunchSuspended
helpviewer_keywords:
- IDebugPortEx2::LaunchSuspended
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEx2::LaunchSuspended

Launches an executable file.

## Syntax

### [C#](#tab/csharp)
```csharp
int LaunchSuspended( 
   string             pszExe,
   string             pszArgs,
   string             pszDir,
   string             bstrEnv,
   uint               hStdInput,
   uint               hStdOutput,
   uint               hStdError,
   out IDebugProcess2 ppPortProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT LaunchSuspended( 
   LPCOLESTR        pszExe,
   LPCOLESTR        pszArgs,
   LPCOLESTR        pszDir,
   BSTR             bstrEnv,
   DWORD            hStdInput,
   DWORD            hStdOutput,
   DWORD            hStdError,
   IDebugProcess2** ppPortProcess
);
```
---

## Parameters
`pszExe`\
[in] The name of the executable to be launched. This can be a full path or relative to the working directory specified in the `pszDir` parameter.

`pszArgs`\
[in] The arguments to pass to the executable. May be a null value if there are no arguments.

`pszDir`\
[in] The name of the working directory used by the executable. May be a null value if no working directory is required.

`bstrEnv`\
[in] Environment block of null-terminated strings, followed by an additional NULL terminator.

`hStdInput`\
[in] Handle to an alternate input stream. May be 0 if redirection is not required.

`hStdOutput`\
[in] Handle to an alternate output stream. May be 0 if redirection is not required.

`hStdError`\
[in] Handle to an alternate error output stream. May be 0 if redirection is not required.

`ppPortProcess`\
[out] Returns an [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) object that represents the launched process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method should launch the process so that it is suspended and not running any code. The [ResumeProcess](../../../extensibility/debugger/reference/idebugportex2-resumeprocess.md) method is called to resume the process.

 A program can also be launched from a debug engine. For details, see [Launching a Program](../../../extensibility/debugger/launching-a-program.md).

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [ResumeProcess](../../../extensibility/debugger/reference/idebugportex2-resumeprocess.md)
- [Launching a Program](../../../extensibility/debugger/launching-a-program.md)
