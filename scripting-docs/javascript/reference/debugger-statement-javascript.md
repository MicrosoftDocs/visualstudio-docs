---
title: "debugger Statement (JavaScript) | Microsoft Docs"
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
  - "debugger_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "debugger statement"
ms.assetid: c6d2e193-c1f7-4fb3-8a4e-cc9823174ae4
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# debugger Statement (JavaScript)
Suspends execution.  
  
## Syntax  
  
```  
debugger  
```  
  
## Remarks  
 You can place `debugger` statements anywhere in procedures to suspend execution. Using the `debugger` statement is similar to setting a breakpoint in the code.  
  
 The `debugger` statement suspends execution, but it does not close any files or clear any variables.  
  
> [!NOTE]
>  The `debugger` statement has no effect unless the script is being debugged.  
  
## Example  
 This example uses the `debugger` statement to suspend execution for each iteration through the `for` loop.  
  
> [!NOTE]
>  To run this example, you must have a script debugger installed and the script must run in debug mode.  
>   
>  Internet Explorer 8 includes the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] debugger. If you are using an earlier version of Internet Explorer, see [How to: Enable and Start Script Debugging from Internet Explorer](http://go.microsoft.com/fwlink/?LinkId=133801).  
  
```javascript  
for(i = 1; i<5; i++) {  
   // Print i to the Output window.  
   Debug.write("loop index is " + i);  
   // Wait for user to resume.  
   debugger  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [JavaScript Statements](../../javascript/reference/javascript-statements.md)   
 [Conditional Compilation](../../javascript/advanced/conditional-compilation-javascript.md)