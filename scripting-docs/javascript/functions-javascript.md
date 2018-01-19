---
title: "Functions (JavaScript) | Microsoft Docs"
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
  - "intrinsic JavaScript functions"
ms.assetid: e2a72b5a-3edd-43d8-95e8-91721b38c1c1
caps.latest.revision: 24
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Functions (JavaScript)
[!INCLUDE[javascript](../javascript/includes/javascript-md.md)] functions perform actions; they can also return values. Sometimes these are the results of calculations or comparisons. Functions are also called "global methods".  
  
 Functions combine several operations under one name. This lets you streamline your code. You can write out a set of statements, name it, and then execute the entire set by calling it and passing to it any information it needs.  
  
 You pass information to a function by enclosing the information in parentheses after the name of the function. Pieces of information that are passed to a function are called arguments or parameters. Some functions do not take any arguments at all while others take one or more arguments. In some functions, the number of arguments depends on how you are using the function.  
  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] supports two kinds of functions: those that are built into the language, and those you create yourself.  
  
## Built-in Functions  
 The [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] language includes several built-in functions. Some let you handle expressions and special characters, while others convert strings to numeric values.  
  
 See [JavaScript Methods](../javascript/reference/javascript-methods.md) for information about these built-in functions.  
  
## Creating Your Own Functions  
 You can create your own functions and use them where needed. A function definition consists of a function statement and a block of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statements.  
  
 The **checkTriplet** function in the following example takes the lengths of the sides of a triangle as its arguments. It calculates from them whether the triangle is a right triangle by checking whether the three numbers constitute a Pythagorean triplet (the square of the length of the hypotenuse of a right triangle is equal to the sum of the squares of the lengths of the other two sides). The checkTriplet function calls one of two other functions to make the actual test.  
  
 Notice the use of a very small number ("epsilon") as a testing variable in the floating-point version of the test. Because of uncertainties and round-off errors in floating-point calculations, it is not practical to make a direct test of whether the three numbers constitute a Pythagorean triplet unless all three values in question are known to be integers. Because a direct test is more accurate, the code in this example determines whether it is appropriate and, if it is, uses it.  
  
```JavaScript  
var epsilon = 0.00000000001; // Some very small number to test against.  
  
// The test function for integers.  
function integerCheck(a, b, c)   
{  
   // The test itself.  
   if ( (a*a) == ((b*b) + (c*c)) )     
      return true;  
  
   return false;  
} // End of the integer checking function.  
  
// The test function for floating-point numbers.  
function floatCheck(a, b, c)     
{  
   // Make the test number.  
   var delta = ((a*a) - ((b*b) + (c*c)))  
  
   // The test requires the absolute value  
   delta = Math.abs(delta);  
  
   // If the difference is less than epsilon, then it's pretty close.  
   if (delta < epsilon)     
      return true;  
  
   return false;  
} // End of the floating-poing check function.  
  
// The triplet checker.   
function checkTriplet(a, b, c)  
{   
   // Create a temporary variable for swapping values  
   var d = 0;   
  
   // First, move the longest side to position "a".  
  
   // Swap a and b if necessary  
   if (b > a)  
   {  
      d = a;  
      a = b;  
      b = d;  
   }  
  
   // Swap a and c if necessary  
   if (c > a)  
   {  
      d = a;  
      a = c;  
      c = d;  
   }  
  
   // Test all 3 values. Are they integers?  
   if (((a % 1) == 0) && ((b % 1) == 0) && ((c % 1) == 0))  
   {   
      // If so, use the precise check.  
      return integerCheck(a, b, c);   
   }  
   else  
   {  
      // If not, get as close as is reasonably possible.  
      return floatCheck(a, b, c);   
   }  
} // End of the triplet check function.  
  
// The next three statements assign sample values for testing purposes.  
var sideA = 5;  
var sideB = 5;  
var sideC = Math.sqrt(50.001);  
  
// Call the function. After the call, 'result' contains the result.  
var result = checkTriplet(sideA, sideB, sideC);  
```  
  
<a name="Arrow"></a>   
## Arrow Functions  
 Arrow function syntax, `=>`, provides a shorthand method of specifying an anonymous function. Here is the arrow function syntax.  
  
```JavaScript  
([arg] [, arg]) => {  
    statements  
}  
```  
  
 Values to the left of the arrow, which may be enclosed by parentheses, specify the arguments passed to the function. A single argument to the function does not require parentheses. Parentheses are required if no arguments are passed in. The function definition to the right of the arrow can be either an expression, such as `v + 1`, or a block of statements enclosed by braces ({}).  
  
