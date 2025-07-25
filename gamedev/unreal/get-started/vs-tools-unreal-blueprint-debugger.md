---
title: "Debug Unreal Engine Blueprints in Visual Studio"
description: "Learn how to use Visual Studio's Blueprint debugger to debug Unreal Engine Blueprint code alongside C++ code."
ms.date: 07/01/2025
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
ai-usage: ai-assisted

#customer intent: As an Unreal Engine developer, I want to debug Blueprint code alongside my c++ code in Visual Studio.
---

# Debug Unreal Engine Blueprints in Visual Studio

Visual Studio improves debugging Unreal Engine projects by showing information about Unreal Engine Blueprints in the call stack and local variables windows. This feature lets you debug Blueprint code alongside your C++ code in one debugging session. With this functionality, you can easily track interactions between Blueprints and C++ code, making it easier to find and fix bugs.

Blueprints are a visual scripting technology in Unreal Engine used for rapid prototyping and development. Blueprints can call C++ code. In many cases, games are originally designed as Blueprints and later converted to C++ to improve performance. If you spend time converting Blueprints to C++, this new debugging functionality lets you analyze Blueprints and C++ code together. Which reduces the need to switch between Visual Studio and the Unreal Editor and provides a seamless debugging experience with less context-switching.

Visual Studio Blueprint debugger support provides:

- **Unified debugging experience**: Debug Blueprints and C++ code in the same session.
- **Integrated call stack**: Blueprint frames appear in the same call stack as C++ frames.
- **Variable inspection**: View Blueprint node pins and their values in the local variables window.
- **Breakpoint support**: Set breakpoints in C++ code called by Blueprints. This is useful when you have multiple Blueprints that can call C++ code, but you aren't sure which ones do and why.

## Prerequisites

- Unreal Engine installed along with debug symbols.
- Visual Studio 2022 17.14 or later with the **Game development with C++** workload installed.
- Visual Studio Tools for Unreal Engine installed into Visual Studio.
- Visual Studio debugger tools for Unreal Engine Blueprints installed into Visual Studio.
- Unreal Engine plugin for Visual Studio installed into Unreal Engine.

## Install prerequisites

Run the Visual Studio Installer to install the required components to debug Unreal Engine Blueprints. For more information about installing Visual Studio Tools for Unreal Engine, see [Get started with Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md).

On the **Workloads** pane, make sure the **Game development with C++** workload is installed, along with **Visual Studio debugger tools for Unreal Engine Blueprints** and **Visual Studio Tools for Unreal Engine**:

:::image type="content" source="../media/vs-installer-unreal-engine-workload.png" alt-text="Screenshot of the Visual Studio installer. The Game development with C++ workload is selected. In the installation details pane, Visual Studio Tools for Unreal Engine, Visual Studio debugger tools for Unreal Engine Blueprints, HSL Tools, And Windows 11 SDK are selected." lightbox="../media/vs-installer-unreal-engine-workload.png":::

### Install Unreal Engine debug symbols

Install debug symbols for each version of Unreal Engine you debug with Visual Studio:

1. Open the **Epic Games Launcher**.
1. Select the **Unreal Engine** pane and then the **Library** pane.
1. Select the dropdown menu for your engine version, then choose **Options**:

    :::image type="content" source="../media/unreal-engine-options.png" alt-text="Screenshot of the Epic Games installer. The Launch dropdown is selected and Options is highlighted.":::

1. In the options dialog, select **Editor symbols for debugging**:

    :::image type="content" source="../media/unreal-engine-editor-symbols-for-debugging.png" alt-text="Screenshot of the Epic Games installation options. Editor symbols for debugging is selected.":::

1. Select **Apply**, then wait for the download to finish.

### Install Unreal Engine plugin for Visual Studio

The Unreal Engine plugin for Visual Studio installs into Unreal Engine. Once installed, it's automatically activated when you open an Unreal Engine project in Visual Studio. This plugin provides integration between Unreal Engine and Visual Studio to support viewing Blueprint node pin values in the Visual Studio debugger local variables window.

