---
title: "Set Object (JavaScript) | Microsoft Docs"
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
  - "Set"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: 4a4dd749-2a76-44fb-9cb0-a3ef317f75fb
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Set Object (JavaScript)
A collection of unique values that may be of any type.  
  
## Syntax  
  
```  
setObj = new Set()     
```  
  
## Remarks  
 If you try to add a non-unique value to a `Set`, the new value will not be added to the collection.  
  
## Properties  
 The following table lists the properties of the `Set` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor](../../javascript/reference/constructor-property-set.md)|Specifies the function that creates a set.|  
|[prototype](../../javascript/reference/prototype-property-set.md)|Returns a reference to the prototype for a set.|  
|[size](../../javascript/reference/size-property-set-javascript.md)|Returns the number of elements in a set.|  
  
## Methods  
 The following table lists the methods of the `Set` object.  
  
|Method|Description|  
|------------|-----------------|  
|[add](../../javascript/reference/add-method-set-javascript.md)|Adds an element to a set.|  
|[clear](../../javascript/reference/clear-method-set-javascript.md)|Removes all elements from a set.|  
|[delete](../../javascript/reference/delete-method-set-javascript.md)|Removes a specified element from a set.|  
|[forEach](../../javascript/reference/foreach-method-set-javascript.md)|Performs the specified action for each element in a set.|  
|[has](../../javascript/reference/has-method-set-javascript.md)|Returns `true` if the set contains a specified element.|  
|[toString](../../javascript/reference/tostring-method-set-javascript.md)|Returns a string representation of a set.|  
|[valueOf](../../javascript/reference/valueof-method-set-javascript.md)|Returns the primitive value of the specified object.|  
  
## Example  
 The following example shows how to add members to a set and then retrieve them.  
  
```javascript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
s.add("founding father");  
  
s.forEach(function (item) {  
    document.write(item.toString() + ", ");  
});  
  
// Output:  
// Thomas Jefferson, 1776, founding father,  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]