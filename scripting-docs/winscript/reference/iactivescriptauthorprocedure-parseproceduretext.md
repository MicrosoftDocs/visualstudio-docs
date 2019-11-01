---
title: "IActiveScriptAuthorProcedure::ParseProcedureText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthorProcedure.ParseProcedureText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthorProcedure::ParseProcedureText"
ms.assetid: cb6c29c5-c749-48d7-a6a8-ccbf0f9119ec
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthorProcedure::ParseProcedureText
Parses a code procedure, adds the code procedure's text to the script authoring engine, and creates an `IScriptEntry` object that corresponds to the code procedure.  
  
## Syntax  
  
```cpp
HRESULT ParseProcedureText(  
   LPCOLESTR   pszCode,  
   LPCOLESTR   pszFormalParams,  
   LPCOLESTR   pszProcedureName,  
   LPCOLESTR   pszItemName,  
   LPCOLESTR   pszDelimiter,  
   DWORD       dwCookie,  
   DWORD       dwFlags,  
   IDispatch   *pdispFor  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in] The script text to parse.  
  
 `pszFormalParams`  
 [in] The address of the formal parameter names for the procedure. The parameter names must be separated by the appropriate delimiters for the script authoring engine. The names should not be enclosed in the parentheses.  
  
 `pszProcedureName`  
 [in] The address of the procedure name to be parsed.  
  
 `pszItemName`  
 [in] The buffer address that contains the item name associated with the `IScriptEntry` object.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script-block delimiter. When `pszCode` is parsed from a stream of text, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the script block. Set this parameter to NULL if there is no delimiter to mark the end of the script block.  
  
 `dwCookie`  
 [in] An application-defined value that is associated with the new `IScriptEntry` object.  
  
 `dwFlags`  
 [in] Not used.  
  
 `pdispFor`  
 [in] Not used.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The current [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] engine does not implement this method.  
  
## See also  
 [IActiveScriptAuthorProcedure Interface](../../winscript/reference/iactivescriptauthorprocedure-interface.md)