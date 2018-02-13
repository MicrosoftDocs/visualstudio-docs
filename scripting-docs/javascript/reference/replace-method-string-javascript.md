---
title: "replace Method (String) (JavaScript) | Microsoft Docs"
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
  - "replace"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "replacing strings"
  - "Replace method"
ms.assetid: 5f0e4765-df4d-4887-bd09-efe5e58251bf
caps.latest.revision: 28
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# replace Method (String) (JavaScript)
Replaces text in a string, using a regular expression or search string.  
  
## Syntax  
  
```  
  
stringObj.replace(rgExp, replaceText)  
```  
  
## Parameters  
 `stringObj`  
 Required. The `String` object or string literal on which to perform the replacement. This string is not modified by the **replace** method. Rather, the return value of this method is the string produced by the replacement.  
  
 `rgExp`  
 Required. An instance of a **Regular Expression** object containing the regular expression pattern and applicable flags. Can also be a `String` object or string literal that represents the regular expression. If `rgExp` is not an instance of a **Regular Expression** object, it is converted to a string, and an exact search is made for the results; no attempt is made to convert the string into a regular expression.  
  
 `replaceText`  
 Required. A `String` object or string literal containing the text to replace for every successful match of `rgExp` in `stringObj`. In [!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later, the `replaceText` argument can also be a function that returns the replacement text.  
  
## Return Value  
 The result of the **replace** method is a copy of `stringObj` after the specified replacements have been made.  
  
## Remarks  
 Any of the following match variables can be used to identify the most recent match and the string from which it came. The match variables can be used in text replacement where the replacement string has to be determined dynamically.  
  
|Characters|Meaning|  
|----------------|-------------|  
|**$$**|`$` ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
|**$&**|Specifies that portion of `stringObj` that the entire pattern matched. ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
|`$``|Specifies that portion of `stringObj` that precedes the match described by **$&**. ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
|`$'`|Specifies that portion of `stringObj` that follows the match described by **$&**. ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
|`$`  ***n***|The *n*th captured submatch, where *n* is a single decimal digit from 1 through 9. ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
|`$`  ***nn***|The *nn*th captured submatch, where *nn* is a two-digit decimal number from 01 through 99. ([!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] or later)|  
  
 If `replaceText` is a function, for each matched substring the function is called with the following *m* + 3 arguments where *m* is the number of left capturing parentheses in the `rgExp`. The first argument is the substring that matched. The next *m* arguments are all of the captures that resulted from the search. Argument *m* + 2 is the offset within `stringObj` where the match occurred, and argument *m* + 3 is `stringObj`. The result is the string value that results from replacing each matched substring with the corresponding return value of the function call.  
  
 The **replace** method updates the properties of the global `RegExp` object.  
  
## Example  
 The following example illustrates the use of the **replace** method to replace all instances of "the" with "a."  
  
```JavaScript  
var s = "the batter hit the ball with the bat";  
  
// Replace "the" with "a".  
var re = /the/g;  
var result = s.replace(re, "a");  
document.write(result);  
// Output: a batter hit a ball with a bat  
```  
  
 In addition, the **replace** method can also replace subexpressions in the pattern. The following example exchanges each pair of words in the string.  
  
```JavaScript  
  
var s = "The quick brown fox jumped over the lazy dog.";  
var re = /(\S+)(\s+)(\S+)/g;  
// Exchange each pair of words.  
var result = s.replace(re, "$3$2$1");  
document.write(result);  
  
// Output:  quick The fox brown over jumped lazy the dog.  
```  
  
 The following example, which works in [!INCLUDE[jsv55textspecific](../../javascript/reference/includes/jsv55textspecific-md.md)] and later, shows how to use a function that returns the replacement text. It replaces any instance of a number followed by "F" with a Celsius conversion.  
  
```JavaScript  
function f2c(s1) {  
    // Initialize pattern.  
    var test = /(\d+(\.\d*)?)F\b/g;  
  
    // Use a function for the replacement.  
    var s2 = s1.replace(test,  
      function($0,$1,$2)  
           {   
           return((($1-32) * 5/9) + "C");  
           }  
        )  
    return s2;  
}  
document.write(f2c("Water freezes at 32F and boils at 212F."));  
  
// Output: Water freezes at 0C and boils at 100C.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [exec Method (Regular Expression)](../../javascript/reference/exec-method-regular-expression-javascript.md)   
 [match Method (String)](../../javascript/reference/match-method-string-javascript.md)   
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [search Method (String)](../../javascript/reference/search-method-string-javascript.md)   
 [test Method (Regular Expression)](../../javascript/reference/test-method-regular-expression-javascript.md)   
 [Regular Expression Programming (JavaScript)](http://msdn.microsoft.com/en-us/3b62e27c-4f07-4726-a95b-6e841807bfaf)   
 [Alternation and Subexpressions (JavaScript)](http://msdn.microsoft.com/en-us/c59dd3e8-7fee-493e-9123-065af1e651ae)   
 [Backreferences (JavaScript)](http://msdn.microsoft.com/en-us/5d8dbd5a-cd03-4548-850b-9d7bad2c839a)   
 [HTML5 drag and drop sample app](http://code.msdn.microsoft.com/Drag-and-drop-e2701a72)