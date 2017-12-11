---
title: "Controlling Program Flow (JavaScript) | Microsoft Docs"
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
  - "Boolean values, program flow"
  - "continue statement"
  - "break statement"
  - "control flow, about control flow"
ms.assetid: 4ef58c82-e5d6-4b09-9458-cf0aa3b39bf5
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Controlling Program Flow (JavaScript)
Normally, statements in a [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] script are executed one after the other, in the order in which they are written. This is called sequential execution, and is the default direction of program flow.  
  
 An alternative to sequential execution transfers the program flow to another part of your script. That is, instead of executing the next statement in the sequence, another statement is executed instead.  
  
 To make a script useful, this transfer of control must be done in a logical manner. Transfer of program control is based upon a decision, the result of which is a truth statement (returning a Boolean **true** or **false**). You create an expression, then test whether its result is true. There are two main kinds of program structures that accomplish this.  
  
 The first is the selection structure. You use it to specify alternate courses of program flow, creating a junction in your program (like a fork in a road). There are four selection structures available in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)].  
  
-   the single-selection structure (**if**),  
  
-   the double-selection structure (**if/else**),  
  
-   the inline ternary operator `?:`  
  
-   the multiple-selection structure (`switch`).  
  
 The second type of program control structure is the repetition structure. You use it to specify that an action is to be repeated while some condition remains true. When the conditions of the control statement have been met (usually after some specific number of iterations), control passes to the next statement beyond the repetition structure. There are four repetition structures available in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)].  
  
-   the expression is tested at the top of the loop (`while`),  
  
-   the expression is tested at the bottom of the loop (**do/while**),  
  
-   operate on each of an object's properties (**for/in**).  
  
-   counter controlled repetition (**for**).  
  
 You can create quite complex scripts by nesting and stacking selection and repetition control structures.  
  
 A third form of structured program flow is provided by exception handling, which is not covered in this document.  
  
## Using Conditional Statements  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] supports **if** and [if...else](../javascript/reference/if-dot-dot-dot-else-statement-javascript.md) conditional statements. In **if** statements a condition is tested, and if the condition meets the test, the relevant [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] code is executed. In the `if...else` statement, different code is executed if the condition fails the test. The simplest form of an **if** statement can be written on one line, but multiline **if** and `if...else` statements are much more common.  
  
 The following examples demonstrate syntaxes you can use with **if** and `if...else` statements. The first example shows the simplest kind of Boolean test. If (and only if) the item between the parentheses evaluates to (or can be coerced to) **true**, the statement or block of statements after the **if** is executed.  
  
```JavaScript  
function GetReaction(newShip, color, texture, dayOfWeek)  
{  
   // The test succeeds if the newShip Boolean value is true.  
   if (newShip)  
   {  
      return "Champagne Bottle";  
   }  
  
   // The test succeeds if both conditions are true.  
   if (color == "deep yellow" && texture == "large and small wrinkles")  
   {  
      return "Is it a crenshaw melon?";  
   }  
  
   // The test succeeds if either condition is true.  
   if ((dayOfWeek == "Saturday") || (dayOfWeek == "Sunday"))  
   {  
      return "I'm off to the beach!";  
   }  
   else  
   {  
      return "I'm going to work.";  
   }  
}  
  
var reaction = GetReaction(false, "deep yellow", "smooth", "Sunday");  
document.write(reaction);  
  
// Output: I'm off to the beach!  
```  
  
## Conditional Operator  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] also supports an implicit conditional form. It uses a question mark after the condition to be tested (rather than the word **if** before the condition). It also specifies two alternatives, one to be used if the condition is met and one if it is not. A colon must separate these alternatives.  
  
