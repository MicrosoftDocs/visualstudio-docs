---
title: "Update a network-based installation of Visual Studio | Microsoft Docs"
description: "Learn how to update a network-based Visual Studio installation by using the --layout command"
ms.date: "08/14/2017"
ms.reviewer: "tims"
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 1AF69C0E-0AC9-451B-845D-AE4EDBCEA65C
author: "timsneath"
ms.author: "tims"
manager: "ghogen"
---
# Update a network-based installation of Visual Studio

It's possible to update a network installation layout of Visual Studio with the latest product updates so that it can be used both as an installation point for the latest update of Visual Studio and also to maintain installations that are already deployed to client workstations.

## How to update a network layout
To refresh your network install share so that it includes the latest updates, run the same `--layout` command that you ran when you first created the layout. When you do this, it will incrementally download updated packages.

If you selected a partial layout when you first created the network layout, make sure that you use the same command-line parameters that you used when you first created the network install layout (in other words, the same workloads and languages). If you choose different options, then the second `--layout` command won't update packages that weren't specified the second time.

If you host a layout on a file share, you should update a private copy of the layout (for example, `c:\vs2017offline`) and after all of the updated content is downloaded, copy it to your file share (for example, `\\server\products\VS2017`).  If you don't do this, there is a greater chance that any users running setup while the layout is being updated may not be able to get all of the content from the layout because it is not completely updated.

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


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
