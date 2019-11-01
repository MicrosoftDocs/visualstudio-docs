---
title: "Conditional compilation is turned off | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1030"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 59a030b0-a6c6-47f2-b90e-c0ed204d5116
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Conditional compilation is turned off
You attempted to use a conditional compilation variable without first turning conditional compilation on. Turning on conditional compilation tells the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] compiler to interpret identifiers beginning with @ as conditional compilation variables. You do this by beginning your conditional code with the statement:  
  
```js
/*@cc_on @*/  
```  
  
### To correct this error  
  
- Add the following statement to the beginning of your conditional code:  
  
    ```JavaScript  
    /*@cc_on @*/  
    ```  
  
## See also  
 [Conditional Compilation](../../javascript/advanced/conditional-compilation-javascript.md)   
 [Conditional Compilation Variables](../../javascript/advanced/conditional-compilation-variables-javascript.md)   
 [@cc_on Statement](../../javascript/reference/at-cc-on-statement-javascript.md)   
 [@if Statement](../../javascript/reference/at-if-statement-javascript.md)   
 [@set Statement](../../javascript/reference/at-set-statement-javascript.md)