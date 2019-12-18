---
title: "VBArray expected | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5013"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: f2998d7d-13a4-4bbe-b872-3ff3316551e4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# VBArray expected
You supplied an object that was not a Visual Basic safeArray, when one was expected.  
  
```js
new VBArray(safeArray);  
```  
  
 VBArrays are read-only, and cannot be created directly. The safeArray argument is a VBArray value, and must have obtained a VBArray value before being passed to the `VBArray` constructor. This can only be done by retrieving the value from an existing ActiveX or other object.  
  
### To correct this error  
  
- Ensure you pass only **VBArray** objects to the **VBArray** constructor.  
  
## See also  
 [VBArray Object](../../javascript/reference/vbarray-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)