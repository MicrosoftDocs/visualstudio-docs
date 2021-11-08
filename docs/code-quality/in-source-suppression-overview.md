---
title: Suppress code analysis violations
ms.date: 05/10/2021
description: Learn how to suppress code analysis violations in Visual Studio. Understand how to use the SuppressMessageAttribute attribute for in-source suppression.
ms.custom: SEO-VS-2020
ms.topic: conceptual
helpviewer_keywords:
- source suppression, code analysis
- code analysis, source suppression
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-code-analysis
dev_langs:
- CSharp
- VB
- CPP
ms.workload:
- multiple
---
# Suppress code analysis violations

It is often useful to indicate that a warning is not applicable. This indicates to team members that the code was reviewed, and that the warning can be suppressed. This article describes the different ways to suppress code analysis violations using the Visual Studio IDE.

::: moniker range=">=vs-2019"

## Suppress violations using the EditorConfig file

In an **EditorConfig file**, set the severity to `none`, for example, `dotnet_diagnostic.CA1822.severity = none`. To add an EditorConfig file, see [Add an EditorConfig file to a project](../ide/create-portable-custom-editor-options.md#add-and-remove-editorconfig-files).

::: moniker-end

## Suppress violations in source code

You can suppress violations in code using a preprocessor directive, the [#pragma warning (C#)](/dotnet/csharp/language-reference/preprocessor-directives#pragma-warning) or [Disable (Visual Basic)](/dotnet/visual-basic/language-reference/directives/disable-enable) directive to suppress the warning for only a specific line of code. Or, you can use the [SuppressMessage attribute](#in-source-suppression-and-the-suppressmessage-attribute).

- From the **code editor**

  Place the cursor in the line of code with the violation and press **Ctrl**+**Period (.)** to open the **Quick Actions** menu. Select **Suppress CAXXXX**, and then choose either **in Source** or **in Source (attribute)**.

  If you choose **in Source**, you see a preview of the preprocessor directive that will be added to your code.

  ::: moniker range="vs-2017"
  :::image type="content" source="media/suppress-diagnostic-from-editor.png" alt-text="Suppress diagnostic from quick actions menu":::
  ::: moniker-end
  ::: moniker range=">=vs-2019"
  :::image type="content" source="media/vs-2019/suppress-diagnostic-from-editor.png" alt-text="Suppress diagnostic from quick actions menu":::

  If you choose **in Source (attribute)**, you see a preview of the [SuppressMessage attribute](#in-source-suppression-and-the-suppressmessage-attribute) that will be added to your code.

  :::image type="content" source="media/vs-2019/suppress-diagnostic-from-editor-attribute.png" alt-text="Suppress diagnostic from quick actions menu using attribute":::
  ::: moniker-end

- From the **Error List**

  Select the rules you want to suppress, and then right-click and select **Suppress** > **In Source**.

  - If you suppress **In Source**, the **Preview Changes** dialog opens and shows a preview of the C# [#pragma warning](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-pragma-warning) or Visual Basic [#Disable warning](/dotnet/visual-basic/language-reference/directives/directives) directive that's added to the source code.

    ![Preview of adding #pragma warning in code file](media/pragma-warning-preview.png)

  In the **Preview Changes** dialog, select **Apply**.

  > [!NOTE]
  > If you don't see the **Suppress** menu option in **Solution Explorer**, the violation is likely coming from build and not live analysis. The **Error List** displays diagnostics, or rule violations, from both live code analysis and build. Since the build diagnostics can be stale, for example, if you've edited the code to fix the violation but haven't rebuilt, you cannot suppress these diagnostics from the **Error List**. Diagnostics from live analysis, or IntelliSense, are always up-to-date with current sources and can be suppressed from the **Error List**. To exclude *build* diagnostics from your selection, switch the **Error List** source filter from **Build + IntelliSense** to **IntelliSense Only**. Then, select the diagnostics you want to suppress and proceed as described previously.
  >
  > ![Error List source filter in Visual Studio](media/error-list-filter.png)

## Suppress violations using a global suppression file

The [global suppression file](#global-level-suppressions) uses the [SuppressMessage attribute](#in-source-suppression-and-the-suppressmessage-attribute).

- From the **Error List**, select the rules you want to suppress, and then right-click and select **Suppress** > **in Suppression File**. The **Preview Changes** dialog opens and shows a preview of the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute that's added to the global suppressions file.

  ![Preview of adding SuppressMessage attribute to suppression file](media/preview-changes-in-suppression-file.png)

- From the **code editor**, place the cursor in the line of code with the violation and press **Quick actions and refactorings** (or press **Ctrl**+**Period (.)**) to open the **Quick Actions** menu. Select **Suppress CAXXXX**, and then choose **in Suppression File**. You see a preview of the [global suppression file](#global-level-suppressions) that will be created or modified.

::: moniker range=">=vs-2019"

- From the **Analyze** menu, select **Analyze** > **Build and Suppress Active Issues** on the menu bar to suppress all current violations. This is sometimes referred to as "baselining".

::: moniker-end
::: moniker range="vs-2017"

- From the **Analyze** menu, select **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar to suppress all current violations. This is sometimes referred to as "baselining".
::: moniker-end

## Suppress violations using project settings

From **Solution Explorer**, open the properties for the project (right-click the project and choose **Properties** (or press **Alt + Enter**) and use the **Code Analysis** tab to configure options. For example, you can disable live code analysis or disable .NET analyzers.

## Suppress violations using a rule set

From the **rule set editor**, clear the check box next to its name or set **Action** to **None**.

## In-source suppression and the SuppressMessage attribute

In-source suppression (ISS) uses the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute to suppress a warning. The attribute can be placed close to the code segment that generated the warning. You can add the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute to the source file by typing it in, or you can use the shortcut menu on a warning in the **Error List** to add it automatically.

The <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is a conditional attribute, which is included in the IL metadata of your managed code assembly, only if the CODE_ANALYSIS compilation symbol is defined at compile time.

In C++/CLI, use the macros CA\_SUPPRESS\_MESSAGE or CA\_GLOBAL\_SUPPRESS_MESSAGE in the header file to add the attribute.

> [!NOTE]
> You should not use in-source suppressions on release builds, to prevent shipping the in-source suppression metadata accidentally. Additionally, because of the processing cost of in-source suppression, the performance of your application can be degraded.

::: moniker range="vs-2017"

> [!NOTE]
> If you migrate a project to Visual Studio 2017, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by selecting **Analyze** > **Run Code Analysis and Suppress Active Issues**.
>
> ![Run code analysis and suppress issues in Visual Studio](media/suppress-active-issues.png)

::: moniker-end

::: moniker range=">=vs-2019"

> [!NOTE]
> If you migrate a project to Visual Studio 2019, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by selecting **Analyze** > **Build and Suppress Active Issues**.

::: moniker-end

### SuppressMessage attribute

When you select **Suppress** from the context or right-click menu of a code analysis warning in the **Error List**, a <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is added either in your code or to the project's global suppression file.

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

- **Category** - The category in which the rule is defined. For more information about code analysis rule categories, see [Managed code warnings](/dotnet/fundamentals/code-analysis/quality-rules/index).

- **CheckId** - The identifier of the rule. Support includes both a short and long name for the rule identifier. The short name is CAXXXX; the long name is CAXXXX:FriendlyTypeName.

- **Justification** - The text that is used to document the reason for suppressing the message.

- **MessageId** - Unique identifier of a problem for each message.

- **Scope** - The target on which the warning is being suppressed. If the target is not specified, it is set to the target of the attribute. Supported [scopes](xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute.Scope) include the following:

  - [`module`](#module-suppression-scope) - This scope suppresses warnings against an assembly. It is a global suppression that applies to the entire project.

  - `resource` - ([legacy FxCop](../code-quality/static-code-analysis-for-managed-code-overview.md) only) This scope suppresses warnings in diagnostic info written to resource files that are part of the module (assembly). This scope is not read/respected in C#/VB compilers for Roslyn analyzer diagnostics, which only analyzes source files.

  - `type` - This scope suppresses warnings against a type.

  - `member` - This scope suppresses warnings against a member.

  - `namespace` - This scope suppresses warnings against the namespace itself. It does not suppress warnings against types within the namespace.

  - `namespaceanddescendants` - (Requires compiler version 3.x or higher and Visual Studio 2019) This scope suppresses warnings in a namespace and all its descendant symbols. The `namespaceanddescendants` value is ignored by legacy analysis.

- **Target** - An identifier that is used to specify the target on which the warning is being suppressed. It must contain a fully qualified item name.

When you see warnings in Visual Studio, you can view examples of `SuppressMessage` by [adding a suppression to the global suppression file](../code-quality/use-roslyn-analyzers.md#suppress-violations). The suppression attribute and its required properties appear in a preview window.

### SuppressMessage usage

Code Analysis warnings are suppressed at the level to which the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute is applied. For example, the attribute can be applied at the assembly, module, type, member, or parameter level. The purpose of this is to tightly couple the suppression information to the code where the violation occurs.

The general form of suppression includes the rule category and a rule identifier, which contains an optional human-readable representation of the rule name. For example:

`[SuppressMessage("Microsoft.Design", "CA1039:ListsAreStrongTyped")]`

If there are strict performance reasons for minimizing in-source suppression metadata, the rule name can be omitted. The rule category and its rule ID together constitute a sufficiently unique rule identifier. For example:

`[SuppressMessage("Microsoft.Design", "CA1039")]`

For maintainability reasons, omitting the rule name is not recommended.

### Suppress selective violations within a method body

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

### Global-level suppressions

The managed code analysis tool examines `SuppressMessage` attributes that are applied at the assembly, module, type, member, or parameter level. It also fires violations against resources and namespaces. These violations must be applied at the global level and are scoped and targeted. For example, the following message suppresses a namespace violation:

`[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MyNamespace")]`

> [!NOTE]
> When you suppress a warning with `namespace` scope, it suppresses the warning against the namespace itself. It does not suppress the warning against types within the namespace.

Any suppression can be expressed by specifying an explicit scope. These suppressions must live at the global level. You cannot specify member-level suppression by decorating a type.

Global-level suppressions are the only way to suppress messages that refer to compiler-generated code that does not map to explicitly provided user source. For example, the following code suppresses a violation against a compiler-emitted constructor:

`[module: SuppressMessage("Microsoft.Design", "CA1055:AbstractTypesDoNotHavePublicConstructors", Scope="member", Target="Microsoft.Tools.FxCop.Type..ctor()")]`

> [!NOTE]
> `Target` always contains the fully qualified item name.

#### Global suppression file

The global suppression file maintains suppressions that are either global-level suppressions or suppressions that do not specify a target. For example, suppressions for assembly-level violations are stored in this file. Additionally, some ASP.NET suppressions are stored in this file because project-level settings are not available for code behind a form. A global suppression file is created and added to your project the first time that you select the **In Project Suppression File** option of the **Suppress** command in the **Error List** window.

#### Module suppression scope

You can suppress code quality violations for the entire assembly by using the **module** scope.

For example, the following attribute in your _GlobalSuppressions_ project file will suppress the ConfigureAwait violation for an ASP.NET Core project:

`[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2007:Consider calling ConfigureAwait on the awaited task", Justification = "ASP.NET Core doesn't use thread context to store request context.", Scope = "module")]`

### Generated code

Managed code compilers and some third-party tools generate code to facilitate rapid code development. Compiler-generated code that appears in source files is usually marked with the `GeneratedCodeAttribute` attribute.

For source code analysis, you can suppress messages in generated code in an `.editorconfig` file. For more information, see [Exclude generated code](/dotnet/fundamentals/code-analysis/configuration-options#exclude-generated-code).

For legacy code analysis, you can choose whether to suppress code analysis warnings and errors for generated code. For information about how to suppress such warnings and errors, see [How to: Suppress Warnings for Generated Code](../code-quality/how-to-suppress-code-analysis-warnings-for-generated-code.md).

> [!NOTE]
> Code analysis ignores `GeneratedCodeAttribute` when it is applied to either an entire assembly or a single parameter.

## See also

- <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute.Scope>
- <xref:System.Diagnostics.CodeAnalysis>
- [Use code analyzers](../code-quality/use-roslyn-analyzers.md)