For manual installation instructions, see [Unreal Engine plugin for Visual Studio](https://github.com/microsoft/vc-ue-extensions).

If you have an Unreal Engine project that you can open in Visual Studio, another way to install the plugin is in Visual Studio via the Unreal Engine Configuration window:

- With an Unreal Engine project opened in Visual Studio, select **Project** > **Configure Tools for Unreal Engine** to open the **Unreal Engine Integration Configuration** window.
- In the **Visual Studio Integration Tool Status** section, select **Install to Project** or **Install to Engine** as meets your needs.

If you don't see the install buttons, choose the refresh icon to refresh the status. If you need to install the plugin manually, select the **Manual installation instructions** link to open the [Unreal Engine plugin for Visual Studio](https://github.com/microsoft/vc-ue-extensions/blob/main/README.md) page, which contains installation instructions.

:::image type="content" source="../media/vs-unreal-engine-configuration-page-plugin.png" alt-text="Screenshot of the Unreal Engine Integration Configuration window. In the Visual Studio Integration Tool Status section, the refresh, Install to Project, and Install to Engine buttons are highlighted. The Manual installation instructions link is also highlighted.":::

## Set up a test project

To test the Blueprint debugger functionality, create a project that contains Blueprints and C++ code. The Unreal Engine **First Person** template works well.

1. Open the Unreal Engine Editor and create a new **First Person** project.
1. Ensure that **C++** is selected:

    :::image type="content" source="../media/unreal-engine-new-project-first-person.png" alt-text="Screenshot of the Unreal Engine editor new project dialog. First Person is selected, and the BlueEpic Games installation options. Editor symbols for debugging is selected.":::

1. After creating the project, close all Unreal Editor instances.
1. In Visual Studio, open the generated Visual Studio solution file (*.sln*).

## Debug Blueprints

Follow these steps to set a breakpoint, inspect a Blueprint function, and view its node pin values:

1. In Visual Studio, locate the `AttachWeapon` method in the weapon component class. For example, if you named your project `FirstPerson`, the function would be in the file `FirstPersonWeaponComponent.cpp`.
1. Add a breakpoint at the start of the `AttachWeapon` method. This method is called when the player picks up a weapon in the game:

    :::image type="content" source="../media/vs-unreal-engine-attach-weapon-breakpoint.png" alt-text="Screenshot of the AttachWeapon function in Visual Studio. A breakpoint is on the first line of the function." lightbox="../media/vs-unreal-engine-attach-weapon-breakpoint.png":::

1. In the Visual Studio **Solution Configuration** dropdown, select **Development Editor**:

    :::image type="content" source="../media/vs-unreal-engine-select-configuration.png" alt-text="Screenshot of the Visual Studio solution configuration dropdown. Development Editor is selected.":::

1. In Visual Studio, compile and run the project to open the Unreal Editor.
1. In the Unreal Editor, select the green **Play** button to start the game.
1. In the running game, press the <kbd>W</kbd> key to move forward until you collide with the weapon and trigger the breakpoint.
1. When the breakpoint is hit, examine the **Call stack** window. Blueprint stack frames appear among your C++ stack frames:

    :::image type="content" source="../media/vs-unreal-engine-blueprint-call-stack.png" alt-text="Screenshot of the call stack window in Visual Studio. The breakpoint in AttachWeapon is at the top of the call stack. Two Blueprint entries are highlighted in the call stack for BP_PickUp_Rifle::ExecuteUbergraph_BP_PickUp_Rifle and BP_PickUp_Rifle::BndEvt___BP_PickUp_Rifle_TP_PickUp_K2Node_ComponentBoundEvent_1_OnPickUp_DelegateSignature." lightbox="../media/vs-unreal-engine-blueprint-call-stack.png":::

1. Double-click the first Blueprint frame in the call stack.
1. Open the **Locals** window to view the variables associated with the Blueprint node. You can see the values of the Blueprint node pins:

    :::image type="content" source="../media/vs-unreal-engine-blueprint-locals-node-pins.png" alt-text="Screenshot of the locals window in Visual Studio. Blueprint information > Node Pins > Available pins is expanded to show the values of the Blueprint such as the EntryPoint, PickUpCharacter, HasRifle, and more." lightbox="../media/vs-unreal-engine-blueprint-locals-node-pins.png":::

## Summary

The Visual Studio Blueprint debugger provides a seamless debugging experience that bridges the gap between C++ and Blueprint code in Unreal Engine projects. This integrated approach allows you to:

- Track execution flow from C++ to Blueprints and back.
- Inspect Blueprint node pin values and C++ variables.
- Step through Blueprint execution frames in the same debugging session as C++ code.

This unified debugging experience helps resolve issues efficiently across both coding paradigms, eliminating the need to switch between different debugging tools.

## Related articles

- [Visual Studio Tools for Unreal Engine overview](vs-tools-unreal-overview.md)
- [Get started with Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)
- [View Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)
