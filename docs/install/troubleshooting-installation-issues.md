---
title: "Troubleshooting installation issues | Microsoft Docs"
description: "Sometimes, things can go wrong. If your Visual Studio installation or upgrade fails, this page can help."
ms.date: "11/21/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 556EDD3F-E365-43EE-B3DD-03AA4353F75B
author: "timsneath"
ms.author: "tglee"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Troubleshooting Visual Studio 2017 installation and upgrade issues

## Symptoms
When you try to install or update Visual Studio 2017, the operation fails.

## Workaround
To work around this issue, follow these steps.

### Step 1 - Check whether this problem is a known issue
There are some known issues with the Visual Studio Installer that Microsoft is working on fixing. To see if there's a workaround for your problem, check the [Known Issues section of our release notes](https://www.visualstudio.com/news/releasenotes/vs2017-relnotes#known-issues).

### Step 2 - Check with the developer community
Search on your error message with the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/spaces/8/index.html). Other members of the community may have documented a solution to your problem.

### Step 3 - Delete the Visual Studio Installer directory to fix upgrade problems
The Visual Studio Installer bootstrapper is a minimal light-weight executable that installs the rest of the Visual Studio Installer. Deleting Visual Studio Installer files and then rerunning the bootstrapper might solve some update failures.

>[!NOTE]
Performing the following actions reinstalls the Visual Studio Installer files and resets the installation metadata.

1. Close the Visual Studio Installer.
2. Delete the Visual Studio Installer directory. Typically, the directory is `C:\Program Files (x86)\Microsoft Visual Studio\Installer`.
3. Run the Visual Studio Installer bootstrapper. You may find the bootstrapper in your Downloads folder with a file name that follows a `vs_[Visual Studio edition]__*.exe` pattern. If you don't find that application, you can download the bootstrapper by going to the [Visual Studio downloads](https://www.visualstudio.com/downloads/) page and clicking **Download** for your edition of Visual Studio. Run the executable to reset your installation metadata.
4. Try to install or update Visual Studio again. If the Installer continues to fail, go to the next step.

### Step 4 - Report a problem
In some situations, such as those related to corrupted files, the problems may have to be looked at on a case-by-case basis:

1. Collect your setup logs. See [How to get the Visual Studio installation logs](#how-to-get-the-visual-studio-installation-logs) for details.
2. Open the Visual Studio Installer, and then click **Report a problem** to open the Visual Studio Feedback tool.
![You can tab to the Provide Feedback button to open the feedback tool](media/report-a-problem.png)
3. Give your problem report a title, and provide relevant details. Click **Next** to go to the **Attachments** section, and then attach the generated log file (typically, the file is at `%TEMP%\vslogs.zip`).
4. Click **Next** to review your problem report, and then click **Submit**.

### Step 5 - Run InstallCleanup.exe to remove installation files
As a last resort, you can [remove Visual Studio](remove-visual-studio.md) to remove all installation files and product information.

1. Follow the instructions in [Remove Visual Studio](remove-visual-studio.md).
2. Rerun the bootstrapper that's described in [Step 3 - Delete the Visual Studio Installer directory to fix upgrade problems](#step-3---delete-the-visual-studio-installer-directory-to-fix-upgrade-problems).
3. Try to install or update Visual Studio again.

### Step 6 - Contact us (optional)
If none of the other steps allow you to successfully install, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

## How to troubleshoot an offline installer
Here is a table of known issues and some workarounds when installing from a local layout that might help.

| Issue       | Item                   | Solution |
| ----------- | ---------------------- | -------- |
| Users do not have access to files. | permissions (ACLs) | Make sure that you adjust the permissions (ACLs) so that they grant Read access to other users  *before* you share the offline install. |
| New workloads, components, or languages fail to install.  | `--layout`  | Make sure that you have internet access if you install from a partial layout and select workloads, components, or languages that were not downloaded previously in that partial layout. |

## How to get the Visual Studio installation logs
Setup logs are needed to troubleshoot most installation issues. When you submit an issue by using [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) in the Visual Studio Installer, these logs are automatically included in your report.

If you contact Microsoft Support, you may need to provide these setup logs by using the [Microsoft Visual Studio and .NET Framework Log Collection Tool](https://aka.ms/vscollect). The log collection tool collects setup logs from all components installed by Visual Studio 2017, including .NET Framework, Windows SDK, and SQL Server. It also collects computer information, a Windows Installer inventory, and Windows event log information for Visual Studio Installer, Windows Installer, and System Restore.

To collect the logs:

1. [Download the tool](https://aka.ms/vscollect).
2. Open an administrative command prompt.
3. Run `Collect.exe` from the directory where you saved the tool.
4. Find the resulting `vslogs.zip` file in your `%TEMP%` directory, for example, `C:\Users\YourName\AppData\Local\Temp\vslogs.zip`.

> [!NOTE]
> The tool must be run under the same user account that the failed installation was run under. If you are running the tool from a different user account, set the `–user:<name>` option to specify the user account under which the failed installation was run. Run `Collect.exe -?` from an administrator command prompt for additional options and usage information.

## More support options

If none of the other steps allow you to successfully install, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This requires a [GitHub](https://github.com/) account.)

## See also
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Remove Visual Studio 2017](remove-visual-studio.md)
