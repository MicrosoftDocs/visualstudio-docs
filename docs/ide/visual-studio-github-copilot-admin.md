---
title: Admin controls for GitHub Copilot in Visual Studio
description: GitHub Copilot in Visual Studio 2022 version 17.10 and later introduces new features for administrators to manage Copilot effectively. 
ms.date: 3/28/2024
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
monikerRange: vs-2022
---

# Admin controls for GitHub Copilot in Visual Studio 2022 version 17.10 Preview 3 or later
GitHub Copilot in Visual Studio 2022 17.10 or later introduces new features for administrators to manage Copilot effectively.

## Disabling Copilot for individual Enterprise Visual Studio accounts

In version 17.10, we're introducing two new features to disable Copilot, ensuring that your repository is protected:

1.  Project administrators can disable Copilot for individual accounts via the [Visual Studio Administrative Templates (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405).
1.  Copilot can be disabled altogether via [Visual Studio Administrative Templates (ADMX/ADML)](https://www.microsoft.com/en-us/download/details.aspx?id=104405).

These features provide administrators with greater control over the use of Copilot within their organization.

### Configure Copilot group policy

1. In the **Local Group Policy Editor** in Windows, find **Copilot Settings**, and select a group policy.

   :::image type="content" source="media/vs-2022/copilot-inbox/Intune-Group-Poilcy.png" alt-text="Screenshot of Group Policy to block copilot for indivduals." lightbox="media/vs-2022/copilot-inbox/Intune-Group-Poilcy.png":::

1. Once you select your group policy, configure the policy to enable or disable.
   
   :::image type="content" source="media/vs-2022/copilot-inbox/CFI-group-poilcy.png" alt-text="Screenshot of Group Policy to block copilot for individuals." lightbox="media/vs-2022/copilot-inbox/CFI-group-poilcy.png":::


5. Save your configuration and the policy is live.
