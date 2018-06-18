---
title: "Handling Windows Runtime Events in JavaScript | Microsoft Docs"
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
  - "JavaScript, Windows Runtime events"
  - "Windows Runtime events [JavaScript]"
ms.assetid: d9436aff-2c30-4846-b8df-eaa3e63fd75c
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Handling Windows Runtime Events in JavaScript
Windows Runtime events are not represented in the same way in JavaScript as they are in C++ or the .NET Framework. They are not class properties, but rather are represented as string identifiers that are passed to the class's `addEventListener` and `removeEventListener` methods. For example, you can add an event handler for the [Geolocator.PositionChanged](https://msdn.microsoft.com/library/windows/apps/xaml/windows.devices.geolocation.geolocator.positionchanged.aspx) event by passing the string "positionchanged" to the `Geolocator.addEventListener` method:  
  
```JavaScript  
var locator = new Windows.Devices.Geolocation.Geolocator();  
locator.addEventListener(  
    "positionchanged",   
     function (ev) {  
        console.log("Got event");  
    });  
```  
  
 You can also set the `locator.onpositionchanged` property.  
  
```JavaScript  
locator.onpositionchanged =    
    function (ev) {  
        console.log("Got event");  
    };  
```  
  
 In JavaScript, Windows Runtime event arguments are represented as a single event object. In the following example of an event handler method, the `ev` parameter is an object that contains both the sender (the target property) and the other event arguments. The event arguments are the ones that are documented for each event.  
  
```JavaScript  
function (ev) {  
    console.log("Target: " + ev.target);  
    console.log("Position: " +  
        ev.position.latitude + "," +  
        ev.position.longitude);  
};  
  
```  
  
> [!IMPORTANT]
>  Windows Runtime features are not available for apps that run in Internet Explorer.  
  
## See Also  
 [Using the Windows Runtime in JavaScript](../jswinrt/using-the-windows-runtime-in-javascript.md)