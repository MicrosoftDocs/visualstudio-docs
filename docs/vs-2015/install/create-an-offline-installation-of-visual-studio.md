---
title: "Create an Offline Installation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
f1_keywords:
  - "offline installation"
  - "offline install"
  - "ISO"
ms.assetid: 85d65709-42be-449f-9663-914bf1045089
caps.latest.revision: 22
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Create an Offline Installation of Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [Create an offline installation of Visual Studio](/visualstudio/install/create-an-offline-installation-of-visual-studio) or [Create a network installation of Visual Studio](/visualstudio/install/create-a-network-installation-of-visual-studio).

This page describes how to install Visual Studio 2015 when you are not connected to the Internet. However, to perform a "disconnected" installation, you must first create an offline installation layout by using a machine that is connected to the Internet. Here's how to do so.

> [!IMPORTANT]
> If your offline machine is running Windows 7 SP1 or Windows Server 2008 R2, please see the special instructions in the [Troubleshooting an offline installation](#BKMK_tshoot) section  of this topic.  You must follow these instructions *before* you install Visual Studio 2015.

## <a name="BKMK_Offline"></a> Installing by creating an offline installation

#### To create an offline installation layout

1. Choose the edition of Visual Studio that you want to install from the  [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20Enterprise%202015) download page.

2. After you download the installer to a location on your file system, run "\<executable name> /layout".

     For example, run: `vs_enterprise.exe /layout D:\VisualStudio2015`

     By using the `/layout` switch, you can download almost all the installation packages, not just the ones that apply to the download machine. This approach gives you the files that you need to run this installer anywhere and it might be useful if you want to install components that weren't installed originally.

3. After you run this command, a dialog box will appear that allows you to change the folder where  you want the offline installation layout to reside.   Next, click the **Download** button.

     When the package download is successful, you should see a message that says **Setup Successful! All specified components have been acquired successfully.**

4. Locate the folder that you specified earlier. (For example, locate D:\VisualStudio2015.) This folder contains everything you need to copy to a shared location or install media.

    > [!CAUTION]
    > Currently, the Android SDK does not support an offline installation experience. If you install Android SDK Setup items on a computer that is not connected to the internet, the installation might fail. For more information, see the "Troubleshooting an offline installation" section in this topic.

5. Run the installation from the file location or from the install media.

## Updating an offline installation
 Microsoft has released several Updates for Visual Studio 2015. To update your Visual Studio installation, simply download  the edition you want from the from the  [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20Enterprise%202015) download page. Next, follow the steps outlined in this topic to create a new offline installation layout and then use it to update your copy of Visual Studio 2015.

## <a name="BKMK_tshoot"></a> Troubleshooting an offline installation
 When you install offline from your offline install cache, you might see warning messages about not being able to install some components and packages. The following table includes possible solutions for these scenarios.

| Component or Package | Solution |
|-|-|
| Dotfuscator and Analytics Community Edition 5.19.1 (for the Community, Professional, and Enterprise editions of Visual Studio, as installed on **Windows 7 SP1** and **Windows Server 2008 R2**) | If your offline machine is running **Windows 7 SP1** or **Windows Server 2008 R2**, you must perform the following steps before you install Visual Studio 2015:<br /><br /> 1.  Configure a file or web server to download the CTL files.<br /><br /> 2.    Redirect the Microsoft Automatic Update URL for a disconnected environment.<br /><br /> For more information, see the [Configure Trusted Roots and Disallowed Certificates](https://technet.microsoft.com/library/dn265983.aspx) page on the Microsoft TechNet site. |
| Android SDK Setup (API Level) | You must have an internet connection to install Android SDK (API Level) packages. If you are on a restricted network, you must allow access to the following URLs when you install Visual Studio:<br /><br /> -   http://dl.google.com:443<br />-   http://dl-ssl.google.com:443<br />-   https://dl-ssl.google.com/android/repository/*<br /> <br />For more information about how to resolve possible issues with proxy settings, see the [Visual Studio 2015 install failures (Android SDK Setup) behind a Proxy](https://blogs.msdn.microsoft.com/peterhauge/2016/09/22/visual-studio-2015-install-failures-android-sdk-setup-behind-a-proxy/) blog post. |
| Visual Studio Extensibility Item Templates<br /><br /> GitHub Extension for Visual Studio<br /><br /> PowerShell Tools for Visual Studio | If you do not have an internet connection when you install Visual Studio 2015, you can use a special offline feed to generate the offline installation layout. **Note:**  This special feed includes the most recent Updates to Visual Studio 2015. <br /><br /> To create the special offline feed, run the following command: /layout *Drive:*\VisualStudio2015 /overridefeeduri *URL-to-feed-xml*<br /><br /> For example, for an English-language special offline feed of Visual Studio 2015 Enterprise, run:<br /><br /> `vs_enterprise_ENU.exe /layout D:\VisualStudio2015 /overridefeeduri "http://go.microsoft.com/fwlink/?LinkID=785882&clcid0x409"`<br /><br /> For a complete list of URLs that you can use to create a special offline feed in the language of your choice, see the table below. |

 Use the following URLs to create a language-specific special offline feed, as described in the table above.

|       Language        |                            URL                            |
|-----------------------|-----------------------------------------------------------|
| Chinese (Simplified)  | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x804 |
| Chinese (Traditional) | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x404 |
|         Czech         | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x405 |
|        German         | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x407 |
|        English        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x409 |
|        Spanish        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0xC0A |
|        French         | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x40C |
|        Italian        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x410 |
|       Japanese        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x411 |
|        Korean         | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x412 |
|        Polish         | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x415 |
|      Portuguese       | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x416 |
|        Russian        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x419 |
|        Turkish        | http://go.microsoft.com/fwlink/?LinkID=785882&clcid=0x41F |

## See Also

- [Install Visual Studio](install-visual-studio-2015.md)