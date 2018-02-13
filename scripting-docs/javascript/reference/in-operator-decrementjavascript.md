---
title: "in Operator (JavaScript) | Microsoft Docs"
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
  - "in_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "in operator"
ms.assetid: dcd8f901-96b8-4c91-848b-b1ec0ab1c11c
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# in Operator (JavaScript)
Tests for the existence of a property in an object.  
  
## Syntax  
  
```  
  
result = property in object  
```  
  
## Parameters  
 `result`  
 Required. Any variable.  
  
 `property`  
 Required. An expression that evaluates to a string expression.  
  
 `object`  
 Required. Any object.  
  
## Remarks  
 The `in` operator determines whether an object has a property named `property`. It also determines whether the property is part of the object's prototype chain. For more information about object prototypes, see [Prototypes and Prototype Inheritance](../../javascript/advanced/prototypes-and-prototype-inheritance.md).  
  
## Example  
 The following example shows how to use the `in` operator:  
  
```JavaScript  
// Create an object that has some properties.  
var myObject = new Object();  
myObject.name = "James";  
myObject.age = "22";  
myObject.phone = "555 0234";  
  
if ("phone" in myObject)  
   document.write ("property is present");  
else  
   document.write ("property is not present");  
  
// Output: property is present  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)