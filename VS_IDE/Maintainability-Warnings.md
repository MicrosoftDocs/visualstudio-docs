---
title: "Maintainability Warnings"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 537e70ca-a88c-49df-bfc7-0ee63bbe4f16
caps.latest.revision: 19
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
# Maintainability Warnings
Maintainability warnings support library and application maintenance.  
  
## In This Section  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1500: Variable names should not match field names](../VS_IDE/CA1500--Variable-names-should-not-match-field-names.md)|An instance method declares a parameter or a local variable whose name matches an instance field of the declaring type, which leads to errors.|  
|[CA1501: Avoid excessive inheritance](../VS_IDE/CA1501--Avoid-excessive-inheritance.md)|A type is more than four levels deep in its inheritance hierarchy. Deeply nested type hierarchies can be difficult to follow, understand, and maintain.|  
|[CA1502: Avoid excessive complexity](../VS_IDE/CA1502--Avoid-excessive-complexity.md)|This rule measures the number of linearly independent paths through the method, which is determined by the number and complexity of conditional branches.|  
|[CA1504: Review misleading field names](../VS_IDE/CA1504--Review-misleading-field-names.md)|The name of an instance field starts with "s_", or the name of a static (Shared in Visual Basic) field starts with "m_".|  
|[CA1505: Avoid unmaintainable code](../VS_IDE/CA1505--Avoid-unmaintainable-code.md)|A type or method has a low maintainability index value. A low maintainability index indicates that a type or method is probably difficult to maintain and would be a good candidate for redesign.|  
|[CA1506: Avoid excessive class coupling](../VS_IDE/CA1506--Avoid-excessive-class-coupling.md)|This rule measures class coupling by counting the number of unique type references that a type or method contains.|  
  
## See Also  
 [Measuring Complexity and Maintainability of Managed Code](../VS_IDE/Measuring-Complexity-and-Maintainability-of-Managed-Code.md)