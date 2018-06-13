---
title: "Debug Object (JavaScript) | Microsoft Docs"
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
  - "debug"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Debug object"
  - "Debug object, about Debug object"
ms.assetid: 42a367ec-beb1-4e59-8342-34c326eca042
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug Object (JavaScript)
An intrinsic global object that sends output to a debugger.  
  
## Syntax  
  
```  
Debug.function  
```  
  
## Remarks  
 You do not instantiate the Debug object. You can access all its properties and methods by calling `function`.  
  
 There are different ways to debug Internet Explorer and [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. In [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, the `write` and `writeln` functions of the `Debug` object display strings in the Visual Studio **Output** window at run time. For more information about debugging [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, see [Debug Windows Universal Apps in Visual Studio](/visualstudio/debugger/debugging-windows-store-and-windows-universal-apps).  
  
 To debug Internet Explorer scripts, you must have a script debugger installed and the script must run in debug mode. Internet Explorer 8 and later versions include the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] debugger. If you are using an earlier version of Internet Explorer, see [How to: Enable and Start Script Debugging from Internet Explorer](http://go.microsoft.com/fwlink/?LinkId=133801).  
  
 If the script is not being debugged, the functions have no effect.  
  
## Example  
 This example uses the `write` function to display the value of the variable.  
  
```JavaScript  
var counter = 42;  
Debug.write("The value of counter is " + counter);  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## Constants  
 [Debug Constants](../../javascript/reference/debug-constants.md)  
  
## Properties  
 [Debug.debuggerEnabled Property](../../javascript/reference/debug-debuggerenabled-property.md) &#124; [Debug.setNonUserCodeExceptions Property](../../javascript/reference/debug-setnonusercodeexceptions-property.md)  
  
## Functions  
 [Debug.msTraceAsyncCallbackStarting Function](../../javascript/reference/debug-mstraceasynccallbackstarting-function.md) &#124; [Debug.msTraceAsyncCallbackCompleted Function](../../javascript/reference/debug-mstraceasynccallbackcompleted-function.md) &#124; [Debug.msTraceAsyncOperationCompleted Function](../../javascript/reference/debug-mstraceasyncoperationcompleted-function.md) &#124; [Debug.msTraceAsyncOperationStarting Function](../../javascript/reference/debug-mstraceasyncoperationstarting-function.md) &#124; [Debug.msUpdateAsyncCallbackRelation Function](../../javascript/reference/debug-msupdateasynccallbackrelation-function.md) &#124; [Debug.write Function](../../javascript/reference/debug-write-function-javascript.md) &#124; [Debug.writeln Function](../../javascript/reference/debug-writeln-function-javascript.md)  
  
## See Also  
 [debugger Statement](../../javascript/reference/debugger-statement-javascript.md)