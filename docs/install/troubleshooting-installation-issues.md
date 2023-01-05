---
title: Troubleshoot installation or upgrade issues
description: Sometimes, things can go wrong. If your Visual Studio installation or upgrade fails, this page can help.
ms.date: 1/4/2023
ms.custom: vs-acquisition
ms.topic: troubleshooting
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 556EDD3F-E365-43EE-B3DD-03AA4353F75B
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Troubleshoot Visual Studio installation and upgrade issues

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

> [!TIP]
> Having a problem installing? We can help. We offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option.

This troubleshooting guide includes step-by-step instructions that should resolve most installation issues.

## Online installations

The following steps apply to a typical online installation. For a network (layout) or offline installation, see [How to troubleshoot an offline installation](#network-layout-or-offline-installations).

### Step 1 - Check whether the problem is a known issue

::: moniker range="vs-2019"

There are some known issues with the Visual Studio Installer that Microsoft is working on fixing. To see if there's a workaround for your problem, check the [Known Issues section of our release notes](/visualstudio/releases/2019/release-notes#-known-issues).

::: moniker-end

::: moniker range=">=vs-2022"

There are some known issues with the Visual Studio Installer that Microsoft is working on fixing. Check if your problem is already solved, or find workarounds, in the [Known Issues section of our release notes](/visualstudio/releases/2022/release-notes#-known-issues).

::: moniker-end

### Step 2 - Try repairing Visual Studio

Repair fixes many common update issues. For more about when and how to repair Visual Studio, see [Repair Visual Studio](repair-visual-studio.md).

### Step 3 - Check with the developer community

Search for your error message in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/search?space=8). Other members of the community might have found a solution or workaround to your problem.

### Step 4 - Delete the Visual Studio Installer folder to fix upgrade problems

The Visual Studio bootstrapper is a light-weight executable that initiates the install of the Visual Studio Installer and then the Visual Studio product. Deleting the Visual Studio Installer files and then rerunning the bootstrapper solves some update failures.

> [!NOTE]
> Performing the following actions reinstalls the Visual Studio Installer files and resets the installation metadata.

::: moniker range="<vs-2022"

1. Close the Visual Studio Installer.
1. Delete the Visual Studio Installer installation directory. Typically, the directory is `C:\Program Files (x86)\Microsoft Visual Studio\Installer`.
1. Run the Visual Studio bootstrapper. You might find the bootstrapper in your Downloads folder with a file name that follows a `vs_[Visual Studio edition]__*.exe` pattern. If you don't find that application, you can download the bootstrapper by going to the [Visual Studio older downloads page](https://visualstudio.microsoft.com/vs/older-downloads) and clicking **Download** for your edition of Visual Studio. Then, run the executable to reset your installation metadata.
1. Try to install or update Visual Studio again. If the Installer continues to fail, proceed to the [Report a problem](#step-5---report-a-problem) step.

::: moniker-end

::: moniker range="=vs-2022"

1. Close the Visual Studio Installer.
1. Delete the Visual Studio Installer folder. Typically, the folder path is `C:\Program Files (x86)\Microsoft Visual Studio\Installer`.
1. Run the Visual Studio Installer bootstrapper. You might find the bootstrapper in your **Downloads** folder with a file name that matches a `vs_[Visual Studio edition]__*.exe` pattern. Or, you can download the bootstrapper for your edition of Visual Studio from the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page. Then, run the executable to reset your installation metadata.
1. Try to install or update Visual Studio again. If the Visual Studio Installer continues to fail, proceed to the [Report a problem](#step-5---report-a-problem) step.

::: moniker-end

### Step 5 - Report a problem

In some situations, such as when there are corrupted files, issues might require case-by-case troubleshooting. To help us help you, follow these steps:

::: moniker range="vs-2019"

1. Collect your setup logs. See [How to get the Visual Studio installation logs](#installation-logs) for details.
1. Open the Visual Studio Installer, and then click **Report a problem** to open the Visual Studio Feedback tool.
![Screenshot showing the Provide feedback button in the Visual Studio Installer.](media/vs-2019/vs-installer-report-problem.png)
1. Give your problem report a title, and provide relevant details. Click **Next** to go to the **Attachments** section, and then attach the generated log file (typically, the file is at `%TEMP%\vslogs.zip`).
1. Click **Next** to review your problem report, and then click **Submit**.

::: moniker-end

::: moniker range=">=vs-2022"

1. Collect your setup logs. See [How to get the Visual Studio installation logs](#installation-logs) for details.
1. Open the Visual Studio Installer, and then choose **Report a problem** to open the Visual Studio Feedback tool.
![Screenshot showing the Provide feedback button in the Visual Studio Installer.](media/vs-2022/vs-installer-report-problem.png)
1. Give your problem report a title, and provide the relevant details. The most recent setup log for the Visual Studio Installer is automatically added to the **Additional attachments** section of your problem report.
1. Choose **Submit**.

::: moniker-end

### Step 6 - Remove Visual Studio installation files

As a last resort, you can remove all Visual Studio installation files and product information:

1. Follow the steps in this article: [Remove Visual Studio](uninstall-visual-studio.md#remove) page.
1. Rerun the Visual Studio Installer bootstrapper. You might find the bootstrapper in your **Downloads** folder with a file name that matches a `vs_[Visual Studio edition]__*.exe` pattern. Or, you can download the bootstrapper for your edition of Visual Studio from the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page.
1. Try to reinstall Visual Studio.

::: moniker range=">=vs-2022"

### Step 7 - Rollback

If none of the previous steps help you successfully upgrade Visual Studio, you can try to rollback to your previously installed version. Learn more about the [rollback feature in Visual Studio](https://aka.ms/vs/rollback) before trying to rollback.

> [!NOTE]
> Starting with Visual Studio 2022 version 17.4, you'll be able to rollback to your previously installed version if:
> - you haven't installed from a layout.
> - your original version was on the Current channel version 17.1.7 or higher, or on the 17.0 Fall 2021 LTSC channel 17.0.10 or higher.  


You can rollback to your previously installed version by using the Visual Studio Installer or by using the command line.

#### Rollback using the Visual Studio Installer

1. Launch the **Visual Studio Installer** on your computer.
1. In the installer, look for the edition of Visual Studio that you installed. Next, choose **More**, and then choose **Rollback to previous version**.

    :::image type="content" source="media/vs-2022/rollback-from-previous-version.png" alt-text="Screenshot of the Rollback to previous version option.":::

1. Select **OK** to confirm your choice.

> [!IMPORTANT]
> Rollback may be disabled or your rollback attempt may be undone if you're in an organization that has security compliance or software updating requirements. Contact your IT Administrator for further details. 

### Step 8 - Contact us (optional)

If none of the previous steps help you successfully install or upgrade Visual Studio, contact us by using our [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) support option (English only) for further assistance.

::: moniker-end

::: moniker range="vs-2019"

### Step 7 - Contact us (optional)

If none of the previous steps help you successfully install or upgrade Visual Studio, contact us by using our [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) support option (English only) for further assistance.

::: moniker-end

## Network layout or offline installations

To resolve issues with a [network installation](create-a-network-installation-of-visual-studio.md), see [Error Codes](./create-a-network-installation-of-visual-studio.md#error-codes) or [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md).

## Administrator Updates

Administrator updates may not be applied correctly due to a variety of situations. Refer to the [Administrator updates troubleshooting error codes](/visualstudio/install/applying-administrator-updates#verification-reports-and-troubleshooting-error-codes) for further information.

## Installation logs

Setup logs help us troubleshoot most installation issues. When you submit an issue by using [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) in the Visual Studio Installer, the most recent setup log for the Visual Studio Installer is automatically added to your report.

If you contact Microsoft Support, you might be asked to collect setup logs by using the [Microsoft Visual Studio and .NET Framework log collection tool](https://aka.ms/vscollect). The log collection tool collects setup logs from all components installed by Visual Studio, including .NET Framework, Windows SDK, and SQL Server. It also collects computer information, a Windows Installer inventory, and Windows event log information for the Visual Studio Installer, Windows Installer, and System Restore.

To collect the logs:

1. [Download the tool](https://aka.ms/vscollect).
1. Open an administrative command prompt.
1. Run `Collect.exe` in the folder where you saved the tool.
1. The tool generates a `vslogs.zip` file in your `%TEMP%` folder, typically at `C:\Users\YourName\AppData\Local\Temp\vslogs.zip`.

> [!NOTE]
> The tool must be run under the same user account that the failed installation was run under. If you are running the tool from a different user account, set the `–user:<name>` option to specify the user account under which the failed installation was run. Run `Collect.exe -?` from an administrator command prompt for additional options and usage information.

## Problems installing WebView2

WebView2 is a component that is required by Visual Studio, but installation of this component can be blocked by your organization’s Group Policies. Blocking the installation of WebView2 will prevent Visual Studio from being installed. 

Two policies control the ability to install WebView2: [Microsoft Edge 'Install (WebView)'](/deployedge/microsoft-edge-update-policies#install-webview) and [Microsoft Edge 'InstallDefault'](/deployedge/microsoft-edge-update-policies#installdefault).

•	If the Microsoft Edge 'Install (WebView)' policy is configured, it will determine whether WebView2 can be installed.
•	If the Microsoft Edge 'Install (WebView)' policy is not configured, the Microsoft Edge 'InstallDefault' policy will determine whether WebView2 can be installed.

> [!NOTE]
> If neither policy is configured, WebView2 installation is allowed by your organization.
