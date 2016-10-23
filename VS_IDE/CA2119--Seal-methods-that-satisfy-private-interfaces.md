---
title: "CA2119: Seal methods that satisfy private interfaces"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 483d02e1-cfaf-4754-a98f-4116df0f3509
caps.latest.revision: 18
manager: douge
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
# CA2119: Seal methods that satisfy private interfaces
|||  
|-|-|  
|TypeName|SealMethodsThatSatisfyPrivateInterfaces|  
|CheckId|CA2119|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 An inheritable public type provides an overridable method implementation of an `internal` (`Friend` in Visual Basic) interface.  
  
## Rule Description  
 Interface methods have public accessibility, which cannot be changed by the implementing type. An internal interface creates a contract that is not intended to be implemented outside the assembly that defines the interface. A public type that implements a method of an internal interface using the `virtual` (`Overridable` in Visual Basic) modifier allows the method to be overridden by a derived type that is outside the assembly. If a second type in the defining assembly calls the method and expects an internal-only contract, behavior might be compromised when, instead, the overridden method in the outside assembly is executed. This creates a security vulnerability.  
  
## How to Fix Violations  
 To fix a violation of this rule, prevent the method from being overridden outside the assembly by using one of the following:  
  
-   Make the declaring type `sealed` (`NotInheritable` in Visual Basic).  
  
-   Change the accessibility of the declaring type to `internal` (`Friend` in Visual Basic).  
  
-   Remove all public constructors from the declaring type.  
  
-   Implement the method without using the `virtual` modifier.  
  
-   Implement the method explicitly.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if, after careful review, no security issues exist that might be exploitable if the method is overridden outside the assembly.  
  
## Example  
 The following example shows a type, `BaseImplementation`, that violates this rule.  
  
 [!CODE [FxCop.Security.SealMethods1#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods1#1)]  
  
## Example  
 The following example exploits the virtual method implementation of the previous example.  
  
 [!CODE [FxCop.Security.SealMethods2#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods2#1)]  
  
## See Also  
 [Interfaces](../Topic/Interfaces%20\(C%23%20Programming%20Guide\).md)   
 [Interfaces](../Topic/Interfaces%20\(Visual%20Basic\).md)