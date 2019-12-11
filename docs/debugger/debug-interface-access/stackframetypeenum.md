---
title: "StackFrameTypeEnum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "StackFrameTypeEnum enumeration"
ms.assetid: 61e40163-eee0-4c1f-af47-cef3771bdc41
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# StackFrameTypeEnum
Specifies the stack frame type.

## Syntax

```C++
enum StackFrameTypeEnum {
    FrameTypeFPO,
    FrameTypeTrap,
    FrameTypeTSS,
    FrameTypeStandard,
    FrameTypeFrameData,
    FrameTypeUnknown = -1
};
```

## Elements
`FrameTypeFPO`
Frame pointer omitted; FPO info available.

`FrameTypeTrap`
Kernel Trap frame.

`FrameTypeTSS`
Kernel Trap frame.

`FrameTypeStandard`
Standard EBP stack frame.

`FrameTypeFrameData`
Frame pointer omitted; Frame data info available.

`FrameTypeUnknown`
Frame that does not have any debug info.

## Remarks
The values in this enumeration are returned by a call to the [IDiaStackFrame::get_type](../../debugger/debug-interface-access/idiastackframe-get-type.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaStackFrame::get_type](../../debugger/debug-interface-access/idiastackframe-get-type.md)
