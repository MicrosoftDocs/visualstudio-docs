---
title: "index Property (RegExp) (JavaScript) | Microsoft Docs"
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
  - "index"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Index property"
  - "matching strings"
ms.assetid: d8be1ef6-1bf2-43cd-b0b5-567a61eabaad
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# index Property (RegExp) (JavaScript)
Returns the character position where the first successful match begins in a searched string. Read-only.  
  
## Syntax  
  
```  
  
RegExp.index   
```  
  
## Remarks  
 The object associated with this property is always the global `RegExp` object.  
  
 The **index** property is zero-based. The initial value of the **index** property is -1. Its value changes whenever a successful match is made.  
  
## Example  
 The following example illustrates the use of the **index** property. This function iterates a search string and prints out the **index** and `lastIndex` values for each word in the string.  
  
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
      document.write (arr);  
      }  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [RegExp Object](../../javascript/reference/regexp-object-javascript.md)  
  
## See Also  
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)