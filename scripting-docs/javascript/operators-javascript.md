---
title: "Operators (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "JavaScript, operators"
ms.assetid: b8602b69-aba9-46e8-86e1-cb533ad41410
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Operators (JavaScript)
[!INCLUDE[javascript](../javascript/includes/javascript-md.md)] has a full range of operators, including arithmetic, logical, bitwise, assignment, as well as some miscellaneous operators. For explanations and examples, see the topics on specific operators.  
  
## Computational Operators  
  
|Description|Symbol|  
|-----------------|------------|  
|[Unary negation](../javascript/reference/subtraction-operator-decrement-javascript.md)|-|  
|[Increment](../javascript/reference/increment-and-decrement-operators-javascript.md)|++|  
|[Decrement](../javascript/reference/increment-and-decrement-operators-javascript.md)|--|  
|[Multiplication](../javascript/reference/multiplication-operator-decrement-javascript.md)|*|  
|[Division](../javascript/reference/division-operator-decrement-javascript.md)|/|  
|[Remainder arithmetic](../javascript/reference/modulus-operator-decrementjavascript.md)|%|  
|[Addition](../javascript/reference/addition-operator-decrement-javascript.md)|+|  
|[Subtraction](../javascript/reference/subtraction-operator-decrement-javascript.md)|-|  
  
## Logical Operators  
  
|Description|Symbol|  
|-----------------|------------|  
|[Logical NOT](../javascript/reference/logical-not-operator-decrement-exclpt-javascript.md)|!|  
|[Less than](../javascript/reference/comparison-operators-javascript.md)|\<|  
|[Greater than](../javascript/reference/comparison-operators-javascript.md)|>|  
|[Less than or equal to](../javascript/reference/comparison-operators-javascript.md)|\<=|  
|[Greater than or equal to](../javascript/reference/comparison-operators-javascript.md)|>=|  
|[Equality](../javascript/reference/comparison-operators-javascript.md)|==|  
|[Inequality](../javascript/reference/comparison-operators-javascript.md)|!=|  
|[Logical AND](../javascript/reference/logical-and-operator-decrement-javascript.md)|&&|  
|[Logical OR](../javascript/reference/logical-or-operator-decrement-javascript.md)|&#124;&#124;|  
|[Conditional (ternary)](../javascript/reference/conditional-ternary-operator-decrement-javascript.md)|?:|  
|[Comma](../javascript/reference/comma-operator-decrement-javascript.md)|,|  
|[Strict Equality](../javascript/reference/comparison-operators-javascript.md)|===|  
|[Strict Inequality](../javascript/reference/comparison-operators-javascript.md)|!==|  
  
## Bitwise Operators  
  
|Description|Symbol|  
|-----------------|------------|  
|[Bitwise NOT](../javascript/reference/bitwise-not-operator-decrement-tilde-javascript.md)|~|  
|[Bitwise Left Shift](../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)|<\<|  
|[Bitwise Right Shift](../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)|>>|  
|[Unsigned Right Shift](../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)|>>>|  
|[Bitwise AND](../javascript/reference/bitwise-and-operator-decrement-javascript.md)|&|  
|[Bitwise XOR](../javascript/reference/bitwise-xor-operator-decrement-hat-javascript.md)|^|  
|[Bitwise OR](../javascript/reference/bitwise-or-operator-decrement-javascript.md)|&#124;|  
  
## Assignment Operators  
  
|Description|Symbol|  
|-----------------|------------|  
|[Assignment](../javascript/reference/assignment-operator-decrement-equal-javascript.md)|=|  
|[Compound Assignment](../javascript/reference/compound-assignment-operators-javascript.md)|*OP*= (such as += and &=)|  
  
## Miscellaneous Operators  
  
|Description|Symbol|  
|-----------------|------------|  
|[delete](../javascript/reference/delete-operator-decrementjavascript.md)|delete|  
|[typeof](../javascript/reference/typeof-operator-decrementjavascript.md)|typeof|  
|[void](../javascript/reference/void-operator-decrementjavascript.md)|void|  
|[instanceof](../javascript/reference/instanceof-operator-decrementjavascript.md)|instanceof|  
|[new](../javascript/reference/new-operator-decrementjavascript.md)|new|  
|[in](../javascript/reference/in-operator-decrementjavascript.md)|in|  
  
## Equality and Strict Equality  
 The difference between == (equality) and === (strict equality) is that the equality operator will coerce values of different types before checking for equality. For example, comparing the string "1" with the number 1 will compare as true. The strict equality operator, on the other hand, will not coerce values to different types, and so the string "1" will not compare as equal to the number 1.  
  
 Primitive strings, numbers, and Booleans are compared by value. If they have the same value, they are equal. Objects (including `Array`, `Function`, `String`, **Number**, `Boolean`, **Error**, `Date` and `RegExp` objects) compare by reference. Even if two variables of these types have the same value, they are equal only if they refer to exactly the same object.  
  
 For example:  
  
```JavaScript  
// Two strings with the same value.  
var string1 = "Hello";  
var string2 = "Hello";  
  
// Two String objects with the same value.  
var StringObject1 = new String(string1);  
var StringObject2 = new String(string2);  
  
if (string1 == string2)  
    document.write("string1 is equal to string2 <br/>");  
  
if (StringObject1 != StringObject2)  
    document.write("StringObject1 is not equal to StringObject2 <br/>");  
  
// To compare the values of String objects, use the toString() or valueOf() methods.  
if (StringObject1.valueOf() == StringObject2.valueOf())  
    document.write("The value of StringObject1 is equal to the value of StringObject2");  
  
//Output:  
// string1 is equal to string2   
// StringObject1 is not equal to StringObject2   
// The value of StringObject1 is equal to the value of StringObject2  
  
```