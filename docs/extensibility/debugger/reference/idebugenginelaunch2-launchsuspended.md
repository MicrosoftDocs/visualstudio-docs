---
description: "This method launches a process by means of the debug engine (DE)."
title: IDebugEngineLaunch2::LaunchSuspended
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineLaunch2::LaunchSuspended
helpviewer_keywords:
- IDebugEngineLaunch2::LaunchSuspended
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineLaunch2::LaunchSuspended

This method launches a process by means of the debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int LaunchSuspended(
   string               pszServer,
   IDebugPort2          pPort,
   string               pszExe,
   string               pszArgs,
   string               pszDir,
   string               bstrEnv,
   string               pszOptions,
   enum_LAUNCH_FLAGS    dwLaunchFlags,
   uint                 hStdInput,
   uint                 hStdOutput,
   uint                 hStdError,
   IDebugEventCallback2 pCallback,
   out IDebugProcess2   ppProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT LaunchSuspended ( 
   LPCOLESTR             pszMachine,
   IDebugPort2*          pPort,
   LPCOLESTR             pszExe,
   LPCOLESTR             pszArgs,
   LPCOLESTR             pszDir,
   BSTR                  bstrEnv,
   LPCOLESTR             pszOptions,
   LAUNCH_FLAGS          dwLaunchFlags,
   DWORD                 hStdInput,
   DWORD                 hStdOutput,
   DWORD                 hStdError,
   IDebugEventCallback2* pCallback,
   IDebugProcess2**      ppDebugProcess
);
```
---

## Parameters
`pszMachine`\
[in] The name of the machine in which to launch the process. Use a null value to specify the local machine.

`pPort`\
[in] The [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface representing the port that the program will run in.

`pszExe`\
[in] The name of the executable to be launched.

`pszArgs`\
[in] The arguments to pass to the executable. May be a null value if there are no arguments.

`pszDir`\
[in] The name of the working directory used by the executable. May be a null value if no working directory is required.

`bstrEnv`\
[in] Environment block of NULL-terminated strings, followed by an additional NULL terminator.

`pszOptions`\
[in] The options for the executable.

`dwLaunchFlags`\
[in] Specifies the [LAUNCH_FLAGS](../../../extensibility/debugger/reference/launch-flags.md) for a session.

`hStdInput`\
[in] Handle to an alternate input stream. May be 0 if redirection is not required.

`hStdOutput`\
[in] Handle to an alternate output stream. May be 0 if redirection is not required.

`hStdError`\
[in] Handle to an alternate error output stream. May be 0 if redirection is not required.

`pCallback`\
[in] The [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) object that receives debugger events.

`ppDebugProcess`\
[out] Returns the resulting [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the launched process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Normally, Visual Studio launches a program using the [LaunchSuspended](../../../extensibility/debugger/reference/idebugportex2-launchsuspended.md) method and then attaches the debugger to the suspended program. However, there are circumstances in which the debug engine may need to launch a program (for example, if the debug engine is part of an interpreter and the program being debugged is an interpreted language), in which case Visual Studio uses the `IDebugEngineLaunch2::LaunchSuspended` method.

 The [ResumeProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-resumeprocess.md) method is called to start the process after the process has been successfully launched in a suspended state.

## See also
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [LAUNCH_FLAGS](../../../extensibility/debugger/reference/launch-flags.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [LaunchSuspended](../../../extensibility/debugger/reference/idebugportex2-launchsuspended.md)
- [ResumeProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-resumeprocess.md)
