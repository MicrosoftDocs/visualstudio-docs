---
title: Troubleshooting GitHub Copilot in Visual Studio 2022
description: Learn about the copilot status and how to fix issues
ms.date: 3/28/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
monikerRange: vs-2022
---

# Troubleshooting GitHub Copilot in Visual Studio 2022 (Version 17.10 or Higher)
If you encounter the message **“Copilot is temporarily unreachable”**, indicating that GitHub Copilot is offline, it could be due to one of the following reasons:

        :::image type="content" source="media/vs-2022/copilot-inbox\copilot-error.png
        " alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/copilot-inbox\copilot-error.png":::

## Network issues
Your network might be down.
**Action:** Ensure you have a stable internet connection. For more information, refer to - Troubleshooting network errors for [GitHub Copilot - GitHub Docs](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-network-errors-for-github-copilot)


## Copilot service is unavailable
Sometimes, the Copilot service itself might be down.
**Action:** In this case, please wait. The service will be back shortly. You can check the status of the service on [GitHub Status](https://www.githubstatus.com/).


        :::image type="content" source="media/vs-2022/copilot-inbox\copilot-refresh-creds.png
        " alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/copilot-inbox\copilot-refresh-creds":::

## Refresh your credentials
Due to the expected timeout, you’ll need to occasionally refresh your credentials.
**Action:** You can do this by clicking the Copilot badge on the top right corner of your Visual Studio and selecting **"Refresh your credentials"**. 


        :::image type="content" source="media/vs-2022/copilot-inbox\copilot-disable-badge.png
        " alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/copilot-inbox\copilot-disable-badge":::

## Copilot is disabled
Copilot for individual or any other sku of copilot can be disabled by your administrator on 17.10.
**Action:** Contact your IT department to learn more if you see this state for your copilot badge on the top right of your Visual Studio.