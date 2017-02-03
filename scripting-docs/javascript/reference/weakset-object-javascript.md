---
title: "WeakSet Object (JavaScript) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: f97e6e7c-d678-4e32-978e-d949a7cafa3a
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# WeakSet Object (JavaScript)
A collection of unique objects that may be of any type.  
  
## Syntax  
  
```  
setObj = new WeakSet()  
```  
  
## Remarks  
 If you try to add a non-unique object to a `WeakSet`, the new object will not be added to the collection.  
  
 Unlike a `Set`, only objects may be added to the collection. Arbitrary values cannot be added to the collection.  
  
 In a `WeakSet` object, references to objects in the set are held ‘weakly’. This means that `WeakSet` will not prevent a garbage collection from happening on the objects. When there are no references (other than `WeakSet`) to the objects, the garbage collector may collect the objects.  
  
 `WeakSet` (or `WeakMap`) may be helpful in some scenarios involving caching of objects or object metadata. For example, metadata for non-extensible objects may be stored in a `WeakSet`, or you may create a cache of user images using `WeakSet`.  
  
## Properties  
 The following table lists the properties of the `WeakSet` object.  
  
|Property|Description|  
|--------------|-----------------|  
|constructor|Specifies the function that creates a set.|  
|prototype|Returns a reference to the prototype for a set.|  
  
## Methods  
 The following table lists the methods of the `WeakSet` object.  
  
|Method|Description|  
|------------|-----------------|  
|add|Adds an element to a set.|  
|delete|Removes a specified element from a set.|  
|has|Returns `true` if the set contains a specified element.|  
  
## Example  
 The following example shows how to add members to a set and then verify that they have been added.  
  
```javascript  
var ws = new WeakSet();  
  
var str = new String("Thomas Jefferson");  
var num = new Number(1776);  
  
ws.add(str);  
ws.add(num);  
  
console.log(ws.has(str));  
console.log(ws.has(num));  
  
ws.delete(str);  
console.log(ws.has(str));  
  
// Output:  
// true  
// true  
// false  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]