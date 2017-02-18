---
title: "toJSON Method (Date) (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "toJSON method"
ms.assetid: f91df030-e9c9-425e-8e6d-b46bdda66cb6
caps.latest.revision: 27
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toJSON Method (Date) (JavaScript)
Used by the [JSON.stringify](../../javascript/reference/json-stringify-function-javascript.md) method to enable the transformation of an object's data for JavaScript Object Notation (JSON) serialization.  
  
## Syntax  
  
```  
  
objectname.toJSON()  
```  
  
## Parameters  
 `objectname`  
 Required. An object for which JSON serialization is wanted.  
  
## Remarks  
 The `toJSON` method is used by the `JSON.stringify` function. `JSON.stringify` serializes a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] value into JSON text. If a `toJSON` method is provided to `JSON.stringify`, the `toJSON` method is called when `JSON.stringify` is called.  
  
 The `toJSON` method is a built-in member of the [Date](../../javascript/reference/date-object-javascript.md)[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object. It returns an ISO-formatted date string for the UTC time zone (denoted by the suffix Z).  
  
 You can override the `toJSON` method for the `Date` type, or define a `toJSON` method for other object types to achieve transformation of data for the specific object type before JSON serialization.  
  
## Example  
 The following example uses the `toJSON` method to serialize string member values in uppercase. The `toJSON` method is called when `JSON.stringify` is called.  
  
```javascript  
var contact = new Object();  
contact.firstname = "Jesper";  
contact.surname = "Aaberg";  
contact.phone = ["555-0100", "555-0120"];  
  
contact.toJSON = function(key)  
 {  
    var replacement = new Object();  
    for (var val in this)  
    {  
        if (typeof (this[val]) === 'string')  
            replacement[val] = this[val].toUpperCase();  
        else  
            replacement[val] = this[val]  
    }  
    return replacement;  
};  
  
var jsonText = JSON.stringify(contact);  
  
/* The value of jsonText is:  
'{"firstname":"JESPER","surname":"AABERG","phone":["555-0100","555-0120"]}'  
*/  
```  
  
## Example  
 The following example illustrates how to use the `toJSON` method that is a built-in member of the [Date](../../javascript/reference/date-object-javascript.md) object.  
  
```javascript  
var dt = new Date('8/24/2009');  
dt.setUTCHours(7, 30, 0);  
var jsonText = JSON.stringify(dt);  
  
/* The value of jsonText is:  
'"2009-08-24T07:30:00Z"'  
*/  
```  
  
## Requirements  
 [!INCLUDE[jsv58](../../javascript/reference/includes/jsv58-md.md)] **Applies To:** [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [JSON Object](../../javascript/reference/json-object-javascript.md)   
 [JSON.parse Function](../../javascript/reference/json-parse-function-javascript.md)   
 [JSON.stringify Function](../../javascript/reference/json-stringify-function-javascript.md)   
 [JavaScript Methods](../../javascript/reference/javascript-methods.md)