---
title: "test Method (Regular Expression) (JavaScript) | Microsoft Docs"
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
  - "test"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "test method"
ms.assetid: 4f4b6e39-cb1a-4be9-a66f-7b846075580d
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# test Method (Regular Expression) (JavaScript)
Returns a Boolean value that indicates whether or not a pattern exists in a searched string.  
  
## Syntax  
  
```  
  
rgExp.test(str)   
```  
  
## Parameters  
 `rgExp`  
 Required. An instance of a **Regular Expression** object containing the regular expression pattern and applicable flags.  
  
 `str`  
 Required. The string on which to perform the search.  
  
## Remarks  
 The **test** method checks to see if a pattern exists within a string and returns **true** if so, and **false** otherwise.  
  
 The properties of the global `RegExp` object are not modified by the **test** method.  
  
## Example  
 The following example illustrates the use of the **test** method. To use this example, pass the function a regular expression pattern and a string. The function will test for the occurrence of the regular expression pattern in the string and return a string indicating the results of that search:  
  
```JavaScript  
function TestDemo(re, teststring)  
{  
   // Test string for existence of regular expression.  
   var found = re.test(teststring)  
  
   // Format the output.  
   var s = "";  
   s += "'" + teststring + "'"  
  
   if (found)  
      s += " contains ";  
   else  
      s += " does not contain ";  
  
   s += "'" + re.source + "'"  
   return(s);  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)  
  
## See Also  
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)