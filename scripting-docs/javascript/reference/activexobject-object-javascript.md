---
title: "ActiveXObject Object (JavaScript) | Microsoft Docs"
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
  - "ActiveXObject"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "ActiveXObject object"
  - "Automation objects, ActiveXObject objects"
ms.assetid: 9c7bed07-853f-48aa-92db-3131324746ec
caps.latest.revision: 34
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ActiveXObject Object (JavaScript)
Enables and returns a reference to an Automation object.  
  
 This object is used only to instantiate Automation objects, and has no members.  
  
> [!WARNING]
>  This object is a Microsoft extension and is supported in Internet Explorer only, not in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## Syntax  
  
```  
  
newObj = new ActiveXObject(servername.typename[, location])  
```  
  
## Parameters  
 `newObj`  
 Required. The variable name to which the `ActiveXObject` is assigned.  
  
 `servername`  
 Required. The name of the application providing the object.  
  
 `typename`  
 Required. The type or class of the object to create.  
  
 `location`  
 Optional. The name of the network server where the object is to be created.  
  
## Remarks  
 Automation servers provide at least one type of object. For example, a word-processing application may provide an application object, a document object, and a toolbar object.  
  
 You may be able to identify `servername.typename` values on a host PC in the `HKEY_CLASSES_ROOT` registry key. For example, here are a few examples of values you may find there, depending on which programs are installed:  
  
-   Excel.Application  
  
-   Excel.Chart  
  
-   Scripting.FileSystemObject  
  
-   WScript.Shell  
  
-   Word.Document  
  
> [!IMPORTANT]
>  ActiveX objects may present security issues. To use the `ActiveXObject`, you may need to adjust security settings in Internet Explorer for the relevant security zone. For example, for the Local intranet zone, you typically need to change a custom setting to "Initialize and script ActiveX controls not marked as safe for scripting."  
  
 To identify members of an Automation object that you can use in your code, you may need to use a COM object browser, such as the [OLE/COM Object Viewer](http://msdn.microsoft.com/library/d0kh9f4c.aspx), if no reference documentation is available for the Automation object.  
  
 To create an Automation object, assign the new `ActiveXObject` to an object variable:  
  
```JavaScript  
var ExcelApp = new ActiveXObject("Excel.Application");  
var ExcelSheet = new ActiveXObject("Excel.Sheet");  
```  
  
 This code starts the application creating the object (in this case, a Microsoft Excel worksheet). Once an object is created, you refer to it in code using the object variable you defined. In the following example, you access properties and methods of the new object using the object variable `ExcelSheet` and other Excel objects, including the Application object and the ActiveSheet.Cells collection.  
  
```JavaScript  
// Make Excel visible through the Application object.  
ExcelSheet.Application.Visible = true;  
// Place some text in the first cell of the sheet.  
ExcelSheet.ActiveSheet.Cells(1,1).Value = "This is column A, row 1";  
// Save the sheet.  
ExcelSheet.SaveAs("C:\\TEST.XLS");  
// Close Excel with the Quit method on the Application object.  
ExcelSheet.Application.Quit();  
```  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, Internet Explorer 10 standards, Internet Explorer 11 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
> [!NOTE]
>  Creating an `ActiveXObject` on a remote server is not supported in [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)] or later.  
  
## See Also  
 [GetObject Function](../../javascript/reference/getobject-function-javascript.md)   
 [Unique authentication using Magic of HTML5/WCF sample app](http://code.msdn.microsoft.com/Unique-Authentication-f32d2da0)