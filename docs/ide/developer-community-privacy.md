---
title: Private data for problem reports
ms.date: 06/21/2018
ms.topic: conceptual
helpviewer_keywords:
  - developer community privacy
  - privacy, developer community
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Developer Community data privacy

By default, all information in problem reports on [Developer Community](https://developercommunity.visualstudio.com/), including any comments and replies, is publicly visible. This is beneficial because it allows the entire community to see the issues, solutions, and workarounds that other users have found. However, if you're concerned about the privacy of your data or identity, you have options.

## Identity privacy

If you're concerned about revealing your identity, [create a new Microsoft account](https://signup.live.com/) that does not disclose any details about you. Use this account to create your report.

## Data privacy

If you're concerned about data privacy, don't put anything you want to keep private in the title or content of the initial report, which is always public. Instead, create the report, and then note that you'll send details privately in a separate comment. Once the problem report is created, you can specify who can see replies and attachments:

1. In the report you created, choose **Add comment** to create a private description of the problem.

2. In the reply editor, use the control below the **Submit** and **Cancel** buttons to specify the audience for your reply. Choose **Viewable by moderators and the original poster** to limit visibility to Microsoft employees and yourself.

   ![Privacy control on Developer Community](media/developer-community-privacy-control.png)

   Only the people you specify can see the comment and any images, links, or code you include in it. Any replies under the comment have the same visibility as the original comment. This is true even if the privacy control on replies doesn't show the restricted visibility status correctly.

3. Add the description and any other information, images, and file attachments needed for your repro. Choose the **Submit** button to send this information privately.

   > [!NOTE]
   > There is a 2-GB limit on attached files, and a maximum of 10 files. If you need to upload a larger file, you can either submit a new problem report or request an upload URL from a Microsoft employee in a private comment.

To maintain your privacy and keep sensitive information out of public view, take care to keep all interactions with Microsoft to replies under a visibility-restricted comment. Replies to other comments may cause you to accidentally disclose sensitive information.

## Data we collect

If **Report a problem** is initiated from Visual Studio Installer, we collect the most recent setup log.

If **Report a problem** is initiated from Visual Studio, we collect one or more of the following types of data:

- Watson and .NET entries from the event log

- Visual Studio in-memory activity log file

- PerfWatson files, if Watson collection is enabled, from the *VSFeedbackPerfWatsonData* folder

- LiveShare log files, if they exist, from the *VSFeedbackVSRTCLogs* folder

- Xamarin log files, if they exist, from *%LOCALAPPDATA%\Xamarin\Logs*

- Nuget log files, if they exist, from *%TEMP%\NuGetScratch\nuget-dg\nugetSpec.dg*

- Web debugger log files, if they exist:

  - *%TEMP%\vscode-chrome-debug.txt*

  - *%TEMP%\vscode-node-debug2.txt*

  - *%TEMP%\vscode-edge-debug.txt*

- A screenshot, if you choose to include it

- Recording data, if you choose to include a recording, which includes:

  - Steps to reproduce the problem

  - ETL trace file

  - Dump file

  > [!NOTE]
  > You can delete any of the recording data that you don't wish to submit before submitting the report.

## See also

- [How to report a problem with Visual Studio](how-to-report-a-problem-with-visual-studio.md)
- [C++ problem report data privacy](/cpp/how-to-report-a-problem-with-the-visual-cpp-toolset#reports-and-privacy)
