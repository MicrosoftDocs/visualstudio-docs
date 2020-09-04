---
title: Code Analysis for Managed Code Warnings
ms.date: 08/31/2020
ms.topic: reference
f1_keywords:
- vc.project.vcfxcoptool.enablefxcop
helpviewer_keywords:
- managed code analyis, warnings
- warnings, managed code analysis
- managed code analysis warnings
- code analysis,managed code
ms.assetid: 3c2741ff-0d3a-42e6-acd5-d42310bd03c4
author: mikadumont
ms.author: midumont
manager: jillfra
ms.workload:
- dotnet
---
# .NET Code Analysis Rules
The Managed Code Analysis tool provides warnings that indicate rule violations in managed code libraries. The warnings are organized into rule areas such as design, localization, performance, and security. Each warning signifies a violation of a Managed Code Analysis rule. This section provides in-depth discussions and examples for each Managed Code Analysis warning.

 The following table shows the type of information that is provided for each warning.

|Item|Description|
|----------|-----------------|
|Type|The TypeName for the rule.|
|CheckId|The unique identifier for the rule. CheckId and Category are used for in-source suppression of a warning.|
|Category|The category of the warning.|
|Breaking change|Whether the fix for a violation of the rule is a breaking change. Breaking change means that an assembly that has a dependency on the target that caused the violation will not recompile with the new fixed version or might fail at run time because of the change. When multiple fixes are available and at least one fix is a breaking change and one fix is not, both 'Breaking' and 'Non-breaking' are specified.|
|Cause|The specific managed code that causes the rule to generate a warning.|
|Description|Discusses the issues that are behind the warning.|
|How to Fix Violations|Explains how to change the source code to satisfy the rule and prevent it from generating a warning.|
|When to Suppress Warnings|Describes when it is safe to suppress a warning from the rule.|
|Example Code|Examples that violate the rule and corrected examples that satisfy the rule.|
|Related Warnings|Related warnings.|

## In This Section

|Category|Description|
|-|-|
|[Rules By ID](../code-quality/code-analysis-warnings-for-managed-code-by-checkid.md)|Lists all rules by RuleID|
|[Design Rules](../code-quality/design-warnings.md)|Rules that support correct library design as specified by the .NET Design Guidelines.|
|[Documentation Rules](../code-quality/documentation-warnings.md)|Rules that support well-documented library design through the correct use of XML documentation comments.|
|[Globalization Rules](../code-quality/globalization-warnings.md)|Rules that support world-ready libraries and applications.|
|[Maintainability Rules](../code-quality/maintainability-warnings.md)|Rules that support library and application maintenance.|
|[Naming Rules](../code-quality/naming-warnings.md)|Rules that support adherence to the naming conventions of the .NET Design Guidelines.|
|[Performance Rules](../code-quality/performance-warnings.md)|Rules that support high-performance libraries and applications.|
|[Portability and Interoperability Rules](../code-quality/interoperability-warnings.md)|Rules that support portability across different platforms and interaction with COM clients.|
|[Reliability Rules](../code-quality/reliability-warnings.md)|Rules that support library and application reliability, such as correct memory and thread usage.|
|[Security Rules](../code-quality/security-warnings.md)|Rules that support safer libraries and applications.|
|[Usage Rules](../code-quality/usage-warnings.md)|Rules that support appropriate usage of .NET.|
