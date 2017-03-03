---
title: "number Property (Error) (JavaScript) | Microsoft Docs"
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
  - "Number"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Number property"
ms.assetid: 8697e20b-a2b0-4e26-85c0-ab07ddfe8281
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# number Property (Error) (JavaScript)
Returns or sets the numeric value associated with a specific error. The `Error` object's default property is **number**.  
  
## Syntax  
  
```  
  
object  
.number [= errorNumber]  
```  
  
## Parameters  
 *Object*  
 Any instance of the `Error` object.  
  
 *errorNumber*  
 An integer representing an error.  
  
## Remarks  
 An error number is a 32-bit value. The upper 16-bit word is the facility code, and the lower word is the error code. To determine the error code, use the `&` (bitwise And) operator to combine the number property with the hexadecimal number `0xFFFF`.  
  
## Example  
 The following example causes an exception to be thrown and displays the error code that is derived from the error number.  
  
```javascript  
try  
    {  
    // Cause an error.  
    var x = y;  
    }  
catch(e)  
    {  
    document.write ("Error Code: ");  
    document.write (e.number & 0xFFFF)  
    document.write ("<br />");  
  
    document.write ("Facility Code: ")  
    document.write(e.number>>16 & 0x1FFF)  
    document.write ("<br />");  
  
    document.write ("Error Message: ")  
    document.write (e.message)  
    }  
```  
  
## Example  
 The output of this code is as follows.  
  
```javascript  
Error Code: 5009  
Facility Code: 10  
Error Message: 'y' is undefined  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [description Property (Error)](../../javascript/reference/description-property-error-javascript.md)   
 [message Property (Error)](../../javascript/reference/message-property-error-javascript.md)   
 [name Property (Error)](../../javascript/reference/name-property-error-javascript.md)