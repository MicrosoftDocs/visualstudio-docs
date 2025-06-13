---
title: "Debug Unreal Engine Blueprints in Visual Studio"
description: "Learn how to use Visual Studio's Blueprint debugger to debug Unreal Engine Blueprint code alongside C++ code."
ms.date: 06/13/2025
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
---

# Debug Unreal Engine Blueprints in Visual Studio

Visual Studio enhances the debugging experience by displaying information about Unreal Engine Blueprints in the call stack and locals variable windows. This feature allows you to debug Blueprint code alongside your C++ code in a unified debugging session.

The Blueprint debugger provides:

- **Integrated call stack**: Blueprint frames appear in the same call stack as C++ frames
- **Variable inspection**: View Blueprint node pins and their values in the Locals window
- **Unified debugging experience**: Debug Blueprint and C++ code in the same session

## Prerequisites

- Visual Studio 2022 with the **Game development with C++** workload and Visual Studio debugger tools for Unreal Engine Blueprints component installed
- Unreal Engine installed with debug symbols
- An Unreal Engine project that contains both C++ code and Blueprints

## Installation

Run the Visual Studio Installer to ensure you have the required components installed for debugging Unreal Engine Blueprints. For more information on installing Visual Studio Tools for Unreal Engine, see [Get started with Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md).

Ensure on the **Workloads** pane that the **Game development with C++** workload is installed:

:::image type="content" source="../media/unreal-workload.png" alt-text="Screenshot of the Visual Studio installer. The Game development with C++ workload is selected. In the installation details pane, Visual Studio Tools for Unreal Engine, Visual Studio debugger tools for Unreal Engine Blueprints, HSL Tools, And Windows 11 SDK are selected." lightbox="../media/unreal-workload.png":::

On the **Individual components** pane, also ensure that the Visual Studio debugger tools for Unreal Engine Blueprints is installed:

:::image type="content" source="../media/vs-unreal-engine-install-blueprints-debug-tools.png" alt-text="Screenshot of the Visual Studio installer Individual components pane. Visual Studio debugger tools for Unreal Engine Blueprints is selected.":::

### Install Unreal Engine debug symbols

Install debug symbols for each version of Unreal Engine you want to debug with Visual Studio:

1. Open the **Epic Games Launcher**.
1. Navigate to the **Unreal Engine** pane on the left and the **Library** pane at the top.
1. Select the dropdown menu for your engine version and select **Options**.

:::image type="content" source="../media/unreal-engine-engine-options.png" alt-text="Screenshot of the Epic Games installer. The Launch dropdown is selected and Options is highlighted.":::

1. In the options dialog, select **Editor symbols for debugging**.
1. Select **Apply** and wait for the download to complete.

:::image type="content" source="../media/unreal-engine-editor-symbols-for-debugging.png" alt-text="Screenshot of the Epic Games installation options. Editor symbols for debugging is selected.":::

## Set up a test project

To test the Blueprint debugger functionality, create a project that uses Blueprints and also has C++ code. The Unreal Engine **First Person** template works.

1. Open the Unreal Engine Editor and create a new **First Person Shooter** project.
1. Ensure that **C++** is selected.

:::image type="content" source="../media/unreal-engine-new-project-first-person.png" alt-text="Screenshot of the Unreal Engine editor new project dialog. First Person is selected and the BlueEpic Games installation options. Editor symbols for debugging is selected.":::

1. After the project is created, close all Unreal Editor instances.
1. Open the generated Visual Studio solution file (`.sln`).

## Debug Blueprints

Follow these steps to test Blueprint debugging:

1. In Visual Studio, locate the `AttachWeapon` method in your weapon component class. For example, if your named your project `FirstPerson`, it would be in the `FirstPersonWeaponComponent.cpp`.
1. Add a breakpoint at the start of the `AttachWeapon` method. This method is called when the player picks up a weapon in the game:

:::image type="content" source="../media/unreal-engine-attach-weapon-breakpoint.png" alt-text="Screenshot of the AttachWeapon() function in Visual Studio. A breakpoint is on the first line of the function.":::

1. In the Solution Configurations dropdown, select **Development Editor**. Compile and run to open the Unreal Editor.
1. In the Unreal Editor, select the green **Play** button to start the game.
1. In the game, move forward using the `W` key until you move into the weapon to trigger the breakpoint.
1. When the breakpoint is hit, examine the **Call Stack** window. You'll see Blueprint stack frames alongside your C++ stack frames.

:::image type="content" source="../media/unreal-engine-blueprint-callstack.png" alt-text="Screenshot of the callstack window in Visual Studio. The breakpoint in AttachWeapon() is at the top of the callstack. Two Blueprint entries are highlight in the callstack for BP_PickUp_Rifle::ExecuteUbergraph_BP_PickUp_Rifle and BP_PickUp_Rifle::BndEvt___BP_PickUp_Rifle_TP_PickUp_K2Node_ComponentBoundEvent_1_OnPickUp_DelegateSignature.":::

1. Double-click on the first Blueprint frame in the call stack.
1. Open the **Locals** window to view the variables associated with the Blueprint node. You can see the values of the Blueprint node pins:

:::image type="content" source="../media/unreal-engine-blueprint-locals-node-pins.png" alt-text="Screenshot of the locals window in Visual Studio. Blueprint information > Node Pins > Available pins is expanded to show the values of the Blueprint such as the EntryPoint, PickUpCharacter, HasRifle, and more.":::

## Known issues

- The Unreal Editor may suggest updating the VisualStudioTools plugin even after installation. This message can be ignored as the latest version with Blueprint debugger support may not yet be published to the plugin marketplace.

## Related articles

- [Visual Studio Tools for Unreal Engine overview](vs-tools-unreal-overview.md)
- [Get started with Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)
- [View Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)
