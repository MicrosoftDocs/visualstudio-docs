---
title: Use color emojis in Visual Studio
description: Learn where Visual Studio shows emojis in full color, including comments, Markdown, Copilot Chat, Output window text, and Solution Explorer items.
ms.date: 06/08/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.subservice: general-ide
---

# Use color emojis in Visual Studio

Visual Studio renders emojis in full color across common IDE surfaces. You can use emoji markers in comments, Markdown, and collaboration workflows while keeping the same visual meaning when you move between views.

## What color emoji support includes

Emoji characters now render in full color instead of monochrome outlines in supported Visual Studio surfaces. This behavior can make visual markers easier to scan in large files, logs, and tool windows.

## Where you see color emojis

You can use color emojis in the following places:

- Code comments
- Markdown files and Markdown preview
- GitHub Copilot Chat responses and prompts
- Output window text and logs
- Solution Explorer item and file names

## Try it quickly

Use this short check to verify rendering behavior in your environment:

1. Open a code file and add a comment that includes emojis, such as `// TODO ✅`.
1. Open or create a Markdown file and add a line with emojis, such as `Status: 🟢 Ready`.
1. Open **View** > **GitHub Copilot Chat** and submit a prompt that includes emojis.
1. Build a project and review text in the **Output** window.
1. Rename a test file or folder in **Solution Explorer** to include an emoji and confirm color rendering.

To insert emoji characters while you're typing, use the Windows emoji picker by pressing <kbd>Windows</kbd>+<kbd>.</kbd> (period), and then select an emoji.

## Notes and limitations

- Emoji appearance can vary slightly by Windows configuration, installed fonts, and scaling settings.
- In Visual Studio, supported emoji characters are rendered with full color in the UI surfaces listed in this article.
- For more ways to enter emojis and symbols in Windows, see [Emoji, kaomoji, and symbols panel](https://support.microsoft.com/en-us/windows/windows-keyboard-tips-and-tricks-588e0b72-0fff-6d3f-aeee-6e5116097942).

## Related content

- [Markdown preview controls](markdown-preview.md)
- [About GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md)
- [Learn about Solution Explorer](use-solution-explorer.md)
- [Output Window](output-window.md)
