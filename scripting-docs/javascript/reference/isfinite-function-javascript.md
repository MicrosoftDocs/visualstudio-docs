---
title: "isFinite Function (JavaScript) | Microsoft Docs"
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
  - "isFinite"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "finite numbers"
  - "isFinite method"
ms.assetid: ea9287d2-892f-496b-86b7-f9196868d5cf
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# isFinite Function (JavaScript)
Determines whether a supplied number is finite.  
  
## Syntax  
  
```  
isFinite(number)   
```  
  
## Remarks  
 The required `number` argument is any numeric value.  
  
 The `isFinite` function returns `true` if `number` is any value other than `NaN`, negative infinity, or positive infinity. In those three cases, it returns **false**.  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## See Also  
 [isNaN Function](../../javascript/reference/isnan-function-javascript.md)