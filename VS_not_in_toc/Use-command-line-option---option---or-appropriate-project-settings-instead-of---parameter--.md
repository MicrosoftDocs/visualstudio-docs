---
title: "Use command line option &#39;&lt;option&gt;&#39; or appropriate project settings instead of &#39;&lt;parameter&gt;&#39;"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1c5d6d7a-b767-4dae-aa61-d7fa81d5aad1
caps.latest.revision: 4
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
# Use command line option &#39;&lt;option&gt;&#39; or appropriate project settings instead of &#39;&lt;parameter&gt;&#39;
The preferred way to specify a file that contains a public key for an assembly, a public-key container for an assembly, or a partial-signed assembly is to use the Visual Basic compiler options. We do not recommend use of the <xref:System.Reflection.AssemblyKeyFileAttribute?qualifyHint=False>, <xref:System.Reflection.AssemblyKeyNameAttribute?qualifyHint=False>, or <xref:System.Reflection.AssemblyDelaySignAttribute?qualifyHint=False> attributes in your code.  
  
 **Error ID:** BC41008  
  
### To correct this error  
  
1.  Use the [/keyfile](../Topic/-keyfile.md), [/keycontainer](../Topic/-keycontainer.md), or [/delaysign](../Topic/-delaysign.md)Visual Basic compiler options instead of the <xref:System.Reflection.AssemblyKeyFileAttribute?qualifyHint=False>, <xref:System.Reflection.AssemblyKeyNameAttribute?qualifyHint=False>, or <xref:System.Reflection.AssemblyDelaySignAttribute?qualifyHint=False> attributes in your code.  
  
## See Also  
 [How to: Create Signed Friend Assemblies](../Topic/How%20to:%20Create%20Signed%20Friend%20Assemblies%20\(C%23%20and%20Visual%20Basic\).md)   
 [Visual Basic Command-Line Compiler](../Topic/Visual%20Basic%20Command-Line%20Compiler.md)   
 [/keyfile](../Topic/-keyfile.md)   
 [/keycontainer](../Topic/-keycontainer.md)   
 [/delaysign](../Topic/-delaysign.md)