---
description: "Gets the language associated with this stack frame."
title: IDebugStackFrame2::GetLanguageInfo | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetLanguageInfo
helpviewer_keywords:
- IDebugStackFrame2::GetLanguageInfo
ms.assetid: 0e12fd92-f155-46a7-8272-cda279388cfb
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetLanguageInfo

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

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
[out] Returns the `GUID` of the language. For the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] languages, for example, the following can be returned:

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
