---
title: "IActiveScriptParseProcedure::ParseProcedureText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptParseProcedure.ParseProcedureText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptParseProcedure_ParseProcedureText"
ms.assetid: 345a74ae-b4e8-42b2-abd8-633a370e8e7f
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParseProcedure::ParseProcedureText
Parses the given code procedure and adds the procedure to the name space.  
  
## Syntax  
  
```cpp
HRESULT ParseProcedureText(  
    LPCOLESTR pstrCode,              // address of procedure text  
    LPCOLESTR pstrFormalParams,      // address of formal parameter names  
    LPCOLESTR pstrProcedureName,     // address of procedure name  
    LPCOLESTR pstrItemName,          // address of item name  
    IUnknown *punkContext,           // address of debugging context  
    LPCOLESTR pstrDelimiter,         // address of end-of-procedure delimiter  
    DWORD_PTR dwSourceContextCookie, // application-defined value for debugging  
    ULONG ulStartingLineNumber,      // starting line of the script  
    DWORD dwFlags,                   // procedure flags  
    IDispatch **ppdisp               // receives IDispatch pointer  
);  
```  
  
#### Parameters  
 `pstrCode`  
 [in] Address of the procedure text to evaluate. The interpretation of this string depends on the scripting language.  
  
 `pstrFormalParams`  
 [in] Address of formal parameter names for the procedure. The parameter names must be separated with the appropriate delimiters for the scripting engine. The names should not be enclosed in parentheses.  
  
 `pstrProcedureName`  
 [in] Address of procedure name to be parsed.  
  
 `pstrItemName`  
 [in] Address of the item name that gives the context in which the procedure is to be evaluated. If this parameter is `NULL`, the code is evaluated in the scripting engine's global context.  
  
 `punkContext`  
 [in] Address of the context object. This object is reserved for use in a debugging environment, where such a context may be provided by the debugger to represent an active run-time context. If this parameter is `NULL`, the engine uses `pstrItemName` to identify the context.  
  
 `pstrDelimiter`  
 [in] Address of the end-of-procedure delimiter. When `pstrCode` is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the procedure. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine makes use of this information depends on the scripting engine. Set this parameter to `NULL` if the host did not use a delimiter to mark the end of the procedure.  
  
 `dwSourceContextCookie`  
 [in] Application-defined value that is used for debugging purposes.  
  
 `ulStartingLineNumber`  
 [in] Zero-based value that specifies which line the parsing will begin at.  
  
 `dwFlags`  
 [in] Flags associated with the procedure. Can be a combination of these values:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTPROC_ISEXPRESSION|Indicates that the code in `pstrCode` is an expression that represents the return value of the procedure. By default, the code can contain an expression, a list of statements, or anything else allowed in a procedure by the script language.|  
|SCRIPTPROC_IMPLICIT_THIS|Indicates that the `this` pointer is included in the scope of the procedure.|  
|SCRIPTPROC_IMPLICIT_PARENTS|Indicates that the parents of the `this` pointer are included in the scope of the procedure.|  
  
 `ppdisp`  
 [out] Address of the pointer for the object containing the script's global methods and properties. If the scripting engine does not support such an object, `NULL` is returned.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_NOTIMPL`|This method is not supported. The scripting engine does not support run-time addition of procedures to the name space.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine is in the uninitialized or closed state).|  
|`OLESCRIPT_E_SYNTAX`|An unspecified syntax error occurred in the procedure.|  
|`S_FALSE`|The scripting engine does not support a dispatch object; the `ppdisp` parameter is set to `NULL`.|  
  
## Remarks  
 No script code is evaluated during this call; rather, the procedure is compiled into the script state where it can be called by the script later.  
  
## See also  
 [IActiveScriptParseProcedure](../../winscript/reference/iactivescriptparseprocedure.md)