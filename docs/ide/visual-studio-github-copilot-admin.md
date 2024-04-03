---
title: Admin controls for GitHub Copilot in Visual Studio
description: GitHub Copilot in Visual Studio 2022 17.10 and higher introduces new features for administrators to manage Copilot effectively. 
ms.date: 3/28/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
monikerRange: vs-2022
---

# Admin controls for GitHub Copilot in Visual Studio 2022 (Version 17.10 or Higher)
GitHub Copilot in Visual Studio 2022 17.10 and higher introduces new features for administrators to manage Copilot effectively.

## Content Exclusion
Content exclusion is a feature that prevents specific files from being accessible to GitHub Copilot. Administrators can configure GitHub Copilot to ignore certain files by specifying paths to the content to be excluded. This can be done in the “Content Exclusion” page in the settings for your organization [described here](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-organization), or the settings for a repository [described here](https://docs.github.com/en/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot#configuring-content-exclusions-for-your-repository).
> This feature is only available in Copilot for Enterprise or Business.

When files are excluded, completions will not work, and users will not be able to use Copilot in Chat and Inline by referencing an excluded file.
For more information on how to configure content exclusions, refer to the Configuring content exclusions for GitHub Copilot - GitHub Docs.

> Please note, when customers attempt to use Content Exclusion, it will present as a file that Copilot cannot read in the different interactions on Copilot.

## Disabling Copilot for Individual Enterprise Visual Studio Accounts
In version 17.10, we have introduced two new features to disable Copilot, ensuring that your repository remains protected:
1.  Project administrators can disable Copilot for individual accounts via the Windows Local Group Policy Editor.
2.  Copilot can be disabled altogether via the Windows Local Group Policy Editor.
These features provide administrators with greater control over the use of Copilot within their organization.
