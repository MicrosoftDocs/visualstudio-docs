---
title: "Indirect reference is being made to assembly &lt;assemblyname&gt; version &lt;laterversionnumber&gt;, which contains &#39;&lt;typename&gt;&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a3de74b5-bedd-4e36-b379-485e4b3903f7
caps.latest.revision: 9
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
# Indirect reference is being made to assembly &lt;assemblyname&gt; version &lt;laterversionnumber&gt;, which contains &#39;&lt;typename&gt;&#39;
Indirect reference is being made to assembly <assemblyname\> version <laterversionnumber\>, which contains '<typename\>'. This Project references a prior version of <assemblyname\> version <earlierversionnumber\>. To use '<typename\>', you must replace the reference to <assemblyname\> with version <laterversionnumber\> or higher.  
  
 An expression makes an indirect reference to another project, which has a reference to an earlier version of the same assembly.  
  
 You should normally use only the most recent version of an assembly.  
  
 **Error ID:** BC32207  
  
### To correct this error  
  
1.  Use the cited type name to determine which project also references the same assembly.  
  
2.  Determine which version of the assembly the other project references, and change your project to reference the same version.  
  
## See Also  
 [Managing references in a project](../VS_IDE/Managing-references-in-a-project.md)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)   
 [Troubleshooting Broken References](../VS_IDE/Troubleshooting-Broken-References.md)