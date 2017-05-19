---
title: "Create a network-based installation of Visual Studio | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "05/19/2017"
ms.reviewer: "tims"
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

Commonly, an enterprise administrator will create a network install point for deployment to client workstations. We've designed Visual Studio 2017 to enable you to cache the files for the initial installation along with all product updates to a single folder (sometimes referred to as _creating a layout_), so that client workstations can use the same network location to manage their installation even if they haven't yet updated to the latest servicing update.

> [!NOTE]
> If you have multiple editions of Visual Studio in use within your enterprise (for example, both Visual Studio Professional and Visual Studio Enteprise), you'll need to create a separate network install share for each edition.

## Download the Visual Studio bootstrapper
**Download** the edition of Visual Studio you want. Make sure to click **Save**, and then click **Open folder**.

Your setup executable&mdash;or to be more specific, a bootstrapper file&mdash;will match one of the following.

|Edition | Download|
|-------------|-----------------------|
|Visual Studio Enterprise | [**vs_enterprise.exe**](https://aka.ms/vs/15/release/vs_enterprise.exe) |
|Visual Studio Professional | [**vs_professional.exe**](https://aka.ms/vs/15/release/vs_professional.exe) |
|Visual Studio Community | [**vs_community.exe**](https://aka.ms/vs/15/release/vs_community.exe) |

Other supported bootstrappers include [vs_buildtools.exe](https://aka.ms/vs/15/release/vs_buildtools.exe), [vs_feedbackclient.exe](https://aka.ms/vs/15/release/vs_feedbackclient.exe), [vs_teamexplorer.exe](https://aka.ms/vs/15/release/vs_teamexplorer.exe), [vs_testagent.exe](https://aka.ms/vs/15/release/vs_testagent.exe), [vs_testcontroller.exe](https://aka.ms/vs/15/release/vs_testcontroller.exe), and [vs_testprofessional.exe](https://aka.ms/vs/15/release/vs_testprofessional.exe).

## Create an offline installation folder
To create an offline installation with all languages and all features, use one of the commands from the following examples.

(Make sure that you run the command from your Download directory. Typically, that's `C:\Users\<username>\Downloads` on a computer that is running Windows 10).

- For Visual Studio Enterprise, run:
  ```
  vs_enterprise.exe --layout c:\vs2017offline
  ```
- For Visual Studio Professional, run:
  ```
  vs_professional.exe --layout c:\vs2017offline
  ```
- For Visual Studio Community, run:
  ```
  vs_community.exe --layout c:\vs2017offline
  ```

## Modify the response.json file
You can modify the response.json to set default values that will be used when setup is run.  For example, you can configure the `response.json` file to select a specific set of workloads selected automatically.
See [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md) for details.

## Copy the layout to a network share

Host the layout on a network share so it can be run from other machines.
* Example:<br>
```xcopy /e c:\vs2017offline \\server\products\VS2017```
    
## Customizing the network layout
There are several options you can use to customize your network layout. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md). This may be useful if you know that you are only going to deploy a subset of workloads to client workstations. Common command-line parameters for customizing the layout include:

 - ```--add``` to specify [workload or component IDs](workload-and-component-ids.md).  If `--add` is used, only those workloads and components specified with `--add` will be downloaded.  If `--add` is not used, all workload and components will be downloaded.
 - ```--includeRecommended``` to include all the recommended  components for the specified workload IDs
 - ```--includeOptional``` to include all the recommended and optional components for the specified workload IDs.
 - ```--lang``` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).
 
Here are a few examples of how to create a custom partial layout.

 - To download all workloads and components for only one language, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US```
 - To download all workloads and components for multiple languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US de-DE ja-JP```
 - To download one workload for all languages, run <br> ```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --includeRecommended```
 - To download two workloads and one optional component for three languages, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended --lang en-US de-DE ja-JP ```
 - To download two workloads and all of their recommended components, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended ```
 - To download two workloads and all of their recommended and optional components, run: <br>```vs_enterprise.exe --layout C:\vs2017offline --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeOptional ```


## Deploying from a network installation
Administrators may deploy Visual Studio onto client workstations as part of an installation script. Or, users who have administrator rights can run setup directly from the share to install Visual Studio on their machine.

- Users can install by running: <br>```\\server\products\VS2017\vs_enterprise.exe```
- Administrators can install in an unattended mode by running: <br>```\\server\products\VS2017\vs_enterprise.exe --quiet --wait --norestart```

> [!TIP]
> When executed as part of a batch file, the `--wait` option ensures that the `vs_enterprise.exe` process waits until the install is completed before returning a exit code. This is useful where an enterprise administrator wants to perform further actions on the completed install (for example, to [apply a product key to a successful installation](automatically-apply-product-keys-when-deploying-visual-studio.md)). where one needs to wait for the install to finish to handle the return code from that install.  If you do not use `--wait`, the vs_enterprise.exe process will exit before the install is complete and it will not return an accurate exit code that represents the state of the install operation.

### Error codes
If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable will be set to one of the following values:

  | **Value** | **Result** |
  | --------- | ---------- |
  | 0 | Operation completed successfully |
  | 3010 | Operation completed successfully, but install requires reboot before it can be used |
  | Other | Failure condition occurred - check the logs for more information |

## Updating a network install layout
As product updates become available, you may want to [update the network install layout](update-a-network-installation-of-visual-studio.md) to incorporate updated packages.

## How to create a layout for a previous Visual Studio 2017 release
The [published Visual Studio 2017 bootstrappers](https://www.visualstudio.com/vs/) will download and install the latest servicing release available at the time they are run. However, if you create a layout, installing Visual Studio from that layout will install the specific version that exists in the layout, even though a newer version may exist online.

We recommend and support the latest published servicing release of Visual Studio 2017. However, if you need to create a layout for an older version of Visual Studio 2017 for enterprise deployment, you can use the links below which will allow you to create a network install layout for that older version. These bootstrappers are "fixed" to a specific versioned release, so even if a later version of Visual Studio is published the layout will not be updated.

> [!NOTE]
> We do not support "fixed" bootstrappers for the Community edition of Visual Studio, since they are only designed to be used for deployment in an enterprise environment.

 | **Minor Version**     | **Visual Studio Professional**                                        | **Visual Studio Enterprise**                                      |
 | --------------------- | --------------------------------------------------------------------- | ----------------------------------------------------------------- |
 | 15.1 (build 26403.07) | [Professional](https://aka.ms/vs/15/release/15_1/vs_professional.exe) | [Enterprise](https://aka.ms/vs/15/release/15_1/vs_enterprise.exe) |
 | 15.0 (build 26228.12) | [Professional](https://aka.ms/vs/15/release/15_0/vs_professional.exe) | [Enterprise](https://aka.ms/vs/15/release/15_0/vs_enterprise.exe) |

> [!IMPORTANT]
> You should not install an older version of Visual Studio on top of a newer version of Visual Studio, as it may have unpredictable results. We do not test in-place installs of older releases over a newer instance.

### How to get support for your offline installer
If you experience a problem with your offline installation, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool. When you use this tool, we automatically receive the logs needed to help us diagnose and fix the problem.

We have other support options available, too. For a list of those, see our [Talk to us](../ide/how-to-report-a-problem-with-visual-studio-2017.md) page.

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
