---
title: Troubleshoot GitHub Copilot state
description: Learn how to use the GitHub Copilot badge in the Visual Studio IDE to troubleshoot copilot state and resolve common issues.
ms.date: 7/29/2024
ms.topic: troubleshooting-problem-resolution
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: vs-2022
ms.custom: ai-learning-hub
---

# Troubleshoot GitHub Copilot in Visual Studio

This troubleshooting guide includes instructions to resolve issues with GitHub Copilot in Visual Studio 2022 version 17.10 or later.

The GitHub Copilot badge in the upper-right corner of the Visual Studio environment showing the message **Copilot is temporarily unreachable** indicates GitHub Copilot is offline.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-error.png" alt-text="Screenshot of copilot unreachable error." lightbox="media/vs-2022/copilot-inbox/copilot-error.png":::

GitHub Copilot could be offline due to one of the following reasons:

## Network issues

Your network is down.

**Action:** Ensure you have a stable internet connection. For more information, see [Troubleshooting network errors for GitHub Copilot](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-network-errors-for-github-copilot).

## Copilot service is unavailable

The Copilot service is down.

**Action:** In this case, wait. The service will be back shortly. You can check the status of the service on [GitHub Status](https://www.githubstatus.com/).

## Refresh your credentials

Due to the expected timeout, you need to occasionally refresh your credentials.

**Action:** Select **"Refresh your credentials"** from the Copilot badge in the upper-right corner of your Visual Studio environment to refresh your GitHub account and sign in again.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-refresh-credentials.png "alt-text="Screenshot of Refresh your credentials option." lightbox="media/vs-2022/copilot-inbox/copilot-refresh-credentials.png":::

> [!NOTE]
> **Known issue:** Not seeing an option to refresh credentials for the GitHub account on **All Accounts** window.
> The workaround is to remove and readd your GitHub account. Please refer to the [Dev Community ticket](https://developercommunity.visualstudio.com/t/Copilot-badge-refresh-credentials-not-wo/10667230?q=refresh+credentials) related to this issue for more information.

## Copilot is disabled

Your administrator disables Copilot for individual or any Copilot license. With Visual Studio version 17.10, your [admin can disable Copilot](visual-studio-github-copilot-admin.md#disabling-copilot-for-individual-enterprise-visual-studio-accounts).

**Action:** Contact your IT department to learn if your admin disabled Copilot.

:::image type="content" source="media/vs-2022/copilot-inbox/copilot-disable-badge.png "alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/copilot-inbox/copilot-disable-badge.png":::
