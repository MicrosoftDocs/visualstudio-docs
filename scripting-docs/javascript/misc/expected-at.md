---
title: "Expected '@' | Microsoft Docs"
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
  - "VS.WebClient.Help.SCRIPT1032"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 82ff8b74-1710-4358-9a26-dc92ab29c53b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected '@'
You attempted to create a variable to be used with conditional compilation statements using the `@set` statement, but did not place an at sign "**@**" before the variable name.  
  
### To correct this error  
  
-   Add an at sign "**@**" immediately before the variable name. For example:  
  
    ```JavaScript  
    @set @myvar = 1  
    ```  
  
## See Also  
 [@set Statement](../../javascript/reference/at-set-statement-javascript.md)   
 [Conditional Compilation](../../javascript/advanced/conditional-compilation-javascript.md)   
 [Conditional Compilation Variables](../../javascript/advanced/conditional-compilation-variables-javascript.md)