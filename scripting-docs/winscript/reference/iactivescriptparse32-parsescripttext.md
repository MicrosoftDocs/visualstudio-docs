---
title: "IActiveScriptParse32::ParseScriptText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f33e454c-69d8-4cab-9150-d1e7fd04786d
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptParse32::ParseScriptText
Parses the given code scriptlet, adding declarations into the namespace and evaluating code as appropriate.  
  
## Syntax  
  
```cpp
HRESULT ParseScriptText(  
    LPCOLESTR pstrCode,              // address of scriptlet text  
    LPCOLESTR pstrItemName,          // address of item name  
    IUnknown *punkContext,           // address of debugging context  
    LPCOLESTR pstrDelimiter,         // address of end-of-scriptlet delimiter  
    DWORD_PTR dwSourceContextCookie, // cookie for debugging  
    ULONG ulStartingLineNumber,      // starting line of the script  
    DWORD dwFlags,                   // scriptlet flags  
    VARIANT *pvarResult,             // address of buffer for results  
    EXCEPINFO *pexcepinfo            // address of buffer for error data  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|`pstrCode`|[in] Address of the scriptlet text to evaluate. The interpretation of this string depends on the scripting language.|  
|`pstrItemName`|[in] Address of the item name that gives the context in which the scriptlet is to be evaluated. If this parameter is NULL, the code is evaluated in the scripting engine's global context.|  
|`punkContext`|[in] Address of the context object. This object is reserved for use in a debugging environment, where such a context may be provided by the debugger to represent an active run-time context. If this parameter is NULL, the engine uses `pstrItemName` to identify the context.|  
|`pstrDelimiter`|[in] Address of the end-of-scriptlet delimiter. When `pstrCode` is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the scriptlet. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine makes use of this information depends on the scripting engine. Set this parameter to `NULL` if the host did not use a delimiter to mark the end of the scriptlet.|  
|`dwSourceContextCookie`|[in] Cookie used for debugging purposes.|  
|`ulStartingLineNumber`|[in] Zero-based value that specifies which line the parsing will begin at.|  
|`dwFlags`|[in] Flags associated with the scriptlet. Can be a combination of these values:|  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTTEXT_ISEXPRESSION|If the distinction between a computational expression and a statement is important but syntactically ambiguous in the script language, this flag specifies that the scriptlet is to be interpreted as an expression, rather than as a statement or list of statements. By default, statements are assumed unless the correct choice can be determined from the syntax of the scriptlet text.|  
|SCRIPTTEXT_ISPERSISTENT|Indicates that the code added during this call should be saved if the scripting engine is saved (for example, through a call to `IPersist*::Save`), or if the scripting engine is reset by way of a transition back to the initialized state.|  
|SCRIPTTEXT_ISVISIBLE|Indicates that the script text should be visible (and, therefore, callable by name) as a global method in the name space of the script.|  
  
|||  
|-|-|  
|`pvarResult`|[out] Address of a buffer that receives the results of scriptlet processing, or `NULL` if the caller expects no result (that is, the SCRIPTTEXT_ISEXPRESSION value is not set).|  
|`pexcepinfo`|[out] Address of a structure that receives exception information. This structure is filled if `IActiveScriptParse::ParseScriptText` returns DISP_E_EXCEPTION.|  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`DISP_E_EXCEPTION`|An exception occurred in the processing of the scriptlet. The `pexcepinfo` parameter contains information about the exception.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_NOTIMPL`|This method is not supported. The scripting engine does not support run-time evaluation of expressions or statements.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine is in the uninitialized or closed state, or the SCRIPTTEXT_ISEXPRESSION flag was set and the scripting engine is in the initialized state).|  
|`OLESCRIPT_E_SYNTAX`|An unspecified syntax error occurred in the scriptlet.|  
  
## Remarks  
 If the scripting engine is in the initialized state, no code will actually be evaluated during this call; rather, such code is queued and executed when the scripting engine is transitioned into (or through) the started state. Because execution is not allowed in the initialized state, it is an error to call this method with the SCRIPTTEXT_ISEXPRESSION flag when in the initialized state.  
  
 The scriptlet can be an expression, a list of statements, or anything allowed by the script language. For example, this method is used in the evaluation of the HTML \<SCRIPT> tag, which allows statements to be executed as the HTML page is being constructed, rather than just compiling them into the script state.  
  
 The code passed to this method must be a valid, complete portion of code. For example, in VBScript it is illegal to call this method once with Sub Function(x) and then a second time with `End Sub`. The parser must not wait for the second call to complete the subroutine, but rather must generate a parse error because a subroutine declaration was started but not completed.  
  
 For more information about script states, see the Script Engine States section of [Windows Script Engines](../../winscript/windows-script-engines.md).  
  
## See also  
 [IActiveScriptParse32](../../winscript/reference/iactivescriptparse32.md)