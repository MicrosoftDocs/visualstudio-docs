---
title: "String Object (JavaScript) | Microsoft Docs"
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
  - "String_JavaScript"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "String object"
  - "String object, overview"
ms.assetid: 8063ecd5-5778-4e87-b985-b21420171914
caps.latest.revision: 32
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# String Object (JavaScript)
Allows manipulation and formatting of text strings and determination and location of substrings within strings.  
  
## Syntax  
  
```  
  
newString = new String(["stringLiteral"])  
```  
  
## Parameters  
 `newString`  
 Required. The variable name to which the `String` object is assigned.  
  
 `stringLiteral`  
 Optional. Any group of Unicode characters.  
  
## Remarks  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] provides escape sequences that you can include in strings to create characters that you cannot type directly. For example, `\t` specifies a tab character. For more information, see [Special Characters](../../javascript/advanced/special-characters-javascript.md).  
  
## String Literals  
 A *string literal* is zero or more characters enclosed in single or double quotation marks. A string literal has a primary (primitive) data type of `string`. A *String object* is created by using the [new Operator](../../javascript/reference/new-operator-decrementjavascript.md), and has a data type of `Object`.  
  
 The following example shows that the data type of a string literal is not the same as that of a `String` object.  
  
```JavaScript  
var strLit = "This is a string literal.";  
var strObj = new String("This is a string object.");  
  
document.write(typeof strLit);  
document.write("<br/>");  
document.write(typeof strObj);  
// Output:  
// string  
// object  
```  
  
## Methods for String Literals  
 When you call a method on a string literal, it is temporarily converted to a string wrapper object. The string literal is treated as though the `new` operator were used to create it.  
  
 The following example applies the `toUpperCase` method to a string literal.  
  
```JavaScript  
var strLit = "This is a string literal.";  
  
var result1 = strLit.toUpperCase();  
  
var result2 = (new String(strLit)).toUpperCase();  
  
document.write(result1);  
document.write("<br/>");  
document.write(result2);  
// Output:   
// THIS IS A STRING LITERAL.  
// THIS IS A STRING LITERAL.  
```  
  
## Accessing an Individual Character  
 You can access an individual character of a string as a read-only array-indexed property. This feature was introduced in [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)]. The following example accesses individual string characters.  
  
```JavaScript  
var str = "abcd";  
var result = str[2];  
document.write (result);  
// Output: c  
  
var result = "the"[0];  
document.write(result);  
// Output: t  
```  
  
## Requirements  
 The `String Object` was introduced in [!INCLUDE[jsv1text](../../javascript/reference/includes/jsv1text-md.md)]. Some members in the following lists were introduced in later versions.  
  
<a name="js56jsobjstringprop"></a>   
## Properties  
 The following table lists the properties of the `String` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor Property](../../javascript/reference/constructor-property-string.md)|Specifies the function that creates an object.|  
|[length Property (String)](../../javascript/reference/length-property-string-javascript.md)|Returns the length of a `String` object.|  
|[prototype Property](../../javascript/reference/prototype-property-string.md)|Returns a reference to the prototype for a class of objects.|  
  
## Functions  
 The following table lists the functions of the `String` object.  
  
|Function|Description|  
|--------------|-----------------|  
|[String.fromCharCode Function](../../javascript/reference/string-fromcharcode-function-javascript.md)|Returns a string from a number of Unicode character values.|  
|[String.fromCodePoint Function](../../javascript/reference/string-fromcodepoint-function-javascript.md)|Returns the string associated with a Unicode UTF-16 code point.|  
|[String.raw Function](../../javascript/reference/string-raw-function-javascript.md)|Returns the raw string form of a template string.|  
  
<a name="js56jsobjstringmeth"></a>   
## Methods  
 The following table lists the methods of the `String` object.  
  
