---
title: "Regular Expression Object (JavaScript) | Microsoft Docs"
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
  - "RegularExpression_JavaScript"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Regular Expression object"
  - "regular expressions, RegExp object"
  - "RegExp object, overview"
ms.assetid: 346aa83e-a045-47ea-acae-b42c7b121534
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Regular Expression Object (JavaScript)
An object that contains a regular expression pattern along with flags that identify how to apply the pattern.  
  
## Syntax  
  
```  
re = /pattern/[flags]  
```  
  
## Syntax  
  
```  
re = new RegExp("pattern"[,"flags"])   
```  
  
## Parameters  
 *re*  
 Required. The variable name to which the regular expression pattern is assigned.  
  
 *pattern*  
 Required. The regular expression pattern to use. If you use Syntax 1, delimit the pattern by "/" characters. If you use Syntax 2, enclose the pattern in quotation marks.  
  
 `flags`  
 Optional. Enclose flag in quotation marks if you use Syntax 2. Available flags, which may be combined, are:  
  
-   g (global search for all occurrences of *pattern*)  
  
-   i (ignore case)  
  
-   m (multiline search)  
  
-   u (unicode), enables EcmaScript 6 [Unicode features](../../javascript/advanced/special-characters-javascript.md). Supported only in [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)].  
  
-   y (sticky match), searches for matches at the `lastIndex` property of the regular expression (and does not search at later indexes). Supported in [!INCLUDE[jsv12textExp](../../javascript/includes/jsv12textexp-md.md)].  
  
## Remarks  
 The **Regular Expression** object should not be confused with the global `RegExp` object. Even though they sound the same, they are separate and distinct. The properties of the **Regular Expression** object contain only information about one particular **Regular Expression** instance, while the properties of the global `RegExp` object contain continually updated information about each match as it occurs.  
  
 **Regular Expression** objects store patterns used when searching strings for character combinations. After the **Regular Expression** object is created, it is either passed to a string method, or a string is passed to one of the regular expression methods. Information about the most recent search performed is stored in the global `RegExp` object.  
  
 Use Syntax 1 when you know the search string ahead of time. Use Syntax 2 when the search string is changing frequently, or is unknown, such as strings taken from user input.  
  
 The *pattern* argument is compiled into an internal format before use. For Syntax 1, *pattern* is compiled as the script is loaded. For Syntax 2, *pattern* is compiled just before use, or when the **compile** method is called.  
  
## Example  
 The following example illustrates the use of the **Regular Expression** object by creating an object (re) containing a regular expression pattern with its associated flags. In this case, the resulting **Regular Expression** object is then used by the `match` method:  
  
```javascript  
var s = "through the pages of the book";  
  
// Create regular expression pattern.  
var re = new RegExp("the", "i");  
  
// Attempt match on search string.  
var r = s.match(re);     
  
// Return first occurrence of "the".  
if(console && console.log) {  
    console.log(r);  
}  
  
// Output:  
//   
```  
  
## Example  
 The following example updates the regular expression pattern to search for multiple instances.  
  
```javascript  
// Create regular expression pattern using the i and g flags.  
var re = new RegExp("the", "ig");  
  
// Attempt match on search string.  
var r = s.match(re);     
  
// Return the two occurrences of "the".  
if(console && console.log) {  
    console.log(r.length);  
    console.log(r);  
}  
  
// Output:  
// 2  
// [object Array] ["the", "the"]  
```  
  
## Example  
 When using the /y flag, if a match succeeds, it updates the `lastindex` to the index of next character after the last match. If the match fails, it resets the `lastindex` to 0.  
  
 The following example searches for a match at a specific index using the /y flag and the `lastIndex` property.  
  
```javascript  
// Create regular expression pattern using the i and y flags.  
var re = new RegExp("the", "iy");  
  
// Set the lastIndex property and attempt a match  
// at the specified index.  
re.lastIndex = 20;  
var r = s.match(re);     
  
// No matches returned.  
if(console && console.log) {  
    console.log(r);  
}  
// Reset the lastIndex property and attempt a match.  
re.lastIndex = 21;  
var r = s.match(re);  
  
// Return occurrence of "the" starting at index 21.  
if(console && console.log) {  
    console.log(r);  
}  
  
// Output:  
// null  
// [object Array] ["the"]  
```  
  
<a name="js56jsobjregexpressionprop"></a>   
## Properties  
 [global Property](../../javascript/reference/global-property-regular-expression-javascript.md) &#124; [ignoreCase Property](../../javascript/reference/ignorecase-property-regular-expression-javascript.md) &#124; [multiline Property](../../javascript/reference/multiline-property-regular-expression-javascript.md) &#124; [source Property](../../javascript/reference/source-property-regular-expression-javascript.md)  
  
<a name="js56jsobjregexpressionmeth"></a>   
## Methods  
 [compile Method](../../javascript/reference/compile-method-regular-expression-javascript.md) &#124; [exec Method](../../javascript/reference/exec-method-regular-expression-javascript.md) &#124; [test Method](../../javascript/reference/test-method-regular-expression-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 The u flag is supported in [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)].  
  
 The y flag is supported in [!INCLUDE[jsv12textExp](../../javascript/includes/jsv12textexp-md.md)].  
  
## See Also  
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)   
 [String Object](../../javascript/reference/string-object-javascript.md)