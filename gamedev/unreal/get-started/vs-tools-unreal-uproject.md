---
title: "Open native Unreal Engine projects in Visual Studio"
description: "Learn how to work with native Unreal Engine projects from within Visual Studio"
ms.date: 10/30/2024
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to work in Visual Studio with native Unreal Engine projects so that I can use Visual Studio's features and tools to develop my game without having to switch back-and-forth between the Unreal Editor and Visual Studio.
---

# Open native Unreal Engine projects in Visual Studio

Visual Studio 2022 version 17.12 provides direct support for Unreal Engine projects.

Previously, before you could work with an Unreal Engine project in Visual Studio, you generated a Visual Studio solution from within the Unreal Editor, or by using the Unreal Build Tool (UBT). That process was cumbersome whenever a new asset was added from within the Unreal Editor, or by another team member, because the Visual Studio solution had to be regenerated to reflect the changes.

Now, with the direct support of the Unreal Engine project format (`.uproject`) in Visual Studio, you can now seamlessly switch between Visual Studio and the Unreal Engine editor. All changes are automatically synced.

Use Visual Studio Tools for Unreal Engine (UE) to open native Unreal Engine projects in Visual Studio. This integration enables seamless editing, debugging, and project file anagement without the repetitive and time-consuming process of generating and regenerating project files between Visual Studio and Unreal Engine.

## Prerequisites

The following must be installed:

- Visual Studio version 17.12 or later.
- Unreal Engine version 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- JTW Include the Uproject support option when installing Visual Studio (will this be necessary out of preview?) 
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game and configure it to use Visual Studio Tools for Unreal Engine.

## Open a native Unreal Engine project in Visual Studio

There are two ways to open a native Unreal Engine project in Visual Studio: by opening a folder, which assumes that there is only one project (`.uproject`) in the folder. Or via **File** > **Open** > **Unreal Engine Project...** to pick a `.uproject` to open. This article uses the open folder approach with the Lyra game project.

1. In Visual Studio, open the **File** menu, and then select **Open** > **Open Folder**.
1. Navigate to the directory where your Unreal Engine project is located. In this example, the Lyra game project is located in `C:\UE\LyraStarterGame`.

## Editing and debugging in Visual Studio

Add a class and see it in the Unreal Engine Editor
Add a function and debug into it?

## Project structure

Understanding the workspace and project files
Filtering views to show relevant files
Managing configurations and properties
Editing target properties
Advanced configuration with JSON files

## Source Control Integration

Recommended practices for source control
Handling binary assets and large files
Integration with Perforce and other version control systems

## Advanced Usage

Fine-tuning for performance and efficiency
Customizing include paths and project settings
Debugging engine-level code

## Common issues and solutions

Currently, your engine and game code must be on the same drive. Please send us feedback if your particular use case requires engine and game code to be on different drives.

Folders with multiple `.uproject` files in the same folder are not supported. To open a specific `.uproject` file when there are multiple project files in the same folder, use **File** > **Open** > **Unreal Engine project**.

If you open an Unreal Engine project via **File** > **Open** > **Unreal Engine project**, the project won't appear in Visual Studio's **File** > **Recent Projects and Solutions** list. If you open the Unreal Engine project via **File** > **Open Folder**, the opened Unreal Engine project will appear in the recently opened projects list.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)