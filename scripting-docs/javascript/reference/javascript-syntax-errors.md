---
title: "JavaScript Syntax Errors | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "JavaScript"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "errors [JavaScript]"
  - "syntax errors, JavaScript"
ms.assetid: 0343dc19-5f5e-4a4c-83da-630b4fbcb3b6
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JavaScript Syntax Errors
[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] syntax errors occur when the structure of one of your [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] statements violates one or more of the syntactic rules.  
  
## Errors  
  
|Error Number|Description|  
|------------------|-----------------|  
|1019|[Can't have 'break' outside of loop](../../javascript/misc/can-t-have-break-outside-of-loop.md)|  
|1020|[Can't have 'continue' outside of loop](../../javascript/misc/can-t-have-continue-outside-of-loop.md)|  
|1030|[Conditional compilation is turned off](../../javascript/misc/conditional-compilation-is-turned-off.md)|  
|1027|['default' can only appear once in a 'switch' statement](../../javascript/misc/default-can-only-appear-once-in-a-switch-statement.md)|  
|1005|[Expected '('](../../javascript/misc/expected-left-parenthesis-javascript.md  
|1006|[Expected ')'](../Topic/Expected%20'\)'%20\(JavaScript\).md)|  
|1012|[Expected '/'](../../javascript/misc/expected-minus.md)|  
|1003|[Expected ':'](../../javascript/misc/expected-colon.md)|  
|1004|[Expected ';'](../../javascript/misc/expected-semicolon.md)|  
|1032|[Expected '@'](../../javascript/misc/expected-at.md)|  
|1029|[Expected '@end'](../../javascript/misc/expected-at-end.md)|  
|1007|[Expected '&#93;'](../../javascript/misc/expected-right-square-bracket.md)|  
|1008|[Expected '{'](../../javascript/misc/expected-left-curly-brace.md)|  
|1009|[Expected '}'](../../javascript/misc/expected-right-curly-brace.md)|  
|1011|[Expected '='](../../javascript/misc/expected-equal-javascript.md)|  
|1033|[Expected 'catch'](../../javascript/misc/expected-catch.md)|  
|1031|[Expected constant](../../javascript/misc/expected-constant.md)|  
|1023|[Expected hexadecimal digit](../../javascript/misc/expected-hexadecimal-digit.md)|  
|1010|[Expected identifier](../../javascript/misc/expected-identifier-javascript.md)|  
|1028|[Expected identifier, string or number](../../javascript/misc/expected-identifier-string-or-number.md)|  
|1024|[Expected 'while'](../../javascript/misc/expected-while.md)|  
|1014|[Invalid character](../../javascript/misc/invalid-character-javascript.md)|  
|1026|[Label not found](../../javascript/misc/label-not-found.md)|  
|1025|[Label redefined](../../javascript/misc/label-redefined.md)|  
|1018|['return' statement outside of function](../../javascript/misc/return-statement-outside-of-function.md)|  
|1002|[Syntax error](../../javascript/misc/syntax-error-javascript.md)|  
|1035|[Throw must be followed by an expression on the same source line](../../javascript/misc/throw-must-be-followed-by-an-expression-on-the-same-source-line.md)|  
|1016|[Unterminated comment](../../javascript/misc/unterminated-comment.md)|  
|1015|[Unterminated string constant](../../javascript/misc/unterminated-string-constant-javascript.md)|  
  
### Script Host Errors  
 The following errors are properly speaking errors pertaining to the script host, but you may see them occasionally.  
  
|Error|HRESULT|Description|  
|-----------|-------------|-----------------|  
|SCRIPT_E_RECORDED|0x86664004|An error has been recorded to be passed between script engine and host. The host needs to pass the error code to the caller.|  
|SCRIPT_E_REPORTED|0x80020101|Script engine has reported an unhandled exception to the host via IActiveScriptSite::OnScriptError. Host can ignore this error.|  
|SCRIPT_E_PROPAGATE|0x8002010|A script error is being propagated to the caller which might be in a different thread. The host should pass the error code to the caller.|  
  
## See Also  
 [JavaScript Run-time Errors](../../javascript/reference/javascript-run-time-errors.md)