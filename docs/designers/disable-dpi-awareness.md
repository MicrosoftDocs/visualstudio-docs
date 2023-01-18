---
title: Fix DPI display issues in Windows Form Designer
description: Disable DPI awareness to fix scaling issues with Windows Forms Designer on HDPI monitors.
ms.date: 12/31/2022
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.topic: how-to
ms.custom: contperf-fy23q2
---
# Disable DPI-awareness to fix HDPI / scaling issues with Windows Forms Designer in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you'll learn how to address scaling limitations of the Windows Forms Designer on HDPI monitors by [running Visual Studio as a DPI-unaware process](#restart-visual-studio-as-a-dpi-unaware-process). 

Visual Studio is a dots per inch (DPI) aware application, which means the display scales automatically. If an application states that it's not DPI-aware, the operating system scales the application as a bitmap. This behavior is also called DPI virtualization. The application still thinks that it's running at 100% scaling, or 96 DPI.  

Since the **Windows Forms Designer** in Visual Studio doesn't have scaling support, display issues can occur when you open some forms on high dots per inch (HDPI) monitors. For example, controls can appear to overlap as shown in the following image:

![Windows Forms Designer on HDPI monitor](./media/win-forms-designer-hdpi-1.gif)

When you open a form in the **Windows Forms Designer** on an HDPI monitor, Visual Studio displays an information bar.

:::image type="content" source="media/scaling-gold-bar-message-1.png" alt-text="Screenshot of the information bar in Visual Studio to restart in DPI-unaware mode.":::

> [!TIP]
> 1. If you've closed the information bar but you still want to restart Visual Studio with 100% scaling, you can. [Use the DevEnv.exe tool](#use-the-devenvexe-tool) to do so.
> 2. If you aren't working in the designer and don't need to adjust the layout of your form, you can ignore the information bar and continue working in the code editor or in other types of designers. (You can also [disable notifications](#disable-notifications) so that the information bar doesn't continue to appear.) Only the **Windows Forms Designer** is affected.

## Restart Visual Studio as a DPI-unaware process

The recommended solution to this issue is to restart Visual Studio as a DPI-unaware process. Do so by selecting the option on the yellow information bar that appears when you open the form in the Windows Forms Designer.

When Visual Studio runs as a DPI-unaware process, the designer layout issues are resolved, but fonts may appear blurry and you may see issues in other designers such as the **XAML Designer**. Visual Studio displays a different yellow informational message when it runs as a DPI-unaware process that says **Visual Studio is running as a DPI-unaware process. WPF and XAML designers might not display correctly.** The informational bar also provides an option to **Restart Visual Studio as a DPI-aware process**.

::: moniker range="<=vs-2019"

> [!NOTE]
> - If you have undocked [tool windows](../ide/customizing-window-layouts-in-visual-studio.md#tool-and-document-windows) in Visual Studio when you select the option to restart as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, or if you have the **Save new projects when created** option deselected in **Tools** > **Options** > **Projects and Solutions**, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

::: moniker range=">=vs-2022"

> [!NOTE]
> - If you have undocked [tool windows](../ide/customizing-window-layouts-in-visual-studio.md#tool-and-document-windows) in Visual Studio when you select the option to restart as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

It's important to restart Visual Studio as a DPI-aware process when you're finished working in the **Windows Forms Designer**. If you close and reopen Visual Studio when it's running in DPI-unaware mode, it becomes DPI-aware again. You can also select the **Restart Visual Studio as a DPI-aware process** option in the informational bar.

## Set your display scaling setting to 100%

With this option, you can resolve the issue by setting your display scaling setting to 100% in Windows 11. To do so, type **display settings** in the task bar search box, and then select **Change display settings**. In the **Settings** window, set **Change the size of text, apps, and other items** to **100%**.  However, setting your display scaling to 100% may be undesirable since it can make the user interface too small to be usable.

## <a name="use-the-devenvexe-tool"></a>Disable scaling using the DevEnv.exe command-line tool

With this option, you can manage scaling settings from the command line, [`devenv.exe`](../ide/reference/devenv-command-line-switches.md) takes `/noscale` as a command-line parameter to run in 100% scaling mode. Here's how:

1. Select **Tools** > **Command Line** > **Developer Command Prompt** from the Visual Studio menu bar.
1. Then, enter `devenv /noScale`.

## Other options

In addition to the aforementioned options, you can:
+ [Automatically scale in Windows Forms](/dotnet/framework/winforms/automatic-scaling-in-windows-forms)

+ Select the option to [Optimize rendering for screens with different pixel densities (requires restart)](../ide/reference/general-environment-options-dialog-box.md#visual-experience)

+ <a name="disable-notifications"></a>**Disable scaling notifications** in Visual Studio, for example,  if you aren't working in the designer. To disable notifications:
  1. Choose **Tools** > **Options** to open the **Options** dialog.
  1. In the **Options** dialog, choose **Windows Forms Designer** > **General**, and set **DPI Scaling Notifications** to **False**.

## Troubleshoot

If the DPI-awareness transition doesn't work in Visual Studio, ensure the `dpiAwareness` value is NOT present in the **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\devenv.exe** subkey in Registry Editor. Delete the value if it is present.
