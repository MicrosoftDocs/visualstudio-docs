---
title: "Math.clz32 Function (JavaScript) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: 34615d7a-6d88-4ab5-a696-7e496caa51db
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.clz32 Function (JavaScript)
Returns the number of leading zero bits in the 32-bit binary representation of a number.  
  
## Syntax  
  
```  
  
Math.clz32(  
number  
)   
```  
  
## Remarks  
 If `number` is 0, the result will be 32. If the most significant bit of the 32-bit binary encoding of `number` is 1, the result will be 0.  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)