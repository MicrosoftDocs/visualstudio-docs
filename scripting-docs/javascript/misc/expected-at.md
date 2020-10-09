---
title: "Expected '@' | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: error-reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1032"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 82ff8b74-1710-4358-9a26-dc92ab29c53b
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected '\@'
You attempted to create a variable to be used with conditional compilation statements using the `@set` statement, but did not place an at sign "**@**" before the variable name.  
  
### To correct this error  
  
- Add an at sign "**@**" immediately before the variable name. For example:  
  
    ```JavaScript  
    @set @myvar = 1  
    ```  
  
## See also  
 [@set Statement](https://developer.mozilla.org/docs/Archive/Web/JavaScript/Microsoft_Extensions/at-set)   
 [Conditional Compilation](/previous-versions/windows/internet-explorer/ie-developer/scripting-articles/121hztk3(v=vs.84))   
 [Conditional Compilation Variables](/previous-versions/windows/internet-explorer/ie-developer/scripting-articles/s59bkzce(v=vs.84))