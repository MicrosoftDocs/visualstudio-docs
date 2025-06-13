---
description: "Gets the language associated with this stack frame."
title: IDebugStackFrame2::GetLanguageInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetLanguageInfo
helpviewer_keywords:
- IDebugStackFrame2::GetLanguageInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetLanguageInfo

Gets the language associated with this stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLanguageInfo ( 
   ref string pbstrLanguage,
   ref Guid   pguidLanguage
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLanguageInfo ( 
   BSTR* pbstrLanguage,
   GUID* pguidLanguage
);
```
---

## Parameters

`pbstrLanguage`\
[out] Returns the name of the language that implements the method associated with this stack frame.

`pguidLanguage`\
[out] Returns the `GUID` of the language. For the Visual Studio languages, for example, the following can be returned:

- `guidVBScriptLang`\

- `guidJScriptLang`\

- `guidCPPLang`\

- `guidVBLang`\

- `guidSQLLang`\

- `guidScriptLang`\

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
