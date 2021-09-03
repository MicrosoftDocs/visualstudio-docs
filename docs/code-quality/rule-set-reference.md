---
title: Code analysis rule set reference
ms.date: 04/04/2018
description: Learn about built-in rule sets in Visual Studio legacy code analysis. See resources on the rule sets. Find out how to use these sets in customized rule sets.
ms.custom: SEO-VS-2020
ms.topic: reference
helpviewer_keywords:
- code analysis, rule sets reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- multiple
---
# Code analysis rule set reference

When you configure legacy analysis for managed code projects in Visual Studio, you can choose from a list of built-in *rule sets*. Some rules are included in more than one of the built-in rule sets, for example, the Basic Correctness Rules rule set includes rules that are in the Managed Recommended Rules rule set.

> [!NOTE]
> The rule sets in this section pertain to legacy analysis. For information about rule sets available for code analyzer packages, see [Use rule sets with code analyzers](/dotnet/fundamentals/code-analysis/code-quality-rule-options).

You can either use one of these built-in rule sets, or you can [customize a rule set](../code-quality/how-to-create-a-custom-rule-set.md) to fit your project requirements. If you include multiple rule sets that contain the same rule in a custom rule set, that rule only appears once in the custom rule set.

The topics in this section describe the built-in rule sets and the rules (or warnings) they contain.

| Rule set | Included rules |
| - | - |
| [All Rules](all-rules-rule-set.md) | Contains all available managed and C++ rules |
| [Basic Correctness Rules](basic-correctness-rules-rule-set-for-managed-code.md) | Includes Managed Recommended Rules plus rules for logic errors and framework usage |
| [Extended Correctness Rules](extended-correctness-rules-rule-set-for-managed-code.md) | Includes Basic Correctness Rules (which includes Managed Recommended Rules) plus more rules for logic errors and framework usage |
| [Basic Design Guideline Rules](basic-design-guideline-rules-rule-set-for-managed-code.md) | Includes Managed Recommended Rules plus rules for ensuring code is easy to read, understand, and maintain |
| [Extended Design Guidelines Rules](extended-design-guidelines-rules-rule-set-for-managed-code.md) | Includes Basic Design Guideline Rules (which includes Managed Recommended Rules) plus more maintainability rules that focus on naming |
| [Globalization Rules](globalization-rules-rule-set-for-managed-code.md) | Includes rules for globalization problems |
| [Managed Minimum Rules](managed-minimum-rules-rule-set-for-managed-code.md) | Includes four rules for critical managed code problems |
| [Managed Recommended Rules](managed-recommended-rules-rule-set-for-managed-code.md) | Includes Managed Minimum Rules plus more rules for critical managed code problems |
| [Mixed Minimum Rules](mixed-minimum-rules-rule-set.md) | Includes rules for critical problems in C++ code for CLR |
| [Mixed Recommended Rules](mixed-recommended-rules-rule-set.md) | Includes Mixed Minimum Rules plus more rules for critical problems in C++ code for CLR |
| [Native Minimum Rules](native-minimum-rules-rule-set.md) | Includes rules for critical problems in native code |
| [Native Recommended Rules](native-recommended-rules-rule-set.md) | Includes Native Minimum Rules plus more rules for critical problems in native code |
| [Security Rules](security-rules-rule-set-for-managed-code.md) | Includes rules for finding security vulnerabilities |