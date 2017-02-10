---
title: "toString Method (Boolean) 1 | Microsoft Docs"
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
  - "DHTML"
ms.assetid: c46b43c0-6946-407a-b0e0-49cba90e226a
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toString Method (Boolean) 1
Returns a string representation of an object.  
  
## Syntax  
  
```  
  
boolean.toString()  
```  
  
## Parameters  
 `boolean`  
 Required. An object for which to get a string representation.  
  
## Return Value  
 If the Boolean value is `true`, returns "true". Otherwise, returns "false".  
  
## Remarks  
  
## Example  
 The following example illustrates the use of the **toString** method.  
  
```javascript  
var s = new Boolean(0);  
document.write(s.toString());  
  
// Output: false;  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]