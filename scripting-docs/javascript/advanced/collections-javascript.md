---
title: "Collections (JavaScript) | Microsoft Docs"
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
ms.assetid: 23c26185-6a7b-4b69-9d22-63e1841b4905
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Collections (JavaScript)
You can use the collection objects [Map](../../javascript/reference/map-object-javascript.md), [Set](../../javascript/reference/set-object-javascript.md), and [WeakMap](../../javascript/reference/weakmap-object-javascript.md) to store values and objects. These objects provide convenient methods for adding and retrieving members by using either a key or a value instead of an index. To access members of a collection by using an index, use an `Array` object. For more information, see [Using Arrays](../../javascript/advanced/using-arrays-javascript.md).  
  
> [!CAUTION]
>  `Map`, `Set`, and `WeakMap` are not supported in browser versions before Internet Explorer 11. For more information about version support, see [Version Information](../../javascript/reference/javascript-version-information.md).  
  
## Using collections  
 The `Map` and `WeakMap` objects store key/value pairs and enable you to add, retrieve, and remove members by using the key. The key and the value may be of any type. The `Set` object stores values of any type.  
  
 The `Map` and `Set` objects enable you to enumerate collection members by using the `forEach` method and to check the size of the collection by using the `size` method. The `WeakMap` object, in contrast, is not enumerable. For this collection, the key references are held weakly. Use `WeakMap` if you want the garbage collector to determine whether the app has to retain each member of the collection in memory. For example, this may be useful in caching scenarios where cached objects are very large and you don't want to hold objects in memory unnecessarily. In some scenarios, you can use this object to prevent memory leaks.  
  
 The following example shows how to use the `Map` object. In this example, you access members by using both `get` and `forEach`. The callback function in `forEach` can take up to three parameters, which provide the value of the current collection element, the key of the current element, and the collection object itself.  
  
```JavaScript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
m.set({x:1}, 3);  
  
document.write(m.get(2));  
document.write("<br />");  
  
m.forEach(function (value, key, mapObj) {  
    document.write(value.toString() + "<br />");  
});  
  
// Output:  
// red  
  
// black  
// red  
// 2  
// 3  
  
```  
  
 The use of `WeakMap` is similar to `Map`, except that you can retrieve members only by using `get`. For an example, see the [WeakMap](../../javascript/reference/weakmap-object-javascript.md) object.  
  
 The following example shows how to use the `Set` object. In this example, the callback function takes one parameter, which is the value of the current collection element.  
  
```JavaScript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
s.add("founding father");  
  
s.forEach(function (value) {  
    document.write(value.toString() + ", ");  
});  
  
// Output:  
// Thomas Jefferson, 1776, founding father,  
  
```  
  
## See Also  
 [Advanced JavaScript](../../javascript/advanced/advanced-javascript.md)