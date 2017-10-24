---
title: "includes Method (String) (JavaScript) | Microsoft Docs"
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
ms.assetid: 2639e4e5-23ba-424a-80ea-be067a4cd65e
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# includes Method (String) (JavaScript)
Returns a Boolean value that indicates whether the passed in string is contained in the string object.  
  
## Syntax  
  
```  
stringObj.includes(substring [, position]);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object to test against.  
  
 `substring`  
 Required. The string to test.  
  
 `position`  
 Optional. The position of the first character to test against in the string object, starting with 0.  
  
## Return Value  
 If the passed in string is contained in the string object, the `includes` method returns `true`; otherwise, it returns `false`.  
  
## Remarks  
  
## Example  
  
```JavaScript  
// Returns true   
"abcde".includes("cd")  
"abcde".includes("cd", 2)  
  
// Returns false  
"abcde".includes("CD")  
"abcde".includes("cd", 3)  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]