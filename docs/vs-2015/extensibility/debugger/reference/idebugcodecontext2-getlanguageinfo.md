---
title: "IDebugCodeContext2::GetLanguageInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCodeContext2::GetLanguageInfo"
helpviewer_keywords: 
  - "IDebugCodeContext2::GetLanguageInfo"
ms.assetid: 03002ef1-9fe6-44b6-b23b-ef7b86b2b21b
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugCodeContext2::GetLanguageInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the language information for this code context.  
  
## Syntax  
  
```cpp#  
HRESULT GetLanguageInfo(   
   BSTR* pbstrLanguage,  
   GUID* pguidLanguage  
);  
```  
  
```csharp  
int GetLanguageInfo(   
   ref string pbstrLanguage,  
   ref Guid pguidLanguage  
);  
```  
  
#### Parameters  
 `pbstrLanguage`  
 [in, out] Returns a string that contains the name of the language, such as "C++."  
  
 `pguidLanguage`  
 [in, out] Returns the GUID for the language of the code context, for example, `guidCPPLang`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 At least one of the parameters must return a non-null value.  
  
## See Also  
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
