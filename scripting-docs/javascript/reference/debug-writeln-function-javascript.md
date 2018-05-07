---
title: "Debug.writeln Function (JavaScript) | Microsoft Docs"
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
  - "writeln"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "writeIn method"
ms.assetid: c3aad0cd-0486-4161-9ba6-31d672da72af
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.writeln Function (JavaScript)
Sends strings to the script debugger, followed by a newline character.  
  
## Syntax  
  
```  
  
Debug.writeln([str1 [, str2 [, ... [, strN]]]])  
```  
  
## Parameters  
 *str1, str2, ... , strN*  
 Optional. Strings to send to the script debugger.  
  
## Remarks  
 The `Debug.writeln` function sends strings, followed by a newline character, to the Immediate window of the Microsoft Script Debugger at run time. If the script is not being debugged, the `Debug.writeln` function has no effect.  
  
 The `Debug.writeln` function is almost identical to the `Debug.write` function. The only difference is that the `Debug.write` function does not send a newline character after sending the strings.  
  
## Example  
 This example uses the `Debug.writeln` function to display the value of the variable in the Immediate window of the Microsoft Script Debugger.  
  
> [!NOTE]
>  To run this example, you must have a script debugger installed and the script must run in debug mode.  
>   
>  Internet Explorer 8 includes the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] debugger. If you are using an earlier version of Internet Explorer, see [How to: Enable and Start Script Debugging from Internet Explorer](http://go.microsoft.com/fwlink/?LinkId=133801).  
  
```JavaScript  
var counter = 42;  
Debug.writeln("The value of counter is " + counter);  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Debug Object](../../javascript/reference/debug-object-javascript.md)  
  
## See Also  
 [Debug.write Function](../../javascript/reference/debug-write-function-javascript.md)