---
title: "How to report a problem with Visual Studio 2017"
description: "Find out how to report a problem with Visual Studio 2017 to Microsoft so that we can diagnose and fix it."
ms.custom: ""
ms.date: 03/11/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
ms.assetid: bee01179-cde5-4419-9095-190ee0ba5902
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# How to report a problem with Visual Studio 2017

If you experience a problem with Visual Studio, we want to know about it. This article details how to report the problem to [Developer Community](https://developercommunity.visualstudio.com/) so that we can diagnose and fix it.

## Report a problem through Visual Studio

To report a problem for Visual Studio, you can't do it directly through the [Developer Community](https://developercommunity.visualstudio.com/) website. You must initiate the report from Visual Studio or Visual Studio Installer, so that diagnostic information is automatically included in the report.

![Report an issue pop-up on Visual Studio Developer Community](media/report-an-issue.png)

1. In Visual Studio, select **Help** > **Send Feedback** > **Report a Problem**.

   > [!TIP]
   > If you can't complete the Visual Studio installation or you can't access the feedback tool within Visual Studio, you can report a problem by using the **Visual Studio Installer**. To do so, choose the feedback icon in the upper-right corner of the **Visual Studio Installer**.

1. If you are not signed in, select **Sign In**; it's on the right-hand side of the tool, as shown in the following screenshot. Follow the instructions on-screen to sign in.

   ![Sign in to report a problem](../ide/media/sign-in-new-ux.png)

   When you sign in, you can report a problem that you're experiencing, and also vote or comment on it. You can also vote or comment on any other problem that you see posted.

1. Visual Studio provides an interface to search for your problem and see if others have reported it, too. If someone has reported it, "up-vote" it to let us know.

   ![Search and vote for similar problems](../ide/media/search-and-vote.png)

1. If you don’t find the problem you encountered, choose **Report new problem** at the bottom of the screen.

   > [!NOTE]
   > The **Report new problem** button only appears in the Visual Studio interface for Developer Community. You can't report a problem directly on the [Developer Community](https://developercommunity.visualstudio.com/) website.

1. Create a descriptive title for the problem that helps us route it to the correct Visual Studio team.

1. Give us any additional details, and if possible, provide us with the steps to reproduce the problem.

   ![Report a new problem](../ide/media/report-new-problem.png)

1. Select **Next** to move to the **Attachments** tab. Here, you can capture your current screen to send it to Microsoft. To attach additional screenshots or other files, choose **Attach Additional Files**.

   ![Attach a screenshot to a Visual Studio problem report](media/report-a-problem-screenshot.png)

1. If you don't want to attach a screenshot or [record a repro](#record-a-repro), select **Next** to move to the **Summary** tab.

1. Select **Submit** to send your report, along with any images and trace or dump files. (If the **Submit** button is grayed out, make sure that you've provided a title and description for the report.)

## Record a repro

Trace and heap dump files are useful in helping us diagnose problems. We appreciate it when you use the **Report a Problem** tool to record your repro steps and send the data to Microsoft. Here's how to do so:

1. After you enter a title and description for your problem, select **Next** to move to the **Attachments** tab.

1. Select the **Record** tab.

1. Under **Record your actions**, select the current instance of Visual Studio if you can reproduce the problem there. If you can't, for example if Visual Studio is hung, select **\<Create a new instance>** to record the actions in a new instance of Visual Studio.

1. Select **Start Recording**. Give permission to run the tool.

   ![Choose "Start Recording" to provide a trace and heap dump file in a Visual Studio problem report](../ide/media/record-dialog-box.png)

1. When the **Steps Recorder** tool appears, perform the steps that reproduce the problem.

1. When you're done, choose the **Stop Record** button.

1. Wait a few minutes for Visual Studio to collect and package the information that you recorded.

## Search for solutions or provide feedback

If you don't want to or can't use Visual Studio to report a problem, there's a chance that the problem has already been reported and a solution posted on the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/) page.

If you don't have a problem to report but want to provide product feedback or a suggestion, there's a place for that, too. For more information, see the [UserVoice](https://visualstudio.uservoice.com/forums/121579-visual-studio-ide) page.

## See also

* [Talk to us](../ide/talk-to-us.md)
* [Report a problem with Visual Studio for Mac](/visualstudio/mac/report-a-problem)
* [Report a problem with C++](/cpp/how-to-report-a-problem-with-the-visual-cpp-toolset)
* [Visual Studio Developer Community](https://developercommunity.visualstudio.com/)
* [Developer Community data privacy](developer-community-privacy.md)