---
title: "CA2224: Override equals on overloading operator equals"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7312afd9-84ba-417f-923e-7a159b53bf70
caps.latest.revision: 15
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
# CA2224: Override equals on overloading operator equals
|||  
|-|-|  
|TypeName|OverrideEqualsOnOverloadingOperatorEquals|  
|CheckId|CA2224|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public type implements the equality operator, but does not override <xref:System.Object.Equals?qualifyHint=True>.  
  
## Rule Description  
 The equality operator is intended to be a syntactically convenient way to access the functionality of the <xref:System.Object.Equals?qualifyHint=False> method. If you implement the equality operator, its logic must be identical to that of <xref:System.Object.Equals?qualifyHint=False>.  
  
 The C# compiler issues a warning if your code violates this rule.  
  
## How to Fix Violations  
 To fix a violation of this rule, you should either remove the implementation of the equality operator, or override <xref:System.Object.Equals?qualifyHint=False> and have the two methods return the same values. If the equality operator does not introduce inconsistent behavior, you can fix the violation by providing an implementation of <xref:System.Object.Equals?qualifyHint=False> that calls the <xref:System.Object.Equals?qualifyHint=False> method in the base class.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the equality operator returns the same value as the inherited implementation of <xref:System.Object.Equals?qualifyHint=False>. The Example section includes a type that could safely suppress a warning from this rule.  
  
## Examples of Inconsistent Equality Definitions  
  
### Description  
 The following example shows a type with inconsistent definitions of equality. `BadPoint` changes the meaning of equality by providing a custom implementation of the equality operator, but does not override <xref:System.Object.Equals?qualifyHint=False> so that it behaves identically.  
  
### Code  
 [!CODE [FxCop.Usage.OperatorEqualsRequiresEquals#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.OperatorEqualsRequiresEquals#1)]  
  
## Example  
 The following code tests the behavior of `BadPoint`.  
  
 [!CODE [FxCop.Usage.TestOperatorEqualsRequiresEquals#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.TestOperatorEqualsRequiresEquals#1)]  
  
 This example produces the following output.  
  
 **a =  ([0] 1,1) and b = ([1] 2,2) are equal? No**  
**a == b ? No**  
**a1 and a are equal? Yes**  
**a1 == a ? Yes**  
**b and bcopy are equal ? No**  
**b == bcopy ? Yes**   
## Example  
 The following example shows a type that technically violates this rule, but does not behave in an inconsistent manner.  
  
 [!CODE [FxCop.Usage.ValueTypeEquals#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.ValueTypeEquals#1)]  
  
## Example  
 The following code tests the behavior of `GoodPoint`.  
  
 [!CODE [FxCop.Usage.TestValueTypeEquals#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.TestValueTypeEquals#1)]  
  
 This example produces the following output.  
  
 **a =  (1,1) and b = (2,2) are equal? No**  
**a == b ? No**  
**a1 and a are equal? Yes**  
**a1 == a ? Yes**  
**b and bcopy are equal ? Yes**  
**b == bcopy ? Yes**   
## Class Example  
  
### Description  
 The following example shows a class (reference type) that violates this rule.  
  
### Code  
 [!CODE [FxCop.Usage.OverrideEqualsClassViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsClassViolation#1)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.Object.Equals?qualifyHint=True>.  
  
 [!CODE [FxCop.Usage.OverrideEqualsClassFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsClassFixed#1)]  
  
## Structure Example  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!CODE [FxCop.Usage.OverrideEqualsStructViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsStructViolation#1)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.ValueType.Equals?qualifyHint=True>.  
  
 [!CODE [FxCop.Usage.OverrideEqualsStructFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsStructFixed#1)]  
  
## Related Rules  
 [CA1046: Do not overload operator equals on reference types](../VS_IDE/CA1046--Do-not-overload-operator-equals-on-reference-types.md)  
  
 [CA2225: Operator overloads have named alternates](../VS_IDE/CA2225--Operator-overloads-have-named-alternates.md)  
  
 [CA2226: Operators should have symmetrical overloads](../VS_IDE/CA2226--Operators-should-have-symmetrical-overloads.md)  
  
 [CA2218: Override GetHashCode on overriding Equals](../VS_IDE/CA2218--Override-GetHashCode-on-overriding-Equals.md)  
  
 [CA2231: Overload operator equals on overriding ValueType.Equals](../VS_IDE/CA2231--Overload-operator-equals-on-overriding-ValueType.Equals.md)