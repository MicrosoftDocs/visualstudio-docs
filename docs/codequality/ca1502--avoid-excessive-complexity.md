---
title: "CA1502: Avoid excessive complexity"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AvoidExcessiveComplexity"
  - "CA1502"
helpviewer_keywords: 
  - "CA1502"
  - "AvoidExcessiveComplexity"
ms.assetid: d735454b-2f8f-47ce-907d-f7a5a5391221
caps.latest.revision: 30
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1502: Avoid excessive complexity
|||  
|-|-|  
|TypeName|AvoidExcessiveComplexity|  
|CheckId|CA1502|  
|Category|Microsoft.Maintainability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method has an excessive cyclomatic complexity.  
  
## Rule Description  
 *Cyclomatic complexity* measures the number of linearly independent paths through the method, which is determined by the number and complexity of conditional branches. A low cyclomatic complexity generally indicates a method that is easy to understand, test, and maintain. The cyclomatic complexity is calculated from a control flow graph of the method and is given as follows:  
  
 cyclomatic complexity = the number of edges - the number of nodes + 1  
  
 where a node represents a logic branch point and an edge represents a line between nodes.  
  
 The rule reports a violation when the cyclomatic complexity is more than 25.  
  
 You can learn more about code metrics at [Measuring Complexity and Maintainability of Managed Code](../codequality/measuring-complexity-and-maintainability-of-managed-code.md),  
  
## How to Fix Violations  
 To fix a violation of this rule, refactor the method to reduce its cyclomatic complexity.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the complexity cannot easily be reduced and the method is easy to understand, test, and maintain. In particular, a method that contains a large `switch` (`Select` in [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)]) statement is a candidate for exclusion. The risk of destabilizing the code base late in the development cycle or introducing an unexpected change in runtime behavior in previously shipped code might outweigh the maintainability benefits of refactoring the code.  
  
## How Cyclomatic Complexity is Calculated  
 The cyclomatic complexity is calculated by adding 1 to the following:  
  
-   Number of branches (such as `if`, `while`, and `do`)  
  
-   Number of `case` statements in a `switch`  
  
 The following examples show methods that have varying cyclomatic complexities.  
  
## Example  
 **Cyclomatic Complexity of 1**  
  
 [!code[FxCop.Maintainability.AvoidExcessiveComplexity#1](../codequality/codesnippet/CPP/ca1502--avoid-excessive-complexity_1.cpp)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#1](../codequality/codesnippet/VisualBasic/ca1502--avoid-excessive-complexity_1.vb)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#1](../codequality/codesnippet/CSharp/ca1502--avoid-excessive-complexity_1.cs)]  
  
## Example  
 **Cyclomatic Complexity of 2**  
  
 [!code[FxCop.Maintainability.AvoidExcessiveComplexity#2](../codequality/codesnippet/CPP/ca1502--avoid-excessive-complexity_2.cpp)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#2](../codequality/codesnippet/VisualBasic/ca1502--avoid-excessive-complexity_2.vb)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#2](../codequality/codesnippet/CSharp/ca1502--avoid-excessive-complexity_2.cs)]  
  
## Example  
 **Cyclomatic Complexity of 3**  
  
 [!code[FxCop.Maintainability.AvoidExcessiveComplexity#3](../codequality/codesnippet/CPP/ca1502--avoid-excessive-complexity_3.cpp)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#3](../codequality/codesnippet/VisualBasic/ca1502--avoid-excessive-complexity_3.vb)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#3](../codequality/codesnippet/CSharp/ca1502--avoid-excessive-complexity_3.cs)]  
  
## Example  
 **Cyclomatic Complexity of 8**  
  
 [!code[FxCop.Maintainability.AvoidExcessiveComplexity#4](../codequality/codesnippet/CPP/ca1502--avoid-excessive-complexity_4.cpp)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#4](../codequality/codesnippet/VisualBasic/ca1502--avoid-excessive-complexity_4.vb)]
[!code[FxCop.Maintainability.AvoidExcessiveComplexity#4](../codequality/codesnippet/CSharp/ca1502--avoid-excessive-complexity_4.cs)]  
  
## Related Rules  
 [CA1501: Avoid excessive inheritance](../codequality/ca1501--avoid-excessive-inheritance.md)  
  
## See Also  
 [Measuring Complexity and Maintainability of Managed Code](../codequality/measuring-complexity-and-maintainability-of-managed-code.md)