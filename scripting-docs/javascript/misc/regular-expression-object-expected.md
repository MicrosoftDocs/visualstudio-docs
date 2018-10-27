---
title: "Regular expression object expected | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5016"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: e226096c-c58f-4bcb-a71e-fa32ce474b67
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Regular expression object expected
You attempted to invoke the **RegExp.prototype.toString** or **RegExp.prototype.valueOf** method on an object of a type other than `RegExp`. The object of this type of invocation must be of type `RegExp`.  
  
### To correct this error  
  
-   Only invoke the **RegExp.prototype.toString** or **RegExp.prototype.valueOf** methods on objects of type `RegExp`.  
  
## See Also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](https://msdn.microsoft.com/library/1400241x)