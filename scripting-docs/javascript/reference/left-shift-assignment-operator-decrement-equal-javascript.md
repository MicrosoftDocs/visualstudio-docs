---
title: "Left Shift Assignment Operator (&lt;&lt;=) (JavaScript) | Microsoft Docs"
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
  - "<<="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "<<= operator [JavaScript]"
  - "left shift assignment operator (<<=) [JavaScript]"
  - "left shift operators [JavaScript]"
  - "assignment operators, JavaScript"
ms.assetid: 9f30ff46-48cc-4931-b260-edef31ff0076
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Left Shift Assignment Operator (&lt;&lt;=) (JavaScript)
Moves the specified number of bits to the left and assigns the result to `result`. The bits vacated by the operation are filled with 0.  
  
## Syntax  
  
```  
  
result <<= expression  
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `expression`  
 The number of bits to move.  
  
## Remarks  
 Using the `<<=` operator is the same as specifying `result = result << expression`  
  
 The following example shows how to use the `<<=` operator.  
  
```javascript  
// 14 is 00000000000000000000000000001110  
var temp = 14;  
temp <<= 2;   
document.write(temp);  
// 56 is 00000000000000000000000000111000  
Output: 56  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise Left Shift Operator (<\<)](../../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)   
 [Bitwise Right Shift Operator (>>)](../../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)   
 [Unsigned Right Shift Operator (>>>)](../../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)