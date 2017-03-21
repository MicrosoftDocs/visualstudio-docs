---
title: "toString Method (Object) (JavaScript) | Microsoft Docs"
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
  - "toString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "ToString method"
ms.assetid: c4ae9da2-60c9-486f-b00a-9df03fda4a35
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toString Method (Object) (JavaScript)
Returns a string representation of an object.  
  
## Syntax  
  
```  
  
objectname.toString([radix])  
```  
  
## Parameters  
 `objectname`  
 Required. An object for which a string representation is sought.  
  
 `radix`  
 Optional. Specifies a radix for converting numeric values to strings. This value is only used for numbers.  
  
## Remarks  
 The **toString** method is a member of all built-in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects. How it behaves depends on the object type:  
  
|Object|Behavior|  
|------------|--------------|  
|Array|Elements of an `Array` are converted to strings. The resulting strings are concatenated, separated by commas.|  
|Boolean|If the Boolean value is **true**, returns "`true`". Otherwise, returns "`false`".|  
|Date|Returns the textual representation of the date.|  
|Error|Returns a string containing the associated error message.|  
|Function|Returns a string of the following form, where *functionname* is the name of the function whose **toString** method was called:<br /><br /> `function functionname( ) { [native code] }`|  
|Number|Returns the textual representation of the number.|  
|String|Returns the value of the `String` object.|  
|Default|Returns `"[object objectname]"`, where `objectname` is the name of the object type.|  
  
## Example  
 The following example illustrates the use of the **toString** method with a radix argument. The return value of function shown below is a Radix conversion table.  
  
```JavaScript  
function CreateRadixTable (){  
   var s = "";  
  
   // Create table heading.  
   s += "Hex  Dec  Bin \n";  
  
   for (x = 0; x < 16; x++)  
   {  
      s += "   ";  
  
      // Convert to hexidecimal.  
      s += x.toString(16);  
      s += "     ";  
      if (x < 10) s += "  ";  
  
      // Convert to decimal.  
      s += x.toString(10);  
      s += "     ";  
  
      // Convert to binary.  
      s += x.toString(2);  
      s += "\n";  
   }  
  
   return(s);  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
 **Applies To**: [Array Object](../../javascript/reference/array-object-javascript.md)&#124; [Boolean Object](../../javascript/reference/boolean-object-javascript.md)&#124; [Date Object](../../javascript/reference/date-object-javascript.md)&#124; [Error Object](../../javascript/reference/error-object-javascript.md)&#124; [Function Object](../../javascript/reference/function-object-javascript.md)&#124; [Number Object](../../javascript/reference/number-object-javascript.md)&#124; [Object Object](../../javascript/reference/object-object-javascript.md)&#124; [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)