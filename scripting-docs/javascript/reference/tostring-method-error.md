---
title: "toString Method (Error) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 5d6d9712-c06d-4b31-9bc9-e46f6bb5cd38
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toString Method (Error)
Returns a string representation of an error.  
  
## Syntax  
  
```  
  
error.toString()  
```  
  
## Parameters  
 `date`  
 Required. The error to represent as a string.  
  
## Return Value  
 Returns "Error: " plus the error message.  
  
## Example  
 The following example illustrates the use of the `toString` method with an error.  
  
```JavaScript  
var myError = new Error();  
myError.message = "My Error";  
var errorString = myError.toString();  
document.write(errorString);  
  
// Output: Error: My Error  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]