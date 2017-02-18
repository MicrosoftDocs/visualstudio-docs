---
title: "item Method (Enumerator) (JavaScript) | Microsoft Docs"
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
  - "item"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Item method"
ms.assetid: a88e93f2-42df-4578-a4f9-0760bd074185
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# item Method (Enumerator) (JavaScript)
Returns the current item in the collection.  
  
> [!WARNING]
>  This object is supported in Internet Explorer only.  
  
## Syntax  
  
```  
  
enumObj.item()   
```  
  
## Remarks  
 The required *enumObj* reference is any `Enumerator` object.  
  
 The **item** method returns the current item. If the collection is empty or the current item is undefined, it returns **undefined**.  
  
## Example  
 In following code, the **item** method is used to return a member of the `Drives` collection.  
  
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
 [moveFirst Method (Enumerator)](../../javascript/reference/movefirst-method-enumerator-javascript.md)   
 [moveNext Method (Enumerator)](../../javascript/reference/movenext-method-enumerator-javascript.md)