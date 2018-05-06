---
title: "TF Version Control"
description: "Connecting to Team Foundation Server or Visual Studio Team Services with Team Foundation version control."
author: asb3993
ms.author: amburns
ms.date: 05/03/2018
ms.topic: article
ms.technology: vs-ide-install
ms.assetid: 52D3D26A-4D01-4FD1-AAA1-AE7D7BD39746
---

# Connecting to Team Fondation version control 

Visual Studio Team Services (VSTS) and Team Foundation Server (TFS) provide two models of version control: Git, which is distributed version control, and Team Foundation Version Control (TFVC), which is centralized version control. This article provides an overview and a starting point for using Team Foundation Version Control with Visual Studio for Mac.


> [!NOTE]
> **Note**: Team Foundation Version Control support is currently in preview and some functionality is not yet fully working. More changes still to come!

## Requirements

* Visual Studio for Mac version 7.5 or later.
* A Project in Visual Studio Team Services or Team Foundation Server, configured to use Team Foundation Version Control.

## Installation

From within Visual Studio for Mac, choose the **Visual Studio > Extensions...** menu. Search for "TF version control" and install the **Team Foundation Version Control** extension. Restart the IDE when prompted.

## Using the add-in

Once the extension is installed, select the **Version Control > Team Foundation Version Control > Connect to Team Foundation Version Control...** menu. 

<img src="images/add-remove-server.png" alt="Connect with a TFS Server" Width="600" />

Choose either Visual Studio Team Services or Team Foundation Server to get started:

<img src="images/choose-server-type.png" alt="Connect with a TFS Server" Width="600" />

Enter you credentials: 

<img src="images/login.png" alt="Connect with a TFS Server" Width="600" />

Then, choose the projects that you want to access: 

<img src="images/choose-projects.png" alt="Choose projects" Width="500" />

To continue, close the dialogs and then use the **Version Control > Team Foundation Version Control > Source Control Explorer** menu to browse source.

> [!WARNING]
> **Known issue**: In this preview release, the first time you open source controle explorer, you'll have to create a new workspace.

<img src="images/sourceexplorer.png" alt="Source Explorer" Width="800" />

From the Source Code Explorer, you can browse your source code on the server and perform a variety of actions :
- Manage Workspaces (Create, edit or delete).
- Navigate between project structure.
- Map projects.
- Get projects.
- Lock & Unlock files.
- Rename files.
- Delete files.
- Add new file.
- Check out.
- Check in.
- View history changes.
- Compare changes.

## Creating a new workspace
In the Source Control Explorer, click on the **Manage Workspaces** button. 

<img src="images/manage-workspaces.png" alt="Manage Workspaces" Width="600" />

Click on **Add** to create a new workspace.

<img src="images/create-workspace.png" alt="Create Workspace" Width="400" />

Provide a name for the workspace and then click **Add Working Folder** to map the project to a local folder on your computer.

When done, click OK, then close the Manage Workspaces dialog. Now, you're ready to get files though the Source Code Explorer and get started.

