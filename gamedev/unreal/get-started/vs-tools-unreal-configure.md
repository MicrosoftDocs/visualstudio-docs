---
title: "Configure Visual Studio Tools for Unreal Engine"
description: "Learn how to use the Unreal Engine Integration Configuration dialog to set up and manage Visual Studio Tools for Unreal Engine features"
ms.date: 12/22/2025
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
---

# Configure Visual Studio Tools for Unreal Engine

Use the Unreal Engine Integration Configuration dialog to configure and manage all Visual Studio Tools for Unreal Engine. This dialog appears automatically when you open an Unreal Engine project in Visual Studio. You can also access it manually from the Visual Studio menu via **Project** > **Configure Tools for Unreal Engine**.

## Prerequisites

The following must be installed:

- Visual Studio version 17.10 or later
- Unreal Engine version 5 or later
- An Unreal Engine project opened in Visual Studio

## Open the configuration page

Open an Unreal Engine project in Visual Studio. The UE configuration page automatically appears when you first open an Unreal Engine project in Visual Studio unless the **Show on startup** checkbox is cleared. If it doesn't appear, from the Visual Studio main menu, choose **Project** > **Configure Tools for Unreal Engine**

:::image type="complex" source="../media/vs-unreal-engine-configuration-page.png" alt-text="A screenshot of the Unreal Engine project configuration page." lightbox="../media/vs-unreal-engine-configuration-page.png":::
The configuration page has a red/green status indicator and a refresh button for options such as Overall Configuration Status, Unreal Build Tool Status, Unreal Engine Targets, Blueprint Support, Visual Studio Integration Tool Status, and so on.
:::image-end:::

## Configuration sections

The Unreal Engine Integration Configuration page contains multiple sections, each responsible for configuring aspects of Visual Studio/Unreal Engine integration.

### Overall Configuration Status

Shows the overall status of Unreal Engine integration in Visual Studio. This section provides a quick summary of whether all components are properly configured. Icons show whether configuration is complete, needs attention, or has errors.

Select the run status check button (a circular arrow) to validate your configuration:

:::image type="content" source="../media/vs-unreal-engine-configuration-run-status-check-button.png" alt-text="Screenshot of the Overall Configuration Status section with the run status check button highlighted in Visual Studio.":::

A green indicator next to the run status check button means that everything is properly configured. A yellow indicator means that some components need attention. Open the **Output** window in Visual Studio (**View** > **Output**) for detailed results of the status check. 

### Customize Project View

Customizes how Unreal Engine projects and files appear in the Visual Studio **Solution Explorer**.

