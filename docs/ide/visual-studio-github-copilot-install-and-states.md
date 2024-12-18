---
title: Install and manage GitHub Copilot in Visual Studio
description: Learn how to install GitHub Copilot to get GitHub Copilot Completions and Chat in Visual Studio. Use the Copilot badge in the IDE to access options to manage or troubleshoot your Copilot state. 
ms.date: 12/18/2024
ms.topic: install-set-up-deploy
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: '>= vs-2022'
ms.custom: [copilot-learning-hub]
---
# Install GitHub Copilot in Visual Studio

**GitHub Copilot Completions** and **GitHub Copilot Chat** in Visual Studio enable enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when writing code.

In this article, you learn how to install GitHub Copilot in Visual Studio. If you're using [Visual Studio 2022 version 17.10 or later](/visualstudio/releases/2022/release-notes), you learn to use the Copilot badge in the IDE to manage your Copilot state.
 
## Get GitHub Copilot for Visual Studio 2022 version 17.10 or later

With [Visual Studio 2022 version 17.10](/visualstudio/releases/2022/release-notes), GitHub Copilot and GitHub Copilot Chat are available to install as a single experience that combines both Copilot and Copilot Chat into one package. The unified GitHub Copilot experience is included as a built-in, recommended component by default in all workloads and is available through the Visual Studio Installer.

To get the new unified GitHub Copilot experience:
- Install [Visual Studio 2022 version 17.10 or later](/visualstudio/releases/2022/release-notes). 
- Select at least one workload in the installer. Make sure to leave the preselected component **GitHub Copilot** selected.
  OR
  If no workload is selected, install **GitHub Copilot** by selecting it from **Individual components** in the installer.

GitHub Copilot is installed by default with all workloads. If you choose to exclude it, you can install it later by using the Visual Studio Installer to **modify** your installation, and selecting the **GitHub Copilot** component. 

## Get GitHub Copilot for Visual Studio 2022 versions 17.8 to 17.9 

In Visual Studio 2022 versions 17.8 to 17.9, GitHub Copilot and GitHub Copilot Chat are available to install as two separate extensions. 
> [!NOTE]
> Installing GitHub Copilot extension is a prerequisite to installing GitHub Copilot Chat.

### Install GitHub Copilot

You can get the **GitHub Copilot extension** in one of the following ways:

