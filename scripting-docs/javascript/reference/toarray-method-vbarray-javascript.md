---
title: "toArray Method (VBArray) (JavaScript) | Microsoft Docs"
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
  - "toArray"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "toArray method"
ms.assetid: 664de44c-2039-4289-82f6-948e9d744d80
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toArray Method (VBArray) (JavaScript)
Returns a standard [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array converted from a VBArray.  
  
## Syntax  
  
```  
  
safeArray.toArray( )   
```  
  
## Remarks  
 The required *safeArray* reference is a VBArray object.  
  
 The conversion translates the multidimensional VBArray into a single dimensional [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array. Each successive dimension is appended to the end of the previous one. For example, a VBArray with three dimensions and three elements in each dimension is converted into a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array as follows:  
  
 Suppose the VBArray contains: (1, 2, 3), (4, 5, 6), (7, 8, 9). After translation, the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array contains: 1, 2, 3, 4, 5, 6, 7, 8, 9.  
  
 There is currently no way to convert a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array into a VBArray.  
  
## Example  
 The following example consists of three parts. The first part is VBScript code to create a Visual Basic safe array. The second part is [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that converts the Visual Basic safe array to a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array. Both of these parts go into the \<HEAD> section of an HTML page. The third part is the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that goes in the \<BODY> section to run the other two parts.  
  
```javascript  
<head>  
<script type="text/vbscript">  
<!--  
Function CreateVBArray()  
   Dim i, j, k  
   Dim a(2, 2)  
   k = 1  
   For i = 0 To 2  
      For j = 0 To 2  
         a(j, i) = k  
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
function VBArrayTest(vbarray)  
{  
   var a = new VBArray(vbarray);  
   var b = a.toArray();  
   var i;  
   for (i = 0; i < 9; i++)   
   {  
      document.writeln(b[i]);  
   }  
}  
-->  
</script>  
</head>  
  
<body>  
<script type="text/javascript">  
<!--  
   VBArrayTest(CreateVBArray());  
-->  
</script>  
</body>  
```  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
 **Applies To**: [VBArray Object](../../javascript/reference/vbarray-object-javascript.md)  
  
## See Also  
 [dimensions Method (VBArray)](../../javascript/reference/dimensions-method-vbarray-javascript.md)   
 [getItem Method (VBArray)](../../javascript/reference/getitem-method-vbarray-javascript.md)   
 [lbound Method (VBArray)](../../javascript/reference/lbound-method-vbarray-javascript.md)   
 [ubound Method (VBArray)](../../javascript/reference/ubound-method-vbarray-javascript.md)