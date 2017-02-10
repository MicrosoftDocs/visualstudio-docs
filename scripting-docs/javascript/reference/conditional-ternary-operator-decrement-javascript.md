---
title: "Conditional (Ternary) Operator (?:) (JavaScript) | Microsoft Docs"
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
  - "?:"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "conditional operators"
  - "conditional (Ternary) operator"
  - "ternary"
ms.assetid: 7399ac32-9324-4a9a-ae76-be9c0f9df81c
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Conditional (Ternary) Operator (?:) (JavaScript)
Returns one of two expressions depending on a condition.  
  
## Syntax  
  
```  
  
test ? expression1 : expression2  
```  
  
## Parameters  
 `test`  
 Any Boolean expression.  
  
 `expression1`  
 An expression returned if `test` is `true`. May be a comma expression.  
  
 `expression2`  
 An expression returned if `test` is `false`. More than one expression may be a linked by a comma expression.  
  
## Remarks  
 The `?:` operator can be used as a shortcut for an `if...else` statement. It is typically used as part of a larger expression where an `if...else` statement would be awkward. For example:  
  
```javascript  
var now = new Date();  
var greeting = "Good" + ((now.getHours() > 17) ? " evening." : " day.");  
```  
  
 The example creates a string containing "Good evening." if it is after 6pm. The equivalent code using an `if...else` statement would look as follows:  
  
```javascript  
var now = new Date();  
var greeting = "Good";  
if (now.getHours() > 17)  
   greeting += " evening.";  
else  
   greeting += " day.";  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [if...else Statement](../../javascript/reference/if-dot-dot-dot-else-statement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)   
 [Script Junkie configuration widget sample app](http://code.msdn.microsoft.com/Script-Junkie-Configuration-543ece24)