---
title: "message Property (Error) (JavaScript) | Microsoft Docs"
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
  - "message"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Message property"
ms.assetid: 8cab0392-e0db-4714-827c-47ab04e8b4f2
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# message Property (Error) (JavaScript)
Returns an error message string.  
  
## Syntax  
  
```  
  
errorObj.message  
```  
  
## Parameters  
 `errorObj`  
 Required. Instance of `Error` object.  
  
## Remarks  
 The `message` property returns a string that contains an error message associated with a specific error.  
  
 The `description` and `message` properties provide the same functionality. The `description` property provides backwards compatibility; the `message` property complies with the ECMA standard.  
  
## Example  
 The following example causes a TypeError exception to be thrown and displays the name of the error and its message.  
  
```JavaScript  
try  
{  
    // Cause an error.  
    var x = y;  
}  
catch(e)  
{  
    document.write ("Error Message: " + e.message);  
    document.write ("<br />");  
    document.write ("Error Code: ");  
    document.write (e.number & 0xFFFF)  
    document.write ("<br />");  
    document.write ("Error Name: " + e.name);  
}  
```  
  
## Example  
 The output of this code is as follows.  
  
```JavaScript  
Error Message: 'y' is undefined  
Error Code: 5009  
Error Name: TypeError  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [description Property (Error)](../../javascript/reference/description-property-error-javascript.md)   
 [name Property (Error)](../../javascript/reference/name-property-error-javascript.md)