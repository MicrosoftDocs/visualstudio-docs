---
title: "Array length must be assigned a finite positive number | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5030"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: c51c66a4-a543-4e95-b18d-2cfbcb3d1fdd
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array length must be assigned a finite positive number
When setting the **length** property of an existing **Array** object, you specified an array length that was not a positive number or zero. This error occurs when you assign a value to the **length** property of an `Array` object that is negative or not a number (`NaN`). Note that [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] automatically converts fractional numbers to whole integers.  
  
### To correct this error  
  
- Assign a positive whole number to the length property. There is no upper limit for the size of an array, other than the maximum integer value (approximately 4 billion). The following example demonstrates the correct way to set the **length** property of an **Array** object.  
  
    ```JavaScript  
    var my_array = new Array();  
    my_array.length = 99;  
    ```  
  
## See also  
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)