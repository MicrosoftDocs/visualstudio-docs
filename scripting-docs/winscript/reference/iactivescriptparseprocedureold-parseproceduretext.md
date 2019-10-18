---
title: "IActiveScriptParseProcedureOld::ParseProcedureText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptParseProcedureOld.ParseProcedureText"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IActiveScriptParseProcedureOld::ParseProcedureText"
ms.assetid: 21a21313-35ce-432d-b9a6-7999065f19ac
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParseProcedureOld::ParseProcedureText
Parses the given code procedure and adds an anonymous procedure to the name space.  
  
## Syntax  
  
```cpp
HRESULT ParseProcedureText(  
   LPCOLESTR    pstrCode,  
   LPCOLESTR    pstrFormalParams,  
   LPCOLESTR    pstrItemName,  
   IUnknown*    punkContext,  
   LPCOLESTR    pstrDelimiter,  
   DWORD_PTR    dwSourceContextCookie,  
   ULONG        ulStartingLineNumber,  
   DWORD        dwFlags,  
   IDispatch**  ppdisp  
);  
```  
  
#### Parameters  
 `pstrCode`  
 [in] The procedure text to evaluate. The interpretation of this string depends on the scripting language.  
  
 `pstrFormalParams`  
 [in] Formal parameter names for the procedure. The parameter names must be separated with the appropriate delimiters for the scripting engine. The names should not be enclosed in parentheses.  
  
 `pstrItemName`  
 [in] The name of the named item that gives the context in which the procedure is to be evaluated. If this parameter is `NULL`, the code is evaluated in the scripting engine's global context.  
  
 `punkContext`  
 [in] The context object. This object is reserved for use in a debugging environment, where such a context may be provided by the debugger to represent an active run-time context. If this parameter is `NULL`, the engine uses `pstrItemName` to identify the context.  
  
 `pstrDelimiter`  
 [in] The end-of-procedure delimiter. When `pstrCode` is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the procedure. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional, primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine uses this information depends on the scripting engine. Set this parameter to `NULL` if the host did not use a delimiter to mark the end of the procedure.  
  
 `dwSourceContextCookie`  
 [in] Application-defined value that is used for debugging purposes.  
  
 `ulStartingLineNumber`  
 [in] Zero-based value that specifies at which line the parsing will begin.  
  
 `dwFlags`  
 [in] Flags associated with the procedure. Can be a combination of these values.  
  
|Constant|Value|Meaning|  
|--------------|-----------|-------------|  
|SCRIPTPROC_ISEXPRESSION|0x00000020|Indicates that the code in `pstrCode` is an expression that represents the return value of the procedure.|  
|SCRIPTPROC_IMPLICIT_THIS|0x00000100|Indicates that the `this` pointer is included in the scope of the procedure.|  
|SCRIPTPROC_IMPLICIT_PARENTS|0x00000200|Indicates that the parents of the `this` pointer are included in the scope of the procedure.|  
  
 `ppdisp`  
 [out] Returns a dispatch wrapper where the default method is the procedure parsed by this method.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_NOTIMPL`|This method is not supported. The scripting engine does not support run-time addition of procedures to the name space.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine is in the uninitialized or closed state).|  
|`OLESCRIPT_E_SYNTAX`|An unspecified syntax error occurred in the procedure.|  
|`S_FALSE`|The scripting engine does not support a dispatch object; the `ppdisp`parameter is set to `NULL`.|  
  
## Remarks  
 No script code is evaluated during this call; rather, the procedure is compiled into a method on `ppdisp` where it can be called by the script later.  
  
 This interface is deprecated in favor of the `IActiveScriptParseProcedure` interface. The `IActiveScriptParseProcedure::ParseProcedureText` method is similar to this method, but it allows the procedure name to be specified. In all circumstances, `IActiveScriptParseProcedure::ParseProcedureText` should be used.  
  
## See also  
 [IActiveScriptParseProcedureOld Interface](../../winscript/reference/iactivescriptparseprocedureold-interface.md)   
 [IActiveScriptParseProcedure::ParseProcedureText](../../winscript/reference/iactivescriptparseprocedure-parseproceduretext.md)