---
title: Debug with GitHub Copilot
description: Use Copilot to help debug your apps and provide performance insights.
ms.date: 02/01/2024
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
ms.subservice: ai-tools
monikerRange: '>= vs-2022'
---
# Debug your app with GitHub Copilot in Visual Studio

[**GitHub Copilot**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs) and [**GitHub Copilot Chat**](https://aka.ms/VSXGHCopilot) extensions in Visual Studio enable many interactive debugging scenarios, including AI-assisted chat for debugging questions related to your code. Copilot understands call stacks, frames, variable names, and values. As a result, you can pose detailed questions to the debugger-aware Copilot. In addition, Copilot provides an **Ask Copilot** link for the following scenarios:

- Exceptions
- Auto Insights for CPU Usage

In this article, you'll learn how to debug more efficiently using the Copilot Chat extension and the **Ask Copilot** link.

For more information on the GitHub Copilot extension in Visual Studio, see [About the GitHub Copilot extension for Visual Studio](visual-studio-github-copilot-extension.md).

## Prerequisites

To get started, you need:

+ Visual Studio 2022 [version 17.8](/visualstudio/releases/2022/release-history) or later
+ Active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business)
+ [**GitHub Copilot** extension](visual-studio-github-copilot-extension.md#installation-instructions) in Visual Studio
+ [**GitHub Copilot Chat** extension](../ide/visual-studio-github-copilot-chat.md#install-the-visual-studio-extension)

   > [!NOTE]
   > If you experience authentication issues after installing the extension, see [Troubleshooting authentication issues with GitHub Copilot Chat](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-authentication-issues-with-github-copilot-chat).

## Start a debugging session

The following simple example shows how to get AI assistance when you encounter an exception and quickly update your code based on AI suggested fixes.

1. In Visual Studio, create a new C# Console app for .NET and replace the code in *Program.cs* with the following code:

    ```csharp
    using System;
    using System.Collections.Generic;
    
    public class Example
    {
        public static void Main(string[] args)
        {
            int value = Int32.Parse(args[0]);
            List<String> names = null;
            if (value > 0)
                names = new List<String>();
    
            names.Add("Major Major Major");
        }
    }
    ```

1. Press **F5** or select **Start Debugging** from the **Debug** menu.

   An `IndexOutOfRangeException` occurs and the app pauses, showing the exception.

   To get AI assistance for the exception, proceed to the next section of this article.

## Get AI assistance for an exception

1. Select the **Ask Copilot** button.

   [ ![Screenshot of Ask Copilot button in an exception.](../debugger/media/vs-2022/debug-with-copilot-exception.png) ](../debugger/media/vs-2022/debug-with-copilot-exception.png#lightbox)

   If it's not already open, the Copilot Chat window appears and provides an assessment of the error and a detailed description of the exception and why it occurred. In this example, Copilot Chat identifies a suggested code fix, a button to copy code, and a **Preview** button for the code fix.

1. Select the **Preview** button.

   ![Screenshot of Preview button in the Copilot Chat window.](../debugger/media/vs-2022/debug-with-copilot-select-code-preview.png)

   Visual Studio shows a code preview with the suggested fix.

1. Review the suggested fix and choose **Accept** to apply the code suggestion.

   [ ![Screenshot of code preview in Visual Studio.](../debugger/media/vs-2022/debug-with-copilot-code-preview.png) ](../debugger/media/vs-2022/debug-with-copilot-code-preview.png#lightbox)

1. Restart the debugger.

   This time, no exception occurs. It has been fixed!

## Get AI assistance for auto insights

In addition to interactive debugging assistance, Copilot provides detailed information in the CPU Usage auto insights. It provides information and insights for specific methods and properties, such as `String.Concat` and many other methods. With Copilot, ask questions about functions on the identified hot paths in your code, which can help you produce more efficient or cost-effective code.

When the CPU Usage tool provides auto insights in the Top Insights section, select **Ask Copilot** to learn from Copilot and start asking questions.

[ ![Animation of using Copilot with CPU Usage.](../debugger/media/vs-2022/debug-with-copilot-top-insights.gif) ](../debugger/media/vs-2022/debug-with-copilot-top-insights.gif#lightbox)