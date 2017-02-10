---
title: "moveNext Method (Enumerator) (JavaScript) | Microsoft Docs"
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
  - "moveNext"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "MoveNext method"
ms.assetid: 59aa339b-f375-450a-8276-37896a55a824
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# moveNext Method (Enumerator) (JavaScript)
Moves the current item to the next item in the collection.  
  
> [!WARNING]
>  This object is supported in Internet Explorer only.  
  
## Syntax  
  
```  
  
enumObj.moveNext( )   
```  
  
## Remarks  
 The required *enumObj* reference is any `Enumerator` object.  
  
 If the enumerator is at the end of the collection or the collection is empty, the current item is set to undefined.  
  
## Example  
 In following example, the **moveNext** method is used to move to the next drive in the `Drives` collection:  
  
```javascript  
function ShowDrives()  
{  
    var s = "";  
    var bytesPerGB = 1024 * 1024 * 1024;  
  
    var fso = new ActiveXObject("Scripting.FileSystemObject");  
    var e = new Enumerator(fso.Drives);  
  
    e.moveFirst();  
    while (e.atEnd() == false)  
    {  
        var drv = e.item();  
  
        s += drv.Path + " - ";  
  
        if (drv.IsReady)  
        {  
            var freeGB = drv.FreeSpace / bytesPerGB;  
            var totalGB = drv.TotalSize / bytesPerGB;  
  
            s += freeGB.toFixed(3) + " GB free of ";  
            s += totalGB.toFixed(3) + " GB";  
        }  
        else  
        {  
            s += "Not Ready";  
        }  
  
        s += "<br />";  
  
        e.moveNext();  
    }  
    return(s);  
}  
```  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
 **Applies To**: [Enumerator Object](../../javascript/reference/enumerator-object-javascript.md)  
  
## See Also  
 [atEnd Method (Enumerator)](../../javascript/reference/atend-method-enumerator-javascript.md)   
 [item Method (Enumerator)](../../javascript/reference/item-method-enumerator-javascript.md)   
 [moveFirst Method (Enumerator)](../../javascript/reference/movefirst-method-enumerator-javascript.md)