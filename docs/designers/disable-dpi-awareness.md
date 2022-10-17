---
title: Disable DPI-awareness for scaling in forms
description: Fix scaling issues with Windows Forms Designer on HDPI monitors.
ms.date: 04/10/2022
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.topic: how-to
ms.custon: contperf-fy22q2
---
# Disable DPI-awareness to fix HDPI / scaling issues with Windows Forms Designer in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you'll learn the limitations of Windows Forms Designer on HDPI monitors and [how to run Visual Studio as a DPI-unaware process](#resolve-hdpi-display-problems).

Visual Studio is a dots per inch (DPI) aware application, which means the display scales automatically. If an application states that it's not DPI-aware, the operating system scales the application as a bitmap. This behavior is also called DPI virtualization. The application still thinks that it's running at 100% scaling, or 96 dpi.

You can also:
+ [Automatically scale in Windows Forms](/dotnet/framework/winforms/automatic-scaling-in-windows-forms)
+ Select the option to [Optimize rendering for screens with different pixel densities (requires restart)](../ide/reference/general-environment-options-dialog-box.md#visual-experience)

## Scaling issues in Windows Forms Designer on HDPI monitors

Since the **Windows Forms Designer** in Visual Studio doesn't have scaling support, display issues can occur when you open some forms on high dots per inch (HDPI) monitors. For example, controls can appear to overlap as shown in the following image:

![Windows Forms Designer on HDPI monitor](./media/win-forms-designer-hdpi-1.gif)

If you aren't working in the designer and don't need to adjust the layout of your form, you can ignore the informational bar and continue working in the code editor or in other types of designers. (You can also [disable notifications](#disable-notifications) so that the informational bar doesn't continue to appear.) Only the **Windows Forms Designer** is affected.

When you open a form in the **Windows Forms Designer** on an HDPI monitor, Visual Studio displays an informational bar.

:::image type="content" source="media/scaling-gold-bar-message-1.png" alt-text="Screenshot of the informational bar in Visual Studio to restart in DPI-unaware mode.":::



> [!TIP]
> If you've closed the informational bar at the top of the designer, but you still want to replicate the behavior of the link that says **Restart Visual Studio with 100% scaling**, you still can. Select **Tools** > **Command Line** > **Developer Command Prompt** from the Visual Studio menu bar. Then, enter `devenv /noScale`.

## Resolve HDPI display problems

There are three options to resolve the display problem:

- [Restart Visual Studio as a DPI-unaware process](#restart-visual-studio-as-a-dpi-unaware-process)
- [Add a registry entry](#add-a-registry-entry)
- [Set your display scaling setting to 100%](#set-your-display-scaling-setting-to-100)

> [!TIP]
> If you prefer to manage settings from the command line, [`devenv.exe`](../ide/reference/devenv-command-line-switches.md) takes `/noscale` as a command-line parameter to run in 100% scaling mode.

### Restart Visual Studio as a DPI-unaware process

The preferred solution to this issue is to restart Visual Studio as a DPI-unaware process. Do so by selecting the option on the yellow informational bar. 

When Visual Studio runs as a DPI-unaware process, the designer layout issues are resolved, but fonts may appear blurry and you may see issues in other designers such as the **XAML Designer**.. Visual Studio displays a different yellow informational message when it runs as a DPI-unaware process that says **Visual Studio is running as a DPI-unaware process. WPF and XAML designers might not display correctly.** The informational bar also provides an option to **Restart Visual Studio as a DPI-aware process**.

::: moniker range="<=vs-2019"

> [!NOTE]
> - If you have undocked tool windows in Visual Studio when you select the option to restart as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, or if you have the **Save new projects when created** option deselected in **Tools** > **Options** > **Projects and Solutions**, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

::: moniker range=">=vs-2022"

> [!NOTE]
> - If you have undocked tool windows in Visual Studio when you select the option to restart as a DPI-unaware process, the position of the tool windows might change.
> - If you use the default Visual Basic profile, Visual Studio cannot reopen your project when it restarts as a DPI-unaware process. However, you can open the project by selecting it under **File** > **Recent Projects and Solutions**.

::: moniker-end

It's important to restart Visual Studio as a DPI-aware process when you're finished working in the **Windows Forms Designer**. If you close and reopen Visual Studio when it's running in DPI-unaware mode, it becomes DPI-aware again. You can also select the **Restart Visual Studio as a DPI-aware process** option in the informational bar.

### Add a registry entry

As option two, you can mark Visual Studio as DPI-unaware by modifying the registry. Open **Registry Editor** and add an entry to the **HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers** subkey:

**Entry**: Depending on whether you're using Visual Studio 2017, 2019, or 2022, use one of these values:

- C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe
- C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe
- C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe

> [!NOTE]
> If you're using the Professional or Enterprise edition of Visual Studio, replace **Community** with **Professional** or **Enterprise** in the entry. Also replace the drive letter as necessary.

**Type**: REG_SZ <br>
**Value**: DPIUNAWARE

Visual Studio remains in DPI-unaware mode until you remove the registry entry.

### Set your display scaling setting to 100%

A third option to resolving the issue is to set your display scaling setting to 100% in Windows 10, type **display settings** in the task bar search box, and then select **Change display settings**. In the **Settings** window, set **Change the size of text, apps, and other items** to **100%**.  However, setting your display scaling to 100% may be undesirable since it can make the user interface too small to be usable.

## Disable notifications

You can choose not to be notified of DPI scaling issues in Visual Studio. You might want to disable notifications if you aren't working in the designer, for example.

To disable notifications:
1. Choose **Tools** > **Options** to open the **Options** dialog.
2. In the **Options** dialog, choose **Windows Forms Designer** > **General**, and set **DPI Scaling Notifications** to **False**.

If you want to later reenable scaling notifications, set the property to **True**.

## Troubleshoot

If the DPI-awareness transition isn't working as expected in Visual Studio, check to see if you have the `dpiAwareness` value in the **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\devenv.exe** subkey in Registry Editor. Delete the value if it's present.
