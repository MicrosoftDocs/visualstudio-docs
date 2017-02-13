---
title: "Special Error Properties from Asynchronous Windows Runtime Methods | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 45155584-06d8-4e7f-93a6-8564a93f643d
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Special Error Properties from Asynchronous Windows Runtime Methods
It can be difficult to debug asynchronous Windows Runtime methods in JavaScript, because the error may be thrown from somewhere deep in the call stack. The JavaScript `Error` object has extra properties that appear only when the error is thrown from an asynchronous Windows Runtime method when the app is running in debug mode.  
  
## Special Error Properties  
 An error object that results from a failed Windows Runtime asynchronous operation in debug mode has the following special properties:  
  
-   `asyncOpSource` (Object) Gets information about the original location where the call that produced an error was made. The property `asyncOpSource.originatingCall` (String) displays the location in the user’s code that originated the asynchronous operation.  
  
-   asyncOpType (String) Gets the name of the asynchronous operation type that raised the error.  
  
 For more information about errors with asynchronous operations, see:  
  
-   [How to handle errors with promises](https://msdn.microsoft.com/en-us/library/windows/apps/hh700337.aspx)  
  
-   [Troubleshooting Windows Runtime errors](http://msdn.microsoft.com/en-us/1ef7d7df-82ac-441d-8ad0-54ab1318de64)