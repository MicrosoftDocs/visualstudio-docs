---
title: "Create an offline installer for Visual Studio 2017 | Microsoft Docs"
description: "Learn how to create an offline installer for of Visual Studio."
ms.custom: ""
ms.date: "03/07/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "offline installation [Visual Studio]"
  - "offline install [Visual Studio]"
  - "offline installer [Visual Studio]"
  - "ISO [Visual Studio]"
ms.assetid: 7bd7e724-7bfd-43f1-9935-981919be5a00
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Create an offline installer for Visual Studio 2017
We understand that a lot of customers want an offline installer for [Visual Studio 2017](https://go.microsoft.com/fwlink/?linkid=844067). Even though we don't offer an ISO image, it's easy to create a folder that you can use to install when offline.

Here's how.

## Download the setup file you want
**[Download](https://www.visualstudio.com/downloads?utm_source=mscom&utm_campaign=msdocs)** the edition of Visual Studio that you want. Make sure to click **Save**, and then click **Open folder**.

Your setup file&mdash;or to be more specific, a bootstrapper file&mdash;will match one of the following.

|Edition | File|  
|-------------|-----------------------|  
|Visual Studio Enterprise |**vs_enterprise.exe**|  
|Visual Studio Professional |**vs_professional.exe**|  
|Visual Studio Community |**vs_community.exe**|

## Create an offline installation folder
To create an offline installation with all languages and all features, use one of the commands from the following examples.

(Make sure that you run the command from your Download directory. Typically, that's `C:\Users\<username>\Downloads` on a computer that is running Windows 10).

- For Visual Studio Enterprise, run: <br>  ```vs_enterprise.exe --layout c:\vs2017offline```
- For Visual Studio Professional, run: <br> ```vs_professional.exe --layout c:\vs2017offline```
- For Visual Studio Community, run: <br> ```vs_community.exe --layout c:\vs2017offline```

For more examples, see the [How to customize your offline installer](#how-to-customize-your-offline- installer) section on this page.

## Install from the offline installation folder
Run your offline installation now or later; the choice is yours to make. But when you do, follow these steps.

  1. Install the certificates (They are in the Certificates folder, which is in your Layout folder. Simply right-click each one to install it.)

  2. Run the installation file. For example, run: <br> ```c:\vs2017offline\vs_enterprise.exe```

## Additional tips for offline installers
It's easy to customize or update your offline installer; we'll show you how. And if something goes wrong with your offline installer, we've got troubleshooting and support information for you, too.

### How to customize your offline installer
There are many options you can use to customize your offline installer. Here are a few examples of how to customize it by [language locale](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).

 - To download all workloads and components for only one language, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US```
 - To download all workloads and components for multiple languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US de-DE ja-JP```
 - To download one workload for all languages, run <br> ```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure ```
 - To download two workloads and one optional component for three languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure Microsoft.VisualStudio.Workload.ManagedDesktop Component.GitHub.VisualStudio --lang en-US de-DE ja-JP ```
To learn more about the options you can use to customize your installation, see our [Use command-line parameters to install Visual Studio 2017 ](use-command-line-parameters-to-install-visual-studio.md) page.


### How to update an offline installer
You might want to update your offline installer at a later date. Here's how.
* To update a Visual Studio instance that you installed from an offline installation folder, run the Visual Studio Installer, and then click **Update**.
* To refresh your offline installation folder so that it includes the latest updates, run the ```--layout``` command again. Make sure to point to the same folder that you used before; this way, only those components that have been updated since you last ran ```--layout``` will be downloaded.


If you want to update your offline installation, run the `--layout` command again. Make sure to point to the same folder that you used before; this way, only those components that have been updated since you last ran `--layout` will be downloaded.

### How to troubleshoot an offline installer
Sometimes, things go wrong. Here is a table of known issues and some workarounds that might help.

| Issue       | Item                   | Solution |
| ----------- | ---------------------- | -------- |
| You receive a warning message about not being able to install some components and packages.  | Android SDK Setup (API Level) | If you want to include Android SDK (API Level) packages, you must have an internet connection when you create your offline installer. If you are on a restricted network, you must allow access to the following URLs: <br><br> - http://dl.google.com:443 <br> - http://dl-ssl.google.com:443 <br>  - https://dl-ssl.google.com/android/repository/*<br><br>For more information about how to resolve possible issues with proxy settings, see the [Visual Studio install failures (Android SDK Setup) behind a Proxy](https://blogs.msdn.microsoft.com/peterhauge/2016/09/22/visual-studio-2015-install-failures-android-sdk-setup-behind-a-proxy/) blog post.  |  
| Users do not have access to files. | permissions (ACLs) | Make sure that you adjust the permissions (ACLs) so that they grant Read access to other users  *before* you share the offline install. |
| New workloads, components, or languages fail to install.  | `--layout`  | Make sure you have internet access if you install from a partial layout and select workloads, components, or languages that are not available in the earlier layout. |

### How to get support for your offline installer
If you experience a problem with your offline installation, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool. When you use this tool, you can send us the telemetry and logs we need to help us diagnose and fix the problem.

We have other support options available, too. For a list of those, see our [Talk to us](../ide/how-to-report-a-problem-with-visual-studio-2017.md) page.


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
