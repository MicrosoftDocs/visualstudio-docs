---
title: "IDebugExpressionContext::ParseLanguageText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpressionContext.ParseLanguageText"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpressionContext::ParseLanguageText"
ms.assetid: 650cb016-7d80-4011-b264-780f871a3466
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpressionContext::ParseLanguageText
Creates a debug expression for the specified text.  
  
## Syntax  
  
```cpp
HRESULT ParseLanguageText(  
   LPCOLESTR           pstrCode,  
   UINT                nRadix,  
   LPCOLESTR           pstrDelimiter,  
   DWORD               dwFlags,  
   IDebugExpression**  ppe  
);  
```  
  
#### Parameters  
 `pstrCode`  
 [in] Provides the text of the expression or statement(s).  
  
 `nRadix`  
 [in] Radix to use.  
  
 `pstrDelimiter`  
 [in] The end-of-script-block delimiter. When `pstrCode` is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the script block. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine uses this information depends on the scripting engine. Set this parameter to `NULL` if the host did not use a delimiter to mark the end of the script block.  
  
 `dwFlags`  
 [in] Combination of the following debug text flags:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|DEBUG_TEXT_ISEXPRESSION|0x00000001|Indicates that the text is an expression as opposed to a statement. This flag may affect the way in which the text is parsed by some languages.|  
|DEBUG_TEXT_RETURNVALUE|0x00000002|If a return value is available, it will be used by the caller.|  
|DEBUG_TEXT_NOSIDEEFFECTS|0x00000004|Do not allow side effects. If this flag is set, the evaluation of the expression should change no runtime state.|  
|DEBUG_TEXT_ALLOWBREAKPOINTS|0x00000008|Allows breakpoints during the evaluation of the text. If this flag is not set then breakpoints are ignored during the evaluation of the text.|  
|DEBUG_TEXT_ALLOWERRORREPORT|0x00000010|Allows error reports during the evaluation of the text. If this flag is not set then errors are not reported to the host during the evaluation.|  
|DEBUG_TEXT_EVALUATETOCODECONTEXT|0x00000020|Indicates the expression is to be evaluated to a code context rather than running the expression itself|  
  
 `ppe`  
 [out] Returns the debug expression for the specified text.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates a debug expression for the specified text.  
  
## See also  
 [IDebugExpressionContext Interface](../../winscript/reference/idebugexpressioncontext-interface.md)