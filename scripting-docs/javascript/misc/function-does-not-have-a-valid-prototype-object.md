---
title: "Function does not have a valid prototype object | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5023"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: b9e34652-190f-4b57-b253-df2e8c4d09c6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Function does not have a valid prototype object
You attempted to use **instanceof** to determine if an object was derived from a particular function class, but you redefined the object's `prototype` property as either `null`, or an external object type (both not valid [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects). An external object can be an object from the host object model (for example, Internet Explorer's document or window object), or an external COM object.  
  
### To correct this error  
  
- Ensure the function's `prototype` property refers to a valid [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object.  
  
## See also  
 [Function Object](../../javascript/reference/function-object-javascript.md)   
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)