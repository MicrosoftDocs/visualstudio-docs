---
title: "Argument is missing in &#39;-&#39; escape sequence."
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: Argument is missing in &#39;\&#39; escape sequence.
ms.assetid: 5bd6559b-8cd9-450f-91c8-335ff1b1ef86
caps.latest.revision: 6
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Argument is missing in &#39;-&#39; escape sequence.
This error generally occurs during search or replace when regular expressions or wildcards are used in a search string. This error can be caused by a single backslash (`\`) at the end of a pattern or by `\x` or `\u` entered without a valid hexadecimal Unicode character.  
  
### To correct this error  
  
1.  To search using the regular expression escape character, enter `\`.  
  
2.  To search for a Unicode character, enter `\x` or `\u` followed by a valid Unicode value.  
  
3.  To search for the literal backslash, use `\\`.  
  
## See Also  
 [Using Regular Expressions in Visual Studio](../VS_IDE/Using-Regular-Expressions-in-Visual-Studio.md)   
 [NIB: Find and Replace, Quick Find](assetId:///dad03582-4931-4893-83ba-84b37f5b1600)   
 [Find in Files](../VS_IDE/Find-in-Files.md)