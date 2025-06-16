---
description: "Gets the language information for this code context."
title: IDebugCodeContext2::GetLanguageInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCodeContext2::GetLanguageInfo
helpviewer_keywords:
- IDebugCodeContext2::GetLanguageInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCodeContext2::GetLanguageInfo

Gets the language information for this code context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLanguageInfo( 
   ref string pbstrLanguage,
   ref Guid pguidLanguage
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLanguageInfo( 
   BSTR* pbstrLanguage,
   GUID* pguidLanguage
);
```
---

## Parameters
`pbstrLanguage`\
[in, out] Returns a string that contains the name of the language, such as "C++."

`pguidLanguage`\
[in, out] Returns the GUID for the language of the code context, for example, `guidCPPLang`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 At least one of the parameters must return a non-null value.

## See also
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
