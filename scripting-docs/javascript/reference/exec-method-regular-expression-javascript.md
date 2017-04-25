---
title: "exec Method (Regular Expression) (JavaScript) | Microsoft Docs"
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
  - "exec"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "matching strings"
  - "Exec method"
ms.assetid: 83092452-60cc-4218-b4ae-af9e3cb96c34
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# exec Method (Regular Expression) (JavaScript)
Executes a search on a string using a regular expression pattern, and returns an array containing the results of that search.  
  
## Syntax  
  
```  
  
rgExp.exec(str)   
```  
  
## Parameters  
 `rgExp`  
 Required. An instance of a **Regular Expression** object containing the regular expression pattern and applicable flags.  
  
 `str`  
 Required. The `String` object or string literal on which to perform the search.  
  
## Remarks  
 If the `exec` method does not find a match, it returns `null`. If it finds a match, `exec` returns an array, and the properties of the global `RegExp` object are updated to reflect the results of the match. Element zero of the array contains the entire match, while elements 1 – *n* contain any submatches that have occurred within the match. This behavior is identical to the behavior of the `match` method without the global flag (**g**) set.  
  
 If the global flag is set for a regular expression, `exec` searches the string beginning at the position indicated by the value of `lastIndex`. If the global flag is not set, `exec` ignores the value of `lastIndex` and searches from the beginning of the string.  
  
 The array returned by the `exec` method has three properties, **input**, **index** and **lastIndex.** The **input** property contains the entire searched string. The **index** property contains the position of the matched substring within the complete searched string. The `lastIndex` property contains the position following the last character in the match.  
  
## Example  
 The following example illustrates the use of the `exec` method:  
  
```JavaScript  
function RegExpTest()  
{  
   var ver = Number(ScriptEngineMajorVersion() + "." + ScriptEngineMinorVersion())  
   if (ver < 5.5)  
   {  
      document.write("You need a newer version of JavaScript for this to work");  
      return;  
   }  
  
   var src = "The quick brown fox jumps over the lazy dog.";  
  
   // Create regular expression pattern with a global flag.  
   var re = /\w+/g;  
  
   // Get the next word, starting at the position of lastindex.  
   var arr;  
   while ((arr = re.exec(src)) != null)  
      {  
      // New line:  
      document.write ("<br />");    
      document.write (arr.index + "-" + arr.lastIndex + " ");  
      document.write (arr[0]);  
      }  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)  
  
## See Also  
 [match Method (String)](../../javascript/reference/match-method-string-javascript.md)   
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)   
 [search Method (String)](../../javascript/reference/search-method-string-javascript.md)   
 [test Method (Regular Expression)](../../javascript/reference/test-method-regular-expression-javascript.md)   
 [Regular Expression Programming (JavaScript)](http://msdn.microsoft.com/en-us/3b62e27c-4f07-4726-a95b-6e841807bfaf)