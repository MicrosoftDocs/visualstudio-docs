---
title: "IDebugStackFrame2::GetLanguageInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugStackFrame2::GetLanguageInfo"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetLanguageInfo"
ms.assetid: 0e12fd92-f155-46a7-8272-cda279388cfb
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugStackFrame2::GetLanguageInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the language associated with this stack frame.  
  
## Syntax  
  
```cpp#  
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
  
#### Parameters  
 `pbstrLanguage`  
 [out] Returns the name of the language that implements the method associated with this stack frame.  
  
 `pguidLanguage`  
 [out] Returns the `GUID` of the language. For the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] languages, for example, the following can be returned:  
  
- `guidVBScriptLang`  
  
- `guidJScriptLang`  
  
- `guidCPPLang`  
  
- `guidVBLang`  
  
- `guidSQLLang`  
  
- `guidScriptLang`  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
