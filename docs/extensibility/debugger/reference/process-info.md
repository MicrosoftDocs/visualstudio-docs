---
description: "Contains information about a process."
title: PROCESS_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PROCESS_INFO
helpviewer_keywords:
- PROCESS_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PROCESS_INFO

Contains information about a process.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct PROCESS_INFO { 
   public uint          Fields;
   public string        bstrFileName;
   public string        bstrBaseName;
   public string        bstrTitle;
   public AD_PROCESS_ID ProcessId;
   public uint          dwSessionId;
   public string        bstrAttachedSessionName;
   public FILETIME      CreationTime;
   public uint          Flags;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct tagPROCESS_INFO { 
   PROCESS_INFO_FIELDS Fields;
   BSTR                bstrFileName;
   BSTR                bstrBaseName;
   BSTR                bstrTitle;
   AD_PROCESS_ID       ProcessId;
   DWORD               dwSessionId;
   BSTR                bstrAttachedSessionName;
   FILETIME            CreationTime;
   PROCESS_INFO_FLAGS  Flags;
} PROCESS_INFO;
```
---

## Members
 `Fields`\
 A combination of flags from the [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md) enumeration that specify which fields are filled out.

 `bstrFileName`\
 The full path name of the process. Equivalent to calling the [GetName](../../../extensibility/debugger/reference/idebugprocess2-getname.md) method with the parameter `GN_FILENAME`.

 `bstrBaseName`\
 The file name and extension of the process. Equivalent to calling the `IDebugProcess2::Getname` method with the parameter `GN_BASENAME`.

 `bstrTitle`\
 The title of the process, if one exists. Equivalent to calling the `IDebugProcess2::Getname` method with the parameter `GN_TITLE`.

 `ProcessId`\
 The [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that identifies the process. Equivalent to calling the [GetPhysicalProcessId](../../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md) method.

 `dwSessionId`\
 The identifier of the debug session that this process is running in.

 `bstrAttachedSessionName`\
 The attached session name. Equivalent to calling the [GetAttachedSessionName](../../../extensibility/debugger/reference/idebugprocess2-getattachedsessionname.md) method.

 `CreationTime`\
 The time the process was created.

 `Flags`\
 A combination of flags from the [PROCESS_INFO_FLAGS](../../../extensibility/debugger/reference/process-info-flags.md) enumeration that specify properties of the process.

## Remarks
 This structure is passed to the [GetInfo](../../../extensibility/debugger/reference/idebugprocess2-getinfo.md) method where it is filled in.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md)
- [PROCESS_INFO_FLAGS](../../../extensibility/debugger/reference/process-info-flags.md)
- [GetInfo](../../../extensibility/debugger/reference/idebugprocess2-getinfo.md)
- [GetName](../../../extensibility/debugger/reference/idebugprocess2-getname.md)
- [GetPhysicalProcessId](../../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md)
- [GetAttachedSessionName](../../../extensibility/debugger/reference/idebugprocess2-getattachedsessionname.md)
