---
description: "Retrieves a list of the code contexts for a given position in a source file."
title: IDebugProgram2::EnumCodeContexts
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::EnumCodeContexts
helpviewer_keywords:
- IDebugProgram2::EnumCodeContexts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::EnumCodeContexts

Retrieves a list of the code contexts for a given position in a source file.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumCodeContexts( 
   IDebugDocumentPosition2     pDocPos,
   out IEnumDebugCodeContexts2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumCodeContexts( 
   IDebugDocumentPosition2*  pDocPos,
   IEnumDebugCodeContexts2** ppEnum
);
```
---

## Parameters
`pDocPos`\
[in] An [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md) object representing an abstract position in a source file known to the IDE.

`ppEnum`
[out] Returns an [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md) object that contains a list of the code contexts.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method allows the session debug manager (SDM) or IDE to map a source file position into a code position. More than one code context is returned if the source generates multiple blocks of code (for example, C++ templates).

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
- [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)
