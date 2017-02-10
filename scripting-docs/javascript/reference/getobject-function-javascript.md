---
title: "GetObject Function (JavaScript) | Microsoft Docs"
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
  - "GetObject"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "GetObject function"
ms.assetid: 62efcdbc-8b86-491d-9000-ef38aa9942a9
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# GetObject Function (JavaScript)
Returns a reference to an Automation object from a file.  
  
> [!NOTE]
>  This function is not supported in Internet Explorer 9 (standards mode) or later.  
  
## Syntax  
  
```  
GetObject([pathname] [, class])  
```  
  
## Parameters  
 `pathname`  
 Optional. Full path and name of the file containing the object to retrieve. If `pathname` is omitted, `class` is required.  
  
 `class`  
 Optional. Class of the object.  
  
 The `class` argument uses the syntax `appname.objectype` and has these parts:  
  
 `appname`  
 Required. Name of the application providing the object.  
  
 `objectype`  
 Required. Type or class of object to create.  
  
## Remarks  
 The `GetObject` function is not supported in [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)] or later.  
  
 Use the `GetObject` function to access an Automation object from a file. Assign the object returned by `GetObject` to the object variable. For example:  
  
```javascript  
var CADObject;  
CADObject = GetObject("C:\\CAD\\SCHEMA.CAD");  
```  
  
 When this code is executed, the application associated with the specified `pathname` is started, and the object in the specified file is activated. If `pathname` is a zero-length string (""), `GetObject` returns a new object instance of the specified type. If the `pathname` argument is omitted, `GetObject` returns a currently active object of the specified type. If no object of the specified type exists, an error occurs.  
  
 Some applications allow you to activate part of a file. To do so, add an exclamation point (!) to the end of the file name and follow it with a string that identifies the part of the file you want to activate. For information on how to create this string, see the documentation for the application that created the object.  
  
 For example, in a drawing application you might have multiple layers to a drawing stored in a file. You could use the following code to activate a layer within a drawing called `SCHEMA.CAD`:  
  
```javascript  
var LayerObject = GetObject("C:\\CAD\\SCHEMA.CAD!Layer3");  
```  
  
 If you do not specify the object's class, Automation determines which application to start and which object to activate, based on the file name you provide. Some files, however, may support more than one class of object. For example, a drawing might support three different types of objects: an Application object, a Drawing object, and a Toolbar object, all of which are part of the same file. To specify which object in a file you want to activate, use the optional `class` argument. For example:  
  
```javascript  
var MyObject;  
MyObject = GetObject("C:\\DRAWINGS\\SAMPLE.DRW", "FIGMENT.DRAWING");  
```  
  
 In the preceding example, `FIGMENT` is the name of a drawing application and `DRAWING` is one of the object types it supports. Once an object is activated, you reference it in code using the object variable you defined. In the preceding example, you access properties and methods of the new object using the object variable `MyObject`. For example:  
  
```javascript  
MyObject.Line(9, 90);  
MyObject.InsertText(9, 100, "Hello, world.");  
MyObject.SaveAs("C:\\DRAWINGS\\SAMPLE.DRW");  
```  
  
> [!NOTE]
>  Use the `GetObject` function when there is a current instance of the object, or if you want to create the object with a file already loaded. If there is no current instance, and you don't want the object started with a file loaded, use the `ActiveXObject` object.  
  
 If an object has registered itself as a single-instance object, only one instance of the object is created, no matter how many times `ActiveXObject` is executed. With a single-instance object, `GetObject` always returns the same instance when called with the zero-length string ("") syntax, and it causes an error if the `pathname` argument is omitted.  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, and Internet Explorer 8 standards. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
## See Also  
 [ActiveXObject Object](../../javascript/reference/activexobject-object-javascript.md)