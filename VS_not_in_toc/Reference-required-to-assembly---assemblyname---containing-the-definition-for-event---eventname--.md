---
title: "Reference required to assembly &#39;&lt;assemblyname&gt;&#39; containing the definition for event &#39;&lt;eventname&gt;&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 843b0b2f-0f93-41c3-8727-13a2138e8140
caps.latest.revision: 10
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
# Reference required to assembly &#39;&lt;assemblyname&gt;&#39; containing the definition for event &#39;&lt;eventname&gt;&#39;
Reference required to assembly '<`assemblyname`>' containing the definition for event '<`eventname`>'. Add a reference to your project.  
  
 The event is defined in a dynamic-link library (DLL) or assembly that is not directly referenced in your project. The Visual Basic compiler requires a reference to avoid ambiguity in case the event is defined in more than one DLL or assembly.  
  
 **Error ID:** BC30005  
  
### To correct this error  
  
-   Include the name of the unreferenced DLL or assembly in your project references.  
  
## See Also  
 [NIB: Referencing Namespaces and Components](assetId:///568fa759-796b-44cd-bf5e-1cf8de6e38fd)   
 [Troubleshooting Broken References](../VS_IDE/Troubleshooting-Broken-References.md)