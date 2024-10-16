---
title: Admin controls for GitHub Copilot in Visual Studio
description: Learn about the new features for administrators in GitHub Copilot for Visual Studio that enable admins to manage Copilot effectively. 
ms.date: 9/12/2024
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: vs-2022
ms.custom: ai-learning-hub
---

# Admin controls for GitHub Copilot

Visual Studio 2022 introduces new features for administrators to configure and manage GitHub Copilot for their enterprise effectively. These features provide administrators greater control over the use of Copilot within their organization. Admins can disable Copilot for individual accounts or disable it altogether, and configure content exclusion to prevent certain files from being available to Copilot in Visual Studio.

In this article, you learn how to:
- [Disable Copilot](#disabling-copilot-for-individual-enterprise-visual-studio-accounts)
- [Configure content exclusion](#configure-content-exclusion)

## Disabling Copilot for individual Enterprise Visual Studio accounts

With Visual Studio version 17.10, project administrators can disable Copilot for individual accounts or disable Copilot altogether via the [Visual Studio Administrative Templates (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405), ensuring that your repository is protected.

To configure and deploy these policies, you can use [Microsoft Intune](../install/administrative-templates.md#deploying-the-policies) or the [Local Group Policy Editor](#configure-copilot-group-policy) directly on the client machine.

### Configure Copilot group policy

1. Head over to the Microsoft Download Center and grab the Visual Studio [Group Policy Administrative Template files (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405). It asks you where you want the files to be downloaded, ensure the location is `C:\Windows\PolicyDefinitions`.

2. Open the **Windows Local Group Policy Editor**, Navigate to Computer Configuration > Administrative Templates > Visual Studio > **Copilot Settings** and select a group policy.

   :::image type="content" source="media/vs-2022/copilot-inbox/intune-group-policy.png" alt-text="Screenshot of Group Policy to block Copilot for Individuals." lightbox="media/vs-2022/copilot-inbox/intune-group-policy.png":::

3. Once you select your group policy, configure the policy to enable or disable.
   
   :::image type="content" source="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png" alt-text="Screenshot of Group Policy to block copilot for individuals." lightbox="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png":::

4. Restart your Visual Studio instance to pick up the new policy changes

## Configure content exclusion

Content exclusion for GitHub Copilot enables administrators to prevent certain files from being available to Copilot and keep sensitive content secure from Copilot use. You can use content exclusions to configure GitHub Copilot to ignore specific files in a [repository](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-repository) or [organization](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-organization). Content exclusion is only available with a GitHub Copilot Business or a GitHub Copilot Enterprise subscription. 

With [Visual Studio 2022 version 17.11](/visualstudio/releases/2022/release-notes), GitHub Copilot for Visual Studio will ignore excluded content. When you exclude content from Copilot, completions and chat aren't available on the affected files.

Note that Visual Studio 2022 version 17.11 only respects rules in the root repository where your solution lives, and doesn't apply rules from git submodules or for files not under a git repo. 

### GitHub Copilot Completions in Visual Studio and content exclusions

- Code completions aren't available on excluded files.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-completions.png" alt-text="Screenshot of Copilot completions on an excluded file." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-completions.png":::

- Excluded content isn't included in code completion suggestions in other files.

### GitHub Copilot Chat in Visual Studio and content exclusions

- Excluded files can't be referenced in the chat window or in inline chat.

   **Chat window** 
    
   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-window.png" alt-text="Screenshot of using an excluded file in chat window." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-window.png":::
    
   **Inline chat**
    
   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-inline.png" alt-text="Screenshot of using an excluded file in inline chat." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-inline.png":::

- Excluded content isn't included in GitHub Copilot Chat's responses.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-response.png" alt-text="Screenshot of chat's responses on excluded content." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-response.png":::
