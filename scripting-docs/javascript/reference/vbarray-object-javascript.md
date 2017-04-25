---
title: "VBArray Object (JavaScript) | Microsoft Docs"
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
  - "VBArray"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "VBArray object constant"
ms.assetid: f0b767f1-ea8a-4726-962b-2708d4742518
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# VBArray Object (JavaScript)
Provides access to Visual Basic safe arrays.  
  
> [!WARNING]
>  This object is supported in Internet Explorer only, not in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## Syntax  
  
```  
  
varName = new VBArray(safeArray)   
```  
  
## Parameters  
 `varName`  
 Required. The variable name to which the VBArray is assigned.  
  
 *safeArray*  
 Required. A VBArray value.  
  
## Remarks  
 VBArrays are read-only, and cannot be created directly. The *safeArray* argument must have obtained a VBArray value before being passed to the VBArray constructor. This can only be done by retrieving the value from an existing ActiveX or other object.  
  
 VBArrays can have multiple dimensions. The indices of each dimension can be different. The **dimensions** method retrieves the number of dimensions in the array; the `lbound` and `ubound` methods retrieve the range of indices used by each dimension.  
  
## Example  
 The following example consists of three parts. The first part is VBScript code to create a Visual Basic safe array. The second part is [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that converts the Visual Basic safe array to a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] array. Both of these parts go into the \<HEAD> section of an HTML page. The third part is the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that goes in the \<BODY> section to run the other two parts.  
  
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
         a(j, i) = k  
         document.writeln(k)  
         k = k + 1  
      Next  
      document.writeln("<br />")  
   Next  
   CreateVBArray = a  
End Function  
-->  
</script>  
  
<script type="text/javascript">  
<!--  
function VBArrayTest(vbarray){  
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
  
## Properties  
 The `VBArray` object has no properties.  
  
## Methods  
 [dimensions Method](../../javascript/reference/dimensions-method-vbarray-javascript.md) &#124; [getItem Method](../../javascript/reference/getitem-method-vbarray-javascript.md) &#124; [lbound Method](../../javascript/reference/lbound-method-vbarray-javascript.md) &#124; [toArray Method](../../javascript/reference/toarray-method-vbarray-javascript.md) &#124; [ubound Method](../../javascript/reference/ubound-method-vbarray-javascript.md)  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
## See Also  
 [Array Object](../../javascript/reference/array-object-javascript.md)