---
title: "Create JSDoc Comments for JavaScript IntelliSense"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a0dadc81-3755-4a47-bcee-c1010819ff2a
caps.latest.revision: 4
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Create JSDoc Comments for JavaScript IntelliSense
IntelliSense in Visual Studio displays information that you add to a script using standard JSDoc comments. You can use JSDoc comments to provide information about code elements such as functions, fields, and variables.  
  
## JSDoc Comment Tags  
 The following standard JSDoc comment tags are used by IntelliSense to display information about your code.  
  
|JSDoc tag|Syntax|Notes|  
|---------------|------------|-----------|  
|@deprecated|@deprecated *description*|Specifies a deprecated function or method.|  
|@description|@description *description*|Specifies the description for a function or method.|  
|@param|@param {*type*} *parameterName**description*|Specifies information for a parameter in a function or method.<br /><br /> TypeScript also supports @paramTag.|  
|@property|@property {*type*} *propertyName*|Specifies information, including a description, for either a field or member that's defined on an object.|  
|@returns|@returns {*type*}|Specifies a return value.<br /><br /> For TypeScript, use @returnType instead of @returns.|  
|@summary|@summary *description*|Specifies the description for a function or method (same as @description).|  
|@type|@type {*type*}|Specifies the type for a constant or a variable.|  
|@typedef|@typedef {*type*} *customTypeName*|Specifies a custom type.|  
  
### Examples  
 The following example shows the use of the @description, @param, and @return JSDoc tags for a function named `getArea`.  
  
```javascript  
/** @description Determines the area of a circle that has the specified radius parameter.  
 * @param {number} radius The radius of the circle.  
 * @return {number}  
 */  
function getArea(radius) {  
    var areaVal;  
    areaVal = Math.PI * radius * radius;  
    return areaVal;  
}  
```  
  
 In the preceding example, IntelliSense shows the description, parameter, and return information when you type the opening parenthesis for `getArea`.  
  
 ![IntelliSense information for a function](../ide/media/js_intellisense_jsdoc_comments.png "JS_IntelliSense_JSDoc_Comments")  
  
 The following example shows how to use the @typedef tag with the @property tag.  
  
```javascript  
/**  
  * @typedef {object} Weather  
  * @property {string} current The current weather.  
  */  
function getForecast(Weather) {  
}  
  
var w = new Weather();  
```  
  
 The following example shows the use of the @type JSDoc tags. As shown in this example, single asterisks (*) that follow the initial asterisk pair (\*\*) are not required.  
  
```javascript  
/**  
    @type {string}  
*/  
const RED = 'FF0000';  
  
```  
  
 The following example shows how to use the @deprecated JSDoc tag.  
  
```javascript  
/**  
 * @deprecated since version 2.0  
 */  
function old() {  
}  
```