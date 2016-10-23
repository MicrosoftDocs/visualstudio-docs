---
title: "CA1502: Avoid excessive complexity"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d735454b-2f8f-47ce-907d-f7a5a5391221
caps.latest.revision: 30
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
  
 You can learn more about code metrics at [Measuring Complexity and Maintainability of Managed Code](../VS_IDE/Measuring-Complexity-and-Maintainability-of-Managed-Code.md),  
  
## How to Fix Violations  
 To fix a violation of this rule, refactor the method to reduce its cyclomatic complexity.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the complexity cannot easily be reduced and the method is easy to understand, test, and maintain. In particular, a method that contains a large `switch` (`Select` in Visual Basic) statement is a candidate for exclusion. The risk of destabilizing the code base late in the development cycle or introducing an unexpected change in runtime behavior in previously shipped code might outweigh the maintainability benefits of refactoring the code.  
  
## How Cyclomatic Complexity is Calculated  
 The cyclomatic complexity is calculated by adding 1 to the following:  
  
-   Number of branches (such as `if`, `while`, and `do`)  
  
-   Number of `case` statements in a `switch`  
  
 The following examples show methods that have varying cyclomatic complexities.  
  
## Example  
 **Cyclomatic Complexity of 1**  
  
 [!CODE [FxCop.Maintainability.AvoidExcessiveComplexity#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Maintainability.AvoidExcessiveComplexity#1)]  
  
## Example  
 **Cyclomatic Complexity of 2**  
  
 [!CODE [FxCop.Maintainability.AvoidExcessiveComplexity#2](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Maintainability.AvoidExcessiveComplexity#2)]  
  
## Example  
 **Cyclomatic Complexity of 3**  
  
 [!CODE [FxCop.Maintainability.AvoidExcessiveComplexity#3](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Maintainability.AvoidExcessiveComplexity#3)]  
  
## Example  
 **Cyclomatic Complexity of 8**  
  
 [!CODE [FxCop.Maintainability.AvoidExcessiveComplexity#4](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Maintainability.AvoidExcessiveComplexity#4)]  
  
## Related Rules  
 [CA1501: Avoid excessive inheritance](../VS_IDE/CA1501--Avoid-excessive-inheritance.md)  
  
## See Also  
 [Measuring Complexity and Maintainability of Managed Code](../VS_IDE/Measuring-Complexity-and-Maintainability-of-Managed-Code.md)