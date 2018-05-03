---
title: "TF Version Control"
description: "Using Azure functions in Visual Studio for Mac."
author: asb3993
ms.author: amburns
ms.date: 05/03/2018
ms.topic: article
ms.technology: vs-ide-install
ms.assetid: 52D3D26A-4D01-4FD1-AAA1-AE7D7BD39746
---

# Visual Studio for macOS TFS Add-in

This article introduces the Visual Studio for Mac add-in for interacting with Microsoft Team Foundation Server and Visual Studio Team Services.

## Requirements

This add-in works on Visual Studio for Mac version 7.5 and above

## Installation

[Jordan: can you add information here?]

## Using the add-in

In Menu > Version Control section you will find the Team Foundation Server menu at the bottom. To start click on Connect to Server. 

<img src="images/add-remove-server.png" alt="Connect with a TFS Server" Width="600" />

Choose between VSTS or TFVC server:

<img src="images/choose-server-type.png" alt="Connect with a TFS Server" Width="600" />

Enter you credentials: 

<img src="images/login.png" alt="Connect with a TFS Server" Width="600" />

The following authentication modes are supported:
- OAuth
- Basic
- Ntlm

Choose the projects thsat you want to be connected to: 

<img src="images/choose-projects.png" alt="Choose projects" Width="500" />

To continue, open **Team Explorer** from **Menu > Version Control > Team Foundation Server > Team Explorer**. 

<img src="images/teamexplorerpad.png" alt="Team Explorer" Width="300" />

Frome here, you can access:
- SourceControlExplorer
- WorkItems

Double click on Source Control option to open SourceControlExplorerView. 

<img src="images/sourceexplorer.png" alt="Source Explorer" Width="800" />

Team Foundation Version Control (TFVC) is a centralized version control system. TFVC lets you do:
- Manage Workspaces (Create, edit or delete).
- Navigate between project structure.
- Map projects.
- Get projects.
- Lock & Unlock.
- Rename.
- Delete.
- Add new file.
- CheckOut.
- CheckIn.
- View history changes.
- Compare changes.

From "Manage" button we can create a manage workspaces. 

<img src="images/manage-workspaces.png" alt="Manage Workspaces" Width="600" />

And create a new one:

<img src="images/create-workspace.png" alt="Create Workspace" Width="400" />

After creating a workspace, the actions are available in a contextual menu.

<img src="images/sourceexplorer-menu.png" alt="Create Workspace" Width="600" />

To work witk WorkItems, double click in WorkItems to open WorkItemsView.

<img src="images/workitems.png" alt="Create Workspace" Width="600" />

The WorkItems actions are available in a contextual menu.

<img src="images/workitems-menu.png" alt="Create Workspace" Width="600" />