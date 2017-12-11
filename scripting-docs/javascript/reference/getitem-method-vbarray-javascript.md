---
title: "getItem Method (VBArray) (JavaScript) | Microsoft Docs"
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
  - "getItem"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "getItem method"
  - "Item property"
ms.assetid: f62964ad-8b2f-4596-95d0-b20e587ecea5
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getItem Method (VBArray) (JavaScript)
Returns the item at the specified location.  
  
## Syntax  
  
```  
  
safeArray.getItem(dimension1[, dimension2, ...], dimensionN)   
```  
  
## Parameters  
 *safeArray*  
 Required. A VBArray object.  
  
 *dimension1, ..., dimensionN*  
 Specifies the exact location of the desired element of the VBArray. *n* equals the number of dimensions in the VBArray.  
  
## Example  
 The following example consists of three parts. The first part is VBScript code to create a Visual Basic safe array. The second part is [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that iterates the Visual Basic safe array and prints out the contents of each element. Both of these parts go into the \<HEAD> section of an HTML page. The third part is the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that goes in the \<BODY> section to run the other two parts.  
  
```JavaScript  
<head>  
<script type="text/vbscript">  
<!--  
Function CreateVBArray()  
   Dim i, j, k  
   Dim a(2, 2)  
   k = 1  
   For i = 0 To 2  
      For j = 0 To 2  
         a(i, j) = k  
         document.writeln(k)  
         k = k + 1  
      Next  
      document.writeln("<BR>")  
   Next  
   CreateVBArray = a  
End Function  
-->  
</script>  
<script type="text/javascript">  
<!--  
function GetItemTest(vbarray)  
{  
   var i, j;  
   var a = new VBArray(vbarray);  
   for (i = 0; i <= 2; i++)  
   {  
      for (j =0; j <= 2; j++)  
      {  
         document.writeln(a.getItem(i, j));  
      }  
   }  
}  
-->  
</script>  
</head>  
<body>  
<script type="text/javascript">  
<!--  
   GetItemTest(CreateVBArray());  
-->  
</script>  
</body>  
```  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
 **Applies To**: [VBArray Object](../../javascript/reference/vbarray-object-javascript.md)  
  
## See Also  
 [dimensions Method (VBArray)](../../javascript/reference/dimensions-method-vbarray-javascript.md)   
 [lbound Method (VBArray)](../../javascript/reference/lbound-method-vbarray-javascript.md)   
 [toArray Method (VBArray)](../../javascript/reference/toarray-method-vbarray-javascript.md)   
 [ubound Method (VBArray)](../../javascript/reference/ubound-method-vbarray-javascript.md)