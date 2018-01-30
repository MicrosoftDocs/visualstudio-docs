---
title: "Quick Actions | Microsoft Docs"
ms.custom: ""
ms.date: "11/30/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
dev_langs: 
  - CSharp
  - VB
ms.workload: 
  - "multiple"
---
# Quick Actions

Quick Actions let you easily refactor, generate, or otherwise modify code with a single action. Quick Actions are available for C#, [C++](/cpp/ide/writing-and-refactoring-code-cpp), and Visual Basic code files. Some actions are specific to a language, and others apply to all languages.

Quick Actions can be applied by using the light bulb icon ![Small Light Bulb Icon](media/vs2015_lightbulbsmall.png), or by pressing **Ctrl**+**.** when your cursor is on the appropriate line of code. You will see a light bulb if there is a red squiggle and Visual Studio has a suggestion for how to fix the issue. For instance if you have an error indicated by a red squiggle, a light bulb will appear when fixes are available for that error.

For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs will light up based on those rules.

## To see a light bulb

1. In many cases, light bulbs spontaneously appear when you hover the mouse at the point of an error, or in the left margin of the editor when you move the caret into a line that has an error in it. When you see a red squiggle, you can hover over it to display the light bulb. You can also cause a light bulb to display when you use the mouse or keyboard to go to anywhere in the line where the issue occurs.

1. Press **Ctrl**+**.** anywhere on a line to invoke the light bulb and go directly to the list of potential fixes.

   ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png "VS2017_LightBulb_Hover")

## To see potential fixes

Either click on the down arrow or the Show potential fixes link to display a list of quick actions that the light bulb can take for you.

![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png "VS2017_LightBulb_hover_expanded")

## See also

[Code generation in Visual Studio](../ide/code-generation-in-visual-studio.md)  
[Common Quick Actions](../ide/common-quick-actions.md)  
[Code styles and Quick Actions](../ide/code-styles-and-quick-actions.md)  
[Writing and refactoring code (C++)](/cpp/ide/writing-and-refactoring-code-cpp)