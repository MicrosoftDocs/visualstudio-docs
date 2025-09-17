---
title: About the Editor Sticky Scroll feature
description: Use the Sticky Scroll feature in Visual Studio to quickly view code scopes at the top of the editor, which helps you stay in the right context while you code. 
ms.date: 10/18/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2022"
#customer intent: As a developer, I want to learn how to use Sticky Scroll to help me understand where I am in unfamiliar code.
---

# What is Sticky Scroll for Visual Studio?

When you work in a large code file or scroll through an unfamiliar codebase, sometimes it can be difficult to tell where you are in the code. With *Sticky Scroll*, you can *stick* scopes to the top of the editor so that they're always in view while you *scroll* through your code. Visual Studio 2022 [version 17.5](/visualstudio/releases/2022/release-notes-v17.5) and later support Sticky Scroll.

## Supported programming languages

Multiple code formats are supported, including C#, C++, XAML, and JSON.

Here's an animated example of Sticky Scroll in a C# file:

:::image type="content" source="media/vs-2022/sticky-scroll-example-csharp.gif" alt-text="An animation of the Sticky Scroll feature being used in C# code.":::

Here's an animated example of Sticky Scroll in a C++ file:

:::image type="content" source="media/vs-2022/sticky-scroll-example-cplusplus.gif" alt-text="An animation of the Sticky Scroll feature being used in C++ code.":::

## Turn Sticky Scroll on or off

Use the following steps:

1. From the Visual Studio menu bar, select **Tools** > **Options** > **Text Editor** > **General**.
1. In the **Sticky scroll** section, select, or unselect, the **Group the current scopes within a scrollable region of the editor window** option.
1. Select **OK**.

If you want to turn Sticky Scroll off, you can do so from the editor by right-clicking in the Sticky Scroll header area and then selecting **Sticky Scroll**.

> [!IMPORTANT]
> If you're using C# and Sticky Scroll isn't working for you, try this workaround. Select **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**. Next, in the **Block Structure Guides** section, enable the following options.
>
> | Option   | Description |
> |:---------|:------------|
> |**Show guides for declaration level constructs** | Affects namespaces, classes, and method initializations |
> |**Show guides for code level constructs**        | Affects conditionals and loops |
>

## How Sticky Scroll works

You can use Sticky Scroll to stick scopes such as namespaces, classes, methods, loop initialization statements, and conditionals.

And, you can jump directly to a line of code by clicking its reference in the Sticky Scroll header.

:::image type="content" source="media/vs-2022/sticky-scroll-single-click-example.gif" alt-text="An animation of the single-click option in the Sticky Scroll header that takes to code.":::

## How to configure Sticky Scroll

You can change how Sticky Scroll works by changing its scope and the number of lines it includes in that scope.

### Inner and outer scopes

Based on your preference, you can change the scope of what Sticky Scroll shows you. Set by default, the *outer* scope option shows the higher-level scopes that come from the top of the file.

:::image type="content" source="media/vs-2022/sticky-scroll-scopes-outer.gif" alt-text="An animation of the Sticky Scroll with outer scopes selected.":::

But sometimes, the namespace and class name match the file name. When information such as this is obvious, you might not want to give up two lines of vertical space at the top of your file. Then, you can change to the lower-level *inner* scope option, which pushes out higher-level scopes as you scroll through deeply nested code.

:::image type="content" source="media/vs-2022/sticky-scroll-scopes-inner.gif" alt-text="An animation of the Sticky Scroll with inner scopes selected.":::

You can configure whether to prioritize outer or inner scopes when the set number of scopes exceeds the maximum. From the Visual Studio menu bar, select **Tools** > **Options**> **Text Editor** > **Sticky scroll**, and then select **Prefer outer scopes** or **Prefer inner scopes**.

:::image type="content" source="media/vs-2022/sticky-scroll-options.png" alt-text="Screenshot of the inner and outer scope options for Sticky Scroll.":::

## Related content

To learn more about Sticky Scroll in Visual Studio, explore the following resources:

- [Sticky Scroll: Preview](https://devblogs.microsoft.com/visualstudio/sticky-scroll-now-in-preview/)
- [Sticky Scroll: Stay in the right context](https://devblogs.microsoft.com/visualstudio/sticky-scroll-stay-in-the-right-context/)
