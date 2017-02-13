---
title: "Using Windows Runtime Asynchronous Methods | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "JavaScript, Windows Runtime asynchronous methods"
ms.assetid: 70756833-44f7-4383-827f-2ac781558082
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Using Windows Runtime Asynchronous Methods
Many Windows Runtime methods, especially methods that might take a long time to complete, are asynchronous. These methods generally return an asynchronous action or operation (for example, `Windows.Foundation.IAsyncAction`, `Windows.Foundation.IAsyncOperation`, `Windows.Foundation.IAsyncActionWithProgress`, or `Windows.Foundation.IAsyncOperationWithProgress`). These methods are represented in JavaScript by the [CommonJS/Promises/A](http://go.microsoft.com/fwlink/p/?LinkId=244434) pattern. That is, they return a Promise object that has a [then](https://msdn.microsoft.com/en-us/library/windows/apps/br229728.aspx) function, for which you must provide a `completed` function that handles the result if the operation succeeds. If you don't want to provide an error handler, you should use the [done](https://msdn.microsoft.com/en-us/library/windows/apps/hh701079.aspx) function instead of the `then` function.  
  
> [!IMPORTANT]
>  Windows Runtime features are not available for apps that run in Internet Explorer.  
  
## Examples of Asynchronous Methods  
 In the following example, the `then` function takes a parameter that represents the completed value of the `createResourceAsync` method.  
  
```javascript  
client.createResourceAsync(uri, description, item)  
    // Success.  
    .then(function(newItem) {   
        console.log("New item is: " + newItem.id);  
            });  
```  
  
 In this case, if the `createResourceAsync` method fails, it returns a promise in the error state, but does not throw an exception. You can handle an error by using the `then` function as follows.  
  
```javascript  
client.createResourceAsync(uri, description, item)  
    // Success.  
    .then(function(newItem) {   
              console.log("New item is: " + newItem.id);  
          }  
          function(err) {  
              console.log("Got error: " + err.message);  
          });  
```  
  
 If you don't want to handle the error explicitly, but do want it to throw an exception, you can use the `done` function instead.  
  
```javascript  
client.createResourceAsync(uri, description, item)  
    // Success.  
      .done(function(newItem) {   
               console.log("New item is: " + newItem.id);  
            });  
```  
  
 You can also display the progress made towards completion by using a third function.  
  
```javascript  
client.createResourceAsync(uri, description, item)  
    // Success.  
      .then(function(newItem) {   
               console.log("New item is: " + newItem.id);  
            },  
    // Error.  
            function(error) {   
               alert("Failed to create a resource.");  
            },  
    // Progress.  
            function(progress, resultSoFar) {   
               setProgressBar(progress);  
            });  
```  
  
 For more information about asynchronous programming, see [Asynchronous Programming in JavaScript](https://msdn.microsoft.com/en-us/library/windows/apps/hh700330.aspx).  
  
## See Also  
 [Using the Windows Runtime in JavaScript](../jswinrt/using-the-windows-runtime-in-javascript.md)