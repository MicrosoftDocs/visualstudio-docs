---
title: "ubound Method (VBArray) (JavaScript) | Microsoft Docs"
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
  - "ubound"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "ubound method"
ms.assetid: 761811c5-9a3d-4cb3-bfe0-0a8749f34496
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ubound Method (VBArray) (JavaScript)
Returns the highest index value used in the specified dimension of the VBArray.  
  
## Syntax  
  
```  
  
safeArray.ubound(dimension)   
```  
  
## Parameters  
 *safeArray*  
 Required. A VBArray object.  
  
 `dimension`  
 Optional. The dimension of the VBArray for which the higher bound index is wanted. If omitted, `ubound` behaves as if a 1 was passed.  
  
## Remarks  
 If the VBArray is empty, the `ubound` method returns undefined. If `dim` is greater than the number of dimensions in the VBArray, or is negative, the method generates a "Subscript out of range" error.  
  
## Example  
 The following example consists of three parts. The first part is VBScript code to create a Visual Basic safe array. The second part is [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that determines the number of dimensions in the safe array and the upper bound of each dimension. Both of these parts go into the \<HEAD> section of an HTML page. The third part is the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code that goes in the \<BODY> section to run the other two parts.  
  
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
         k = k + 1  
      Next  
   Next  
   CreateVBArray = a  
End Function  
-->  
</script>  
  
<script type="text/javascript">  
<!--  
function VBArrayTest(vba)  
{  
   var i;  
   var a = new VBArray(vba);  
   var s = "";  
   for (i = 1; i <= a.dimensions(); i++)  
   {  
      s += "The upper bound of dimension ";  
      s += i + " is ";  
      s += a.ubound(i);  
      s += ".<br />";  
   }  
   return (s);  
}  
-->  
</script>  
</head>  
  
<body>  
<script type="text/javascript">  
   document.write(VBArrayTest(CreateVBArray()));  
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
 [toArray Method (VBArray)](../../javascript/reference/toarray-method-vbarray-javascript.md)