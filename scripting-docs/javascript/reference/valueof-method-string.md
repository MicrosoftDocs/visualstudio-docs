---
title: "valueOf Method (String) | Microsoft Docs"
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
ms.assetid: dfb55e6b-e38f-4b49-8196-9693f87126a4
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# valueOf Method (String)
Returns the string.  
  
## Syntax  
  
```  
  
string.valueOf()  
```  
  
#### Parameters  
 This method has no parameters.  
  
## Return Value  
 Returns the string value.  
  
## Remarks  
 In the following example, the string object is the same as the return value.  
  
```javascript  
var str = "every good boy does fine";  
var strStr = str.valueOf();  
  
if (str === strStr)  
document.write("same");  
else  
document.write("different");  
  
// Output:  
// same  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]