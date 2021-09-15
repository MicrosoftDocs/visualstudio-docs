---
title: Quick Actions, light bulbs, and screwdrivers
description: Learn how to use a single Quick Action to refactor, generate, or otherwise modify your code.
ms.custom: SEO-VS-2020
ms.date: 09/15/2021
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
- CSharp
- VB
ms.workload:
- multiple
---
# Quick Actions

Quick Actions let you easily refactor, generate, or otherwise modify code with a single action. Quick Actions are available for C#, [C++](/cpp/ide/writing-and-refactoring-code-cpp), and Visual Basic code files. Some actions are specific to a language, and others apply to all languages.

Quick Actions can be used to:

- Apply a code fix for a [code analyzer](../code-quality/roslyn-analyzers-overview.md) rule violation

::: moniker range=">=vs-2019"

- [Suppress](../code-quality/use-roslyn-analyzers.md#suppress-violations) a code analyzer rule violation or [configure](../code-quality/use-roslyn-analyzers.md#set-rule-severity-from-the-light-bulb-menu) its severity

::: moniker-end

::: moniker range="vs-2017"

- [Suppress](../code-quality/use-roslyn-analyzers.md#suppress-violations) a code analyzer rule violation

::: moniker-end

- Apply a refactoring (for example, [inline a temporary variable](../ide/reference/inline-temporary-variable.md))

- Generate code (for example, [introduce a local variable](../ide/reference/introduce-local-variable.md))

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Refactoring (Visual Studio for Mac)](/visualstudio/mac/refactoring).

Quick Actions can be applied by using the light bulb ![light bulb icon](media/light-bulb-icon.png) or screwdriver ![screwdriver icon](media/screwdriver-icon.png) icons, or by pressing **Ctrl**+**.** when your cursor is on a line of code for which an action is available. You'll see an error light bulb ![error light bulb icon](media/error-light-bulb-icon.png) if there's a red squiggle indicating an error and Visual Studio has a fix available for that error.

For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs appear based on those rules.

## Icons

The icon that appears when a Quick Action is available gives an indication of the type of fix or refactoring that's available. The *screwdriver* ![screwdriver icon](media/screwdriver-icon.png) icon indicates just that there are actions available to change the code, but you shouldn't necessarily use them. The *yellow light bulb* ![light bulb icon](media/light-bulb-icon.png) icon indicates there are actions available that you *should* do to improve your code. The *error light bulb* ![error light bulb icon](media/error-light-bulb-icon.png) icon indicates there's an action available that fixes an error in your code.

## To see a light bulb or screwdriver

If a fix is available, light bulbs appear:

- When you hover the mouse at the location of an error

   ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png)

- In the left margin of the editor when you move the caret (cursor) into the applicable line of code

You can also press **Ctrl**+**.** anywhere on a line to see a list of available Quick Actions and refactorings.

To see potential fixes, select either the down arrow next to the light bulb or the **Show potential fixes** link. A list of available Quick Actions is displayed.

![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png)

## See also

- [Visual Studio IntelliCode](/visualstudio/intellicode/intellicode-visual-studio)
- [Code generation in Visual Studio](../ide/code-generation-in-visual-studio.md)
- [Common Quick Actions](../ide/common-quick-actions.md)
- [Code styles and Quick Actions](../ide/code-styles-and-code-cleanup.md)
- [Write and refactor code (C++)](/cpp/ide/writing-and-refactoring-code-cpp)
- [Refactoring (Visual Studio for Mac)](/visualstudio/mac/refactoring)
