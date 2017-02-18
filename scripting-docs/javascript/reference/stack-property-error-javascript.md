---
title: "stack Property (Error) (JavaScript) | Microsoft Docs"
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
  - "Error.stack"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "JavaScript error stack"
  - "error stack [JavaScript]"
ms.assetid: 1dc21fdd-853c-4664-bf1c-24eb1f6f2daf
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# stack Property (Error) (JavaScript)
Gets or sets the error stack as a string that contains the stack trace frames.  
  
## Syntax  
  
```  
  
object  
.stack   
```  
  
## Remarks  
 The `stack` property is set to `undefined` when the error is constructed, and gets the trace information when the error is raised. If an error is raised multiple times, the `stack` property is updated each time the error is raised.  
  
 Stack frames are displayed in the following format: **at FunctionName (\<Fully-qualified name/URL>:\<line number>:\<column number>)**  
  
 If you create your own Error object and set the stack trace to a value, the value won't be overwritten when the error is thrown.  
  
 The `stack` property does not show inline functions in its frames. It shows only the physical stack.  
  
## Example  
 The following example shows how to get the stack when you're catching an error.  
  
```javascript  
try  
    {  
        var x = y.name;  
    }  
catch(e)  
    {  
        document.write ("Error stack: ")  
        document.write (e.stack);  
    }  
```  
  
## Example  
 The following example shows how to set and then get the stack.  
  
```javascript  
try  
    {  
        var err = Error("my error");  
        err.stack = "my stack trace";  
        throw err;  
    }  
catch(e)  
    {  
        document.write ("Error stack: ")  
        document.write (e.stack);  
    }  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [description Property (Error)](../../javascript/reference/description-property-error-javascript.md)   
 [message Property (Error)](../../javascript/reference/message-property-error-javascript.md)   
 [name Property (Error)](../../javascript/reference/name-property-error-javascript.md)   
 [stackTraceLimit Property (Error)](../../javascript/reference/stacktracelimit-property-error-javascript.md)