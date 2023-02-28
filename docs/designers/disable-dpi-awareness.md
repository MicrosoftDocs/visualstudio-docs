---
title: Fix DPI display issues in Windows Form Designer
description: Disable DPI awareness to fix scaling issues with Windows Forms Designer on HDPI monitors.
ms.date: 02/28/2023
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.topic: how-to
ms.custom: contperf-fy23q2; engagement-fy23
---
# Disable DPI-awareness to fix HDPI / scaling issues with Windows Forms Designer in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you'll learn how to address scaling limitations of the Windows Forms Designer on HDPI monitors by [running Visual Studio as a DPI-unaware process](#restart-visual-studio-as-a-dpi-unaware-process).

## What is DPI and why does it matter?

DPI stands for dots per inch, where a dot represents a physical device pixel. (The nomenclature comes from printing, where dots are the smallest ink dot that a printing process can produce). HDPI stands for high dots per inch.

Historically, monitors shipped with 96 pixels per inch. The Windows operating system drew a bitmap that represented 96 DPI as 100%. But as display technology progressed, that DPI threshold was surpassed. Monitors started shipping with display panels close to 300 DPI or higher.

While higher pixel density produces sharper images, some sort of display scaling is required to size elements on the screen properly. Otherwise, user interface (UI) elements and text are too tiny to use effectively and can overlap. To help remedy this, Windows automatically scales the UI percentile to match the DPI setting. For example, a DPI setting of 100% represents 96 DPI, where 125% is 120 DPI, and 150% is 144 DPI. This automatic scaling affects text, graphics, controls, and window sizes.

Here's where DPI-aware vs. DPI-unaware comes in. When an application declares itself to be DPI-aware, it's a statement specifying that the app behaves well at higher DPI settings and so Windows can apply auto-scaling. Conversely, DPI-unaware applications render at a fixed DPI value of 96 pixels per inch, or 100%, and so auto-scaling isn't applied.

## Visual Studio is DPI-aware

Visual Studio is a dots per inch (DPI)-aware application, which means the display scales automatically.

## Windows Forms Designer is DPI-unaware

**Windows Forms Designer** is a DPI-unaware application, which means that the Windows operating system presents the application as a bitmap at 100% scaling, or 96 DPI. Because **Windows Forms Designer** in Visual Studio doesn't have auto-scaling support, display issues can occur when you open some forms on HDPI (high dots per inch) monitors. For example, controls can appear to overlap as shown in the following image:

![Windows Forms Designer on HDPI monitor](./media/win-forms-designer-hdpi-1.gif)

When you open a form in the **Windows Forms Designer** on an HDPI monitor, Visual Studio displays an information bar. The information bar includes the following information:

- The scaling percentage that your monitor is currently using. In the following screenshot, the scaling is set to 150%, or 144 DPI.
- The option to restart Visual Studio at 100% scaling, or 96 DPI, so that Visual Studio can match the same scaling that **Windows Forms Designer** provides.
- Whether you want Visual Studio to provide you with further information to help you decide what to do.

:::image type="content" source="media/scaling-gold-bar-message-1.png" alt-text="Screenshot of the information bar in Visual Studio to restart in DPI-unaware mode.":::

When you restart Visual Studio at 100% scaling, or 96 DPI, you're restarting Visual Studio as DPI-unaware. This means that Windows won't apply auto-scaling, and that the **Windows Forms Designer** in Visual Studio can then render text, graphics, controls, and window sizes without overlap.

> [!TIP]
> 1. If you've closed the information bar but you still want to restart Visual Studio as DPI-unaware, you can. [Use the DevEnv.exe tool](#use-the-devenvexe-tool) to do so.
> 2. If you aren't working in the designer and don't need to adjust the layout of your form, you can ignore the information bar and continue working in the code editor or in other types of designers. (You can also [disable notifications](#disable-notifications) so that the information bar doesn't continue to appear.)

## Restart Visual Studio as a DPI-unaware process

The recommended solution to resolve UI issues that can occur in **Windows Forms Designer** is to restart Visual Studio as a DPI-unaware process, which means that it restarts at 100% scaling, or 96 DPI. To so so, select the "**Restart Visual Studio with 100% scaling**" option on the yellow information bar that appears when you open a form in **Windows Forms Designer**.

When Visual Studio runs as a DPI-unaware process, the designer layout issues are resolved, but fonts might appear blurry and you might see issues in other designers such as the **XAML Designer**. Visual Studio displays a different yellow informational message when it runs as a DPI-unaware process that says **Visual Studio is running as a DPI-unaware process. WPF and XAML designers might not display correctly.** The information bar also provides an option to **Restart Visual Studio as a DPI-aware process**.

::: moniker range="<=vs-2019"

> [!NOTE]
> - If you have undocked [tool windows](../ide/customizing-window-layouts-in-visual-studio.md#tool-and-document-windows) after you select the option to restart Visual Studio as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, or if you have the **Save new projects when created** option deselected in **Tools** > **Options** > **Projects and Solutions**, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

::: moniker range=">=vs-2022"

> [!NOTE]
> - If you undock [tool windows](../ide/customizing-window-layouts-in-visual-studio.md#tool-and-document-windows) after you select the option to restart Visual Studio as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

It's important to restart Visual Studio to return it to its default as a DPI-aware process when you're finished working in the **Windows Forms Designer**. If you close and reopen Visual Studio when it's running in DPI-unaware mode, it becomes DPI-aware again. You can also select the **Restart Visual Studio as a DPI-aware process** option in the information bar.

## Use Windows to set your display scaling to 100%

If you don't want to use Visual Studio to toggle display scaling on an as-needed basis, you can use Windows settings to do so. For example, you can set display scaling to 100%, or 96 DPI, in Windows 11.

To do so, type **display settings** in the task bar search box, and then select **Change display settings**. In the **Settings** window, set **Change the size of text, apps, and other items** to **100%**.  However, setting your display scaling to 100%, or 96 DPI, might be undesirable because it can make the user interface too small to be usable.

## <a name="use-the-devenvexe-tool"></a>Use the DevEnv.exe command-line tool to disable scaling

If you prefer to manage your display settings by using command-line tools instead of UI (user interface) tools, you can with [DevEnv.exe](../ide/reference/devenv-command-line-switches.md). The `devenv.exe` command takes `/noscale` as a command-line parameter to run in 100% scaling mode. Here's how to use it:

1. Select **Tools** > **Command Line** > **Developer Command Prompt** from the Visual Studio menu bar.
1. Then, enter `devenv /noScale`.

## Other options

In addition to the aforementioned options, you can also try the following options:

- [Automatically scale in Windows Forms](/dotnet/framework/winforms/automatic-scaling-in-windows-forms)

- Select the option to [Optimize rendering for screens with different pixel densities (requires restart)](../ide/reference/general-environment-options-dialog-box.md#visual-experience)

- <a name="disable-notifications"></a>**Disable scaling notifications** in Visual Studio, for example,  if you aren't working in a designer. Here's how to disable notifications:

  1. Choose **Tools** > **Options** to open the **Options** dialog.
  1. In the **Options** dialog, choose **Windows Forms Designer** > **General**, and set **DPI Scaling Notifications** to **False**.

## Troubleshoot

If the DPI-awareness transition doesn't work in Visual Studio, ensure the `dpiAwareness` value is NOT present in the **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\devenv.exe** subkey in Registry Editor. Delete the value if it is present.
