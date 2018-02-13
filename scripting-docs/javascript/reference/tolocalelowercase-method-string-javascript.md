---
title: "toLocaleLowerCase Method (String) (JavaScript) | Microsoft Docs"
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
  - "toLocaleLowerCase"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toLocaleLowerCase method"
ms.assetid: add894d3-d14a-4dbc-a9b9-7ad1d3a2e581
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleLowerCase Method (String) (JavaScript)
Converts all alphabetic characters to lowercase, taking into account the host environment's current locale.  
  
## Syntax  
  
```  
  
stringVar.toLocaleLowerCase( )  
```  
  
## Remarks  
 The required `stringVar` reference is a `String` object or string literal.  
  
 The `toLocaleLowerCase` method converts the characters in a string, taking into account the host environment's current locale. In most cases, the result is the same as the result of the `toLowerCase` method. Results differ if the rules for a language conflict with the regular Unicode case mappings.  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [toLocaleUpperCase Method (String)](../../javascript/reference/tolocaleuppercase-method-string-javascript.md)   
 [toLowerCase Method](../../javascript/reference/tolowercase-method-javascript.md)