---
title: "Math.sign Function (JavaScript) | Microsoft Docs"
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
ms.assetid: 8b462020-ceff-4947-8dd1-c78e6aff8d98
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.sign Function (JavaScript)
Returns the sign of a number, indicating whether the number is positive, negative, or 0.  
  
## Syntax  
  
```  
Math.sign(number)  
```  
  
## Remarks  
 The required `number` argument is a numeric expression for which the sign is needed.  
  
 The return value is one of the following:  
  
-   `NaN`, if `number` is `NaN`.  
  
-   -0, if `number` is -0.  
  
-   +0, if `number` is +0.  
  
-   -1, if `number` is negative and not -0.  
  
-   +1, if `number` is positive and not +0.  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]