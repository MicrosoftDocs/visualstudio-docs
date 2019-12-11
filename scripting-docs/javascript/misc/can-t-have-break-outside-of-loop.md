---
title: "Can't have 'break' outside of loop | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1019"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 11d02172-2a78-4705-a730-d21111db5f42
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Can't have 'break' outside of loop
You attempted to use the **break** keyword outside of a loop. The **break** keyword is used to terminate a loop or `switch` statement. It must be embedded in the body of a loop or `switch` statement. However, a **label** can follow the break keyword.  
  
```js
break labelname;  
```  
  
 You only need the labeled form of the **break** keyword when you are using nested loops or `switch` statements and need to break out of a loop that is not the innermost one.  
  
### To correct this error  
  
- Make sure the **break** keyword appears inside an enclosing loop or switch statement.  
  
## See also  
 [break Statement](../../javascript/reference/break-statement-javascript.md)   
 [Controlling Program Flow](../../javascript/controlling-program-flow-javascript.md)   
 [Troubleshooting Your Scripts](../../javascript/advanced/troubleshooting-your-scripts-javascript.md)