---
title: "lastIndex Property (RegExp) (JavaScript) | Microsoft Docs"
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
  - "lastIndex"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "lastIndex property"
ms.assetid: c8ae2a13-6dff-4cbe-b662-aca3d66c2a7f
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# lastIndex Property (RegExp) (JavaScript)
Returns the character position where the next match begins in a searched string.  
  
## Syntax  
  
```  
  
RegExp.lastIndex  
```  
  
## Remarks  
 The object associated with this property is always the global `RegExp` object.  
  
 The `lastIndex` property is zero-based, that is, the index of the first character is zero. Its initial value is –1. Its value is modified whenever a successful match is made.  
  
 The `lastIndex` property is modified by the `exec` and **test** methods of the `RegExp` object, and the `match`, **replace**, and **split** methods of the `String` object.  
  
 The following rules apply to values of `lastIndex`:  
  
-   If there is no match, `lastIndex` is set to -1.  
  
-   If `lastIndex` is greater than the length of the string, **test** and `exec` fail and `lastIndex` is set to -1.  
  
-   If `lastIndex` is equal to the length of the string, the regular expression matches if the pattern matches the empty string. Otherwise, the match fails and `lastIndex` is reset to -1.  
  
-   Otherwise, `lastIndex` is set to the next position following the most recent match.  
  
## Example  
 The following example illustrates the use of the `lastIndex` property. This function iterates a search string and prints out the **index** and `lastIndex` values for each word in the string.  
  
```javascript  
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
      document.write (arr.index + "-" + re.lastIndex + " ");  
      document.write (arr);  
      }  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [RegExp Object](../../javascript/reference/regexp-object-javascript.md)  
  
## See Also  
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)