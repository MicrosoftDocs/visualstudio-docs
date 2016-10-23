---
title: "Replace In Files Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f116066a-4f65-4f2c-94ef-12cbd8cfb598
caps.latest.revision: 12
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Replace In Files Command
Replaces text in files using a subset of the options available on the **Replace in Files** tab of the **Find and Replace** window.  
  
## Syntax  
  
```  
Edit.ReplaceinFiles findwhat replacewith [/all] [/case]  
[/ext:extensions] [/keep] [/lookin:searchpath] [/options] [/regex]  
[/reset] [/stop] [/sub] [/text2] [/wild] [/word]  
```  
  
## Arguments  
 `findwhat`  
 Required. The text to match.  
  
 `replacewith`  
 Required. The text to substitute for the matched text.  
  
## Switches  
 /all or /a  
 Optional. Replaces all occurrences of the search text with the replacement text.  
  
 /case or /c  
 Optional. Matches occur only if when the uppercase and lowercase characters exactly match those specified in the `findwhat` argument.  
  
 /ext: `extensions`  
 Optional. Specifies the file extensions for the files to be searched.  
  
 /keep or /k  
 Optional. Specifies that all modified files are left open.  
  
 /lookin: `searchpath`  
 Optional. Directory to search. If the path contains spaces, enclose the entire path in quotation marks.  
  
 /options or /t  
 Optional. Displays a list of the current find option settings and does not perform a search.  
  
 /regex or /r  
 Optional. Uses pre-defined special characters in the `findwhat` argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../VS_IDE/Using-Regular-Expressions-in-Visual-Studio.md).  
  
 /reset or /e  
 Optional. Returns the find options to their default settings and does not perform a search.  
  
 /stop  
 Optional. Halts the current search operation if one is in progress. Replace ignores all other arguments when `/stop` has been specified. For example, to stop the current replacement you would enter the following:  
  
```  
>Edit.ReplaceinFiles /stop  
```  
  
 /sub or /s  
 Optional. Searches the subfolders within the directory specified in the /lookin:`searchpath` argument.  
  
 /text2 or /2  
 Optional. Displays the results of the replacement in the **Find Results 2** window.  
  
 /wild or /l  
 Optional. Uses pre-defined special characters in the `findwhat` argument as notations to represent a character or sequence of characters.  
  
 /word or /w  
 Optional. Searches for only whole words.  
  
## Example  
 This example searches for `btnCancel` and replaces it with `btnReset` in all .cls files located in the folder "my visual studio projects" and displays the replacement information in the **Find Results 2** window.  
  
```  
>Edit.ReplaceinFiles btnCancel btnReset /lookin:"c:/my visual studio projects" /ext:.cls /text2  
```  
  
## See Also  
 [Finding and Replacing Text](../VS_IDE/Finding-and-Replacing-Text.md)   
 [Replace in Files](../VS_IDE/Replace-in-Files.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)