- Install the GitHub Copilot extension using the [Visual Studio Installer](#install-using-the-visual-studio-installer) (**recommended**)
- Install using the [Extension Manager](#install-using-the-manage-extensions-dialog-box)
- Install directly from [Visual Studio Marketplace](#install-from-visual-studio-marketplace): [**GitHub Copilot on Marketplace**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs)

### Install GitHub Copilot Chat

You can get the **GitHub Copilot Chat extension** in one of the following ways:

- Install using the [Extension Manager](#install-using-the-manage-extensions-dialog-box)
- Install directly from [Visual Studio Marketplace](#install-from-visual-studio-marketplace): [**GitHub Copilot Chat on Marketplace**](https://aka.ms/VSXGHCopilot)

Support for GitHub Copilot Chat will be provided by GitHub and can be reached at https://support.github.com.
 
#### Install using the Visual Studio Installer

1. Launch the Visual Studio Installer.
1. Select the installation of Visual Studio you want to modify, and then select **Modify**.
1. Select any workload, for example, **.NET desktop development**.
1. Select **GitHub Copilot** from the list of **Optional** components, and then select **Modify** to install the extension.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png" alt-text="Screenshot that shows using the Visual Studio Installer to install the GitHub Copilot component." lightbox="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-installer-component.png":::

    > [!NOTE]
    > In versions 17.9 or earlier, you'll use the **Manage Extensions** dialog to manage updates to the GitHub Copilot extension.

#### Install using the Manage Extensions dialog box

1. Open Visual Studio.
1. On the menu bar, select **Extensions** > **Manage Extensions**.
1. In the Search box, enter "GitHub Copilot" or "GitHub Copilot Chat".
1. Select the extension, and then select the **Download** button.
1. Restart Visual Studio to complete the installation process.

> [!NOTE]
> For more information about activation & authorization, see the [Installing the Visual Studio extension](https://docs.github.com/en/copilot/getting-started-with-github-copilot?tool=visualstudio#installing-the-visual-studio-extension) section in GitHub Docs.

#### Install from Visual Studio Marketplace

Download and install the extensions directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/).
- [GitHub Copilot extension for Visual Studio 2022 version 17.9 or earlier][**GitHub Copilot on Marketplace**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs)
- [GitHub Copilot Chat extension for Visual Studio 2022 version 17.9 or earlier](https://aka.ms/VSXGHCopilot)

## Manage your Copilot state 

With Visual Studio 2022 version 17.10, you see a Copilot status icon in the upper-right corner of the Visual Studio environment that indicates if Copilot is active, inactive, unavailable, or not installed. Using the dropdown menu from the status icon, you can easily access options that help manage or [troubleshoot](visual-studio-github-copilot-troubleshoot.md) your Copilot state. Some options are available or greyed out depending on your Copilot state.

> [!NOTE]
> Note that the status icon is moving from the bottom panel of the Visual Studio editor. 

### Copilot is active

Copilot is in an active state and fully functional if you [signed into Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot).
Using the dropdown menu, you can easily open the Chat window, access Copilot settings, and manage Copilot subscription.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-active.png" alt-text="Screenshot of Copilot badge when Copilot is in active state.":::

### Copilot is inactive

If Copilot is installed but in an inactive state, it may be because:
-  you're not yet signed into Visual Studio with a GitHub account
-  your signed in GitHub account doesn't have an active [Copilot subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot)

Select **Add GitHub Account with a Copilot Subscription** in the dropdown from the status icon to open **Account Settings** and [sign in with a GitHub account](work-with-github-accounts.md) that has an active subscription to use Copilot. When you're signed in, the Copilot status icon updates to active.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-inactive.png" alt-text="Screenshot of Copilot badge when Copilot is in an inactive state.":::

If Copilot is inactive as the signed in GitHub account credentials need to be refreshed, select [**Refresh your GitHub credentials**](visual-studio-github-copilot-troubleshoot.md#refresh-your-credentials) from the dropdown to refresh your GitHub account and sign in again.

If [Copilot is disabled by your administrator](visual-studio-github-copilot-troubleshoot.md#copilot-is-disabled), contact your IT administrator to learn more.

### Copilot is unavailable

If Copilot is installed but unavailable for use, it may be due to [network connectivity issues](visual-studio-github-copilot-troubleshoot.md#network-issues), [server-side technical problems](visual-studio-github-copilot-troubleshoot.md#copilot-service-is-unavailable), or an expired service plan. In this state, Copilot doesn't provide its usual services until the external issues are resolved.

Select **Copilot is unreachable** in the dropdown menu to open the **Troubleshooting** page on diagnosing and resolving common network errors with GitHub Copilot. When the issue is resolved and you're signed in with an active subscription, the Copilot status icon updates to [active](#copilot-is-active).

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-unavailable.png" alt-text="Screenshot of Copilot badge when Copilot is unavailable.":::

### Copilot not installed

If you chose to opt out of the default recommended install by unchecking the **GitHub Copilot** component in the installer, the status icon is still available in the IDE. 

Select **Install Copilot** from the dropdown to install Copilot.
If you choose to not install Copilot, you can select **Hide Copilot** from the dropdown to hide the Copilot status icon from the IDE.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-not-installed.png" alt-text="Screenshot of Copilot badge when Copilot isn't installed.":::

## Disable Copilot

### Hide Copilot badge

You can hide the GitHub Copilot badge in the Visual Studio IDE by unselecting **Tools** > **Options** > **Environment** > **Hide Copilot menu badge**.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/hide-copilot-badge.png" alt-text="Screenshot of option to hide copilot badge in Tools > Options.":::

### Uninstall Copilot

You can remove the GitHub Copilot component from your Visual Studio instance by using the Visual Studio Installer.

1. Launch the Visual Studio Installer by selecting **Tools** > **Get Tools and Features**.
1. Select **Individual components**.
1. Type "copilot" in the search box.
1. Uncheck **GitHub Copilot** and select **Modify**.
1. Restart Visual Studio, and select **Hide Copilot** from the Copilot status icon dropdown to hide the badge.

## Next steps

To learn more, consider exploring the following resources:

- [Get started with GitHub Copilot Completions in Visual Studio](visual-studio-github-copilot-extension.md)
- [Get started with GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md)
