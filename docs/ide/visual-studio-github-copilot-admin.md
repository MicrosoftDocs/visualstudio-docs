---
title: Admin controls for GitHub Copilot in Visual Studio
description: GitHub Copilot in Visual Studio 2022 version 17.10 and later introduces new features for administrators to manage Copilot effectively. 
ms.date: 3/28/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
monikerRange: vs-2022
---

# Admin controls for GitHub Copilot in Visual Studio 2022 version 17.10 or later
GitHub Copilot in Visual Studio 2022 17.10 or later introduces new features for administrators to manage Copilot effectively.

## Disabling Copilot for individual Enterprise Visual Studio accounts
In version 17.10, we have introduced two new features to disable Copilot, ensuring that your repository remains protected:
1.  Project administrators can disable Copilot for individual accounts via the Windows Local Group Policy Editor.
1.  Copilot can be disabled altogether via the Windows Local Group Policy Editor.
These features provide administrators with greater control over the use of Copilot within their organization.

/**
 * This code represents the steps to perform a specific task using Visual Studio and GitHub Copilot.
 * 
 * Steps:
 * 1. Step 1 description.
 * 2. Step 2 description.
 * 3. Step 3 description.
 * ...
 */
### Steps:
1. Go to your Windows Local Group Policy Editor, find "Copilot Settings", and select a group policy

        :::image type="content" source="media\vs-2022\copilot-inbox\Intune-Group-Poilcy.png" alt-text="Screenshot of Group poilcy to block copilot for indivduals." lightbox="media\vs-2022\copilot-inbox\Intune-Group-Poilcy.png":::


2. Once you have selected your group policy, you can configure the policy to be enabled or disabled. 

        :::image type="content" source="media/vs-2022/copilot-inbox/CFI-group-poilcy" alt-text="Screenshot of Group poilcy to block copilot for indivduals." lightbox="media/vs-2022/copilot-inbox/CFI-group-poilcy":::


3. Save your configuration and the policy will be live 