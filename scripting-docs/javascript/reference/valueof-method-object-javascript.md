---
title: "valueOf Method (Object) (JavaScript) | Microsoft Docs"
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
  - "valueOf"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "valueOf method"
ms.assetid: c555e38b-f451-4341-8fcd-4c8b02906a2c
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# valueOf Method (Object) (JavaScript)
Returns the primitive value of the specified object.  
  
## Syntax  
  
```  
  
object.valueOf( )  
```  
  
## Remarks  
 The required `object` reference is any intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object.  
  
 The `valueOf` method is defined differently for each intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object.  
  
|Object|Return Value|  
|------------|------------------|  
|Array|Returns the array instance.|  
|Boolean|The Boolean value.|  
|Date|The stored time value in milliseconds since midnight, January 1, 1970 UTC.|  
|Function|The function itself.|  
|Number|The numeric value.|  
|Object|The object itself. This is the default.|  
|String|The string value.|  
  
 The **Math** and `Error` objects do not have a `valueOf` method.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
 **Applies To**: [Array Object](../../javascript/reference/array-object-javascript.md)&#124; [Boolean Object](../../javascript/reference/boolean-object-javascript.md)&#124; [Date Object](../../javascript/reference/date-object-javascript.md)&#124; [Function Object](../../javascript/reference/function-object-javascript.md)&#124; [Number Object](../../javascript/reference/number-object-javascript.md)&#124; [Object Object](../../javascript/reference/object-object-javascript.md)&#124; [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [toString Method (Object)](../../javascript/reference/tostring-method-object-javascript.md)