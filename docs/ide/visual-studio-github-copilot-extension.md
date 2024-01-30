---
title: About the GitHub Copilot extension for Visual Studio
description: Use Visual Studio with the GitHub Copilot extension to access AI features and generate information about your code, including suggested edits and new code snippets.
ms.date: 12/15/2023
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: jmartens
ms.subservice: ai-tools
monikerRange: vs-2022
content_well_notification: 
  - AI-contribution
---
# What is the GitHub Copilot extension for Visual Studio?

[**GitHub Copilot**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs) and [GitHub Copilot Chat](https://aka.ms/VSXGHCopilot) extensions in Visual Studio enable enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when writing code.

In this article, you learn about the Copilot extension, an AI-powered pair programmer extension for Visual Studio that provides you with context-aware code completions, suggestions, and even entire code snippets. This powerful tool aids [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md) and helps developers write code more efficiently, reduce the time spent on repetitive tasks, and minimize errors.

For more information on the GitHub Copilot Chat extension in Visual Studio, see [About the GitHub Copilot Chat extension for Visual Studio](visual-studio-github-copilot-chat.md).

## How GitHub Copilot works

GitHub Copilot works by utilizing advanced machine learning models trained on a vast dataset of publicly available code from GitHub repositories. As you type code, the AI analyzes the context and provides relevant suggestions in real-time. You can receive suggestions also by writing a natural language comment describing what you want the code to do.

:::image type="content" source="media/vs-2022/github-copilot-extension-example.gif" alt-text="Animated screenshot that shows the code completion capabilities of the GitHub Copilot extension.":::

You can also use GitHub Copilot to convert comments to code, create unit tests, create SQL queries, and more. 

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-history) or later
+ a GitHub Copilot [subscription](https://docs.github.com/enterprise-cloud@latest/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot). 

  > [!TIP]
  > GitHub Copilot is free for verified students and for maintainers of popular open source projects on GitHub. If you are not a student or maintainer of a popular open source project, you can [try GitHub Copilot for free with a one-time 30-day trial](https://github.com/settings/copilot). After the free trial, you will need a [paid subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) for continued use.

GitHub Copilot supports several programming languages and frameworks, including but not limited to: C#, C++, and Python.

## Installation instructions

You can [install GitHub Copilot as an extension](#install-using-the-manage-extensions-dialog), but we recommend you [install GitHub Copilot as a component](#install-using-the-visual-studio-installer) using the Visual Studio Installer.

### Install using the Visual Studio Installer

1. Launch the Visual Studio Installer.
1. Select the installation of Visual Studio you want to modify, and then select **Modify**.
1. Select any workload, for example, **.NET desktop development**.
1. Select **GitHub Copilot** from the list of **Optional** components, and then select **Modify** to install the extension.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png" alt-text="Screenshot that shows using the Visual Studio Installer to install the GitHub Copilot component." lightbox="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png":::

    > [!NOTE]
    > You'll use the **Manage Extensions** dialog to manage updates to the GitHub Copilot extension.

### Install using the Manage Extensions dialog

1. Open Visual Studio.
1. On the menu bar, select **Extensions** > **Manage Extensions**.
1. In the Search box, enter "GitHub Copilot".
1. Select the **GitHub Copilot** extension, and then select the **Download** button.
1. Restart Visual Studio to complete the installation process.

> [!NOTE]
> For more information about activation & authorization, see the [Installing the Visual Studio extension](https://docs.github.com/en/copilot/getting-started-with-github-copilot?tool=visualstudio#installing-the-visual-studio-extension) section in GitHub Docs.

After installation, you can start using GitHub Copilot by typing code in the editor and observing the suggestions provided by AI.

## Exploring GitHub Copilot

To see GitHub Copilot in action, check out the following video tutorial. <br><br>*Video length: 1.19 minutes*

> [!VIDEO https://www.youtube.com/embed/kc_A12G4Elk]

## Next steps

To learn more about the current GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
