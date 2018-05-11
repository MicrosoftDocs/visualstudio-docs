---
title: Quick Actions, light bulbs, and screwdrivers
ms.date: 03/28/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "multiple"
---
# Quick Actions

Quick Actions let you easily refactor, generate, or otherwise modify code with a single action. Quick Actions are available for C#, [C++](/cpp/ide/writing-and-refactoring-code-cpp), and Visual Basic code files. Some actions are specific to a language, and others apply to all languages.

Quick Actions can be used to:

- Apply a code fix for a [code analyzer](../code-quality/roslyn-analyzers-overview.md) rule violation
- [Suppress](../code-quality/use-roslyn-analyzers.md) a code analyzer rule violation
- Apply a refactoring (for example, [inline a temporary variable](../ide/reference/inline-temporary-variable.md))
- Generate code (for example, [introduce a local variable](../ide/reference/introduce-local-variable.md))

Quick Actions can be applied by using the light bulb ![light bulb icon](media/light-bulb-icon.png) or screwdriver ![screwdriver icon](media/screwdriver-icon.png) icons, or by pressing **Ctrl**+**.** when your cursor is on a line of code for which an action is available. You'll see an error light bulb ![error light bulb icon](media/error-light-bulb-icon.png) if there is a red squiggle indicating an error, and Visual Studio has a fix available for that error.

For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs light up based on those rules.

## Icons

The icon that appears when a Quick Action is available gives an indication of the type of fix or refactoring that's available. The *screwdriver* ![screwdriver icon](media/screwdriver-icon.png) icon indicates just that there are actions available to change the code, but you shouldn't necessarily use them. The *yellow light bulb* ![light bulb icon](media/light-bulb-icon.png) icon indicates there are actions available that you *should* do to improve your code. The *error light bulb* ![error light bulb icon](media/error-light-bulb-icon.png) icon indicates there's an action available that fixes an error in your code.

## To see a light bulb or screwdriver

- If a fix is available, light bulbs spontaneously appear when you hover the mouse at the location of an error.

   ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png)

- Light bulbs and screwdrivers appear in the left margin of the editor when you move the caret into a line of code for which a Quick Action is available.

- Press **Ctrl**+**.** anywhere on a line to see a list of available Quick Actions and refactorings.

## To see potential fixes

Select either the down arrow next to the light bulb or the **Show potential fixes** link to display a list of Quick Actions that are available.

![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png)

## See also

- [Code generation in Visual Studio](../ide/code-generation-in-visual-studio.md)
- [Common Quick Actions](../ide/common-quick-actions.md)
- [Code styles and Quick Actions](../ide/code-styles-and-quick-actions.md)
- [Write and refactor code (C++)](/cpp/ide/writing-and-refactoring-code-cpp)