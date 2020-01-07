---
title: "Code Analysis for Managed Code Warnings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vc.project.vcfxcoptool.enablefxcop"
helpviewer_keywords:
  - "managed code analyis, warnings"
  - "warnings, managed code analysis"
  - "managed code analysis warnings"
  - "code analysis,managed code"
ms.assetid: 3c2741ff-0d3a-42e6-acd5-d42310bd03c4
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Code Analysis for Managed Code Warnings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Managed Code Analysis tool provides warnings that indicate rule violations in managed code libraries. The warnings are organized into rule areas such as design, localization, performance, and security. Each warning signifies a violation of a Managed Code Analysis rule. This section provides in-depth discussions and examples for each Managed Code Analysis warning.

 The following table shows the type of information that is provided for each warning.

|Item|Description|
|----------|-----------------|
|Type|The TypeName for the rule.|
|CheckId|The unique identifier for the rule. CheckId and Category are used for in-source suppression of a warning.|
|Category|The category of the warning.|
|Breaking Change|Whether the fix for a violation of the rule is a breaking change. Breaking change means that an assembly that has a dependency on the target that caused the violation will not recompile with the new fixed version or might fail at run time because of the change. When multiple fixes are available and at least one fix is a breaking change and one fix is not, both 'Breaking' and 'Non Breaking' are specified.|
|Cause|The specific managed code that causes the rule to generate a warning.|
|Description|Discusses the issues that are behind the warning.|
|How to Fix Violations|Explains how to change the source code to satisfy the rule and prevent it from generating a warning.|
|When to Suppress Warnings|Describes when it is safe to suppress a warning from the rule.|
|Example Code|Examples that violate the rule and corrected examples that satisfy the rule.|
|Related Warnings|Related warnings.|

## In This Section

|||
|-|-|
|[Warnings By CheckId](../code-quality/code-analysis-warnings-for-managed-code-by-checkid.md)|Lists all warnings by CheckId|
|[Cryptography Warnings](../code-quality/cryptography-warnings.md)|Warnings that support safer libraries and applications through the correct use of cryptography.|
|[Design Warnings](../code-quality/design-warnings.md)|Warnings that support correct library design as specified by the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] Design Guidelines.|
|[Globalization Warnings](../code-quality/globalization-warnings.md)|Warnings that support world-ready libraries and applications.|
|[Interoperability Warnings](../code-quality/interoperability-warnings.md)|Warnings that support interaction with COM clients.|
|[Maintainability Warnings](../code-quality/maintainability-warnings.md)|Warnings that support library and application maintenance.|
|[Mobility Warnings](../code-quality/mobility-warnings.md)|Warnings that support efficient power usage.|
|[Naming Warnings](../code-quality/naming-warnings.md)|Warnings that support adherence to the naming conventions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] Design Guidelines.|
|[Performance Warnings](../code-quality/performance-warnings.md)|Warnings that support high-performance libraries and applications.|
|[Portability Warnings](../code-quality/portability-warnings.md)|Warnings that support portability across different platforms.|
|[Reliability Warnings](../code-quality/reliability-warnings.md)|Warnings that support library and application reliability, such as correct memory and thread usage.|
|[Security Warnings](../code-quality/security-warnings.md)|Warnings that support safer libraries and applications.|
|[Usage Warnings](../code-quality/usage-warnings.md)|Warnings that support appropriate usage of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].|
|[Code Analysis Policy Errors](../code-quality/code-analysis-policy-errors.md)|Errors that occur if the code analysis policy is not satisfied at check-in.|
