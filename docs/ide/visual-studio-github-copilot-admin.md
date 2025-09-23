---
title: Admin controls for GitHub Copilot in Visual Studio
description: Learn about the new features for administrators in GitHub Copilot for Visual Studio that enable admins to manage Copilot effectively. 
ms.date: 9/23/2025
ms.update-cycle: 180-days
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: ">=vs-2022"
ms.custom: ai-learning-hub
---

# Admin controls for GitHub Copilot

Visual Studio 2022 introduces new features that enable administrators to configure and manage GitHub Copilot more effectively within their enterprise. These features provide administrators greater control over the use of Copilot within their organization. Admins can disable Copilot for individual accounts, disable it entirely, and configure content exclusion to prevent certain files from being available to Copilot in Visual Studio.

In this article, you learn how to:
- [Disable Copilot](#disable-copilot-skus)
- [Configure content exclusion](#configure-content-exclusion)

## Disable Copilot SKUs

With Visual Studio 2022 version 17.10 or later, project administrators can disable Copilot for individual accounts or disable it entirely using the [Visual Studio Administrative Templates (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405). This helps ensure that your repository remains protected.

With Visual Studio 2022 version 17.13 or later, you can disable Copilot Free. 

To configure and deploy these policies, you can use [Microsoft Intune](../install/administrative-templates.md#deploying-the-policies) or the [Local Group Policy Editor](#configure-copilot-group-policy) directly on the client machine. 

### Configure Copilot group policy

1. Visit the Microsoft Download Center to download the Visual Studio [Group Policy Administrative Template files (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405). When prompted, ensure the files are saved to `C:\Windows\PolicyDefinitions`.

2. Open the **Windows Local Group Policy Editor** and navigate to **Computer Configuration > Administrative Templates > Visual Studio > Copilot Settings**. Select a group policy.

   :::image type="content" source="media/vs-2022/copilot-inbox/intune-group-policy.png" alt-text="Screenshot of Group Policy Settings." lightbox="media/vs-2022/copilot-inbox/intune-group-policy.png":::

3. Once you select the group policy, configure it to enable or disable Copilot as needed.
   
   :::image type="content" source="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png" alt-text="Screenshot of Group Policy to block Copilot for individuals." lightbox="media/vs-2022/copilot-inbox/copilot-for-individuals-group-poilcy.png":::

4. Restart your Visual Studio instance to apply the new policy changes.

### Disable Copilot Agent Mode

With Visual Studio 2022 version 17.14.16 or later, project administrators can fully disable Agent Mode using Visual Studio Administrative Templates (ADMX/ADML).
With this policty setting administrators can control which AI-assisted features are available in their organization, helping ensure usage aligns with security and compliance requirements.

Policy location in the Local Group Policy Editor:
**Computer Configuration > Administrative Templates > Visual Studio > Copilot Settings > Disable Agent Mode**.

## Configure content exclusion

Content exclusion for GitHub Copilot enables administrators to prevent certain files from being available to Copilot and keep sensitive content secure from Copilot use. You can use content exclusions to configure GitHub Copilot to ignore specific files in a [repository](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-repository) or [organization](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-organization).

Content exclusion is available only with a GitHub Copilot Business or a GitHub Copilot Enterprise [subscriptions](https://docs.github.com/en/copilot/about-github-copilot/subscription-plans-for-github-copilot). 

With [Visual Studio 2022 version 17.11](/visualstudio/releases/2022/release-notes), GitHub Copilot for Visual Studio will ignore excluded content. When content is excluded, completions and chat aren't available for the affected files.

Note that Visual Studio 2022 version 17.11 respects rules only in the root repository where your solution lives, and doesn't apply rules from git submodules or for files not under a git repository. 

### GitHub Copilot Completions in Visual Studio and content exclusions

- Code completions aren't available for excluded files.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-completions.png" alt-text="Screenshot of Copilot completions on an excluded file." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-completions.png":::

- Excluded content isn't included in code completion suggestions for other files.

### GitHub Copilot Chat in Visual Studio and content exclusions

- Excluded files can't be referenced in the chat window or in inline chat.

   **Chat window** 
    
   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-window.png" alt-text="Screenshot of using an excluded file in chat window." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-window.png":::
    
   **Inline chat**
    
   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-inline.png" alt-text="Screenshot of using an excluded file in inline chat." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-inline.png":::

- Excluded content isn't included in GitHub Copilot Chat's responses.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-response.png" alt-text="Screenshot of chat's responses on excluded content." lightbox="media/vs-2022/visual-studio-github-copilot-admin/copilot-content-exclusions-chat-response.png":::

## Related content

- [GitHub Copilot settings](https://github.com/settings/copilot)
- [GitHub Copilot: Compare plans](https://github.com/features/copilot/plans)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)