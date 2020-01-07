---
title: "Cannot assign to 'this' | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords:
  - "VS.WebClient.Help.SCRIPT5000"
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: ba2b0a2b-f0f8-4698-b335-a4ab6c166671
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Cannot assign to 'this'
You attempted to assign a value to **this**. **this** is a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] keyword that refers to either:

- the object currently executing a method,

- the global object if there is no current method (or the method does not belong to any other object).

A method is a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] function that is invoked through an object. Inside a method, the **this** keyword is a reference to the object the method was invoked through (which happens to be the object created by invoking the class constructor with the **new** operator).

Inside a method, you can use **this** to refer to the current object, but you cannot assign a new value to **this**.

## To correct this error

- Do not attempt to assign to **this**. To access a property or method of an instantiated object, use the dot operator (e.g., **circle.radius**).

  > [!NOTE]
  > You cannot name a user-created variable **this**; it is a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] reserved word.

## See also

- [this Statement](../../javascript/reference/this-statement-javascript.md)
- [Troubleshooting Your Scripts](../../javascript/advanced/troubleshooting-your-scripts-javascript.md)