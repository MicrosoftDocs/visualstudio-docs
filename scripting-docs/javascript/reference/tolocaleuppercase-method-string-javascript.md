---
title: "toLocaleUpperCase Method (String) (JavaScript) | Microsoft Docs"
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
  - "toLocaleUpperCase"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "toLocaleUpperCase method"
ms.assetid: e927adb6-475e-44b2-91f7-cedda10a39b0
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleUpperCase Method (String) (JavaScript)
Returns a string where all alphabetic characters have been converted to uppercase, taking into account the host environment's current locale.  
  
## Syntax  
  
```  
  
stringVar.toLocaleUpperCase( )  
```  
  
## Remarks  
 The required `stringVar` reference is a `String` object or string literal.  
  
 The `toLocaleUpperCase` method converts the characters in a string, taking into account the host environment's current locale. In most cases, the result is the same as the result the `toUpperCase` method. Results differ if the rules for a language conflict with the regular Unicode case mappings.  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [toLocaleLowerCase Method (String)](../../javascript/reference/tolocalelowercase-method-string-javascript.md)   
 [toUpperCase Method (String)](../../javascript/reference/touppercase-method-string-javascript.md)