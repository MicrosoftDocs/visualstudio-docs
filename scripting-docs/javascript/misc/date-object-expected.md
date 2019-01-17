---
title: "Date object expected | Microsoft Docs"
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
  - "VS.WebClient.Help.SCRIPT5006"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: d6ab82e6-ca64-46b4-a06c-5c6b0aa057cb
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Date object expected
You attempted to invoke the **Date.prototype.toString** or **Date.prototype.valueOf** method on an object of a type other than `Date`. The object of this type of invocation must be of type `Date`. For example:  
  
```JavaScript  
var o = new Object;  
o.f = Date.prototype.toString;  
o.f();  
```  
  
### To correct this error  
  
-   Only invoke the **Date.prototype.toString** or **Date.prototype.valueOf** methods on objects of type `Date`.  
  
## See Also  
 [Date Object](../../javascript/reference/date-object-javascript.md)   
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)   
 [Intrinsic Objects](../../javascript/intrinsic-objects-javascript.md)