|Method|Description|  
|------------|-----------------|  
|[anchor Method](../../javascript/reference/html-tag-methods-javascript.md)|Places an HTML anchor that has a NAME attribute around text.|  
|[big Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<BIG> tags around text.|  
|[blink Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<BLINK> tags around text.|  
|[bold Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<B> tags around text.|  
|[charAt Method](../../javascript/reference/charat-method-string-javascript.md)|Returns the character at the specified index.|  
|[charCodeAt Method](../../javascript/reference/charcodeat-method-string-javascript.md)|Returns the Unicode encoding of the specified character.|  
|[codePointAt Method](../../javascript/reference/codepointat-method-string-javascript.md)|Returns the code point for a Unicode UTF-16 character.|  
|[concat Method (String)](../../javascript/reference/concat-method-string-javascript.md)|Returns a string that contains the concatenation of two supplied strings.|  
|[endsWith Method](../../javascript/reference/endswith-method-string-javascript.md)|Returns a Boolean value that indicates whether a string or substring ends with the passed in string.|  
|[includes Method](../../javascript/reference/includes-method-string-javascript.md)|Returns a Boolean value that indicates whether the passed in string is contained in the string object.|  
|[fixed Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<TT> tags around text.|  
|[fontcolor Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<FONT> tags with a COLOR attribute around text.|  
|[fontsize Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<FONT> tags with a SIZE attribute around text.|  
|[hasOwnProperty Method](../../javascript/reference/hasownproperty-method-object-javascript.md)|Returns a Boolean value that indicates whether an object has a property with the specified name.|  
|[indexOf Method (String)](../../javascript/reference/indexof-method-string-javascript.md)|Returns the character position where the first occurrence of a substring occurs within a string.|  
|[isPrototypeOf Method](../../javascript/reference/isprototypeof-method-object-javascript.md)|Returns a Boolean value that indicates whether an object exists in another object's prototype chain.|  
|[italics Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<I> tags around text.|  
|[lastIndexOf Method (String)](../../javascript/reference/lastindexof-method-string-javascript.md)|Returns the last occurrence of a substring within a string.|  
|[link Method](../../javascript/reference/html-tag-methods-javascript.md)|Places an HTML anchor that has an HREF attribute around text.|  
|[localeCompare Method](../../javascript/reference/localecompare-method-string-javascript.md)|Returns a value that indicates whether two strings are equivalent in the current locale.|  
|[match Method](../../javascript/reference/match-method-string-javascript.md)|Searches a string by using a supplied **Regular Expression** object and returns the results as an array.|  
|[normalize Method](../../javascript/reference/normalize-method-string-javascript.md)|Returns the Unicode Normalization Form of a specified string.|  
|[propertyIsEnumerable Method](../../javascript/reference/propertyisenumerable-method-object-javascript.md)|Returns a Boolean value that indicates whether a specified property is part of an object and whether it is enumerable.|  
|[repeat Method](../../javascript/reference/repeat-method-string-javascript.md)|Returns a new string object with a value equal to the original string repeated the specified number of times.|  
|[replace Method](../../javascript/reference/replace-method-string-javascript.md)|Uses a regular expression to replace text in a string and returns the result.|  
|[search Method](../../javascript/reference/search-method-string-javascript.md)|Returns the position of the first substring match in a regular expression search.|  
|[slice Method (String)](../../javascript/reference/slice-method-string-javascript.md)|Returns a section of a string.|  
|[small Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<SMALL> tags around text.|  
|[split Method](../../javascript/reference/split-method-string-javascript.md)|Returns the array of strings that results when a string is separated into substrings.|  
|[startsWith Method](../../javascript/reference/startswith-method-string-javascript.md)|Returns a Boolean value that indicates whether a string or substring starts with the passed in string.|  
|[strike Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<STRIKE> tags around text.|  
|[sub Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<SUB> tags around text.|  
|[substr Method](../../javascript/reference/substr-method-string-javascript.md)|Returns a substring beginning at a specified location and having a specified length.|  
|[substring Method](../../javascript/reference/substring-method-string-javascript.md)|Returns the substring at a specified location within a `String` object.|  
|[sup Method](../../javascript/reference/html-tag-methods-javascript.md)|Places HTML \<SUP> tags around text.|  
|[toLocaleLowerCase Method](../../javascript/reference/tolocalelowercase-method-string-javascript.md)|Returns a string in which all alphabetic characters are converted to lowercase, taking into account the host environment's current locale.|  
|[toLocaleString Method](../../javascript/reference/tolocalestring-method-object-javascript.md)|Returns an object converted to a string, using the current locale.|  
|[toLocaleUpperCase Method](../../javascript/reference/tolocaleuppercase-method-string-javascript.md)|Returns a string in which all alphabetic characters are converted to uppercase, taking into account the host environment's current locale.|  
|[toLowerCase Method](../../javascript/reference/tolowercase-method-javascript.md)|Returns a string in which all alphabetic characters are converted to lowercase.|  
|[toString Method](../../javascript/reference/tostring-method-string-1.md)|Returns the string.|  
|[toUpperCase Method](../../javascript/reference/touppercase-method-string-javascript.md)|Returns a string in which all alphabetic characters are converted to uppercase.|  
|[trim Method](../../javascript/reference/trim-method-string-javascript.md)|Returns a string with leading and trailing white space and line terminator characters removed.|  
|[valueOf Method](../../javascript/reference/valueof-method-string.md)|Returns the string.|  
  
## See Also  
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [Scrolling, panning, and zooming sample app](http://code.msdn.microsoft.com/ie/Scrolling-panning-and-6834aaf9)