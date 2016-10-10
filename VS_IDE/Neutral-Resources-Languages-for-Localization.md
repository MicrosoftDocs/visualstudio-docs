---
title: "Neutral Resources Languages for Localization"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef064995-3b84-4698-a708-9689b7723533
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
# Neutral Resources Languages for Localization
The <xref:System.Resources.NeutralResourcesLanguageAttribute?qualifyHint=False> class specifies the culture of the resources included in the main assembly. This attribute is used as a performance enhancement, so that the <xref:System.Resources.ResourceManager?qualifyHint=False> object does not search for resources that are included in the main assembly.  
  
 The following code shows how to set the neutral resources language. The code can be placed in either a build script or in the AssemblyInfo.vb or AssemblyInfo.cs file.  
  
```vb#  
' Set neutral resources language for assembly.  
<Assembly: NeutralResourcesLanguageAttribute("en")>  
  
```  
  
```c#  
// Set neutral resources language for assembly.  
[assembly: NeutralResourcesLanguageAttribute("en")]  
```  
  
## See Also  
 <xref:System.Resources.ResourceManager?qualifyHint=False>   
 [Introduction to International Applications Based on the .NET Framework](../VS_IDE/Introduction-to-International-Applications-Based-on-the-.NET-Framework.md)   
 [Hierarchical Organization of Resources for Localization](../VS_IDE/Hierarchical-Organization-of-Resources-for-Localization.md)   
 [Localizing Applications](../VS_IDE/Localizing-Applications.md)   
 [Globalizing and Localizing Applications](../VS_IDE/Globalizing-and-Localizing-Applications.md)