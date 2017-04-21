---
title: "Create a network-based installation of Visual Studio | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "04/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 4CABFD20-962E-482C-8A76-E4012052F701
author: "timsneath"
ms.author: "tims"
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

# Create a network installation of Visual Studio 2017

## Download the setup file you want
**[Download](https://www.visualstudio.com/downloads?utm_source=mscom&utm_campaign=msdocs)** the edition of Visual Studio that you want. Make sure to click **Save**, and then click **Open folder**.

Your setup file&mdash;or to be more specific, a bootstrapper file&mdash;will match one of the following.

|Edition | File|  
|-------------|-----------------------|  
|Visual Studio Enterprise |**vs_enterprise.exe**|  
|Visual Studio Professional |**vs_professional.exe**|  
|Visual Studio Community |**vs_community.exe**|

Other supported bootstrappers include vs_buildtools.exe, vs_feedbackclient.exe, vs_teamexplorer.exe, vs_testagent.exe, vs_testcontroller.exe, and vs_testprofessional.exe.

## Create an offline installation folder
To create an offline installation with all languages and all features, use one of the commands from the following examples.

(Make sure that you run the command from your Download directory. Typically, that's `C:\Users\<username>\Downloads` on a computer that is running Windows 10).

- For Visual Studio Enterprise, run: <br>  ```vs_enterprise.exe --layout c:\vs2017offline```
- For Visual Studio Professional, run: <br> ```vs_professional.exe --layout c:\vs2017offline```
- For Visual Studio Community, run: <br> ```vs_community.exe --layout c:\vs2017offline```

For more examples, see the [How to customize your offline installer](#how-to-customize-your-offline-installer) section on this page.

## Modify the response.json file
You can modify the response.json to set default values that will be used when setup is run.  For example, you can configure the response.json to select a specific set of Workloads selected automatically.
See [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md) for details.

## Copy the layout to a network share
Host the layout on a network share so it can be run from other machines.  
* Example:<br>
```xcopy /e c:\vs2017offline \\MyServer\products\VS2017```

## Install from the offline installation folder
Administrators may run setup to push Visual Studio onto client machines.  Or, users (with administrator rights) can run setup from the share to install Visual Studio on their machine.

  1. If you are not connected to the internet, you will need to  Install the certificates (They are in the Certificates folder, which is in your Layout folder. Simply right-click each one to install it.)  See [Install Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md) for more details.

  2. Run the installation file. Examples: 
  * Users can install by running: <br>```\\MyServer\products\VS2017\vs_enterprise.exe```
  * Administrators can install in an unattend mode by running: <br>```\\MyServer\products\VS2017\vs_enterprise.exe --quiet --wait --norestart```

## Additional tips for offline installers
It's easy to customize or update your offline installer; we'll show you how. And if something goes wrong with your offline installer, we've got troubleshooting and support information for you, too.

### How to customize your offline installer
There are several options you can use to customize your offline installer. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md).  Use the following options to create a partial layout filtered to your specifications.

 - ```--add``` to specify [Workload or Component Ids](workload-and-component-ids.md).  If --add is used, only those workloads and components specified with --add will be downloaded.  If --add is not used, all workload and components will be downloaded.
 - ```--includeRecommended``` to include all the recommended  components for the specified workload IDs
 - ```--includeOptional``` to include all the recommended  and optional components for the specified workload IDs.
 - ```--lang``` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).
 
Here are a few examples of how to create a custom partial layout.

 - To download all workloads and components for only one language, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US```
 - To download all workloads and components for multiple languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US de-DE ja-JP```
 - To download one workload for all languages, run <br> ```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure ```
 - To download two workloads and one optional component for three languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --lang en-US de-DE ja-JP ```
 - To download two workloads and all of their recommended components, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended ```
 - To download two workloads and all of their recommended and optional components, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeOptional ```
 
### How to update an offline installer
You might want to update your offline installer at a later date. Here's how.
* To refresh your offline installation folder so that it includes the latest updates, run the ```--layout``` command again. Make sure to point to the same folder that you used before; this way, only those components that have been updated since you last ran ```--layout``` will be downloaded.  It is recommended that you update a private copy of the layoute (e.g. c:\vs2017offline) and after all of the updated content is downloaded, copy it to your share (e.g. \\MyServer\products\VS2017).  If you don't do this, there is a greater chance that any users running setup wile the layout is being updated may not be able to get all of the content from the layout since it is not completely updated.
* To update a Visual Studio instance that you installed from an offline installation folder, run the Visual Studio Installer, and then click **Update**.  For details on how to controll when update notifications are presented to users, see [Install Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md).

### How to create a layout for a previous release of VS 2017
The VS 2017 bootstrappers available on http://www.visualstudio.com will download and install the latest VS 2017 release available whenever they are run. If you download a VS bootstrapper today and run it 6 months from now, it will install the VS 2017 release that is available at that later time. If you create a layout, installing VS from that layout will install the specific version of VS that exists in the layout. Even though a newer version may exist online, you will get the version of VS that is in the layout.

If you need to create a layout for an older version of VS 2017 (e.g. 15.1 after 15.2 is released) and you have a Visual Studio subscription, https://my.visualstudio.com has “Fixed” versions of VS 2017 bootstrappers. These will download a specific build of VS 2017.
For example, if you want 15.1
Go to http://my.visualstudio.com (login to your subscription).
Go to “downloads”, search for “Visual Studio 15.1”.
Download a product such as “Visual Studio Enterprise 2017 (version 15.1)” and it will give you a “fixed” bootstrapper. Running it will download that specific 15.1 version of VS 2017.

### How to update an offline installer
You might want to update your offline installer at a later date. Here's how.
* To refresh your offline installation folder so that it includes the latest updates, run the ```--layout``` command again. Make sure to point to the same folder that you used before; this way, only those components that have been updated since you last ran ```--layout``` will be downloaded.  It is recommended that you update a private copy of the layoute (e.g. c:\vs2017offline) and after all of the updated content is downloaded, copy it to your share (e.g. \\MyServer\products\VS2017).  If you don't do this, there is a greater chance that any users running setup wile the layout is being updated may not be able to get all of the content from the layout since it is not completely updated.
* To update a Visual Studio instance that you installed from an offline installation folder, run the Visual Studio Installer, and then click **Update**.  For details on how to controll when update notifications are presented to users, see [Install Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md).

### How to troubleshoot an offline installer
Sometimes, things go wrong. Here is a table of known issues and some workarounds that might help.

| Issue       | Item                   | Solution |
| ----------- | ---------------------- | -------- |
| You receive an error message from the Visual Studio Installer that says, "Setup completed with warning", and then the Windows Emulator fails to install. | Windows 10 Emulator | Open your offline installation folder for Visual Studio, navigate to the subfolder "Win10_Emulator_10.0.15063,version=10.0.15063.12,chip=x64", and then run EmulatorSetup.exe to install the Windows Emulator. |
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
