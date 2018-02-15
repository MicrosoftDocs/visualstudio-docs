---
title: "Writing JavaScript Code | Microsoft Docs"
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
  - "vs.htmldesigner.html"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "code, JavaScript syntax"
  - "comments, JavaScript code"
  - "JavaScript code"
ms.assetid: dde28266-0d0f-4460-a819-f931cf0911ad
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Writing JavaScript Code
Like many other programming languages, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] is organized into statements, blocks consisting of related sets of statements, and comments. Within a statement you can use variables, strings, numbers, and expressions.  
  
## Statements  
 A [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] program is a collection of statements. [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statements combine expressions in such a way that they carry out one complete task.  
  
 A statement consists of one or more expressions, keywords, or operators (symbols). Typically, a statement is written on a single line, although a statement can be written over two or more lines. Also, two or more statements can be written on the same line by separating them with semicolons. In general, each new line begins a new statement. It is a good idea to terminate your statements explicitly. You do this with the semicolon (;), which is the [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statement termination character.  
  
 Here are two examples of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statements. The sentences after the // characters are *comments*, which are explanatory remarks in the program.  
  
```JavaScript  
var aBird = "Robin"; // Assign the text "Robin" to the variable aBird.  
var today = new Date(); // Assign today's date to the variable today.  
```  
  
 A group of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statements surrounded by braces ({}) is called a *block*. Statements grouped into a block can generally be treated as a single statement. This means you can use blocks in most places that [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] expects a single statement. Notable exceptions include the headers of **for** and `while` loops. Notice that the single statements within a block end in semicolons, but the block itself does not.  
  
 Generally, blocks are used in functions and conditionals. Notice that unlike C++ and some other languages, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] does not consider a block to be a new scope; only functions create a new scope.  
  
 In the following example, the `else` clause contains a block of two statements surrounded by braces. The block is treated as a single statement. Also, the function itself consists of a block of statements surrounded by braces. The statements below the function are outside of the block and are therefore not part of the function definition.  
  
```JavaScript  
function inchestometers(inches)  
   {  
   if (inches < 0)  
      return -1;  
   else  
      {  
      var meters = inches / 39.37;  
      return meters;  
      }  
   }  
  
var inches = 12;  
var meters = inchestometers(inches);  
document.write("the value in meters is " + meters);  
```  
  
## Comments  
 A single-line [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] comment begins with a pair of forward slashes (//). Here is an example of a single line comment.  
  
```JavaScript  
var aGoodIdea = "Comment your code thoroughly."; // This is a single-line comment.  
```  
  
 A multiline [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] comment begins with a forward slash and asterisk (/*), and ends with the reverse (\*/).  
  
```JavaScript  
/*  
This is a multiline comment that explains the preceding code statement.  
  
The statement assigns a value to the aGoodIdea variable. The value,   
which is contained between the quote marks, is called a literal. A   
literal explicitly and directly contains information; it does not   
refer to the information indirectly. The quote marks are not part   
of the literal.  
*/  
```  
  
> [!NOTE]
>  If you attempt to embed one multiline comment within another, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] interprets the resulting multiline comment in an unexpected way. The */ that marks the end of the embedded multiline comment is interpreted as the end of the whole multiline comment. This means that the text that follows the embedded multiline comment will not be commented out; instead, it will be interpreted as [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] code, and will generate syntax errors.  
  
 It is recommended that you write all your comments as blocks of single-line comments. This allows you to comment out large segments of code with a multiline comment later.  
  
```JavaScript  
// This is another multiline comment, written as a series of single-line comments.  
// After the statement is executed, you can refer to the content of the   
// aGoodIdea variable by using its name.  
var extendedIdea = aGoodIdea + " You never know when you'll have to figure out what it does.";  
```  
  
## Assignments and Equality  
 The equal sign (=) is used in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] statements to assign values to variables: it is the assignment operator. The left hand operand of the = operator is always an Lvalue. Examples of Lvalues are:  
  
-   variables,  
  
-   array elements,  
  
-   object properties.  
  
 The right operand of the = operator is always an Rvalue. Rvalues can be an arbitrary value of any type, including the value of an expression. Here is an example of a [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] assignment statement.  
  
```JavaScript  
var anInteger = 3;  
```  
  
 The [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] compiler interprets this statement as meaning: "Assign the value 3 to the variable **anInteger**," or "**anInteger** takes the value 3."  
  
 Be certain you understand the difference between the = operator (assignment) and the == operator (equality). When you want to compare two values to find out if they are equal, use two equals signs (==). This is discussed in detail in [Controlling Program Flow](../javascript/controlling-program-flow-javascript.md).  
  
## Expressions  
 A [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] expression value can be of any valid [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] type - a number, a string, an object, and so on. The simplest expressions are literals. Here are some examples of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] literal expressions.  
  
```JavaScript  
3.9                       // numeric literal  
"Hello!"                  // string literal  
false                     // boolean literal  
null                      // literal null value  
{x:1, y:2}                // Object literal  
[1,2,3]                   // Array literal  
function(x){return x*x;}  // function literal  
```  
  
 More complicated expressions can contain variables, function calls, and other expressions. You can combine expressions to create complex expressions using operators. Examples of operators are: `+` (addition), `-` (subtraction), `*` (multiplication), and `/` (division).  
  
 Here are some examples of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] complex expressions.  
  
```JavaScript  
var anExpression = 3 * (4 / 5) + 6;  
var aSecondExpression = Math.PI * radius * radius;  
var aThirdExpression = aSecondExpression + "%" + anExpression;  
var aFourthExpression = "(" + aSecondExpression + ") % (" + anExpression + ")";  
```