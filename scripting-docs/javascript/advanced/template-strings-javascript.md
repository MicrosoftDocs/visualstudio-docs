---
title: "Template Strings (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: f2e525a5-b0fc-49c3-95a0-641788e5c12a
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Template Strings (JavaScript)
In [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)], you can use template strings to construct string literals with embedded expressions. Template strings also provide built-in support for multi-line strings.  
  
 To construct a template string, use the grave accent (also called a back-tick) (`) to enclose the string instead of single or double quotes. The following code example shows a simple template string.  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
 Template strings can include line breaks without requiring use of the linefeed character (\n).  
  
<CodeContentPlaceHolder>1</CodeContentPlaceHolder>  
 The $ character is used to specify placeholders within a template string. The syntax is ${*expression*}, where *expression* is any JavaScript expression such as a variable or function, as shown in the following example.  
  
<CodeContentPlaceHolder>2</CodeContentPlaceHolder>  
 Tagged template functions, which allow you to modify the value of a template string using a function that is invoked with arguments from the template string. The first argument is an array of string literals, delimited by the template string expressions that it contains, and the second argument is an array (a [Rest parameter](../../javascript/functions-javascript.md)) that contains the values of the template string expressions.  
  
 In the following example, the tagged template function, buildURL is used to construct a URL. The syntax is to use the function name followed immediately by the template string.  
  
<CodeContentPlaceHolder>3</CodeContentPlaceHolder>  
 If you need access to the raw string values passed in, the first argument passed to the tagged template function supports a `raw` property that returns the raw string form of the passed in strings.  
  
```  
function buildURL(strArray, ...valArray) {  
    console.log(strArray.raw);  
}  
  
var lang = "en-us";  
var a = "library";  
var b = "dn771551.aspx";  
  
// Call the tagged template function.  
var url = buildURL`http://msdn.microsoft.com/${lang}/${a}/${b}`;  
  
// Ouput:  
// http://msdn.microsoft.com/  
// /  
// en-us  
// library  
```  
  
> [!NOTE]
>  You can also use the [String.raw](../../javascript/reference/string-raw-function-javascript.md) function to return the raw string form of a template string.  
  
## See Also  
 [JavaScript Language Reference](../../javascript/javascript-language-reference.md)   
 [Advanced JavaScript](../../javascript/advanced/advanced-javascript.md)