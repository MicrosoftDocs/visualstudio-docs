---
title: "global Property (Regular Expression) (JavaScript) | Microsoft Docs"
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
  - "Global"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "global property"
ms.assetid: 76a0f115-0d89-4aca-86d5-932895c6d649
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# global Property (Regular Expression) (JavaScript)
Returns a Boolean value indicating the state of the global flag (**g**) used with a regular expression. Default is **false**. Read-only.  
  
## Syntax  
  
```  
  
rgExp.global  
```  
  
## Remarks  
 The required `rgExp` reference is an instance of a **Regular Expression** object.  
  
 The `global` property returns **true** if the global flag is set for a regular expression, and returns **false** if it is not.  
  
 The global flag, when used, indicates that a search should find all occurrences of the pattern within the searched string, not just the first one. This is also known as global matching.  
  
## Example  
 The following example illustrates the use of the `global` property. If you pass **g** in to the function shown below, all instances of the word "the" are replaced with the word "a". Note that the "The" at the beginning of the string is not replaced because the **i** (ignore case) flag is not passed to the function.  
  
 This function displays the condition of the properties associated with the allowable regular expression flags, which are **g**, **i**, and **m**. The function also displays the string with all replacements made.  
  
```javascript  
function RegExpPropDemo(flag){  
   // The flag parameter is a string that contains  
   // g, i, or m.  The flags can be combined.  
  
   // Check flags for validity.  
   if (flag.match(/[^gim]/))  
      {  
      return ("Flag specified is not valid");  
      }  
  
   // Create the string on which to perform the replacement.  
   var ss = "The batter hit the ball with the bat ";  
   ss += "and the fielder caught the ball with the glove.";  
  
   //Replace "the" with "a".  
   var re = new RegExp("the", flag);  
   var r = ss.replace(re, "a");          
  
   // Output the resulting string and the flags.  
   var s = "";  
   s += "global: " + re.global.toString();  
   s += "<br />";  
   s += "ignoreCase: " + re.ignoreCase.toString();  
   s += "<br />";  
   s += "multiline: " + re.multiline.toString();  
   s += "<br />";  
   s += "Resulting String: " + r;  
  
   return (s);  
}  
  
document.write(RegExpPropDemo("g"));  
```  
  
## Example  
 Following is the resulting output.  
  
```javascript  
global: true  
ignoreCase: false  
multiline: false  
Resulting String: The batter hit a ball with a bat and a fielder caught a ball with a glove.  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)  
  
## See Also  
 [ignoreCase Property (Regular Expression)](../../javascript/reference/ignorecase-property-regular-expression-javascript.md)   
 [multiline Property (Regular Expression)](../../javascript/reference/multiline-property-regular-expression-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)