---
title: 'GitHub Copilot Free in Visual Studio'
description: Use GitHub Copilot Completions, Chat, and Edits for free in Visual Studio.
ms.date: 12/18/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Use GitHub Copilot for free in Visual Studio

GitHub Copilot Free enables you to experience AI-powered coding assistance in your IDE by providing limited access to select Copilot features, without requiring a subscription. With [Copilot Free]((https://aka.ms/ghdocscopilotfreepage)), individual developers can now use [Completions](visual-studio-github-copilot-extension.md) and [**Chat**](visual-studio-github-copilot-chat.md) for free in Visual Studio.

Copilot Free is not available if you have an EMU account or an existing Copilot subscription.

## Prerequisites

To get started with Copilot Free in Visual Studio, you need:
+ Visual Studio 2022 [version 17.8](/visualstudio/releases/2022/release-history) or later
+ [GitHub Copilot](visual-studio-github-copilot-install-and-states.md) in Visual Studio
+ No active GitHub Copilot subscription

Support for GitHub Copilot is provided by GitHub and can be reached at https://support.github.com.

## Set up Copilot Free

To use Copilot Free in Visual Studio, you first have to activate it in your GitHub account settings.

- Select **Get Copilot** from the chat window to open the [GitHub account settings](https://github.com/settings/copilot) page.
  You can also select **Get Copilot Subscription** from the **GitHub Copilot** badge dropdown in the Visual Studio upper-right corner..
- Select **Start using Copilot Free** to activate Copilot Free and open a conversation thread.
- Select **Use Copilot in other IDEs** and follow the steps for Visual Studio. 

## Limitations of Copilot Free

Copilot Free provides a limited number of code completions and chat responses for free per month.

Completions and Chat won't function as expected when you hit the usage limits on the free plan.

| **Feature limit reached** | **Functionality change** | **Copilot status** |
|-------------|----------------------|:----------:|
| Completions | IntelliCode suggestions instead of Copilot completions. <br/> Suggestions are shorter and less contextual. | Active |
| Chat | No chat responses. <br/> Chat interface may appear unresponsive | Active |
| Completions & Chat |  IntelliCode suggestions. <br/> No completions and no chat responses. | Inactive |

When you reach usage limits for Copilot Free, you can wait for them to reset at the end of the monthly cycle or upgrade to Copilot Pro to continue using Copilot.
You can check your monthly usage limits on the GitHub account settings page.

## Frequently asked questions

#### Who can access Copilot Free?

Copilot Free is not avilable if you have an EMU account, access to a Copilot seat through an organization, an existing Copilot Pro subscription or trial, or free access to Copilot Pro as a student, teacher, or open-source maintainer.

#### Can I turn off completions to save them for later?

Yes. You can enable or disable completions at any time.
From **GitHub Copilot** badge in the upper-right corner of your IDE, select **Settings** > **Options** and then select or unselect **Enable Copilot Completions**. 

#### Can I block suggestions matching public code with Copilot Free?

Yes. You can configure these settings from the [GitHub Copilot Settings](https://github.com/settings/copilot) page.

#### When will my free usage limits renew?

Limits renew every 30 days after you first activate Copilot Free.

#### What features are included in Copilot Free?

Copilot Free includes the following features: Copilot Completions, Edits, and Chat.
Learn more at [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)

#### Why doesn't Copilot Free work for me?

If you signed up for Copilot Free but Completions or Chat no longer work, you may have reached the monthly usage [limits](#limitations-of-copilot-free) on the free plan for either or both of them.
Check your status on the GitHub account settings page.

## Related content

- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)
- [GitHub Copilot experience for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
