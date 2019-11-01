---
title: "IDebugProgramEngines2::EnumPossibleEngines | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramEngines2::EnumPossibleEngines"
helpviewer_keywords:
  - "IDebugProgramEngines2::EnumPossibleEngines"
ms.assetid: 993d70a4-f6a5-4e47-a603-0b162b9fde00
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramEngines2::EnumPossibleEngines
Returns the GUIDs for all the possible debug engines (DE) that can debug this program.

## Syntax

```cpp
HRESULT EnumPossibleEngines( 
   DWORD  celtBuffer,
   GUID*  rgguidEngines,
   DWORD* pceltEngines
);
```

```csharp
int EnumPossibleEngines( 
   uint      celtBuffer,
   GUID[]    rgguidEngines,
   ref DWORD pceltEngines
);
```

## Parameters
`celtBuffer`\
[in] The number of DE GUIDs to return. This also specifies the maximum size of the `rgguidEngines` array.

`rgguidEngines`\
[in, out] An array of DE GUIDs to be filled in.

`pceltEngines`\
[out] Returns the actual number of DE GUIDs that are returned.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns [C++] `HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)` or [C#] 0x8007007A if the buffer is not large enough.

## Remarks
 In order to determine how many engines there are, call this method once with the `celtBuffer` parameter set to 0 and the `rgguidEngines` parameter set to a null value. This returns `HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)` (0x8007007A for C#), and the `pceltEngines` parameter returns the necessary size of the buffer.

## See also
- [IDebugProgramEngines2](../../../extensibility/debugger/reference/idebugprogramengines2.md)