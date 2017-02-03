---
title: "RegExp Object (JavaScript) | Microsoft Docs"
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
  - "RegExp"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "RegExp object, overview"
  - "RegExp object"
ms.assetid: 7f6b1073-8cbb-49ed-94b6-56833ba663c5
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# RegExp Object (JavaScript)
An intrinsic global object that stores information about the results of regular expression pattern matches.  
  
## Syntax  
  
```  
  
RegExp.property   
```  
  
## Remarks  
 The required *property* argument can be any one of the `RegExp` object properties.  
  
 The `RegExp` object cannot be created directly, but is always available for use. Until a successful regular expression search has been completed, the initial values of the various properties of the `RegExp` object are as follows:  
  
|Property|Shorthand|Initial Value|  
|--------------|---------------|-------------------|  
|index||-1|  
|input|$_|Empty string.|  
|lastIndex||-1|  
|lastMatch|$&|Empty string.|  
|lastParen|$+|Empty string.|  
|leftContext|$`|Empty string.|  
|rightContext|$'|Empty string.|  
|$1 - $9|$1 - $9|Empty string.|  
  
 Its properties have undefined as their value until a successful regular expression search has been completed.  
  
 The global `RegExp` object should not be confused with the **Regular Expression** object. Even though they sound like the same thing, they are separate and distinct. The properties of the global `RegExp` object contain continually updated information about each match as it occurs, while the properties of the **Regular Expression** object contain only information about the matches that occur with that instance of the **Regular Expression**.  
  
## Example  
 The following example performs a regular expression search. It displays matches and submatches from the global `RegExp` object, and from the array that is returned by the `exec` method.  
  
<CodeContentPlaceHolder>1</CodeContentPlaceHolder>  
<a name="js56jsobjregexpprop"></a>   
## Properties  
 [$1...$9 Properties](../../javascript/reference/dollar-1-dot-dot-dot-dollar-9-properties-regexp-javascript.md) &#124; [index Property](../../javascript/reference/index-property-regexp-javascript.md) &#124; [input Property](../../javascript/reference/input-property-dollar-regexp-javascript.md) &#124; [lastIndex Property](../../javascript/reference/lastindex-property-regexp-javascript.md) &#124; [lastMatch Property](../../javascript/reference/lastmatch-property-dollar-regexp-javascript.md) &#124; [lastParen Property](../../javascript/reference/lastparen-property-dollar-regexp-javascript.md) &#124; [leftContext Property](../../javascript/reference/leftcontext-property-dollar-grave-regexp-javascript.md) &#124; [rightContext Property](../../javascript/reference/rightcontext-property-dollar-regexp-javascript.md)  
  
## Methods  
 The `RegExp` object has no methods.  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)   
 [String Object](../../javascript/reference/string-object-javascript.md)