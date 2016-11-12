---
title: "CA2224: Override equals on overloading operator equals | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2224"
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "OverrideEqualsOnOverridingOperatorEquals"
helpviewer_keywords: 
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "CA2224"
ms.assetid: 7312afd9-84ba-417f-923e-7a159b53bf70
caps.latest.revision: 15
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2224: Override equals on overloading operator equals
|||  
|-|-|  
|TypeName|OverrideEqualsOnOverloadingOperatorEquals|  
|CheckId|CA2224|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public type implements the equality operator, but does not override <xref:System.Object.Equals%2A?displayProperty=fullName>.  
  
## Rule Description  
 The equality operator is intended to be a syntactically convenient way to access the functionality of the <xref:System.Object.Equals%2A> method. If you implement the equality operator, its logic must be identical to that of <xref:System.Object.Equals%2A>.  
  
 The C# compiler issues a warning if your code violates this rule.  
  
## How to Fix Violations  
 To fix a violation of this rule, you should either remove the implementation of the equality operator, or override <xref:System.Object.Equals%2A> and have the two methods return the same values. If the equality operator does not introduce inconsistent behavior, you can fix the violation by providing an implementation of <xref:System.Object.Equals%2A> that calls the <xref:System.Object.Equals%2A> method in the base class.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the equality operator returns the same value as the inherited implementation of <xref:System.Object.Equals%2A>. The Example section includes a type that could safely suppress a warning from this rule.  
  
## Examples of Inconsistent Equality Definitions  
  
### Description  
 The following example shows a type with inconsistent definitions of equality. `BadPoint` changes the meaning of equality by providing a custom implementation of the equality operator, but does not override <xref:System.Object.Equals%2A> so that it behaves identically.  
  
### Code  
 [!code-cs[FxCop.Usage.OperatorEqualsRequiresEquals#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_1.cs)]  
  
## Example  
 The following code tests the behavior of `BadPoint`.  
  
 [!code-cs[FxCop.Usage.TestOperatorEqualsRequiresEquals#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_2.cs)]  
  
 This example produces the following output.  
  
 **a =  ([0] 1,1) and b = ([1] 2,2) are equal? No**  
**a == b ? No**  
**a1 and a are equal? Yes**  
**a1 == a ? Yes**  
**b and bcopy are equal ? No**  
**b == bcopy ? Yes**   
## Example  
 The following example shows a type that technically violates this rule, but does not behave in an inconsistent manner.  
  
 [!code-cs[FxCop.Usage.ValueTypeEquals#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_3.cs)]  
  
## Example  
 The following code tests the behavior of `GoodPoint`.  
  
 [!code-cs[FxCop.Usage.TestValueTypeEquals#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_4.cs)]  
  
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
 [!code-cs[FxCop.Usage.OverrideEqualsClassViolation#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_5.cs)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.Object.Equals%2A?displayProperty=fullName>.  
  
 [!code-cs[FxCop.Usage.OverrideEqualsClassFixed#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_6.cs)]  
  
## Structure Example  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!code-cs[FxCop.Usage.OverrideEqualsStructViolation#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_7.cs)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.ValueType.Equals%2A?displayProperty=fullName>.  
  
 [!code-cs[FxCop.Usage.OverrideEqualsStructFixed#1](../code-quality/codesnippet/CSharp/ca2224-override-equals-on-overloading-operator-equals_8.cs)]  
  
## Related Rules  
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)  
  
 [CA2225: Operator overloads have named alternates](../code-quality/ca2225-operator-overloads-have-named-alternates.md)  
  
 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)  
  
 [CA2218: Override GetHashCode on overriding Equals](../code-quality/ca2218-override-gethashcode-on-overriding-equals.md)  
  
 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)