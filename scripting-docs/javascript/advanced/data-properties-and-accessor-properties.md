---
title: "Data Properties and Accessor Properties | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 7e132831-375d-4728-9a57-5c6f91075b1c
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Data Properties and Accessor Properties
This section includes all the information you are likely to need about data properties and accessor properties.  
  
### Data Properties  
 A *data property* is a property that can get and set a value. Data properties contain the `value` and `writable` properties in their descriptors.  
  
 The following table lists the attributes for a data property descriptor.  
  
|Data descriptor attribute|Description|Default|  
|-------------------------------|-----------------|-------------|  
|`value`|The current value of the property.|`undefined`|  
|`writable`|`true` or `false`. If `writable` is set to `true`, the property value can be modified.|`false`|  
|`enumerable`|`true` or `false`. If `enumerable` is set to `true`, the property can be enumerated by a `for...in` statement.|`false`|  
|`configurable`|`true` or `false`. If `configurable` is set to `true`, property attributes can be changed, and the property can be deleted.|`false`|  
  
 If the descriptor does not have a `value`, `writable`, `get`, or `set` attribute, and the specified property name does not exist, a data property is added.  
  
 When the `configurable` attribute is `false` and `writable` is `true`, the `value` and `writable` attributes can be changed.  
  
#### Data Properties Added Without Using defineProperty  
 If you add a data property without using the `Object.defineProperty`, `Object.defineProperties`, or `Object.create` functions, the `writable`, `enumerable`, and `configurable` attributes are all set to `true`. After the property is added, you can modify it by using the `Object.defineProperty` function.  
  
 You can use the following ways to add a data property:  
  
-   An assignment operator (=), as in `obj.color = "white";`  
  
-   An object literal, as in `obj = { color: "white", height: 5 };`  
  
-   A construction function, as described in [Using Constructors to Define Types](../../javascript/advanced/using-constructors-to-define-types.md)  
  
### Accessor Properties  
 An *accessor property* calls a user-provided function every time that the property value is set or retrieved. The descriptor for an accessor property contains a `get` attribute, a `set` attribute, or both.  
  
 The following table lists the attributes for an accessor property descriptor.  
  
|Accessor descriptor attribute|Description|Default|  
|-----------------------------------|-----------------|-------------|  
|`get`|A function that returns the property value. The function has no parameters.|`undefined`|  
|`set`|A function that sets the property value. It has one parameter that contains the value to be assigned.|`undefined`|  
|`enumerable`|`true` or `false`. If `enumerable` is set to `true`, the property can be enumerated by a `for...in` statement.|`false`|  
|`configurable`|`true` or `false`. If `configurable` is set to `true`, property attributes can be changed, and the property can be deleted.|`false`|  
  
 When a `get` accessor is undefined and an attempt is made to access the property value, the value `undefined` is returned. When a `set` accessor is undefined and an attempt is made to assign a value to the accessor property, nothing occurs.  
  
### Property Modifications  
 If the object already has a property with the specified name, the property attributes are modified. When you modify the property, attributes that are not specified in the descriptor remain the same.  
  
 If the `configurable` attribute of an existing property is `false`, the only allowed modification is changing the `writable` attribute from `true` to `false`.  
  
 You can change a data property to an accessor property, and vice-versa. If you do this, `configurable` and `enumerable` attributes that are not specified in the descriptor are preserved in the property. Other attributes that are not specified in the descriptor are set to their default values.  
  
 You can incrementally define configurable accessor properties by using multiple calls to the `Object.defineProperty` function. For example, one `Object.defineProperty` call might define only a `get` accessor. A later call on the same property name might define a `set` accessor. The property would then have both a `get` accessor and `set` accessor.  
  
 To obtain a descriptor object that applies to an existing property, you can use the [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
 You can use the [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md) and the [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md) to prevent the modification of property attributes.