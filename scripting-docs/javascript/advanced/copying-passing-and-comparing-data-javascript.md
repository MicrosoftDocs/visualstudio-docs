---
title: "Copying, Passing, and Comparing Data (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "arrays [Visual Studio], passing values"
  - "function parameters"
  - "string comparison"
  - "function parameters, about function parameters"
  - "ByRef argument"
  - "arrays [Visual Studio], setting data types"
  - "arrays [Visual Studio], copying data"
  - "ByVal argument"
  - "string comparison, testing data"
ms.assetid: fbccd877-7249-45d4-bd9f-6bcd8ba94a6b
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Copying, Passing, and Comparing Data (JavaScript)
In [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)], how data is handled depends on its data type.  
  
## By Value vs. By Reference  
 Numbers and Boolean values (**true** and **false**) are copied, passed, and compared *by value*. When you copy or pass by value, you allocate a space in computer memory and copy the value of the original into it. If you then change the original, the copy is not affected (and vice versa), because the two are separate entities.  
  
 Objects, arrays, and functions are copied, passed, and compared *by reference*. When you copy or pass by reference, you essentially create a pointer to the original item, and use the pointer as if it were a copy. If you then change the original, you change both the original and the copy (and vice versa). There is really only one entity; the "copy" is not actually a copy, it's just another reference to the data.  
  
 When comparing by reference, the two variables must refer to exactly the same entity for the comparison to succeed. For example, two distinct **Array** objects will always compare as unequal, even if they contain the same elements. One of the variables must be a reference to the other one for the comparison to succeed. To check if two Arrays hold the same elements, compare the results of the **toString()** method.  
  
 Last, strings are copied and passed by reference, but are compared by value. Note that if you have two **String** objects (created with **new** String("something")), they are compared by reference, but if one or both of the values is a string value, they are compared by value.  
  
> [!NOTE]
>  Because of the way the ASCII and ANSI character sets are constructed, capital letters precede lowercase ones in sequence order. For example, "Zoo" compares as *less* than "aardvark." You can call **toUpperCase()** or **toLowerCase()** on both strings if you want to perform a case-insensitive match.  
  
## Passing Parameters to Functions  
 When you pass a parameter to a function by value, you are making a separate copy of that parameter, a copy that exists only inside the function. Even though objects and arrays are passed by reference, if you directly overwrite them with a new value in the function, the new value is not reflected outside the function. Only changes to properties of objects, or elements of arrays, are visible outside the function.  
  
 For example (using the Internet Explorer object model):  
  
```JavaScript  
// This clobbers (over-writes) its parameter, so the change  
// is not reflected in the calling code.  
function Clobber(param)   
{  
    // clobber the parameter; this will not be seen in   
    // the calling code  
    param = new Object();  
    param.message = "This will not work";  
}  
  
// This modifies a property of the parameter, which  
// can be seen in the calling code.  
function Update(param)  
{  
    // Modify the property of the object; this will be seen  
    // in the calling code.  
    param.message = "I was changed";  
}  
  
// Create an object, and give it a property.  
var obj = new Object();  
obj.message = "This is the original";  
  
// Call Clobber, and print obj.message. Note that it hasn't changed.  
Clobber(obj);  
window.alert(obj.message); // Still displays "This is the original".  
  
// Call Update, and print obj.message. Note that is has changed.  
Update(obj);  
window.alert(obj.message); // Displays "I was changed".  
```  
  
## Testing Data  
 When you perform a test by value, you compare two distinct items to see whether they are equal to each other. Usually, this comparison is performed on a byte-by-byte basis. When you test by reference, you are checking to see whether two items are pointers to a single original item. If they are, then they compare as equal; if not, even if they contain the exact same values, byte-for-byte, they compare as unequal.  
  
 Copying and passing strings by reference saves memory; but because you cannot change strings once they are created, it becomes possible to compare them by value. This lets you test whether two strings have the same content even if one was generated entirely separately from the other.  
  
## See Also  
 [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md)