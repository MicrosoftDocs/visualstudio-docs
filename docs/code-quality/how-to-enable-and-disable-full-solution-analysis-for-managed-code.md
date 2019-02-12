---
title: "How to: Enable and Disable Full Solution Analysis for Managed Code"
ms.date: 03/23/2018
ms.topic: "conceptual"
helpviewer_keywords:
  - "full solution analysis"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Enable and disable full solution analysis for managed code

*Full solution analysis* is a Visual Studio feature that enables you to see code analysis issues only in open Visual C# or Visual Basic files in your solution, or also in code files that are closed. By default, full solution analysis is *enabled* for Visual Basic, and *disabled* for Visual C#.

It can be useful to see all issues in all files, but it can also be distracting. It slows Visual Studio down if your solution is very large or has many files. To limit the number of issues shown and improve Visual Studio performance, you can disable full solution analysis. You can easily reenable this feature if necessary.

## To toggle full solution analysis

1. To open the **Options** dialog box, on the menu bar in Visual Studio choose **Tools** > **Options**.

1. In the **Options** dialog box, choose **Text Editor** > **C#** or **Basic** > **Advanced**.

1. Select the **Enable full solution analysis** check box to enable full solution analysis, or clear the box to disable it. Choose **OK** when you're done.

    ![Enable full solution analysis check box.](../code-quality/media/options-enable-full-solution-analysis.png)

## Results of enabling and disabling full solution analysis

In the following screenshot, you can see the results when full solution analysis is enabled. All errors and code analysis issues in *all* of the files in the solution appear, regardless of whether the files are open or not.

![Full solution analysis enabled.](../code-quality/media/fsa_enabled.png)

The following screenshot shows the results from the same solution after disabling full solution analysis. Only errors and code analysis issues in open solution files appear in the **Error List**.

![Full solution analysis disabled.](../code-quality/media/fsa_disabled.png)

## Automatically disable full solution analysis

If Visual Studio detects that 200 MB or less of system memory is available to it, it automatically disables full solution analysis (and some other features) if it's enabled. If this occurs, an alert appears informing you that Visual Studio has disabled some features. A button lets you reenable full solution analysis if you want.

![Alert text suspending full solution analysis](../code-quality/media/fsa_alert.png)