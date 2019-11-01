---
title: "IDebugStackFrame::GetLanguageString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrame.GetLanguageString"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrame::GetLanguageString"
ms.assetid: 561d6306-f214-422f-abc9-b502cbfbe208
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrame::GetLanguageString
Returns a short or long textual description of the language.  
  
## Syntax  
  
```cpp
HRESULT GetLanguageString(  
   BOOL   fLong,  
   BSTR*  pbstrLanguage  
);  
```  
  
#### Parameters  
 `fLong`  
 [in] Flag, where `TRUE` returns a long description and `FALSE` returns a short description.  
  
 `pbstrLanguage`  
 [out] The description of the language.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Typically, if `fLong` is `FALSE`, this method provides only the name of the language associated with the stack frame. When `fLong` is `TRUE`, this method may provide a full product description.  
  
## See also  
 [IDebugStackFrame Interface](../../winscript/reference/idebugstackframe-interface.md)