---
title: "new Operator (JavaScript) | Microsoft Docs"
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
  - "new_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "new operator in JavaScript"
ms.assetid: 5ea556ba-7ae6-426c-8430-9032eee5a0a5
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# new Operator (JavaScript)
Creates a new object.  
  
## Syntax  
  
```  
new constructor ([arguments])   
```  
  
## Parameters  
 `constructor`  
 Required. The constructor of the object. The parentheses can be omitted if the constructor takes no arguments.  
  
 `arguments`  
 Optional. Any arguments to be passed to the new object's constructor.  
  
## Remarks  
 The `new` operator performs the following tasks:  
  
-   It creates an object with no members.  
  
-   It calls the constructor for that object, passing a pointer to the newly created object as the `this` pointer.  
  
-   The constructor then initializes the object according to the arguments passed to the constructor.  
  
 These are examples of valid uses of the **new** operator.  
  
```javascript  
my_object = new Object;  
my_array = new Array();  
my_date = new Date("Jan 5 1996");  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)