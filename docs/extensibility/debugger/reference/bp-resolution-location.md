---
description: "Specifies the structure of the breakpoint resolution location."
title: BP_RESOLUTION_LOCATION
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_RESOLUTION_LOCATION
helpviewer_keywords:
- BP_RESOLUTION_LOCATION structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_RESOLUTION_LOCATION

Specifies the structure of the breakpoint resolution location.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct BP_RESOLUTION_LOCATION {
    public uint   bpType;
    public IntPtr unionmember1;
    public IntPtr unionmember2;
    public IntPtr unionmember3;
    public uint   unionmember4;
};
```
### [C++](#tab/cpp)
```cpp
struct _BP_RESOLUTION_LOCATION {
    BP_TYPE bpType;
    union {
        BP_RESOLUTION_CODE bpresCode;
        BP_RESOLUTION_DATA bpresData;
        int                unused;
    } bpResLocation;
} BP_RESOLUTION_LOCATION;
```
---

## Members
`bpType`\
A value from the [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md) enumeration that specifies how to interpret the `bpResLocation` union or `unionmemberX` members.

`bpResLocation.bpresCode`\
[C++ only] Contains the [BP_RESOLUTION_CODE](../../../extensibility/debugger/reference/bp-resolution-code.md) structure if `bpType` = `BPT_CODE`.

`bpResLocation.bpresData`\
[C++ only] Contains the [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md) structure if `bpType` = `BPT_DATA`.

`bpResLocation.unused`\
[C++ only] A placeholder.

`unionmember1`\
[C# only] See Remarks on how to interpret.

`unionmember2`\
[C# only] See Remarks on how to interpret.

`unionmember3`\
[C# only] See Remarks on how to interpret.

`unionmember4`\
[C# only] See Remarks on how to interpret.

## Remarks
This structure is a member of the [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md) and [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structures.

 [C# only] The `unionmemberX` members are interpreted according to the following table. Look down the left column for the `bpType` value then across to determine what each `unionmemberX` member represents and marshal the `unionmemberX` accordingly. See the Example for a way to interpret this structure in C#.

|`bpLocationType`|`unionmember1`|`unionmember2`|`unionmember3`|`unionmember4`|
|----------------------|--------------------|--------------------|--------------------|--------------------|
|`BPT_CODE`|[IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)|-|-|-|
|`BPT_DATA`|`string` (data expression)|`string` (function name)|`string` (image name)|`enum_BP_RES_DATA_FLAGS`|

## Example
This example shows how to interpret the `BP_RESOLUTION_LOCATION` structure in C#.

```csharp
using System;
using System.Runtime.Interop.Services;
using Microsoft.VisualStudio.Debugger.Interop;

namespace MyPackage
{
    public class MyClass
    {
        public void Interpret(BP_RESOLUTION_LOCATION bprl)
        {
            if (bprl.bpType == (uint)enum_BP_TYPE.BPT_CODE)
            {
                IDebugCodeContext2 pContext = (IDebugCodeContext2)Marshal.GetObjectForIUnknown(bp.unionmember1);
            }
            else if (bprl.bpType == (uint)enum_BP_TYPE.BPT_DATA)
            {
                string dataExpression = Marshal.PtrToStringBSTR(bp.unionmember3);
                string functionName = Marshal.PtrToStringBSTR(bp.unionmember2);
                string imageName = Marshal.PtrToStringBSTR(bp.unionmember3);
                enum_BP_RES_DATA_FLAGS numElements = (enum_BP_RES_DATA_FLAGS)bp.unionmember4;
            }
        }
    }
}
```

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md)
- [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md)
- [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)
- [BP_RESOLUTION_CODE](../../../extensibility/debugger/reference/bp-resolution-code.md)
- [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md)
- [BP_RES_DATA_FLAGS](../../../extensibility/debugger/reference/bp-res-data-flags.md)
