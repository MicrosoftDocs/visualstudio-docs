---
title: Scaling on your main display is set to X%
description: Learn about the scaling percentage settings message you see with Windows Forms Designer on HDPI monitors, and what to do next.
ms.date: 11/06/2025
ms.topic: ui-reference
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: ui-designers
monikerRange: "visualstudio,<=vs-2022"
---
# Scaling on your main display is set to X%

When you open a form in **Windows Forms Designer** on an HDPI monitor, Visual Studio displays an information bar with a message that includes the monitor's current scaling percentage and an option to restart Visual Studio at 100% scaling. Restarting at 100% scaling allows for proper rendering without overlap.

:::image type="content" source="media/scaling-gold-bar-message-1.png" alt-text="Screenshot of the information bar in Visual Studio to restart in DPI-unaware mode.":::

## Why this message appears and what to do about it

If your Windows Forms designer UI looks fine, you can ignore this message or [disable it](#disable-the-notification).

If the display doesn't look right, try the link to restart Visual Studio and see if that solves the problem.

If you want to understand more, continue reading.

Here's why the message appears:

- Windows Forms Designer is [DPI-unaware](disable-dpi-awareness.md#windows-forms-designer-is-dpi-unaware), while Visual Studio is DPI-aware. 
- To accurately display Forms elements in the Designer, you can set Visual Studio to 100% scaling so that it, too, is DPI-unaware. 
- When Visual Studio is set to 100% scaling, fonts might appear blurry and you might see issues in other designers, such as the XAML Designer, which are DPI-aware. 

Here's what to do about it:

- Select the **Restart Visual Studio with 100% scaling** link in the message on the information bar to [restart Visual Studio as a DPI-unaware process](disable-dpi-awareness.md#restart-visual-studio-as-a-dpi-unaware-process), which means that it restarts at 100% scaling (96 DPI).
- You can also [set the scaling size in Windows](disable-dpi-awareness.md#use-windows-to-set-your-display-scaling-to-100) to 100%, but it can make the user interface (UI) too small to be usable.
- When Visual Studio runs as DPI-unaware, the designer layout issues are resolved. However, fonts might appear blurry and issues can appear in other designers such as the XAML Designer. 
- If you've previously set Visual Studio to 100% scaling and want to re-enable DPI awareness, select the **Restart Visual Studio with automatic scaling** link in the information bar to restart Visual Studio as DPI-aware. 

## Disable the notification

You can stop the notification from appearing by changing a setting.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **Windows Forms Designer** > **General** section.

1. Under **High DPI Support**, clear the **DPI scaling notifications** checkbox.

:::moniker-end
:::moniker range="<=vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **Windows Forms Designer** > **General** section.

1. Under **High DPI Support**, set the **DPI scaling notifications** option to **False**.

:::moniker-end

## Next steps

For more information about HDPI scaling issues and detailed, step-by-step instructions on how to fix them, see [HDPI/scaling issues with Windows Forms Designer in Visual Studio](disable-dpi-awareness.md).
