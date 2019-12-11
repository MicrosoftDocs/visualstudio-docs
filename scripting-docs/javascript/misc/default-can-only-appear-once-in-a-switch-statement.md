---
title: "'default' can only appear once in a 'switch' statement | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1027"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: a94100f4-6ee5-4759-b635-9d309e47111e
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# 'default' can only appear once in a 'switch' statement
You attempted to use the **default** statement more than once within a switch statement. The default case is always the last case statement in a switch statement (it is the fall-through case).  
  
### To correct this error  
  
- Remove any extra **default** case statements from your `switch` statement (use at most one default case statement in your switch statement).  
  
## See also  
 [switch Statement](../../javascript/reference/switch-statement-javascript.md)   
 [Controlling Program Flow](../../javascript/controlling-program-flow-javascript.md)   
 [JavaScript Reserved Words](../../javascript/reference/javascript-reserved-words.md)