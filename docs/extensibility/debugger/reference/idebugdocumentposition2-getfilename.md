---
description: "Gets the file name of the source file that contains the document position."
title: IDebugDocumentPosition2::GetFileName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::GetFileName
helpviewer_keywords:
- IDebugDocumentPosition2::GetFileName
ms.assetid: d713635e-088f-465b-b26d-00ac971c9e86
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::GetFileName
Gets the file name of the source file that contains the document position.

## Syntax

```cpp
HRESULT GetFileName( 
   BSTR* pbstrFileName
);
```

```csharp
int GetFileName( 
   out string pbstrFileName
);
```

## Parameters
`pbstrFileName`\
[out] Returns the file name of the source file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A source file may not always have a file name (the source file may not exist on disk, for example).

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
