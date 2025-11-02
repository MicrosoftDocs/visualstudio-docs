---
title: How Copilot Chat uses context
description: Learn how GitHub Copilot Chat understands your codebase, builds context, and applies code suggestions in Visual Studio.
ms.date: 10/31/2025
ms.update-cycle: 180-days
ms.topic: overview
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: '>= vs-2022'
---

# How Copilot Chat understands and uses context

Copilot Chat in Visual Studio is designed to be context-aware, delivering highly relevant and tailored responses by deeply understanding your project’s structure and content. This article provides a behind-the-scenes look at how Copilot Chat constructs and utilizes context to enhance your coding workflow.

## How Copilot Chat gathers solution context

Copilot Chat uses a multi-layered approach to context-building within your codebase to ensure its suggestions and answers are relevant and accurate.

### Codebase indexing

If your repository is hosted on GitHub or Azure DevOps, Copilot creates a remote index of your codebase and computes an embedding that captures patterns and relationships in your code. Learn more about [remote indexing on GitHub](https://docs.github.com/en/search-github/github-code-search/about-github-code-search).

If your code is hosted elsewhere, Copilot builds a local index.

### Semantic search

Based on your prompt, Copilot might determine that it needs more project context to respond accurately. In such cases, it performs a semantic search on the remote or local index.

Unlike traditional search, which matches exact words, semantic search focuses on meaning. Using advanced vector embeddings, Copilot identifies files with the highest semantic similarity to your request and adds them to its context.

These files supplement the system prompt, instructions, implicit context (such as chat history and open files), and any explicit content you provide, like errors.

Learn how to [add references as context](copilot-chat-context-references.md) in chat.

## How Copilot Chat applies code suggestions

Copilot Chat frequently provides code suggestions in its responses. These suggestions must be accurately mapped to your codebase before they can be applied and tested.

### Model based code mapping

Copilot Chat uses speculative decoding to accurately insert suggestions into existing files, reducing the risk of errors. In Agent mode, this enables Copilot to make reliable edits that support building, debugging, and testing your code independently.

## Copilot memories

Copilot memories enable Copilot to learn your project's specific coding standards and best practices, making it project-aware and consistent across sessions.

### How Copilot memories work

Memories use intelligent detection to understand your team's preferences as you prompt in the chat. As you prompt, Copilot identifies instances where you correct its behavior, indicate a standard, or ask it to remember something. 

When such instances are detected, you see a confirmation nudge to save the preference.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-memories.png" alt-text="Screenshot of when Copilot detects a preference to add to memories.":::

Copilot then categorizes the preference into one of three files:

- `.editorconfig` for coding standards
- `CONTRIBUTING.md` for best practices, guidelines, and architectural standards.
- `README.md` for high-level project information

As you continue to prompt Copilot, you teach it to respond more effectively to your needs and help your team by documenting development best practices that enhance their future Copilot interactions.

## Related content

- [Customize chat responses and set context](copilot-chat-context.md)
- [Manage chat context with references](copilot-chat-context-references.md)
- [GitHub Copilot Trust Center: Learn about security, privacy, compliance, and transparency](https://copilot.github.trust.page)
- [Smarter AI edits in Visual Studio Copilot (DevBlog)](https://devblogs.microsoft.com/visualstudio/smarter-ai-edits-in-visual-studio-copilot/)