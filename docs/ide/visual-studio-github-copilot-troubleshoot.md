---
title: Troubleshoot GitHub Copilot state
description: Learn how to use the GitHub Copilot badge in the Visual Studio IDE to troubleshoot Copilot's state and resolve common issues.
ms.date: 8/30/2025
ms.update-cycle: 180-days
ms.topic: troubleshooting-problem-resolution
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: ">=vs-2022"
ms.custom: ai-learning-hub
---

# Troubleshoot GitHub Copilot in Visual Studio

This troubleshooting guide includes steps for resolving GitHub Copilot issues in Visual Studio 2022 version 17.10 or later.

If the GitHub Copilot badge in the upper-right corner of the Visual Studio environment displays the message **Copilot is temporarily unreachable**, it means GitHub Copilot is currently offline.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-error.png" alt-text="Screenshot of copilot unreachable error." lightbox="media/vs-2022/copilot-inbox/copilot-error.png":::

GitHub Copilot may be offline due to one of the following reasons:
- Network issues
- Copilot service being unavailable
- Credentials requiring a refresh
- Copilot being disabled

If you're running into an issue not in this list, [report your problem](#send-feedback) to us.

## Network issues

If your network is down, GitHub Copilot may not be able to connect.

**Action:** Ensure you have a stable internet connection. For more information, see [Troubleshooting network errors for GitHub Copilot](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-network-errors-for-github-copilot).

## Copilot service is unavailable

The GitHub Copilot service may be temporarily down.

**Action:** Wait for the service to come back online. You can check the status on [GitHub Status](https://www.githubstatus.com/).

## Refresh your credentials

Occasionally, you may need to refresh your credentials due to expected timeouts.

**Action:** Select **"Refresh your credentials"** from the Copilot badge in the upper-right corner of your Visual Studio environment to reauthenticate your GitHub account and sign in again.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-refresh-credentials.png "alt-text="Screenshot of Refresh your credentials option." lightbox="media/vs-2022/copilot-inbox/copilot-refresh-credentials.png":::

> [!NOTE]
> **Known issue:** If you don’t see the option to refresh your credentials for the GitHub account in the  **All Accounts** window, you can resolve this by removing and re-adding your GitHub account. For more information, refer to the  [Dev Community ticket](https://developercommunity.visualstudio.com/t/Copilot-badge-refresh-credentials-not-wo/10667230?q=refresh+credentials) related to this issue.

## Copilot is disabled

Your administrator may have disabled GitHub Copilot for individual or any Copilot license. With Visual Studio version 17.10, your [admin can disable Copilot](visual-studio-github-copilot-admin.md#disable-copilot-skus).

**Action:** Contact your IT department to confirm whether your admin has disabled Copilot.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-disable-badge.png "alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/copilot-inbox/copilot-disable-badge.png":::

## Send feedback

 - [Report a problem](how-to-report-a-problem-with-visual-studio.md) to us from either the Visual Studio IDE or the installer. The built-in Feedback Tool allows you to easily add diagnostic information that helps the Visual Studio teams diagnose and fix the issues.
 - Suggest a feature, track product issues, and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/VisualStudio).

 ## Related content

 - [Troubleshooting network errors for GitHub Copilot](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-network-errors-for-github-copilot)
 - [Troubleshooting firewall settings for GitHub Copilot](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-firewall-settings-for-github-copilot)