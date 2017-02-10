---
title: "hasOwnProperty Method (Object) (JavaScript) | Microsoft Docs"
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
  - "hasOwnProperty"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "hasOwnProperty method"
ms.assetid: 3eb69d69-486f-4792-9518-4452aef369ca
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# hasOwnProperty Method (Object) (JavaScript)
Determines whether an object has a property with the specified name.  
  
## Syntax  
  
```  
  
object.hasOwnProperty(proName)  
```  
  
## Parameters  
 `object`  
 Required. Instance of an object.  
  
 `proName`  
 Required. String value of a property name.  
  
## Remarks  
 The `hasOwnProperty` method returns `true` if `object` has a property of the specified name, `false` if it does not. This method does not check the properties in the object's prototype chain; the property must be a member of the object itself.  
  
 This property is not supported on host objects for Internet Explorer 8 and below.  
  
## Example  
 In the following example, all `String` objects share a common split method. The following code will display **false** and **true**.  
  
```javascript  
var s = new String("Sample");  
document.write(s.hasOwnProperty("split"));  
document.write("<br/>");  
document.write(String.prototype.hasOwnProperty("split"));  
  
// Output:  
// false  
// true  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [in Operator](../../javascript/reference/in-operator-decrementjavascript.md)