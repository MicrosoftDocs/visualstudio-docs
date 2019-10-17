---
title: "Array length must be a finite positive integer | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5029"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 1a467040-4702-4178-848f-418a5974e907
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array length must be a finite positive integer
You are calling the **Array** constructor with an argument that is not a whole number (whole numbers consist of zero plus the set of positive integers).  
  
### To correct this error  
  
- Use positive integers only when creating a new `Array` object. If you want to create an array with a single element that is not an integer, do it in a two-step process. First create an array with one element, then place the value in the first element (array[0]). The following is an example that generates this error.  
  
    ```JavaScript  
    var piArray = new Array(3.14159);  
    ```  
  
     The following example demonstrates the correct way to specify an array with a single numeric element.  
  
    ```JavaScript  
    var piArray = new Array(1);  
    piArray [0] = 3.14159;  
    ```  
  
     There is no upper limit for the size of an array, other than the maximum integer value (approximately 4 billion).  
  
## See also  
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)