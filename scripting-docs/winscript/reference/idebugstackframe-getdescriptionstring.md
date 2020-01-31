---
title: "IDebugStackFrame::GetDescriptionString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrame.GetDescriptionString"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrame::GetDescriptionString"
ms.assetid: a2ddc069-c440-4dee-98dc-ab7c78773b94
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrame::GetDescriptionString
Returns a short or long textual description of the stack frame.  
  
## Syntax  
  
```cpp
HRESULT GetDescriptionString(  
   BOOL   fLong,  
   BSTR*  pbstrDescription  
);  
```  
  
#### Parameters  
 `fLong`  
 [in] Flag, where `TRUE` returns a long description and `FALSE` returns a short description.  
  
 `pbstrDescription`  
 [out] The description of the stack frame.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Typically, if `fLong` is `FALSE`, this method provides only the name of the function associated with the stack frame. When `fLong` is `TRUE`, this method may also provide the function parameters and other relevant information.  
  
## See also  
 [IDebugStackFrame Interface](../../winscript/reference/idebugstackframe-interface.md)