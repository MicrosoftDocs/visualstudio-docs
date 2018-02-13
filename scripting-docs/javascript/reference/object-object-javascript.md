---
title: "Object Object (JavaScript) | Microsoft Docs"
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
  - "object"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Object object"
ms.assetid: d24ef8fc-217b-4828-94e1-19f72780bae0
caps.latest.revision: 25
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object Object (JavaScript)
Provides functionality common to all [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects.  
  
## Syntax  
  
```  
  
obj  
 = new Object([value])   
```  
  
## Parameters  
 `obj`  
 Required. The variable name to which the `Object` object is assigned.  
  
 *value*  
 Optional. Any one of the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] primitive data types (Number, Boolean, or String). If value is an object, the object is returned unmodified. If *value* is `null`, **undefined**, or not supplied, an object with no content is created.  
  
## Remarks  
 The `Object` object is contained in all other [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects; all of its methods and properties are available in all other objects. The methods can be redefined in user-defined objects, and are called by [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] at appropriate times. The **toString** method is an example of a frequently redefined `Object` method.  
  
 In this language reference, the description of each `Object` method includes both default and object-specific implementation information for the intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects.  
  
## Requirements  
 The `Object Object` was introduced in [!INCLUDE[jsv3text](../../javascript/reference/includes/jsv3text-md.md)]. Some members in the following lists were introduced in later versions.  
  
## Properties  
 The following table lists properties of the `Object Object`.  
  
|Property|Description|  
|--------------|-----------------|  
|[__proto\_\_ Property](../../javascript/reference/proto-property-object-javascript.md)|Specifies the prototype for an object.|  
|[constructor Property](../../javascript/reference/constructor-property-object-javascript.md)|Specifies the function that creates an object.|  
|[prototype Property](../../javascript/reference/prototype-property-object-javascript.md)|Returns a reference to the prototype for a class of objects.|  
  
## Functions  
 The following table lists functions of the `Object Object`.  
  
|Function|Description|  
|--------------|-----------------|  
|[Object.assign Function](../../javascript/reference/object-assign-function-object-javascript.md)|Copies the values from one or more source objects to a target object.|  
|[Object.create Function](../../javascript/reference/object-create-function-javascript.md)|Creates an object that has a specified prototype, and that optionally contains specified properties.|  
|[Object.defineProperties Function](../../javascript/reference/object-defineproperties-function-javascript.md)|Adds one or more properties to an object, and/or modifies attributes of existing properties.|  
|[Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md)|Adds a property to an object, or modifies attributes of an existing property.|  
|[Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)|Prevents the modification of existing property attributes and values, and prevents the addition of new properties.|  
|[Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md)|Returns the definition of a data property or an accessor property.|  
|[Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md)|Returns the names of the properties and methods of an object.|  
|[Object.getOwnPropertySymbols Function](../../javascript/reference/object-getownpropertysymbols-function-javascript.md)|Returns the symbol properties of an object.|  
|[Object.getPrototypeOf Function](../../javascript/reference/object-getprototypeof-function-javascript.md)|Returns the prototype of an object.|  
|[Object.is Function](../../javascript/reference/object-is-function-javascript.md)|Returns a value that indicates whether two values are the same value.|  
|[Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)|Returns a value that indicates whether new properties can be added to an object.|  
|[Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)|Returns `true` if existing property attributes and values cannot be modified in an object and new properties cannot be added to the object.|  
|[Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)|Returns `true` if existing property attributes cannot be modified in an object and new properties cannot be added to the object.|  
|[Object.keys Function](../../javascript/reference/object-keys-function-javascript.md)|Returns the names of the enumerable properties and methods of an object.|  
|[Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md)|Prevents the addition of new properties to an object.|  
|[Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)|Prevents the modification of attributes of existing properties, and prevents the addition of new properties.|  
|[Object.setPrototypeOf Function](../../javascript/reference/object-setprototypeof-function-javascript.md)|Sets the prototype of an object.|  
  
## Methods  
 The following table lists methods of the `Object Object`.  
  
|Method|Description|  
|------------|-----------------|  
|[hasOwnProperty method](../../javascript/reference/hasownproperty-method-object-javascript.md)|Returns a Boolean value that indicates whether an object has a property with the specified name.|  
|[isPrototypeOf method](../../javascript/reference/isprototypeof-method-object-javascript.md)|Returns a Boolean value that indicates whether an object exists in another object's prototype hierarchy.|  
|[propertyIsEnumerable method](../../javascript/reference/propertyisenumerable-method-object-javascript.md)|Returns a Boolean value that indicates whether a specified property is part of an object and whether it is enumerable.|  
|[toLocaleString method](../../javascript/reference/tolocalestring-method-object-javascript.md)|Returns an object converted to a string based on the current locale.|  
|[toString method](../../javascript/reference/tostring-method-object-javascript.md)|Returns a string representation of an object.|  
|[valueOf method](../../javascript/reference/valueof-method-object-javascript.md)|Returns the primitive value of the specified object.|  
  
## See Also  
 [JavaScript Objects](../../javascript/reference/javascript-objects.md)