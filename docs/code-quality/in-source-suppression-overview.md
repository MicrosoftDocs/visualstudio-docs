---
title: Suppress code analysis warnings
ms.date: 12/01/2018
ms.topic: "conceptual"
helpviewer_keywords:
  - "source suppression, code analysis"
  - "code analysis, source suppression"
author: jillre
ms.author: jillfra
manager: jillfra
dev_langs:
 - CSharp
 - VB
 - CPP
ms.workload:
  - "multiple"
---
# Suppress code analysis warnings

It is often useful to indicate that a warning is not applicable. This indicates to team members that the code was reviewed, and that the warning can be suppressed. In-source suppression (ISS) uses the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute to suppress a warning. The attribute can be placed close to the code segment that generated the warning. You can add the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute to the source file by typing it in, or you can use the shortcut menu on a warning in the **Error List** to add it automatically.

The <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is a conditional attribute, which is included in the IL metadata of your managed code assembly, only if the CODE_ANALYSIS compilation symbol is defined at compile time.

In C++/CLI, use the macros CA\_SUPPRESS\_MESSAGE or CA\_GLOBAL\_SUPPRESS_MESSAGE in the header file to add the attribute.

> [!NOTE]
> You should not use in-source suppressions on release builds, to prevent shipping the in-source suppression metadata accidentally. Additionally, because of the processing cost of in-source suppression, the performance of your application can be degraded.

::: moniker range="vs-2017"

> [!NOTE]
> If you migrate a project to Visual Studio 2017, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues**.
>
> ![Run code analysis and suppress issues in Visual Studio](media/suppress-active-issues.png)

::: moniker-end

::: moniker range=">=vs-2019"

> [!NOTE]
> If you migrate a project to Visual Studio 2019, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by choosing **Analyze** > **Build and Suppress Active Issues**.

::: moniker-end

## SuppressMessage attribute

When you choose **Suppress** from the context or right-click menu of a code analysis warning in the **Error List**, a <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is added either in your code or to the project's global suppression file.

The <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute has the following format:

```vb
<Scope:SuppressMessage("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")>
```

```csharp
[Scope:SuppressMessage("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")]
```

```cpp
CA_SUPPRESS_MESSAGE("Rule Category", "Rule Id", Justification = "Justification", MessageId = "MessageId", Scope = "Scope", Target = "Target")
```

The properties of the attribute include:

- **Category** - The category in which the rule is defined. For more information about code analysis rule categories, see [Managed code warnings](../code-quality/code-analysis-for-managed-code-warnings.md).

- **CheckId** - The identifier of the rule. Support includes both a short and long name for the rule identifier. The short name is CAXXXX; the long name is CAXXXX:FriendlyTypeName.

- **Justification** - The text that is used to document the reason for suppressing the message.

- **MessageId** - Unique identifier of a problem for each message.

- **Scope** - The target on which the warning is being suppressed. If the target is not specified, it is set to the target of the attribute. Supported [scopes](xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute.Scope) include the following:

  - `module`

  - `resource`

  - `type`

  - `member`

  - `namespace` - This scope suppresses warnings against the namespace itself. It does not suppress warnings against types within the namespace.

  - `namespaceanddescendants` - (New for Visual Studio 2019) This scope suppresses warnings in a namespace and all its descendant symbols. The `namespaceanddescendants` value is ignored by legacy analysis.

- **Target** - An identifier that is used to specify the target on which the warning is being suppressed. It must contain a fully qualified item name.

## SuppressMessage usage

Code Analysis warnings are suppressed at the level to which the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is applied. For example, the attribute can be applied at the assembly, module, type, member, or parameter level. The purpose of this is to tightly couple the suppression information to the code where the violation occurs.

The general form of suppression includes the rule category and a rule identifier, which contains an optional human-readable representation of the rule name. For example:

`[SuppressMessage("Microsoft.Design", "CA1039:ListsAreStrongTyped")]`

If there are strict performance reasons for minimizing in-source suppression metadata, the rule name can be omitted. The rule category and its rule ID together constitute a sufficiently unique rule identifier. For example:

