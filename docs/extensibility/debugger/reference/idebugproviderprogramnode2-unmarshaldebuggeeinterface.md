---
description: "Obtains a specified interface across process boundaries."
title: IDebugProviderProgramNode2::UnmarshalDebuggeeInterface
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProviderProgramNode2::UnmarshalDebuggeeInterface
helpviewer_keywords:
- IDebugProviderProgramNode2::UnmarshalDebuggeeInterface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProviderProgramNode2::UnmarshalDebuggeeInterface

Obtains a specified interface across process boundaries.

## Syntax

### [C#](#tab/csharp)
```csharp
int UnmarshalDebuggeeInterface(
   ref Guid   riid,
   out IntPtr ppvObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT UnmarshalDebuggeeInterface(
   REFIID riid,
   void** ppvObject
);
```
---

## Parameters
`riid`\
[in] GUID of the interface to obtain.

`ppvObject`\
[out] Returns the object implementing the desired interface. [C++] this can be cast directly to the desired interface type. [C#] use the <xref:System.Runtime.InteropServices.Marshal.GetObjectForIUnknown%2A> method to get the desired interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is used when the debug engine is running in the Visual Studio process space and the program being debugged is running in its own process space.

## See also
- [IDebugProviderProgramNode2](../../../extensibility/debugger/reference/idebugproviderprogramnode2.md)
