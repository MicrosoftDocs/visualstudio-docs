---
title: "ignoreCase Property (Regular Expression) (JavaScript) | Microsoft Docs"
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
  - "ignoreCase"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "IgnoreCase property"
ms.assetid: 816f0df5-5a82-44a5-a4ab-dbc91fa76e61
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ignoreCase Property (Regular Expression) (JavaScript)
Returns a Boolean value indicating the state of the ignoreCase flag (**i**) used with a regular expression. Default is **false**. Read-only.  
  
## Syntax  
  
```  
  
rgExp.ignoreCase  
```  
  
## Remarks  
 The required `rgExp` reference is an instance of the `RegExp` object.  
  
 The **ignoreCase** property returns **true** if the ignoreCase flag is set for a regular expression, and returns **false** if it is not.  
  
 The ignoreCase flag, when used, indicates that a search should ignore case sensitivity when matching the pattern within the searched string.  
  
## Example  
 The following example illustrates the use of the **ignoreCase** property. If you pass "gi" in to the function shown below, all instances of the word "the" are replaced with the word "a", including the initial "The". This is because with the ignoreCase flag set, the search ignores any case sensitivity. So "T" is the same as "t" for the purposes of matching.  
  
 This function returns the Boolean values that indicate the state of the allowable regular expression flags, which are **g**, **i**, and **m**. The function also returns the string with all replacements made.  
  
```javascript  
function RegExpPropDemo(flag){  
    // The flag parameter is a string that contains  
    // g, i, or m. The flags can be combined.  
  
    // Check flags for validity.  
    if (flag.match(/[^gim]/))  
        {  
        return ("Flag specified is not valid");  
        }  
  
    // Create the string on which to perform the replacement.  
    var orig = "The batter hit the ball with the bat ";  
    orig += "and the fielder caught the ball with the glove.";  
  
    // Replace "the" with "a".  
    var re = new RegExp("the", flag);  
    var r = orig.replace(re, "a");          
  
    // Output the resulting string and the values of the flags.  
    var s = "";  
    s += "global: " + re.global.toString();  
    s += "<br />";  
    s += "ignoreCase: " + re.ignoreCase.toString();  
    s += "<br />";  
    s += "multiline: " + re.multiline.toString();  
    s += "<br />";  
    s += "Resulting String: " + r;  
    s += "<br />";  
    s += "<br />";  
    return (s);  
}  
  
document.write(RegExpPropDemo("gi"));  
document.write(RegExpPropDemo("g"));  
```  
  
## Example  
 Following is the resulting output.  
  
```javascript  
global: true  
ignoreCase: true  
multiline: false  
Resulting String: a batter hit a ball with a bat and a fielder caught a ball with a glove.  
  
global: true  
ignoreCase: false  
multiline: false  
Resulting String: The batter hit a ball with a bat and a fielder caught a ball with a glove.  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)  
  
## See Also  
 [global Property (Regular Expression)](../../javascript/reference/global-property-regular-expression-javascript.md)   
 [multiline Property (Regular Expression)](../../javascript/reference/multiline-property-regular-expression-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)