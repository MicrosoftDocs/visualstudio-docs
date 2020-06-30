---
title: Developer Community Guidelines
description: "Describes the guidelines for working with the Visual Studio Developer Community."
ms.date: 6/30/2020
ms.topic: conceptual
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "multiple"
---
# Developer Community Guidelines

The Developer Community tracks issues and feature suggestions for Visual Studio.

## Submitting problems and suggestions

The [Developer Community](https://developercommunity.visualstudio.com/) tracks issues and feature suggestions for Visual Studio.

### Before submitting an issue

Search for your issue on Visual Studio Developer Community to ensure your issue doesn't already exist. If you find your issue already exists, make relevant comments and cast your vote.

If your issue is a question, ask the community on [Stack Overflow](https://stackoverflow.com/questions/tagged/visual-studio?tab=Newest) using the tag _visual-studio_. We have customer support staff monitoring that tag and will help answer the questions.

If you can't find an existing issue that describes your bug or feature, submit an issue using the guidelines below.

### Writing a good bug report or feature suggestion

1. File only one problem or feature request per issue.

- Combining multiple problems or feature requests into a single issue makes it harder for us to diagnose, and harder for other users to vote for your issue.
- Don't add your issue as a comment to an existing issue unless it's for the identical input. Many issues look similar but have different causes, which makes it harder for us to diagnose your issue.

2. The more information you can provide, the easier it will be for us to reproduce and fix your issue.
3. Include the following steps with each issue.

- Reproducible steps (1... 2... 3...) and what you expected versus what you experienced.
- Images, animations, or a link to a video. Images and animations illustrate repro-steps but _don't_ replace them.
- As appropriate, a code snippet that demonstrates the issue or a link to a code repository we can easily pull down onto our machine to recreate the issue.

4. Remember to do the following steps:

- Search to see if there exists a duplicate. If so, vote up the existing issue, providing additional comments or clarifications as needed.
- Recreate the issue after disabling all extensions. If you find the issue is caused by an extension you've installed, file an issue on the extension respectively.
- Simplify your code around the issue so we can better isolate the problem.

Note that even with issues that include rich details, we may not be able to reproduce the issue and may ask for more information!

## Managing problem reports

Triaging an issue is a multi-step process that is collaboratively done within the feature team. Triaging usually takes one week but may take longer. The goal of triaging is to provide you with a clear understanding of what will happen to your issue. For example, after triage you know whether we plan to fix your issue or whether we'll wait to hear what the broader community thinks about it.

After you report a problem, states indicate where your submissions are in their lifecycle. As Visual Studio product teams review your feedback, they set it with an appropriate state. Track the progress of your problem reports by referencing the [Problem states and FAQ](https://docs.microsoft.com/visualstudio/ide/report-a-problem).

If an issue is missing information that we need to understand the issue, we assign the _Needs More Info_ state. We add a comment to the issue with the specific information we need, and you'll receive an email notification. If we don't receive the needed information within seven days, the system adds a comment asking for the info again or we'll close the issue in 14 days.

### Won't fix Bugs

We close some bugs if there's a negative cost-benefit balance. For example, if the fix is so complex that it risks regressions for many users, fixing may not be a reasonable choice. When we close a bug like this, we'll explain why we do so.

#### Additional information

- [How to increase the chances of a performance issue being fixed](https://docs.microsoft.com/visualstudio/ide/how-to-increase-chances-of-performance-issue-being-fixed)
- [Troubleshoot and create logs for MSBuild problems](https://docs.microsoft.com/visualstudio/ide/msbuild-logs)

## Managing feature suggestions

Feature suggestions, are a means of communication between us and the members of the community. Technically we could keep feature requests open regardless of plans to address the request. Keeping the issues open would reduce community visibility into the actual status of a feature. So, we close feature requests we won't address and assign features we'll address to the _Under Review_ label.

If you suggested a feature, you might be disappointed that we don't plan to address your request. We understand that. All of us have been there - in this project or others we've contributed to. So, rest assured, we love all your input. Don't take personal offense when we close or assign the _Under Review_ label to your suggestion. If you feel your feature suggestion deserves to stay open, clarify your use case and contact us or gather more up-votes.

In our decision-making process, we look at the following characteristics about the feature suggestion:

- Can we afford to build and maintain it?
- Does it align with our overall [roadmap](https://docs.microsoft.com/visualstudio/productinfo/vs-roadmap) strategy?
- Does it have lots of community support, as indicated by votes and comments?
- Do we love it, regardless of its community support?

Suggestions where we can't answer "yes" to any of these questions, are unlikely to be added to our roadmap. But often the suggestion will remain open in the _Under Review_ state to gather more community feedback.

Track the progress of your feature suggestion by referencing the [Suggestion states and FAQ](https://docs.microsoft.com/visualstudio/ide/report-a-problem).

## Discussion etiquette

To keep the conversation clear and transparent, limit discussion to English and keep things on topic with the issue. Be considerate to others and always try to be courteous and professional.

For more information, ee the [Microsoft Community Code of Conduct](https://answers.microsoft.com/en-us/page/codeofconduct).

Any violations to the discussion etiquette can lead to removal of the comment and eventually banning the user.

## Data Privacy

By default, comments and replies are publicly visible, but any attached files are privately shared with Microsoft only. This visibility is beneficial because it allows the entire community to see the issues and solutions found by other users. However, if you're concerned about the privacy of your data or identity, you have options. For more information, see the [Developer Community data privacy](https://docs.microsoft.com/visualstudio/ide/developer-community-privacy).