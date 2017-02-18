---
title: "name Property (Error) (JavaScript) | Microsoft Docs"
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
  - "name"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Name property"
  - "name property, error name"
ms.assetid: 94df2d6b-f1a1-4931-a956-0a930cb87f76
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# name Property (Error) (JavaScript)
Returns the name of an error.  
  
## Syntax  
  
```  
  
errorObj.  
name  
  
```  
  
## Parameters  
 `errorObj`  
 Required. Instance of `Error` object.  
  
## Remarks  
 The **name** property returns the name or exception type of an error. When a runtime error occurs, the name property is set to one of the following native exception types:  
  
|Exception Type|Meaning|  
|--------------------|-------------|  
|ConversionError|This error occurs whenever there is an attempt to convert an object into something to which it cannot be converted.|  
|RangeError|This error occurs when a function is supplied with an argument that has exceeded its allowable range. For example, this error occurs if you attempt to construct an `Array` object with a length that is not a valid positive integer.|  
|ReferenceError|This error occurs when an invalid reference has been detected. This error will occur, for example, if an expected reference is `null`.|  
|RegExpError|This error occurs when a compilation error occurs with a regular expression. Once the regular expression is compiled, however, this error cannot occur. This example will occur, for example, when a regular expression is declared with a pattern that has an invalid syntax, or flags other than **i**, **g**, or **m**, or if it contains the same flag more than once.|  
|SyntaxError|This error occurs when source text is parsed and that source text does not follow correct syntax. This error will occur, for example, if the `eval` function is called with an argument that is not valid program text.|  
|TypeError|This error occurs whenever the actual type of an operand does not match the expected type. An example of when this error occurs is a function call made on something that is not an object or does not support the call.|  
|URIError|This error occurs when an illegal Uniform Resource Indicator (URI) is detected. For example, this is error occurs when an illegal character is found in a string being encoded or decoded.|  
  
## Example  
 The following example causes a TypeError exception to be thrown and displays the name of the error and its message.  
  
```javascript  
try  
{  
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
  
```javascript  
Error Message: 'y' is undefined  
Error Code: 5009  
Error Name: TypeError  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Error Object](../../javascript/reference/error-object-javascript.md)  
  
## See Also  
 [description Property (Error)](../../javascript/reference/description-property-error-javascript.md)   
 [message Property (Error)](../../javascript/reference/message-property-error-javascript.md)   
 [number Property (Error)](../../javascript/reference/number-property-error-javascript.md)