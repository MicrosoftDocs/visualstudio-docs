---
title: IntelliSense and formatting refactorings
description: Learn how to use IntelliSense completion for DateTime, TimeSpan, regex, and unimported types, and how to wrap, indent, and align code in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# IntelliSense and formatting refactorings

Visual Studio provides IntelliSense-based completions and formatting refactorings that help you write and organize code more efficiently.

## DateTime and TimeSpan completion

**Applies to:** C#

This feature uses the IntelliSense menu to help write DateTime and TimeSpan string literals and format strings. IntelliSense gives you basic completion and an explanation of what each character means.

1. Place your cursor in the DateTime or TimeSpan format string.
1. Press **Ctrl**+**Space** to trigger the **IntelliSense** menu.
1. Select the character you would like to add.

   ![Screenshot of DateTime Completion IntelliSense.](media/datetime-completion.png)

## Regex completion through IntelliSense

**Applies to:** C#, Visual Basic

This feature uses the IntelliSense menu to help write regular expressions. IntelliSense gives you basic completion and an explanation of what each regex character means.

1. Place your cursor in the regex string.
1. Press **Ctrl**+**Space** to trigger the **IntelliSense** menu.
1. Select the character you would like to add to your regex string.

   ![Screenshot of Regex Completion IntelliSense.](../media/regex-completion-intellisense.png)

## IntelliSense completion for unimported types and extension methods

**Applies to:** C#, Visual Basic

IntelliSense gives completion suggestions for types and extension methods that aren't imported with a `using` directive, and automatically adds the `using` directive when you commit the suggestion.

1. After you start to enter the name of a type or extension method with a dependency in your project, IntelliSense shows you suggestions. In the list, items from unimported namespaces are shown with their containing namespace as a suffix.

   :::moniker range="visualstudio"

   > [!TIP]
   > You can show/hide items from unimported namespaces on demand by selecting **Expander** next to the completion list. (Or use the **Alt**+**A** keyboard shortcut.)
   >
   > To change the default behavior, open the **Tools** > **Options** pane and expand the **All Settings** > **Languages** > **C#** (or **Visual Basic**) > **IntelliSense** section. Select or clear the **Show items from unimported namespaces** checkbox.

   :::moniker-end
   :::moniker range="<=vs-2022"

   > [!TIP]
   > You can show/hide items from unimported namespaces on demand by selecting **Expander** next to the completion list. (Or use the **Alt**+**A** keyboard shortcut.)
   >
   > To change the default behavior, open the **Tools** > **Options** dialog and expand the **Text Editor** > **C#** (or **Visual Basic**) > **IntelliSense** section. Select or clear the **Show items from unimported namespaces** checkbox, and then select **OK**.

   :::moniker-end

1. Select a suggestion and commit an unimported item.

   The `using` directive is automatically added to your file.

   ![Screenshot of IntelliSense completion for unimported types.](media/intellisense-completion-unimported-types.png)

## Wrap and align call chains

**Applies to:** C#, Visual Basic

This refactoring wraps and aligns chains of method calls for improved readability.

1. Place your cursor in any of the call chains.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Wrap call chain** or **Wrap and align call chain** to accept the refactoring.

   ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Wrap call chain selected and C# code changes shown.](media/wrap-call-chain.png)

## Wrap, indent, and align parameters or arguments

**Applies to:** C#, Visual Basic

This refactoring wraps, indents, and aligns parameters or arguments in method declarations or calls for improved readability.

1. Place your cursor in a parameter list.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Wrap, Indent, and Align parameters.](media/wrap-parameters.png)

1. Select **Wrap every parameter** to accept the refactoring.

## Wrap binary expressions

**Applies to:** C#, Visual Basic

This refactoring wraps binary expressions for improved readability.

1. Place your cursor in the binary expression.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Wrap expression** to accept the refactoring.

   ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Wrap expression selected and C# code changes shown.](media/wrap-binary-expression.png)

## Related content

- [IntelliSense](../using-intellisense.md)
- [Refactoring](../refactoring-in-visual-studio.md)
