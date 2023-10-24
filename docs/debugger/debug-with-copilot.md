---
title: Debug with GitHub Copilot
description: Use Copilot to help debug your apps and provide performance insights.
ms.date: 09/14/2023
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugger, Copilot
  - Copilot, debugging
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ai-tools
monikerRange: '>= vs-2022'
---
# Debug your app with GitHub Copilot in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

[GitHub Copilot chat for Visual Studio 2022](../ide/visual-studio-github-copilot-chat.md) supports many interactive debugging scenarios, including AI-assisted chat for debugging questions related to your variables, the call stack, and other code elements, along with highly targeted help associated with an **Ask Copilot** link.

For related videos, see the [blog post announcement](https://devblogs.microsoft.com/visualstudio/simplified-code-refinement-and-debugging-with-github-copilot-chat/
).

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

To use Copilot with the debugging features, you must have Visual Studio 2022 version 17.7.4 or later, a [GitHub Copilot subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot), and the Copilot extensions for Visual Studio installed:

- [GitHub Copilot installation instructions](https://docs.github.com/en/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot Chat installation instructions](https://docs.github.com/en/copilot/github-copilot-chat/using-github-copilot-chat?tool=visualstudio)

[![Screenshot of Copilot extensions.](../debugger/media/vs-2022/debug-with-copilot-extensions.png "Copilot extensions.")](../debugger/media/vs-2022/debug-with-copilot-extensions.png#lightbox)

## AI-assisted auto insights

Copilot provides detailed information in the CPU Usage auto insights. It provides detailed information and insights for specific methods and properties, such as `String.Concat` and many other methods. With Copilot, ask questions about functions on the identified hot paths in your code, which can help you produce more efficient or cost-effective code.

When the CPU Usage tool provides auto insights in the Top Insights section, select **Ask Copilot** to learn from Copilot and start asking questions.

![Animation of using Copilot with CPU Usage.](../debugger/media/vs-2022/debug-with-copilot-top-insights.gif "Using Copilot with CPU Usage.")

## AI-assisted exceptions

Copilot has access to exceptions, call stack, local variables, and code. By asking good questions based on the relevant exception data that Visual Studio has when you’re at an exception, Copilot Chat can provide useful insights and fixes for the issue.

When you see an exception, select the **Ask Copilot** link to get AI-generated answers related to the specific exception and context.

[![Screenshot of Ask Copilot option in Exception Helper.](../debugger/media/vs-2022/debug-with-copilot-exception-helper.png "Ask Copilot option in Exception Helper.")](../debugger/media/vs-2022/debug-with-copilot-exception-helper.png#lightbox)

If you have more questions, just ask Copilot!

[![Screenshot of Chat window after choosing Ask Copilot.](../debugger/media/vs-2022/debug-with-copilot-exception-chat.png "Ask Copilot option in Exception Helper.")](../debugger/media/vs-2022/debug-with-copilot-exception-helper.png#lightbox)

## AI-assisted debugging

Copilot understands call stacks, frames, variable names, and values. As a result, you can pose detailed questions to the debugger-aware Copilot.

![Screenshot of asking a debugging question.](../debugger/media/vs-2022/debug-with-copilot-asking-a-question.png "Asking a Debugging Question.")

And Copilot answers!

![Screenshot of answered question.](../debugger/media/vs-2022/debug-with-copilot-question-answered.png "Answered Question.")
