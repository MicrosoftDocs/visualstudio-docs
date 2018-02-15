---
title: "Enumerator Object (JavaScript) | Microsoft Docs"
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
  - "Enumerator"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Enumerator object"
ms.assetid: 63f03c21-d58c-47db-a728-4d8d88b0a422
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Enumerator Object (JavaScript)
Enables enumeration of items in a collection.  
  
> [!WARNING]
>  This object is supported in Internet Explorer only, not in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## Syntax  
  
```  
  
enumObj = new Enumerator([collection])   
```  
  
## Parameters  
 `enumObj`  
 Required. The variable name to which the `Enumerator` object is assigned.  
  
 `collection`  
 Optional. Any Collection object.  
  
## Remarks  
 Collections differ from arrays in that the members of a collection are not directly accessible. Instead of using indexes, as you would with arrays, you can move the current item pointer only to the first or next element of a collection.  
  
 The `Enumerator` object provides a way to access any member of a collection and behaves similarly to the `For...Each` statement in VBScript.  
  
## Example  
 The following code shows the usage of the `Enumerator` object:  
  
```JavaScript  
var bytesPerGB = 1024 * 1024 * 1024;  
  
var fso = new ActiveXObject("Scripting.FileSystemObject");  
  
document.write(fso.Drives);  
var e = new Enumerator(fso.Drives);  
  
var driveString = "";  
  
e.moveFirst();  
while (e.atEnd() == false)  
{  
    var drv = e.item();  
  
    driveString += drv.Path + " - ";  
  
    if (drv.IsReady){  
        var freeGB = drv.FreeSpace / bytesPerGB;  
        var totalGB = drv.TotalSize / bytesPerGB;  
  
        driveString += freeGB.toFixed(3) + " GB free of ";  
        driveString += totalGB.toFixed(3) + " GB";  
    }  
    else{  
        driveString += "Not Ready";  
    }  
  
    driveString += "<br />";;  
  
    e.moveNext();  
}  
document.write(driveString);  
  
// Output: <drive information  
  
```  
  
## Properties  
 The `Enumerator` object has no properties.  
  
## Methods  
 [atEnd Method](../../javascript/reference/atend-method-enumerator-javascript.md) &#124; [item Method](../../javascript/reference/item-method-enumerator-javascript.md) &#124; [moveFirst Method](../../javascript/reference/movefirst-method-enumerator-javascript.md) &#124; [moveNext Method](../../javascript/reference/movenext-method-enumerator-javascript.md)  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
## See Also  
 [Boolean Object](../../javascript/reference/boolean-object-javascript.md)