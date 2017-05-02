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

If you are not connected to the internet, you will need to Install the certificates (They are in the Certificates folder, which is in your Layout folder. Simply right-click each one to install it.)  See [Special considerations for installing Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md) for more details.

  1. Run the installation file. Examples: 
  * Users can install by running: <br>```\\MyServer\products\VS2017\vs_enterprise.exe```
  * Administrators can install in an unattended mode by running: <br>```\\MyServer\products\VS2017\vs_enterprise.exe --quiet --wait --norestart```
    * The --wait option will ensure the vs_enterprise.exe process waits until the install is completed before returning a exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install.  If you do not use --wait, the vs_enterprise.exe process will exit before the install is complete and it will not return an accurate exit code that represents the state of the install operation.

  #### Error codes
  Depending on the result of the operation, the `%ERRORLEVEL%` environment variable will be set to one of the following values:
  
  | **Value** | **Result** |
  | --------- | ---------- |
  | 0 | Operation completed successfully |
  | 3010 | Operation completed successfully, but install requires reboot before it can be used |
  | Other | Failure condition occurred - check the logs for more information |
    
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
* To refresh your local layout folder so that it includes the latest updates, run the same ```--layout``` command you ran when initially creating the layout. Make sure to point to the same folder that you used before with the same customizations (e.g. specific workloads and languages); this way, only those components that have been updated since you last ran ```--layout``` will be downloaded.  If you host a layout on a file share, it is recommended that you update a private copy of the layout (e.g. c:\vs2017offline) and after all of the updated content is downloaded, copy it to your file share (e.g. \\\\MyServer\products\VS2017).  If you don't do this, there is a greater chance that any users running setup while the layout is being updated may not be able to get all of the content from the layout since it is not completely updated.
* To update a Visual Studio instance that you installed from an offline installation folder, run the Visual Studio Installer, and then click **Update**.  For details on how to controll when update notifications are presented to users, see [Special considerations for installing Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md).

### How to create a layout for a previous Visual Studio 2017 release
**Note**: The VS 2017 bootstrappers available on http://www.visualstudio.com will download and install the latest VS 2017 release available whenever they are run. If you download a VS bootstrapper today and run it 6 months from now, it will install the VS 2017 release that is available at that later time. If you create a layout, installing VS from that layout will install the specific version of VS that exists in the layout. Even though a newer version may exist online, you will get the version of VS that is in the layout.

If you need to create a layout for an older version of Visual Studio 2017, you can go to https://my.visualstudio.com to download "fixed" versions of the Visual Studio 2017 bootstrappers for supported versions, which will allow you to create a network install layout for that older version. 

### How to get support for your offline installer
If you experience a problem with your offline installation, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool. When you use this tool, you can send us the telemetry and logs we need to help us diagnose and fix the problem.

We have other support options available, too. For a list of those, see our [Talk to us](../ide/how-to-report-a-problem-with-visual-studio-2017.md) page.


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
