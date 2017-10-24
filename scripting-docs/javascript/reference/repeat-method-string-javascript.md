---
title: "repeat Method (String) (JavaScript) | Microsoft Docs"
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
ms.assetid: fe02cdfd-f0f6-45a2-ad36-31c4300ef142
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# repeat Method (String) (JavaScript)
Returns a new string object with a value equal to the original string repeated the specified number of times.  
  
## Syntax  
  
```  
stringObj.repeat(count);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object.  
  
 `count`  
 Required. The number of times to repeat the original string in the returned string.  
  
## Exceptions  
 This method throws a RangeError if and only if the argument is negative or +Infinity.  
  
## Remarks  
 The `repeat` method concatenates the original string to the new string the number of times specified by `count`.  
  
 This method throws an error if `count` is not a positive number less than `Infinity`.  
  
## Example  
  
```JavaScript  
"abc".repeat(3); // Returns "abcabcabc"  
"abc".repeat(0); // Returns an empty string.  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]