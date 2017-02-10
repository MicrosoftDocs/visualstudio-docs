---
title: "stackTraceLimit Property (Error) (JavaScript) | Microsoft Docs"
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
  - "Error.stackTraceLimit"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "error stack track limit [JavaScript]"
  - "JavaScript error stack"
  - "error stack [JavaScript]"
  - "JavaScript stack trace limit"
ms.assetid: 127ef8e8-892e-4263-9ebc-03364af01212
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# stackTraceLimit Property (Error) (JavaScript)
Gets or sets the stack trace limit, which is equivalent to the number of error frames to display. The default limit is 10.  
  
## Syntax  
  
```  
  
Error  
.stackTraceLimit   
```  
  
## Remarks  
 You can set the `stackTraceLimit` property to any positive value between 0 and `Infinity`. If the `stackTraceLimit` property is set to 0 at the time an error is thrown, no stack trace is shown. If the property is set to a negative value or a non-numeric value, the value is converted to 0. If the stackTraceLimit is set to `Infinity`, the entire stack is shown. Otherwise, `ToUint32` is used to convert the value.  
  
## Example  
 The following example shows how to set and then get the stack trace limit.  
  
```javascript  
try  
    {  
    var err = new Error("my error");  
    Error.stackTraceLimit = 7;  
    throw err;  
    }  
catch(e)  
    {  
    document.write ("Error stack trace limit: ")  
    document.write (Error.stackTraceLimit);  
    }  
```  
  
## Requirements  
 Supported in Internet Explorer 10 and in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [description Property (Error)](../../javascript/reference/description-property-error-javascript.md)   
 [message Property (Error)](../../javascript/reference/message-property-error-javascript.md)   
 [name Property (Error)](../../javascript/reference/name-property-error-javascript.md)   
 [stack Property (Error)](../../javascript/reference/stack-property-error-javascript.md)