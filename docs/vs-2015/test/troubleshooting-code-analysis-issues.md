---
title: "Troubleshooting Code Analysis Issues | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: troubleshooting
ms.assetid: 61c7e44d-2780-4df5-9bcb-49e40c1152fc
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# Troubleshooting Code Analysis Issues
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic contains troubleshooting information for the following Visual Studio code analysis issues.

- [Changes in a Visual Studio 2010 Rule Set Are Not Reflected in Previous Visual Studio Versions](#ChildRuleSetChangesInPreviousVersions)

## <a name="ChildRuleSetChangesInPreviousVersions"></a> Changes in a Visual Studio 2010 Rule Set Are Not Reflected in Previous Visual Studio Versions

When you create a rule set in [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] that contains a child rule set, a change to the child rule set might not be applied in code analysis runs on computers that use an earlier version of Visual Studio. To resolve this issue, you must force a rewrite of the parent rule set, that is the rule set that contains the child rule set.

1. Open the parent rule set in [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)].

2. Make a change, such as adding or removing a rule, and then save the rule set.

3. Reopen the rule set, reverse the change, and then save the rule set again.

## See also

- [Analyzing Application Quality](../code-quality/analyzing-application-quality-by-using-code-analysis-tools.md)
- [Analyzing Managed Code Quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)
- [Using Rule Sets to Group Code Analysis Rules](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