> [!IMPORTANT]
>  Arrow function syntax is supported only in [!INCLUDE[jsv12text](../javascript/includes/jsv12text-md.md)].  
  
 You cannot use the `new` operator with an arrow function.  
  
 The following code examples show the use of the arrow function with expressions as the function definitions. In the first example, v is passed in as the argument to the expression. In the second example, v and i are passed in as the arguments to the expression.  
  
```  
var evens = [2, 4, 6, 8];  
  
// Using standard syntax.  
var odds = evens.map(function(v) { return v + 1; });  
  
// Using arrow function syntax.  
// Add one to each value to produce output.  
var odds = evens.map(v => v + 1);  
  
// The following line of code adds the index value to the passed  
// in value to produce output.  
// Note: the second argument to the callback function in the map   
// method is the index value (i).  
var nums = evens.map((v, i) => v + i);  
  
console.log(odds);  
console.log(nums);  
  
// Output:  
// [object Array] [3, 5, 7, 9]  
// [object Array] [2, 5, 8, 11]  
```  
  
 The following code example shows the use of the arrow function with a statement block.  
  
```JavaScript  
var fives = new Array();  
  
// Statement block, re-using nums array from previous example.  
// Note: The first argument to the callback function in forEach  
// is the value of the array element (v).  
nums.forEach(v => {  
  if (v % 5 === 0)  
    fives.push(v);  
});  
  
console.log(fives);  
  
// Output:  
// [object Array] [5]  
```  
  
 Unlike standard functions, Arrow functions share the same lexical `this` object as the surrounding code, which can be used to eliminate the need for workarounds such as `var self = this;`.  
  
 The following example shows that the value of the `this` object within the arrow function is the same as in the surrounding code (it still refers to the `bob` variable.  
  
```JavaScript  
var bob = {  
  _name: "Bob",  
  _friends: ["Pete", "Joe", "Larry"],  
  printFriends() {  
    this._friends.forEach(f =>  
      console.log(this._name + " knows " + f));  
  }  
}  
  
// Output:  
// Bob knows Pete  
// Bob knows Joe  
// Bob knows Larry  
```  
  
 Arrow functions also share the same lexical `arguments` object as the surrounding code (just like the `this` object).  
  
<a name="Default"></a>   
## Default parameters  
 You can specify a default value for a parameter in a function by assigning it an initial value. The default value may be a constant value or an expression.  
  
> [!IMPORTANT]
>  Default parameters are supported only in [!INCLUDE[jsv12textExp](../javascript/includes/jsv12textexp-md.md)].  
  
 In the following example, the default value of y is 10, and the default value of z is 20. The function will use 10 as the value of y unless the caller passes in a distinct value (or undefined) as the second argument. The function will use 20 as the value of z unless the caller passes in a distinct value (or undefined) as the third argument.  
  
```JavaScript  
var val = 20;  
  
function f(x, y=10, z=val) {  
  return x + y + z;  
}  
  
console.log(f(3));  
console.log(f(3, 3));  
console.log(f(3, 3, 3));  
  
// Output:  
// 33  
// 26  
// 9  
```  
  
<a name="Rest"></a>   
## Rest parameters  
 Rest parameters, specified by the spread operator `...`, allow you to turn consecutive arguments in a function call to an array.  
  
 Rest parameters eliminate the need for the `arguments` object. Rest parameters differ from the `arguments` object in several ways, such as:  
  
-   A rest parameter is an actual array instance and therefore supports operations that can be performed on an array.  
  
-   A rest parameter includes only the consecutive arguments that are not passed in as separate (named) arguments (conversely, the `arguments` object contains all arguments passed into the function).  
  
> [!IMPORTANT]
>  Rest parameters and the spread operator are supported only in [!INCLUDE[jsv12text](../javascript/includes/jsv12text-md.md)].  
  
 In the following code example, "hello" and true are passed in as array values and stored in the y parameter. The rest parameter must be the last parameter of the function.  
  
```JavaScript  
function f(x, ...y) {  
  // y is an array.  
  return x * y.length;  
}  
  
console.log(f(3, "hello", true));  
  
// Output:  
// 6  
  
```  
  
 For additional uses of the spread operator, see [Spread Operator](../javascript/reference/spread-operator-decrement-dot-dot-dot-javascript.md).  
  
## See Also  
 [JavaScript Language Reference](../javascript/javascript-language-reference.md)