---
title: "Number.isFinite Function (Number) (JavaScript) | Microsoft Docs"
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
ms.assetid: 41a91408-09d1-49f2-b7a0-6da105e2ed8e
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Number.isFinite Function (Number) (JavaScript)
Returns a Boolean value that indicates whether a value is a finite number.  
  
## Syntax  
  
```  
Number.isFinite(numValue)   
```  
  
## Return Value  
 `false` if the value is `NaN`, `+∞`, or `-∞`; otherwise `true`.  
  
## Remarks  
  
## Example  
  
```javascript  
// Returns true  
Number.isFinite(100)  
Number.isFinite(-100)  
Number.isFinite(100 / 3)  
  
// Returns false  
Number.isFinite(Number.NaN)  
Number.isFinite(Infinity)  
Number.isFinite("100")  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)