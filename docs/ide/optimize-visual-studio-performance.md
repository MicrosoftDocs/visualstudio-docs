---
title: Improve performance if Visual Studio is slow
ms.date: 04/11/2018
ms.topic: conceptual
helpviewer_keywords:
  - "performance [Visual Studio]"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
f1_keywords:
  - "vs.performancecenter"
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Optimize Visual Studio performance

This article provides some suggestions to try if you find that Visual Studio is running slowly.

## Upgrade to Visual Studio 2017 version 15.6 or later

If you are currently using Visual Studio 2015, download [Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) for free to check out its improved performance. Solutions load two to three times faster in Visual Studio 2017, with performance improvements in other areas too. Visual Studio 2017 is side-by-side compatible with Visual Studio 2015, so you won't lose anything by trying it out.

If you are currently using Visual Studio 2017, make sure you are running version 15.6 or later. Data shows that solutions load up to two or three times faster in version 15.6. Download it [here](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

## Hardware

If you're thinking about upgrading your hardware, a solid state drive (SSD) has more effect on performance than additional RAM or a faster CPU.

If you do add an SSD, for optimal performance install Windows on that drive as opposed to a hard disk drive (HDD). The drive location of your Visual Studio solutions does not seem to matter as much.

Additionally, do not run your solution from a USB drive. Copy it to your HDD or SSD.

## Other suggestions

If you have the ReSharper extension installed, it may be slowing Visual Studio down. Consider turning it off until you need it. To suspend ReSharper, go to **Tools** > **Options** > **ReSharper Ultimate**, and then select **Suspend Now**.

Read [Visual Studio performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md) for more suggestions to improve performance.

## Help us improve

Your feedback helps us improve. Use the **Report a Problem** feature to “record” a trace and send to us. Select the feedback icon next to **QuickLaunch**, or select **Help** > **Send Feedback** > **Report a Problem** from the menu bar. For more information, see [How to report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md).

## See also

- [Performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md)
- [Visual Studio blog - Load solutions faster with Visual Studio 2017 version 15.6](https://blogs.msdn.microsoft.com/visualstudio/2018/04/04/load-solutions-faster-with-visual-studio-2017-version-15-6/)
