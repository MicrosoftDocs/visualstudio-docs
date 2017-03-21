---
title: "Symbol Object (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 2ad059f1-4b7f-4758-882a-c74ce1283ab0
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Symbol Object (JavaScript)
Allows you to create a unique identifier.  
  
## Syntax  
  
```  
obj = Symbol(desc)  
```  
  
#### Parameters  
 `desc`  
 Optional. The description of the symbol.  
  
## Remarks  
 Symbol objects allow properties to be added to existing objects with no possibility of interference with the existing object properties, with no unintended visibility, and with no other uncoordinated additions by other code.  
  
 Symbol is a primitive data type. Symbol objects cannot be created using the `new` operator.  
  
 To add symbol objects the global symbol registry, use the `Symbol.for` and `Symbol.keyFor` functions. If you serialize symbols as strings, use the global symbol registry to make sure that a particular string maps to the correct symbol for all lookups.  
  
 JavaScript includes the following built-in symbol values that are available in the global scope.  
  
|Symbol|Description|  
|------------|-----------------|  
|`Symbol.hasInstance`|This method determines whether a constructor object recognizes an object as one of the constructor’s instances. It is used internally by the `instanceof` operator.|  
|`Symbol.isConcatSpreadable`|This property returns a Boolean value that indicates whether an object should be flattened to its array elements by `Array.concat`.|  
|`Symbol.iterator`|This method returns the default iterator for an object. It is used internally by the `for…of` statement.|  
|`Symbol.toPrimitive`|This method converts an object to a corresponding primitive value. It is used internally by the `ToPrimitive` abstract operation.|  
|`Symbol.toStringTag`|This property returns a string value that is used to help create the default string description of an object. It is used internally by the built-in method `Object.toString` method.|  
|`Symbol.unscopables`|This property returns an object whose properties are excluded from the `with` environment bindings of the associated object.|  
  
## Functions  
 The following table lists the functions of the `Symbol` object.  
  
|||  
|-|-|  
|Property|Description|  
|[Symbol.for](../../javascript/reference/symbol-for-function-javascript.md)|Returns the symbol for a specified key or, if the key is not present, creates a new symbol object with the new key.|  
|[Symbol.keyFor](../../javascript/reference/symbol-keyfor-function-javascript.md)|Returns the key for a specified symbol.|  
|||  
  
## Example  
  
```JavaScript  
(function() {  
  
    // module-scoped symbol  
    var key = Symbol("description");  
  
    function MyClass(privateData) {  
      this[key] = privateData;  
    }  
  
    MyClass.prototype = {  
      someFunc: function() {  
        return "data: " + this[key];  
      }  
    };  
  
    var c = new MyClass("private data")  
    console.log(key);  
    console.log(c["key"]);  
    console.log(c.someFunc());  
  
})();  
  
// Output:  
// undefined  
// undefined  
// data: private data  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]