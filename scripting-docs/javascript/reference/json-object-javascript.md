---
title: "JSON Object (JavaScript) | Microsoft Docs"
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
  - "JSON"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "JSON object"
ms.assetid: 0279a0e0-70bf-451a-a78e-0da4e2fdeb9a
caps.latest.revision: 43
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JSON Object (JavaScript)
An intrinsic object that provides functions to convert [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] values to and from the JavaScript Object Notation (JSON) format. The `JSON.stringify` function serializes a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] value to JSON text. The `JSON.parse` function deserializes JSON text to produce a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] value.  
  
## Syntax  
  
```  
  
JSON.[method]  
  
```  
  
## Parameters  
 `Method`  
 Required. Name of one of the methods of the `JSON` object.  
  
## Remarks  
 You cannot create a `JSON` object by using the `new` operator. An error occurs if you try to do this. However, you can override or modify the `JSON` object.  
  
 The scripting engine creates the `JSON` object when the engine is loaded. Its methods are available to your script at all times.  
  
 To use the intrinsic `JSON` object, make sure that you do not override it with another `JSON` object that is defined in your script. You may need to modify existing script statements that detect the presence of a `JSON` object because those statements will evaluate differently. This is demonstrated in the following example.  
  
```javascript  
if (!this.JSON) {  
    // JSON object does not exist.  
    }  
```  
  
 In the previous example, `!this.JSON` evaluates to false in [!INCLUDE[jsv58text](../../javascript/reference/includes/jsv58text-md.md)]. Therefore, the code inside the `if` statement does not execute.  
  
## Functions  
 [JSON.parse Function](../../javascript/reference/json-parse-function-javascript.md)  
  
 [JSON.stringify Function](../../javascript/reference/json-stringify-function-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv58](../../javascript/reference/includes/jsv58-md.md)]  
  
## See Also  
 [toJSON Method (Date)](../../javascript/reference/tojson-method-date-javascript.md)   
 [JavaScript Objects](../../javascript/reference/javascript-objects.md)   
 [Hub template sample app (Windows Store)](http://code.msdn.microsoft.com/Hub-template-sample-with-4b70002d)