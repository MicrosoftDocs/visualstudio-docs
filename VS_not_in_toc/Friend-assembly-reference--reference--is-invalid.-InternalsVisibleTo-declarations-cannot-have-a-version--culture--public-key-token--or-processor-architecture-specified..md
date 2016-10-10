---
title: "Friend assembly reference &lt;reference&gt; is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified."
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ae1e470e-3105-48f2-87b1-466e395a7d44
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
# Friend assembly reference &lt;reference&gt; is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.
The assembly name passed to the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute?qualifyHint=False> attribute constructor contains a `Version`, `Culture`, `PublicKeyToken`, or `processorArchitecture` attribute.  
  
 **Error ID:** BC31534  
  
### To correct this error  
  
1.  Remove the `Version`, `Culture`, `PublicKeyToken`, or `processorArchitecture` attribute from the assembly name passed to the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute?qualifyHint=False> attribute constructor.  
  
## See Also  
 <xref:System.Reflection.AssemblyName?qualifyHint=False>   
 [NOT IN BUILD: Friend Assemblies (Visual Basic)](assetId:///80e7a33a-ca91-450b-a00e-c5a7986e228c)