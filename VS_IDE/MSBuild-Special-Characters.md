---
title: "MSBuild Special Characters"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 545e6a59-1093-4514-935e-78679a46fb3c
caps.latest.revision: 8
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
# MSBuild Special Characters
MSBuild reserves some characters for special use in specific contexts. You only have to escape such characters if you want to use them literally in the context in which they are reserved. For example, an asterisk has special meaning only in the `Include` and `Exclude` attributes of an item definition, and in calls to `CreateItem`. If you want an asterisk to appear as an asterisk in one of those contexts, you must escape it. In every other context, just type the asterisk where you want it to appear.  
  
 To escape a special character, use the syntax %*xx*, where *xx* represents the ASCII hexadecimal value of the character. For more information, see [How to: Escape Special Characters in MSBuild](../VS_IDE/How-to--Escape-Special-Characters-in-MSBuild.md).  
  
## Special Characters  
 The following table lists MSBuild special characters:  
  
|**Character**|**ASCII**|**Reserved Usage**|  
|-------------------|---------------|------------------------|  
|%|%25|Referencing metadata|  
|$|%24|Referencing properties|  
|@|%40|Referencing item lists|  
|'|%27|Conditions and other expressions|  
|;|%3B|List separator|  
|?|%3F|Wildcard character for file names in `Include` and `Exclude` attributes|  
|*|%2A|Wildcard character for use in file names in `Include` and `Exclude` attributes|  
  
## See Also  
 [Advanced Concepts](../VS_IDE/MSBuild-Advanced-Concepts.md)   
 [Items](../VS_IDE/MSBuild-Items.md)