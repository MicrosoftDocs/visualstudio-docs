---
title: About the Editor Sticky Scroll feature
description: Use the Sticky Scroll feature in Visual Studio quickly view code scopes at the top of the editor, which helps you stay in the right context while you code. 
ms.date: 05/18/2023
ms.topic: overview 
ms.custom: template-overview
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2022
---
# What is Sticky Scroll for Visual Studio?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When you work in a large code file or scroll through an unfamiliar codebase, sometimes it can be difficult to tell where you are in the code. With **Sticky Scroll**&mdash;previewed first in Visual Studio 2022 [version 17.5](/visualstudio/releases/2022/release-notes-v17.5)&mdash;you can *stick* scopes to the top of the editor so that they're always in view while you *scroll* through your code.

## Supported programming languages

Multiple code formats are supported, including C#, C++, XAML, and JSON.

Here's an animated example of Sticky Scroll in a C# file:

:::image type="content" source="media/vs-2022/sticky-scroll-example-csharp.gif" alt-text="An animation of the Sticky Scroll feature being used in C# code.":::

Here's an animated example of Sticky Scroll in a C++ file:

:::image type="content" source="media/vs-2022/sticky-scroll-example-cplusplus.gif" alt-text="An animation of the Sticky Scroll feature being used in C++ code.":::

## Turn Sticky Scroll on or off

1. From the Visual Studio menu bar, select **Tools** > **Options** > **Text Editor** > **General**. 
1. In the **Sticky scroll** section, and toggle the **Group the current scopes within a scrollable region of the editor window** checkbox. 

> [!TIP]
> If you want to quickly turn off Sticky Scroll, you can do so from the editor by right-clicking in the Sticky Scroll area and then selecting **Sticky Scroll**.  

## How Sticky Scroll works

You can use Sticky Scroll to stick scopes such as namespaces, classes, methods, loop initialization statements, and conditionals. And, you can jump directly to a line of code by clicking its reference in the Sticky Scroll header. 

:::image type="content" source="media/vs-2022/sticky-scroll-single-click-example.gif" alt-text="An animation of the single-click option in the Sticky Scroll header that takes to code.":::

### Inner and outer scopes

Based on your preference, you can changed what Sticky Scroll shows you. Set by default, **outer** scopes show the higher-level scopes that come from the top of the file. 

:::image type="content" source="media/vs-2022/sticky-scroll-scopes-outer.gif" alt-text="An animation of the Sticky Scroll with outer scopes selected.":::

But sometimes, the namespace and class name match the file name. When info such as this is obvious, you might not want to give up two lines of vertical space at the top of your file. Then, you can change to lower-level **inner** scopes, which pushes out higher-level scopes as you scroll through deeply nested code.

:::image type="content" source="media/vs-2022/sticky-scroll-scopes-inner.gif" alt-text="An animation of the Sticky Scroll with inner scopes selected.":::

You can configure whether outer or inner scopes are prioritized when a number of scopes exceeds the maximum. From the Visual Studio menu bar, select **Tools** > **Options**> **Text Editor** > **Sticky scroll**, and then toggle between **Prefer outer scopes** and **Prefer inner scopes**.

:::image type="content" source="media/vs-2022/sticky-scroll-options.png" alt-text="Screenshot of the inner and outer scope options for Sticky Scroll." lightbox="media/vs-2022/sticky-scroll-options.png":::

## Next steps

To learn more about Sticky Scroll in Visual Studio, consider exploring the following resources:

- [Sticky Scroll: Preview](https://devblogs.microsoft.com/visualstudio/sticky-scroll-now-in-preview/)
- [Sticky Scroll: Stay in the right context](https://devblogs.microsoft.com/visualstudio/sticky-scroll-stay-in-the-right-context/)