---
title: "In Source Suppression Overview | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "source suppression, code analysis"
  - "code analysis, source suppression"
ms.assetid: f1a2dc6a-a9eb-408c-9078-2571e57d207d
caps.latest.revision: 42
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# In Source Suppression Overview
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In-source suppression is the ability to suppress or ignore Code Analysis violations in managed code by adding the **SuppressMessage** attribute to the code segments that cause the violations. The **SuppressMessage** attribute is a conditional attribute which is included in the IL metadata of your managed code assembly only if the CODE_ANALYSIS compilation symbol is defined at compile time.

 In C++/CLI, use the macros CA_SUPPRESS_MESSAGE or CA_GLOBAL_SUPPRESS_MESSAGE in the header file,  to add the attribute .

 You should not use in-source suppressions on release builds to prevent shipping the in-source suppression metadata accidentally. Because of the processing cost of in-source suppression, the performance of your application can also be degraded by including the in-source suppression metadata.

> [!NOTE]
> You do not have to hand code these attributes yourself. For more information, see [How to: Suppress Warnings by Using the Menu Item](../code-quality/how-to-suppress-warnings-by-using-the-menu-item.md). The menu item is not available for C++ code.

## SuppressMessage Attribute
 When you right-click a Code Analysis warning in the **Error List** and then click **Suppress Message(s)**, a **SuppressMessage** attribute is added either in your code or to the project's global suppressions file.

 The **SuppressMessage** attribute has the following format:

```vb
<Scope:SuppressMessage("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")>
```

```csharp
[Scope:SuppressMessage("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")]

```

 [C++]

```
CA_SUPPRESS_MESSAGE("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")

```

 Where:

- **Rule Category** - The category in which the rule is defined. For more information about code analysis rule categories, see [Code Analysis for Managed Code Warnings](../code-quality/code-analysis-for-managed-code-warnings.md).

- **Rule Id** - The identifier of the rule. Support includes both a short and long name for the rule identifier. The short name is CAXXXX; the long name is CAXXXX:FriendlyTypeName.

- **Justification** - The text that is used to document the reason for suppressing the message.

- **Message Id** - Unique identifier of a problem for each message.

- **Scope** - The target on which the warning is being suppressed. If the target is not specified, it is set to the target of the attribute. Supported scopes include the following:

  - Module

  - Namespace

  - Resource

  - Type

  - Member

- **Target** - An identifier that is used to specify the target on which the warning is being suppressed. It must contain a fully-qualified item name.

## SuppressMessage Usage
 Code Analysis warnings are suppressed at the level to which an instance of the **SuppressMessage** attribute is applied. The purpose of this is to tightly couple the suppression information to the code where the violation occurs.

 The general form of suppression includes the rule category and a rule identifier which contains an optional human-readable representation of the rule name. For example,

 `[SuppressMessage("Microsoft.Design", "CA1039:ListsAreStrongTyped")]`

 If there are strict performance reasons for minimizing in-source suppression metadata, the rule name itself can be left out. The rule category and its rule ID together constitute a sufficiently unique rule identifier. For example,

 `[SuppressMessage("Microsoft.Design", "CA1039")]`

 This format is not recommended because of maintainability issues.

## Suppressing Multiple Violations within a method body
 Attributes can only be applied to a method and cannot be embedded within the method body. However, you can specify the identifier as the message ID to distinguish multiple occurrences of a violation within a method.

 [!code-cpp[InSourceSuppression#1](../snippets/cpp/VS_Snippets_CodeAnalysis/InSourceSuppression/cpp/insourcesuppression.cpp#1)]
 [!code-csharp[InSourceSuppression#1](../snippets/csharp/VS_Snippets_CodeAnalysis/InSourceSuppression/cs/InSourceSuppression.cs#1)]
 [!code-vb[InSourceSuppression#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/InSourceSuppression/vb/InSourceSuppression.vb#1)]

## Generated Code
 Managed code compilers and some third-party tools generate code to facilitate rapid code development. Compiler-generated code that appears in source files is usually marked with the **GeneratedCodeAttribute** attribute.

 You can choose whether to suppress Code Analysis warnings and errors for generated code. For information about how to suppress such warnings and errors, see [How to: Suppress Warnings for Generated Code](../code-quality/how-to-suppress-code-analysis-warnings-for-generated-code.md).

 Note that Code Analysis ignores **GeneratedCodeAttribute** when it is applied to either an entire assembly or a single parameter. These situations occur rarely.

## Global-Level Suppressions
 The managed code analysis tool examines **SuppressMessage** attributes that are applied at the assembly, module, type, member, or parameter level. It also fires violations against resources and namespaces. These violations must be applied at the global level and are scoped and targeted. For example, the following message suppresses a namespace violation:

 `[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MyNamespace")]`

> [!NOTE]
> When you suppress a warning with namespace scope, it suppresses the warning against the namespace itself. It does not suppress the warning against types within the namespace.

 Any suppression can be expressed by specifying an explicit scope. These suppressions must live at the global level. You cannot specify member-level suppression by decorating a type.

 Global-level suppressions are the only way to suppress messages that refer to compiler-generated code that does not map to explicitly provided user source. For example, the following code suppresses a violation against a compiler-emitted constructor:

 `[module: SuppressMessage("Microsoft.Design", "CA1055:AbstractTypesDoNotHavePublicConstructors", Scope="member", Target="Microsoft.Tools.FxCop.Type..ctor()")]`

> [!NOTE]
> Target always contains the fully-qualified item name.

## Global Suppression File
 The global suppression file maintains suppressions that are either global-level suppressions or suppressions that do not specify a target. For example, suppressions for assembly level violations are stored in this file. Additionally, some ASP.NET suppressions are stored in this file because project level settings are not available for code behind a form. A global suppression is created and added to your project the first time that you select the **In Project Suppression File** option of the **Suppress Message(s)** command in the Error List window. For more information, see [How to: Suppress Warnings by Using the Menu Item](../code-quality/how-to-suppress-warnings-by-using-the-menu-item.md).

## See Also
 <xref:System.Diagnostics.CodeAnalysis>