```JavaScript  
var AMorPM = (theHour >= 12) ? "PM" : "AM";  
```  
  
 If you have several conditions to be tested together, and you know that one is more likely to pass or fail than the others, you can use a feature called 'short circuit evaluation' to speed the execution of your script. When [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] evaluates a logical expression, it only evaluates as many sub-expressions as required to get a result.  
  
 For example, if you have an AND expression such as ((x == 123) && (y == 6)), [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] first checks if x is 123. If it is not, the entire expression cannot be true, even if y is equal to 6. Hence, the test for y is never made, and [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] returns the value **false**.  
  
 Similarly, if only one of several conditions must be **true** (using the &#124;&#124; operator), testing stops as soon as any one condition passes the test. This is effective if the conditions to be tested involve the execution of function calls or other complex expressions. With this in mind, when you write Or expressions, place the conditions most likely to be **true** first. When you write And expressions, place the conditions most likely to be **false** first.  
  
 A benefit of designing your script in this manner is that **runsecond()** will not be executed in the following example if **runfirst()** returns 0.  
  
```JavaScript  
if ((runfirst() == 0) || (runsecond() == 0)) {  
    // some code  
}  
```  
  
## Using Loops  
 There are several ways to execute a statement or block of statements repeatedly. In general, repetitive execution is called *looping* or *iteration*. An iteration is simply a single execution of a loop. It is typically controlled by a test of a variable, where the value of which is changed each time the loop is executed. [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] supports four types of loops: [for](../javascript/reference/for-statement-javascript.md) loops, [for...in](../javascript/reference/for-dot-dot-dot-in-statement-javascript.md) loops, [while](../javascript/reference/while-statement-javascript.md) loops, [do...while](../javascript/reference/do-dot-dot-dot-while-statement-javascript.md) loops.  
  
## Using for Loops  
 The **for** statement specifies a counter variable, a test condition, and an action that updates the counter. Before each iteration of the loop, the condition is tested. If the test is successful, the code inside the loop is executed. If the test is unsuccessful, the code inside the loop is not executed, and the program continues on the first line of code immediately following the loop. After the loop is executed, the counter variable is updated before the next iteration begins.  
  
 If the condition for looping is never met, the loop is never executed. If the test condition is always met, an infinite loop results. While the former may be desirable in certain cases, the latter rarely is, so be cautious when writing your loop conditions.  
  
```JavaScript  
// The update expression ("icount++" in the following examples)  
// is executed at the end of the loop, after the block of  
// statements that forms the body of the loop is executed, and  
// before the condition is tested.  
  
// Set a limit of 10 on the loop.  
var howFar = 10;  
  
// Create an array called sum with 10 members, 0 through 9.  
var sum = new Array(howFar);  
sum[0] = 0;  
  
// Iterate from 0 through 9.  
var theSum = 0;  
for(var icount = 0; icount < howFar; icount++)  
{  
   theSum += icount;  
   sum[icount] = theSum;  
}  
  
// This code is not executed at all, because icount is not greater than howFar.  
var newSum = 0;  
for(var icount = 0; icount > howFar; icount++)  
{  
   newSum += icount;  
}  
  
// This is an infinite loop.  
var sum = 0;  
for(var icount = 0; icount >= 0; icount++)  
{  
   sum += icount;  
}  
```  
  
## Using for...in Loops  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] provides a special kind of loop for stepping through all the user-defined properties of an [object](../javascript/objects-and-arrays-javascript.md), or all the elements of an array. The loop counter in a `for...in` loop is a string, not a number. It contains the name of current property or the index of the current array element.  
  
```JavaScript  
// Create an object with some properties  
var myObject = new Object();  
myObject.name = "James";  
myObject.age = "22";  
myObject.phone = "555 1234";  
  
// Enumerate (loop through)_all the properties in the object  
for (var prop in myObject)  
{  
    // This displays "The property 'name' is James", etc.  
    document.write("The property '" + prop + "' is " + myObject[prop]);  
    // New line.  
    document.write("<br />");    
}  
```  
  
 Although `for...in` loops look similar to VBScript's `For Each...Next` loops, they do not work the same way. The [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]**for...in loop** iterates over properties of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] objects. The VBScript **For Each...Next** loop iterates over items in a collection. To loop over collections in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], you need to use the [Enumerator Object](../javascript/reference/enumerator-object-javascript.md) object or, if present, the `forEach` method of the collection object. Although some objects, such as those in Internet Explorer, support both the VBScript **For Each...Next**  loop and the [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]**for...in** loop, most objects do not.  
  
## Using while Loops  
 A `while` loop is similar to a **for** loop. The difference is, a `while` loop does not have a built-in counter variable or update expression. If you want to control repetitive execution of a statement or block of statements, but need a more complex rule than simply "run this code n times", use a `while` loop. The following example uses the Internet Explorer object model and a `while` loop to ask the user a simple question.  
  
```JavaScript  
var x = 0;  
while ((x != 5) && (x != null))  
{  
    x = window.prompt("What is my favorite number?", x);  
}  
  
if (x == null)  
    window.alert("You gave up!");  
else  
    window.alert("Correct answer!");  
```  
  
> [!NOTE]
>  Because `while` loops do not have explicit built-in counter variables, they are more vulnerable to infinite looping than the other types of loops. Moreover, because it is not necessarily easy to discover where or when the loop condition is updated, it is easy to write a `while` loop in which the condition never gets updated. For this reason, you should be careful when you design `while` loops.  
  
 As noted above, there is also a **do...while** loop in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] that is similar to the while loop, except that it is guaranteed to always execute at least once, since the condition is tested at the end of the loop, rather than at the start. For example, the loop above can be re-written as:  
  
```JavaScript  
var x = 0;  
do  
{  
    x = window.prompt("What is my favorite number?", x);  
} while ((x != 5) && (x != null));  
  
if (x == null)  
    window.alert("You gave up!");  
else  
    window.alert("Correct answer!");  
```  
  
## Using break and continue Statements  
 In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], the [break](../javascript/reference/break-statement-javascript.md) statement is used to stop the execution of a loop, if some condition is met. (Note that **break** is also used to exit a `switch` block). The [continue](../javascript/reference/continue-statement-javascript.md) statement can be used to jump immediately to the next iteration, skipping the rest of the code block, while updating the counter variable if the loop is a **for** or `for...in` loop.  
  
 The following example builds on the previous example to use the **break** and **continue** statements to control the loop.  
  
```JavaScript  
var x = 0;  
do  
{  
    x = window.prompt("What is my favorite number?", x);  
  
    // Did the user cancel? If so, break out of the loop  
    if (x == null)  
        break;  
  
    // Did they enter a number?  
    // If so, no need to ask them to enter a number.  
    if (Number(x) == x)  
        continue;  
  
    // Ask user to only enter in numbers  
    window.alert("Please only enter in numbers!");  
  
} while (x != 5)  
  
if (x != 5)  
    window.alert("You gave up!");  
else  
    window.alert("Correct answer!");  
```