---
title: "System.CLSCompliantAttribute cannot be applied to property &#39;Get&#39;-&#39;Set&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: System.CLSCompliantAttribute cannot be applied to property &#39;Get&#39;/&#39;Set&#39;
ms.assetid: 2ff45c09-32be-4ca9-b42a-63ce2536db7d
caps.latest.revision: 11
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
# System.CLSCompliantAttribute cannot be applied to property &#39;Get&#39;-&#39;Set&#39;
A property definition applies the <xref:System.CLSCompliantAttribute?qualifyHint=False> attribute to its `Get` or `Set` statement.  
  
 For a property to be compliant with the [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md) (CLS), the entire property must be marked as `<CLSCompliant(True)>`. You must apply <xref:System.CLSCompliantAttribute?qualifyHint=False> to the [Property Statement](../Topic/Property%20Statement.md), not to either the `Get` or the `Set` statement.  
  
 When you apply <xref:System.CLSCompliantAttribute?qualifyHint=False> to a programming element, you set the attribute's `isCompliant` parameter to either `True` or `False` to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply <xref:System.CLSCompliantAttribute?qualifyHint=False> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../VS_IDE/Configuring-Warnings-in-Visual-Basic.md).  
  
 **Error ID:** BC40043  
  
### To correct this error  
  
-   Remove <xref:System.CLSCompliantAttribute?qualifyHint=False> from the `Get` or `Set` statement.  
  
-   If the property should be CLS-compliant, mark the `Property` statement as `<CLSCompliant(True)>`.  
  
## See Also  
 [<PAVE OVER\> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)   
 [Get Statement](../Topic/Get%20Statement.md)   
 [Set Statement](../Topic/Set%20Statement%20\(Visual%20Basic\).md)