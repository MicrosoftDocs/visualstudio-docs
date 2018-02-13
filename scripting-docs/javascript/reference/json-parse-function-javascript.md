---
title: "JSON.parse Function (JavaScript) | Microsoft Docs"
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
  - "JSON.parse"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "parse JSON method"
  - "JSON.parse method"
ms.assetid: 20f00d31-5ab5-4c3c-ab49-2534fc39a9b4
caps.latest.revision: 41
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JSON.parse Function (JavaScript)
Converts a JavaScript Object Notation (JSON) string into an object.  
  
## Syntax  
  
```  
JSON.parse(text [, reviver])  
```  
  
## Parameters  
 `text`  
 Required. A valid JSON string.  
  
 `reviver`  
 Optional. A function that transforms the results. This function is called for each member of the object. If a member contains nested objects, the nested objects are transformed before the parent object. For each member, the following occurs:  
  
-   If `reviver` returns a valid value, the member value is replaced with the transformed value.  
  
-   If `reviver` returns the same value it received, the member value is not modified.  
  
-   If `reviver` returns `null` or `undefined`, the member is deleted.  
  
## Return Value  
 An object or array.  
  
## Exceptions  
 If this function causes a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] parser error (such as "SCRIPT1014: Invalid character"), the input text does not comply with JSON syntax. To correct the error, do one of the following:  
  
-   Modify the `text` argument to comply with JSON syntax. For more information, see the [BNF syntax notation](http://go.microsoft.com/fwlink/?LinkId=125203) of JSON objects.  
  
     For example, if the response is in JSONP format instead of pure JSON, try this code on the response object:  
  
    ```JavaScript  
    var fixedResponse = response.responseText.replace(/\\'/g, "'");  
    var jsonObj = JSON.parse(fixedResponse);  
    ```  
  
-   Make sure that the `text` argument was serialized by a JSON-compliant implementation such as `JSON.stringify`.  
  
-   Run the `text` argument in a JSON validator such as [JSLint](http://www.jslint.com/) or [JSON to CSV](https://json-csv.com) to help identify syntax errors.  
  
## Example  
 The following example uses `JSON.parse` to convert a JSON string to an object.  
  
```JavaScript  
var jsontext = '{"firstname":"Jesper","surname":"Aaberg","phone":["555-0100","555-0120"]}';  
var contact = JSON.parse(jsontext);  
document.write(contact.surname + ", " + contact.firstname);  
document.write(contact.phone[1]);  
// Output:  
// Aaberg, Jesper  
// 555-0100  
```  
  
## Example  
 The following example converts an array to a JSON string by using `JSON.stringify`, and then converts the string back to an array by using `JSON.parse`.  
  
```JavaScript  
var arr = ["a", "b", "c"];  
var str = JSON.stringify(arr);  
document.write(str);  
document.write ("<br/>");  
  
var newArr = JSON.parse(str);  
  
while (newArr.length > 0) {  
    document.write(newArr.pop() + "<br/>");  
}  
  
// Output:  
// ["a","b","c"]  
// c  
// b  
// a  
```  
  
## Example  
 The `reviver` function is often used to transform JSON representation of International Organization for Standardization (ISO) date strings into Coordinated Universal Time (UTC) format `Date` objects. This example uses `JSON.parse` to deserialize an ISO-formatted date string. The `dateReviver` function returns `Date` objects for members that are formatted like ISO date strings.  
  
```JavaScript  
var jsontext = '{ "hiredate": "2008-01-01T12:00:00Z", "birthdate": "2008-12-25T12:00:00Z" }';  
var dates = JSON.parse(jsontext, dateReviver);  
document.write(dates.birthdate.toUTCString());  
  
function dateReviver(key, value) {  
    var a;  
    if (typeof value === 'string') {  
        a = /^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2}(?:\.\d*)?)Z$/.exec(value);  
        if (a) {  
            return new Date(Date.UTC(+a[1], +a[2] - 1, +a[3], +a[4],  
                            +a[5], +a[6]));  
        }  
    }  
    return value;  
};  
  
// Output:  
// Thu, 25 Dec 2008 12:00:00 UTC  
  
```  
  
## Requirements  
 [!INCLUDE[jsv58](../../javascript/reference/includes/jsv58-md.md)]  
  
## See Also  
 [JSON.stringify Function](../../javascript/reference/json-stringify-function-javascript.md)   
 [toJSON Method (Date)](../../javascript/reference/tojson-method-date-javascript.md)   
 [Hub template sample app (Windows Store)](http://code.msdn.microsoft.com/Hub-template-sample-with-4b70002d)