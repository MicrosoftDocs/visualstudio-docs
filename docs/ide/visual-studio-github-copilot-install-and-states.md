---
title: Install and get started with GitHub Copilot in Visual Studio
description: Install GitHub Copilot in Visual Studio and use the Copilot badge in the IDE to troubleshoot your copilot state.
ms.date: 2/28/2024
ms.topic: conceptual 
author: anandmeg
ms.author: meghaanand
ms.manager: jmartens
ms.subservice: ai-tools
monikerRange: vs-2022
---
# Install GitHub Copilot in Visual Studio

**GitHub Copilot** and **GitHub Copilot Chat** in Visual Studio enable enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when writing code.

In this article, you'll learn how to install GitHub Copilot and use the Copilot badge (available in [Visual Studio 2022 version 17.10 Preview 2](/visualstudio/releases/2022/release-notes-preview) and later) in the IDE to manage your Copilot state.
 
## Get GitHub Copilot for Visual Studio 2022 version 17.10 Preview 2 or later 

With Visual Studio 2022 version 17.10 Preview 2, GitHub Copilot and GitHub Copilot Chat are available to install as a single extension that combines both Copilot and Copilot Chat into one package. The unified GitHub Copilot extension is included as a built-in, recommended component by default in all workloads and is available through the Visual Studio Installer.

To get the new unified GitHub Copilot extension:
- Install Visual Studio 2022 version 17.10 Preview 2 (**recommended**)

If you opt out of the default install by unchecking the **GitHub Copilot** component, you can install it later:
- Install using **Install Copilot** option in the Copilot badge
- Install using the [Visual Studio Installer](#install-using-the-visual-studio-installer)
- Install using the [Extension Manager](#install-using-the-manage-extensions-dialog-box)
- Install directly from [Visual Studio Marketplace](#install-from-visual-studio-marketplace)

## Get GitHub Copilot for Visual Studio 2022 versions 17.6 to 17.9 

In Visual Studio 2022 versions 17.6 to 17.9, GitHub Copilot and GitHub Copilot Chat are available to install as two separate extensions. Installing Github Copilot extension is a prerequisite to installing GitHub Copilot Chat.

 You can get the GitHub Copilot extension and the GitHub Copilot Chat extension in one of the following ways:
- Install only the GitHub Copilot extension using the Visual Studio Installer and install Copilot Chat using the Extension Manager or from Marketplace
- Install using the [Extension Manager](#install-using-the-manage-extensions-dialog-box)
- Install directly from [Visual Studio Marketplace](#install-from-visual-studio-marketplace): [**GitHub Copilot on Marketplace**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs) and [GitHub Copilot Chat on Marketplace](https://aka.ms/VSXGHCopilot) 

## Installation instructions

### Install using the Visual Studio Installer

1. Launch the Visual Studio Installer.
1. Select the installation of Visual Studio you want to modify, and then select **Modify**.
1. Select any workload, for example, **.NET desktop development**.
1. Select **GitHub Copilot** from the list of **Optional** components, and then select **Modify** to install the extension.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png" alt-text="Screenshot that shows using the Visual Studio Installer to install the GitHub Copilot component." lightbox="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png":::

    > [!NOTE]
    > In versions 17.9 or earlier, you'll use the **Manage Extensions** dialog to manage updates to the GitHub Copilot extension.

### Install using the Manage Extensions dialog box

1. Open Visual Studio.
1. On the menu bar, select **Extensions** > **Manage Extensions**.
1. In the Search box, enter "GitHub Copilot" (or "GitHub Copilot Chat").
1. Select the extension, and then select the **Download** button.
1. Restart Visual Studio to complete the installation process.

> [!NOTE]
> For more information about activation & authorization, see the [Installing the Visual Studio extension](https://docs.github.com/en/copilot/getting-started-with-github-copilot?tool=visualstudio#installing-the-visual-studio-extension) section in GitHub Docs.

### Install from Visual Studio Marketplace

Download and install the extensions directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/). 
- GitHub Copilot unified extension for Visual Studio 2022 version 17.10 Preview 2 
- GitHub Copilot extension for Visual Studio 2022 version 17.9 or earlier
- GitHub Copilot Chat extension for Visual Studio 2022 version 17.9 or earlier

## Manage your Copilot state 

With Visual Studio 2022 version 17.10 Preview 2, you'll see a Copilot status icon in the upper-right corner of the Visual Studio environment that indicates if Copilot is active, inactive, unavailable, or not installed. Using the dropdown menu from the status icon, you can easily access options that help manage or troubleshoot your Copilot state. Some options are available or greyed out depending on your Copilot state.

> [!NOTE]
> Note that the status icon is moving from the bottom panel of the Visual Studio editor. 

### Copilot is active

Copilot is in an active state and fully functional if the user is signed into Visual Studio with a GitHub account that has an active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business).

Using the dropdown menu, you can easily open the Chat window, access Copilot settings, and manage Copilot subscription.

<add screenshot>

### Copilot is inactive

If Copilot is installed but in an inactive state, you have not yet signed into Visual Studio with a GitHub account or your signed in GitHub account does not have an active [Copilot subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot). 

Select **Add GitHub Account with a Copilot Subscription** in the dropdown from the status icon to open **Account Settings** and sign in with a GitHub account that has an active subscription to use Copilot. When you're signed in, the Copilot status icon will update to active.

<add screenshot>

### Copilot is unavailable

If Copilot is installed but unavailable for use, it may be due to network connectivity issues, server-side technical problems, or an expired service plan. In this state, Copilot will not provide its usual services until the external issues are resolved.

Select **Copilot is unreachable** in the dropdown menu to open the **Troubleshooting** page on diagnosing and resolving common network errors with GitHub Copilot. When the issue is resolved and you're signed in with an active subscription, the Copilot status icon will update to active.

<add screenshot>

## Copilot is not installed

If you chose to opt out of the default recommended install by unchecking the **GitHub Copilot** component in the installer, the status icon is still available in the IDE. 

Select **Install Copilot** from the dropdown to install Copilot.
If you choose to not install Copilot, you can select **Hide Copilot** from the dropdown to hide the Copilot status icon from the IDE.

<add screenshot>

## Next steps

To learn more, consider exploring the following resources:

[Get started with GitHub Copilot in Visual Studio](visual-studio-github-copilot-extension.md)
[Get started with GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md)