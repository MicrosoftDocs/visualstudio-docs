---
title: "Update a network-based installation of Visual Studio | Microsoft Docs"
description: "Learn how to update a network-based Visual Studio installation by using the --layout command"
ms.date: "08/14/2017"
ms.reviewer: "tims"
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 1AF69C0E-0AC9-451B-845D-AE4EDBCEA65C
author: "timsneath"
ms.author: "tglee"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Update a network-based installation of Visual Studio

It's possible to update a network installation layout of Visual Studio with the latest product updates so that it can be used both as an installation point for the latest update of Visual Studio and also to maintain installations that are already deployed to client workstations.

## How to update a network layout
To refresh your network install share so that it includes the latest updates, run the --layout command to incrementally download updated packages.

If you selected a partial layout when you first created the network layout, those settings are saved.  Any future layout commands use the previous options plus any new options that you specify.  (This is new in 15.3.)  If you are using a layout of an older version, you should use the same command-line parameters that you used when you first created the network install layout (in other words, the same workloads and languages) to update its content.

If you host a layout on a file share, you should update a private copy of the layout (for example, c:\vs2017offline) and then, after all of the updated content is downloaded, copy it to your file share (for example, \\server\products\VS2017). If you don't do this, there is a greater chance that any users who run Setup while you are updating the layout might not be able to get all of the content from the layout because it is not yet completely updated.

Let's walk through how to create and then update a layout:

* First, here's an example of how to create a layout with one workload for English only:

  ```
  vs_enterprise.exe --layout c:\VS2017Layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
  ```

* Here's how to update that same layout to a newer version. You don't have to specify any additional command-line parameters. The previous settings were saved and will be used by any subsequent layout commands in this layout folder.  

  ```
  vs_enterprise.exe --layout c:\VS2017Layout  
  ```

* Here's how to update your layout to a newer version in an unattended manner. The layout operation runs the setup process in a new console window. The window is left open so users can see the final result and a summary of any errors that might have occurred. If you are performing a layout operation in an unattended manner (for example, you have a script that is regularly run to update your layout to the latest version), then use the `--passive` parameter and the process will automatically close the window.

  ```
  vs_enterprise.exe --layout c:\VS2017Layout --passive
  ```

* Here's how to add an additional workload and localized language.  (This command adds the Azure workload.)  Now both Managed Desktop and Azure are included in this layout.  The language resources for English and German are also included for all these workloads.  And, the layout is updated to the latest available version.

  ```
  vs_enterprise.exe --layout c:\VS2017Layout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
  ```

* And finally, here's how to add an additional workload and localized language without updating the version. (This command adds the ASP.NET & Web workload.)  Now the Managed Desktop, Azure, and ASP.NET & Web workloads are included in this layout.  The language resources for English, German, and French are also included for all these workloads.  However, the layout was not updated to the latest available version when this command was run.  It remains at the existing version.

  ```
  vs_enterprise.exe --layout c:\VS2017Layout --add Microsoft.VisualStudio.Workload.NetWeb --lang fr-FR --keepLayoutVersion
  ```

## How to deploy an update to client machines
Depending on how your network environment is configured, an update can either be deployed by an enterprise administrator or initiated from a client machine.

* Users can update a Visual Studio instance that was installed from an offline installation folder:
  * Run the Visual Studio Installer.
  * Then, click **Update**.

* Administrators can update client deployments of Visual Studio without any user interaction with two separate commands:
  * First, update the Visual Studio installer: <br>```vs_enterprise.exe --quiet --update```
  * Then, update the Visual Studio application itself: <br>```vs_enterprise.exe update --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" --quiet --wait --norestart```

> [!NOTE]
> Use the [vswhere.exe command](tools-for-managing-visual-studio-instances.md) to identify the install path of an existing instance of Visual Studio on a client machine.

> [!TIP]
> For details on how to control when update notifications are presented to users, see [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md).

## How to verify a layout
Use `--verify` to perform verification on the offline cache supplied. It checks if packages files are either missing or invalid. At the end of the verification, it prints the list of missing files and invalid files.

```
vs_enterprise.exe --layout <layoutDir> --verify
```

The vs_enterprise.exe can be invoked inside the layoutDir.


> [!NOTE]
> Some important metadata files that are needed by the `--verify` option must be in the layout offline cache. If these metadata files are missing, "--verify" cannot run and Setup gives you an error. If you experience this error, re-create a new offline layout to a different folder (or to the same offline cache folder. To so do, run the same layout command that you used to create the initial offline layout. For example, `Vs_enterprise.exe --layout <layoutDir>`.

Microsoft ships updates to Visual Studio periodically, so the new layout that you create might not be the same version as the initial layout.  

## How to fix a layout
Use `--fix` to perform the same verification as `--verify` and also try to fix the identified issues. The `--fix` process needs an Internet connection, so make sure your machine is connected to the Internet before you invoke `--fix`.

```
vs_enterprise.exe --layout <layoutDir> --fix
```

The vs_enterprise.exe can be invoked inside the layoutDir.

## How to remove older versions from a layout
After you perform layout updates to an offline cache, the layout cache folder may have some obsolete packages that are no longer needed by the latest Visual Studio installation. You can use the `--clean` option to remove obsolete packages from an offline cache folder.

To do this, you'll need the file path(s) to catalog manifest(s) that contain those obsolete packages. You can find the catalog manifests in an "Archive" folder in the offline layout cache. They are saved there when you update a layout. In the "Archive" folder, there is one or more "GUID" named folders, each of which contains an obsolete catalog manifest. The number of "GUID" folders should be the same as the number of updates made to your offline cache.

A few files are saved inside each "GUID" folder. The two files of most interest are a "catalog.json" file and a "version.txt" file. The "catalog.json" file is the obsolete catalog manifest you'll need to pass to the `--clean` option. The other version.txt file contains the version of this obsolete catalog manifest. Based on the version number, you can decide whether you want to remove obsolete packages from this catalog manifest. You can do the same as you go through the other "GUID" folders. After you make the decision on the catalog(s) you want to clean, run the `--clean` command by supplying the files paths to these catalogs.  

Here are a few examples of how to use the --clean option:   

```
vs_enterprise.exe --layout <layoutDir> --clean <file-path-of-catalog1> <file-path-of-catalog2> …
```

```
vs_enterprise.exe --layout <layoutDir> --clean <file-path-of-catalog1> --clean <file-path-of-catalog2> …
```

You can also invoke vs_enterprise.exe inside the &lt;layoutDir&gt;. Here's an example:

```	 
c:\VS2017Layout\vs_enterprise.exe --layout c:\VS2017Layout --clean c:\VS2017Layout\Archive\1cd70189-fc55-4583-8ad8-a2711e928325\Catalog.json --clean c:\VS2017Layout\Archive\d420889f-6aad-4ba4-99e4-ed7833795a10\Catalog.json
```	 

When you execute this command, Setup analyzes your offline cache folder to find the list of files that it will remove. You will then have a chance to review the files that are going to be deleted and confirm the deletions.

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
