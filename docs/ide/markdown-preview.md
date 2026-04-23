---
title: Markdown preview controls
description: Learn how to switch between editor modes and use zoom controls when previewing Markdown files and Mermaid diagrams in Visual Studio.
ms.date: 02/19/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
ai-usage: ai-assisted
ms.custom: awp-ai
monikerRange: "visualstudio"
#customer intent: As a developer, I want to control how I preview Markdown files and zoom into Mermaid diagrams in Visual Studio.
---

# Markdown preview controls

The Visual Studio Markdown editor gives you more control over how you view and edit Markdown files. You can switch between different preview modes to focus on either editing or viewing rendered content, and you can zoom in on Mermaid diagrams to see details in complex visualizations.

## Preview modes

Visual Studio provides three preview modes for working with Markdown files:

| Mode | Description |
|------|-------------|
| **Split Preview** | Shows the editor and preview side by side. This mode is the default and lets you see your changes rendered in real time as you type. |
| **Open Preview** | Shows only the rendered preview content. Use this mode when you want to focus on the final output, especially for reviewing large images or complex Mermaid diagrams. |
| **Edit Markdown** | Shows only the editor without the preview pane. Use this mode when you want to focus on writing and editing without distractions. |

To switch between preview modes, use the preview controls in the editor toolbar when you have a Markdown file open.

:::image type="content" source="media/visualstudio/markdown-preview/markdown-preview-controls.png" alt-text="Screenshot of the Markdown preview controls in the Visual Studio editor toolbar, showing options for Split Preview, Open Preview, and Edit Markdown modes.":::

## Zoom Mermaid diagrams

When you preview a Markdown file that contains a Mermaid diagram, you can use the zoom controls to get a better view of the diagram. This feature is especially useful for large or complex diagrams where you need to see details.

To zoom in or out on a Mermaid diagram:

1. Open a Markdown file that contains a Mermaid diagram.
1. Switch to **Split Preview** or **Open Preview** mode.
1. Use the zoom controls in the top left corner of the preview pane to zoom in or out.

> [!TIP]
> The preview-only mode (**Open Preview**) combined with zoom controls is particularly helpful when working with architectural diagrams, flowcharts, or sequence diagrams that have many elements.

:::image type="content" source="media/visualstudio/markdown-preview/markdown-controls.gif" alt-text="Screenshot of a Mermaid diagram in the Visual Studio Markdown preview with zoom controls visible in the top left corner.":::

## Related content

- [Generate Mermaid diagrams with GitHub Copilot](visual-studio-github-copilot-chat.md#generate-mermaid-diagrams)
- [Features of the code editor](writing-code-in-the-code-and-text-editor.md)
- [Add Visual Studio editor support for other languages](adding-visual-studio-editor-support-for-other-languages.md)