Use the dropdown to select project view settings optimized for your development workflow such as a game development view or an engine development view. You can change which project files and engine files to exclude from the Solution Explorer view, which shared include paths to exclude from IntelliSense, and so on. For more information, see [Edit project settings](vs-tools-unreal-uproject.md#edit-project-settings).

### Unreal Build Tool Status

Manages the integration with Unreal Engine's build system and workspace generation. It indicates whether the build tool integration is up to date and properly configured. Update the workspace generator from this section.

### Unreal Engine Targets

This section manages target-configuration-platform combinations.

- **Target** dropdown: Select from available targets. For example, for the Lyra project, choose from **`LyraClient`**, **`LyraGame`**, **`LyraServer`**, or **`LyraEditor`**.
- **Configuration** dropdown: Choose the build configuration. For example, in the Lyra project, **`DebugGame`** builds full debugging symbols, **`Development`** builds some debugging symbols but includes compiler optimizations for performance, and **`Shipping`** creates a fully optimized release build with no debugging symbols.
- **Platform** dropdown: Select the target platform, such as **`Win64`**.
- **Add** button: Create the target-configuration-platform combination you have selected. It appears in the list of targets.
- **Remove selected targets** button: Deletes the selected target-configuration-platform combination from the list of targets.
- **Generate Targets** button: Creates the selected target-configuration-platform combinations so that you can build them.

:::image type="content" source="../media/vs-unreal-engine-targets-configuration.png" alt-text="Screenshot of the Unreal Engine Targets configuration section. The target dropdown is set to LyraGame. The Configuration dropdown is DebugGame. The Platform dropdown is Win64. The Add, Generate Targets, and Remove selected targets buttons are highlighted. The checkbox next to the target LyraEditor is selected.":::

### Blueprint Support

Enables Visual Studio integration with Unreal Engine Blueprints so you can view Blueprint information in the Visual Studio debugger. You can also find Blueprint references in the project. Select the refresh button to validate that Blueprint support is properly configured.

### Visual Studio Integration Tool Status

This section refers to the status of the [Unreal Engine plugin for Visual Studio](https://github.com/microsoft/vc-ue-extensions/blob/main/README.md). It shows whether it is installed and active. This plugin is required for features such as viewing Blueprint pin values in the Visual Studio debugger and running Unreal Engine tests from Visual Studio.

If the plugin isn't installed, install it into your project or into the UE engine by following the instructions at [Install the Unreal Engine plugin for Visual Studio to UE](vs-tools-unreal-install.md#install-the-unreal-engine-plugin-for-visual-studio-to-ue).

:::image type="content" source="../media/vs-unreal-engine-integration-tool-status.png" alt-text="Screenshot of the VS Integration Tool Status section. The status says ready to install v2.7. The Install to Project and Install to Engine buttons are highlighted. The manual installation link is at the bottom.":::

### Unreal Engine Test Adapter Status

Configures Unreal Engine test discovery and execution integration so you can run and debug UE tests directly from Visual Studio. When configured, UE tests appear in the Visual Studio Test Explorer.

### Unreal Engine Naming Convention Checker Status

Enables code analysis for Unreal Engine naming conventions and coding standards so you can ensure your code adheres to UE guidelines. It provides warnings and suggestions for naming convention violations.

### HLSL Support for Unreal Engine Projects

Configures High-Level Shader Language (HLSL) support for shader development. It enables HLSL-specific features for HLSL shader files like syntax coloring, IntelliSense, and error detection. This support is intended to improve the experience of writing and editing shaders in Visual Studio. 

### UBA Visual configuration

The Unreal Build Accelerator (UBA) virtualizes and distributes C++ compilation, allowing compilers and tools to run on remote machines while appearing local. This integration allows you to monitor the build processes for your Unreal Engine projects. It's a UBA specific diagnostic view that Visual Studio exposes when UBA is enabled for Unreal Engine builds. It allows you to:

- View UBA task execution timelines
- Display remote compilation activity
- Visualize cache hits/misses
- Provide diagnostics when UBA fails or slows down
- Help you understand how UBA is accelerating (or not accelerating) your build

Configure UBA Visualizer integration to automatically display the UBA Visualizer window when building Unreal Engine projects that use the Unreal Build Accelerator.

## Run status checks

Most sections include a status check feature:

1. Look for the message "Need to run status check"
1. Select the refresh icon to run the status check
1. Wait for the validation to complete. A green checkmark indicates that the section is properly configured. A yellow warning icon indicates that attention is needed.
1. Address any issues identified by the status check. High level messages appear in the section. Some tools provide additional information in the Visual Studio **Output** window.

## Troubleshooting

If you encounter issues with the configuration:

- **Refresh status**: Use the refresh icon in the top-right corner of the dialog
- **Run individual checks**: Validate each section separately to isolate problems
- **Check prerequisites**: Ensure all required components are installed
- **Restart Visual Studio**: Close and reopen Visual Studio if changes don't take effect
- **Manual installation**: Use the manual installation links if automatic installation fails

## Next steps

After configuring Visual Studio Tools for Unreal Engine:

- [Use Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)
- [View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)
- [Debug Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-blueprint-debugger.md)
- [View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)
