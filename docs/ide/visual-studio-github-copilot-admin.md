---
title: Admin controls for GitHub Copilot in Visual Studio
description: GitHub Copilot in Visual Studio 2022 version 17.10 introduces new features for administrators to manage Copilot effectively. 
ms.date: 3/28/2024
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
monikerRange: vs-2022
---

# Admin controls for GitHub Copilot 
GitHub Copilot in Visual Studio 2022 17.10 Preview 3 introduces new features for administrators to manage Copilot effectively.

## Disabling Copilot for individual Enterprise Visual Studio accounts

In version 17.10, we're introducing two new features to disable Copilot, ensuring that your repository is protected. 
Project administrators can disable Copilot for individual accounts or disable Copilot altogether via the [Visual Studio Administrative Templates (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405). These features provide administrators with greater control over the use of Copilot within their organization.

To configure and deploy these policies, you can use [Microsoft Intune](../install/administrative-templates.md#deploying-the-policies) or the Local Group Policy Editor directly on the client machine.

## Configure Copilot group policy

1. Head over to the Microsoft Download Center and grab the Visual Studio [Group Policy Administrative Template files (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405). It asks you where you want the files to be downloaded, ensure the location is `C:\Windows\PolicyDefinitions`.

2. Open the **Windows Local Group Policy Editor**, Navigate to Computer Configuration > Administrative Templates > Visual Studio > **Copilot Settings** and select a group policy.

   :::image type="content" source="media/vs-2022/copilot-inbox/intune-group-policy.png" alt-text="Screenshot of Group Policy to block Copilot for Individuals." lightbox="media/vs-2022/copilot-inbox/intune-group-policy.png":::

3. Once you select your group policy, configure the policy to enable or disable.
   
   :::image type="content" source="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png" alt-text="Screenshot of Group Policy to block copilot for individuals." lightbox="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png":::

4. Restart your Visual Studio instance to pick up the new policy changes

