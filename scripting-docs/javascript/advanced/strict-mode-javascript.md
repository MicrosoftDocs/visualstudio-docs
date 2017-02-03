---
title: "Strict Mode (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1038"
  - "VS.WebClient.Help.SCRIPT1050"
  - "VS.WebClient.Help.SCRIPT1042"
  - "VS.WebClient.Help.SCRIPT1041"
  - "VS.WebClient.Help.SCRIPT1046"
  - "VS.WebClient.Help.SCRIPT1045"
  - "VS.WebClient.Help.SCRIPT1037"
  - "VS.WebClient.Help.SCRIPT1039"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "strict mode"
  - "use strict"
ms.assetid: 0f27022a-f41c-4504-965c-5a2701f342cd
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Strict Mode (JavaScript)
Strict mode is a way to introduce better error-checking into your code. When you use strict mode, you cannot, for example, use implicitly declared variables, or assign a value to a read-only property, or add a property to an object that is not extensible. The restrictions are listed in the [Restrictions on Code in Strict Mode](../../javascript/advanced/strict-mode-javascript.md#rest) section later in this topic. For additional information on strict mode, see [ECMAScript Language Specification, 5th edition](http://www.ecma-international.org/publications/standards/Ecma-262.htm).  
  
> [!WARNING]
>  Strict mode is not supported in versions of Internet Explorer earlier than Internet Explorer 10.  
  
## Declaring Strict Mode  
 You can declare strict mode by adding `"use strict";` at the beginning of a file, a program, or a function. This kind of declaration is known as a *directive prologue*. The scope of a strict mode declaration depends on its context. If it is declared in a global context (outside the scope of a function), all the code in the program is in strict mode. If it is declared in a function, all the code in the function is in strict mode. For example, in the following example all the code is in strict mode, and the variable declaration outside the function causes the syntax error "Variable undefined in strict mode."  
  
```javascript  
"use strict";  
function testFunction(){  
    var testvar = 4;  
    return testvar;  
}  
  
// This causes a syntax error.  
testvar = 5;  
  
```  
  
 In the following example, only the code inside `testFunction` is in strict mode. The variable declaration outside the function does not cause a syntax error, but the declaration inside the function does.  
  
```javascript  
function testFunction(){  
    "use strict";  
    // This causes a syntax error.  
    testvar = 4;  
    return testvar;  
}  
testvar = 5;  
  
```  
  
<a name="rest"></a>   
## Restrictions on Code in Strict Mode  
 The following table lists the most important restrictions that apply in strict mode.  
  
|||||  
|-|-|-|-|  
|**Language element**|**Restriction**|**Error**|**Example**|  
|Variable|Using a variable without declaring it.|SCRIPT5042: Variable undefined in strict mode|`testvar = 4;`|  
|Read-only property|Writing to a read-only property.|SCRIPT5045: Assignment to read-only properties is not allowed in strict mode|`var testObj = Object.defineProperties({}, {     prop1: {         value: 10,         writable: false // by default     },     prop2: {         get: function () {         }     } }); testObj.prop1 = 20;  testObj.prop2 = 30;`|  
|Non-extensible property|Adding a property to an object whose `extensible` attribute is set to `false`.|SCRIPT5046: Cannot create property for a non-extensible object|`var testObj = new Object();  Object.preventExtensions(testObj);  testObj.name = "Bob";`|  
|`delete`|Deleting a variable, a function, or an argument.<br /><br /> Deleting a property whose `configurable` attribute is set to `false`.|SCRIPT1045: Calling delete on \<expression>is not allowed in strict mode|`var testvar = 15; function testFunc() {}; delete testvar; delete testFunc;  Object.defineProperty(testObj, "testvar", {     value: 10,     configurable: false     }); delete testObj.testvar;`|  
|Duplicating a property|Defining a property more than once in an object literal.|SCRIPT1046: Multiple definitions of a property not allowed in strict mode|`var testObj = {     prop1: 10,     prop2: 15,     prop1: 20 };`|  
|Duplicating a parameter name|Using a parameter name more than once in a function.|SCRIPT1038: Duplicate formal parameter names not allowed in strict mode|`function testFunc(param1, param1) {     return 1; };`|  
|Future reserved keywords|Using a future reserved keyword as a variable or function name.|SCRIPT1050: The use of a future reserved word for an identifier is invalid. The identifier name is reserved in strict mode.|-                      `implements`<br /><br /> -                      `interface`<br /><br /> -                      `package`<br /><br /> -                      `private`<br /><br /> -                      `protected`<br /><br /> -                      `public`<br /><br /> -                      `static`<br /><br /> -                      `yield`|  
|Octals|Assigning an octal value to a numeric literal, or attempting to use an escape on an octal value.|SCRIPT1039: Octal numeric literals and escape characters not allowed in strict mode|`var testoctal = 010; var testescape = \010;`|  
|`this`|The value of `this` is not converted to the global object when it is `null` or `undefined`.||`function testFunc() {     return this; } var testvar = testFunc();`<br /><br /> In non-strict mode, the value of `testvar` is the global object, but in strict mode the value is `undefined`.|  
|`eval` as an identifier|The string "eval" cannot be used as an identifier (variable or function name, parameter name, and so on).||`var eval = 10;`|  
|Function declared inside a statement or a block|You cannot declare a function inside a statement or a block.|SCRIPT1047: In strict mode, function declarations cannot be nested inside a statement or block. They may only appear at the top level or directly inside a function body.|`var arr = [1, 2, 3, 4, 5]; var index = null; for (index in arr) {     function myFunc() {}; }`|  
|Variable declared inside an `eval` function|If a variable is declared inside an `eval` function, it cannot be used outside that function.|SCRIPT1041: Invalid usage of 'eval' in strict mode|`eval("var testvar = 10"); testvar = 15;`<br /><br /> Indirect evaluation is possible, but you still cannot use a variable declared outside the `eval` function.<br /><br /> `var indirectEval = eval; indirectEval("var testvar = 10;"); document.write(testVar);`<br /><br /> This code causes an error SCRIPT5009: 'testVar' is undefined.|  
|`Arguments` as an identifier|The string "arguments" cannot be used as an identifier (variable or function name, parameter name, and so on).|SCRIPT1042: Invalid usage of 'arguments' in strict mode|`var arguments = 10;`|  
|`arguments` inside a function|You cannot change the values of members of the local `arguments` object.||`function testArgs(oneArg) {     arguments[0] = 20; }`<br /><br /> In non-strict mode, you can change the value of the `oneArg` parameter by changing the value of `arguments[0]`, so that the value of both `oneArg` and `arguments[0]` is 20. In strict mode, changing the value of `arguments[0]` does not affect the value of `oneArg`, because the `arguments` object is merely a local copy.|  
|`arguments.callee`|Not allowed.||`function (testInt) {     if (testInt-- == 0)         return;     arguments.callee(testInt--); }`|  
|`with`|Not allowed.|SCRIPT1037: 'with' statements are not allowed in strict mode|`with (Math){     x = cos(3);     y = tan(7); }`|