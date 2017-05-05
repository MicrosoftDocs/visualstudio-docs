---
title: "Error Object (JavaScript) | Microsoft Docs"
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
  - "Error"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Error object"
ms.assetid: 0b27d6ec-3997-4e91-a6c0-5afbaf494db7
caps.latest.revision: 25
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Error Object (JavaScript)
Contains information about errors.  
  
## Syntax  
  
```  
  
      errorObj = new Error()  
errorObj = new Error([number])  
errorObj = new Error([number[, description]])  
```  
  
## Parameters  
 `errorObj`  
 Required. The variable name to which the `Error` object is assigned. The variable assignment is omitted when you create the error using a `throw` statement.  
  
 `number`  
 Optional. Numeric value assigned to an error. Zero if omitted.  
  
 `description`  
 Optional. Brief string that describes an error. Empty string if omitted.  
  
## Remarks  
 Whenever a run-time error occurs, an instance of the `Error` object is created to describe the error. This instance has two intrinsic properties that contain the description of the error (`description` property) and the error number (`number` property). For more information, see [JavaScript Run-time Errors](../../javascript/reference/javascript-run-time-errors.md).  
  
 An error number is a 32-bit value. The upper 16-bit word is the facility code, while the lower word is the actual error code.  
  
 `Error` objects can also be explicitly created, using the syntax shown above, or thrown using the `throw` statement. In both cases, you can add any properties you choose to expand the capability of the `Error` object.  
  
 Typically, the local variable that is created in a **try...catch** statement refers to the implicitly created `Error` object. As a result, you can use the error number and description in any way you choose.  
  
## Example  
 The following example illustrates the use of the `Error` object.  
  
```  
function checkInput(x) {  
    try  
    {  
        if (isNaN(parseInt(x))) {  
            throw new Error("Input is not a number.");  
        }  
    }  
    catch(e)  
    {  
        document.write(e.description);  
    }  
}  
  
checkInput("not a number");  
```  
  
## Example  
 The following example illustrates the use of the implicitly created `Error` object.  
  
```JavaScript  
try  
   {  
   // Cause an error.  
   x = y;  
   }  
catch(e)  
   {  
      document.write(e);  
      document.write ("<br />");  
  
      document.write ("Number: ");  
      document.write (e.number & 0xFFFF);  
      document.write ("<br />");  
  
      document.write ("Facility Code: ");  
      document.write(e.number>>16 & 0x1FFF);  
      document.write ("<br />");  
  
      document.write ("Description: ");  
      document.write (e.description);  
   }  
  
// Output:  
// ReferenceError: 'y' is undefined  
// Number: 5009  
// Facility Code: 10  
// Description: 'y' is undefined  
  
```  
  
## Methods  
 [toString Method (Error)](../../javascript/reference/tostring-method-error.md) &#124; [valueOf Method (Date)](../../javascript/reference/valueof-method-date.md)  
  
## Properties  
 [constructor Property (Error)](../../javascript/reference/constructor-property-error.md) &#124; [description Property](../../javascript/reference/description-property-error-javascript.md) &#124; [message Property](../../javascript/reference/message-property-error-javascript.md) &#124; [name Property](../../javascript/reference/name-property-error-javascript.md) &#124; [number Property](../../javascript/reference/number-property-error-javascript.md) &#124; [prototype Property (Error)](../../javascript/reference/prototype-property-error.md) &#124; [stack Property (Error)](../../javascript/reference/stack-property-error-javascript.md) &#124; [stackTraceLimit Property (Error)](../../javascript/reference/stacktracelimit-property-error-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [throw Statement](../../javascript/reference/throw-statement-javascript.md)   
 [try...catch...finally Statement](../../javascript/reference/try-dot-dot-dot-catch-dot-dot-dot-finally-statement-javascript.md)   
 [var Statement](../../javascript/reference/var-statement-javascript.md)   
 [Hilo JavaScript sample app (Windows Store)](http://hilojs.codeplex.com/SourceControl/latest)