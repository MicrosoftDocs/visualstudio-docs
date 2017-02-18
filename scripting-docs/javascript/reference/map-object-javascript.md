---
title: "Map Object (JavaScript) | Microsoft Docs"
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
  - "Map"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: a91dbcbe-f58d-41a0-be15-8c9d30020327
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Map Object (JavaScript)
A collection of key/value pairs.  
  
## Syntax  
  
```javascript  
mapObj = new Map()  
```  
  
## Remarks  
 The keys and values in the collection may be of any type. If you add a value to the collection using an existing key, the new value will replace the old value.  
  
## Properties  
 The following table lists the properties of the `Map` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor](../../javascript/reference/constructor-property-map.md)|Specifies the function that creates a map.|  
|[prototype](../../javascript/reference/prototype-property-map.md)|Returns a reference to the prototype for a map.|  
|[size](../../javascript/reference/size-property-map-javascript.md)|Returns the number of elements in a map.|  
  
## Methods  
 The following table lists the methods of the `Map` object.  
  
|Method|Description|  
|------------|-----------------|  
|[clear](../../javascript/reference/clear-method-map-javascript.md)|Removes all elements from a map.|  
|[delete](../../javascript/reference/delete-method-map-javascript.md)|Removes a specified element from a map.|  
|[forEach](../../javascript/reference/foreach-method-map-javascript.md)|Performs the specified action for each element in a map.|  
|[get](../../javascript/reference/get-method-map-javascript.md)|Returns a specified element from a map.|  
|[has](../../javascript/reference/has-method-map-javascript.md)|Returns `true` if the map contains a specified element.|  
|[set](../../javascript/reference/set-method-map-javascript.md)|Adds a new element to a map.|  
|[toString](../../javascript/reference/tostring-method-map-javascript.md)|Returns a string representation of a map.|  
|[valueOf](../../javascript/reference/valueof-method-map-javascript.md)|Returns the primitive value of the specified object.|  
  
## Example  
 The following example shows how to add members to a `Map` and then retrieve them.  
  
```javascript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
m.set({x:1}, 3);  
  
m.forEach(function (item, key, mapObj) {  
    document.write(item.toString() + "<br />");  
});  
  
document.write("<br />");  
document.write(m.get(2));  
  
// Output:  
// black  
// red  
// 2  
// 3  
//  
// red  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]