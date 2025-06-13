---
description: "Gets the file name of the source file that contains the document position."
title: IDebugDocumentPosition2::GetFileName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::GetFileName
helpviewer_keywords:
- IDebugDocumentPosition2::GetFileName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::GetFileName

Gets the file name of the source file that contains the document position.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetFileName( 
   out string pbstrFileName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFileName( 
   BSTR* pbstrFileName
);
```
---

## Parameters
`pbstrFileName`\
[out] Returns the file name of the source file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A source file may not always have a file name (the source file may not exist on disk, for example).

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
