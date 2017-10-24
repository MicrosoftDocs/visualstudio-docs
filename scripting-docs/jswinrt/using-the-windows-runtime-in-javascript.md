---
title: "Using the Windows Runtime in JavaScript | Microsoft Docs"
ms.custom: ""
ms.date: "02/03/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "JavaScript, Windows Runtime"
ms.assetid: 90658546-f746-4e34-a7d1-71cf9ee322a2
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Using the Windows Runtime in JavaScript
When you write a Universal Windows Platform (UWP) app, you can use Windows Runtime classes, methods, and properties in much the same way that you would use native JavaScript objects, methods, and properties. This topic provides introductory information and links to topics that explain the basic concepts of using Windows Runtime APIs in JavaScript, including an explanation of how Windows Runtime types are represented, how to use asynchronous Windows Runtime methods, and how to listen to and handle Windows Runtime events.  
  
 You can find JavaScript reference documentation at [JavaScript Language Reference](../javascript/javascript-language-reference.md).  
  
> [!IMPORTANT]
>  Windows Runtime features are not available for apps that run in Internet Explorer.  
  
## Windows Runtime Reference Documentation  
 For reference documentation, see [Windows Runtime Reference](https://msdn.microsoft.com/en-us/library/windows/apps/br211377.aspx). Code examples are available in JavaScript and also in C++, C#, and Visual Basic.  
  
## Writing Windows Runtime Components in C++, C#, or Visual Basic  
 For instructions and guidelines for writing Windows Runtime components that can be consumed in JavaScript, see [Creating Windows Runtime Components in C++](/windows/uwp/winrt-components/creating-windows-runtime-components-in-cpp) and [Creating Windows Runtime Components in C# and Visual Basic](/windows/uwp/winrt-components/creating-windows-runtime-components-in-csharp-and-visual-basic).  
  
## Casing Conventions with Windows Runtime Features  
 Casing conventions for Windows Runtime features in JavaScript differ slightly from those for other languages:  
  
-   Namespaces and classes are in Pascal case:  
  
    ```JavaScript  
    Windows.Deployment.PackageInfo;  
    ```  
  
-   Members of classes, including methods and properties, and members of structures and enumerations, are in camel case:  
  
    ```JavaScript  
    Deployment.PackageInfo.createPackage();  
    ```  
  
-   Event names are in lower case:  
  
    ```JavaScript  
    dataTransferManager.ontargetapplicationchosen;  
    ```  
  
## See Also  
 [Considerations when Using the Windows Runtime API](../jswinrt/considerations-when-using-the-windows-runtime-api.md)   
 [Using Windows Runtime Asynchronous Methods](../jswinrt/using-windows-runtime-asynchronous-methods.md)   
 [Handling Windows Runtime Events in JavaScript](../jswinrt/handling-windows-runtime-events-in-javascript.md)   
 [JavaScript Representation of Windows Runtime Types](../jswinrt/javascript-representation-of-windows-runtime-types.md)   
 [JavaScript Projection of Windows Runtime DateTime and TimeSpan](../jswinrt/windows-runtime-datetime-and-timespan-representations.md)