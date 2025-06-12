---
title: Quick Actions, light bulbs, and screwdrivers
description: Use a single Quick Action in Visual Studio to refactor, generate, or modify your C#, C++, or Visual Basic code files to apply updates and fixes or generate code.
ms.date: 03/26/2025
ms.topic: concept-article
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
- CSharp
- VB
ms.collection: ce-skilling-ai-copilot

#customer intent: As a developer, I want to use Quick Actions in Visual Studio, so I can modify my code files to apply updates and fixes or generate code.
---

# Quick Actions

Quick Actions in Visual Studio let you easily refactor, generate, or otherwise modify your code with a single action. Quick Actions are available for C#, [C++](/cpp/ide/writing-and-refactoring-code-cpp), and Visual Basic code files. Some actions are specific to a language, and others apply to all languages.

Quick Actions can be used to:

- Apply a code fix for a [code analyzer](../code-quality/roslyn-analyzers-overview.md) rule violation
- [Suppress](../code-quality/use-roslyn-analyzers.md#suppress-violations) a code analyzer rule violation or [configure](../code-quality/use-roslyn-analyzers.md#set-rule-severity-from-the-light-bulb-menu) its severity
- Apply a refactoring, such as [inline for a temporary variable](../ide/reference/inline-temporary-variable.md)
- Generate code, such as to [introduce a local variable](../ide/reference/introduce-local-variable.md)

## Understand Quick Action icons

Visual Studio uses several icons to indicate when Quick Actions are available. The icon type indicates whether the Quick Action is a recommendation or required fix, including refactoring:

- **Screwdriver** ![screwdriver icon](media/screwdriver-icon.png): Suggested action to improve your code.

- **Yellow light bulb** ![light bulb icon](media/light-bulb-icon.png): Recommended action to address noncritical issues with your code.

- **Error light bulb** ![error light bulb icon](media/error-light-bulb-icon.png): Critical action to fix an error in your code, or apply necessary refactoring.

For any language, third parties can provide custom diagnostics and suggestions, such as part of an SDK. Visual Studio shows light bulbs based on those rules.

## Find available actions

You can check your code for available Quick Actions in Visual Studio by scanning for the light bulb ![light bulb icon](media/light-bulb-icon.png), screwdriver ![screwdriver icon](media/screwdriver-icon.png), and error light bulb ![error light bulb icon](media/error-light-bulb-icon.png):

- Move your mouse over your code and notice any Quick Action icons:

   :::image type="content" source="../ide/media/vs2022-lightbulb-hover.png" border="false" alt-text="Screenshot that shows the basic Quick Action recommendation and light bulb icon in Visual Studio.":::

- Move the insertion cursor (|) into a line of code, and check for Quick Action icons in the left margin of the code editor.

You can also manually check for any available Quick Actions:

- Right-click a line of code and choose **Quick Actions and Refactorings** for a list of available Quick Actions and refactoring options.

- Select Ctrl + period (.) anywhere on a line.

## Apply recommendations to improve code

When Quick Actions are available, you can select the light bulb ![light bulb icon](media/light-bulb-icon.png) or screwdriver ![screwdriver icon](media/screwdriver-icon.png) icon next to the applicable code.

- To see the available improvements, select the Down arrow next to the icon or use the **Show potential fixes** link. 

   :::image type="content" source="../ide/media/vs2022-lightbulb-hover-expanded.png" border="false" alt-text="Screenshot that shows the Quick Action recommendation details with the light bulb icon in Visual Studio.":::

- To apply the recommended change to your code, select the icon. You can also select Ctrl + period (.) when your cursor is on a line of code that shows an available action.

## Apply actions to fix errors

If there's an error in your code, and Visual Studio has a recommended fix, you see a red squiggle under the code with the error. The error light bulb ![error light bulb icon](media/error-light-bulb-icon.png) icon also displays next to the marked code.

- To see the available fixes, select the Down arrow next to the icon or use the **Show potential fixes** link. 

   :::image type="content" source="../ide/media/vs2022-error-lightbulb-hover.png" border="false" alt-text="Screenshot that shows the Quick Action potential fix and error light bulb icon in Visual Studio.":::

- To apply the recommended change to your code, select the icon. You can also select Ctrl + period (.) when your cursor is on a line of code that shows an available action.

> [!TIP]
> You can turn off some of the code fix Quick Actions. For more information, see [Disable source code analysis for .NET](../code-quality/disable-code-analysis.md).

::: moniker range=">=vs-2022"
## Get AI assistance

If you have [Copilot](../ide/visual-studio-github-copilot-extension.md), you can get AI assistance while using the Quick Actions light bulb. From the light bulb menu, choose **Fix with Copilot**. This opens an inline chat with GitHub Copilot Chat, offering you an available fix.

:::image type="content" source="../ide/media/vs-2022/quick-action-lightbulb-github-copilot.png" border="false" alt-text="Screenshot that shows the Quick Action GitHub Copilot option for the light bulb.":::
::: moniker-end

## Related content

- [Common Quick Actions](../ide/common-quick-actions.md)
- [Code styles and Quick Actions](../ide/code-styles-and-code-cleanup.md)
- [Visual Studio IntelliCode](/visualstudio/intellicode/intellicode-visual-studio)
