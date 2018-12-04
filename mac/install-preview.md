---
title: "Install a preview release"
description: "Instructions for updating Visual Studio for Mac and accessing preview releases, including the Visual Studio 2019 for Mac previews."
author: conceptdev
ms.author: crdun
ms.date: 11/03/2018
ms.topic: article
ms.technology: vs-ide-install
ms.assetid: 0E1EF257-9DE4-4653-9DF4-805CE007A1A1
---
# Install a preview release

::: moniker range="vsmac-2019"

> [!TIP]
> Visual Studio 2019 for Mac preview is now available. For the first time, it is available to install side-by-side with the latest stable release of Visual Studio for Mac.

## Requirements for the Visual Studio 2019 for Mac preview

* A Mac with macOS High Sierra 10.13 or above.

To build Xamarin apps for iOS or macOS, you'll also need:

* Xcode 10.0 or above. The latest stable version is usually recommended.
* An Apple ID. If you don't have an Apple ID already you can create a new one at https://appleid.apple.com. It's necessary to have an Apple ID for installing and signing into Xcode.

## Installing the preview

1. Download the preview installer from the [Visual Studio for Mac preview page](https://aka.ms/vs4mac-preview).
2. Once the download is complete, click the **VisualStudioforMacPreviewInstaller.dmg** to mount the installer, then run it by double-clicking the arrow logo:

    [![Click the large arrow to begin installation](media/install-preview-installer-sml.png)](media/install-preview-installer.png#lightbox)

3. You may be presented with a warning about the application being downloaded from the Internet. Click **Open**.
4. Wait while the installer checks your system:

    [![The installer checks your system for installed components](media/install-preview-checking-sml.png)](media/install-preview-checking.png#lightbox)

5. An alert will appear asking you to acknowledge the privacy and license terms. Follow the links to read them, then press **Continue** if you agree:

    [![Follow the links to the privacy and terms, then continue if you agree](media/install-preview-privacy-sml.png)](media/install-preview-privacy.png#lightbox)

6. The list of available workloads is displayed. Select the ones you wish to use:

    [![Choose which optional workload features you would like to install](media/install-preview-selection-sml.png)](media/install-preview-selection.png#lightbox)

    If your current Visual Studio for Mac 2017 is older than version 7.7, you will be asked to approve an upgrade to the latest stable version (which is required to support side-by-side installation). Press **Continue** to approve the upgrade:

    ![Upgrading the stable version to 7.7 is required](media/install-preview-older-upgrade.png)

7. After you have made your selections, press the **Install** button.
8. The installer will display progress as it downloads and installs Visual Studio for Mac and the selected workloads. You might be prompted to enter your password to grant the privileges necessary for installation.
9. Use the **Visual Studio (Preview)** anytime you want to test the preview version, or switch back to the latest stable Visual Studio for your production work. The two icons are shown here:

    ![Stable and preview icon differences](media/install-preview-icons-sml.png)

If you have network trouble while installing in a corporate environment, review the [installing behind a firewall or proxy](https://docs.microsoft.com/visualstudio/mac/installation#install-visual-studio-for-mac-behind-a-firewall-or-proxy-server) instructions.

Learn more about the changes in the [release notes](https://docs.microsoft.com/visualstudio/releasenotes/vs2019-mac-preview-relnotes).

::: moniker-end
::: moniker range="vsmac-2017"

## Install an update for Visual Studio 2017 for Mac

Before a new version of Visual Studio for Mac is officially released, it's available as a preview. The preview release gives you a chance to try out new features and get the latest bug fixes before they are fully incorporated into the product.

Preview releases to Visual Studio for Mac are distributed as an update, rather than through a separate download. Visual Studio for Mac has three updater channels, as described in the [update](update.md) article: Stable, Beta, and Alpha.

Most preview releases will be available through both the **Beta** and **Alpha** channels, but always check the [Preview Release Notes](/visualstudio/releasenotes/vs2017-mac-preview-relnotes) for the most accurate information.

To install the preview of Visual Studio for Mac, use the following steps:

1. Go to **Visual Studio > Check for Updates**.
2. In the Update channel combo box, select **Beta**.
3. Select the **Switch channel** button to switch to the selected channel and start downloading any new updates.
4. Select the **Restart and Install Updates** button to start installing the updates.

For more information on updating in Visual Studio for Mac, see the [update](update.md) article.

::: moniker-end