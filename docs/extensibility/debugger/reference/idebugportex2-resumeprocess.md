---
title: "IDebugPortEx2::ResumeProcess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPortEx2::ResumeProcess"
helpviewer_keywords:
  - "IDebugPortEx2::ResumeProcess"
ms.assetid: e80a6960-9456-4764-9320-e7b1bd57fe5d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPortEx2::ResumeProcess
Resumes execution of a process.

## Syntax

```cpp
HRESULT ResumeProcess( 
   IDebugProcess2* pPortProcess
);
```

```cpp
int ResumeProcess( 
   IDebugProcess2 pPortProcess
);
```

## Parameters
`pPortProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process to be resumed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)