---
title: "Special Characters (JavaScript) | Microsoft Docs"
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
  - "line terminator character"
  - "white space character"
  - "Unicode character"
  - "escape sequence"
  - "backslash (\)"
ms.assetid: 3b38b1bd-1f0f-4748-b13e-55cab36fd126
caps.latest.revision: 31
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Special Characters (JavaScript)
[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] provides escape sequences that you can include in strings to create characters that you cannot type directly.  
  
## Remarks  
 A string value is a series of zero or more Unicode characters (letters, digits, and other characters). String literals are enclosed in matching pairs of single or double quotation marks. Double quotation marks can be contained in a string that is enclosed in single quotation marks. Single quotation marks can be contained in a string that is enclosed in double quotation marks.  
  
 Each character in a string literal can be represented by an escape sequence. An escape sequence starts with a backslash (\\) that informs the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] interpreter that the next character is a special character.  
  
 You can specify a Unicode character by using the \u*hhhh* escape sequence, where *hhhh* is a four-digit hexadecimal number. A Unicode escape sequence can represent any 16-bit character. For additional information, see [Unicode Code Point Escape Sequences](#CodePoint).  
  
 You can use a single-character escape sequence for some characters. For example, \t specifies a tab character.  
  
## Escape Sequences  
 The following table lists a few examples of escape sequences for common characters.  
  
|Unicode character value|Escape sequence|Meaning|Category|  
|-----------------------------|---------------------|-------------|--------------|  
|\u0008|\b|Backspace||  
|\u0009|\t|Tab|White space|  
|\u000A|\n|Line feed (new line)|Line terminator|  
|\u000B|\v<br /><br /> (See note after this table.)|Vertical tab|White space|  
|\u000C|\f|Form feed|White space|  
|\u000D|\r|Carriage return|Line terminator|  
|\u0020||Space|White space|  
|\u0022|\\"|Double quotation mark (")||  
|\u0027|\\'|Single quotation mark (')||  
|\u005C|\\\|Backslash (\\)||  
|\u00A0||Nonbreaking space|White space|  
|\u2028||Line separator|Line terminator|  
|\u2029||Paragraph separator|Line terminator|  
|\uFEFF||Byte order mark|White space|  
  
 The Category column specifies whether the character is a white space or line terminator character. The [trim Method (String)](../../javascript/reference/trim-method-string-javascript.md) removes leading and trailing white space and line terminator characters from a string.  
  
 The backslash itself is used as the escape character. Therefore, you cannot directly type one in your script. If you want to write a backslash, you must type two of them together (\\\\).  
  
> [!NOTE]
>  Starting in [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)], you cannot identify the browser as Internet Explorer by testing for the equivalence of the vertical tab (\v) and the "v". In earlier versions, the expression `"\v" === "v"` returns `true`. In [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)], the expression returns `false`.  
  
## Example  
  
### Description  
 The following example demonstrates the \\\ and \\' escape sequences.  
  
### Code  
  
```JavaScript  
document.write('The image path is C:\\webstuff\\mypage\\gifs\\garden.gif.');  
document.write ("<br />");  
document.write('The caption reads, "After the snow of \'97. Grandma\'s house is covered."');  
```  
  
<a name="CodePoint"></a>   
## Unicode Code Point Escape Sequences  
 In [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)], Unicode is fully supported. The most common Unicode code points are represented by four hexadecimal digits, such as /u0009 for a tab character. Astral code points, which include all symbols that require more than four hexadecimal digits, are now supported in a simplified format. By using the format "\u{*codepoint*}", the full Unicode character set can be represented in a literal format. For example, to represent the symbol "𠮷", you can use the following format: "\u{20BB7}".  
  
 In the following code example, the strings are all equivalent. (\uD842\uDFB7 is the workaround method to specify this symbol in previous versions.)  
  
```JavaScript  
"\u{20BB7}"=="𠮷"=="\uD842\uDFB7"  
```  
  
 RegExp now includes a /u flag to enable full support for astral code points. For example, in the following code example, the /u flag in the regular expression enables matching astral code points (the period matches any character in the provided string).  
  
```JavaScript  
"𠮷".match(/./u)[0].length == 2  
```  
  
 The /u flag enables parsing of the new format, \u{codepoint}), as a Unicode escape sequence. This is necessary because \u{xxxxx} without the /u flag has a different meaning in a regular expression.  
  
> [!NOTE]
>  For astral code points, length is always 2. This matches behavior in previous versions.  
  
 The String object now includes two new methods, String.codePointAt and String.fromCodePoint, to support astral code points. For example, you can use codePointAt to return the code point equivalent for the "𠮷" symbol.  
  
```JavaScript  
"𠮷".codePointAt(0) == 0x20BB7  
  
```  
  
 You can also iterate code points using the `for...of` statement.  
  
```JavaScript  
for(var c of "𠮷") {  
    console.log(c);  
}  
  
```  
  
## See Also  
 [String.fromCharCode Function](../../javascript/reference/string-fromcharcode-function-javascript.md)