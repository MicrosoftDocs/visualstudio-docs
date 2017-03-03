---
title: "Debug.write Function (JavaScript) | Microsoft Docs"
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
  - "Write"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "write method [JavaScript]"
ms.assetid: fd1cfbb3-46cb-47cc-896c-a70d457dd413
caps.latest.revision: 22
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.write Function (JavaScript)
Sends strings to the script debugger.  
  
## Syntax  
  
```  
  
Debug.write([str1 [, str2 [, ... [, strN]]]])  
```  
  
## Parameters  
 *str1, str2, ... , strN*  
 Optional. Strings to send to the script debugger.  
  
## Remarks  
 The `Debug.write` function sends strings to the Immediate window of a script debugger at run time. If the script is not being debugged, the `Debug.write` function has no effect.  
  
 The `Debug.write` function is almost identical to the `Debug.writeln` function. The only difference is that the `Debug.writeln` function sends a newline character after the strings are sent.  
  
## Example  
 This example uses the `Debug.write` function to display the value of the variable in the Immediate window of the script debugger.  
  
> [!NOTE]
>  To run this example, you must have a script debugger installed and the script must run in debug mode.  
>   
>  Internet Explorer 8 includes the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] debugger. If you are using an earlier version of Internet Explorer, see [How to: Enable and Start Script Debugging from Internet Explorer](http://go.microsoft.com/fwlink/?LinkId=133801).  
  
```javascript  
var counter = 42;  
Debug.write("The value of counter is " + counter);  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Debug Object](../../javascript/reference/debug-object-javascript.md)  
  
## See Also  
 [Debug.writeln Function](../../javascript/reference/debug-writeln-function-javascript.md)