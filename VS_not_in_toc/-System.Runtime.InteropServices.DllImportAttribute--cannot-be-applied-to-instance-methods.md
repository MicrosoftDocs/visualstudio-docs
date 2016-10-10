---
title: "&#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to instance methods"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c8bde5d7-c6bf-4d21-bb1a-e8627d65ad29
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
# &#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to instance methods
A nonshared procedure is declared with the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False>.  
  
 The common language runtime (CLR) recognizes this attribute and its <xref:System.Runtime.InteropServices._Assembly.EntryPoint?qualifyHint=False> property as designating a replacement procedure defined in an unmanaged dynamic-link library (DLL) outside the .NET Framework. When code calls the procedure to which the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> is applied, the common language runtime calls the designated unmanaged procedure instead.  
  
 Because unmanaged platforms outside the .NET Framework do not support nonshared procedures the same way the .NET Framework does, you cannot interoperate with them using nonshared procedures.  
  
 **Error ID:** BC31529  
  
### To correct this error  
  
-   If the procedure does not need to apply individually to each instance of its class or structure, then declare it as `Shared`.  
  
-   If the procedure cannot be `Shared`, then remove the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> from the declaration of this procedure.  
  
## See Also  
 <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False>   
 [Shared](../Topic/Shared%20\(Visual%20Basic\).md)