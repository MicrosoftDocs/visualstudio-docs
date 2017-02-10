---
title: "HTML Tag Methods (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "link method [JavaScript]"
  - "blink method [JavaScript]"
  - "fontsize method [JavaScript]"
  - "italics method [JavaScript]"
  - "sup method [JavaScript]"
  - "anchor method [JavaScript]"
  - "fixed method [JavaScript]"
  - "fontcolor method [JavaScript]"
  - "bold method [JavaScript]"
  - "small method [JavaScript]"
  - "HTML Tag methods [JavaScript]"
  - "sub method [JavaScript]"
  - "big method [JavaScript]"
ms.assetid: 50376223-be95-4aa4-9147-9e738a5d3cfa
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# HTML Tag Methods (JavaScript)
You can use HTML tag methods to place HTML elements around text in a `String` object.  
  
## Syntax  
 The following table lists the syntax for and a description of each HTML tag method.  
  
 In the Syntax column, `string1` is a `String` object or literal.  
  
 The Standard column indicates [World Wide Web Consortium (W3C)](http://go.microsoft.com/fwlink/?LinkId=199553) recommendations for HTML 4. "Discouraged" indicates that the HTML element is discouraged in favor of style sheets.  
  
|Syntax|Method description|Parameter description|Standard|  
|------------|------------------------|---------------------------|--------------|  
|`string1`.anchor(`name`)|Places an HTML anchor that has a NAME attribute around the text.|The `name` parameter is text to put in the NAME attribute of the HTML anchor.||  
|`string1`.big()|Places HTML \<BIG> tags around the text.||Discouraged|  
|`string1`.blink()|Places HTML \<BLINK> tags around the text. The \<BLINK> tag is not supported in Internet Explorer.||Not in standard|  
|`string1`.bold()|Places HTML \<B> tags around the text.||Discouraged|  
|`string1`.fixed()|Places HTML \<TT> tags around the text.||Discouraged|  
|`string1`.fontcolor(`color`)|Places HTML \<FONT> tags with a COLOR attribute around the text.|The `color` parameter is a string value that contains the hexadecimal value or predefined name for a color. Valid predefined color names depend on the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] host browser and its version.|Deprecated|  
|`string1`.fontsize(`size`)|Places HTML \<FONT> tags with a SIZE attribute around the text.|The `size` parameter is an integer value that specifies the size of the text. Valid integer values depend on the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] host browser and its version.|Deprecated|  
|`string1`.italics()|Places HTML \<I> tags around the text.||Discouraged|  
|`string1`.link(`href`)|Places an HTML anchor that has an HREF attribute around the text.|The `href` parameter is text to put in the HREF attribute of the HTML anchor.||  
|`string1`.small()|Places HTML \<SMALL> tags around the text.||Discouraged|  
|`string1`.strike()|Places HTML \<STRIKE> tags around the text.||Deprecated|  
|`string1`.sub()|Places HTML \<SUB> tags around the text.|||  
|`string1`.sup()|Places HTML \<SUP> tags around the text.|||  
  
## Remarks  
 No checking is performed to determine whether the HTML tags have already been applied to the string.  
  
## Example  
 The following examples show how to use the HTML tag methods.  
  
```javascript  
// anchor method.  
var strVariable = "This is an anchor.";  
document.write(strVariable.anchor("Anchor1"));  
// Output: <A NAME="Anchor1">This is an anchor.</A>  
  
// big method.  
var strVariable = "This is a string.";  
document.write(strVariable.big());  
// Output: <BIG>This is a string.</BIG>  
  
//  blink method.  
var strVariable = "This is a string.";  
document.write(strVariable.blink());  
// Output: <BLINK>This is a string.</BLINK>  
  
//  bold method.  
var strVariable = "This is a string.";  
document.write(strVariable.bold());  
// Output: <B>This is a string.</B>  
  
//  fixed method.  
var strVariable = "This is a string.";  
document.write(strVariable.fixed());  
// Output: <TT>This is a string.</TT>  
  
//  fontcolor method.  
var strVariable = "This is a string.";  
document.write(strVariable.fontcolor("red"));  
// Output: <FONT COLOR="red">This is a string.</FONT>  
  
//  fontsize method.  
var strVariable = "This is a string.";  
document.write(strVariable.fontsize(-1));  
// Output: <FONT SIZE="-1">This is a string.</FONT>  
  
//  italics method  
var strVariable = "This is a string.";  
document.write(strVariable.italics());  
// Output: <I>This is a string.</I>  
  
//  link method.  
var strVariable = "This is a hyperlink.";  
document.write(strVariable.link("http://www.microsoft.com"));  
// Output: <A HREF="http://www.microsoft.com">This is a hyperlink.</A>  
  
//  small method.  
var strVariable = "This is a string.";  
document.write(strVariable.small());  
// Output: <SMALL>This is a string.</SMALL>  
  
//  strike method.  
var strVariable = "This is a string.";  
document.write(strVariable.strike());  
// Output: <STRIKE>This is a string.</STRIKE>  
  
//  sub method.  
var strVariable = "This is a string.";  
document.write(strVariable.sub());  
// Output: <SUB>This is a string.</SUB>  
  
//  sup method.  
var strVariable = "This is a string.";  
document.write(strVariable.sup());  
// Output: <SUP>This is a string.</SUP>  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [String Object](../../javascript/reference/string-object-javascript.md)