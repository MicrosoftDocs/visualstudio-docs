---
title: "try...catch...finally Statement (JavaScript) | Microsoft Docs"
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
  - "try_JavaScriptKeyword"
  - "finally_JavaScriptKeyword"
  - "catch_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "try-catch exception handling, finally block"
  - "try-catch exception handling, about try-catch exception handling"
  - "try-catch exception handling, catch block"
  - "try-catch exception handling"
ms.assetid: b7a0a54e-dfaa-4e41-bf25-bcaa43e601fb
caps.latest.revision: 28
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# try...catch...finally Statement (JavaScript)
Sets up blocks of code in which errors that are thrown in one block are handled in another. Errors that are thrown inside the `try` block are caught in the `catch` block. [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)].  
  
## Syntax  
  
```  
try {  
    tryStatements  
}  
catch(exception){  
    catchStatements  
}  
finally {  
    finallyStatements  
}  
```  
  
## Parameters  
 `tryStatements`  
 Required. Statements where an error can occur.  
  
 `exception`  
 Required. Any variable name. The initial value of `exception` is the value of the thrown error.  
  
 `catchStatements`  
 Optional. Statements to handle errors occurring in the associated `tryStatements`.  
  
 `finallyStatements`  
 Optional. Statements that are unconditionally executed after all other error processing has occurred.  
  
## Remarks  
 The `try...catch...finally` statement provides a way to handle some or all of the errors that may occur in a given block of code, while still running code. If errors occur that are not handled, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] provides the normal error message.  
  
 The `try` block contains code that may provoke an error, while the `catch` block contains the code that handles some or all errors. If an error occurs in the `try` block, program control is passed to the `catch` block. The value of `exception` is the value of the error that occurred in the `try` block. If no error occurs, the code in the `catch` block is never executed.  
  
 You can pass the error up to the next level by using the `throw` statement to re-throw the error.  
  
 After all the statements in the `try` block have been executed and error handling has been done in the `catch` block, the statements in the `finally` block are executed, whether or not an error was handled. The code in the `finally` block is guaranteed to run unless an unhandled error occurs (for example, a run-time error inside the **catch** block).  
  
## Example  
 The following example causes a `ReferenceError` exception to be thrown and displays the name of the error and its message.  
  
```JavaScript  
try {  
    addalert("bad call");  
}  
catch(e) {  
    document.write ("Error Message: " + e.message);  
    document.write ("<br />");  
    document.write ("Error Code: ");  
    document.write (e.number & 0xFFFF);  
    document.write ("<br />");  
    document.write ("Error Name: " + e.name);  
}  
  
// Output:  
Error Message: 'addalert' is undefined  
Error Code: 5009  
Error Name: ReferenceError  
  
```  
  
## Example  
 The following example shows how to re-throw errors, as well as the execution of nested `try…catch` blocks. When the error is thrown from the nested `try` block, it passes to the nested `catch` block, which re-throws it. The nested `finally` block runs before the outer `catch` block handles the error, and at the end the outer `finally` block runs.  
  
```JavaScript  
try {  
    document.write("Outer try running...<br/>");  
  
    try {  
        document.write("Nested try running...<br/>");  
        throw new Error(301, "an error");  
    }  
    catch (e) {  
        document.write ("Nested catch caught " + e.message + "<br/>");  
        throw e;  
    }  
    finally {  
        document.write ("Nested finally is running...<br/>");  
    }  
}  
catch (e) {  
    document.write ("Outer catch caught " + e.message + "<br/>");  
}  
finally {  
    document.write ("Outer finally running");  
}  
  
// Output:  
// Outer try running...  
// Nested try running...  
// Nested catch caught error from nested try  
// Nested finally is running...  
// Outer catch caught error from nested try  
// Outer finally running  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
> [!NOTE]
>  Starting with Internet Explorer 8 Standards mode, the **catch** block is no longer required for `finally` to run.  
  
## See Also  
 [throw Statement](../../javascript/reference/throw-statement-javascript.md)   
 [Script Junkie configuration wizard sample app](http://code.msdn.microsoft.com/Script-Junkie-Configuration-543ece24)