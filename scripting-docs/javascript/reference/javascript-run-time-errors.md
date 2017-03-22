---
title: "JavaScript Run-time Errors | Microsoft Docs"
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
  - "VS.WebClient.Help.SCRIPT-32725"
  - "VS.WebClient.Help.SCRIPT7002"
  - "VS.WebClient.Help.SCRIPT1001"
  - "VS.WebClient.Help.SCRIPT16389"
  - "VS.WebClient.HelpSCRIPT50"
  - "VS.WebClient.HelpSCRIPT70"
  - "VS.WebClient.HelpSCRIPT87"
  - "VS.WebClient.HelpSCRIPT65535"
  - "VS.WebClient.HelpSCRIPT445"
  - "VS.WebClient.HelpSCRIPT600"
  - "VS.WebClient.HelpSCRIPT2343"
  - "VS.WebClient.HelpSCRIPT122"
  - "VS.WebClient.HelpSCRIPT28"
  - "VS.WebClient.HelpSCRIPT16386"
  - "VS.WebClient.HelpSCRIPT7015"
  - "VS.WebClient.HelpSCRIPT3"
  - "VS.WebClient.HelpSCRIPT16388"
  - "VS.WebClient.HelpSCRIPT14"
  - "VS.WebClient.HelpSCRIPT12030"
  - "VS.WebClient.HelpSCRIPT12029"
  - "VS.WebClient.HelpSCRIPT1001"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "errors [JavaScript]"
  - "run-time errors, JavaScript"
ms.assetid: c111469d-8f31-4bde-9d46-16d58775db7d
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JavaScript Run-time Errors
[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] run-time errors are errors that occur when your script attempts to perform an action that the system cannot execute. You may see run-time errors when variable expressions are being evaluated or memory is being allocated.  
  
## Windows Runtime Errors  
 If you are using Windows Runtime APIs in your [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] app, you may see JavaScript errors that have been converted from Windows Runtime HRESULTs. Windows Runtime HRESULTs in the range over 0x80070000 are converted to JavaScript errors by taking the hexadecimal value of the low bits and converting it to a decimal. For example, the HRESULT 0x80070032 is converted to the decimal value 50, and the JavaScript error is SCRIPT50. The HRESULT 0x80074005 is converted to the decimal value 16389, and the JavaScript error is SCRIPT16389.  
  
## Errors  
  
|Error Number|Description|  
|------------------|-----------------|  
|5|[Access is denied](../../javascript/misc/access-is-denied.md)|  
|438|[Object doesn't support this property or method](../../javascript/misc/object-doesn-t-support-this-property-or-method.md)|  
|1001|Out of memory|  
|5029|[Array length must be a finite positive integer](../../javascript/misc/array-length-must-be-a-finite-positive-integer.md)|  
|5030|[Array length must be assigned a finite positive number](../../javascript/misc/array-length-must-be-assigned-a-finite-positive-number.md)|  
|5028|[Array or arguments object expected](../../javascript/misc/array-or-arguments-object-expected.md)|  
|5010|[Boolean expected](../../javascript/misc/boolean-expected.md)|  
|5003|[Cannot assign to a function result](../../javascript/misc/cannot-assign-to-a-function-result.md)|  
|5000|[Cannot assign to 'this'](../../javascript/misc/cannot-assign-to-this.md)|  
|5034|[Circular reference in value argument not supported](../../javascript/misc/circular-reference-in-value-argument-not-supported.md)|  
|5006|[Date object expected](../../javascript/misc/date-object-expected.md)|  
|5015|[Enumerator object expected](../../javascript/misc/enumerator-object-expected.md)|  
|5022|[Exception thrown and not caught](../../javascript/misc/exception-thrown-and-not-caught.md)|  
|5020|[Expected ')' in regular expression](../Topic/Expected%20'\)'%20in%20regular%20expression%20\(JavaScript\).md)|  
|5019|[Expected '&#93;' in regular expression](../../javascript/misc/expected-right-square-bracket-in-regular-expression-javascript.md)|  
|5023|[Function does not have a valid prototype object](../../javascript/misc/function-does-not-have-a-valid-prototype-object.md)|  
|5002|[Function expected](../../javascript/misc/function-expected.md)|  
|5008|[Illegal assignment](../../javascript/misc/illegal-assignment-javascript.md)|  
|5021|[Invalid range in character set](../../javascript/misc/invalid-range-in-character-set-javascript.md)|  
|5035|[Invalid replacer argument](../../javascript/misc/invalid-replacer-argument.md)|  
|5014|[JavaScript object expected](../../javascript/misc/javascript-object-expected.md)|  
|5001|[Number expected](../../javascript/misc/number-expected.md)|  
|5007|[Object expected](../../javascript/misc/object-expected.md)|  
|5012|[Object member expected](../../javascript/misc/object-member-expected.md)|  
|5016|[Regular Expression object expected](../../javascript/misc/regular-expression-object-expected.md)|  
|5005|[String expected](../../javascript/misc/string-expected.md)|  
|5017|[Syntax error in regular expression](../../javascript/misc/syntax-error-in-regular-expression-javascript.md)|  
|5026|[The number of fractional digits is out of range](../../javascript/misc/the-number-of-fractional-digits-is-out-of-range.md)|  
|5027|[The precision is out of range](../../javascript/misc/the-precision-is-out-of-range.md)|  
|5025|[The URI to be decoded is not a valid encoding](../../javascript/misc/the-uri-to-be-decoded-is-not-a-valid-encoding.md)|  
|5024|[The URI to be encoded contains an invalid character](../../javascript/misc/the-uri-to-be-encoded-contains-an-invalid-character.md)|  
|5009|[Undefined identifier](../../javascript/misc/undefined-identifier.md)|  
|5018|[Unexpected quantifier](../../javascript/misc/unexpected-quantifier-javascript.md)|  
|5013|[VBArray expected](../../javascript/misc/vbarray-expected.md)|  
  
## See Also  
 [JavaScript Syntax Errors](../../javascript/reference/javascript-syntax-errors.md)