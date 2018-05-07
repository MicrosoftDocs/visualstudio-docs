---
title: "atEnd Method (Enumerator) (JavaScript) | Microsoft Docs"
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
  - "atEnd"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "atEnd method"
ms.assetid: 326808fb-9a0f-428e-aff1-b11b237913f1
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# atEnd Method (Enumerator) (JavaScript)
Returns a Boolean value indicating if the enumerator is at the end of the collection.  
  
> [!WARNING]
>  This object is supported in Internet Explorer only.  
  
## Syntax  
  
```  
  
myEnum.atEnd()  
```  
  
## Remarks  
 The required *myEnum* reference is any `Enumerator` object.  
  
 The `atEnd` method returns **true** if the current item is the last one in the collection, the collection is empty, or the current item is undefined. Otherwise, it returns **false**.  
  
## Example  
 In following code, the `atEnd` method is used to determine if the end of a list of drives has been reached:  
  
```JavaScript  
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
 [item Method (Enumerator)](../../javascript/reference/item-method-enumerator-javascript.md)   
 [moveFirst Method (Enumerator)](../../javascript/reference/movefirst-method-enumerator-javascript.md)   
 [moveNext Method (Enumerator)](../../javascript/reference/movenext-method-enumerator-javascript.md)   
 [Enumerator Object](../../javascript/reference/enumerator-object-javascript.md)