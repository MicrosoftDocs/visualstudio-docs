---
title: "Troubleshoot installation or upgrade issues"
description: "Sometimes, things can go wrong. If your Visual Studio installation or upgrade fails, this page can help."
ms.date: 09/13/2019
ms.custom: "seodec18"
ms.topic: troubleshooting
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 556EDD3F-E365-43EE-B3DD-03AA4353F75B
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Troubleshoot Visual Studio installation and upgrade issues

> [!IMPORTANT]
> Having a problem installing? We can help. We offer a [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option.

This troubleshooting guide includes step-by-step instructions that should resolve most installation issues.

## Online installations

The following steps are optimized for a typical online installation. For an issue that affects an offline installation, please see [How to troubleshoot an offline installation](#offline-installations).

### Step 1 - Check whether this problem is a known issue

::: moniker range="vs-2017"

There are some known issues with the Visual Studio Installer that Microsoft is working on fixing. To see if there's a workaround for your problem, check the [Known Issues section of our release notes](/visualstudio/releasenotes/vs2017-relnotes#-known-issues).

::: moniker-end

::: moniker range="vs-2019"

There are some known issues with the Visual Studio Installer that Microsoft is working on fixing. To see if there's a workaround for your problem, check the [Known Issues section of our release notes](/visualstudio/releases/2019/release-notes#-known-issues).

::: moniker-end

### Step 2 - Check with the developer community

Search on your error message with the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/spaces/8/index.html). Other members of the community might have documented a solution to your problem.

### Step 3 - Delete the Visual Studio Installer directory to fix upgrade problems

The Visual Studio Installer bootstrapper is a minimal light-weight executable that installs the rest of the Visual Studio Installer. Deleting Visual Studio Installer files and then rerunning the bootstrapper might solve some update failures.

> [!NOTE]
> Performing the following actions reinstalls the Visual Studio Installer files and resets the installation metadata.

::: moniker range="vs-2017"

1. Close the Visual Studio Installer.
2. Delete the Visual Studio Installer directory. Typically, the directory is `C:\Program Files (x86)\Microsoft Visual Studio\Installer`.
3. Run the Visual Studio Installer bootstrapper. You might find the bootstrapper in your Downloads folder with a file name that follows a `vs_[Visual Studio edition]__*.exe` pattern. If you don't find that application, you can download the bootstrapper by going to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page and clicking **Download** for your edition of Visual Studio. Then, run the executable to reset your installation metadata.
4. Try to install or update Visual Studio again. If the Installer continues to fail, go to the next step.

::: moniker-end

::: moniker range="vs-2019"

1. Close the Visual Studio Installer.
2. Delete the Visual Studio Installer directory. Typically, the directory is `C:\Program Files (x86)\Microsoft Visual Studio\Installer`.
3. Run the Visual Studio Installer bootstrapper. You might find the bootstrapper in your Downloads folder with a file name that follows a `vs_[Visual Studio edition]__*.exe` pattern. If you don't find that application, you can download the bootstrapper by going to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page and clicking **Download** for your edition of Visual Studio. Then, run the executable to reset your installation metadata.
4. Try to install or update Visual Studio again. If the Installer continues to fail, go to the next step.

::: moniker-end

### Step 4 - Report a problem

In some situations, such as those related to corrupted files, the problems might have to be looked at on a case-by-case basis. To help us help you, please do the following:

::: moniker range="vs-2017"

1. Collect your setup logs. See [How to get the Visual Studio installation logs](#installation-logs) for details.
2. Open the Visual Studio Installer, and then click **Report a problem** to open the Visual Studio Feedback tool.
![You can tab to the Provide Feedback button to open the feedback tool](media/report-a-problem.png)
3. Give your problem report a title, and provide relevant details. Click **Next** to go to the **Attachments** section, and then attach the generated log file (typically, the file is at `%TEMP%\vslogs.zip`).
4. Click **Next** to review your problem report, and then click **Submit**.

::: moniker-end

::: moniker range="vs-2019"

1. Collect your setup logs. See [How to get the Visual Studio installation logs](#installation-logs) for details.
2. Open the Visual Studio Installer, and then click **Report a problem** to open the Visual Studio Feedback tool.
![You can tab to the Provide Feedback button to open the feedback tool](media/vs-2019/vs-installer-report-problem.png)
3. Give your problem report a title, and provide relevant details. Click **Next** to go to the **Attachments** section, and then attach the generated log file (typically, the file is at `%TEMP%\vslogs.zip`).
4. Click **Next** to review your problem report, and then click **Submit**.

::: moniker-end

### Step 5 - Run InstallCleanup.exe to remove installation files

As a last resort, you can [remove Visual Studio](remove-visual-studio.md) to remove all installation files and product information.

1. Follow the instructions in [Remove Visual Studio](remove-visual-studio.md).
2. Rerun the bootstrapper that's described in [Step 3 - Delete the Visual Studio Installer directory to fix upgrade problems](#step-3---delete-the-visual-studio-installer-directory-to-fix-upgrade-problems).
3. Try to install or update Visual Studio again.

### Step 6 - Contact us (optional)

If none of the previous steps help you successfully install or upgrade Visual Studio, contact us by using our [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) support option (English only) for further assistance.

## Offline installations

Here is a table of known issues and some workarounds that might help you when you create an [offline installation](create-an-offline-installation-of-visual-studio.md) and then install from a local layout.

| Issue       | Item                   | Solution |
| ----------- | ---------------------- | -------- |
| Users do not have access to files. | permissions (ACLs) | Make sure that you adjust the permissions (ACLs) so that they grant Read access to other users  *before* you share the offline install. |
| New workloads, components, or languages fail to install.  | `--layout`  | Make sure that you have internet access if you install from a partial layout and select workloads, components, or languages that were not downloaded previously in that partial layout. |

For more information about how to resolve issues with a [network installation](create-a-network-installation-of-visual-studio.md), see [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md).

## Installation logs

Setup logs are needed to troubleshoot most installation issues. When you submit an issue by using [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) in the Visual Studio Installer, these logs are automatically included in your report.

If you contact Microsoft Support, you might need to provide these setup logs by using the [Microsoft Visual Studio and .NET Framework Log Collection Tool](https://aka.ms/vscollect). The log collection tool collects setup logs from all components installed by Visual Studio, including .NET Framework, Windows SDK, and SQL Server. It also collects computer information, a Windows Installer inventory, and Windows event log information for Visual Studio Installer, Windows Installer, and System Restore.

To collect the logs:

1. [Download the tool](https://aka.ms/vscollect).
2. Open an administrative command prompt.
3. Run `Collect.exe` from the directory where you saved the tool.
4. Find the resulting `vslogs.zip` file in your `%TEMP%` directory, for example, `C:\Users\YourName\AppData\Local\Temp\vslogs.zip`.

> [!NOTE]
> The tool must be run under the same user account that the failed installation was run under. If you are running the tool from a different user account, set the `–user:<name>` option to specify the user account under which the failed installation was run. Run `Collect.exe -?` from an administrator command prompt for additional options and usage information.

## Live help

If the solutions listed in this troubleshooting guide do not help you to successfully install or upgrade Visual Studio, use our [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) support option (English only) for further assistance.

## See also

* [Remove Visual Studio](remove-visual-studio.md)
* [Install and use Visual Studio and Azure Services behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
