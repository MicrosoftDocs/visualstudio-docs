---
title: "Debug.setNonUserCodeExceptions Property | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 1dd2abee-a415-41bb-a359-017da62f9485
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.setNonUserCodeExceptions Property
Determines whether any try-catch blocks in this scope are to be treated by the debugger as user-unhandled. Exceptions can be classified as thrown, user-unhandled or unhandled.  
  
 If this property is set to `true` in a given scope, the debugger can then determine to take some action (for example, break) on exceptions thrown inside that scope if the developer wishes to break on user-unhandled exceptions. If this property is set to `false` is the same as if the property was never set.  
  
 For more information on debugging, see [Active Script Debugging Overview](http://go.microsoft.com/fwlink/p/?LinkId=249469).  
  
## Syntax  
  
```  
Debug.setNonUserCodeExceptions [= bool];  
```  
  
## Example  
 The following code shows how to set this property.  
  
```JavaScript  
(function () {  
    Debug.setNonUserCodeExceptions = true;  
    try{  
        var x = null;  
        x.y();  
    } catch (e) {  
    // Catch the exception.  
    }  
})();  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]