---
title: IntelliSenseHostFlags
description: The IntelliSenseHostFlags enumeration specifies IntelliSense host flags. This article describes the enum values.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IntellisenseHostFlags
helpviewer_keywords:
- IntelliSense, IntellisenseHostFlags enumeration
- IntellisenseHostFlags enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# IntelliSenseHostFlags

Specifies IntelliSense host flags.

## Syntax

```cpp
enum IntellisenseHostFlags
{
    IHF_READONLYCONTEXT      = 0x00000001
    IHF_NOSEPARATESUBJECT    = 0x00000002
    IHF_SINGLELINESUBJECT    = 0x00000004
    IHF_FORCECOMMITTOCONTEXT = 0x00000008
    IHF_OVERTYPE             = 0x00000010
};
```

### Parameters

|Members|Description|
|-------------|-----------------|
|`IHF_READONLYCONTEXT`|Context buffer is read-only.|
|`IHF_NOSEPARATESUBJECT`|No subject text. Context buffer contains IntelliSense-target (implies `!IHF_READONLYCONTEXT`).|
|`IHF_SINGLELINESUBJECT`|Subject text is not multi-line-capable.|
|`IHF_FORCECOMMITTOCONTEXT`|Same as `CanCommitIntoReadOnlyBuffer`.|
|`IHF_OVERTYPE`|Editing (in subject or context) should be done in overtype mode.|

## Requirements
 SingleFileeditor.idl

## See also
- <xref:Microsoft.VisualStudio.TextManager.Interop>
