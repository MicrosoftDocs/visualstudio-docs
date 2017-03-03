---
title: "multiline Property (Regular Expression) (JavaScript) | Microsoft Docs"
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
  - "multiline"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "multiline property"
ms.assetid: ca7b276a-1fe2-4189-ac27-f089ab3e9974
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# multiline Property (Regular Expression) (JavaScript)
Returns a Boolean value indicating the state of the multiline flag (**m**) used with a regular expression. Default is **false**. Read-only.  
  
## Syntax  
  
```  
  
rgExp.multiline  
```  
  
## Remarks  
 The required `rgExp` argument is an instance of the `RegExp` object  
  
 The **multiline** property returns **true** if the multiline flag is set for a regular expression, and returns **false** if it is not. The **multiline** property is **true** if the regular expression object was created with the **m** flag.  
  
 If **multiline** is **false**, "^" matches the position at the beginning of a string, and "$" matches the position at the end of a string. If **multiline** is **true**, "^" matches the position at the beginning of a string as well as the position following a "\n" or "\r", and "$" matches the position at the end of a string and the position preceding "\n" or "\r".  
  
## Example  
 The following example illustrates the behavior of the **multiline** property. If you pass "m" in to the function shown below, the word "while" is replaced with the word "and". This is because with the multiline flag is set and the word "while" occurs at the beginning of the line after a newline character. The multiline flag allows the search to be performed on multiline strings.  
  
```javascript  
function RegExpMultilineDemo(flag){  
   // The flag parameter is a string that contains  
   // g, i, or m.  The flags can be combined.  
  
   // Check flags for validity.  
   if (flag.match(/[^gim]/))  
      {  
      return ("Flag specified is not valid");  
      }  
  
   // Create the string on which to perform the replacement.  
   var ss = "The man hit the ball with the bat ";  
   ss += "\nwhile the fielder caught the ball with the glove.";  
  
   // Replace "while" with "and".  
   var re = new RegExp("^while", flag);  
   var r = ss.replace(re, "and");          
  
   // Output the multiline flag and the resulting string.  
   var s = "";  
   s += "Result for multiline = " + re.multiline.toString();  
   s += ": " + r;  
  
   return(s);  
  
}  
  
sa = RegExpMultilineDemo("m");  
sb = RegExpMultilineDemo("");  
document.write (sa + "<br />" + sb);  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)  
  
## See Also  
 [global Property (Regular Expression)](../../javascript/reference/global-property-regular-expression-javascript.md)   
 [ignoreCase Property (Regular Expression)](../../javascript/reference/ignorecase-property-regular-expression-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)