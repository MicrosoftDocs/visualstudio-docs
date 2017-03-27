---
title: "description Property (Error) (JavaScript) | Microsoft Docs"
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
  - "Description"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "error handling, error description"
  - "Description property"
  - "errors, description"
ms.assetid: ea727f1e-2041-4400-965c-67e6d47a1ff0
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# description Property (Error) (JavaScript)
Returns or sets the descriptive string associated with a specific error.  
  
## Syntax  
  
```  
  
object  
.description [= stringExpression]  
```  
  
## Parameters  
 *object*  
 Required. Any instance of an `Error` object.  
  
 `stringExpression`  
 Optional. A string expression containing a description of the error.  
  
## Remarks  
 The **description** property contains the error message string associated with a specific error. Use the value contained in this property to alert a user to an error.  
  
 The **description** and **message** properties provide the same functionality; the **description** property provides backward compatibility; the **message** property complies with the ECMA standard.  
  
## Example  
 The following example illustrates the use of the **description** property.  
  
```JavaScript  
try  
{  
// Cause an error:  
    x = y     
}  
catch(e)  
{  
// Prints "[object Error]":  
    document.write(e)  
    document.write (" ");  
// Prints 5009:  
    document.write((e.number & 0xFFFF))    
    document.write (" ");  
// Prints "'y' is undefined":  
    document.write(e.description);  
    document.write (" ");  
// Prints "'y' is undefined":  
    document.write(e.message)  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [number Property (Error)](../../javascript/reference/number-property-error-javascript.md)   
 [message Property (Error)](../../javascript/reference/message-property-error-javascript.md)   
 [name Property (Error)](../../javascript/reference/name-property-error-javascript.md)