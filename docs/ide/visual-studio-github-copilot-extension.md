---
title: About the GitHub Copilot extension for Visual Studio
description: Use Visual Studio and the GitHub Copilot extension together to take advantage of AI and generate detailed info about your code, along with suggested edits, and even new code snippets, too. 
ms.date: 04/21/2023
ms.topic: overview 
ms.custom: template-overview
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.technology: vs-ai-tools
ms.workload:
- multiple
monikerRange: vs-2022
---
# What is the GitHub Copilot extension for Visual Studio?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
 [!INCLUDE [AI Generated Attribution](../includes/ai-generated-attribution.md)]

[**GitHub Copilot**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) is an AI-powered pair programmer extension for Visual Studio that provides you with context-aware code completions, suggestions, and even entire code snippets. This powerful tool helps developers write code more efficiently, reduce the time spent on repetitive tasks, and minimize errors.

:::image type="content" source="media/vs-2022/github-copilot-extension-example.gif" alt-text="Animated screenshot that shows the code completion capabilities of the GitHub Copilot extension.":::

## How GitHub Copilot works

GitHub Copilot works by utilizing advanced machine learning models trained on a vast dataset of publicly available code from GitHub repositories. As you type code, the AI analyzes the context and provides relevant suggestions in real-time. You can receive suggestions also by writing a natural language comment describing what you want the code to do.

## IntelliSense, IntelliCode, and GitHub Copilot compared

While all three Visual Studio tools aim to improve developer productivity, GitHub Copilot stands out with its ability to understand the context of your code and provide more accurate and relevant suggestions. Here's a detailed look at what each tool can do for you:

- **[IntelliSense](using-intellisense.md)** is a code completion feature built-in to Visual Studio, which provides suggestions based on the current context. Such suggestions include variable names, functions, and classes. IntelliSense is language-specific and works with a limited set of programming languages.
- **[IntelliCode](/visualstudio/intellicode/)** is an extension for Visual Studio that uses AI to provide more intelligent code completions based on patterns found in your codebase. It goes beyond IntelliSense by analyzing your code to understand common practices and recommend suggestions accordingly.
- **[GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)** is an AI-powered code completion extension for Visual Studio that leverages a vast dataset of publicly available code to provide context-aware code suggestions, snippets, and even entire functions. It works with many programming languages and offers more advanced assistance compared to IntelliCode and IntelliSense.

## Supported programming languages

GitHub Copilot supports several programming languages and frameworks, including but not limited to: C#, C++, and Python.

## Installation instructions

1. Open Visual Studio.
1. On the menu bar, select **Extensions** > **Manage Extensions**.
1. In the Search box, enter "GitHub Copilot".
1. Select the **GitHub Copilot** extension, and then select the **Download** button.
1. Restart Visual Studio to complete the installation process.

After installation, you can start using GitHub Copilot by typing code in the editor and observing the suggestions provided by the AI.

## Next steps

To learn more about a new GitHub Copilot experience that's soon to be integrated into the Visual Studio IDE, see the [GitHub Copilot chat for Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/github-copilot-chat-for-visual-studio-2022/) blog post. 

To learn more about the current GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot extension: Official website](https://copilot.github.com/)
- [GitHub Copilot extension: Documentation](https://docs.github.com/en/copilot)
- [GitHub Copilot extension: FAQ](https://copilot.github.com/faq)