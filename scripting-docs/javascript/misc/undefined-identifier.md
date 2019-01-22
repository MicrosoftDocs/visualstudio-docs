---
title: "Undefined identifier | Microsoft Docs"
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
  - "VS.WebClient.Help.SCRIPT5009"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 8c8000d9-dd14-487e-922d-98430024a0f6
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Undefined identifier
You attempted to use an identifier that the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] compiler does not recognize. The undefined value is returned whenever you use:  
  
-   a variable that does not exist,  
  
-   a variable that has been declared, but never had a value assigned to it,  
  
-   an object property that does not exist.  
  
### To correct this error  
  
-   Declare the variable with a **var** statement (as in `var` x;).  
  
## See Also  
 [Variables](../../javascript/variables-javascript.md)   
 [Variable Scope](../../javascript/advanced/variable-scope-javascript.md)