`[SuppressMessage("Microsoft.Design", "CA1039")]`

For maintainability reasons, omitting the rule name is not recommended.

## Suppress selective violations within a method body

Suppression attributes can be applied to a method, but cannot be embedded within a method body. This means that all violations of a particular rule are suppressed if you add the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute to the method.

In some cases, you might want to suppress a particular instance of the violation, for example so that future code isn't automatically exempt from the code analysis rule. Certain code analysis rules allow you to do this by using the `MessageId` property of the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute. In general, legacy rules for violations on a particular symbol (a local variable or parameter) respect the `MessageId` property. [CA1500:VariableNamesShouldNotMatchFieldNames](../code-quality/ca1500.md) is an example of such a rule. However, legacy rules for violations on executable code (non-symbol) do not respect the `MessageId` property. Additionally, .NET Compiler Platform ("Roslyn") analyzers do not respect the `MessageId` property.

To suppress a particular symbol violation of a rule, specify the symbol name for the `MessageId` property of the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute. The following example shows code with two violations of [CA1500:VariableNamesShouldNotMatchFieldNames](../code-quality/ca1500.md)&mdash;one for the `name` variable and one for the `age` variable. Only the violation for the `age` symbol is suppressed.

```vb
Public Class Animal
    Dim age As Integer
    Dim name As String

    <CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId:="age")>
    Sub PrintInfo()
        Dim age As Integer = 5
        Dim name As String = "Charlie"

        Console.WriteLine("Age {0}, Name {1}", age, name)
    End Sub

End Class
```

```csharp
public class Animal
{
    int age;
    string name;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "age")]
    private void PrintInfo()
    {
        int age = 5;
        string name = "Charlie";

        Console.WriteLine($"Age {age}, Name {name}");
    }
}
```

## Generated code

Managed code compilers and some third-party tools generate code to facilitate rapid code development. Compiler-generated code that appears in source files is usually marked with the `GeneratedCodeAttribute` attribute.

You can choose whether to suppress code analysis warnings and errors for generated code. For information about how to suppress such warnings and errors, see [How to: Suppress Warnings for Generated Code](../code-quality/how-to-suppress-code-analysis-warnings-for-generated-code.md).

> [!NOTE]
> Code analysis ignores `GeneratedCodeAttribute` when it is applied to either an entire assembly or a single parameter.

## Global-level suppressions

The managed code analysis tool examines `SuppressMessage` attributes that are applied at the assembly, module, type, member, or parameter level. It also fires violations against resources and namespaces. These violations must be applied at the global level and are scoped and targeted. For example, the following message suppresses a namespace violation:

`[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MyNamespace")]`

> [!NOTE]
> When you suppress a warning with `namespace` scope, it suppresses the warning against the namespace itself. It does not suppress the warning against types within the namespace.

Any suppression can be expressed by specifying an explicit scope. These suppressions must live at the global level. You cannot specify member-level suppression by decorating a type.

Global-level suppressions are the only way to suppress messages that refer to compiler-generated code that does not map to explicitly provided user source. For example, the following code suppresses a violation against a compiler-emitted constructor:

`[module: SuppressMessage("Microsoft.Design", "CA1055:AbstractTypesDoNotHavePublicConstructors", Scope="member", Target="Microsoft.Tools.FxCop.Type..ctor()")]`

> [!NOTE]
> `Target` always contains the fully qualified item name.

## Global suppression file

The global suppression file maintains suppressions that are either global-level suppressions or suppressions that do not specify a target. For example, suppressions for assembly-level violations are stored in this file. Additionally, some ASP.NET suppressions are stored in this file because project-level settings are not available for code behind a form. A global suppression file is created and added to your project the first time that you select the **In Project Suppression File** option of the **Suppress** command in the **Error List** window.

## See also

- <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute.Scope>
- <xref:System.Diagnostics.CodeAnalysis>
- [Use code analyzers](../code-quality/use-roslyn-analyzers.md)
