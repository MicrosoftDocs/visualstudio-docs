---
title: "IDebugStackFrame2::GetLanguageInfo | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugStackFrame2::GetLanguageInfo"
helpviewer_keywords:
  - "IDebugStackFrame2::GetLanguageInfo"
ms.assetid: 0e12fd92-f155-46a7-8272-cda279388cfb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugStackFrame2::GetLanguageInfo

Gets the language associated with this stack frame.

## Syntax

```cpp
HRESULT GetLanguageInfo ( 
   BSTR* pbstrLanguage,
   GUID* pguidLanguage
);
```

```csharp
int GetLanguageInfo ( 
   ref string pbstrLanguage,
   ref Guid   pguidLanguage
);
```

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
