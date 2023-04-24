---
title: Improve performance if Visual Studio is slow
titleSuffix: ''
description: Learn how to improve Visual Studio performance if you find that it's running slowly.
ms.date: 04/23/2023
ms.topic: conceptual
helpviewer_keywords:
- performance [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
f1_keywords:
- vs.performancecenter
ms.workload:
- multiple
---
# Optimize Visual Studio performance

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article provides some suggestions to try if you find that Visual Studio is running slowly. You can also take a look at [Visual Studio performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md) for more suggestions on how to improve performance.

## Upgrade Visual Studio

If you're currently using an earlier version of Visual Studio, such as Visual Studio 2017 or Visual Studio 2019, download [Visual Studio 2022](https://visualstudio.microsoft.com/downloads) for free to check out its improved performance. Solutions load much faster than in earlier versions, with performance improvements in other areas too. You can install Visual Studio on a computer that has an earlier or later version of Visual Studio already installed. For more information, see [Install Visual Studio versions side-by-side](../install/install-visual-studio-versions-side-by-side.md).

## Extensions and tool windows

You might have extensions installed that slow Visual Studio down. For help on managing extensions to improve performance, see [Change extension settings to improve performance](../ide/optimize-visual-studio-startup-time.md#extensions).

Similarly, you might have tool windows that slow Visual Studio down. For help on managing tool windows, see [Change tool window settings to improve performance](../ide/optimize-visual-studio-startup-time.md#tool-windows).

## Hardware

If you're thinking about upgrading your hardware, a solid state drive (SSD) has more effect on performance than additional RAM or a faster CPU.

If you do add an SSD, for optimal performance install Windows on that drive as opposed to a hard disk drive (HDD). The drive location of your Visual Studio solutions doesn't seem to matter as much.

Additionally, don't run your solution from a USB drive. Copy it to your HDD or SSD.

## Help us improve

Your feedback helps us improve. Use the **Report a Problem** feature to “record” a trace and send to us. Select **Help** > **Send Feedback** > **Report a Problem** from the menu bar. For more information, see [How to report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio.md).

## See also

- [Performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md)