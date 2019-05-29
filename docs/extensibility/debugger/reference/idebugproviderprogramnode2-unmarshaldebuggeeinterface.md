---
title: "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface"
helpviewer_keywords:
  - "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface"
ms.assetid: 2e4653c5-10f1-493c-9973-f31d266c5d48
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProviderProgramNode2::UnmarshalDebuggeeInterface
Obtains a specified interface across process boundaries.

## Syntax

```cpp
HRESULT UnmarshalDebuggeeInterface(
   REFIID riid,
   void** ppvObject
);
```

```csharp
int UnmarshalDebuggeeInterface(
   ref Guid   riid,
   out IntPtr ppvObject
);
```

## Parameters
`riid`\
[in] GUID of the interface to obtain.

`ppvObject`\
[out] Returns the object implementing the desired interface. [C++] this can be cast directly to the desired interface type. [C#] use the <xref:System.Runtime.InteropServices.Marshal.GetObjectForIUnknown%2A> method to get the desired interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is used when the debug engine is running in the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] process space and the program being debugged is running in its own process space.

## See also
- [IDebugProviderProgramNode2](../../../extensibility/debugger/reference/idebugproviderprogramnode2.md)